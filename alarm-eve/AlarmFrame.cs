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
                    this.Height = 155;
                    break;
                case 3:
                    this.Height = 239;
                    break;
                case 4:
                    this.Height = 326;
                    break;
                case 5:
                    this.Height = 405;
                    break;
            }

        }

        private void AlarmFrame_MouseDown(object sender, MouseEventArgs e)
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
