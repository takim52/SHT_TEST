using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blade_Monitoring
{

    public partial class MainForm : Form
    {
        // 그래프를 보여 주는 역할을 한다.
        private BackgroundWorker bgwProcess_show_Graph = new BackgroundWorker();

        //DB select 쿼리 백그라운드이다.
        private BackgroundWorker bgwProcess_DB_select = new BackgroundWorker();

        // 데이터 그리드 뷰에 나오는 것을 저장 하는 것이다
        private BackgroundWorker bgwProcess_save_data = new BackgroundWorker();

        private Loading_Form loading_Form;

        private Graph_Form graph_form;

        private DB_Controller DB_control;

        //쿼리속도 등을 위해 쓸 예정이다.
        Stopwatch swatch = new Stopwatch();

        private Loading_Form loading;

        Show_IMG_Form frm_showIMG;

        Blocking_Form frm_Blocking;

        //설정값 저장하는 바이너리 데이터
        private Serialization serialization = new Serialization();

        public MainForm()
        {
            InitializeComponent();
        }

        private void User_Tab_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font fntTab;

            Brush bshBack;

            Brush bshFore;

            if (e.Index == this.User_Tab.SelectedIndex)

            {
                fntTab = new Font(e.Font, FontStyle.Bold);

                //bshBack = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, SystemColors.Control, SystemColors.Control, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);//원래 컨트롤색
                //bshFore = Brushes.Black;
                bshBack = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.LightSkyBlue, Color.LightSkyBlue, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                bshFore = Brushes.White;
            }
            else
            {
                fntTab = e.Font;
                //bshBack = new SolidBrush(SystemColors.Control); //원래 컨트롤색
                //bshFore = new SolidBrush(Color.Black);
                bshBack = new SolidBrush(Color.White);
                bshFore = new SolidBrush(Color.Black);
            }

            string tabName = this.User_Tab.TabPages[e.Index].Text;

            StringFormat sftTab = new StringFormat(StringFormatFlags.NoClip);

            sftTab.Alignment = StringAlignment.Center;

            sftTab.LineAlignment = StringAlignment.Center;



            e.Graphics.FillRectangle(bshBack, e.Bounds);

            Rectangle recTab = e.Bounds;

#if true    // <--- 여기를 true 로 변경하면 텍스트의 좌우를 뒤집지 않음

            recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);

            e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);

#else

                        recTab = new Rectangle(0, 0, recTab.Width, recTab.Height);

 

                        Bitmap bitmap = new Bitmap(e.Bounds.Width, e.Bounds.Height);

                        Graphics g = Graphics.FromImage(bitmap);

                        g.Clear(BackColor);        // <--- 여기에 원하는 배경색상을 지정

                        g.DrawString(tabName, fntTab, bshFore, recTab, sftTab);

                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);

 

                        e.Graphics.DrawImage(bitmap, e.Bounds.X + 1, e.Bounds.Y);   // +1 안해주면 왼쪽에서 짤림

 

                        g.Dispose();

                        bitmap.Dispose();

