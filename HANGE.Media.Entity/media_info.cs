using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANGE.Media.Entity
{
    /// <summary>
    /// 根据文件名称生成的文件操作类
    /// </summary>
    public class media_info
    {
        /// <summary>
        /// 机主编号
        /// </summary>
        public string host_code { set; get; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string host_body { set; get; }
        /// <summary>
        /// 文件名称不包含扩展名、机主编号、设备编号
        /// </summary>
        public string file_name { set; get; }
        /// <summary>
        /// 是否重要
        /// </summary>
        public bool is_imp { set; get; } = false;
        /// <summary>
        /// 当前日期段格式
        /// </summary>
        public string file_date { set; get; } = DateTime.Now.ToString("yyyyMMdd");
        /// <summary>
        /// 媒体类型不包含'.'，JPG\WAV\MP4
        /// </summary>
        public string file_type { set; get; }
        /// <summary>
        /// 本地保存路径最后一位不包含/
        /// </summary>
        public string local_bakup_path { set; get; }
        /// <summary>
        /// 输入文件全名
        /// </summary>

        public string media_full_filenam { set; get; }

        public media_info(string media_filename, string local_bakpath)
        {
            this.media_full_filenam = media_filename;
            this.local_bakup_path = local_bakpath.EndsWith("/") ? local_bakpath.Substring(0, local_bakpath.Length - 1) : local_bakpath;
            string file_extend = media_filename.Substring(media_filename.LastIndexOf('.') + 1).ToUpper();
            this.file_type = file_extend;
            string[] file_split = media_filename.Split('_');
            this.host_body = file_split[0];
            this.host_code = file_split[1];
            string filename_tmp = file_split[2];
            if (media_filename.ToUpper().Contains("_IMP"))
            {
                this.is_imp = true;
                this.file_name = filename_tmp;
            }
            else
            {
                this.is_imp = false;
                string tmp = file_split[2];
                this.file_name = filename_tmp.Substring(0, filename_tmp.IndexOf('.'));
            }
            file_date = DateTime.Now.ToString("yyyyMMdd");

        }
        /// <summary>
        /// 本地保存路径前面包含/
        /// </summary>
        public string save_position
        {
            get
            {
                return $"/{this.file_date}/{this.file_type}/{this.media_full_filenam}";
            }
        }
        /// <summary>
        /// 缩率图路径前面包含/
        /// </summary>
        public string thumb
        {
            get
            {
                return $"/{this.file_date}/{this.file_type}/{this.host_body}_{this.host_code}_{this.file_name}{(this.is_imp ? "_IMP" : "")}.THM.JPG";
            }
        }
        /// <summary>
        /// 远程服务器路径前面包含/
        /// </summary>
        public string play_position
        {
            get
            {
                return $"/{this.file_date}/{this.file_type}/{this.media_full_filenam}";
            }
        }
        /// <summary>
        /// 远程ftp上传目录,前面包含/
        /// </summary>
        public string remote_path
        {
            get
            {
                return $"/{this.file_date}/{this.file_type}";
            }
        }
        /// <summary>
        /// 本地保存全路径（D:/test/123.jpg)
        /// </summary>
        public string local_positon
        {
            get
            {
                return this.local_bakup_path + this.save_position;
            }
        }

    }
}
