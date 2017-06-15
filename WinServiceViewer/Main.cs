using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using Microsoft.Win32;
using System.Management;
using System.Diagnostics;
using System.Threading;

// В UI нужно отображать Name, DisplayName, Status и аккаунт под которым работает служба. 
// ListView должен заполняться по мере получения информации (получение информации по сервису может занять длительное время). 
// Получение информации по сервисам можно приостановить и продолжить»

namespace WinServiceViewer
{
    public partial class Main : Form
    {
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        System.Threading.ManualResetEvent _busy = new System.Threading.ManualResetEvent(false);

        public Main()
        {
            InitializeComponent();

            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
        }

        void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                _busy.WaitOne(Timeout.Infinite);
                if (backgroundWorker.CancellationPending)
                    return;
                Thread.Sleep(1000);
                backgroundWorker.ReportProgress(i);
            }
        }

        void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
          // toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(this, "Вывод информации о службах Windows завершен");
        }

        private void test_start_Click(object sender, EventArgs e)
        {
            //backgroundWorker.RunWorkerAsyn​c();

            if (!backgroundWorker.IsBusy)
            {
                MessageBox.Show("Not Busy"); //Just For Debugg
                _busy.Set();
                //Start_Back.Text = "Pause";
                backgroundWorker.RunWorkerAsync();
            }
            else
            {
                _busy.Reset();
                //Start_Back.Text = "Resume";
            }

           // btnStop.Enabled = true;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CancelWorker();
        }

        private void test_pause_Click(object sender, EventArgs e)
        {
            PauseWorker();
        }

        private void test_resume_Click(object sender, EventArgs e)
        {
            ResumeWorker();
        }
        

        void ResumeWorker()
        {
            // Start the worker if it isn't running
            if (!backgroundWorker.IsBusy) backgroundWorker.RunWorkerAsync();
            // Unblock the worker 
            _busy.Set();
        }

        void PauseWorker()
        {
            // Block the worker
            _busy.Reset();
        }

        void CancelWorker()
        {
            if (backgroundWorker.IsBusy)
            {
                // Set CancellationPending property to true
                backgroundWorker.CancelAsync();
                // Unblock worker so it can see that
                _busy.Set();
            }
        }












        private void tsUpdate_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (ServiceController service in ServiceController.GetServices())
            {
                try
                {
                    count++;
                    string login = "";

                    string select = "select name, startname from Win32_Service where name = '" + service.ServiceName + "'";
                    using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(new SelectQuery(string.Format(select))))
                    {
                        foreach (ManagementObject servicew in searcher.Get())
                        {
                            // Console.WriteLine(string.Format("Name: {0} - Logon : {1} ", servicew["Name"], servicew["startname"]));
                            login = string.Format("{0}", servicew["startname"]);
                            break;
                        }
                    }

                    listViewService.Items.Add(new ListViewItem(new string[] { service.ServiceName, service.Status.ToString(), login }));
                    tsStatus.Text = "Найдено сервисов: " + count;
                }
                catch (Exception ex) { Debug.Print(ex.Message); }
            }
        }

        private void tsStopUpdate_Click(object sender, EventArgs e)
        {

        }


    }
}
