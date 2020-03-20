using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HANGE.Media.Form;
using HANGE.Media.Mysql;
using Ftp = HANGE.Media.FTP;
namespace HANGE.Media
{
    public partial class CollectForm
    {
        private static ConcurrentDictionary<int, Entity.Pe_video_list> diction_upload = new ConcurrentDictionary<int, Entity.Pe_video_list>();
        private static List<Ftp.FtpHelper> ftp_client_list = new List<Ftp.FtpHelper>();
        /// <summary>
        /// ftp上传主目录如 media3 不包含前后路径符号/
        /// </summary>
        private static string ftp_server_mainpath;
        private bool is_upload_copying = false;
        //private static string uploadPath = "upload";
        private void update_upload_txt(string outinfo)
        {
            this.txt_upload.Text += "-----" + DateTime.Now.ToString() + outinfo + Environment.NewLine;
        }
        /// <summary>
        /// 初始化ftp信息
        /// </summary>
        /// <param name="server"></param>
        private void initFtp(Entity.Pe_serverinfo server)
        {
            FTP.FtpConfig ftpConfig = new Ftp.FtpConfig()
            {
                str_FtpUri = server.Serverip,
                int_FtpPort = (int)server.Port,
                str_FtpUserID = server.Ftpusername,
                str_FtpPassword = server.Pwd,
                int_RetryTimes = 3
            };
            ftp_server_mainpath = server.Path.ToLower().Replace($"http://{server.Serverip}/", "");
            if (ftp_server_mainpath.EndsWith("/"))
            {
                ftp_server_mainpath = ftp_server_mainpath.Substring(0, ftp_server_mainpath.Length - 1);
            }
            for (int i = 0; i < limit_upload_count; i++)
            {
                ftp_client_list.Add(new Ftp.FtpHelper(ftpConfig));
            }
        }

        /// <summary>
        /// 收集需要上传的文件列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_collect_upload_Tick(object sender, EventArgs e)
        {
            if (isupload)
            {
                if (server_Config != null)
                {
                    //string copy_path = server_Config.backup_path;
                    //copy_path = copy_path.EndsWith("/") ? copy_path.Substring(0, copy_path.Length - 1) : copy_path;
                    //var directs = new System.IO.DirectoryInfo(collect_path).GetDirectories();
                    Task.Run(() =>
                    {
                        var need_upload_list = DBContext.DB.From<Entity.Pe_video_list>().Where(s => (s.servername == server_Config.client_ip && (int)HANGE.Media.Henum.HEnum.media_status.备份成功 == (int)s.is_flg)).ToList();
                        //List<Entity.Pe_video_list> list111 =  video_list_ball.GetModelListByClient(server_Config.client_ip, (int)HANGE.Media.Henum.HEnum.media_status.备份成功);
                        //this.Invoke(new delegate_updatetxt(update_bak_txt), "正在收集需要采集的信息");
                        int files_count = 0;
                        foreach (var pe_video in need_upload_list)
                        {
                            if (!diction_upload.ContainsKey(pe_video.id))
                            {
                                files_count++;
                                diction_upload.AddOrUpdate(pe_video.id, pe_video, (key, value) => value);
                            }
                        }
                        if (files_count > 0)
                        {
                            this.Invoke(new delegate_updatetxt(update_upload_txt), $"收集结束,此次收集文件【{files_count}】个");
                        }
                    });

                }
            }
        }
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_upload_Tick(object sender, EventArgs e)
        {
            if (isupload)
            {
                if (!is_upload_copying)
                {
                    if (ftp_client_list != null && ftp_client_list.Count >= limit_upload_count)
                    {
                        BlockingCollection<int> list = new BlockingCollection<int>();
                        int index = 0;
                        foreach (var dic in diction_upload)
                        {
                            if (index >= limit_upload_count)
                            {
                                break;
                            }
                            index++;
                            list.Add(dic.Key);
                        }
                        is_upload_copying = true;
                        Task.Run(() =>
                        {
                            System.Threading.Tasks.Parallel.ForEach(list, s =>
                            {
                                Entity.Pe_video_list pe_Video = diction_upload[s];
                                try
                                {
                                    int p_index = list.ToList().IndexOf(s);
                                    string filefullname = pe_Video.saveposition.Split('/').Last();
                                    Entity.media_info media_Info = new Entity.media_info(filefullname, "");
                                    string uploadPath = ftp_server_mainpath + media_Info.remote_path;
                                    List<string> upload_list = new List<string>();
                                    string filepath = pe_Video.macposition;

                                    upload_list.Add(filepath);
                                    if ("MP4|JPG".Contains(pe_Video.filetype))
                                    {
                                        string thm_file = filepath.Substring(0, filepath.LastIndexOf('.')) + ".THM.JPG";
                                        upload_list.Add(thm_file);
                                    }
                                    if (System.IO.File.Exists(filepath))
                                    {
                                        this.Invoke(new delegate_updatetxt(update_upload_txt), $"正在开始上传文件[{filepath}]");
                                        FluentFTP.FtpStatus status = ftp_client_list[p_index].UploadFiles(upload_list, uploadPath);
                                        this.Invoke(new delegate_updatetxt(update_upload_txt), $"上传文件[{status.ToString()}]");
                                        if (status.ToString() == FluentFTP.FtpStatus.Success.ToString())
                                        {
                                            this.Invoke(new delegate_updatetxt(update_upload_txt), $"上传文件成功[{filepath}]");
                                            var model = new Entity.Pe_video_list();
                                            model.playposition = media_Info.play_position;
                                            model.is_flg = (int)HANGE.Media.Henum.HEnum.media_status.上传成功;
                                            bool update = DBContext.DB.Update<Entity.Pe_video_list>(model, m => m.id == pe_Video.id) > 0;
                                            if (update)
                                            {
                                                //try
                                                //{
                                                //    bool result = diction_upload.TryRemove(s, out pe_Video);
                                                //    if (!result)
                                                //    {
                                                //        NLog.LogManager.GetCurrentClassLogger().Error(new Exception($"移除key[{s}]失败"));
                                                //    }
                                                //}
                                                //catch (Exception ex)
                                                //{
                                                //    NLog.LogManager.GetCurrentClassLogger().Error(ex);
                                                //}
                                            }
                                        }
                                    }
                                    else
                                    {
                                        this.Invoke(new delegate_updatetxt(update_upload_txt), $"文件[{filepath}]未找到请排查相关路径下文件");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    NLog.LogManager.GetCurrentClassLogger().Error(ex);
                                }
                                finally
                                {
                                    try
                                    {
                                        bool result = diction_upload.TryRemove(s, out pe_Video);
                                        if (!result)
                                        {
                                            NLog.LogManager.GetCurrentClassLogger().Error(new Exception($"移除key[{s}]失败"));
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        NLog.LogManager.GetCurrentClassLogger().Error(ex);
                                    }
                                }
                            });
                            is_upload_copying = false;
                        });

                    }
                }
            }
        }
    }
}
