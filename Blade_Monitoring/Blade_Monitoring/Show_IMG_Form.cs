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
    public partial class Show_IMG_Form : Form
    {
        int selectedIndex = 0;

        DB_Controller dbControl;

        public Show_IMG_Form(DB_Controller DB_control)
        {
            InitializeComponent();

            dbControl = DB_control;
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

        private void btn_set_IMG_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_imgPath.CurrentCell == null)
                {
                    MessageBox.Show("이미지를 선택해주세요!");
                    return;
                }
                int id = dgv_imgPath.CurrentCell.RowIndex;
                selectedIndex = dgv_imgPath.CurrentCell.RowIndex;
                txt_grid_path.Text = "그리드이미지 : " + dgv_imgPath.Rows[id].Cells[2].Value.ToString();

                txt_info.Text = dgv_imgPath.Rows[id].Cells[0].Value.ToString() + " :: " + "그리드이미지 : " + dgv_imgPath.Rows[id].Cells[2].Value.ToString();
                pb_GRID.Image = Image.FromFile(dgv_imgPath.Rows[id].Cells[3].Value.ToString());
            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "]" + DateTime.Now);
            }
        }

        private void Show_IMG_Form_Load(object sender, EventArgs e)
        {
            User_Tab.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        public void Log(String msg)
        {
            DateTime today = DateTime.Now;
            string dir_y = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year;
            string dir_m = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year + @"\" + today.Month;

            string FilePath = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year + @"\" + today.Month + @"\" + DateTime.Today.ToString("yyyyMMdd")
                + "_IMG_PATH.log";
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

            }

        }

        private void btn_WholeSelect_Click(object sender, EventArgs e)
        {
            if (dgv_imgPath.Columns.Count > 0)
            {
                dgv_imgPath.Columns.Clear();
            }
            if (dgv_imgPath.Rows.Count > 0)
            {
                dgv_imgPath.Rows.Clear();
            }

            dgv_imgPath.DataSource = dbControl.GET_IMG_PATH();
            dgv_imgPath.Update();

            int last_index = dgv_imgPath.ColumnCount;
            for (int i = 0; i < last_index; i++)
            {
                if (i == (last_index - 1))
                {
                    dgv_imgPath.Columns[i].AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                else
                {
                    dgv_imgPath.Columns[i].AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }

            foreach (DataGridViewColumn dgvc in dgv_imgPath.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            dgv_imgPath.RowTemplate.Height = 50;

            for (int i = 0; i < dgv_imgPath.Rows.Count; i++)
            {
                if (dgv_imgPath.Rows[i].Cells[0].Value.ToString().ToLower().Equals("ng"))
                {
                    dgv_imgPath.Rows[i].Cells[0].Style.ForeColor = Color.Red;
                }
            }
        }

        private void btn_ChoiceSelect_Click(object sender, EventArgs e)
        {
            if (dgv_imgPath.Columns.Count > 0)
            {
                dgv_imgPath.Columns.Clear();
            }
            if (dgv_imgPath.Rows.Count > 0)
            {
                dgv_imgPath.Rows.Clear();
            }

            DateTime stTime = new DateTime(dtp_StartDate.Value.Year, dtp_StartDate.Value.Month, dtp_StartDate.Value.Day
                    , Convert.ToInt32(nud_Start_Hour.Value), Convert.ToInt32(nud_Start_Minutes.Value), 0);

            DateTime edTime = new DateTime(dtp_EndDate.Value.Year, dtp_EndDate.Value.Month, dtp_EndDate.Value.Day
                , Convert.ToInt32(nud_End_Hour.Value), Convert.ToInt32(nud_End_Minutes.Value), 0);

            dgv_imgPath.DataSource = dbControl.GET_ChoiceIMGPATH(stTime, edTime);
            dgv_imgPath.Update();

            int last_index = dgv_imgPath.ColumnCount;
            for (int i = 0; i < last_index; i++)
            {
                if (i == (last_index - 1))
                {
                    dgv_imgPath.Columns[i].AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                else
                {
                    dgv_imgPath.Columns[i].AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }

            foreach (DataGridViewColumn dgvc in dgv_imgPath.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgv_imgPath.RowTemplate.Height = 50;

            for (int i = 0; i < dgv_imgPath.Rows.Count; i++)
            {
                if (dgv_imgPath.Rows[i].Cells[0].Value.ToString().ToLower().Equals("ng"))
                {
                    dgv_imgPath.Rows[i].Cells[0].Style.ForeColor = Color.Red;
                }
            }
        }

        private void btn_perview_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_imgPath.Rows.Count < 1)
                {
                    MessageBox.Show("이미지 조회를 먼저 해주세요");
                    return;
                }
                if (selectedIndex >= dgv_imgPath.Rows.Count - 1)
                {
                    MessageBox.Show("가장 오래 된 이미지입니다.");
                }
                else
                {
                    selectedIndex += 1;
                    txt_grid_path.Text = "그리드이미지 : " + dgv_imgPath.Rows[selectedIndex].Cells[2].Value.ToString();

                    txt_info.Text = dgv_imgPath.Rows[selectedIndex].Cells[0].Value.ToString() + " :: " + "그리드이미지 : " + dgv_imgPath.Rows[selectedIndex].Cells[2].Value.ToString();
                    pb_GRID.Image = Image.FromFile(dgv_imgPath.Rows[selectedIndex].Cells[3].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "]" + DateTime.Now);
            }
        }

        private void btn_nextView_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_imgPath.Rows.Count < 1)
                {
                    MessageBox.Show("이미지 조회를 먼저 해주세요");
                    return;
                }
                if (selectedIndex <= 0)
                {
                    MessageBox.Show("가장 최신 이미지입니다.");
                }
                else
                {
                    selectedIndex -= 1;
                    txt_grid_path.Text = "그리드이미지 : " + dgv_imgPath.Rows[selectedIndex].Cells[2].Value.ToString();

                    txt_info.Text = dgv_imgPath.Rows[selectedIndex].Cells[0].Value.ToString() + " :: " + "그리드이미지 : " + dgv_imgPath.Rows[selectedIndex].Cells[2].Value.ToString();
                    pb_GRID.Image = Image.FromFile(dgv_imgPath.Rows[selectedIndex].Cells[3].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "]" + DateTime.Now);
            }
        }
    }
}
