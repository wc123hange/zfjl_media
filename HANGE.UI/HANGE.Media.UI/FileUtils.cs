using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANGE.Media.UI
{
    class FileUtils
    {
        public static void CopyOrRemoveFile(string toFile, FileInfo file)
        {
            file.CopyTo(Path.Combine(toFile, file.Name),true); //复制 ，剪切的话file.MoveTo();file.CopyTo是拷贝到另外一个文件夹
            file.Delete();
        }

        public static void CopyToFromFullname(string fullname, FileInfo file)
        {
            file.CopyTo(fullname, true); //复制 ，剪切的话file.MoveTo();file.CopyTo是拷贝到另外一个文件夹
        }
    }
}
