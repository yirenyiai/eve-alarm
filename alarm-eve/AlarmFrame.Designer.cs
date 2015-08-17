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
            this.RoleName_1 = new System.Windows.Forms.Label();
            this.MaturityDate_1 = new System.Windows.Forms.Label();
            this.SkillsStatue_1 = new System.Windows.Forms.Label();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayImageList = new System.Windows.Forms.ImageList(this.components);
            this.TrayIconContentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoleName_2 = new System.Windows.Forms.Label();
            this.MaturityDate_2 = new System.Windows.Forms.Label();
            this.SkillsStatue_2 = new System.Windows.Forms.Label();
            this.RoleName_3 = new System.Windows.Forms.Label();
            this.MaturityDate_3 = new System.Windows.Forms.Label();
            this.SkillsStatue_3 = new System.Windows.Forms.Label();
            this.RoleName_4 = new System.Windows.Forms.Label();
            this.MaturityDate_4 = new System.Windows.Forms.Label();
            this.SkillsStatue_4 = new System.Windows.Forms.Label();
            this.RoleName_5 = new System.Windows.Forms.Label();
            this.MaturityDate_5 = new System.Windows.Forms.Label();
            this.SkillsStatue_5 = new System.Windows.Forms.Label();
            this.MinBtn = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.AddBtn = new System.Windows.Forms.PictureBox();
            this.TrayIconContentMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // RoleName_1
            // 
            this.RoleName_1.AutoEllipsis = true;
            this.RoleName_1.AutoSize = true;
            this.RoleName_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoleName_1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RoleName_1.ForeColor = System.Drawing.Color.GreenYellow;
            this.RoleName_1.Location = new System.Drawing.Point(7, 5);
            this.RoleName_1.Name = "RoleName_1";
            this.RoleName_1.Size = new System.Drawing.Size(51, 21);
            this.RoleName_1.TabIndex = 0;
            this.RoleName_1.Text = "名字: ";
            this.RoleName_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_1
            // 
            this.MaturityDate_1.AutoEllipsis = true;
            this.MaturityDate_1.AutoSize = true;
            this.MaturityDate_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaturityDate_1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaturityDate_1.ForeColor = System.Drawing.Color.GreenYellow;
            this.MaturityDate_1.Location = new System.Drawing.Point(7, 28);
            this.MaturityDate_1.Name = "MaturityDate_1";
            this.MaturityDate_1.Size = new System.Drawing.Size(65, 20);
            this.MaturityDate_1.TabIndex = 0;
            this.MaturityDate_1.Text = "完成时间";
            this.MaturityDate_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_1
            // 
            this.SkillsStatue_1.AutoEllipsis = true;
            this.SkillsStatue_1.AutoSize = true;
            this.SkillsStatue_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SkillsStatue_1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SkillsStatue_1.ForeColor = System.Drawing.Color.GreenYellow;
            this.SkillsStatue_1.Location = new System.Drawing.Point(6, 50);
            this.SkillsStatue_1.Name = "SkillsStatue_1";
            this.SkillsStatue_1.Size = new System.Drawing.Size(72, 27);
            this.SkillsStatue_1.TabIndex = 0;
            this.SkillsStatue_1.Text = "倒计时";
            this.SkillsStatue_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
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
            // TrayIconContentMenu
            // 
            this.TrayIconContentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.TrayIconContentMenu.Name = "TrayIconContentMenu";
            this.TrayIconContentMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TrayIconContentMenu.ShowImageMargin = false;
            this.TrayIconContentMenu.ShowItemToolTips = false;
            this.TrayIconContentMenu.Size = new System.Drawing.Size(76, 26);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(75, 22);
            this.ExitMenuItem.Text = "退出";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // RoleName_2
            // 
            this.RoleName_2.AutoEllipsis = true;
            this.RoleName_2.AutoSize = true;
            this.RoleName_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoleName_2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RoleName_2.ForeColor = System.Drawing.Color.GreenYellow;
            this.RoleName_2.Location = new System.Drawing.Point(7, 89);
            this.RoleName_2.Name = "RoleName_2";
            this.RoleName_2.Size = new System.Drawing.Size(51, 21);
            this.RoleName_2.TabIndex = 0;
            this.RoleName_2.Text = "名字: ";
            this.RoleName_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_2
            // 
            this.MaturityDate_2.AutoEllipsis = true;
            this.MaturityDate_2.AutoSize = true;
            this.MaturityDate_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaturityDate_2.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaturityDate_2.ForeColor = System.Drawing.Color.GreenYellow;
            this.MaturityDate_2.Location = new System.Drawing.Point(7, 112);
            this.MaturityDate_2.Name = "MaturityDate_2";
            this.MaturityDate_2.Size = new System.Drawing.Size(65, 20);
            this.MaturityDate_2.TabIndex = 0;
            this.MaturityDate_2.Text = "完成时间";
            this.MaturityDate_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_2
            // 
            this.SkillsStatue_2.AutoEllipsis = true;
            this.SkillsStatue_2.AutoSize = true;
            this.SkillsStatue_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SkillsStatue_2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SkillsStatue_2.ForeColor = System.Drawing.Color.GreenYellow;
            this.SkillsStatue_2.Location = new System.Drawing.Point(6, 133);
            this.SkillsStatue_2.Name = "SkillsStatue_2";
            this.SkillsStatue_2.Size = new System.Drawing.Size(72, 27);
            this.SkillsStatue_2.TabIndex = 0;
            this.SkillsStatue_2.Text = "倒计时";
            this.SkillsStatue_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // RoleName_3
            // 
            this.RoleName_3.AutoEllipsis = true;
            this.RoleName_3.AutoSize = true;
            this.RoleName_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoleName_3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RoleName_3.ForeColor = System.Drawing.Color.GreenYellow;
            this.RoleName_3.Location = new System.Drawing.Point(7, 179);
            this.RoleName_3.Name = "RoleName_3";
            this.RoleName_3.Size = new System.Drawing.Size(51, 21);
            this.RoleName_3.TabIndex = 0;
            this.RoleName_3.Text = "名字: ";
            this.RoleName_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_3
            // 
            this.MaturityDate_3.AutoEllipsis = true;
            this.MaturityDate_3.AutoSize = true;
            this.MaturityDate_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaturityDate_3.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaturityDate_3.ForeColor = System.Drawing.Color.GreenYellow;
            this.MaturityDate_3.Location = new System.Drawing.Point(7, 202);
            this.MaturityDate_3.Name = "MaturityDate_3";
            this.MaturityDate_3.Size = new System.Drawing.Size(65, 20);
            this.MaturityDate_3.TabIndex = 0;
            this.MaturityDate_3.Text = "完成时间";
            this.MaturityDate_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_3
            // 
            this.SkillsStatue_3.AutoEllipsis = true;
            this.SkillsStatue_3.AutoSize = true;
            this.SkillsStatue_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SkillsStatue_3.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SkillsStatue_3.ForeColor = System.Drawing.Color.GreenYellow;
            this.SkillsStatue_3.Location = new System.Drawing.Point(6, 223);
            this.SkillsStatue_3.Name = "SkillsStatue_3";
            this.SkillsStatue_3.Size = new System.Drawing.Size(72, 27);
            this.SkillsStatue_3.TabIndex = 0;
            this.SkillsStatue_3.Text = "倒计时";
            this.SkillsStatue_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // RoleName_4
            // 
            this.RoleName_4.AutoEllipsis = true;
            this.RoleName_4.AutoSize = true;
            this.RoleName_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoleName_4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RoleName_4.ForeColor = System.Drawing.Color.GreenYellow;
            this.RoleName_4.Location = new System.Drawing.Point(7, 273);
            this.RoleName_4.Name = "RoleName_4";
            this.RoleName_4.Size = new System.Drawing.Size(51, 21);
            this.RoleName_4.TabIndex = 0;
            this.RoleName_4.Text = "名字: ";
            this.RoleName_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_4
            // 
            this.MaturityDate_4.AutoEllipsis = true;
            this.MaturityDate_4.AutoSize = true;
            this.MaturityDate_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaturityDate_4.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaturityDate_4.ForeColor = System.Drawing.Color.GreenYellow;
            this.MaturityDate_4.Location = new System.Drawing.Point(7, 296);
            this.MaturityDate_4.Name = "MaturityDate_4";
            this.MaturityDate_4.Size = new System.Drawing.Size(65, 20);
            this.MaturityDate_4.TabIndex = 0;
            this.MaturityDate_4.Text = "完成时间";
            this.MaturityDate_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_4
            // 
            this.SkillsStatue_4.AutoEllipsis = true;
            this.SkillsStatue_4.AutoSize = true;
            this.SkillsStatue_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SkillsStatue_4.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SkillsStatue_4.ForeColor = System.Drawing.Color.GreenYellow;
            this.SkillsStatue_4.Location = new System.Drawing.Point(6, 317);
            this.SkillsStatue_4.Name = "SkillsStatue_4";
            this.SkillsStatue_4.Size = new System.Drawing.Size(72, 27);
            this.SkillsStatue_4.TabIndex = 0;
            this.SkillsStatue_4.Text = "倒计时";
            this.SkillsStatue_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // RoleName_5
            // 
            this.RoleName_5.AutoEllipsis = true;
            this.RoleName_5.AutoSize = true;
            this.RoleName_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoleName_5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RoleName_5.ForeColor = System.Drawing.Color.GreenYellow;
            this.RoleName_5.Location = new System.Drawing.Point(7, 360);
            this.RoleName_5.Name = "RoleName_5";
            this.RoleName_5.Size = new System.Drawing.Size(51, 21);
            this.RoleName_5.TabIndex = 0;
            this.RoleName_5.Text = "名字: ";
            this.RoleName_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_5
            // 
            this.MaturityDate_5.AutoEllipsis = true;
            this.MaturityDate_5.AutoSize = true;
            this.MaturityDate_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaturityDate_5.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaturityDate_5.ForeColor = System.Drawing.Color.GreenYellow;
            this.MaturityDate_5.Location = new System.Drawing.Point(7, 382);
            this.MaturityDate_5.Name = "MaturityDate_5";
            this.MaturityDate_5.Size = new System.Drawing.Size(65, 20);
            this.MaturityDate_5.TabIndex = 0;
            this.MaturityDate_5.Text = "完成时间";
            this.MaturityDate_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_5
            // 
            this.SkillsStatue_5.AutoEllipsis = true;
            this.SkillsStatue_5.AutoSize = true;
            this.SkillsStatue_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SkillsStatue_5.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SkillsStatue_5.ForeColor = System.Drawing.Color.GreenYellow;
            this.SkillsStatue_5.Location = new System.Drawing.Point(6, 404);
            this.SkillsStatue_5.Name = "SkillsStatue_5";
            this.SkillsStatue_5.Size = new System.Drawing.Size(72, 27);
            this.SkillsStatue_5.TabIndex = 0;
            this.SkillsStatue_5.Text = "倒计时";
            this.SkillsStatue_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MinBtn
            // 
            this.MinBtn.Image = global::alarm_eve.Properties.Resources.Min;
            this.MinBtn.Location = new System.Drawing.Point(222, 4);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(22, 13);
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
            this.CloseBtn.Size = new System.Drawing.Size(14, 14);
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
            this.AddBtn.Location = new System.Drawing.Point(247, 0);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(20, 17);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.TabStop = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            this.AddBtn.MouseLeave += new System.EventHandler(this.ImageBtn_Leave);
            this.AddBtn.MouseHover += new System.EventHandler(this.ImageBtn_Hover);
            // 
            // AlarmFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(287, 458);
            this.Controls.Add(this.MinBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SkillsStatue_5);
            this.Controls.Add(this.MaturityDate_5);
            this.Controls.Add(this.SkillsStatue_4);
            this.Controls.Add(this.MaturityDate_4);
            this.Controls.Add(this.SkillsStatue_3);
            this.Controls.Add(this.MaturityDate_3);
            this.Controls.Add(this.RoleName_5);
            this.Controls.Add(this.SkillsStatue_2);
            this.Controls.Add(this.RoleName_4);
            this.Controls.Add(this.MaturityDate_2);
            this.Controls.Add(this.RoleName_3);
            this.Controls.Add(this.SkillsStatue_1);
            this.Controls.Add(this.RoleName_2);
            this.Controls.Add(this.MaturityDate_1);
            this.Controls.Add(this.RoleName_1);
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
            this.TrayIconContentMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoleName_1;
        private System.Windows.Forms.Label MaturityDate_1;
        private System.Windows.Forms.Label SkillsStatue_1;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ImageList TrayImageList;
        private System.Windows.Forms.PictureBox AddBtn;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.PictureBox MinBtn;
        private System.Windows.Forms.ContextMenuStrip TrayIconContentMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.Label RoleName_2;
        private System.Windows.Forms.Label MaturityDate_2;
        private System.Windows.Forms.Label SkillsStatue_2;
        private System.Windows.Forms.Label RoleName_3;
        private System.Windows.Forms.Label MaturityDate_3;
        private System.Windows.Forms.Label SkillsStatue_3;
        private System.Windows.Forms.Label RoleName_4;
        private System.Windows.Forms.Label MaturityDate_4;
        private System.Windows.Forms.Label SkillsStatue_4;
        private System.Windows.Forms.Label RoleName_5;
        private System.Windows.Forms.Label MaturityDate_5;
        private System.Windows.Forms.Label SkillsStatue_5;
    }
}

