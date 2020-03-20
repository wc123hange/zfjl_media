using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANGE.Media.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string default_from_path = Environment.CurrentDirectory;

        private void Btn_select_from_Click(object sender, EventArgs e)
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
                this.txt_from.Text = dialog.SelectedPath;

                //this.LoadingText = "处理中...";
                //this.LoadingDisplay = true;
                //Action<string> a = DaoRuData;
                //a.BeginInvoke(dialog.SelectedPath, asyncCallback, a);
            }
        }

        private void Btn_select_to_Click(object sender, EventArgs e)
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
                this.txt_to.Text = dialog.SelectedPath;

                //this.LoadingText = "处理中...";
                //this.LoadingDisplay = true;
                //Action<string> a = DaoRuData;
                //a.BeginInvoke(dialog.SelectedPath, asyncCallback, a);
            }
        }

        private static bool is_exec = false;
        private static Dictionary<string, string> dicObj = new Dictionary<string, string>();
        private static string from_txt_path = "";
        private static string to_txt_path = "";

        private void Btn_start_Click(object sender, EventArgs e)
        {
            this.txt_status.Text = "正在执行";
            is_exec = true;
            from_txt_path = this.txt_from.Text;
            to_txt_path = this.txt_to.Text;
            dicObj = new Dictionary<string, string>();
            this.timer1.Start();
        }

        private void Btn_end_Click(object sender, EventArgs e)
        {
            this.txt_status.Text = "停止执行";
            is_exec = false;
            from_txt_path = "";
            to_txt_path = "";
            this.timer1.Stop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //string from_txt_path = this.txt_from.Text;
            //string to_txt_path = this.txt_to.Text;
            if (from_txt_path == "" || to_txt_path == "")
            {
                return;
            }
            if (is_exec)
            {
                System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(from_txt_path);
                foreach (var file in directoryInfo.GetFiles())
                {
                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(file);
                    this.txt_out.Text += file.FullName + $"|{file.Extension}" + $"(文件状态为：{FileStatus.IsFileInUse(file.FullName)})" + Environment.NewLine;
                }

            }
        }
        private delegate void update_txt(string outstr);
        private void update_txt1(string outstr)
        {
            this.txt_out.Text += outstr;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            from_txt_path = this.txt_from.Text;
            to_txt_path = this.txt_to.Text;
            System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(from_txt_path);
            System.Threading.Tasks.Task.Run(() =>
            {
                System.Threading.Tasks.Parallel.ForEach(directoryInfo.GetFiles(), s =>
                {
                    this.Invoke(new update_txt(update_txt1), s.FullName + ";开始复制" + Environment.NewLine);
                    FileUtils.CopyOrRemoveFile(to_txt_path, s);
                    this.Invoke(new update_txt(update_txt1), s.FullName + ";复制成功" + Environment.NewLine);
                });
            });
            //foreach (var file in directoryInfo.GetFiles())
            //{
            //    this.txt_out.Text += file.Name + $"(文件状态为：{FileStatus.IsFileInUse(file.FullName)})" + Environment.NewLine;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var date = DateTime.ParseExact("20200320111110", "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture);
            //var result = HANGE.Media.Mysql.DBContext.media_context.From<Entity.Pe_video_list>().Where(s => (s.servername == "192.168.3.3" && 10 == (int)s.is_flg)).ToList();
            //var result = (new HANGE.Media.Form.video_list_ball()).GetModelListByClient("192.168.3.30", 10);
            //var list = new HANGE.Media.Mysql.pe_device_ball().Get_Devices("-");
            //string media_filename = this.textBox1.Text.Trim();
            //Entity.media_info media = new Entity.media_info(media_filename);
            //this.txt_out.Text = Newtonsoft.Json.JsonConvert.SerializeObject(media);
        }

        private delegate void delegate_update(int index);
        private void update(int index)
        {
            this.progressBar1.Value = index + 1;
        }
        private delegate void delegate_update_txt(string outinfo);
        private void update(string outinfo)
        {
            this.txt_out.Text = outinfo;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var devices = HANGE.Media.Mysql.DBContext.DB.From<Entity.Pe_device>().Top(6).ToList();
            string file_path = this.txt_from.Text;
            string filecopy = this.txt_from.Text + "/copyto";
            System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(file_path);
            var files = directoryInfo.GetFiles().Where(s => ".JPG.MP3.RMVB".Contains(s.Extension.ToUpper())).ToList();
            int lengcount = files.Count;
            this.progressBar1.Maximum = lengcount + 1;
            DateTime dateTime = DateTime.Now.AddDays(-1);
            Task.Run(() =>
            {
                foreach (var file in files)
                {
                    int indexof = files.IndexOf(file) % 6;
                    var device = devices[indexof];
                    string createpath = filecopy + "/" + device.Hostbody;
                    if (!System.IO.Directory.Exists(createpath))
                    {
                        System.IO.Directory.CreateDirectory(createpath);
                    }
                    string filename = $"{device.Hostbody }_{device.Hostcode}_{dateTime.AddMinutes(files.IndexOf(file)).ToString("yyyyMMddHHmmss")}";
                    if (indexof == 0)
                    {
                        filename += "_IMP";
                    }
                    if (file.Extension.ToUpper() == ".MP3")
                    {
                        filename += ".WAV";
                    }
                    else if (file.Extension.ToUpper() == ".RMVB")
                    {
                        filename += ".MP4";
                    }
                    else if (file.Extension.ToUpper() == ".JPG")
                    {
                        filename += ".JPG";
                    }
                    FileUtils.CopyToFromFullname(createpath + "/" + filename, file);
                    this.Invoke(new delegate_update(update), files.IndexOf(file));
                    if (files.IndexOf(file) == lengcount - 1)
                    {
                        this.Invoke(new delegate_update_txt(update), $"生成所有文件成功,共计生成文件【{lengcount}】个");
                    }
                }


            });

        }
    }
}
