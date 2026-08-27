using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using System.IO;
using Webpage;
//.................................................................................................................
namespace MultiThreadFaceCrawler
{
    public partial class FrmMulti : Form
    {
        private static ReaderWriterLockSlim _readWriteLock = new ReaderWriterLockSlim();
        private HTMLPage PageCurrent = new HTMLPage();
        //Hash File For Coding UserIDs
        public Hashtable UserHashTable = new Hashtable();
        //Current UserIDs Processing
        public Hashtable CurrentUser = new Hashtable();
        public int DuplicateId = 0;
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
        public FrmMulti()
        {
            InitializeComponent();
            this.cpuCounter = new System.Diagnostics.PerformanceCounter();
            this.ramCounter = new System.Diagnostics.PerformanceCounter("Memory", "Available MBytes");
            this.cpuCounter.CategoryName = "Processor";
            this.cpuCounter.CounterName = "% Processor Time";
            this.cpuCounter.InstanceName = "_Total";
            FrmMulti.CheckForIllegalCrossThreadCalls = false;
        }
//.................................................................................................................
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMulti());
        }
//.................................................................................................................
        private void timerMem_Tick(object sender, EventArgs e)
        {
            FreeMemory = ramCounter.NextValue();
            CPUUsage = (int)cpuCounter.NextValue();
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
        private void BtnBFS_Click(object sender, EventArgs e)
        {
            Thread ThreadBfs;
            ThreadBfs = new Thread(new ThreadStart(StartThreads));
            ThreadBfs.Start();
        }
//.................................................................................................................
        void StartThreads()
        {
            int n = (int)NumThread.Value;
            Thread[] SpiderThread = new Thread[n];
            object[] Param = new object[n];
            for (int i = 0; i < n; i++)
                Param[i] = CmbSeedUrl.Items[i].ToString();
            for (int Index = 0; Index < n; Index++)
            {
                if (RdBtnBfs.Checked == true)
                    SpiderThread[Index] = new Thread(BFS);
            else
                if (RdBtnDfs.Checked == true)
                    SpiderThread[Index] = new Thread(DFS);
                SpiderThread[Index].Name = Index.ToString();
                if (Index == this.LstViewThreads.Items.Count)
                {
                    ListViewItem item = this.LstViewThreads.Items.Add((Index + 1).ToString(), 0);
                    string[] subItems = { "", "", "0" };
                    item.SubItems.AddRange(subItems);
                    item.ImageIndex = 0;
                }
            }
            InsertFileCrawlTime("Start Time:", TxtPath.Text);
            for (int i = 0; i < n; i++)
                SpiderThread[i].Start(Param[i]);
            for (int i = 0; i < n; i++)
                SpiderThread[i].Join();
            InsertFileCrawlTime("End Time:", TxtPath.Text);
            InsertFileDuplicateNum("Duplicate Id:", DuplicateId, TxtPath.Text);
            InsertFileHashTable(TxtPath.Text);
            MessageBox.Show("پایان پیمایش");
        }
//.................................................................................................................
        void LogCell(ref ListViewItem itemLog, int nCell, string str)
        {
            Monitor.Enter(this.LstViewThreads);
            try
            {
                itemLog.SubItems[nCell].Text = str;
            }
            catch (Exception)
            {
            }
            Monitor.Exit(this.LstViewThreads);
        }
//.................................................................................................................
        public void BFS(object Param)
        {
            try
            {
                Queue<string> UnCrawledQueue = new Queue<string>();
                Queue<string> CrawledQueue = new Queue<string>();
                int visited = 1;
                ArrayList FriendList;
                ArrayList FriendUrl = null;
                string SUri = Param.ToString(); 
                int NumC = (int) NumUp.Value;
                String Path = TxtPath.Text;
                ListViewItem itemLog = null;
                UnCrawledQueue.Enqueue(SUri);
                while (UnCrawledQueue.Count > 0 && visited <= NumC)
                {
                    string FirstUri = UnCrawledQueue.Dequeue();
                    string Userid = GetUserId(FirstUri);
                    Monitor.Enter(CurrentUser);
                    if (!(CurrentUser.ContainsValue(Userid)))
                        CurrentUser.Add(CurrentUser.Count + 1, Userid);
                    else
                    {
                        DuplicateId++;
                    Monitor.Exit(CurrentUser);
                       continue;
                    }
                    Monitor.Exit(CurrentUser);
                    //update thread information in the threads view list
                    Monitor.Enter(this.LstViewThreads);
                    itemLog = this.LstViewThreads.Items[int.Parse(Thread.CurrentThread.Name)];
                    itemLog.ImageIndex = 0;
                    itemLog.BackColor = Color.WhiteSmoke;
                    itemLog.SubItems[1].Text = "Connect";
                    itemLog.ForeColor = Color.Red;
                    itemLog.SubItems[2].Text = FirstUri;
                    itemLog.SubItems[3].Text =visited.ToString() ;
                    Monitor.Exit(this.LstViewThreads);
                    Monitor.Enter(UserHashTable);
                    if (!UserHashTable.ContainsValue(Userid))
                        UserHashTable.Add(UserHashTable.Count + 1, Userid);
                    Monitor.Exit(UserHashTable);
                    string FriendUri = "http://facenama.com/" + Userid + "/tab:coleagues";
                    PageCurrent.LoadSource(FriendUri);
                    if (PageCurrent.CloseFriendList())
                        continue;
                    string[] strHRef = PageCurrent.GetHRefs();
                    FriendList = PageCurrent.GetFriend_list(strHRef);
                    if (FriendList.Count == 0)
                        FriendList.Add(FriendUri);
                    for (int i = 0; i < FriendList.Count; i++)
                    {
                        PageCurrent.LoadSource(FriendList[i].ToString());
                        string[] strHRefFriend = PageCurrent.GetHRefs();
                        FriendList = PageCurrent.UpdateFriend_list(strHRefFriend, FriendList);
                        FriendUrl = PageCurrent.GetFriendId(strHRefFriend);
                        Monitor.Enter(this.LstViewThreads);
                        itemLog = this.LstViewThreads.Items[int.Parse(Thread.CurrentThread.Name)];
                        itemLog.ImageIndex = 1;
                        itemLog.BackColor = Color.WhiteSmoke;
                        itemLog.SubItems[1].Text = "Loading";
                        itemLog.ForeColor = Color.Blue;
                        itemLog.SubItems[2].Text = FriendList[i].ToString();
                        itemLog.SubItems[3].Text =visited.ToString();
                        Monitor.Exit(this.LstViewThreads);
                        if (!(FriendList == null))
                            for (int j = 0; j < FriendUrl.Count; j++)
                            {
                                UnCrawledQueue.Enqueue(FriendUrl[j].ToString());
                                if (UnCrawledQueue.Count % 100 == 0)
                                    InsertFileTimeOfUnCrawledUser(UnCrawledQueue, int.Parse(Thread.CurrentThread.Name), Path);
                                string Friendid = GetUserId(FriendUrl[j].ToString());
                                Monitor.Enter(UserHashTable);
                                if (!UserHashTable.ContainsValue(Friendid))
                                    UserHashTable.Add(UserHashTable.Count + 1, Friendid);
                                Monitor.Exit(UserHashTable);
                            }

                        InsertFileMain(UserHashTable, Userid, FriendUrl, Path);
                        FriendUrl.Clear();
                    }
                    CrawledQueue.Enqueue(Userid);
                    if (CrawledQueue.Count % 10 == 0)
                        InsertFileTimeOfCrawledUser(CrawledQueue, UnCrawledQueue.Count, int.Parse(Thread.CurrentThread.Name), Path);
                    Monitor.Enter(this.LstViewThreads);
                    itemLog = this.LstViewThreads.Items[int.Parse(Thread.CurrentThread.Name)];
                    itemLog.ImageIndex = 4;
                    itemLog.BackColor = Color.WhiteSmoke;
                    itemLog.SubItems[1].Text = "Done";
                    itemLog.ForeColor = Color.Green;
                    itemLog.SubItems[2].Text = FriendUri;
                    Monitor.Exit(this.LstViewThreads);
                    visited++;
                    Thread.Sleep(1000);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//.................................................................................................................
        public void DFS(object Param)
        {
            try
            {
                Stack<string> UnCrawledStack = new Stack<string>();
                Queue<string> CrawledQueue = new Queue<string>();
                int visited = 1;
                ArrayList FriendList;
                ArrayList FriendUrl = null;
                string SUri = Param.ToString();
                int NumC = (int)NumUp.Value;
                String Path = TxtPath.Text;
                ListViewItem itemLog = null;
                UnCrawledStack.Push(SUri);
                while (UnCrawledStack.Count > 0 && visited <= NumC)
                {
                    string FirstUri = UnCrawledStack.Pop();
                    string Userid = GetUserId(FirstUri);
                    Monitor.Enter(CurrentUser);
                    if (!(CurrentUser.ContainsValue(Userid)))
                        CurrentUser.Add(CurrentUser.Count + 1, Userid);
                    else
                    {
                        DuplicateId++;
                        Monitor.Exit(CurrentUser);
                        continue;
                    }
                    Monitor.Exit(CurrentUser);
                    //update thread information in the threads view list
                    Monitor.Enter(this.LstViewThreads);
                    itemLog = this.LstViewThreads.Items[int.Parse(Thread.CurrentThread.Name)];
                    itemLog.ImageIndex = 0;
                    itemLog.BackColor = Color.WhiteSmoke;
                    itemLog.SubItems[1].Text = "Connect";
                    itemLog.ForeColor = Color.Red;
                    itemLog.SubItems[2].Text = FirstUri;
                    itemLog.SubItems[3].Text = visited.ToString();
                    Monitor.Exit(this.LstViewThreads);
                    Monitor.Enter(UserHashTable);
                    if (!UserHashTable.ContainsValue(Userid))
                        UserHashTable.Add(UserHashTable.Count + 1, Userid);
                    Monitor.Exit(UserHashTable);
                    string FriendUri = "http://facenama.com/" + Userid + "/tab:coleagues";
                    PageCurrent.LoadSource(FriendUri);
                    if (PageCurrent.CloseFriendList())
                        continue;
                    string[] strHRef = PageCurrent.GetHRefs();
                    FriendList = PageCurrent.GetFriend_list(strHRef);
                    if (FriendList.Count == 0)
                        FriendList.Add(FriendUri);
                    for (int i = 0; i < FriendList.Count; i++)
                    {
                        PageCurrent.LoadSource(FriendList[i].ToString());
                        string[] strHRefFriend = PageCurrent.GetHRefs();
                        FriendList = PageCurrent.UpdateFriend_list(strHRefFriend, FriendList);
                        FriendUrl = PageCurrent.GetFriendId(strHRefFriend);
                        Monitor.Enter(this.LstViewThreads);
                        itemLog = this.LstViewThreads.Items[int.Parse(Thread.CurrentThread.Name)];
                        itemLog.ImageIndex = 1;
                        itemLog.BackColor = Color.WhiteSmoke;
                        itemLog.SubItems[1].Text = "Loading";
                        itemLog.ForeColor = Color.Blue;
                        itemLog.SubItems[2].Text = FriendList[i].ToString();
                        itemLog.SubItems[3].Text = visited.ToString();
                        Monitor.Exit(this.LstViewThreads);
                        if (!(FriendList == null))
                            for (int j = 0; j < FriendUrl.Count; j++)
                            {
                                UnCrawledStack.Push(FriendUrl[j].ToString());
                                if (UnCrawledStack.Count % 100 == 0)
                                    InsertFileTimeOfUnCrawledUserStack(UnCrawledStack, int.Parse(Thread.CurrentThread.Name), Path);
                                string Friendid = GetUserId(FriendUrl[j].ToString());
                                Monitor.Enter(UserHashTable);
                                if (!UserHashTable.ContainsValue(Friendid))
                                    UserHashTable.Add(UserHashTable.Count + 1, Friendid);
                                Monitor.Exit(UserHashTable);
                            }
                        InsertFileMain(UserHashTable, Userid, FriendUrl, Path);
                        FriendUrl.Clear();
                    }
                    CrawledQueue.Enqueue(Userid);
                    if (CrawledQueue.Count % 10 == 0)
                        InsertFileTimeOfCrawledUser(CrawledQueue, UnCrawledStack.Count, int.Parse(Thread.CurrentThread.Name), Path);
                    Monitor.Enter(this.LstViewThreads);
                    itemLog = this.LstViewThreads.Items[int.Parse(Thread.CurrentThread.Name)];
                    itemLog.ImageIndex = 4;
                    itemLog.BackColor = Color.WhiteSmoke;
                    itemLog.SubItems[1].Text = "Done";
                    itemLog.ForeColor = Color.Green;
                    itemLog.SubItems[2].Text = FriendUri;
                    Monitor.Exit(this.LstViewThreads);
                    visited++;
                    Thread.Sleep(1000);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//.................................................................................................................
        //Find UserId From UserUrl 
        private string GetUserId(string Urlid)
        {
            int start = Urlid.LastIndexOf('/');
            string Userid = Urlid.Substring(start + 1);
            return (Userid);
        }
 //.................................................................................................................
        //Find UserCode From HashTable 
        private int SearchHash(Hashtable UserHashTable, string UserId)
        {
            int key = -1;
            foreach (DictionaryEntry entry in UserHashTable)
            {
                if (entry.Value.ToString() == UserId)
                {
                    key = (int)entry.Key;
                    break;
                }
            }
            return (key);
        }
//.................................................................................................................
        //Check Dublicate Url in Queue
        private bool ContainQueue(IEnumerable myQueue, string Userid)
        {
            foreach (string str in myQueue)
            {
                if (str == Userid)
                    return (true);
            }
            return (false);
        }
//.................................................................................................................
        //Save UserCode And Friend In Txt File 
        private void InsertFileMain(Hashtable UserHashTable, string Userid, ArrayList StrFriendid,string Path)
        {
            Monitor.Enter(UserHashTable);
            int id1 = SearchHash(UserHashTable, Userid);
            _readWriteLock.EnterWriteLock();
            StreamWriter sw = new StreamWriter(Path + @"\Main.txt", true);
                for (int i = 0; i < StrFriendid.Count; i++)
                {
                    string Temp = GetUserId(StrFriendid[i].ToString());
                    int id2 = SearchHash(UserHashTable, Temp);
                    sw.Write(id1.ToString() + "\t");
                    sw.WriteLine(id2.ToString());
                }
                sw.Close();
          _readWriteLock.ExitWriteLock();
          Monitor.Exit(UserHashTable);
        }
//.................................................................................................................
        //Save UserCode And Friend In Txt File 
        public void InsertFileHashTable(object Path)
        {
            StreamWriter sw = new StreamWriter(Path + @"\Config.txt", true);
            sw.WriteLine("-------------------------------");
            foreach (DictionaryEntry item in UserHashTable)
            {
                sw.Write(item.Key.ToString() + "\t");
                sw.WriteLine(item.Value.ToString());
            }
            sw.Close();
        }
//.................................................................................................................
        //Save Time Of Crawled User In Txt File 
        public void InsertFileTimeOfCrawledUser(Queue<String> CrawledQueue, int CountEdge, int ThreadId, string Path)
        {
            StreamWriter sw = new StreamWriter(Path + @"\TimeOfCrawledUser_" + ThreadId.ToString() + ".txt", true);
            sw.Write(CrawledQueue.Count.ToString() + "\t");
            sw.Write(CountEdge.ToString() + "\t");
            sw.WriteLine(System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString() + ":" + System.DateTime.Now.Second.ToString());
            sw.Close();
        }
//.................................................................................................................
        //Save Time Of UnCrawled User In Txt File 
        private void InsertFileTimeOfUnCrawledUser(Queue<String> UnCrawledQueue,int ThreadId, string Path)
        {
            StreamWriter sw = new StreamWriter(Path + @"\UnCrawledUserTime_" + ThreadId.ToString() + ".txt", true);
            sw.Write(UnCrawledQueue.Count.ToString() + "\t");
            sw.WriteLine(System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString() + ":" + System.DateTime.Now.Second.ToString());
            sw.Close();
        }
//.................................................................................................................
        private void InsertFileTimeOfUnCrawledUserStack(Stack<String> UnCrawledQueue, int ThreadId, string Path)
        {
            StreamWriter sw = new StreamWriter(Path + @"\UnCrawledUserTime_" + ThreadId.ToString() + ".txt", true);
            sw.Write(UnCrawledQueue.Count.ToString() + "\t");
            sw.WriteLine(System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString() + ":" + System.DateTime.Now.Second.ToString());
            sw.Close();
        }
//.................................................................................................................
        //Save Time Of UnCrawled User In Txt File 
        public void InsertFileDuplicateNum(string Desc, int DuplicateId, string Path)
        {
            StreamWriter sw = new StreamWriter(Path + @"\Config.txt", true);
            sw.Write(Desc + "\t");
            sw.WriteLine(DuplicateId.ToString());
            sw.Close();
        }
//................................................................................................................
        //Save Time Of UnCrawled User In Txt File 
        public void InsertFileCrawlTime(string Desc, string Path)
        {
            StreamWriter sw = new StreamWriter(Path + @"\Config.txt", true);
            sw.Write(Desc + "\t");
            sw.WriteLine(System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString() + ":" + System.DateTime.Now.Second.ToString());
            sw.Close();
        }
//................................................................................................................
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            ChkListBox.Items.Add(TxtSeed.Text);
        }
//................................................................................................................
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int lastIndex = ChkListBox.Items.Count - 1;
            for (int i = lastIndex; i >= 0; i--)
                if (ChkListBox.GetItemCheckState(i) == CheckState.Checked)
                    ChkListBox.Items.RemoveAt(i);
        }
//................................................................................................................
        private void BtnSend_Click(object sender, EventArgs e)
        {
            CmbSeedUrl.Items.Clear();
            CmbSeedUrl.Text = "";
            for (int i = 0; i < ChkListBox.Items.Count; i++)
                CmbSeedUrl.Items.Add(ChkListBox.Items[i]);
            CmbSeedUrl.SelectedIndex=0;
        }
//................................................................................................................
    }
}
