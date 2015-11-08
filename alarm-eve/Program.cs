using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 

namespace alarm_eve
{
    static class Program
    {
        public static EventWaitHandle ProgramStarted;  


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 尝试创建一个命名事件  
            bool createNew;
            ProgramStarted = new EventWaitHandle(false, EventResetMode.AutoReset, "Eve-Alarm", out createNew);

            // 如果该命名事件已经存在(存在有前一个运行实例)，则发事件通知并退出  
            if (!createNew)
            {
                ProgramStarted.Set();
                return;
            }  


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
