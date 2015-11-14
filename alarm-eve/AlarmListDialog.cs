using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ini;
using Microsoft.Win32;
using Qiniu.IO;
using Qiniu.RS;
using Qiniu.RPC;
using System.Net;
using System.IO;

namespace alarm_eve
{
    public partial class AlarmListDialog : Form
    {
        private IniFile m_Ini = new IniFile(Application.StartupPath + "\\eve-account.ini");

        public AlarmListDialog()
        {
            InitializeComponent();
        }

        private bool IsAutoStart()
        {
            try
            {
                bool bAutoStart = false;
                string starupPath = Application.LocalUserAppDataPath;
                RegistryKey loca = Registry.CurrentUser;
                RegistryKey run = loca.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                string RegValue = run.GetValue("alarm-eve").ToString();
                if (RegValue == starupPath)
                    bAutoStart = true;
                loca.Close();

                return bAutoStart;
            }
            catch (Exception )
            {
            }
            return false;
        }

        private void AutoStart()
        {
            try
            {
                string starupPath = Application.ExecutablePath;
                RegistryKey loca = Registry.CurrentUser;
                RegistryKey run = loca.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                run.SetValue("alarm-eve", starupPath);
                loca.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "无法设置开机启动", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DelAutoStart()
        {
            try
            {
                string starupPath = Application.ExecutablePath;
                //  class Micosoft.Win32.RegistryKey. 表示Window注册表中项级节点,此类是注册表装.
                RegistryKey loca = Registry.CurrentUser;
                RegistryKey run = loca.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                run.DeleteValue("alarm-eve");
                loca.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitCheckBoxStatus()
        {
            string bShowTimer = m_Ini.IniReadValue("eve-configure", "ShowTimer");
            string bShowMaturityDate = m_Ini.IniReadValue("eve-configure", "ShowMaturityDate");
            string bShowAccount = m_Ini.IniReadValue("eve-configure", "ShowAccount");

            if (!string.IsNullOrWhiteSpace(bShowAccount)) this.ShowAccount.Checked = Convert.ToBoolean(bShowAccount);
            if (!string.IsNullOrWhiteSpace(bShowMaturityDate)) this.ShowMaturityDate.Checked = Convert.ToBoolean(bShowMaturityDate);
            if (!string.IsNullOrWhiteSpace(bShowTimer)) this.ShowTimer.Checked = Convert.ToBoolean(bShowTimer);
        }

        private void InitListViewData()
        {
            // 读取INI数据
            string AccountSet = m_Ini.IniReadValue("eve-account", "AccountSet");
            string Account = "";
            foreach (char C in AccountSet)
            {
                if (C == '|')
                {
                    string Time = m_Ini.IniReadValue("eve-account", Account);
                    ListViewItem lv = new ListViewItem();
                    lv.SubItems[0].Text = Account;
                    lv.SubItems.Add(Time);
                    AlramList.Items.Add(lv);
                    // 清空
                    Account = "";
                }
                else
                {
                    Account += C;
                }
            }
        }

        private void InitShowItemCount()
        {
            string ShowItemCount = m_Ini.IniReadValue("eve-configure", "ShowItemCount");
            if (!string.IsNullOrWhiteSpace(ShowItemCount))
                this.ShowItemCount.Text = ShowItemCount;
        }

        private void InitAutoStart()
        {
            if (IsAutoStart())
            {
                AutoStartBtn.Text = "取消开机启动";
            }
            else
            {
                AutoStartBtn.Text = "开机启动";
            }
        }

        private void AlarmListDialog_Load(object sender, EventArgs e)
        {
            this.MaturityDate.Format = DateTimePickerFormat.Custom;
            this.MaturityDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.MaturityDate.ShowUpDown = true;

            InitCheckBoxStatus();
            InitListViewData();
            InitShowItemCount();
            InitAutoStart();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddAlramBtn_Click(object sender, EventArgs e)
        {
            string Account = RoleEdit.Text;
            string Time = MaturityDate.Text;
            if (string.IsNullOrWhiteSpace(Account))
            {
                MessageBox.Show("帐号不允许为空");
                return ;
            }

            string AccountSet = m_Ini.IniReadValue("eve-account", "AccountSet");
            AccountSet += Account + "|";
            m_Ini.IniWriteValue("eve-account", "AccountSet", AccountSet);
            m_Ini.IniWriteValue("eve-account", Account, Time);

            ListViewItem lv = new ListViewItem();
            lv.SubItems[0].Text = Account;
            lv.SubItems.Add(Time);
            AlramList.Items.Add(lv);

            CommitFile();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (AlramList.SelectedItems.Count <= 0) return;

            string DelAccount = AlramList.SelectedItems[0].Text;
            string oldAccountSet = m_Ini.IniReadValue("eve-account", "AccountSet");
            string tmpAccount = "";
            string newAccountSet = "";
            foreach (char C in oldAccountSet)
            {
                if (C == '|')
                {
                    if (DelAccount != tmpAccount)
                    {
                        newAccountSet += tmpAccount + "|";
                    }
                    tmpAccount = "";
                }
                else
                {
                    tmpAccount += C;
                }
            }

            m_Ini.IniWriteValue("eve-account", "AccountSet", newAccountSet);
            m_Ini.IniWriteValue("eve-account", DelAccount, "");

            AlramList.Items.RemoveAt(AlramList.SelectedItems[0].Index);
            CommitFile();
        }

        private void AutoStartBtn_Click(object sender, EventArgs e)
        {
            if (IsAutoStart())
            {
                DelAutoStart();
                AutoStartBtn.Text = "开机启动";
            }
            else 
            {
                AutoStart();
                AutoStartBtn.Text = "取消开机启动";
            }

        }

        private void ShowTimer_CheckedChanged(object sender, EventArgs e)
        {
            string Status = this.ShowTimer.Checked.ToString();
            m_Ini.IniWriteValue("eve-configure", "ShowTimer", Status);
        }

        private void ShowMaturityDate_CheckedChanged(object sender, EventArgs e)
        {
            string Status = this.ShowMaturityDate.Checked.ToString();
            m_Ini.IniWriteValue("eve-configure", "ShowMaturityDate", Status);
        }

        private void ShowAccount_CheckedChanged(object sender, EventArgs e)
        {
            string Status = this.ShowAccount.Checked.ToString();
            m_Ini.IniWriteValue("eve-configure", "ShowAccount", Status);
        }

        private void ShowItemCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ItemCount = this.ShowItemCount.Text;
            m_Ini.IniWriteValue("eve-configure", "ShowItemCount", ItemCount);
        }

        private void SyncBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                string url = "http://7xjgjz.com1.z0.glb.clouddn.com/eve-account.ini";
                string LocalPath = Application.StartupPath + @"\eve-account.ini";
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(url, LocalPath);
                AlramList.Items.Clear();
                InitListViewData();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void CommitFile()
        {
            string LocalPath = Application.StartupPath + @"\eve-account.ini";

            DeleteFile("eve-account", "eve-account.ini");

            // 这里很严重。所以要重复提交
            DialogResult ret = DialogResult.Cancel;
            do
            {
                if (!PutFile("eve-account", "eve-account.ini", LocalPath))
                {
                    MessageBox.Show("发生严重错误，服务器数据被单向删除。是否要重新提交");
                    return;
                }
            } while (ret == DialogResult.OK);
        }

        private bool PutFile(string bucket, string key, string fname)
        {
            var policy = new PutPolicy(bucket, 3600);
            string upToken = policy.Token();
            PutExtra extra = new PutExtra();
            IOClient client = new IOClient();
            PutRet ret = client.PutFile(upToken, key, fname, extra);
            if (!ret.OK) MessageBox.Show(ret.Response);
            return ret.OK;
        }

        private bool DeleteFile(string bucket, string key)
        {
            Console.WriteLine("\n===> Delete {0}:{1}", bucket, key);
            RSClient client = new RSClient();
            CallRet ret = client.Delete(new EntryPath(bucket, key));
            if (!ret.OK) MessageBox.Show(ret.Response);
            return ret.OK;
        }
    }
}
