namespace OSNCrawler
{
    partial class FrmCrawler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrawler));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSb = new System.Windows.Forms.Button();
            this.BtnFF = new System.Windows.Forms.Button();
            this.BtnDfs = new System.Windows.Forms.Button();
            this.BtnPath = new System.Windows.Forms.Button();
            this.BtnCrawl = new System.Windows.Forms.Button();
            this.LblDistance = new System.Windows.Forms.Label();
            this.NumUp = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.TxtURL = new System.Windows.Forms.TextBox();
            this.LblUrl = new System.Windows.Forms.Label();
            this.statusPanelURLS = new System.Windows.Forms.StatusBarPanel();
            this.statusPanelProgress = new System.Windows.Forms.StatusBarPanel();
            this.statusPanelCPU = new System.Windows.Forms.StatusBarPanel();
            this.statusPanelMem = new System.Windows.Forms.StatusBarPanel();
            this.StatusBar = new System.Windows.Forms.StatusBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabCrawl = new System.Windows.Forms.TabPage();
            this.LstCrawl = new System.Windows.Forms.ListView();
            this.Row = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FriendID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoadProgress = new System.Windows.Forms.ProgressBar();
            this.SavePath = new System.Windows.Forms.SaveFileDialog();
            this.timerMem = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelURLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelMem)).BeginInit();
            this.panel3.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TabCrawl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnSb);
            this.panel1.Controls.Add(this.BtnFF);
            this.panel1.Controls.Add(this.BtnDfs);
            this.panel1.Controls.Add(this.BtnPath);
            this.panel1.Controls.Add(this.BtnCrawl);
            this.panel1.Controls.Add(this.LblDistance);
            this.panel1.Controls.Add(this.NumUp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtPath);
            this.panel1.Controls.Add(this.TxtURL);
            this.panel1.Controls.Add(this.LblUrl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 116);
            this.panel1.TabIndex = 123;
            // 
            // BtnSb
            // 
            this.BtnSb.Location = new System.Drawing.Point(85, 76);
            this.BtnSb.Name = "BtnSb";
            this.BtnSb.Size = new System.Drawing.Size(75, 23);
            this.BtnSb.TabIndex = 148;
            this.BtnSb.Text = "SB";
            this.BtnSb.UseVisualStyleBackColor = true;
            this.BtnSb.Click += new System.EventHandler(this.BtnSb_Click);
            // 
            // BtnFF
            // 
            this.BtnFF.Location = new System.Drawing.Point(182, 76);
            this.BtnFF.Name = "BtnFF";
            this.BtnFF.Size = new System.Drawing.Size(75, 23);
            this.BtnFF.TabIndex = 147;
            this.BtnFF.Text = "FF";
            this.BtnFF.UseVisualStyleBackColor = true;
            this.BtnFF.Click += new System.EventHandler(this.BtnFF_Click);
            // 
            // BtnDfs
            // 
            this.BtnDfs.Location = new System.Drawing.Point(279, 76);
            this.BtnDfs.Name = "BtnDfs";
            this.BtnDfs.Size = new System.Drawing.Size(75, 23);
            this.BtnDfs.TabIndex = 146;
            this.BtnDfs.Text = "DFS";
            this.BtnDfs.UseVisualStyleBackColor = true;
            this.BtnDfs.Click += new System.EventHandler(this.BtnDfs_Click);
            // 
            // BtnPath
            // 
            this.BtnPath.Location = new System.Drawing.Point(86, 43);
            this.BtnPath.Name = "BtnPath";
            this.BtnPath.Size = new System.Drawing.Size(75, 24);
            this.BtnPath.TabIndex = 145;
            this.BtnPath.Text = "Path";
            this.BtnPath.UseVisualStyleBackColor = true;
            this.BtnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // BtnCrawl
            // 
            this.BtnCrawl.Location = new System.Drawing.Point(375, 76);
            this.BtnCrawl.Name = "BtnCrawl";
            this.BtnCrawl.Size = new System.Drawing.Size(75, 23);
            this.BtnCrawl.TabIndex = 124;
            this.BtnCrawl.Text = "BFS";
            this.BtnCrawl.UseVisualStyleBackColor = true;
            this.BtnCrawl.Click += new System.EventHandler(this.BtnCrawl_Click);
            // 
            // LblDistance
            // 
            this.LblDistance.AutoSize = true;
            this.LblDistance.Location = new System.Drawing.Point(544, 76);
            this.LblDistance.Name = "LblDistance";
            this.LblDistance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblDistance.Size = new System.Drawing.Size(100, 13);
            this.LblDistance.TabIndex = 144;
            this.LblDistance.Text = "حداکثر تعداد کاربران:";
            // 
            // NumUp
            // 
            this.NumUp.Location = new System.Drawing.Point(483, 74);
            this.NumUp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumUp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUp.Name = "NumUp";
            this.NumUp.Size = new System.Drawing.Size(55, 21);
            this.NumUp.TabIndex = 143;
            this.NumUp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 49);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 142;
            this.label1.Text = "مسیر فایل های پیمایش:";
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(179, 47);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPath.Size = new System.Drawing.Size(359, 21);
            this.TxtPath.TabIndex = 139;
            this.TxtPath.Text = "C:\\Users\\Payamnoor\\Desktop\\Hammihan Files";
            // 
            // TxtURL
            // 
            this.TxtURL.Location = new System.Drawing.Point(179, 17);
            this.TxtURL.Multiline = true;
            this.TxtURL.Name = "TxtURL";
            this.TxtURL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtURL.Size = new System.Drawing.Size(359, 23);
            this.TxtURL.TabIndex = 123;
            this.TxtURL.Text = "http://www.hammihan.com/profile/admin";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(544, 20);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblUrl.Size = new System.Drawing.Size(112, 13);
            this.LblUrl.TabIndex = 121;
            this.LblUrl.Text = "آدرس پیوندهای شروع:";
            // 
            // statusPanelURLS
            // 
            this.statusPanelURLS.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusPanelURLS.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusPanelURLS.Name = "statusPanelURLS";
            this.statusPanelURLS.ToolTipText = "View total parsed uris";
            this.statusPanelURLS.Width = 10;
            // 
            // statusPanelProgress
            // 
            this.statusPanelProgress.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusPanelProgress.Name = "statusPanelProgress";
            this.statusPanelProgress.ToolTipText = "View total hits count";
            this.statusPanelProgress.Width = 95;
            // 
            // statusPanelCPU
            // 
            this.statusPanelCPU.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusPanelCPU.Name = "statusPanelCPU";
            this.statusPanelCPU.ToolTipText = "CPU usage";
            this.statusPanelCPU.Width = 140;
            // 
            // statusPanelMem
            // 
            this.statusPanelMem.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusPanelMem.Name = "statusPanelMem";
            this.statusPanelMem.ToolTipText = "Available memory";
            this.statusPanelMem.Width = 120;
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 338);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusPanelMem,
            this.statusPanelCPU,
            this.statusPanelProgress,
            this.statusPanelURLS});
            this.StatusBar.ShowPanels = true;
            this.StatusBar.Size = new System.Drawing.Size(770, 22);
            this.StatusBar.TabIndex = 121;
            this.StatusBar.Text = "Ready";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.TabControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 222);
            this.panel3.TabIndex = 127;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabCrawl);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.RightToLeftLayout = true;
            this.TabControl.SelectedIndex = 0;
            this.TabControl.ShowToolTips = true;
            this.TabControl.Size = new System.Drawing.Size(766, 218);
            this.TabControl.TabIndex = 85;
            this.TabControl.Tag = "Main Tab";
            // 
            // TabCrawl
            // 
            this.TabCrawl.Controls.Add(this.LstCrawl);
            this.TabCrawl.ImageIndex = 6;
            this.TabCrawl.Location = new System.Drawing.Point(4, 22);
            this.TabCrawl.Name = "TabCrawl";
            this.TabCrawl.Size = new System.Drawing.Size(758, 192);
            this.TabCrawl.TabIndex = 3;
            this.TabCrawl.Text = "کاربران پیمایش شده";
            this.TabCrawl.UseVisualStyleBackColor = true;
            // 
            // LstCrawl
            // 
            this.LstCrawl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LstCrawl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Row,
            this.UserID,
            this.FriendID});
            this.LstCrawl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstCrawl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LstCrawl.FullRowSelect = true;
            this.LstCrawl.GridLines = true;
            this.LstCrawl.HideSelection = false;
            this.LstCrawl.Location = new System.Drawing.Point(0, 0);
            this.LstCrawl.MultiSelect = false;
            this.LstCrawl.Name = "LstCrawl";
            this.LstCrawl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LstCrawl.Size = new System.Drawing.Size(758, 192);
            this.LstCrawl.TabIndex = 86;
            this.LstCrawl.UseCompatibleStateImageBehavior = false;
            this.LstCrawl.View = System.Windows.Forms.View.Details;
            // 
            // Row
            // 
            this.Row.Text = "Row";
            this.Row.Width = 50;
            // 
            // UserID
            // 
            this.UserID.Text = "UserID";
            this.UserID.Width = 100;
            // 
            // FriendID
            // 
            this.FriendID.Text = "FriendID";
            this.FriendID.Width = 100;
            // 
            // LoadProgress
            // 
            this.LoadProgress.Location = new System.Drawing.Point(262, 342);
            this.LoadProgress.Name = "LoadProgress";
            this.LoadProgress.Size = new System.Drawing.Size(85, 14);
            this.LoadProgress.TabIndex = 130;
            // 
            // timerMem
            // 
            this.timerMem.Enabled = true;
            this.timerMem.Interval = 10000;
            this.timerMem.Tick += new System.EventHandler(this.timerMem_Tick);
            // 
            // FrmCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 360);
            this.Controls.Add(this.LoadProgress);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusBar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCrawler";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کاوشگر شبکه اجتماعی  هم میهن";
            this.Load += new System.EventHandler(this.FrmOSNCrawler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelURLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelMem)).EndInit();
            this.panel3.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.TabCrawl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtURL;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.StatusBarPanel statusPanelURLS;
        private System.Windows.Forms.StatusBarPanel statusPanelProgress;
        private System.Windows.Forms.StatusBarPanel statusPanelCPU;
        private System.Windows.Forms.StatusBarPanel statusPanelMem;
        private System.Windows.Forms.StatusBar StatusBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabCrawl;
        private System.Windows.Forms.ListView LstCrawl;
        private System.Windows.Forms.ColumnHeader Row;
        private System.Windows.Forms.ColumnHeader UserID;
        private System.Windows.Forms.ColumnHeader FriendID;
        private System.Windows.Forms.Button BtnCrawl;
        internal System.Windows.Forms.ProgressBar LoadProgress;
        private System.Windows.Forms.SaveFileDialog SavePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button BtnPath;
        private System.Windows.Forms.Label LblDistance;
        private System.Windows.Forms.NumericUpDown NumUp;
        private System.Windows.Forms.Button BtnDfs;
        private System.Windows.Forms.Button BtnFF;
        private System.Windows.Forms.Timer timerMem;
        private System.Windows.Forms.Button BtnSb;
    }
}

