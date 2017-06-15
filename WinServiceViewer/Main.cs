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


// Получение информации по сервисам можно приостановить и продолжить»

namespace WinServiceViewer
{
    public partial class Main : Form
    {
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        ManualResetEvent _busy = new ManualResetEvent(false);

        public Main()
        {
            InitializeComponent();

            this.Icon = WinServiceViewer.Properties.Resources.main;
            this.Text = "Список сервисов Windows";

            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = 0;

            foreach (ServiceController service in ServiceController.GetServices())
            {
                try
                {
                    _busy.WaitOne(Timeout.Infinite);
                    if (backgroundWorker.CancellationPending) return;

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

                    this.Invoke(new MethodInvoker(delegate { listViewService.Items.Add(new ListViewItem(new string[] { service.ServiceName, service.Status.ToString(), login })); }));
                    //listViewService.Items.Add(new ListViewItem(new string[] { service.ServiceName, service.Status.ToString(), login }));
                    tsScanStatus.Text = "Найдено сервисов: " + count;
                }
                catch (Exception ex) { Debug.Print(ex.Message); }
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tsState.Text = "Сканирование завершено!";
            tsState.ForeColor = System.Drawing.Color.Gray;
            btnStart.Image = WinServiceViewer.Properties.Resources.start;
            btnStop.Enabled = false;
        }

        private void btnStart_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStart.Checked)
            {
                btnStart.Image = WinServiceViewer.Properties.Resources.pause;
                tsState.Text = "Сканирование запущено";
                if (!backgroundWorker.IsBusy) backgroundWorker.RunWorkerAsync();
                _busy.Set();
            }
            else
            {
                _busy.Reset();
                btnStart.Image = WinServiceViewer.Properties.Resources.start;
                tsState.Text = "Сканирование остановлено";
            }
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                // Set CancellationPending property to true
                backgroundWorker.CancelAsync();
                // Unblock worker so it can see that
                _busy.Set();

                btnStop.Enabled = false;
            }
        }
    }
}
