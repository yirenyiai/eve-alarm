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
        DateTime m_SkillsDT;

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
            string AccountSet = m_Ini.IniReadValue("eve-account", "AccountSet");
            string Account = "";

            m_SkillsDT = new DateTime();

            foreach (char C in AccountSet)
            {
                if (C == '|')
                {
                    string Time = m_Ini.IniReadValue("eve-account", Account);
                    if (string.IsNullOrWhiteSpace(Time)) continue;

                    DateTime tmpDT = Convert.ToDateTime(Time);

                    if (DateTime.Compare(tmpDT, m_SkillsDT) < 0 || m_SkillsDT.Ticks == 0)
                    {
                        m_SkillsDT = tmpDT;
                        this.RoleName.Text = Account;
                        this.Msg.Text = string.Format("计划  {0}  完成", m_SkillsDT.ToString("yyyy年MM月dd日 HH:mm:ss"));

                        m_TimerFreshSkillsStatus.Close();
                        m_TimerFreshSkillsStatus.Elapsed += new System.Timers.ElapsedEventHandler(OnTimerSkillsStatus);//到达时间的时候执行事件；
                        m_TimerFreshSkillsStatus.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
                        m_TimerFreshSkillsStatus.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
                    }
                    // 清空
                    Account = "";
                }
                else
                {
                    Account += C;
                }
            }
        }

        private void AlarmFrame_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, Win32.WM_NCLBUTTONDOWN, Win32.HTCAPTION, 0);
        }

        private string GetTimeDiff()
        {
            string dateDiff = null;
            try
            {
                TimeSpan ts1 = new TimeSpan(m_SkillsDT.Ticks);
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
                    SkillsStatue.ForeColor = Color.GreenYellow;
                    dateDiff = day + "天 " + hours + ":" + minutes + ":" + seconds;
                }
                else
                {
                    SkillsStatue.ForeColor = Color.Red;
                    dateDiff = hours + ":" + minutes + ":" + seconds;
                }
            }
            catch
            {

            }
            return dateDiff;
        }

        private void OnTimerControl()
        {
            if (DateTime.Compare(DateTime.Now, m_SkillsDT) > 0)
            {
                if (SkillsStatue.Text != "已经完成")
                {
                    SkillsStatue.Text = "已经完成";
                    SkillsStatue.ForeColor = Color.DarkRed;
                    TrayIcon.BalloonTipTitle = "EVE-技能序列";
                    TrayIcon.BalloonTipText = this.RoleName.Text + " 一项技能已经训练完毕";
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
                SkillsStatue.Text = GetTimeDiff();
                this.ShowInTaskbar = false;
                this.TrayIcon.Text = string.Format("{0}\n{1}\n{2}", RoleName.Text, Msg.Text, SkillsStatue.Text);
            }
        }

        public void OnTimerSkillsStatus(object source, System.Timers.ElapsedEventArgs e)
        {
            SkillsStatue.BeginInvoke(new BeginInvokeDelegate(OnTimerControl));
        }

        private void InitShowControl()
        {
            string bShowTimer = m_Ini.IniReadValue("eve-configure", "ShowTimer");
            string bShowMaturityDate = m_Ini.IniReadValue("eve-configure", "ShowMaturityDate");
            string bShowAccount = m_Ini.IniReadValue("eve-configure", "ShowAccount");

            if (!string.IsNullOrWhiteSpace(bShowAccount)) this.RoleName.Visible = Convert.ToBoolean(bShowAccount);
            if (!string.IsNullOrWhiteSpace(bShowMaturityDate)) this.Msg.Visible = Convert.ToBoolean(bShowMaturityDate);
            if (!string.IsNullOrWhiteSpace(bShowTimer)) this.SkillsStatue.Visible = Convert.ToBoolean(bShowTimer);
        }

        private void AlarmFrame_Load(object sender, EventArgs e)
        {
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
}
