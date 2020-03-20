using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANGE.Media.Entity
{
    public class client_server_config
    {
        /// <summary>
        /// 客户端id
        /// </summary>
        public int client_id { set; get; } = 1;
        /// <summary>
        /// 客户端ip
        /// </summary>
        public string client_ip { set; get; } = "192.168.3.3";
        /// <summary>
        /// 采集路径
        /// </summary>
        public string collect_path { set; get; } = "D:/";
        /// <summary>
        /// 备份路径
        /// </summary>
        public string backup_path { set; get; } = "F:/";
        /// <summary>
        /// 预警最大容量GB
        /// </summary>E:\DONET_CODE\ZFJLY\Project\HANGE.Common\FileHelper.cs
        public int warn_limit_size { set; get; } = 20;
        /// <summary>
        /// 存储最大天数
        /// </summary>
        public int store_max_days { set; get; } = 999;
        /// <summary>
        /// 上传ftp id
        /// </summary>
        public int upload_ftp_id { set; get; } = 1;

        public string start_time { set; get; } = "00:00:00";

        public string end_time { set; get; } = "23:59:59";
        /// <summary>
        /// 上传带宽M
        /// </summary>
        public int upload_bandwidth { set; get; } = 10;
        /// <summary>
        /// 上传并行设置
        /// </summary>
        public int upload_parallel { set; get; } = 8;
        /// <summary>
        /// FTP服务名称
        /// </summary>
        public string server_name { set; get; } = "FTPServer";


    }
}
