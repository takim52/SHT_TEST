using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.InSight.Net;
using System.Net;
using System.IO;

namespace INSIGHT_SDK_TEST
{
    public delegate void DataGetEventHandler(DataGridView data1, CvsNetworkMonitor cnMonitor);
    public partial class Camconfigform : Form
    {
        public DataGetEventHandler DataSendEvent;

        private CvsNetworkMonitor mMonitor;

        private Dictionary<string, IPAddress> newDevices;
        private Dictionary<string, IPAddress> station1;


        private bool bResult = false;
        private int count = 0;

        public Camconfigform()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            try
            {
                // Create a network monitor and connect to events of the display's InSight
                mMonitor = new CvsNetworkMonitor();
                mMonitor.PingInterval = 0;

                newDevices = new Dictionary<string, IPAddress>();
                station1 = new Dictionary<string, IPAddress>();

                dgvNewdevices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvNewdevices.Sort(dgvNewdevices.Columns[0], ListSortDirection.Ascending);
                dgvNewdevices.MultiSelect = false;

                dgvSt1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSt1.Sort(dgvSt1.Columns[0], ListSortDirection.Ascending);
                dgvSt1.MultiSelect = false;

                mMonitor.HostsChanged += new EventHandler(mMonitor_HostsChanged);
                mMonitor.Enabled = true;
            }
            catch (Exception)
            {

            }
        }

        void mMonitor_HostsChanged(object sender, EventArgs e)
        {
            if (!bResult)
            {
                mMonitor.HostsChanged -= new EventHandler(mMonitor_HostsChanged);

                PopulateHostList();
            }

        }

        private void PopulateHostList()
        {
            int FindDeviceNum = mMonitor.Hosts.Count;

            string[,] data = new string[FindDeviceNum, 2];

            if (mMonitor.Hosts.Count > 0)
            {

                for (int i = 0; i < FindDeviceNum; i++)
                {
                    data[i, 0] = mMonitor.Hosts[i].Name.ToString();
                    data[i, 1] = mMonitor.Hosts[i].IPAddress.ToString();

                    if (station1.ContainsValue(mMonitor.Hosts[i].IPAddress))
                    {
                        //station1.Add(mMonitor.Hosts[i].Name, mMonitor.Hosts[i].IPAddress);
                        this.dgvSt1.Rows.Add(data[i, 0], data[i, 1]);

                        count++;
                    }
                    else
                    {
                        try
                        {
                            this.dgvNewdevices.Rows.Add(data[i, 0], data[i, 1]);

                            if (newDevices.Count != mMonitor.Hosts.Count)
                            {
                                newDevices.Add(mMonitor.Hosts[i].Name, mMonitor.Hosts[i].IPAddress);
                            }
                        }
                        catch (Exception ex)
                        {
                            Log("<ERROR> CamConfig Error : " + ex.ToString());
                        }
                    }
                }
                btn_enter.Enabled = true;
                btn_close.Enabled = true;
                bResult = true;
            }
            else
            {
                MessageBox.Show("센서가 없습니다.");
            }


        }

