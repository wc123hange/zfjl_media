using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HANGE.Media.Mysql;
using Entity = HANGE.Media.Entity;

namespace HANGE.Media.Form
{
    public class pe_device_ball 
    {   
        //public List<Entity.Pe_device> Get_Devices()
        //{
        //    return DBContext.DB.From<Entity.Pe_device>().Where(s => s.State == "0" && !s.Hostbody.Contains("_")).ToList();
        //}

        //public Entity.Pe_device Get_Device_denum(string device_num)
        //{
        //    return DBContext.DB.From<Entity.Pe_device>().Where(s => s.Hostbody == device_num&&!s.Hostbody.Contains("_")&&s.State=="0").First();
        //} 

        //public List<Entity.Pe_device> Get_Devices(string contains)
        //{
        //    return DBContext.DB.From<Entity.Pe_device>().Where(s => s.State == "0" && s.Hostbody.Contains(contains)).ToList();
        //}
    }
}
