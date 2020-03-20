using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uitls=DTcms.Common;

namespace HANGE.Media.UI.API
{
    class GetLocalConfig
    {
        private static readonly string client_ip = Uitls.ConfigUtil.GetConfigString("client_ip");
        //protected static Model.client_server_config get_client_config()
        //{
        //    var client = new { client_ip = client_ip };
        //    Uitls.HttpUtil.Post("", Newtonsoft.Json.JsonConvert.SerializeObject(client));
        //}

    }
}
