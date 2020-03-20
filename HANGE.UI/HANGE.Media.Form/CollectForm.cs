using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EASkins;
using EASkins.Controls;
using Entity = HANGE.Media.Entity;

namespace HANGE.Media
{
    public partial class CollectForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public CollectForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
        }

        private delegate void delegate_updatetxt(string outinfo);
        private void update_bak_txt(string outinfo)
        {
            this.txt_box_bk.Text += "-----" + DateTime.Now.ToString() + outinfo + Environment.NewLine;
        }



        /// <summary>
        /// 收集是否成功
        /// </summary>
        private static bool isload = false;
        /// <summary>
        /// 上传是否成功
        /// </summary>
        private static bool isupload = false;
        private static int limit_upload_count = 5;
        private Entity.client_server_config server_Config;
        private Entity.Pe_serverinfo pe_Serverinfo;
        ///// <summary>
        ///// ftp主目录
        ///// </summary>
        //private string ftp_server_mainpath;
        private void CollectForm_Load(object sender, EventArgs e)
        {

            this.timer_bak.Start();
            this.timer_init.Start();
            this.timer_collect.Start();
            this.timer_collect_upload.Start();
            this.timer_upload.Start();
            this.timer_create_dicect.Start();
            this.init_config();
        }

        private void init_config()
        {
            Task.Run(() =>
            {
                this.Invoke(new delegate_updatetxt(update_bak_txt), "正在请求配置信息");
                server_Config = GetLocalConfig.get_client_config();
                this.Invoke(new delegate_updatetxt(update_bak_txt), "已获取配置信息，马上加载界面");
                if (server_Config != null)
                {
                    this.Invoke(new delegate_updatetxt(update_upload_txt), "正在请求上传服务器配置信息");
                    pe_Serverinfo = GetLocalConfig.get_serverinfo(server_Config.server_name);
                    create_file_path(server_Config.backup_path);
                    limit_upload_count = server_Config.upload_parallel;
                    this.Invoke(new delegate_updatetxt(update_upload_txt), $"请求上传服务器配置信息成功，服务器名称[{pe_Serverinfo.Servername}]");
                    this.initFtp(pe_Serverinfo);
                    isupload = true;
                    isload = true;
                }

            });
        }

        private void create_file_path(string copy_path)
        {
            if (!copy_path.EndsWith("/"))
            {
                copy_path += "/";
            }
            if (!System.IO.Directory.Exists(copy_path))
            {
                System.IO.Directory.CreateDirectory(copy_path);
            }
            string file_extend = "WAV|JPG|MP4";
            string today = DateTime.Now.ToString("yyyyMMdd");
            string tomoro = DateTime.Now.AddDays(1).ToString("yyyyMMdd");
            List<string> create_path_list = new List<string>();
            foreach (var extend in file_extend.Split('|'))
            {
                create_path_list.Add(copy_path + today + "/" + extend);
                create_path_list.Add(copy_path + tomoro + "/" + extend);
            }
            foreach (var path in create_path_list)
            {
                System.IO.Directory.CreateDirectory(path);
            }

        }

        private static ConcurrentDictionary<string, media_collect_class> diction = new ConcurrentDictionary<string, media_collect_class>();
        class media_collect_class
        {
            public string full_path { set; get; }
            public Entity.Pe_device device { set; get; }
        }

        private void timer_init_Tick(object sender, EventArgs e)
        {
            if (isload)
            {
                //this.init_config();
            }
        }
        private bool is_copying = false;
        private void timer_bak_Tick(object sender, EventArgs e)
        {

            if (isload)
            {
                if (!is_copying)
                {
                    if (server_Config != null)
                    {
                        int parall_num = server_Config.upload_parallel;
                        string bak_path = server_Config.backup_path;
                        BlockingCollection<string> list = new BlockingCollection<string>();
                        int index = 0;
                        foreach (var dic in diction)
                        {
                            if (index > parall_num)
                            {
                                break;
                            }
                            index++;
                            list.Add(dic.Key);
                        }
                        is_copying = true;
                        Task.Run(() =>
                        {
                            System.Threading.Tasks.Parallel.ForEach(list, s =>
                            {
                                media_collect_class collect_Class = diction[s];
                                string filepath = collect_Class.full_path;
                                Entity.Pe_device device = collect_Class.device;
                                if (!string.IsNullOrEmpty(filepath))
                                {
                                    if (!FileUtils.IsFileInUse(filepath))
                                    {
                                        try
                                        {
                                            Entity.media_info media_Info = new Entity.media_info(s, server_Config.backup_path);
                                            LogManager.Info(new Entity.media_option_log()
                                            {
                                                client_ip = server_Config.client_ip,
                                                device_name = media_Info.host_body,
                                                media_filename = s,
                                                media_type = media_Info.file_type,
                                                option_info = $"开始复制文件：[{s}]",
                                                option_type = (int)HANGE.Media.Henum.HEnum.media_status.开始备份,
                                                user_code = media_Info.host_code
                                            });
                                            System.IO.FileInfo fileInfo = new System.IO.FileInfo(filepath);
                                            long file_size = fileInfo.Length;

                                            #region 新建上传实体类
                                            Entity.Pe_video_list video_list_model = new Entity.Pe_video_list()
                                            {
                                                filename = media_Info.host_code + "@" + media_Info.file_name,
                                                bfilename = device.Hostname + "@" + media_Info.file_name,
                                                createdate=  DateTime.ParseExact(media_Info.file_name, "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture).ToString("yyyy-MM-dd HH:mm:ss"),
                                                filelen = file_size.ToString(),
                                                playfilelen = file_size.ToString(),
                                                filetype = media_Info.file_type,
                                                hostname = device.Hostname,
                                                hostbody = device.Hostbody,
                                                hostcode = device.Hostcode,
                                                danwei = device.Danwei,
                                                onlyread = media_Info.is_imp ? 1 : 0,
                                                caserank = media_Info.is_imp ? "重要" : "",
                                                casetopic = "",
                                                note = "",
                                                serverurl = server_Config.server_name,
                                                servername = server_Config.client_ip,
                                                thumb = media_Info.thumb,
                                                saveposition = media_Info.save_position,
                                                playposition = "",
                                                macposition = media_Info.local_positon,
                                                creater = server_Config.client_ip,
                                                playtime = 1000,
                                                resolution = "1920*1080",
                                                filetotnum = 1,
                                                filetottime = 1000,
                                                is_flg = (int)HANGE.Media.Henum.HEnum.media_status.备份成功
                                            };
                                            var isexsit = HANGE.Media.Mysql.DBContext.DB.From<Entity.Pe_video_list>().Where(p => p.filename == video_list_model.filename).First();
                                            if (isexsit != null)
                                            {
                                                video_list_model.id = isexsit.id;
                                                HANGE.Media.Mysql.DBContext.DB.Update<Entity.Pe_video_list>(video_list_model);
                                            }
                                            else
                                            {
                                                HANGE.Media.Mysql.DBContext.DB.Insert<Entity.Pe_video_list>(video_list_model);
                                            }
                                            #endregion
                                            FileUtils.CopyOrRemoveFileFullPath(media_Info.local_positon, fileInfo);
                                            LogManager.Info(new Entity.media_option_log()
                                            {
                                                client_ip = server_Config.client_ip,
                                                device_name = media_Info.host_body,
                                                media_filename = s,
                                                media_type = media_Info.file_type,
                                                option_info = $"备份文件：[{s}]成功",
                                                option_type = (int)HANGE.Media.Henum.HEnum.media_status.备份成功,
                                                user_code = media_Info.host_code
                                            });
                                           
                                        }
                                        catch (Exception ex)
                                        {
                                            LogManager.Error(ex);
                                        }
                                    }
                                }
                                try
                                {
                                    bool result = diction.TryRemove(s, out collect_Class);
                                    if (!result)
                                    {
                                        LogManager.Error(new Exception($"移除key[{s}]失败"));
                                    }
                                }
                                catch (Exception ex)
                                {
                                    LogManager.Error(ex);
                                }

                            });
                            is_copying = false;
                        });

                    }
                }
            }
        }

        private void timer_collect_Tick(object sender, EventArgs e)
        {
            if (isload)
            {
                if (server_Config != null)
                {
                    string collect_path = server_Config.collect_path;
                    var directs = new System.IO.DirectoryInfo(collect_path).GetDirectories();
                    Task.Run(() =>
                    {
                        //this.Invoke(new delegate_updatetxt(update_bak_txt), "正在收集需要采集的信息");
                        int files_count = 0;
                        foreach (var direct in directs)
                        {
                            var pe_device_model = HANGE.Media.Mysql.DBContext.DB.From<Entity.Pe_device>().Where(s => s.Hostbody == direct.Name && s.State == "0").First();
                            if (pe_device_model == null)
                            {
                                continue;
                            }
                            var files = direct.GetFiles();
                            foreach (var file in files)
                            {
                                if (!FileUtils.is_need_file(file.Extension))
                                {
                                    continue;
                                }
                                if (!diction.ContainsKey(file.Name))
                                {
                                    files_count++;
                                    diction.AddOrUpdate(file.Name,
                                        (new media_collect_class()
                                        {
                                            full_path = file.FullName,
                                            device = pe_device_model
                                        }), (key, value) => value);
                                }
                            }
                        }
                        if (files_count > 0)
                        {
                            this.Invoke(new delegate_updatetxt(update_bak_txt), $"收集结束,此次收集文件【{files_count}】个");
                        }
                    });

                }
            }
        }

        private void timer_create_dicect_Tick(object sender, EventArgs e)
        {
            if (isload)
            {
                if (server_Config != null)
                {
                    this.create_file_path(server_Config.backup_path);
                }
            }
        }
    }
}
