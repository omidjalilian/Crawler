using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Webpage;
using BreadthFirst;
using DepthFirst;
using ForestFire;
using SnowBall;
//.................................................................................................................
namespace FacenamaCrawler
{
    public partial class FrmFaceCrawler : Form
    {
        private BreadthFirstCrawler Spider1 = new BreadthFirstCrawler();
        private DepthFirstCrawler Spider2 = new DepthFirstCrawler();
        private ForestFireCrawler Spider3 = new ForestFireCrawler();
        private SnowBallCrawler Spider4 = new SnowBallCrawler();
        //Performance Counter to measure CPU usage
        private System.Diagnostics.PerformanceCounter cpuCounter;
        //Performance Counter to measure memory usage
        private System.Diagnostics.PerformanceCounter ramCounter;
//.................................................................................................................
        //Available memory;
        private float nFreeMemory;
        private float FreeMemory
        {
            get { return nFreeMemory; }
            set
            {
                nFreeMemory = value;
                statusPanelMem.Text = "حافظه آزاد: " + nFreeMemory + "مگابایت";
            }
        }
//.................................................................................................................
        //CPU usage
        private int nCPUUsage;
        private int CPUUsage
        {
            get { return nCPUUsage; }
            set
            {
                nCPUUsage = value;
                this.statusPanelCPU.Text = "استفاده از پردازنده:" + nCPUUsage + "%";
            }
        }
//.................................................................................................................
        public FrmFaceCrawler()
        {
            InitializeComponent();
            this.cpuCounter = new System.Diagnostics.PerformanceCounter();
            this.ramCounter = new System.Diagnostics.PerformanceCounter("Memory", "Available MBytes");
            this.cpuCounter.CategoryName = "Processor";
            this.cpuCounter.CounterName = "% Processor Time";
            this.cpuCounter.InstanceName = "_Total";
        }
//.................................................................................................................
       [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmFaceCrawler());
        }
//.................................................................................................................
        private void FrmOSNCrawler_Load(object sender, EventArgs e)
        {
            Spider1.LoadProgress += new BreadthFirstCrawler.LoadProgressHandler(m_wcSpider_LoadProgress);
            Spider1.LoadStatus += new BreadthFirstCrawler.LoadStatusHandler(m_wcSpider_LoadStatus);
            Spider1.BreadthQueue += new BreadthFirstCrawler.ShowQueueHandler(m_ShowQueue);
            Spider2.LoadProgress += new DepthFirstCrawler.LoadProgressHandler(m_wcSpider_LoadProgress);
            Spider2.LoadStatus += new DepthFirstCrawler.LoadStatusHandler(m_wcSpider_LoadStatus);
            Spider2.DepthQueue += new DepthFirstCrawler.ShowQueueHandler(m_ShowQueue);
            Spider3.LoadProgress += new ForestFireCrawler.LoadProgressHandler(m_wcSpider_LoadProgress);
            Spider3.LoadStatus += new ForestFireCrawler.LoadStatusHandler(m_wcSpider_LoadStatus);
            Spider3.FFQueue += new ForestFireCrawler.ShowQueueHandler(m_ShowQueue);
            Spider4.LoadProgress += new SnowBallCrawler.LoadProgressHandler(m_wcSpider_LoadProgress);
            Spider4.LoadStatus += new SnowBallCrawler.LoadStatusHandler(m_wcSpider_LoadStatus);
            Spider4.SBQueue += new SnowBallCrawler.ShowQueueHandler(m_ShowQueue);
        }
//.................................................................................................................
        private void BtnCrawl_Click(object sender, EventArgs e)
        {
            ArrayList SeedUrls = new ArrayList();
            for (int i = 0; i < TxtURL.Lines.Length; i++)
                SeedUrls.Add(TxtURL.Lines[i].ToString());
            Spider1.BreadthFirst(SeedUrls, NumUp.Value, TxtPath.Text);
            MessageBox.Show("پایان کاوش");
        }
//.................................................................................................................
        private void timerMem_Tick(object sender, EventArgs e)
        {
            FreeMemory = ramCounter.NextValue();
            CPUUsage = (int)cpuCounter.NextValue();
        }
//.................................................................................................................
        //set Progress Bar
        private void m_wcSpider_LoadProgress(string URL, long Maximum, long Value)
        {
            try
            {
                int intMaximum = (int)Maximum;
                int intValue = (int)Value;
                if ((intMaximum < 0) | (intValue < 0))
                    return;
                else
                    if (intMaximum + intValue == 0)
                        PutStatus(URL + " :بارگذاری");
                    else
                        if (intMaximum == intValue)
                        {
                            PutStatus("");
                            intValue = 0;
                            intMaximum = 0;
                        }
                LoadProgress.Maximum = intMaximum;
                LoadProgress.Minimum = 0;
                LoadProgress.Value = intValue;
                Application.DoEvents();
            }
            catch
            {
                Console.WriteLine("خطا");
            }
        }
//.................................................................................................................
        //Update status bar with new description 
        private void m_wcSpider_LoadStatus(string URL, string Description)
        {
            try
            {
                PutStatus(URL + Description);
            }
            catch
            {
                Console.WriteLine("خطا");
            }
        }
//.................................................................................................................
        //Message to status bar
        private void PutStatus(string strPutThis)
        {
            try
            {
                statusPanelURLS.Text = strPutThis;
                Application.DoEvents();
            }
            catch { }
        }
//.................................................................................................................
        //Raised when a new page has been loaded
        private void m_wcSpider_NewPage(DataSet data)
        {
            try
            {
                Application.DoEvents();
            }
            catch { }
        }
//.................................................................................................................
        //Raised when crawler is about to begin crawling
        private void m_ShowQueue(string FirstUri, ArrayList StrFriendid)
        {
            try
            {
                int crawlid = 0;
                for (int i = 0; i < StrFriendid.Count; i++)
                {
                    crawlid = LstCrawl.Items.Count + 1;
                    string Temp = StrFriendid[i].ToString();
                    int start = Temp.LastIndexOf('/');
                    string UserFriendid = Temp.Substring(start + 1);
                    ListViewItem crawlitem = new ListViewItem(new string[] { crawlid.ToString(), FirstUri, UserFriendid });
                    LstCrawl.Items.AddRange(new ListViewItem[] { crawlitem });
                }
            }
            catch { }
        }
//.................................................................................................................
        private void Path_Click(object sender, EventArgs e)
        {
            SavePath.Filter = "Text File|.txt";
            SavePath.FileName = String.Empty;
            SavePath.DefaultExt = ".txt";
            DialogResult result = SavePath.ShowDialog();
            TxtPath.Text = SavePath.FileName;
            if (result == DialogResult.OK)
                TxtPath.Text = SavePath.FileName;
            TxtPath.Text = System.IO.Path.GetDirectoryName(SavePath.FileName);
        }
//.................................................................................................................
        private void BtnDfs_Click(object sender, EventArgs e)
        {
            ArrayList SeedUrls = new ArrayList();
            for (int i = 0; i < TxtURL.Lines.Length; i++)
                SeedUrls.Add(TxtURL.Lines[i].ToString());
            Spider2.DepthFirst(SeedUrls, NumUp.Value, TxtPath.Text);
            MessageBox.Show("پایان کاوش");
        }
//.................................................................................................................
        private void BtnFF_Click(object sender, EventArgs e)
        {
            ArrayList SeedUrls = new ArrayList();
            for (int i = 0; i < TxtURL.Lines.Length; i++)
                SeedUrls.Add(TxtURL.Lines[i].ToString());
            Spider3.ForestFire(SeedUrls, NumUp.Value, TxtPath.Text);
            MessageBox.Show("پایان کاوش");
        }
//.................................................................................................................
        private void BtnSb_Click(object sender, EventArgs e)
        {
            ArrayList SeedUrls = new ArrayList();
            for (int i = 0; i < TxtURL.Lines.Length; i++)
                SeedUrls.Add(TxtURL.Lines[i].ToString());
            Spider4.SnowBall(SeedUrls, NumUp.Value, TxtPath.Text);
            MessageBox.Show("پایان کاوش");
        }
//.................................................................................................................
    }
}
