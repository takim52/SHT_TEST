using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS232_TEST
{
    
    public partial class Form1 : Form
    {
        delegate void AppendTextDelegate(Control ctrl, string s);
        AppendTextDelegate _textAppender;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.IO.Ports.SerialPort serialPort4;
        public Form1()
        {
            InitializeComponent();
            _textAppender = new AppendTextDelegate(AppendText);

            //LoadIFSP1(null, null);
            //LoadIFSP2(null, null);
            //LoadIFSP3(null, null);
            //LoadIFSP4(null, null);
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

        private void LoadIFSP1(object sender, EventArgs e)
        {
            try
            {
                if (chkPortUse1.Checked)
                {
                    serialPort1 = new SerialPort();
                    serialPort1.PortName = cbbPortName1.Text.ToUpper().ToString();
                    serialPort1.BaudRate = int.Parse(cbbBaudRate1.Text);
                    serialPort1.DataBits = int.Parse(txtDataBit.Text);
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;

                    serialPort1.Open();
                    //serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                }
            }
            catch (Exception)
            {
                if (!serialPort1.IsOpen)
                    MessageBox.Show("<ERROR> SerialPort1 Not Open");
                else
                    MessageBox.Show("<ERROR> LoadSerialPort1");
            }

        }

        private void LoadIFSP2(object sender, EventArgs e)
        {
            try
            {
                if (chkPortUse2.Checked)
                {
                    serialPort2 = new SerialPort();
                    serialPort2.PortName = cbbPortName2.Text.ToUpper().ToString();
                    serialPort2.BaudRate = int.Parse(cbbBaudRate2.Text);
                    serialPort2.DataBits = int.Parse(txtDataBit.Text);
                    serialPort2.Parity = Parity.None;
                    serialPort2.StopBits = StopBits.One;

                    serialPort2.Open();
                    //serialPort2.DataReceived += new SerialDataReceivedEventHandler(serialPort2_DataReceived);
                }
            }
            catch (Exception)
            {
                if (!serialPort2.IsOpen)
                    MessageBox.Show("<ERROR> SerialPort2 Not Open");
                else
                    MessageBox.Show("<ERROR> LoadSerialPort1"); ;
            }

        }

        private void LoadIFSP3(object sender, EventArgs e)
        {
            try
            {
                if (chkPortUse3.Checked)
                {
                    serialPort3 = new SerialPort();
                    serialPort3.PortName = cbbPortName3.Text.ToUpper().ToString();
                    serialPort3.BaudRate = int.Parse(cbbBaudRate3.Text);
                    serialPort3.DataBits = int.Parse(txtDataBit.Text);
                    serialPort3.Parity = Parity.None;
                    serialPort3.StopBits = StopBits.One;

                    serialPort3.Open();
                    serialPort3.DataReceived += new SerialDataReceivedEventHandler(serialPort3_DataReceived);
                }
            }
            catch (Exception)
            {
                if (!serialPort3.IsOpen)
                    MessageBox.Show("<ERROR> SerialPort3 Not Open");
                else
                    MessageBox.Show("<ERROR> LoadSerialPort1"); ;
            }

        }

        private void LoadIFSP4(object sender, EventArgs e)
        {
            try
            {
                if (chkPortUse4.Checked)
                {
                    serialPort4 = new SerialPort();
                    serialPort4.PortName = cbbPortName4.Text.ToUpper().ToString();
                    serialPort4.BaudRate = int.Parse(cbbBaudRate4.Text);
                    serialPort4.DataBits = int.Parse(txtDataBit.Text);
                    serialPort4.Parity = Parity.None;
                    serialPort4.StopBits = StopBits.One;

                    serialPort4.Open();
                    serialPort4.DataReceived += new SerialDataReceivedEventHandler(serialPort4_DataReceived);
                }
            }
            catch (Exception)
            {
                if (!serialPort4.IsOpen)
                    MessageBox.Show("<ERROR> SerialPort4 Not Open");
                else
                    MessageBox.Show("<ERROR> LoadSerialPort1"); ;
            }

        }
        private void serialPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(sportRCV3));
        }
        private void serialPort4_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(sportRCV4));
        }
        private void sportRCV1(object sender, EventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                txtRS1.Text = serialPort1.ReadExisting();

                AppendText(richTextBox1, "SerialPort1 Data :: " + txtRS1.Text);
                richTextBox1.Invoke((MethodInvoker)delegate ()
                {
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();
                });
            }


        }

        private void sportRCV2(object sender, EventArgs e)
        {
            if (serialPort2.BytesToRead > 0)
            {
                txtRS2.Text = serialPort2.ReadExisting();

                AppendText(richTextBox1, "SerialPort1 Data :: " + txtRS2.Text);
                richTextBox1.Invoke((MethodInvoker)delegate ()
                {
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();
                });
            }
        }

        private void sportRCV3(object sender, EventArgs e)
        {
            if (serialPort3.BytesToRead > 0)
            {
                txtRS3.Text = serialPort3.ReadExisting();

                AppendText(richTextBox1, "SerialPort1 Data :: " + txtRS3.Text);
                richTextBox1.Invoke((MethodInvoker)delegate ()
                {
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();
                });
            }
        }

        private void sportRCV4(object sender, EventArgs e)
        {
            if (serialPort4.BytesToRead > 0)
            {
                txtRS4.Text = serialPort4.ReadExisting();

                AppendText(richTextBox1, "SerialPort1 Data :: " + txtRS4.Text);
                richTextBox1.Invoke((MethodInvoker)delegate ()
                {
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();
                });
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadIFSP1(null, null);
            LoadIFSP2(null, null);
            LoadIFSP3(null, null);
            LoadIFSP4(null, null);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
                serialPort1.Open();

            if (!serialPort2.IsOpen)
                serialPort2.Open();

            serialPort1.WriteLine("READ?\r\n");
            this.Invoke(new EventHandler(sportRCV1));
            serialPort2.WriteLine("READ?\r\n");
            this.Invoke(new EventHandler(sportRCV2));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!serialPort3.IsOpen)
                serialPort3.Open();

            if (!serialPort4.IsOpen)
                serialPort4.Open();

            this.Invoke(new EventHandler(sportRCV3));
            this.Invoke(new EventHandler(sportRCV4));
        }
    }
}
