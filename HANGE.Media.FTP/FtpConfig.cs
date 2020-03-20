using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANGE.Media.FTP
{
    public class FtpConfig
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public FtpConfig()
        {
            this.int_FtpReadWriteTimeout = 60000;
            this.bool_FtpUseBinary = true;
            this.bool_FtpUsePassive = true;
            this.bool_FtpKeepAlive = true;
            this.bool_FtpEnableSsl = false;
            this.int_RetryTimes = 3;
        }
        #endregion

        /// <summary>
        /// Ftp 标识
        /// </summary>
        public string str_Name { get; set; }
        /// <summary>
        /// FTP地址
        /// </summary>
        public string str_FtpUri { get; set; }
        /// <summary>
        /// FTP端口
        /// </summary>
        public int int_FtpPort { get; set; }
        /// <summary>
        /// FTP路径(/test)
        /// </summary>
        public string str_FtpPath { get; set; }
        /// <summary>
        /// FTP用户名
        /// </summary>
        public string str_FtpUserID { get; set; }
        /// <summary>
        /// FTP密码
        /// </summary>
        public string str_FtpPassword { get; set; }
        /// <summary>
        /// FTP密码是否被加密
        /// </summary>
        public bool bool_IsEncrypt { get; set; }
        /// <summary>
        /// 读取或写入超时之前的毫秒数。默认值为 30,000 毫秒。
        /// </summary>
        public int int_FtpReadWriteTimeout { get; set; }
        /// <summary>
        /// true，指示服务器要传输的是二进制数据；false，指示数据为文本。默认值为true。
        /// </summary>
        public bool bool_FtpUseBinary { get; set; }
        /// <summary>
        /// true，被动模式；false，主动模式(主动模式可能被防火墙拦截)。默认值为true。
        /// </summary>
        public bool bool_FtpUsePassive { get; set; }
        /// <summary>
        /// 是否保持连接。
        /// </summary>
        public bool bool_FtpKeepAlive { get; set; }
        /// <summary>
        /// 是否启用SSL。
        /// </summary>
        public bool bool_FtpEnableSsl { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string str_Describe { get; set; }
        /// <summary>
        /// 重试次数
        /// </summary>
        public int int_RetryTimes { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        public string str_Ver { get; set; }
    }
}
