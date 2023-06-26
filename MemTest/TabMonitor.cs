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
using System.Text.RegularExpressions;

namespace MemTest
{
    public partial class Form1
    {

        private void bgMonitor_DoWork(object sender, DoWorkEventArgs e)
        {
            for (;;)
            {
                if (bgMonitor.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    try
                    {
                        bgMonitor.ReportProgress(0);
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

        private void bgMonitor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                MonitorBurning();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void MonitorBurning()
        {
            //lvMonitor.BeginUpdate();
           
            foreach (var had in handle.Select((value, i) => new { i, value }))
            {
                string strReturnText = AutoItX.ControlGetText(had.value, AutoItX.ControlGetHandle(had.value, "Static1"));
                Debug.WriteLine(strReturnText);
                string[] str = Regex.Replace(strReturnText, "[^0-9,.]", "").Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                if (str.Count() < 1)
                    continue;
                if(had.i==0)
                {
                    timenew = sw.Elapsed.TotalMilliseconds;
                    coveragenew = Convert.ToDouble(str[0]);
                    timeoffset = (timenew - timeold);
                    coverageoffset = coveragenew - coverageold;
                    coverageold = coveragenew;
                    timeold = timenew;
                }
                lvMonitor.Items[had.i].SubItems[2].Text = str[0] + "%";
                lvMonitor.Items[had.i].SubItems[3].Text = str[1] + " Error";
                if (Convert.ToDouble(str[0]) > 100.0)
                    lvMonitor.Items[had.i].BackColor = Color.Blue;
                if (Convert.ToInt32(str[1]) > 0)
                    lvMonitor.Items[had.i].BackColor = Color.Red;
            }
            //lvMonitor.Items[4].BackColor = Color.Red;
            //lvMonitor.EndUpdate();
        }
    }
}
