using System;
using System.Windows.Forms;

namespace MaterialSkinExample
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HANGE.Media.Mysql.DBContext.AppInit();
             Application.Run(new HANGE.Media.CollectForm());
            //Application.Run(new UploadForm());
        }
    }
}
