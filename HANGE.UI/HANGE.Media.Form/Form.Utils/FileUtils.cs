using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FileUtils
{
    /// <summary>
    /// 输入需要备份的路径，路径中不包含文件
    /// </summary>
    /// <param name="toFile"></param>
    /// <param name="file"></param>
    public static void CopyOrRemoveFile(string toFile, FileInfo file)
    {
        file.CopyTo(Path.Combine(toFile, file.Name), true); //复制 ，剪切的话file.MoveTo();file.CopyTo是拷贝到另外一个文件夹
        file.Delete();
    }

    public static void CopyOrRemoveFileFullPath(string full_file_path, FileInfo file)
    {
        file.CopyTo(full_file_path, true); //复制 ，剪切的话file.MoveTo();file.CopyTo是拷贝到另外一个文件夹
        file.Delete();
    }
     
    private static string file_extend = ".WAV.JPG.MP4";
    public static bool is_need_file(string extend_str)
    {
        //return true;
        return file_extend.Contains(extend_str.ToUpper());
    }
    public static bool IsFileInUse(string fileName)
    {
        bool inUse = true;
        FileStream fs = null;
        try
        {
            fs = new FileStream(fileName, FileMode.Open, FileAccess.Read,
            FileShare.None);
            inUse = false;
        }
        catch
        {
        }
        finally
        {
            if (fs != null)
                fs.Close();
        }
        return inUse;//true表示正在使用,false没有使用  
    }
}

