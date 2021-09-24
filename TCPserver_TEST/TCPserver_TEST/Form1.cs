using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace TCPserver_TEST
{
    public partial class Form1 : Form
    {
        Socket tcpServer;

        private List<Socket> connectedClients = new List<Socket>();

        int bufferSize = 9012;

        bool serverIsRunning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_serverStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serverIsRunning)
                {
                    serverIsRunning = true;
                    int port;
                    if (!int.TryParse(nup_port.Value.ToString(), out port))
                    {
                        MsgBoxHelper.Error("포트 번호가 잘못 입력되었거나 입력되지 않았습니다.");
                        return;
                    }
                    tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    // 서버에서 클라이언트의 연결 요청을 대기하기 위해
                    // 소켓을 열어둔다.
                    IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse(ipList.SelectedItem.ToString()), port);

                    tcpServer.Bind(serverEP);
                    tcpServer.Listen(10);

                    // 비동기적으로 클라이언트의 연결 요청을 받는다.
                    tcpServer.BeginAccept(AcceptCallback, null);

                    writeUILog("server open!");
                    Log("서버를 오픈했습니다~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                    ipList.Enabled = false;
                    nup_port.Enabled = false;

                    btn_serverStart.Text = "Stop";
                    btn_serverState.BackColor = Color.Green;
                }else
                {
                    serverIsRunning = false;

                    ipList.Enabled = true;
                    nup_port.Enabled = true;

                    updateIPList();

                    ipList.SelectedIndex = 0;

                    btn_serverStart.Text = "Start";
                    btn_serverState.BackColor = Color.Red;

                    writeUILog("server close!");
                    Log("서버를 닫았습니다~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                }
                
            }
            catch (Exception ex)
            {
                Log("서버 오픈 문제 발생 : " + ex.ToString());
            }
        }


        private void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                // 클라이언트의 연결 요청을 수락한다.
                Socket client = tcpServer.EndAccept(ar);

                // 또 다른 클라이언트의 연결을 대기한다.
                tcpServer.BeginAccept(AcceptCallback, null);

                AsyncObject obj = new AsyncObject(bufferSize);
                obj.WorkingSocket = client;

                // 연결된 클라이언트 리스트에 추가해준다.
                connectedClients.Add(client);

                writeUILog(string.Format("클라이언트 (@ {0})가 연결되었습니다.", client.RemoteEndPoint));

                // 클라이언트의 데이터를 받는다.
                client.BeginReceive(obj.Buffer, 0, bufferSize , 0, DataReceived, obj);
            }
            catch (Exception ex)
            {
                MsgBoxHelper.Error("DMR과 우리서버가 연결되어 있지 않아 에러가 발생했습니다.");
                Log("서버와 연결되어 있지 않아 에러가 발생했습니다." + ex.ToString());
            }

        }

        private void DataReceived(IAsyncResult ar)
        {
            // BeginReceive에서 추가적으로 넘어온 데이터를 AsyncObject 형식으로 변환한다.
            AsyncObject obj = (AsyncObject)ar.AsyncState;
            try
            {
                // 데이터 수신을 끝낸다.
                int received = obj.WorkingSocket.EndReceive(ar);

                // 받은 데이터가 없으면(연결끊어짐) 끝낸다.  -1일 경우 비정상 종료된것으로 확인 된다.
                // 일반적으로 TCP 서버측에서 received 데이터를 가지고 확인을 하여 어떤 에러인지 확인을 한다.
                if (received <= 0)
                {
                    writeUILog("연결이 끊겼습니다 :: " + obj.WorkingSocket.RemoteEndPoint + "\r\n에러 확인 :" + received);
                    connectedClients.Remove(obj.WorkingSocket);
                    Log("연결이 끊겼습니다 :: " + obj.WorkingSocket.RemoteEndPoint + "\r\n에러 확인 :" + received);
                    return;
                }

                //byte[] b_text = Prune(obj.Buffer);
                // 텍스트로 변환한다.
                string text = Encoding.Default.GetString(Prune(obj.Buffer));

                writeUILog(obj.WorkingSocket.RemoteEndPoint + "에서[" + text + "] 전송받음");
                Log(obj.WorkingSocket.RemoteEndPoint + "에서[" + text + "] 전송받음");

                // 데이터를 받은 후엔 다시 버퍼를 비워주고 같은 방법으로 수신을 대기한다.
                obj.ClearBuffer();

                // 수신 대기
                obj.WorkingSocket.BeginReceive(obj.Buffer, 0, bufferSize, 0, DataReceived, obj);

            }
            catch (Exception ex)
            {
                Log("!!에러발생!!" + ex.ToString());
            }

        }

        private void btn_DataSend_Click(object sender, EventArgs e)
        {
            try
            {
                string sendText = string.Empty;
                txt_sendtxt.Invoke(new MethodInvoker(delegate ()
                {
                    sendText = txt_sendtxt.Text;
                }));
                byte[] byteDatas = Encoding.ASCII.GetBytes(txt_sendtxt.Text);

                for (int i = 0; i < connectedClients.Count; i++)
                {
                    connectedClients[i].Send(Prune(byteDatas));
                    writeUILog(connectedClients[i].RemoteEndPoint + "으로[" + sendText + "] 전송완료");
                    Log(connectedClients[i].RemoteEndPoint + "으로[" + sendText + "] 전송완료");
                }
            }
            catch (Exception ex)
            {
                Log("[DataSend에러]" + ex.ToString());
            }
        }

        private void writeUILog(string msg)
        {
            if (listbox_UI_LOG.InvokeRequired)
            {
                listbox_UI_LOG.Invoke(new MethodInvoker(delegate ()
                {
                    listbox_UI_LOG.Items.Insert(0, DateTime.Now.ToString("[hh:mm:ss.fff]") + msg);
                }));
            }
            else
            {
                listbox_UI_LOG.Items.Insert(0, DateTime.Now.ToString("[hh:mm:ss.fff]") + msg);
            }
        }
        private void Log(String msg)
        {
            DateTime today = DateTime.Now;

            string dir_LOG = Directory.GetCurrentDirectory() + @"\Logs";
            string dir_y = dir_LOG + @"\" + today.Year;
            string dir_m = dir_y + @"\" + today.Month;

            string FilePath = dir_m + @"\" + DateTime.Today.ToString("yyyy_MM_dd") + ".log";

            DirectoryInfo di = new DirectoryInfo(dir_LOG);

            DirectoryInfo di_y = new DirectoryInfo(dir_y);

            DirectoryInfo di_m = new DirectoryInfo(dir_m);

            try
            {
                if (di.Exists != true) Directory.CreateDirectory(dir_LOG);
                if (di_y.Exists != true) Directory.CreateDirectory(dir_y);
                if (di_m.Exists != true) Directory.CreateDirectory(dir_m);


                using (StreamWriter sw = File.AppendText(FilePath))
                {
                    sw.WriteLine(DateTime.Now.ToString("[yyyy/MM/dd_hh:mm:ss.fff]" + msg));
                    sw.Close();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Log가 쓰여지지 않았습니다." + ex.ToString());
            }

        }

        // null 데이터 없애는 작업
        // byte 내에 null일 경우 줄여서 보내는 작업을 한다.
        public byte[] Prune(Byte[] bytes)
        {
            if (bytes.Length == 0) return bytes;

            var i = bytes.Length - 1;
            while (bytes[i] == 0)
            {
                i--;
            }
            Byte[] copy = new Byte[i + 1];
            Array.Copy(bytes, copy, i + 1);
            return copy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateIPList();
            ipList.SelectedIndex = 0;
        }

        private void updateIPList()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] ipAddress = ipHostInfo.AddressList;

            ipList.Items.Clear();

            ipList.Items.Add("127.0.0.1");

            for (int i = 0; i < ipAddress.Length; i++)
            {
                ipList.Items.Add(ipAddress[i].ToString());
            }
        }
    }
}