#endif
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DB_control = new DB_Controller();

            //스레드 작업 도중 취소 가능 여부
            bgwProcess_DB_select.WorkerSupportsCancellation = true;

            //스레드가 run시에 호출되는 핸들러 등록
            bgwProcess_DB_select.DoWork += new DoWorkEventHandler(DB_select_DoWork);

            //스레드 작업 도중 취소 가능 여부
            bgwProcess_save_data.WorkerSupportsCancellation = true;

            //스레드가 run시에 호출되는 핸들러 등록
            bgwProcess_save_data.DoWork += new DoWorkEventHandler(save_data_Dowork);

            //스레드 작업 도중 취소 가능 여부
            bgwProcess_show_Graph.WorkerSupportsCancellation = true;

            //스레드가 run시에 호출되는 핸들러 등록
            bgwProcess_show_Graph.DoWork += new DoWorkEventHandler(show_Graph_Dowork);

            User_Tab.DrawMode = TabDrawMode.OwnerDrawFixed;

            loading = new Loading_Form("데이터 조회 중...");

            Deserialize();
        }

        private void DB_select_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;

                GlobalData.query_argument args = e.Argument as GlobalData.query_argument;

                swatch.Start();

                DataTable dt;

                dt = DB_control.DB_SELECT(args);

                swatch.Stop();
                string query_speed = Math.Round(Convert.ToDouble(swatch.ElapsedMilliseconds / 1000), 2).ToString();
                swatch.Reset();

                swatch.Start();
                dgv_selectData.Invoke((MethodInvoker)delegate ()
                {
                    dgv_selectData.DataSource = dt;

                    dgv_selectData.Columns[0].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";

                    dgv_selectData.Update();
                });
                swatch.Stop();
                string ui_speed = Math.Round(Convert.ToDouble(swatch.ElapsedMilliseconds / 1000), 2).ToString();

                lb_Query_speed.Invoke((MethodInvoker)delegate ()
                {
                    lb_Query_speed.Text = query_speed + " s, " + ui_speed + " s "
                    + dt.Rows.Count.ToString() + " 행";
                });

                swatch.Reset();

                this.Invoke((MethodInvoker)delegate ()
                {
                    loading.Close();
                });


                GC.Collect();
            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "]" + DateTime.Now);
            }

        }

        private void save_data_Dowork(object sender, DoWorkEventArgs e)
        {
            if (!cb_date.Checked)
            {
                MessageBox.Show("날짜제한이 걸려 있지 않습니다.\r\n 권장 날짜 : 1일");
            }
            else
            {
                try
                {
                    string csv_path = GlobalData.DATA_PATH + "\\" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".csv";
                    dgv_selectData.Invoke(new MethodInvoker(
                      delegate ()
                      {
                          // Choose whether to write header. Use EnableWithoutHeaderText instead to omit header.
                          dgv_selectData.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                          // Select all the cells
                          dgv_selectData.SelectAll();
                          // Copy selected cells to DataObject
                          DataObject dataObject = dgv_selectData.GetClipboardContent();
                          // Get the text of the DataObject, and serialize it to a file
                          File.WriteAllText(csv_path, dataObject.GetText(TextDataFormat.CommaSeparatedValue));

                          dgv_selectData.ClearSelection();
                      }
                   ));
                }
                catch (Exception ex)
                {

                    Log("[" + ex.ToString() + "]" + DateTime.Now);
                }
            }


        }

        private void show_Graph_Dowork(object sender, DoWorkEventArgs e)
        {
            DataTable[] dataTables = new DataTable[6];
            try
            {
                dataTables = DB_control.DB_Show_Graph(tb_StartDate.Text, tb_EndDate.Text);

                this.Invoke((MethodInvoker)delegate ()
                {
                    graph_form = new Graph_Form(dataTables);

                    graph_form.Show();
                });
                for (int i = 0; i < 6; i++)
                {
                    dataTables[i].Clear();
                }

                GC.Collect();

            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "]" + DateTime.Now);
            }


            this.Invoke((MethodInvoker)delegate ()
            {
                loading_Form.Close();
            });


        }

        private void btn_dateSetting_Click(object sender, EventArgs e)
        {
            DateTime[] dateTimes = DB_control.Get_MinMax_Time();

            DateTime enddate = dateTimes[1];
            enddate = enddate.AddDays(1);

            tb_StartDate.Text = dateTimes[0].ToString("yyyy-MM-dd");
            tb_EndDate.Text = enddate.ToString("yyyy-MM-dd");
        }

        private void btn_Show_Graph_Click(object sender, EventArgs e)
        {
            if (!bgwProcess_show_Graph.IsBusy)
            {
                bgwProcess_show_Graph.RunWorkerAsync();
                loading_Form = new Loading_Form("데이터 처리중 입니다.");

                loading_Form.ShowDialog();
            }
        }

        private void btn_SelfTimeSetting_Click(object sender, EventArgs e)
        {
            DateTime enddate = dtp_SelectEndDate.Value;
            enddate = enddate.AddDays(1);

            tb_StartDate.Text = dtp_SelectStartDate.Value.ToString("yyyy-MM-dd");
            tb_EndDate.Text = enddate.ToString("yyyy-MM-dd");
        }

        private void btn_nglist_select_Click(object sender, EventArgs e)
        {
            if (dgv_ngList.Columns.Count > 0)
            {
                dgv_ngList.Columns.Clear();
            }
            if (dgv_ngList.Rows.Count > 0)
            {
                dgv_ngList.Rows.Clear();
            }

            try//예외 처리
            {
                dgv_ngList.Invoke((MethodInvoker)delegate ()
                {
                    dgv_ngList.DataSource = DB_control.GET_NGLIST();

                    dgv_ngList.Columns[2].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";

                    dgv_ngList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    dgv_ngList.Update();
                });
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                Log("[" + ex.ToString() + "]" + DateTime.Now);
            }
        }

        private void btn_nglist_delete_Click(object sender, EventArgs e)
        {
            DB_control.Delete_NGList();
        }

        private void btn_set_IMG_Click(object sender, EventArgs e)
        {
            try
            {
                //int id = dgv_imgPath.CurrentCell.RowIndex;

                //txt_origin_path.Text = "인덱스 :" + dgv_imgPath.Rows[id].Cells[0].Value.ToString();
                //txt_grid_path.Text = "그리드이미지 : " + dgv_imgPath.Rows[id].Cells[2].Value.ToString();

                //txt_info.Text = "인덱스 :" + dgv_imgPath.Rows[id].Cells[0].Value.ToString() +
                //    ", 그리드이미지 : " + dgv_imgPath.Rows[id].Cells[2].Value.ToString();
                //pb_GRID.Image = Image.FromFile(dgv_imgPath.Rows[id].Cells[2].Value.ToString());
            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "]" + DateTime.Now);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        public void Log(String msg)
        {
            DateTime today = DateTime.Now;
            string dir_y = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year;
            string dir_m = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year + @"\" + today.Month;

            string FilePath = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year + @"\" + today.Month + @"\" + DateTime.Today.ToString("yyyyMMdd")
                + "_MAIN.log";
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

        private void cb_date_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_date.Checked)
            {
                dtp_StartDate.Enabled = true;
                dtp_EndDate.Enabled = true;
            }
            else
            {
                dtp_StartDate.Enabled = false;
                dtp_EndDate.Enabled = false;
            }
        }

        private void btn_Selct_Click(object sender, EventArgs e)
        {
            string barcode_name = "";

            if (dgv_selectData.Columns.Count > 0)
            {
                dgv_selectData.Columns.Clear();
            }
            if (dgv_selectData.Rows.Count > 0)
            {
                dgv_selectData.Rows.Clear();
            }

            barcode_name = txt_barcode.Text;
            try//예외 처리
            {

                // 이부분 추가 해야함 체크 되어 있으면 날짜 제한을 해야한다.
                // 토탈쿼리 부분에도 추가를 해주어야 함
                //DateTime enddate = dtp_EndDate.Value;
                //enddate = enddate.AddDays(1);

                DateTime stTime = new DateTime(dtp_StartDate.Value.Year, dtp_StartDate.Value.Month, dtp_StartDate.Value.Day
                   , Convert.ToInt32(nud_Start_Hour.Value), Convert.ToInt32(nud_Start_Minutes.Value), 0);

                DateTime edTime = new DateTime(dtp_EndDate.Value.Year, dtp_EndDate.Value.Month, dtp_EndDate.Value.Day
                    , Convert.ToInt32(nud_End_Hour.Value), Convert.ToInt32(nud_End_Minutes.Value), 0);

                if (cb_date.Checked)
                {
                    // 스레드가 Busy(수행중)가 아니라면
                    if (bgwProcess_DB_select.IsBusy != true)
                    {
                        // 스레드 작동!! 아래 함수 호출 시 위에서 bw.DoWork += new DoWorkEventHandler(bw_DoWork); 에 등록한 핸들러가 호출됨
                        bgwProcess_DB_select.RunWorkerAsync(new GlobalData.query_argument(barcode_name, 
                            string.Format("{0:u}", stTime),
                            string.Format("{0:u}", edTime), cb_date.Checked, cb_ng.Checked, false));
                    }
                }
                else
                {
                    // 스레드가 Busy(수행중)가 아니라면
                    if (bgwProcess_DB_select.IsBusy != true)
                    {
                        // 스레드 작동!! 아래 함수 호출 시 위에서 bw.DoWork += new DoWorkEventHandler(bw_DoWork); 에 등록한 핸들러가 호출됨
                        bgwProcess_DB_select.RunWorkerAsync(new GlobalData.query_argument(barcode_name, cb_date.Checked, cb_ng.Checked, false));
                    }
                }
                loading.ShowDialog();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());

                Log("[" + ex.ToString() + "]" + DateTime.Now);
            }
        }

        private void btn_TotalSelect_Click(object sender, EventArgs e)
        {
            if (dgv_selectData.Columns.Count > 0)
            {
                dgv_selectData.Columns.Clear();
            }
            if (dgv_selectData.Rows.Count > 0)
            {
                dgv_selectData.Rows.Clear();
            }

            swatch.Start();

            try//예외 처리
            {
                string sql = "";
                //DateTime enddate = dtp_EndDate.Value;
                //enddate = enddate.AddDays(1);

                DateTime stTime = new DateTime(dtp_StartDate.Value.Year, dtp_StartDate.Value.Month, dtp_StartDate.Value.Day
                    , Convert.ToInt32(nud_Start_Hour.Value), Convert.ToInt32(nud_Start_Minutes.Value), 0);

                DateTime edTime = new DateTime(dtp_EndDate.Value.Year, dtp_EndDate.Value.Month, dtp_EndDate.Value.Day
                    , Convert.ToInt32(nud_End_Hour.Value), Convert.ToInt32(nud_End_Minutes.Value), 0);

                if (cb_date.Checked)
                {
                    // 스레드가 Busy(수행중)가 아니라면
                    if (bgwProcess_DB_select.IsBusy != true)
                    {
                        // 스레드 작동!! 아래 함수 호출 시 위에서 bw.DoWork += new DoWorkEventHandler(bw_DoWork); 에 등록한 핸들러가 호출됨
                        bgwProcess_DB_select.RunWorkerAsync(new GlobalData.query_argument(string.Format("{0:u}", stTime),
                           string.Format("{0:u}", edTime), cb_date.Checked, cb_ng.Checked, true));
                    }
                }
                else
                {
                    // 스레드가 Busy(수행중)가 아니라면
                    if (bgwProcess_DB_select.IsBusy != true)
                    {
                        // 스레드 작동!! 아래 함수 호출 시 위에서 bw.DoWork += new DoWorkEventHandler(bw_DoWork); 에 등록한 핸들러가 호출됨
                        bgwProcess_DB_select.RunWorkerAsync(new GlobalData.query_argument(cb_date.Checked, cb_ng.Checked, true));
                    }
                }
                loading.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                Log("[" + ex.ToString() + "]" + DateTime.Now);
            }
        }

        private void btn_save_data_Click(object sender, EventArgs e)
        {
            if (!bgwProcess_save_data.IsBusy)
            {
                bgwProcess_save_data.RunWorkerAsync();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_showIMG = new Show_IMG_Form(DB_control);

            frm_showIMG.Show();
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

                txt_image_path.Text = GlobalData.IMAGE_PATH;

                txt_data_Path.Text = GlobalData.DATA_PATH;

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

        private void btn_select_directory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                GlobalData.IMAGE_PATH = fbd.SelectedPath;
                txt_image_path.Text = GlobalData.IMAGE_PATH;
                Log("이미지 저장 폴더 설정 :: " + DateTime.Now);
            }
        }

        private void btn_directory_data_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                GlobalData.DATA_PATH = fbd.SelectedPath;
                txt_data_Path.Text = GlobalData.DATA_PATH;
                Log("데이터 저장 폴더 설정 :: " + DateTime.Now);
            }
        }

        private void btn_image_folder_start_Click(object sender, EventArgs e)
        {
            Process.Start(txt_image_path.Text);
        }

        private void btn_data_folder_start_Click(object sender, EventArgs e)
        {
            Process.Start(txt_data_Path.Text);
        }

        private void btn_setting_Save_Click(object sender, EventArgs e)
        {
            Serialize();
            MessageBox.Show("설정 저장 완료!");
        }

        private void btn_Blocking_Click(object sender, EventArgs e)
        {
            frm_Blocking = new Blocking_Form(DB_control);

            frm_Blocking.Show();
        }
    }
}
