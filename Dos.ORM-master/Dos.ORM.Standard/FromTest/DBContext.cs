using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;

namespace FromTest
{
    public class DBContext
    {
        public static DbSession media_context;
        //private static string media_sqlstr = System.Configuration.ConfigurationSettings.AppSettings["media"];
        public static void AppInit()
        {
            media_context = new DbSession("media");
        }
    }
}
