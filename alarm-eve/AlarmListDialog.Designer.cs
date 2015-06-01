namespace alarm_eve
{
    partial class AlarmListDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AlramList = new System.Windows.Forms.ListView();
            this.EveAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoleEdit = new System.Windows.Forms.TextBox();
            this.AddAlramBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.EveAccountEdit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaturityDate = new System.Windows.Forms.DateTimePicker();
            this.Delete = new System.Windows.Forms.Button();
            this.AutoStartBtn = new System.Windows.Forms.Button();
            this.ShowAccount = new System.Windows.Forms.CheckBox();
            this.ShowMaturityDate = new System.Windows.Forms.CheckBox();
            this.ShowTimer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AlramList
            // 
            this.AlramList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EveAccount,
            this.Remain});
            this.AlramList.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlramList.FullRowSelect = true;
            this.AlramList.Location = new System.Drawing.Point(0, 0);
            this.AlramList.Name = "AlramList";
            this.AlramList.Size = new System.Drawing.Size(492, 183);
            this.AlramList.TabIndex = 0;
            this.AlramList.UseCompatibleStateImageBehavior = false;
            this.AlramList.View = System.Windows.Forms.View.Details;
            // 
            // EveAccount
            // 
            this.EveAccount.Text = "帐号名字";
            this.EveAccount.Width = 99;
            // 
            // Remain
            // 
            this.Remain.Text = "到期时间";
            this.Remain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Remain.Width = 385;
            // 
            // RoleEdit
            // 
            this.RoleEdit.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RoleEdit.Location = new System.Drawing.Point(108, 201);
            this.RoleEdit.Name = "RoleEdit";
            this.RoleEdit.Size = new System.Drawing.Size(228, 33);
            this.RoleEdit.TabIndex = 1;
            // 
            // AddAlramBtn
            // 
            this.AddAlramBtn.Location = new System.Drawing.Point(372, 224);
            this.AddAlramBtn.Name = "AddAlramBtn";
            this.AddAlramBtn.Size = new System.Drawing.Size(108, 26);
            this.AddAlramBtn.TabIndex = 2;
            this.AddAlramBtn.Text = "添加任务";
            this.AddAlramBtn.UseVisualStyleBackColor = true;
            this.AddAlramBtn.Click += new System.EventHandler(this.AddAlramBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(372, 288);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(108, 26);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "关闭";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // EveAccountEdit
            // 
            this.EveAccountEdit.AutoSize = true;
            this.EveAccountEdit.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EveAccountEdit.Location = new System.Drawing.Point(13, 204);
            this.EveAccountEdit.Name = "EveAccountEdit";
            this.EveAccountEdit.Size = new System.Drawing.Size(50, 25);
            this.EveAccountEdit.TabIndex = 3;
            this.EveAccountEdit.Text = "帐号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "到期时间";
            // 
            // MaturityDate
            // 
            this.MaturityDate.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaturityDate.Location = new System.Drawing.Point(107, 257);
            this.MaturityDate.Name = "MaturityDate";
            this.MaturityDate.Size = new System.Drawing.Size(229, 33);
            this.MaturityDate.TabIndex = 4;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(372, 256);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 26);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AutoStartBtn
            // 
            this.AutoStartBtn.Location = new System.Drawing.Point(372, 192);
            this.AutoStartBtn.Name = "AutoStartBtn";
            this.AutoStartBtn.Size = new System.Drawing.Size(108, 26);
            this.AutoStartBtn.TabIndex = 2;
            this.AutoStartBtn.Text = "开机启动";
            this.AutoStartBtn.UseVisualStyleBackColor = true;
            this.AutoStartBtn.Click += new System.EventHandler(this.AutoStartBtn_Click);
            // 
            // ShowAccount
            // 
            this.ShowAccount.AutoSize = true;
            this.ShowAccount.Checked = true;
            this.ShowAccount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowAccount.Location = new System.Drawing.Point(19, 305);
            this.ShowAccount.Name = "ShowAccount";
            this.ShowAccount.Size = new System.Drawing.Size(72, 16);
            this.ShowAccount.TabIndex = 5;
            this.ShowAccount.Text = "显示帐号";
            this.ShowAccount.UseVisualStyleBackColor = true;
            this.ShowAccount.CheckedChanged += new System.EventHandler(this.ShowAccount_CheckedChanged);
            // 
            // ShowMaturityDate
            // 
            this.ShowMaturityDate.AutoSize = true;
            this.ShowMaturityDate.Checked = true;
            this.ShowMaturityDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowMaturityDate.Location = new System.Drawing.Point(97, 305);
            this.ShowMaturityDate.Name = "ShowMaturityDate";
            this.ShowMaturityDate.Size = new System.Drawing.Size(120, 16);
            this.ShowMaturityDate.TabIndex = 5;
            this.ShowMaturityDate.Text = "显示计划到期时间";
            this.ShowMaturityDate.UseVisualStyleBackColor = true;
            this.ShowMaturityDate.CheckedChanged += new System.EventHandler(this.ShowMaturityDate_CheckedChanged);
            // 
            // ShowTimer
            // 
            this.ShowTimer.AutoSize = true;
            this.ShowTimer.Checked = true;
            this.ShowTimer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowTimer.Location = new System.Drawing.Point(223, 305);
            this.ShowTimer.Name = "ShowTimer";
            this.ShowTimer.Size = new System.Drawing.Size(84, 16);
            this.ShowTimer.TabIndex = 5;
            this.ShowTimer.Text = "显示倒计时";
            this.ShowTimer.UseVisualStyleBackColor = true;
            this.ShowTimer.CheckedChanged += new System.EventHandler(this.ShowTimer_CheckedChanged);
            // 
            // AlarmListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 333);
            this.Controls.Add(this.ShowTimer);
            this.Controls.Add(this.ShowMaturityDate);
            this.Controls.Add(this.ShowAccount);
            this.Controls.Add(this.MaturityDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EveAccountEdit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AutoStartBtn);
            this.Controls.Add(this.AddAlramBtn);
            this.Controls.Add(this.RoleEdit);
            this.Controls.Add(this.AlramList);
            this.Name = "AlarmListDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帐号技能列表";
            this.Load += new System.EventHandler(this.AlarmListDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView AlramList;
        private System.Windows.Forms.ColumnHeader EveAccount;
        private System.Windows.Forms.ColumnHeader Remain;
        private System.Windows.Forms.TextBox RoleEdit;
        private System.Windows.Forms.Button AddAlramBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label EveAccountEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker MaturityDate;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AutoStartBtn;
        private System.Windows.Forms.CheckBox ShowAccount;
        private System.Windows.Forms.CheckBox ShowMaturityDate;
        private System.Windows.Forms.CheckBox ShowTimer;
    }
}