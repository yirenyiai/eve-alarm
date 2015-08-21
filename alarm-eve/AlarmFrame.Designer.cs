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
            this.HideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.TrayIconContentMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoleName_1
            // 
            this.RoleName_1.AutoEllipsis = true;
            this.RoleName_1.AutoSize = true;
            this.RoleName_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RoleName_1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleName_1.ForeColor = System.Drawing.Color.SpringGreen;
            this.RoleName_1.Location = new System.Drawing.Point(7, 5);
            this.RoleName_1.Name = "RoleName_1";
            this.RoleName_1.Size = new System.Drawing.Size(63, 19);
            this.RoleName_1.TabIndex = 0;
            this.RoleName_1.Text = "名字: ";
            this.RoleName_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_1
            // 
            this.MaturityDate_1.AutoEllipsis = true;
            this.MaturityDate_1.AutoSize = true;
            this.MaturityDate_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MaturityDate_1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaturityDate_1.ForeColor = System.Drawing.Color.SpringGreen;
            this.MaturityDate_1.Location = new System.Drawing.Point(7, 28);
            this.MaturityDate_1.Name = "MaturityDate_1";
            this.MaturityDate_1.Size = new System.Drawing.Size(81, 19);
            this.MaturityDate_1.TabIndex = 0;
            this.MaturityDate_1.Text = "完成时间";
            this.MaturityDate_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_1
            // 
            this.SkillsStatue_1.AutoEllipsis = true;
            this.SkillsStatue_1.AutoSize = true;
            this.SkillsStatue_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SkillsStatue_1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillsStatue_1.ForeColor = System.Drawing.Color.SpringGreen;
            this.SkillsStatue_1.Location = new System.Drawing.Point(6, 50);
            this.SkillsStatue_1.Name = "SkillsStatue_1";
            this.SkillsStatue_1.Size = new System.Drawing.Size(63, 19);
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
            this.ExitMenuItem,
            this.HideMenuItem,
            this.SettingMenuItem});
            this.TrayIconContentMenu.Name = "TrayIconContentMenu";
            this.TrayIconContentMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TrayIconContentMenu.ShowImageMargin = false;
            this.TrayIconContentMenu.ShowItemToolTips = false;
            this.TrayIconContentMenu.Size = new System.Drawing.Size(76, 70);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(75, 22);
            this.ExitMenuItem.Text = "退出";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // HideMenuItem
            // 
            this.HideMenuItem.Name = "HideMenuItem";
            this.HideMenuItem.Size = new System.Drawing.Size(75, 22);
            this.HideMenuItem.Text = "隐藏";
            this.HideMenuItem.Click += new System.EventHandler(this.HideMenuItem_Click);
            // 
            // SettingMenuItem
            // 
            this.SettingMenuItem.Name = "SettingMenuItem";
            this.SettingMenuItem.Size = new System.Drawing.Size(75, 22);
            this.SettingMenuItem.Text = "设置";
            this.SettingMenuItem.Click += new System.EventHandler(this.SettingMenuItem_Click);
            // 
            // RoleName_2
            // 
            this.RoleName_2.AutoEllipsis = true;
            this.RoleName_2.AutoSize = true;
            this.RoleName_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RoleName_2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleName_2.ForeColor = System.Drawing.Color.SpringGreen;
            this.RoleName_2.Location = new System.Drawing.Point(7, 89);
            this.RoleName_2.Name = "RoleName_2";
            this.RoleName_2.Size = new System.Drawing.Size(63, 19);
            this.RoleName_2.TabIndex = 0;
            this.RoleName_2.Text = "名字: ";
            this.RoleName_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_2
            // 
            this.MaturityDate_2.AutoEllipsis = true;
            this.MaturityDate_2.AutoSize = true;
            this.MaturityDate_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MaturityDate_2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaturityDate_2.ForeColor = System.Drawing.Color.SpringGreen;
            this.MaturityDate_2.Location = new System.Drawing.Point(7, 112);
            this.MaturityDate_2.Name = "MaturityDate_2";
            this.MaturityDate_2.Size = new System.Drawing.Size(81, 19);
            this.MaturityDate_2.TabIndex = 0;
            this.MaturityDate_2.Text = "完成时间";
            this.MaturityDate_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_2
            // 
            this.SkillsStatue_2.AutoEllipsis = true;
            this.SkillsStatue_2.AutoSize = true;
            this.SkillsStatue_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SkillsStatue_2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillsStatue_2.ForeColor = System.Drawing.Color.SpringGreen;
            this.SkillsStatue_2.Location = new System.Drawing.Point(6, 133);
            this.SkillsStatue_2.Name = "SkillsStatue_2";
            this.SkillsStatue_2.Size = new System.Drawing.Size(63, 19);
            this.SkillsStatue_2.TabIndex = 0;
            this.SkillsStatue_2.Text = "倒计时";
            this.SkillsStatue_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // RoleName_3
            // 
            this.RoleName_3.AutoEllipsis = true;
            this.RoleName_3.AutoSize = true;
            this.RoleName_3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RoleName_3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleName_3.ForeColor = System.Drawing.Color.SpringGreen;
            this.RoleName_3.Location = new System.Drawing.Point(7, 179);
            this.RoleName_3.Name = "RoleName_3";
            this.RoleName_3.Size = new System.Drawing.Size(63, 19);
            this.RoleName_3.TabIndex = 0;
            this.RoleName_3.Text = "名字: ";
            this.RoleName_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_3
            // 
            this.MaturityDate_3.AutoEllipsis = true;
            this.MaturityDate_3.AutoSize = true;
            this.MaturityDate_3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MaturityDate_3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaturityDate_3.ForeColor = System.Drawing.Color.SpringGreen;
            this.MaturityDate_3.Location = new System.Drawing.Point(7, 202);
            this.MaturityDate_3.Name = "MaturityDate_3";
            this.MaturityDate_3.Size = new System.Drawing.Size(81, 19);
            this.MaturityDate_3.TabIndex = 0;
            this.MaturityDate_3.Text = "完成时间";
            this.MaturityDate_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_3
            // 
            this.SkillsStatue_3.AutoEllipsis = true;
            this.SkillsStatue_3.AutoSize = true;
            this.SkillsStatue_3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SkillsStatue_3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillsStatue_3.ForeColor = System.Drawing.Color.SpringGreen;
            this.SkillsStatue_3.Location = new System.Drawing.Point(6, 223);
            this.SkillsStatue_3.Name = "SkillsStatue_3";
            this.SkillsStatue_3.Size = new System.Drawing.Size(63, 19);
            this.SkillsStatue_3.TabIndex = 0;
            this.SkillsStatue_3.Text = "倒计时";
            this.SkillsStatue_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // RoleName_4
            // 
            this.RoleName_4.AutoEllipsis = true;
            this.RoleName_4.AutoSize = true;
            this.RoleName_4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RoleName_4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleName_4.ForeColor = System.Drawing.Color.SpringGreen;
            this.RoleName_4.Location = new System.Drawing.Point(7, 273);
            this.RoleName_4.Name = "RoleName_4";
            this.RoleName_4.Size = new System.Drawing.Size(63, 19);
            this.RoleName_4.TabIndex = 0;
            this.RoleName_4.Text = "名字: ";
            this.RoleName_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_4
            // 
            this.MaturityDate_4.AutoEllipsis = true;
            this.MaturityDate_4.AutoSize = true;
            this.MaturityDate_4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MaturityDate_4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaturityDate_4.ForeColor = System.Drawing.Color.SpringGreen;
            this.MaturityDate_4.Location = new System.Drawing.Point(7, 296);
            this.MaturityDate_4.Name = "MaturityDate_4";
            this.MaturityDate_4.Size = new System.Drawing.Size(81, 19);
            this.MaturityDate_4.TabIndex = 0;
            this.MaturityDate_4.Text = "完成时间";
            this.MaturityDate_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_4
            // 
            this.SkillsStatue_4.AutoEllipsis = true;
            this.SkillsStatue_4.AutoSize = true;
            this.SkillsStatue_4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SkillsStatue_4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillsStatue_4.ForeColor = System.Drawing.Color.SpringGreen;
            this.SkillsStatue_4.Location = new System.Drawing.Point(6, 317);
            this.SkillsStatue_4.Name = "SkillsStatue_4";
            this.SkillsStatue_4.Size = new System.Drawing.Size(63, 19);
            this.SkillsStatue_4.TabIndex = 0;
            this.SkillsStatue_4.Text = "倒计时";
            this.SkillsStatue_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // RoleName_5
            // 
            this.RoleName_5.AutoEllipsis = true;
            this.RoleName_5.AutoSize = true;
            this.RoleName_5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RoleName_5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleName_5.ForeColor = System.Drawing.Color.SpringGreen;
            this.RoleName_5.Location = new System.Drawing.Point(7, 360);
            this.RoleName_5.Name = "RoleName_5";
            this.RoleName_5.Size = new System.Drawing.Size(63, 19);
            this.RoleName_5.TabIndex = 0;
            this.RoleName_5.Text = "名字: ";
            this.RoleName_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_5
            // 
            this.MaturityDate_5.AutoEllipsis = true;
            this.MaturityDate_5.AutoSize = true;
            this.MaturityDate_5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MaturityDate_5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaturityDate_5.ForeColor = System.Drawing.Color.SpringGreen;
            this.MaturityDate_5.Location = new System.Drawing.Point(7, 382);
            this.MaturityDate_5.Name = "MaturityDate_5";
            this.MaturityDate_5.Size = new System.Drawing.Size(81, 19);
            this.MaturityDate_5.TabIndex = 0;
            this.MaturityDate_5.Text = "完成时间";
            this.MaturityDate_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_5
            // 
            this.SkillsStatue_5.AutoEllipsis = true;
            this.SkillsStatue_5.AutoSize = true;
            this.SkillsStatue_5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SkillsStatue_5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillsStatue_5.ForeColor = System.Drawing.Color.SpringGreen;
            this.SkillsStatue_5.Location = new System.Drawing.Point(6, 404);
            this.SkillsStatue_5.Name = "SkillsStatue_5";
            this.SkillsStatue_5.Size = new System.Drawing.Size(63, 19);
            this.SkillsStatue_5.TabIndex = 0;
            this.SkillsStatue_5.Text = "倒计时";
            this.SkillsStatue_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // AlarmFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(362, 458);
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
            this.MinimizeBox = false;
            this.Name = "AlarmFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计时器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlarmFrame_FormClosing);
            this.Load += new System.EventHandler(this.AlarmFrame_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AlarmFrame_MouseDown);
            this.TrayIconContentMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoleName_1;
        private System.Windows.Forms.Label MaturityDate_1;
        private System.Windows.Forms.Label SkillsStatue_1;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ImageList TrayImageList;
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
        private System.Windows.Forms.ToolStripMenuItem HideMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingMenuItem;
    }
}

