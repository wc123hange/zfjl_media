using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANGE.Media.Entity
{

    //@client_ip,@media_type,@device_name,@user_code,@media_filename,@option_type,@option_info
    public class media_option_log
    {
        public string client_ip { set; get; }
        public string media_type { set; get; }
        public string device_name { get; set; }
        public string user_code { set; get; }
        public string media_filename { set; get; }
        public int option_type { set; get; }
        public string option_info { set; get; }
    }
}
