namespace alarm_eve
{
    partial class AlarmFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmFrame));
            this.RoleName = new System.Windows.Forms.Label();
            this.Msg = new System.Windows.Forms.Label();
            this.SkillsStatue = new System.Windows.Forms.Label();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayImageList = new System.Windows.Forms.ImageList(this.components);
            this.MinBtn = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.AddBtn = new System.Windows.Forms.PictureBox();
            this.TrayIconContentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MinBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            this.TrayIconContentMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoleName
            // 
            this.RoleName.AutoSize = true;
            this.RoleName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RoleName.ForeColor = System.Drawing.Color.GreenYellow;
            this.RoleName.Location = new System.Drawing.Point(7, 5);
            this.RoleName.Name = "RoleName";
            this.RoleName.Size = new System.Drawing.Size(51, 21);
            this.RoleName.TabIndex = 0;
            this.RoleName.Text = "名字: ";
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Msg.ForeColor = System.Drawing.Color.GreenYellow;
            this.Msg.Location = new System.Drawing.Point(7, 26);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(65, 20);
            this.Msg.TabIndex = 0;
            this.Msg.Text = "完成时间";
            // 
            // SkillsStatue
            // 
            this.SkillsStatue.AutoSize = true;
            this.SkillsStatue.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SkillsStatue.ForeColor = System.Drawing.Color.GreenYellow;
            this.SkillsStatue.Location = new System.Drawing.Point(6, 46);
            this.SkillsStatue.Name = "SkillsStatue";
            this.SkillsStatue.Size = new System.Drawing.Size(72, 27);
            this.SkillsStatue.TabIndex = 0;
            this.SkillsStatue.Text = "倒计时";
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "EVE-技能记录";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // TrayImageList
            // 
            this.TrayImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TrayImageList.ImageStream")));
            this.TrayImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TrayImageList.Images.SetKeyName(0, "TrayIcon.ico");
            this.TrayImageList.Images.SetKeyName(1, "TrayIconNULL.ico");
            // 
            // MinBtn
            // 
            this.MinBtn.Image = global::alarm_eve.Properties.Resources.Min;
            this.MinBtn.Location = new System.Drawing.Point(222, 4);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(22, 12);
            this.MinBtn.TabIndex = 3;
            this.MinBtn.TabStop = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            this.MinBtn.MouseLeave += new System.EventHandler(this.ImageBtn_Leave);
            this.MinBtn.MouseHover += new System.EventHandler(this.ImageBtn_Hover);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.CloseBtn.Image = global::alarm_eve.Properties.Resources.Close;
            this.CloseBtn.Location = new System.Drawing.Point(267, 1);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(14, 13);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            this.CloseBtn.MouseLeave += new System.EventHandler(this.ImageBtn_Leave);
            this.CloseBtn.MouseHover += new System.EventHandler(this.ImageBtn_Hover);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.Image = global::alarm_eve.Properties.Resources.add1;
            this.AddBtn.Location = new System.Drawing.Point(241, -5);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(25, 24);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.TabStop = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            this.AddBtn.MouseLeave += new System.EventHandler(this.ImageBtn_Leave);
            this.AddBtn.MouseHover += new System.EventHandler(this.ImageBtn_Hover);
            // 
            // TrayIconContentMenu
            // 
            this.TrayIconContentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.TrayIconContentMenu.Name = "TrayIconContentMenu";
            this.TrayIconContentMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TrayIconContentMenu.ShowImageMargin = false;
            this.TrayIconContentMenu.ShowItemToolTips = false;
            this.TrayIconContentMenu.Size = new System.Drawing.Size(128, 48);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ExitMenuItem.Text = "退出";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // AlarmFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(287, 83);
            this.Controls.Add(this.MinBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SkillsStatue);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.RoleName);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlarmFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计时器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlarmFrame_FormClosing);
            this.Load += new System.EventHandler(this.AlarmFrame_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AlarmFrame_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.MinBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            this.TrayIconContentMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoleName;
        private System.Windows.Forms.Label Msg;
        private System.Windows.Forms.Label SkillsStatue;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ImageList TrayImageList;
        private System.Windows.Forms.PictureBox AddBtn;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.PictureBox MinBtn;
        private System.Windows.Forms.ContextMenuStrip TrayIconContentMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
    }
}

