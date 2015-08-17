using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIPlus;
using Ini;
using System.Collections;
using System.Runtime.InteropServices;


namespace alarm_eve
{
    public partial class AlarmFrame : Form
    {
        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        public delegate void BeginInvokeDelegate();
        private AlarmListDialog m_AlarmListDialog;
        private IniFile m_Ini = new IniFile(Application.StartupPath + "\\eve-account.ini");
        System.Timers.Timer m_TimerFreshSkillsStatus = new System.Timers.Timer(1000);
        ArrayList m_SkillsDTArray = new ArrayList();
        ArrayList m_ControlSetArray = new ArrayList();
        public Point m_ptInForm = new Point(); 

        #region 热键模块
        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_EXSTYLE = (-20);

        [DllImport("user32.dll")]
        private static extern int RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern int UnregisterHotKey(IntPtr hwnd, int id);
        int Space = 32; //热键ID 
        private const int WM_HOTKEY = 0x312; //窗口消息-热键 
        private const int WM_CREATE = 0x1; //窗口消息-创建 
        private const int WM_DESTROY = 0x2; //窗口消息-销毁 
        private const int MOD_ALT = 0x1; //ALT 
        private const int MOD_CONTROL = 0x2; //CTRL 
        private const int MOD_SHIFT = 0x4; //SHIFT 
        private const int VK_SPACE = 0x20; //SPACE 
        private const int VK_OEM_PLUS = 0xBB;
        private const int VK_OEM_MINUS = 0xBD;

        /// <summary> 
		/// 注册热键 
		/// </summary> 
		/// <param name="hwnd">窗口句柄</param> 
		/// <param name="hotKey_id">热键ID</param> 
		/// <param name="fsModifiers">组合键</param> 
		/// <param name="vk">热键</param> 
        private void RegKey(IntPtr hwnd, int hotKey_id, int fsModifiers, int vk, string ErroMsg = "注册热键失败!")
		{
		     bool result;
		     if (RegisterHotKey(hwnd,hotKey_id,fsModifiers,vk) == 0)
		     {
		         result = false;
		     }
		     else
		     {
		         result = true;
		     }
		     if (!result)
		     {
                 MessageBox.Show(ErroMsg);
		     }
		}
		
		/// <summary> 
		/// 注销热键 
		/// </summary> 
		/// <param name="hwnd">窗口句柄</param> 
		/// <param name="hotKey_id">热键ID</param> 
		private void UnRegKey(IntPtr hwnd, int hotKey_id)
		{
		     UnregisterHotKey(hwnd,hotKey_id);
		}
        #endregion

        #region 使窗口有鼠标穿透功能
        /// <summary> 
        /// 在窗口结构中为指定的窗口设置信息 
        /// </summary> 
        /// <param name="hwnd">欲为其取得信息的窗口的句柄</param> 
        /// <param name="nIndex">欲取回的信息</param> 
        /// <param name="dwNewLong">由nIndex指定的窗口信息的新值</param> 
        /// <returns></returns> 
        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);

