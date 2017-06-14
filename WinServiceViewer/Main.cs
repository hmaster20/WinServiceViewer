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

// В UI нужно отображать Name, DisplayName, Status и аккаунт под которым работает служба. 
// ListView должен заполняться по мере получения информации (получение информации по сервису может занять длительное время). 
// Получение информации по сервисам можно приостановить и продолжить»

namespace WinServiceViewer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tsUpdate_Click(object sender, EventArgs e)
        {
            //ServiceController[] services = ServiceController.GetServices();
            //foreach (ServiceController service in services)

            int count = 0;

            foreach (ServiceController service in ServiceController.GetServices())
            {
                try
                {
                    count++;

                    //ListViewItem newListViewItem = new ListViewItem();

                    //newListViewItem.Text = "Сервис: " + service.ServiceName;
                    //newListViewItem.SubItems.Add(service.Status.ToString());

                    ////RegistryKey regKey1 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\" + service.ServiceName);
                    ////newListViewItem.SubItems.Add(regKey1.GetValue("ImagePath").ToString());
                    ////newListViewItem.SubItems.Add(regKey1.GetValue("Description").ToString());
                    ////regKey1.Close();

                    //listViewService.Items.Add(newListViewItem);

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

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void tsStopUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
