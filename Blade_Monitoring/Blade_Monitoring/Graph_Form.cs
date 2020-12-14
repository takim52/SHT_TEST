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
    public partial class Graph_Form : Form
    {
        DataTable[] dataTables;

        private double[] point1 = new double[230000];
        private double[] point2 = new double[230000];
        private double[] point3 = new double[230000];
        private double[] point4 = new double[230000];
        private double[] width1 = new double[230000];
        private double[] width2 = new double[230000];
        public Graph_Form()
        {
            InitializeComponent();
        }

        public Graph_Form(DataTable[] tables)
        {
            InitializeComponent();

            dataTables = tables;

            chart_Point1.ChartAreas[0].AxisY.Minimum = 0;
            chart_Point1.ChartAreas[0].AxisY.Maximum = 10;

            chart_Point2.ChartAreas[0].AxisY.Minimum = 0;
            chart_Point2.ChartAreas[0].AxisY.Maximum = 10;

            chart_Point3.ChartAreas[0].AxisY.Minimum = 0;
            chart_Point3.ChartAreas[0].AxisY.Maximum = 10;

            chart_Point4.ChartAreas[0].AxisY.Minimum = 0;
            chart_Point4.ChartAreas[0].AxisY.Maximum = 10;

            chart_Point1.ChartAreas[0].AxisX.Title = "count";
            chart_Point1.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;
            chart_Point1.ChartAreas[0].AxisY.Title = "mm";
            chart_Point1.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;

            chart_Point2.ChartAreas[0].AxisX.Title = "count";
            chart_Point2.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;
            chart_Point2.ChartAreas[0].AxisY.Title = "mm";
            chart_Point2.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;

            chart_Point3.ChartAreas[0].AxisX.Title = "count";
            chart_Point3.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;
            chart_Point3.ChartAreas[0].AxisY.Title = "mm";
            chart_Point3.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;

            chart_Point4.ChartAreas[0].AxisX.Title = "count";
            chart_Point4.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;
            chart_Point4.ChartAreas[0].AxisY.Title = "mm";
            chart_Point4.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;

            chart_Width1.ChartAreas[0].AxisX.Title = "count";
            chart_Width1.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;
            chart_Width1.ChartAreas[0].AxisY.Title = "mm";
            chart_Width1.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;

            chart_Width2.ChartAreas[0].AxisX.Title = "count";
            chart_Width2.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;
            chart_Width2.ChartAreas[0].AxisY.Title = "mm";
            chart_Width2.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;

            Log("조회 그래프 생성 완료" + DateTime.Now);
        }


        public void Log(String msg)
        {
            DateTime today = DateTime.Now;
            string dir_y = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year;
            string dir_m = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year + @"\" + today.Month;

            string FilePath = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year + @"\" + today.Month + @"\" + DateTime.Today.ToString("yyyyMMdd")
                + "_Graph.log";
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

        private void Graph_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void Graph_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }

        private void Graph_Form_Load(object sender, EventArgs e)
        {
            try
            {
                //차트 컨트롤 --띄워주는것
                chart_Point1.Series[0].Points.DataBindY(dataTables[0].DefaultView);
                chart_Point2.Series[0].Points.DataBindY(dataTables[1].DefaultView);
                chart_Point3.Series[0].Points.DataBindY(dataTables[2].DefaultView);
                chart_Point4.Series[0].Points.DataBindY(dataTables[3].DefaultView);
                chart_Width1.Series[0].Points.DataBindY(dataTables[4].DefaultView);
                chart_Width2.Series[0].Points.DataBindY(dataTables[5].DefaultView);

                chart_Point1.Update();
                chart_Point2.Update();
                chart_Point3.Update();
                chart_Point4.Update();
                chart_Width1.Update();
                chart_Width2.Update();
            }
            catch (Exception ex)
            {
                Log(ex.ToString() + DateTime.Now);
            }
        }
    }
}
