namespace MultiThreadFaceCrawler
{
    partial class FrmMulti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMulti));
            this.SavePath = new System.Windows.Forms.SaveFileDialog();
            this.LblDistance = new System.Windows.Forms.Label();
            this.NumUp = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.LblUrl = new System.Windows.Forms.Label();
            this.statusPanelCPU = new System.Windows.Forms.StatusBarPanel();
            this.statusPanelMem = new System.Windows.Forms.StatusBarPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControlRightView = new System.Windows.Forms.TabControl();
            this.tabPageThreads = new System.Windows.Forms.TabPage();
            this.LstViewThreads = new System.Windows.Forms.ListView();
            this.columnHeaderTHreadID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderThreadAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderThreadURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderThreadNumCrawled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.TxtSeed = new System.Windows.Forms.TextBox();
            this.ChkListBox = new System.Windows.Forms.CheckedListBox();
            this.StatusBar = new System.Windows.Forms.StatusBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmbSeedUrl = new System.Windows.Forms.ComboBox();
            this.BtnBFS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumThread = new System.Windows.Forms.NumericUpDown();
            this.Path = new System.Windows.Forms.Button();
            this.timerMem = new System.Windows.Forms.Timer(this.components);
            this.RdBtnBfs = new System.Windows.Forms.RadioButton();
            this.RdBtnDfs = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelMem)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControlRightView.SuspendLayout();
            this.tabPageThreads.SuspendLayout();
            this.tabPageSetting.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumThread)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDistance
            // 
            this.LblDistance.AutoSize = true;
            this.LblDistance.Location = new System.Drawing.Point(549, 88);
            this.LblDistance.Name = "LblDistance";
            this.LblDistance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblDistance.Size = new System.Drawing.Size(100, 13);
            this.LblDistance.TabIndex = 144;
            this.LblDistance.Text = " تعداد کاربران هر نخ:";
            // 
            // NumUp
            // 
            this.NumUp.Location = new System.Drawing.Point(490, 86);
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
            this.NumUp.Size = new System.Drawing.Size(53, 21);
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
            this.label1.Location = new System.Drawing.Point(549, 55);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 142;
            this.label1.Text = "مسیر فایل های پیمایش:";
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(184, 53);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPath.Size = new System.Drawing.Size(359, 21);
            this.TxtPath.TabIndex = 139;
            this.TxtPath.Text = "C:\\Users\\Payamnoor\\Desktop\\Multi Thread";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(549, 23);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblUrl.Size = new System.Drawing.Size(100, 13);
            this.LblUrl.TabIndex = 121;
            this.LblUrl.Text = "آدرس کاربران شروع:";
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
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tabControlRightView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 189);
            this.panel3.TabIndex = 136;
            // 
            // tabControlRightView
            // 
            this.tabControlRightView.Controls.Add(this.tabPageThreads);
            this.tabControlRightView.Controls.Add(this.tabPageSetting);
            this.tabControlRightView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRightView.Location = new System.Drawing.Point(0, 0);
            this.tabControlRightView.Name = "tabControlRightView";
            this.tabControlRightView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlRightView.SelectedIndex = 0;
            this.tabControlRightView.ShowToolTips = true;
            this.tabControlRightView.Size = new System.Drawing.Size(698, 185);
            this.tabControlRightView.TabIndex = 8;
            this.tabControlRightView.Tag = "Main Tab";
            // 
            // tabPageThreads
            // 
            this.tabPageThreads.Controls.Add(this.LstViewThreads);
            this.tabPageThreads.ImageIndex = 6;
            this.tabPageThreads.Location = new System.Drawing.Point(4, 22);
            this.tabPageThreads.Name = "tabPageThreads";
            this.tabPageThreads.Size = new System.Drawing.Size(690, 159);
            this.tabPageThreads.TabIndex = 3;
            this.tabPageThreads.Text = "Threads";
            this.tabPageThreads.ToolTipText = "View working threads status";
            // 
            // LstViewThreads
            // 
            this.LstViewThreads.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LstViewThreads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTHreadID,
            this.columnHeaderThreadAction,
            this.columnHeaderThreadURL,
            this.columnHeaderThreadNumCrawled});
            this.LstViewThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstViewThreads.FullRowSelect = true;
            this.LstViewThreads.GridLines = true;
            this.LstViewThreads.HideSelection = false;
            this.LstViewThreads.Location = new System.Drawing.Point(0, 0);
            this.LstViewThreads.MultiSelect = false;
            this.LstViewThreads.Name = "LstViewThreads";
            this.LstViewThreads.Size = new System.Drawing.Size(690, 159);
            this.LstViewThreads.SmallImageList = this.imageList3;
            this.LstViewThreads.TabIndex = 0;
            this.LstViewThreads.UseCompatibleStateImageBehavior = false;
            this.LstViewThreads.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTHreadID
            // 
            this.columnHeaderTHreadID.Text = "ID";
            this.columnHeaderTHreadID.Width = 40;
            // 
            // columnHeaderThreadAction
            // 
            this.columnHeaderThreadAction.Text = "Action";
            // 
            // columnHeaderThreadURL
            // 
            this.columnHeaderThreadURL.Text = "Uri";
            this.columnHeaderThreadURL.Width = 400;
            // 
            // columnHeaderThreadNumCrawled
            // 
            this.columnHeaderThreadNumCrawled.Text = "Visiting Number";
            this.columnHeaderThreadNumCrawled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderThreadNumCrawled.Width = 105;
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "");
            this.imageList3.Images.SetKeyName(1, "");
            this.imageList3.Images.SetKeyName(2, "");
            this.imageList3.Images.SetKeyName(3, "");
            this.imageList3.Images.SetKeyName(4, "ok.png");
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSetting.Controls.Add(this.label4);
            this.tabPageSetting.Controls.Add(this.BtnSend);
            this.tabPageSetting.Controls.Add(this.BtnDelete);
            this.tabPageSetting.Controls.Add(this.BtnSelect);
            this.tabPageSetting.Controls.Add(this.TxtSeed);
            this.tabPageSetting.Controls.Add(this.ChkListBox);
            this.tabPageSetting.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetting.Size = new System.Drawing.Size(690, 159);
            this.tabPageSetting.TabIndex = 4;
            this.tabPageSetting.Text = "Seed Url";
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(337, 82);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(80, 23);
            this.BtnSend.TabIndex = 124;
            this.BtnSend.Text = "تایید لیست";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(442, 82);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(80, 23);
            this.BtnDelete.TabIndex = 123;
            this.BtnDelete.Text = "حذف از لیست";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(545, 82);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(80, 23);
            this.BtnSelect.TabIndex = 2;
            this.BtnSelect.Text = "درج در لیست";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // TxtSeed
            // 
            this.TxtSeed.Location = new System.Drawing.Point(330, 31);
            this.TxtSeed.Name = "TxtSeed";
            this.TxtSeed.Size = new System.Drawing.Size(239, 21);
            this.TxtSeed.TabIndex = 1;
            // 
            // ChkListBox
            // 
            this.ChkListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChkListBox.FormattingEnabled = true;
            this.ChkListBox.Items.AddRange(new object[] {
            "http://facenama.com/music1363",
            "http://facenama.com/ehsan-sepehr",
            "http://facenama.com/khashayar93",
            "http://facenama.com/Amir-Cherik"});
            this.ChkListBox.Location = new System.Drawing.Point(3, 3);
            this.ChkListBox.Name = "ChkListBox";
            this.ChkListBox.Size = new System.Drawing.Size(273, 153);
            this.ChkListBox.TabIndex = 0;
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 311);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusPanelMem,
            this.statusPanelCPU});
            this.StatusBar.ShowPanels = true;
            this.StatusBar.Size = new System.Drawing.Size(702, 22);
            this.StatusBar.TabIndex = 134;
            this.StatusBar.Text = "Ready";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RdBtnDfs);
            this.panel1.Controls.Add(this.RdBtnBfs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CmbSeedUrl);
            this.panel1.Controls.Add(this.NumThread);
            this.panel1.Controls.Add(this.BtnBFS);
            this.panel1.Controls.Add(this.Path);
            this.panel1.Controls.Add(this.LblDistance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtPath);
            this.panel1.Controls.Add(this.NumUp);
            this.panel1.Controls.Add(this.LblUrl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 122);
            this.panel1.TabIndex = 135;
            // 
            // CmbSeedUrl
            // 
            this.CmbSeedUrl.FormattingEnabled = true;
            this.CmbSeedUrl.Location = new System.Drawing.Point(184, 20);
            this.CmbSeedUrl.Name = "CmbSeedUrl";
            this.CmbSeedUrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbSeedUrl.Size = new System.Drawing.Size(359, 21);
            this.CmbSeedUrl.TabIndex = 153;
            // 
            // BtnBFS
            // 
            this.BtnBFS.Location = new System.Drawing.Point(27, 33);
            this.BtnBFS.Name = "BtnBFS";
            this.BtnBFS.Size = new System.Drawing.Size(75, 23);
            this.BtnBFS.TabIndex = 152;
            this.BtnBFS.Text = "اجرا";
            this.BtnBFS.UseVisualStyleBackColor = true;
            this.BtnBFS.Click += new System.EventHandler(this.BtnBFS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 88);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 151;
            this.label2.Text = "تعداد نخ های موازی:";
            // 
            // NumThread
            // 
            this.NumThread.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumThread.Location = new System.Drawing.Point(308, 86);
            this.NumThread.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumThread.Name = "NumThread";
            this.NumThread.Size = new System.Drawing.Size(53, 21);
            this.NumThread.TabIndex = 150;
            this.NumThread.ThousandsSeparator = true;
            this.NumThread.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(131, 51);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(47, 23);
            this.Path.TabIndex = 135;
            this.Path.Text = "Path";
            this.Path.UseVisualStyleBackColor = true;
            this.Path.Click += new System.EventHandler(this.Path_Click);
            // 
            // timerMem
            // 
            this.timerMem.Enabled = true;
            this.timerMem.Interval = 5000;
            this.timerMem.Tick += new System.EventHandler(this.timerMem_Tick);
            // 
            // RdBtnBfs
            // 
            this.RdBtnBfs.AutoSize = true;
            this.RdBtnBfs.Checked = true;
            this.RdBtnBfs.Location = new System.Drawing.Point(135, 88);
            this.RdBtnBfs.Name = "RdBtnBfs";
            this.RdBtnBfs.Size = new System.Drawing.Size(43, 17);
            this.RdBtnBfs.TabIndex = 154;
            this.RdBtnBfs.TabStop = true;
            this.RdBtnBfs.Text = "BFS";
            this.RdBtnBfs.UseVisualStyleBackColor = true;
            // 
            // RdBtnDfs
            // 
            this.RdBtnDfs.AutoSize = true;
            this.RdBtnDfs.Location = new System.Drawing.Point(68, 88);
            this.RdBtnDfs.Name = "RdBtnDfs";
            this.RdBtnDfs.Size = new System.Drawing.Size(44, 17);
            this.RdBtnDfs.TabIndex = 155;
            this.RdBtnDfs.Text = "DFS";
            this.RdBtnDfs.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 34);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 125;
            this.label4.Text = "آدرس کاربران شروع:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 88);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 156;
            this.label3.Text = "الگوریتم پیمایش:";
            // 
            // FrmMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 333);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "FrmMulti";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کاوشگر چند نخی فیس نما";
            ((System.ComponentModel.ISupportInitialize)(this.NumUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelMem)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControlRightView.ResumeLayout(false);
            this.tabPageThreads.ResumeLayout(false);
            this.tabPageSetting.ResumeLayout(false);
            this.tabPageSetting.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumThread)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog SavePath;
        private System.Windows.Forms.Label LblDistance;
        private System.Windows.Forms.NumericUpDown NumUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.StatusBarPanel statusPanelCPU;
        private System.Windows.Forms.StatusBarPanel statusPanelMem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.StatusBar StatusBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Path;
        private System.Windows.Forms.Timer timerMem;
        private System.Windows.Forms.NumericUpDown NumThread;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControlRightView;
        private System.Windows.Forms.TabPage tabPageThreads;
        private System.Windows.Forms.ListView LstViewThreads;
        private System.Windows.Forms.ColumnHeader columnHeaderTHreadID;
        private System.Windows.Forms.ColumnHeader columnHeaderThreadAction;
        private System.Windows.Forms.ColumnHeader columnHeaderThreadURL;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Button BtnBFS;
        private System.Windows.Forms.ColumnHeader columnHeaderThreadNumCrawled;
        private System.Windows.Forms.TabPage tabPageSetting;
        private System.Windows.Forms.CheckedListBox ChkListBox;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox TxtSeed;
        private System.Windows.Forms.ComboBox CmbSeedUrl;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.RadioButton RdBtnDfs;
        private System.Windows.Forms.RadioButton RdBtnBfs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

