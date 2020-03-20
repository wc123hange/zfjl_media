using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity = HANGE.Media.Entity;


class LogManager
{
    //@client_ip,@media_type,@device_name,@user_code,@media_filename,@option_type,@option_info

    private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
    public static void Info(Entity.media_option_log loginfo)
    {
        NLog.LogEventInfo eventInfo = new NLog.LogEventInfo(NLog.LogLevel.Info, "", "");
        foreach (var pro in typeof(Entity.media_option_log).GetProperties())
        {
            eventInfo.Properties[pro.Name] = pro.GetValue(loginfo);
        }
        logger.Info(eventInfo);

    }

    public static void Error(Exception ex)
    {
        logger.Error(ex);
    }
}