        #region LOG
        public void Log(String msg)
        {
            DateTime today = DateTime.Now;
            string dir_y = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year;
            string dir_m = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year + @"\" + today.Month;

            string FilePath = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year + @"\" + today.Month + @"\" + DateTime.Today.ToString("yyyyMMdd") + ".log";
            string DirPath = Directory.GetCurrentDirectory() + @"\Logs";

            DirectoryInfo di = new DirectoryInfo(DirPath);

            DirectoryInfo di_y = new DirectoryInfo(dir_y);

            DirectoryInfo di_m = new DirectoryInfo(dir_m);

            FileInfo fi = new FileInfo(FilePath);

            try
            {
                if (di.Exists != true) Directory.CreateDirectory(DirPath);
                if (di_y.Exists != true) Directory.CreateDirectory(dir_y);
                if (di_m.Exists != true) Directory.CreateDirectory(dir_m);
                if (fi.Exists != true)
                {
                    using (StreamWriter sw = new StreamWriter(FilePath))
                    {
                        sw.WriteLine(msg);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(FilePath))
                    {
                        sw.WriteLine(msg);
                        sw.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        #endregion

        private void Btn_enter_Click(object sender, EventArgs e)
        {
            GlobalData.NetCamCount = mMonitor.Hosts.Count;
            GlobalData.ConnectedCamCount = dgvSt1.Rows.Count - 1;

            string[,] CamConfigData = new string[dgvSt1.Rows.Count, 2];

            for (int i = 0; i < dgvSt1.Rows.Count - 1; i++)
            {
                var CamName = dgvSt1.Rows[i].Cells[0].Value.ToString();
                var CamIP = dgvSt1.Rows[i].Cells[1].Value.ToString();

                CamConfigData[i + 1, 0] = CamName;
                CamConfigData[i + 1, 1] = CamIP;

                GlobalData.CAMIP[i] = CamIP;
                GlobalData.CAMNAME[i] = CamName;
            }

            DataSendEvent(dgvSt1, mMonitor);
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Hide();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dgvNewdevices.Rows.Clear();
            dgvSt1.Rows.Clear();

            newDevices.Clear();
            station1.Clear();

            string status = string.Empty;
            string[,] data = new string[mMonitor.Hosts.Count, 2]; // 연결된 카메라의 Host Name, Host IP

            if (mMonitor.Hosts.Count > 0)
            {
                for (int i = 0; i < mMonitor.Hosts.Count; i++)
                {
                    data[i, 1] = mMonitor.Hosts[i].IPAddress.ToString();
                    data[i, 0] = mMonitor.Hosts[i].Name.ToString();
                    if (station1.ContainsValue(mMonitor.Hosts[i].IPAddress))
                    {
                        dgvSt1.Rows.Add(data[i, 1]);
                        if (!string.IsNullOrEmpty(data[i, 1].ToString()))
                        {
                            count++;
                        }
                    }
                    else
                    {
                        try
                        {
                            dgvNewdevices.Rows.Add(mMonitor.Hosts[i].Name, mMonitor.Hosts[i].IPAddress);
                            //dgvNewdevices.Rows.Add(data[a, 0].ToString());

                            if (newDevices.Count != mMonitor.Hosts.Count)
                            {
                                newDevices.Add(mMonitor.Hosts[i].Name, mMonitor.Hosts[i].IPAddress);
                            }
                        }
                        catch (Exception ex)
                        {
                        }


                    }

                    // 기존 station에 연결 되어 있을 경우 현재 카운트와 같다면 바로 프로그램 메인을 실행하는 코드
                    // 현재 이 테스트 프로그램에서는 Serialize가 구현 되어 있지 않아 사용하지 않음
                    //if (count == station1.Count)
                    //{
                    //    ClientsCompleteEventArgs cv = new ClientsCompleteEventArgs(false);
                    //    //OnComplete(cv);
                    //}
                }
            }
            else
            {
                MessageBox.Show("센서가 없습니다.");
            }
        }

        private void BtnInsert1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNewdevices.SelectedRows.Count == 0) return;

                var data = dgvNewdevices.SelectedRows[0];

                dgvNewdevices.Rows.Remove(data);
                dgvSt1.Rows.Add(data);

                newDevices.Remove(data.Cells[0].Value.ToString());

                dgvSt1.Sort(dgvSt1.Columns[1], ListSortDirection.Ascending);

                station1.Remove(data.Cells[0].Value.ToString());
                station1.Add(data.Cells[0].Value.ToString(), IPAddress.Parse(data.Cells[1].Value.ToString()));
            }
            catch (Exception)
            {

            }
        }

        private void BtnDelete1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSt1.SelectedRows.Count == 0) return;

                var data = dgvSt1.SelectedRows[0];

                dgvSt1.Rows.Remove(data);

                dgvNewdevices.Rows.Add(data);

                station1.Remove(data.Cells[0].Value.ToString());
                newDevices.Add(data.Cells[0].Value.ToString(), IPAddress.Parse(data.Cells[1].Value.ToString()));

            }
            catch (Exception)
            {
                MessageBox.Show("<ERROR> frmCamConfig btnDelete1_Click");
            }
        }
    }
}
