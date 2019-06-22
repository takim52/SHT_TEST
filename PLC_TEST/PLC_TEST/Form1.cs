using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ACTMULTILib;

namespace PLC_TEST
{
    public partial class Form1 : Form
    {
        delegate void AppendTextDelegate(Control ctrl, string s);
        ActEasyIF easyIF;
        AppendTextDelegate _textAppender;

        public Form1()
        {
            InitializeComponent();
            easyIF = new ActEasyIF();
            easyIF.ActLogicalStationNumber = 0;
            _textAppender = new AppendTextDelegate(AppendText);
            PLCOpen();
        }
        void AppendText(Control ctrl, string s)
        {
            if (ctrl.InvokeRequired) ctrl.Invoke(_textAppender, ctrl, s);
            else
            {
                string source = ctrl.Text;
                ctrl.Text = source + Environment.NewLine + s;

            }

        }

        private void PLCOpen()
        {
            try
            {
                var IRet = 0;

                IRet = easyIF.Open();

                if (IRet != 0)
                {
                    AppendText(richTextBox1, "!! PLC 오픈 에러 !! "  + IRet);
                    //GetReadPLC.Change(Timeout.Infinite, Timeout.Infinite);
                }
                else
                {
                    AppendText(richTextBox1, "!! PLC 오픈 !! " + IRet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("<ERROR> PLC OPEN FUNCTION ERROR : " + ex.ToString());
            }
        }

        public void PLCBit_Control(string address, short bit)
        {
            DateTime today = DateTime.Now;
            int check = 1;
            lock (this)
            {
                try
                {
                    Log("비트 쓰는중 !" + today.ToString());
                    check = easyIF.SetDevice2(address, bit);
                    Log("비트 쓰기완료 !" + today.ToString());

                    AppendText(richTextBox1, "!! 값을 넣자 !! " + check + "  ::  " + bit);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("<ERROR> PLC READ FUNCTION ERROR : " + ex.ToString());
                    Log("PLC READ ERROR :: " + today.ToString()+ "    ::    "  + ex.ToString());
                }
            }


        }

        // 계속해서 비전 요구 확인
        public short PLC_READ_Thread(string address)
        {
            DateTime today = DateTime.Now;
            short result = 0;
            int ck = 0;
            lock (this)
            {
                try
                {
                    Log("비트 읽기중 !" + today.ToString() );
                    ck = easyIF.GetDevice2(address, out result);
                    Log("비트 읽기완료 !" + today.ToString());
                    AppendText(richTextBox1, "!! 값을 보자 !! " + ck + "  ::  " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("<ERROR> PLC READ FUNCTION ERROR : " + ex.ToString());
                    Log("PLC WRITE ERROR :: " + today.ToString() + "    ::    " + ex.ToString());
                }
            }

            return result;
        }

        private void PLCDATA_Control(string address, int bit)
        {
            DateTime today = DateTime.Now;
            int check = 1;
            lock (this)
            {
                try
                {
                    Log("데이터 쓰는중 !" + today.ToString());
                    check = easyIF.SetDevice(address, bit);
                    Log("데이터 쓰기완료 !" + today.ToString());

                    AppendText(richTextBox1, "!! 값을 넣자 !! " + check + "  ::  " + bit);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("<ERROR> PLC READ FUNCTION ERROR : " + ex.ToString());
                    Log("PLC READ ERROR :: " + today.ToString() + "    ::    " + ex.ToString());
                }
            }
        }

        private int PLC_READ_DATA(string address)
        {
            DateTime today = DateTime.Now;
            int result = 0;
            int ck = 0;
            lock (this)
            {
                try
                {
                    Log("데이터 읽기중 !" + today.ToString());
                    ck = easyIF.GetDevice(address, out result);
                    Log("데이터 읽기완료 !" + today.ToString());
                    AppendText(richTextBox1, "!! 값을 보자 !! " + ck + "  ::  " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("<ERROR> PLC READ FUNCTION ERROR : " + ex.ToString());
                    Log("PLC WRITE ERROR :: " + today.ToString() + "    ::    " + ex.ToString());
                }
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PLCBit_Control(textBox1.Text, 1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(PLC_READ_Thread(textBox2.Text));
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            PLCDATA_Control(textBox3.Text , 15);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(PLC_READ_DATA(textBox4.Text));
        }

        public void Log(String msg)
        {
            DateTime today = DateTime.Now;

            string FilePath = Directory.GetCurrentDirectory() + @"\Logs\" + DateTime.Today.ToString("yyyyMMdd") + ".log";
            string DirPath = Directory.GetCurrentDirectory() + @"\Logs";


            DirectoryInfo di = new DirectoryInfo(DirPath);

            FileInfo fi = new FileInfo(FilePath);

            try
            {
                if (di.Exists != true) Directory.CreateDirectory(DirPath);
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
    }
}
