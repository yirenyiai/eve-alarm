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
            Qiniu.Conf.Config.ACCESS_KEY = "02YfE38C5Qxx61yiCHOiXNxeMUD6PsqRSNONMCmi";
            Qiniu.Conf.Config.SECRET_KEY = "7ZT8RhIwjsUpW9M9Y4hWXQAtxw5zVb_N_0rraD7t";
            // 开启主窗口
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AlarmFrame());
        }
    }
}
