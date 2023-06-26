using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using MetroFramework.Forms;
using Microsoft.VisualBasic.Devices;
using System.Reflection;

namespace MemTest
{
    public partial class Form1 : MetroForm
    {
        public List<int> HandlePtr = new List<int>();
        public double memfree;
        public double memtotal;
        string MemTestPath;
        public bool runtime = false;
        double coverageold = 0.0;
        double coveragenew = 0.0;
        double coverageoffset = -1;
        double timeold = 0.0;
        double timenew = 0.0;
        double timeoffset = -1;

        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//計時
        public Form1()
        {
            InitializeComponent();           
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("The number of processors on this computer is {0}.", Environment.ProcessorCount);
            byte[] exefile = Properties.Resources.memTestPro; //取出Resources中的sample.xls檔
            MemTestPath = Path.GetTempPath() + "memTestPro.exe";
            if (!File.Exists(MemTestPath))
            {
                FileStream outputFile = new FileStream(MemTestPath, FileMode.Create, FileAccess.Write); //存到C槽
                outputFile.Write(exefile, 0, exefile.Length);
                outputFile.Close();
            }
            MemoryListViewSet(lvMemoryState);
            MemoryListViewSet(lvMonitorState);
            MonitorListViewSet();

            nbNumMemory.Value = Environment.ProcessorCount;

            Startbg(bgMemoryFree);

            togAutoCal.Checked = true;
        }

        void Startbg(BackgroundWorker bg)
        {
            bg.WorkerSupportsCancellation = true;//背景執行 BLCK frequrncy

            if (bg.IsBusy != true)
            {
                bg.WorkerReportsProgress = true;
                bg.RunWorkerAsync();
            }
        }

        void Stopbg(BackgroundWorker bg)
        {
            if (bg.IsBusy)
            {
                bg.WorkerReportsProgress = false;
                bg.CancelAsync();
                bg.Dispose();
            }
        }

        private void MemoryListViewSet(ListView listview)
        {

            listview.BeginUpdate();
            listview.View = View.Details;//ListView顯示方式
            listview.Font = new System.Drawing.Font("Consolas", 11F);
            listview.Columns.Add("Total RAM");
            //mlvMemoryState.Columns.Add("UsablRAM");
            listview.Columns.Add("Free RAM");
            listview.Columns.Add("Run Time");
            listview.Columns.Add("100% Time Left");
            listview.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listview.FullRowSelect = true;

            ComputerInfo CI = new ComputerInfo();
            ulong mem = ulong.Parse(CI.TotalPhysicalMemory.ToString());
            memtotal = ((double)mem / (1024 * 1024));

            listview.Columns[0].Width = 150;
            listview.Columns[1].Width = 150;
            listview.Columns[2].Width = 150;
            listview.Columns[3].Width = 150;
            listview.Items.Add((memtotal.ToString("##.0") + " MB"));
            listview.Items[0].SubItems.Add("");
            listview.Items[0].SubItems.Add("");
            listview.Items[0].SubItems.Add("");
            listview.Scrollable = false;
            listview.EndUpdate();
        }

        private void MonitorListViewSet()
        {

            lvMonitor.BeginUpdate();
            lvMonitor.View = View.Details;//ListView顯示方式
            lvMonitor.Font = new System.Drawing.Font("Consolas", 11F);
            lvMonitor.GridLines = true;
            lvMonitor.Columns.Add("#");
            lvMonitor.Columns.Add("Usable RAM");
            lvMonitor.Columns.Add("Coverage");
            lvMonitor.Columns.Add("Error");
            lvMonitor.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvMonitor.FullRowSelect = true;

            lvMonitor.Columns[0].Width = 30;
            lvMonitor.Columns[1].Width = 120;
            lvMonitor.Columns[2].Width = 80;
            lvMonitor.Columns[3].Width = 80;
            //lvMonitor.Scrollable = false;
            lvMonitor.EndUpdate();
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            StartMemTest();
            MonitorDefault();

            btBurning.Enabled = true;
            btMBurning.Enabled = true;

            this.Activate();
        }
        private void btBurning_Click(object sender, EventArgs e)
        {
            StartBurning();
            btBurning.Enabled = false;
            btMBurning.Enabled = false;
            btMStopBurning.Enabled = true;
            btStart.Enabled = false;
            btMStart.Enabled = false;
        }
        private void btColse_Click(object sender, EventArgs e)
        {
            KillMemTest();
            btMBurning.Enabled = false;
            btMStopBurning.Enabled = false;
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((sender as TabControl).SelectedIndex==1)
            {
                this.Size = new System.Drawing.Size(1024, 800);
            }
            else
                this.Size = new System.Drawing.Size(604, 393);
        }

        private void btMSBurning_Click(object sender, EventArgs e)
        {
            StopBurning();
            btBurning.Enabled = true;
            btMBurning.Enabled = true;
        }
    }
}
