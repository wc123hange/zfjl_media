using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uitls = DTcms.Common;
using Entity = HANGE.Media.Form;
using Json = Newtonsoft.Json.JsonConvert;
using DBContext = HANGE.Media.Mysql;

namespace HANGE.Media
{
    class GetLocalConfig
    {
        private static readonly string client_ip = Uitls.ConfigUtil.GetConfigString("client_ip");
        public static Entity.client_server_config get_client_config()
        {
            System.Threading.Thread.Sleep(2000);
            //var client = new { client_ip = client_ip };
            //var client_config =
            //    Json.DeserializeObject<Entity.PostResult<Entity.client_server_config, string>>(Uitls.HttpUtil.Post("", Json.SerializeObject(client)));
            Entity.client_server_config client_config = new Entity.client_server_config()
            {
                collect_path = Uitls.ConfigUtil.GetConfigString("frompath"),
                backup_path = Uitls.ConfigUtil.GetConfigString("topath"),
            };
            return client_config;
        }
        /// <summary>
        /// 获取上传服务器信息
        /// </summary>
        /// <param name="servername"></param>
        /// <returns></returns>
        public static Entity.Pe_serverinfo get_serverinfo(string servername)
        {
            return HANGE.Media.Mysql.DBContext.DB.From<Entity.Pe_serverinfo>().Where(s => s.Servername == servername).First();
        }

    }
}
