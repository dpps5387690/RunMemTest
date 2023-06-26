using MetroFramework.Controls;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Drawing;

namespace MemTest
{
    public partial class Form1
    {
        public class HandleClass
        {
            public IntPtr windowsINP;//windows           
            public IntPtr Edit1INP;//control         
            public IntPtr Button1INP;
            public IntPtr Button2INP;
            public IntPtr Static1INP;

            public HandleClass(IntPtr windowsINP, IntPtr Edit1INP, IntPtr Button1INP, IntPtr Button2INP, IntPtr Static1INP)
            {
                this.windowsINP = windowsINP;
                this.Edit1INP = Edit1INP;
                this.Button1INP = Button1INP;
                this.Button2INP = Button2INP;
                this.Static1INP = Static1INP;
            }
        };

        List<IntPtr> handle;

        public void StartMemTest()
        {
            if (handle != null)
                KillMemTest();

            handle = new List<IntPtr>();

            if (this.bgAutoCal.IsBusy)
            {
                this.bgAutoCal.WorkerReportsProgress = false;
                this.bgAutoCal.CancelAsync();
                this.bgAutoCal.Dispose();
            }

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int offsetHeight = 0, offsetWidth = 0, HeightIndex = 0, WidthIndex = 0;



            for (int i = 0; i < nbNumMemory.Value; i++)//nbNumMemory.Value
            {
                // open notepad program
                AutoItX.Run(MemTestPath, "", 1);

                //wait notepad opened until 10 seconds
                //autoit.WinWait("[CLASS:#32770]", "");
                Thread.Sleep(100);//delay time 100msec
                //set the texts
                AutoItX.ControlSetText("[CLASS:#32770]", "", "Edit1", nbMemory.Value.ToString());

                offsetWidth = WidthIndex * 50;
                offsetHeight = HeightIndex * 100;

                if (offsetWidth <= screenWidth)
                    WidthIndex++;
                else
                {
                    WidthIndex = 0;
                    HeightIndex++;
                }



                AutoItX.WinMove("[CLASS:#32770]", "", offsetWidth, offsetHeight);

                IntPtr windowsINP = AutoItX.WinGetHandle("[CLASS:#32770]", "");//windows           
                /*IntPtr Edit1INP = AutoItX.ControlGetHandle(windowsINP, "Edit1");//control         
                IntPtr Button1INP = AutoItX.ControlGetHandle(windowsINP, "Button1");
                IntPtr Button2INP = AutoItX.ControlGetHandle(windowsINP, "Button2");
                IntPtr Static1INP = AutoItX.ControlGetHandle(windowsINP, "Static1");*/


                handle.Add(windowsINP);

                Debug.WriteLine(handle[i].ToString("X"));
                /*Debug.WriteLine("windowsINP: " + windowsINP.ToString("X") +
                    " Edit1INP: " + Edit1INP.ToString("X")+
                    " Button1INP: " + Button1INP.ToString("X")+
                    " Button2INP: " + Button2INP.ToString("X")+
                    " Static1INP: " + Static1INP.ToString("X"));*/

            }

            bgAutoCal.WorkerSupportsCancellation = true;//背景執行 BLCK frequrncy

            if (this.bgAutoCal.IsBusy != true)
            {
                this.bgAutoCal.WorkerReportsProgress = true;
                this.bgAutoCal.RunWorkerAsync();
            }
        }

        public void MonitorDefault()
        {

            lvMonitor.Items.Clear();
            lvMonitor.BeginUpdate();
            foreach (var had in handle.Select((value, i) => new { i, value }))
            {
                string strReturnText = AutoItX.ControlGetText(had.value, AutoItX.ControlGetHandle(had.value, "Edit1"));
                Debug.WriteLine(strReturnText);
                lvMonitor.Items.Add(new ListViewItem(new[] { had.i.ToString(), strReturnText + " MB", "", "" }));
            }
            //lvMonitor.Items[4].BackColor = Color.Red;
            lvMonitor.EndUpdate();
        }

        public void StartBurning()
        {

            Stopbg(bgAutoCal);

            coverageold = 0.0;
            timeold = 0.0;
            foreach (var had in handle)
            {
                AutoItX.ControlClick(had, AutoItX.ControlGetHandle(had, "Button1"));
            }

            Startbg(bgMonitor);
            
            sw.Reset();
            sw.Start();
            runtime = true;
        }
        void shuntdownMontor()
        {
            sw.Stop();
            runtime = false;
            btBurning.Enabled = false;
            btStart.Enabled = true;
            btMStart.Enabled = true;

            Stopbg(bgMonitor);           

            Startbg(bgAutoCal);
        }
        public void StopBurning()
        {
            shuntdownMontor();
            foreach (var had in handle)
            {
                AutoItX.ControlClick(had, AutoItX.ControlGetHandle(had, "Button2"));
            }

            Startbg(bgAutoCal);
        }

        
        public void KillMemTest()
        {
            shuntdownMontor();
            /*foreach (var had in handle)
            {
                AutoItX3 autoitX = new AutoItX3();
                while (autoitX.WinExists("[HANDLE:" + had + "]") != 0)
                    autoitX.WinKill("[HANDLE:" + had + "]");
            }*/
            Process[] ProcessKill = Process.GetProcessesByName("memTestPro");
            foreach (var proc in ProcessKill)
                proc.Kill();
        }

