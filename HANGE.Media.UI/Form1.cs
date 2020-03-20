using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ftp = HANGE.Media.FTP;

namespace HANGE.Media.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string path = System.Configuration.ConfigurationSettings.AppSettings["path"];
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择所在文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                this.textBox1.Text = dialog.SelectedPath;
                path = dialog.SelectedPath;
                //this.LoadingText = "处理中...";
                //this.LoadingDisplay = true;
                //Action<string> a = DaoRuData;
                //a.BeginInvoke(dialog.SelectedPath, asyncCallback, a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //private static FTP.FtpHelper ftpHelper;
        private static bool is_load = false;
        private int limit_count = 5;
        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke(new delegate_update(update_txt), $"初始化系统数据");
                System.Threading.Thread.Sleep(2000);
                FTP.FtpConfig ftpConfig = new Ftp.FtpConfig()
                {
                    str_FtpUri = "172.18.84.23",
                    int_FtpPort = 21,
                    str_FtpUserID = "admin",
                    str_FtpPassword = "Wc123hange",
                    int_RetryTimes = 3
                };
                for (int i = 0; i < limit_count; i++)
                {
                    ftp_client_list.Add(new Ftp.FtpHelper(ftpConfig));
                }
                //ftpHelper = new Ftp.FtpHelper(ftpConfig);
                is_load = true;
                this.Invoke(new delegate_update(update_txt), $"初始化系统数据成功");
            });
            this.timer1.Start();
            this.timer2.Start();
        }

        private static ConcurrentDictionary<string, string> diction = new ConcurrentDictionary<string, string>();
        private static List<Ftp.FtpHelper> ftp_client_list = new List<Ftp.FtpHelper>();
        private bool is_copying = false;
        private static string uploadPath = "upload";
        /// <summary>
        /// 收集文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (is_load)
            {

                if (!string.IsNullOrEmpty(path))
                {
                    string collect_path = path;
                    var directs = new System.IO.DirectoryInfo(collect_path).GetDirectories();
                    Task.Run(() =>
                    {
                        //this.Invoke(new delegate_updatetxt(update_bak_txt), "正在收集需要采集的信息");
                        int files_count = 0;
                        foreach (var direct in directs)
                        {
                            var files = direct.GetFiles();
                            foreach (var file in files)
                            {
                                if (!diction.ContainsKey(file.Name))
                                {
                                    files_count++;
                                    diction.AddOrUpdate(file.Name, file
                                        .FullName, (key, value) => value);
                                }
                            }
                        }
                        if (files_count > 0)
                        {
                            this.Invoke(new delegate_update(update_txt), $"收集结束,此次收集文件【{files_count}】个");
                        }
                    });

                }
            }
        }

        private delegate void delegate_update(string ouinfo);
        private void update_txt(string outinfo)
        {
            this.textBox2.Text += $"--------{DateTime.Now.ToString()}," + outinfo + Environment.NewLine;
        }
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (is_load)
            {
                if (!is_copying)
                {
                    if (ftp_client_list != null && ftp_client_list.Count >= limit_count)
                    {
                        BlockingCollection<string> list = new BlockingCollection<string>();
                        int index = 0;
                        foreach (var dic in diction)
                        {
                            if (index >= limit_count)
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
                                int p_index = list.ToList().IndexOf(s);
                                string filepath = diction[s];
                                if (!string.IsNullOrEmpty(filepath))
                                {
                                    if (!IsFileInUse(filepath))
                                    {
                                        this.Invoke(new delegate_update(update_txt), $"正在开始上传文件[{s}]");
                                        FluentFTP.FtpStatus status = ftp_client_list[p_index].UploadFile(filepath, uploadPath);
                                        this.Invoke(new delegate_update(update_txt), $"上传文件[{status.ToString()}]");
                                        if (status.ToString() == FluentFTP.FtpStatus.Success.ToString())
                                        {
                                            this.Invoke(new delegate_update(update_txt), $"正在开始删除文件[{s}]");
                                            (new System.IO.FileInfo(filepath)).Delete();
                                            this.Invoke(new delegate_update(update_txt), $"删除文件成功[{s}]");
                                            try
                                            {
                                                string value = "";
                                                bool result = diction.TryRemove(s, out value);
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

                                    }
                                }

                            });
                            is_copying = false;
                        });

                    }
                }
            }
        }


        public static bool IsFileInUse(string fileName)
        {
            bool inUse = true;
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read,
                FileShare.None);
                inUse = false;
            }
            catch
            {
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
            return inUse;//true表示正在使用,false没有使用  
        }
    }
}
