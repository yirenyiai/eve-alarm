using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm_eve
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 初始化七牛
            Qiniu.Conf.Config.Init();
            Qiniu.Conf.Config.ACCESS_KEY = "";
            Qiniu.Conf.Config.SECRET_KEY = "";
            // 开启主窗口
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AlarmFrame());
        }
    }
}