        /// <summary> 
        /// 从指定窗口的结构中取得信息 
        /// </summary> 
        /// <param name="hwnd">欲为其获取信息的窗口的句柄</param> 
        /// <param name="nIndex">欲取回的信息</param> 
        /// <returns></returns> 
        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);

        /// <summary> 
        /// 使窗口 拥有/取消 鼠标穿透功能
        /// </summary> 
        private void Penetrate()
        {
            uint intExTemp = GetWindowLong(this.Handle, GWL_EXSTYLE);
            if (intExTemp == (WS_EX_TRANSPARENT | WS_EX_LAYERED))
            {
                uint oldGWLEx = SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_LAYERED);
            }
            else {
                uint oldGWLEx = SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
            }
        }
        /// <summary> 
        /// 增大窗口的透明度
        /// </summary> 
        /// 
        void IncreaseOpacity()
        {
            this.TransparencyKey = Color.DarkGray; //让窗体不透明  
        }
        /// 
        /// <summary> 
        /// 降低窗口的透明度
        /// </summary> 
        void LowerOpacity()
        {
            this.TransparencyKey = this.BackColor; //让窗体透明   
        }
        #endregion


        public AlarmFrame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置窗体的圆角矩形
        /// </summary>
        /// <param name="rgnRadius">圆角矩形的半径</param>
        public void SetFormRoundRectRgn(int rgnRadius)
        {
            int hRgn = 0;
            hRgn = Win32.CreateRoundRectRgn(0, 0, this.Width + 1, this.Height + 1, rgnRadius, rgnRadius);
            Win32.SetWindowRgn(this.Handle, hRgn, true);
            Win32.DeleteObject(hRgn);
        }

        private void ShowEveAccount()
        {
            // 读取INI数据
            m_SkillsDTArray.Clear();

            string AccountSet = m_Ini.IniReadValue("eve-account", "AccountSet");
            string Account = "";
            foreach (char C in AccountSet)
            {
                if (C == '|')
                {
                    string Time = m_Ini.IniReadValue("eve-account", Account);
                    if (string.IsNullOrWhiteSpace(Time)) continue;
                    AccountSet Accounts = new AccountSet();
                    Accounts.m_RoleName = Account;
                    Accounts.m_MaturityDate = Convert.ToDateTime(Time);
                    m_SkillsDTArray.Add(Accounts);
                    Account = "";
                }
                else
                {
                    Account += C;
                }
            }

            m_SkillsDTArray.Sort(new AccountSetSortComplarer());

            m_TimerFreshSkillsStatus.Close();
            m_TimerFreshSkillsStatus.Elapsed += new System.Timers.ElapsedEventHandler(OnTimerSkillsStatus);//到达时间的时候执行事件；
            m_TimerFreshSkillsStatus.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            m_TimerFreshSkillsStatus.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；

            ReSetInfo();

            // 初始化帐号信息
            string ShowItemCount = m_Ini.IniReadValue("eve-configure", "ShowItemCount");
            int ItemCount = 1;
            if (!string.IsNullOrWhiteSpace(ShowItemCount))
                ItemCount = Convert.ToInt32(ShowItemCount);
            switch(ItemCount)
            {
                case 1:
                    this.Height = 76;
                    break;
                case 2:
                    this.Height = 175;
                    break;
                case 3:
                    this.Height = 270;
                    break;
                case 4:
                    this.Height = 358;
                    break;
                case 5:
                    this.Height = 455;
                    break;
            }

        }

        private void AlarmFrame_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, Win32.WM_NCLBUTTONDOWN, Win32.HTCAPTION, 0);
        }

        private void SkillsStatue_5_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, Win32.WM_NCLBUTTONDOWN, Win32.HTCAPTION, 0);
        }

        private string GetTimeDiff(DateTime DT, ref bool WarningColor)
        {
            string dateDiff = null;
            try
            {
                TimeSpan ts1 = new TimeSpan(DT.Ticks);
                TimeSpan ts2 = new TimeSpan(DateTime.Now.Ticks);
                TimeSpan ts = ts1.Subtract(ts2).Duration();
                string day = ts.Days.ToString(), hours = ts.Hours.ToString(), minutes = ts.Minutes.ToString(), seconds = ts.Seconds.ToString();
                if (ts.Hours < 10)
                {
                    hours = "0" + ts.Hours.ToString();
                }
                if (ts.Minutes < 10)
                {
                    minutes = "0" + ts.Minutes.ToString();
                }
                if (ts.Seconds < 10)
                {
                    seconds = "0" + ts.Seconds.ToString();
                }
                if (ts.Days > 0)
                {
                    WarningColor = false;
                    dateDiff = day + "天 " + hours + ":" + minutes + ":" + seconds;
                }
                else
                {
                    WarningColor = true;
                    dateDiff = hours + ":" + minutes + ":" + seconds;
                }
            }
            catch
            {

            }
            return dateDiff;
        }

        private void ReSetInfo()
        {
            // 初始化帐号信息
            string ShowItemCount = m_Ini.IniReadValue("eve-configure", "ShowItemCount");
            int ItemCount = 1;
            if (!string.IsNullOrWhiteSpace(ShowItemCount))
                ItemCount = Convert.ToInt32(ShowItemCount);

            if (m_SkillsDTArray.Count > 0)
            {
                int Count = 0;
                this.TrayIcon.Text = "";
                foreach (AccountSet Accounts in m_SkillsDTArray)
                {
                    if (Count >= ItemCount) break;
                    ControlSet Controls = (ControlSet)m_ControlSetArray[Count];

                    if (Controls.m_RoleName.Text != Accounts.m_RoleName)
                        Controls.m_RoleName.Text = Accounts.m_RoleName;

                    Controls.m_MaturityDate.Text = string.Format("计划在  {0}  完成", Accounts.m_MaturityDate.ToString());

                    if (DateTime.Compare(DateTime.Now, Accounts.m_MaturityDate) > 0)
                    {
                        if (Controls.m_SkillsStatue.Text != "已经到期")
                        {
                            Controls.m_SkillsStatue.Text = "已经到期";
                            Controls.m_SkillsStatue.ForeColor = Color.DarkRed;
                            TrayIcon.BalloonTipTitle = "任务到期提醒";
                            TrayIcon.BalloonTipText = this.RoleName_1.Text + " 一项任务已经到达预设的时间";
                            //消失时间
                            TrayIcon.ShowBalloonTip(2000);
                            // 显示在任务栏
                            this.ShowInTaskbar = true;
                        }
                        IntPtr hWnd = this.Handle;
                        Win32.FlashWindow(hWnd, true);
                    }
                    else
                    {
                        bool bWarningTip = false;
                        Accounts.m_SkillsStatue = Controls.m_SkillsStatue.Text = GetTimeDiff(Accounts.m_MaturityDate, ref bWarningTip);

                        if (bWarningTip) 
                            Controls.m_SkillsStatue.ForeColor = Color.Red;
                        else 
                            Controls.m_SkillsStatue.ForeColor = Color.GreenYellow;

                        this.ShowInTaskbar = false;
                        this.TrayIcon.Text = string.Format("{0}\n{1}\n{2}", Controls.m_RoleName.Text, Controls.m_MaturityDate.Text, Controls.m_SkillsStatue.Text);
                        this.TrayIcon.Text += "\n";
                    }
                    Count += 1;
                }
            }
            else
            {
                foreach (ControlSet Controls in m_ControlSetArray)
                {
                    Controls.m_RoleName.Text = "备注";
                    Controls.m_MaturityDate.Text = "计划完成时间";
                    Controls.m_SkillsStatue.Text = "倒计时";
                }
                m_TimerFreshSkillsStatus.Close();
            }
        }

        private void OnTimerControl()
        {
            ReSetInfo();
        }

        public void OnTimerSkillsStatus(object source, System.Timers.ElapsedEventArgs e)
        {
            SkillsStatue_1.BeginInvoke(new BeginInvokeDelegate(OnTimerControl));
        }

        private void InitControlSet()
        { 
            ControlSet Set_1 = new ControlSet();
            ControlSet Set_2 = new ControlSet();
            ControlSet Set_3 = new ControlSet();
            ControlSet Set_4 = new ControlSet();
            ControlSet Set_5 = new ControlSet();

            Set_1.m_RoleName = this.RoleName_1;
            Set_2.m_RoleName = this.RoleName_2;
            Set_3.m_RoleName = this.RoleName_3;
            Set_4.m_RoleName = this.RoleName_4;
            Set_5.m_RoleName = this.RoleName_5;

            Set_1.m_MaturityDate = this.MaturityDate_1;
            Set_2.m_MaturityDate = this.MaturityDate_2;
            Set_3.m_MaturityDate = this.MaturityDate_3;
            Set_4.m_MaturityDate = this.MaturityDate_4;
            Set_5.m_MaturityDate = this.MaturityDate_5;

            Set_1.m_SkillsStatue = this.SkillsStatue_1;
            Set_2.m_SkillsStatue = this.SkillsStatue_2;
            Set_3.m_SkillsStatue = this.SkillsStatue_3;
            Set_4.m_SkillsStatue = this.SkillsStatue_4;
            Set_5.m_SkillsStatue = this.SkillsStatue_5;

            m_ControlSetArray.Add(Set_1);
            m_ControlSetArray.Add(Set_2);
            m_ControlSetArray.Add(Set_3);
            m_ControlSetArray.Add(Set_4);
            m_ControlSetArray.Add(Set_5);
        }

        private void InitShowControl()
        {
            string bShowTimer = m_Ini.IniReadValue("eve-configure", "ShowTimer");
            string bShowMaturityDate = m_Ini.IniReadValue("eve-configure", "ShowMaturityDate");
            string bShowAccount = m_Ini.IniReadValue("eve-configure", "ShowAccount");

            if (!string.IsNullOrWhiteSpace(bShowAccount))
            {
                foreach (ControlSet Controls in m_ControlSetArray)
                {
                    Controls.m_RoleName.Visible = Convert.ToBoolean(bShowAccount); 
                }
            }

            if (!string.IsNullOrWhiteSpace(bShowMaturityDate))
            {
                foreach (ControlSet Controls in m_ControlSetArray)
                {
                    Controls.m_MaturityDate.Visible = Convert.ToBoolean(bShowMaturityDate); 
                }
            }

            if (!string.IsNullOrWhiteSpace(bShowTimer)) 
            {
                {
                    foreach (ControlSet Controls in m_ControlSetArray)
                    {
                        Controls.m_SkillsStatue.Visible = Convert.ToBoolean(bShowTimer); 
                    }
                }

            }
        }

        private void AlarmFrame_Load(object sender, EventArgs e)
        {
            InitControlSet();
            SetFormRoundRectRgn(5);
            Win32.SetClassLong(this.Handle, GCL_STYLE, Win32.GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
            this.TrayIcon.Visible = true;
            this.TrayIcon.ContextMenuStrip = this.TrayIconContentMenu;
            this.ShowInTaskbar = false;
            ShowEveAccount();
            InitShowControl();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            m_AlarmListDialog = new AlarmListDialog();
            m_AlarmListDialog.ShowDialog();
            ShowEveAccount();
            InitShowControl();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AlarmFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_TimerFreshSkillsStatus.Close();
        }

        private void ImageBtn_Hover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void ImageBtn_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.Activate();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch(m.Msg)
            {
            case WM_HOTKEY: //窗口消息-热键 
                switch(m.WParam.ToInt32())
                {
                    case VK_SPACE: //热键ID 
                        Penetrate();
                        break;
                    case VK_OEM_PLUS:
                        IncreaseOpacity();
                        break;
                    case VK_OEM_MINUS:
                        LowerOpacity();
                        break;
                    default:
                    break;
                }
                break;
            case WM_CREATE: //窗口消息-创建 
                RegKey(Handle, Space, MOD_ALT | MOD_CONTROL , VK_SPACE, "注册快捷键失败： 无法使用窗口固定功能"); //注册热键---鼠标穿透
                RegKey(Handle, VK_OEM_PLUS, MOD_CONTROL , VK_OEM_PLUS, "注册快捷键失败： 无法增加透明度"); //注册热键---增加透明度
                RegKey(Handle, VK_OEM_MINUS, MOD_CONTROL , VK_OEM_MINUS, "注册快捷键失败： 无法降低透明度"); //注册热键---降低透明度
                break;
            case WM_DESTROY: //窗口消息-销毁 
                UnRegKey(Handle,Space); //销毁热键 
                break;
            default:
                break;
           }

        }


    }

    public class ControlSet
    {
        public Label m_RoleName { get; set; }
        public Label m_MaturityDate { get; set; }
        public Label m_SkillsStatue { get; set; }
    }

    public class AccountSet
    {
        public string m_RoleName { get; set; }
        public DateTime m_MaturityDate { get; set; }
        public string m_SkillsStatue { get; set; }

    }

    public class AccountSetSortComplarer
        : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            AccountSet t1 = (AccountSet)x;
            AccountSet t2 = (AccountSet)y;
            return DateTime.Compare(t1.m_MaturityDate, t2.m_MaturityDate);
        }
    }
}
