using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blade_Monitoring
{
    public partial class Blocking_Form : Form
    {
        DB_Controller dbControl;

        //설정값 저장하는 바이너리 데이터
        private Serialization serialization = new Serialization();

        public Blocking_Form(DB_Controller DB_control)
        {
            InitializeComponent();

            dbControl = DB_control;

            Refresh_Table();

            Deserialize();

            cb_SelectData.Checked = GlobalData.Select_Data;
            cb_NGList.Checked = GlobalData.NGList;
            cb_NG_IMAGE.Checked = GlobalData.NG_IMAGE;
        }

        private void Refresh_Table()
        {
            if (dgv_BlockingData.Columns.Count > 0)
            {
                dgv_BlockingData.Columns.Clear();
            }
            if (dgv_BlockingData.Rows.Count > 0)
            {
                dgv_BlockingData.Rows.Clear();
            }

            dgv_BlockingData.DataSource = dbControl.Get_BlockingTable();
            dgv_BlockingData.Update();

            int last_index = dgv_BlockingData.ColumnCount;
            for (int i = 0; i < last_index; i++)
            {
                if (i == (last_index - 1))
                {
                    dgv_BlockingData.Columns[i].AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                else
                {
                    dgv_BlockingData.Columns[i].AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }

            dgv_BlockingData.RowTemplate.Height = 50;
        }

        private void cb_AllCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_AllCheck.Checked)
            {
                if (!cb_SelectData.Checked)
                {
                    cb_SelectData.Checked = true;
                    GlobalData.Select_Data = true;
                }
                if (!cb_NGList.Checked)
                {
                    cb_NGList.Checked = true;
                    GlobalData.NGList = true;
                }
                if (!cb_NG_IMAGE.Checked)
                {
                    cb_NG_IMAGE.Checked = true;
                    GlobalData.NG_IMAGE = true;
                }

            }
            else
            {
                if (cb_SelectData.Checked)
                {
                    cb_SelectData.Checked = false;
                    GlobalData.Select_Data = false;
                }
                if (cb_NGList.Checked)
                {
                    cb_NGList.Checked = false;
                    GlobalData.NGList = false;
                }
                if (cb_NG_IMAGE.Checked)
                {
                    cb_NG_IMAGE.Checked = false;
                    GlobalData.NG_IMAGE = false;
                }
            }
        }

        private void btn_SaveBarcode_Click(object sender, EventArgs e)
        {
            dbControl.INSERT_BlockingData(txt_barcode.Text);
            Refresh_Table();
        }

        private void btn_DeleteData_Click(object sender, EventArgs e)
        {
            dbControl.Delete_BlockingData(txt_barcode.Text);
            Refresh_Table();
        }

        private void btn_AllDelete_Click(object sender, EventArgs e)
        {
            dbControl.Delete_BlockingData("AllData");
            Refresh_Table();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_SelectData_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_SelectData.Checked)
            {
                GlobalData.Select_Data = true;
            }
            else
            {
                GlobalData.Select_Data = false;
            }

            Serialize();
        }

        private void cb_NGList_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_NGList.Checked)
            {
                GlobalData.NGList = true;
            }
            else
            {
                GlobalData.NGList = false;
            }
            Serialize();
        }

        private void cb_NG_IMAGE_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_NG_IMAGE.Checked)
            {
                GlobalData.NG_IMAGE = true;
            }
            else
            {
                GlobalData.NG_IMAGE = false;
            }
            Serialize();
        }

        #region Serialization

        private void Serialize()
        {
            try
            {

                Dictionary<string, string> data = new Dictionary<string, string>();

                data.Add("IMAGE_PATH", GlobalData.IMAGE_PATH);

                data.Add("DATA_PATH", GlobalData.DATA_PATH);


                data.Add("CB_SELECT", GlobalData.Select_Data.ToString());
                data.Add("CB_NGLIST", GlobalData.NGList.ToString());
                data.Add("CB_NGIMAGE", GlobalData.NG_IMAGE.ToString());

                serialization.Setting_Data_Serialize(data);

                //MessageBox.Show("저장 성공!");
                Log("시리얼라이즈 성공!  :: " + DateTime.Now);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("저장 실패!");
                Log("시리얼라이즈 실패!!!!  :: " + ex.ToString() + " ::  " + DateTime.Now);
            }

        }

        private Dictionary<string, string> Deserialize()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            try
            {
                data = serialization.Setting_Data_Deserialize();

                GlobalData.IMAGE_PATH = data["IMAGE_PATH"];
                GlobalData.DATA_PATH = data["DATA_PATH"];

                string[] checkbox = new string[3];

                checkbox[0] = data["CB_SELECT"];
                checkbox[1] = data["CB_NGLIST"];
                checkbox[2] = data["CB_NGIMAGE"];

                for (int i = 0; i < checkbox.Length; i++)
                {
                    if (checkbox[i].Equals(null))
                    {
                        checkbox[i] = "false";
                    }
                }

                GlobalData.Select_Data = Convert.ToBoolean(checkbox[0]);
                GlobalData.NGList = Convert.ToBoolean(checkbox[1]);
                GlobalData.NG_IMAGE = Convert.ToBoolean(checkbox[2]);


                Log("디시리얼라이즈 성공!  :: " + DateTime.Now);
            }

            catch (Exception ex)
            {
                Log("디시리얼라이즈 실패!!!!  :: " + ex.ToString() + " ::  " + DateTime.Now);
            }

            return data;
        }

        #endregion

        public void Log(String msg)
        {
            DateTime today = DateTime.Now;
            string dir_y = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year;
            string dir_m = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year + @"\" + today.Month;

            string FilePath = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year + @"\" + today.Month + @"\" + DateTime.Today.ToString("yyyyMMdd")
                + "_Blocking.log";
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
            catch (Exception)
            {

            }

        }
    }
}