        private void nbMemory_ValueChanged(object sender, EventArgs e)
        {
            int memuse = Convert.ToInt32(nbMemory.Value) * Convert.ToInt32(nbNumMemory.Value);
            int memre = (int)(memfree) - memuse;

            lbMemoryFree.Text = String.Format("{0} MB;{1} MB", memuse, memre);
        }
        private void nbNumMemory_ValueChanged(object sender, EventArgs e)
        {
            int memuse = Convert.ToInt32(nbMemory.Value) * Convert.ToInt32(nbNumMemory.Value);
            int memre = (int)(memfree) - memuse;

            lbMemoryFree.Text = String.Format("{0} MB;{1} MB", memuse, memre);
        }
        private void btCalculate_Click(object sender, EventArgs e)
        {
            nbNumMemory.Value = Environment.ProcessorCount;
            nbMemory.Value = oneofmem();
        }

        private void metroToggle2_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine((sender as MetroToggle).Checked);


            if ((sender as MetroToggle).Checked)
            {
                nbNumMemory.Value = Environment.ProcessorCount;
                nbMemory.Enabled = false;
                nbNumMemory.Enabled = false;
                bgAutoCal.WorkerSupportsCancellation = true;//背景執行 BLCK frequrncy

                if (this.bgAutoCal.IsBusy != true)
                {
                    this.bgAutoCal.WorkerReportsProgress = true;
                    this.bgAutoCal.RunWorkerAsync();
                }
            }
            else
            {
                if (this.bgAutoCal.IsBusy)
                {
                    this.bgAutoCal.WorkerReportsProgress = false;
                    this.bgAutoCal.CancelAsync();
                    this.bgAutoCal.Dispose();
                }
                nbMemory.Enabled = true;
                nbNumMemory.Enabled = true;
            }
        }

        private void bgAutoCal_DoWork(object sender, DoWorkEventArgs e)
        {
            for (;;)
            {
                if (bgAutoCal.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    try
                    {
                        bgAutoCal.ReportProgress(0);
                        System.Threading.Thread.Sleep(500);
                    }
                    catch (Exception)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }
        int oneofmem()
        {
            int onememtest =  (int)((memfree - (int)nudHoldMemory.Value) / Environment.ProcessorCount);

            int process = Environment.ProcessorCount;
            if (onememtest > 2048)
            {
                
                while(true)
                {
                    process +=2;
                    onememtest = (int)((memfree - (int)nudHoldMemory.Value) / process);
                    nbNumMemory.Value = process;
                    if (onememtest <= 2048)
                        return onememtest;
                }
            }
            
            return onememtest;

        }
        private void bgAutoCal_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {


            //ReadMSR(0x6, data);
            try
            {
                nbMemory.Value = oneofmem();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            //view.Text = DateTime.Now.ToString();
        }

        private void bgMemoryFree_DoWork(object sender, DoWorkEventArgs e)
        {
            for (;;)
            {
                if (bgMemoryFree.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    try
                    {
                        bgMemoryFree.ReportProgress(0);
                        System.Threading.Thread.Sleep(1000);
                    }
                    catch (Exception)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }
        private void bgMemoryFree_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {


            //ReadMSR(0x6, data);
            try
            {
                getAvailableRAM(lvMemoryState);
                getAvailableRAM(lvMonitorState);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            //view.Text = DateTime.Now.ToString();
        }

        public void getAvailableRAM(ListView listview)
        {
            ComputerInfo CI = new ComputerInfo();
            ulong mem = ulong.Parse(CI.AvailablePhysicalMemory.ToString());
            memfree = ((double)mem / (1024 * 1024));
            listview.Items[0].SubItems[1].Text = memfree.ToString("##.0") + " MB";
            //lbl_Avilable_Memory.Text = (mem / (1024 * 1024) + " MB").ToString();
            if (runtime)
            {
                //sw.Stop();
                listview.Items[0].SubItems[2].Text = sw.Elapsed.ToString(@"dd\ hh\:mm\:ss\.ff");             //D HH:mm:ss.ff   
                //Debug.WriteLine(string.Format("耗時(毫秒) : {0} ", sw.ElapsedMilliseconds.ToString("#,##0")));

                if (coverageoffset > -1 && coveragenew <= 100.0 && timeoffset > 0 && coverageoffset > 0)
                {
                    string lefttime = TimeSpan.FromMilliseconds((100 - coveragenew) / (coverageoffset / timeoffset)).ToString(@"dd\ hh\:mm\:ss\.ff");
                    Debug.WriteLine(lefttime + " " + coveragenew + " " + coverageoffset + " " + timeoffset);
                    listview.Items[0].SubItems[3].Text = lefttime;
                }
            }

        }
    }


}
