using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HANGE.Media.Mysql;
using Entity = HANGE.Media.Entity;

namespace HANGE.Media.Form
{
    public class video_list_ball
    {
        ///// <summary>
        ///// 插入，如果存在则返回失败
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public bool InsertModel(Entity.Pe_video_list model)
        //{
        //    var is_exit = DBContext.DB.From<Entity.Pe_video_list>().Where(s => s.filename == model.filename).First();
        //    if (is_exit != null)
        //    {
        //        return false;
        //    }
        //    var result = DBContext.DB.Insert(model);
        //    if (result == 0)
        //    {
        //        return false;
        //    }
        //    return true;

        //}

        //public bool update_model(int id, string playstation, int status)
        //{
        //    var model = new Entity.Pe_video_list();
        //    model.playposition = playstation;
        //    model.is_flg = status;
        //    int result = DBContext.DB.Update<Entity.Pe_video_list>(model, s => s.id == id);
        //    return result > 0;
        //}

        //public static List<Entity.Pe_video_list> GetModelListByClient(string client_ip, int status)
        //{
        //    var result = DBContext.DB.From<Entity.Pe_video_list>().Where(s => (s.servername == client_ip && status == (int)s.is_flg)).ToList();
        //    return result;
        //}

        //public Entity.Pe_video_list GetModelbyId(int id)
        //{
        //    return DBContext.DB.From<Entity.Pe_video_list>().Where(s => s.id == id).First();
        //}

        //public Entity.Pe_video_list GetModelByFilename(string filename)
        //{
        //    if (string.IsNullOrEmpty(filename))
        //    {
        //        return null;
        //    }
        //    return DBContext.DB.From<Entity.Pe_video_list>().Where(s => s.filename == filename).First();
        //}

    }
}
