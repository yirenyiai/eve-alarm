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
            this.SettingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AsyncDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DockMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WeatherServiceGroup = new System.Windows.Forms.GroupBox();
            this.WeatherSDLabel = new System.Windows.Forms.Label();
            this.WeatherWSLabel = new System.Windows.Forms.Label();
            this.WeatherWDLabel = new System.Windows.Forms.Label();
            this.WeatherTempLabel = new System.Windows.Forms.Label();
            this.WeatherUpdateTimeLabel = new System.Windows.Forms.Label();
            this.WeatherCityLabel = new System.Windows.Forms.Label();
            this.CountdownServiceGroup = new System.Windows.Forms.GroupBox();
            this.TrayIconContentMenu.SuspendLayout();
            this.WeatherServiceGroup.SuspendLayout();
            this.CountdownServiceGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoleName_1
            // 
            this.RoleName_1.AutoEllipsis = true;
            this.RoleName_1.AutoSize = true;
            this.RoleName_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RoleName_1.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleName_1.ForeColor = System.Drawing.Color.SpringGreen;
            this.RoleName_1.Location = new System.Drawing.Point(6, 27);
            this.RoleName_1.Name = "RoleName_1";
            this.RoleName_1.Size = new System.Drawing.Size(56, 17);
            this.RoleName_1.TabIndex = 0;
            this.RoleName_1.Text = "名字: ";
            this.RoleName_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_1
            // 
            this.MaturityDate_1.AutoEllipsis = true;
            this.MaturityDate_1.AutoSize = true;
            this.MaturityDate_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MaturityDate_1.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaturityDate_1.ForeColor = System.Drawing.Color.SpringGreen;
            this.MaturityDate_1.Location = new System.Drawing.Point(6, 50);
            this.MaturityDate_1.Name = "MaturityDate_1";
            this.MaturityDate_1.Size = new System.Drawing.Size(72, 17);
            this.MaturityDate_1.TabIndex = 0;
            this.MaturityDate_1.Text = "完成时间";
            this.MaturityDate_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_1
            // 
            this.SkillsStatue_1.AutoEllipsis = true;
            this.SkillsStatue_1.AutoSize = true;
            this.SkillsStatue_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SkillsStatue_1.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillsStatue_1.ForeColor = System.Drawing.Color.SpringGreen;
            this.SkillsStatue_1.Location = new System.Drawing.Point(5, 72);
            this.SkillsStatue_1.Name = "SkillsStatue_1";
            this.SkillsStatue_1.Size = new System.Drawing.Size(56, 17);
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
            this.SettingMenuItem,
            this.AsyncDataMenuItem,
            this.DockMenuItem,
            this.HideMenuItem,
            this.ExitMenuItem});
            this.TrayIconContentMenu.Name = "TrayIconContentMenu";
            this.TrayIconContentMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TrayIconContentMenu.ShowImageMargin = false;
            this.TrayIconContentMenu.ShowItemToolTips = false;
            this.TrayIconContentMenu.Size = new System.Drawing.Size(100, 114);
            // 
            // SettingMenuItem
            // 
            this.SettingMenuItem.Name = "SettingMenuItem";
            this.SettingMenuItem.Size = new System.Drawing.Size(99, 22);
            this.SettingMenuItem.Text = "设置";
            this.SettingMenuItem.Click += new System.EventHandler(this.SettingMenuItem_Click);
            // 
            // AsyncDataMenuItem
            // 
            this.AsyncDataMenuItem.Name = "AsyncDataMenuItem";
            this.AsyncDataMenuItem.Size = new System.Drawing.Size(99, 22);
            this.AsyncDataMenuItem.Text = "同步数据";
            this.AsyncDataMenuItem.Click += new System.EventHandler(this.AsyncDataMenuItem_Click);
            // 
            // DockMenuItem
            // 
            this.DockMenuItem.Name = "DockMenuItem";
            this.DockMenuItem.Size = new System.Drawing.Size(99, 22);
            this.DockMenuItem.Text = "固定";
            this.DockMenuItem.Click += new System.EventHandler(this.DockMenuItem_Click);
            // 
            // HideMenuItem
            // 
            this.HideMenuItem.Name = "HideMenuItem";
            this.HideMenuItem.Size = new System.Drawing.Size(99, 22);
            this.HideMenuItem.Text = "隐藏";
            this.HideMenuItem.Click += new System.EventHandler(this.HideMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(99, 22);
            this.ExitMenuItem.Text = "退出";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // RoleName_2
            // 
            this.RoleName_2.AutoEllipsis = true;
            this.RoleName_2.AutoSize = true;
            this.RoleName_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RoleName_2.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleName_2.ForeColor = System.Drawing.Color.SpringGreen;
            this.RoleName_2.Location = new System.Drawing.Point(6, 111);
            this.RoleName_2.Name = "RoleName_2";
            this.RoleName_2.Size = new System.Drawing.Size(56, 17);
            this.RoleName_2.TabIndex = 0;
            this.RoleName_2.Text = "名字: ";
            this.RoleName_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_2
            // 
            this.MaturityDate_2.AutoEllipsis = true;
            this.MaturityDate_2.AutoSize = true;
            this.MaturityDate_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MaturityDate_2.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaturityDate_2.ForeColor = System.Drawing.Color.SpringGreen;
            this.MaturityDate_2.Location = new System.Drawing.Point(6, 134);
            this.MaturityDate_2.Name = "MaturityDate_2";
            this.MaturityDate_2.Size = new System.Drawing.Size(72, 17);
            this.MaturityDate_2.TabIndex = 0;
            this.MaturityDate_2.Text = "完成时间";
            this.MaturityDate_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_2
            // 
            this.SkillsStatue_2.AutoEllipsis = true;
            this.SkillsStatue_2.AutoSize = true;
            this.SkillsStatue_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SkillsStatue_2.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillsStatue_2.ForeColor = System.Drawing.Color.SpringGreen;
            this.SkillsStatue_2.Location = new System.Drawing.Point(5, 155);
            this.SkillsStatue_2.Name = "SkillsStatue_2";
            this.SkillsStatue_2.Size = new System.Drawing.Size(56, 17);
            this.SkillsStatue_2.TabIndex = 0;
            this.SkillsStatue_2.Text = "倒计时";
            this.SkillsStatue_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // RoleName_3
            // 
            this.RoleName_3.AutoEllipsis = true;
            this.RoleName_3.AutoSize = true;
            this.RoleName_3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RoleName_3.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleName_3.ForeColor = System.Drawing.Color.SpringGreen;
            this.RoleName_3.Location = new System.Drawing.Point(6, 201);
            this.RoleName_3.Name = "RoleName_3";
            this.RoleName_3.Size = new System.Drawing.Size(56, 17);
            this.RoleName_3.TabIndex = 0;
            this.RoleName_3.Text = "名字: ";
            this.RoleName_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_3
            // 
            this.MaturityDate_3.AutoEllipsis = true;
            this.MaturityDate_3.AutoSize = true;
            this.MaturityDate_3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MaturityDate_3.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaturityDate_3.ForeColor = System.Drawing.Color.SpringGreen;
            this.MaturityDate_3.Location = new System.Drawing.Point(6, 224);
            this.MaturityDate_3.Name = "MaturityDate_3";
            this.MaturityDate_3.Size = new System.Drawing.Size(72, 17);
            this.MaturityDate_3.TabIndex = 0;
            this.MaturityDate_3.Text = "完成时间";
            this.MaturityDate_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_3
            // 
            this.SkillsStatue_3.AutoEllipsis = true;
            this.SkillsStatue_3.AutoSize = true;
            this.SkillsStatue_3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SkillsStatue_3.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillsStatue_3.ForeColor = System.Drawing.Color.SpringGreen;
            this.SkillsStatue_3.Location = new System.Drawing.Point(5, 245);
            this.SkillsStatue_3.Name = "SkillsStatue_3";
            this.SkillsStatue_3.Size = new System.Drawing.Size(56, 17);
            this.SkillsStatue_3.TabIndex = 0;
            this.SkillsStatue_3.Text = "倒计时";
            this.SkillsStatue_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // RoleName_4
            // 
            this.RoleName_4.AutoEllipsis = true;
            this.RoleName_4.AutoSize = true;
            this.RoleName_4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RoleName_4.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleName_4.ForeColor = System.Drawing.Color.SpringGreen;
            this.RoleName_4.Location = new System.Drawing.Point(6, 295);
            this.RoleName_4.Name = "RoleName_4";
            this.RoleName_4.Size = new System.Drawing.Size(56, 17);
            this.RoleName_4.TabIndex = 0;
            this.RoleName_4.Text = "名字: ";
            this.RoleName_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_4
            // 
            this.MaturityDate_4.AutoEllipsis = true;
            this.MaturityDate_4.AutoSize = true;
            this.MaturityDate_4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MaturityDate_4.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaturityDate_4.ForeColor = System.Drawing.Color.SpringGreen;
            this.MaturityDate_4.Location = new System.Drawing.Point(6, 318);
            this.MaturityDate_4.Name = "MaturityDate_4";
            this.MaturityDate_4.Size = new System.Drawing.Size(72, 17);
            this.MaturityDate_4.TabIndex = 0;
            this.MaturityDate_4.Text = "完成时间";
            this.MaturityDate_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_4
            // 
            this.SkillsStatue_4.AutoEllipsis = true;
            this.SkillsStatue_4.AutoSize = true;
            this.SkillsStatue_4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SkillsStatue_4.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillsStatue_4.ForeColor = System.Drawing.Color.SpringGreen;
            this.SkillsStatue_4.Location = new System.Drawing.Point(5, 339);
            this.SkillsStatue_4.Name = "SkillsStatue_4";
            this.SkillsStatue_4.Size = new System.Drawing.Size(56, 17);
            this.SkillsStatue_4.TabIndex = 0;
            this.SkillsStatue_4.Text = "倒计时";
            this.SkillsStatue_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // RoleName_5
            // 
            this.RoleName_5.AutoEllipsis = true;
            this.RoleName_5.AutoSize = true;
            this.RoleName_5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RoleName_5.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleName_5.ForeColor = System.Drawing.Color.SpringGreen;
            this.RoleName_5.Location = new System.Drawing.Point(6, 382);
            this.RoleName_5.Name = "RoleName_5";
            this.RoleName_5.Size = new System.Drawing.Size(56, 17);
            this.RoleName_5.TabIndex = 0;
            this.RoleName_5.Text = "名字: ";
            this.RoleName_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // MaturityDate_5
            // 
            this.MaturityDate_5.AutoEllipsis = true;
            this.MaturityDate_5.AutoSize = true;
            this.MaturityDate_5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MaturityDate_5.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaturityDate_5.ForeColor = System.Drawing.Color.SpringGreen;
            this.MaturityDate_5.Location = new System.Drawing.Point(6, 404);
            this.MaturityDate_5.Name = "MaturityDate_5";
            this.MaturityDate_5.Size = new System.Drawing.Size(72, 17);
            this.MaturityDate_5.TabIndex = 0;
            this.MaturityDate_5.Text = "完成时间";
            this.MaturityDate_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // SkillsStatue_5
            // 
            this.SkillsStatue_5.AutoEllipsis = true;
            this.SkillsStatue_5.AutoSize = true;
            this.SkillsStatue_5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SkillsStatue_5.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillsStatue_5.ForeColor = System.Drawing.Color.SpringGreen;
            this.SkillsStatue_5.Location = new System.Drawing.Point(5, 426);
            this.SkillsStatue_5.Name = "SkillsStatue_5";
            this.SkillsStatue_5.Size = new System.Drawing.Size(56, 17);
            this.SkillsStatue_5.TabIndex = 0;
            this.SkillsStatue_5.Text = "倒计时";
            this.SkillsStatue_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "城市:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "温度";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(179, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "风向";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(179, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "更新时间:";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(25, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "风力:";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(179, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "相对湿度:";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // WeatherServiceGroup
            // 
            this.WeatherServiceGroup.Controls.Add(this.WeatherSDLabel);
            this.WeatherServiceGroup.Controls.Add(this.WeatherWSLabel);
            this.WeatherServiceGroup.Controls.Add(this.WeatherWDLabel);
            this.WeatherServiceGroup.Controls.Add(this.WeatherTempLabel);
            this.WeatherServiceGroup.Controls.Add(this.WeatherUpdateTimeLabel);
            this.WeatherServiceGroup.Controls.Add(this.WeatherCityLabel);
            this.WeatherServiceGroup.Controls.Add(this.label1);
            this.WeatherServiceGroup.Controls.Add(this.label2);
            this.WeatherServiceGroup.Controls.Add(this.label3);
            this.WeatherServiceGroup.Controls.Add(this.label4);
            this.WeatherServiceGroup.Controls.Add(this.label5);
            this.WeatherServiceGroup.Controls.Add(this.label6);
            this.WeatherServiceGroup.ForeColor = System.Drawing.Color.Tomato;
            this.WeatherServiceGroup.Location = new System.Drawing.Point(14, 4);
            this.WeatherServiceGroup.Name = "WeatherServiceGroup";
            this.WeatherServiceGroup.Size = new System.Drawing.Size(336, 100);
            this.WeatherServiceGroup.TabIndex = 1;
            this.WeatherServiceGroup.TabStop = false;
            this.WeatherServiceGroup.Text = "天气预报";
            // 
            // WeatherSDLabel
            // 
            this.WeatherSDLabel.AutoEllipsis = true;
            this.WeatherSDLabel.AutoSize = true;
            this.WeatherSDLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WeatherSDLabel.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherSDLabel.ForeColor = System.Drawing.Color.Tomato;
            this.WeatherSDLabel.Location = new System.Drawing.Point(265, 67);
            this.WeatherSDLabel.Name = "WeatherSDLabel";
            this.WeatherSDLabel.Size = new System.Drawing.Size(16, 17);
            this.WeatherSDLabel.TabIndex = 0;
            this.WeatherSDLabel.Text = "-";
            this.WeatherSDLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // WeatherWSLabel
            // 
            this.WeatherWSLabel.AutoEllipsis = true;
            this.WeatherWSLabel.AutoSize = true;
            this.WeatherWSLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WeatherWSLabel.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherWSLabel.ForeColor = System.Drawing.Color.Tomato;
            this.WeatherWSLabel.Location = new System.Drawing.Point(89, 67);
            this.WeatherWSLabel.Name = "WeatherWSLabel";
            this.WeatherWSLabel.Size = new System.Drawing.Size(16, 17);
            this.WeatherWSLabel.TabIndex = 0;
            this.WeatherWSLabel.Text = "-";
            this.WeatherWSLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // WeatherWDLabel
            // 
            this.WeatherWDLabel.AutoEllipsis = true;
            this.WeatherWDLabel.AutoSize = true;
            this.WeatherWDLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WeatherWDLabel.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherWDLabel.ForeColor = System.Drawing.Color.Tomato;
            this.WeatherWDLabel.Location = new System.Drawing.Point(265, 41);
            this.WeatherWDLabel.Name = "WeatherWDLabel";
            this.WeatherWDLabel.Size = new System.Drawing.Size(16, 17);
            this.WeatherWDLabel.TabIndex = 0;
            this.WeatherWDLabel.Text = "-";
            this.WeatherWDLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // WeatherTempLabel
            // 
            this.WeatherTempLabel.AutoEllipsis = true;
            this.WeatherTempLabel.AutoSize = true;
            this.WeatherTempLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WeatherTempLabel.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherTempLabel.ForeColor = System.Drawing.Color.Tomato;
            this.WeatherTempLabel.Location = new System.Drawing.Point(89, 41);
            this.WeatherTempLabel.Name = "WeatherTempLabel";
            this.WeatherTempLabel.Size = new System.Drawing.Size(16, 17);
            this.WeatherTempLabel.TabIndex = 0;
            this.WeatherTempLabel.Text = "-";
            this.WeatherTempLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // WeatherUpdateTimeLabel
            // 
            this.WeatherUpdateTimeLabel.AutoEllipsis = true;
            this.WeatherUpdateTimeLabel.AutoSize = true;
            this.WeatherUpdateTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WeatherUpdateTimeLabel.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherUpdateTimeLabel.ForeColor = System.Drawing.Color.Tomato;
            this.WeatherUpdateTimeLabel.Location = new System.Drawing.Point(265, 14);
            this.WeatherUpdateTimeLabel.Name = "WeatherUpdateTimeLabel";
            this.WeatherUpdateTimeLabel.Size = new System.Drawing.Size(16, 17);
            this.WeatherUpdateTimeLabel.TabIndex = 0;
            this.WeatherUpdateTimeLabel.Text = "-";
            this.WeatherUpdateTimeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // WeatherCityLabel
            // 
            this.WeatherCityLabel.AutoEllipsis = true;
            this.WeatherCityLabel.AutoSize = true;
            this.WeatherCityLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WeatherCityLabel.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherCityLabel.ForeColor = System.Drawing.Color.Tomato;
            this.WeatherCityLabel.Location = new System.Drawing.Point(89, 14);
            this.WeatherCityLabel.Name = "WeatherCityLabel";
            this.WeatherCityLabel.Size = new System.Drawing.Size(16, 17);
            this.WeatherCityLabel.TabIndex = 0;
            this.WeatherCityLabel.Text = "-";
            this.WeatherCityLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillsStatue_5_MouseDown);
            // 
            // CountdownServiceGroup
            // 
            this.CountdownServiceGroup.Controls.Add(this.RoleName_1);
            this.CountdownServiceGroup.Controls.Add(this.MaturityDate_1);
            this.CountdownServiceGroup.Controls.Add(this.RoleName_2);
            this.CountdownServiceGroup.Controls.Add(this.SkillsStatue_5);
            this.CountdownServiceGroup.Controls.Add(this.SkillsStatue_1);
            this.CountdownServiceGroup.Controls.Add(this.MaturityDate_5);
            this.CountdownServiceGroup.Controls.Add(this.RoleName_3);
            this.CountdownServiceGroup.Controls.Add(this.SkillsStatue_4);
            this.CountdownServiceGroup.Controls.Add(this.MaturityDate_2);
            this.CountdownServiceGroup.Controls.Add(this.MaturityDate_4);
            this.CountdownServiceGroup.Controls.Add(this.RoleName_4);
            this.CountdownServiceGroup.Controls.Add(this.SkillsStatue_3);
            this.CountdownServiceGroup.Controls.Add(this.SkillsStatue_2);
            this.CountdownServiceGroup.Controls.Add(this.MaturityDate_3);
            this.CountdownServiceGroup.Controls.Add(this.RoleName_5);
            this.CountdownServiceGroup.ForeColor = System.Drawing.Color.SpringGreen;
            this.CountdownServiceGroup.Location = new System.Drawing.Point(14, 110);
            this.CountdownServiceGroup.Name = "CountdownServiceGroup";
            this.CountdownServiceGroup.Size = new System.Drawing.Size(335, 481);
            this.CountdownServiceGroup.TabIndex = 2;
            this.CountdownServiceGroup.TabStop = false;
            this.CountdownServiceGroup.Text = "计时服务";
            // 
            // AlarmFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(362, 616);
            this.Controls.Add(this.CountdownServiceGroup);
            this.Controls.Add(this.WeatherServiceGroup);
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
            this.WeatherServiceGroup.ResumeLayout(false);
            this.WeatherServiceGroup.PerformLayout();
            this.CountdownServiceGroup.ResumeLayout(false);
            this.CountdownServiceGroup.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ToolStripMenuItem DockMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AsyncDataMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox WeatherServiceGroup;
        private System.Windows.Forms.GroupBox CountdownServiceGroup;
        private System.Windows.Forms.Label WeatherSDLabel;
        private System.Windows.Forms.Label WeatherWSLabel;
        private System.Windows.Forms.Label WeatherWDLabel;
        private System.Windows.Forms.Label WeatherTempLabel;
        private System.Windows.Forms.Label WeatherUpdateTimeLabel;
        private System.Windows.Forms.Label WeatherCityLabel;
    }
}

