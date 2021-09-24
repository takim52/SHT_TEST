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
using Cognex.InSight;
using Cognex.InSight.Controls.Display;
using System.IO;
using System.Configuration;
using Cognex.InSight.Cell;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace INSIGHT_SDK_TEST
{
    public partial class frmCamView : Form
    {
        private CvsNetworkMonitor mMonitor;
        private CvsInSight mInSight;
        private Camconfigform _frmCamConfig;

        static string GET_TEXT = ConfigurationManager.AppSettings["GET_TEXT"];

        static Cognex.InSight.CvsCellLocation cl_GET_TEXT = new Cognex.InSight.CvsCellLocation(GET_TEXT);

        static string SET_TEXT = ConfigurationManager.AppSettings["SET_TEXT"];

        static Cognex.InSight.CvsCellLocation cl_SET_TEXT = new Cognex.InSight.CvsCellLocation(SET_TEXT);



        public frmCamView()
        {
            InitializeComponent();

            Init();

            _frmCamConfig = new Camconfigform();

            _frmCamConfig.DataSendEvent += new DataGetEventHandler(this.ConnectedCam);

			StartClient();

		}

        private void Init()
        {
            // Create a network monitor and connect to events of the display's InSight
            mMonitor = new CvsNetworkMonitor();
            mMonitor.PingInterval = 0;


            // Setup InSightDisplay and InSight object.
            // 인사이트 디스플레이를 mInsight에 넣어줍니다.
            mInSight = cvsInSightDisplay2.InSight;
            cvsInSightDisplay2.ShowGrid = true;
            cvsInSightDisplay2.ShowGraphics = true;
            cvsInSightDisplay2.ShowImage = true;
            cvsInSightDisplay2.ShowScrollBars = true;
            cvsInSightDisplay2.GridOpacity = 0.7;
            cvsInSightDisplay2.ImageScale = 1.0;
            cvsInSightDisplay2.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit;

            mMonitor.HostsChanged += new EventHandler(mMonitor_HostsChanged);
            mMonitor.Enabled = true;

            cvsInSightDisplay2.InSightChanged += new System.EventHandler(this.cvsInSightDisplay1_InSightChanged);

			//InSight.ResultsChanged += new EventHandler(senserChangedHandler);

        }
        private CvsInSight InSight
        {
            get { return mInSight; }
            set
            {
                mInSight = value;
            }
        }

        void senserChangedHandler(object sender, EventArgs e)
        {
            if (InSight.Results.HasNewlyAcquiredImage)
            {
				Send(connectedClient, "Vision PC Sended\r\n");
            }
        }

        void mMonitor_HostsChanged(object sender, EventArgs e)
        {

            string status = string.Empty;
            if (mMonitor.Hosts.Count > 0)
            {

                for (int i = 0; i < mMonitor.Hosts.Count; i++)
                {
                    if (mMonitor.Hosts[i].Name == this.Text)
                    {
                        cvsInSightDisplay2.Connect(mMonitor.Hosts[i].IPAddress.ToString(), "admin", "", false);

                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("센서가 없습니다.");
            }
        }

        private void cvsInSightDisplay1_InSightChanged(object sender, EventArgs e)
        {
            // 인사이트 커넥트를 하게 해줍니다.
            InSight = cvsInSightDisplay2.InSight;


            if (InSight != null)
            {
				InSight.ResultsChanged += new EventHandler(senserChangedHandler);
			}
		}

        private void ConnectedCam(DataGridView St1, CvsNetworkMonitor nMonitor)
        {

            string[] cCamName = new string[St1.Rows.Count];

            for (int i = 0; i < St1.Rows.Count - 1; i++)
            {
                cCamName[i] = St1.Rows[i].Cells[0].Value.ToString();
            }
        }

        
        public void IMG_SAVE()
        {
            DateTime today = DateTime.Now;

            try
            {
                mInSight.Results.Image.Save(Application.StartupPath + "\\IMG\\"
                               + today.Year + ".bmp");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public string GET_STRING()
        {
            CvsCell cell1 = mInSight.Results.Cells[GET_TEXT];

            return cell1.Text;
        }

        public void SET_STRING(string value)
        {
            mInSight.SetString(cl_SET_TEXT, value);
        }

        public void TRIGGER()
        {
            mInSight.ManualAcquire(true);
        }

		Socket connectedClient;

		public class StateObject
		{
			// Client socket.  
			public Socket workSocket = null;
			// Size of receive buffer.  
			public const int BufferSize = 256;
			// Receive buffer.  
			public byte[] buffer = new byte[BufferSize];
			// Received data string.  
			public StringBuilder sb = new StringBuilder();
		}
		// The port number for the remote device.  
		private int port = 11000;

		// ManualResetEvent instances signal completion.  
		private static ManualResetEvent connectDone =
			new ManualResetEvent(false);
		private static ManualResetEvent sendDone =
			new ManualResetEvent(false);
		private static ManualResetEvent receiveDone =
			new ManualResetEvent(false);
		// The response from the remote device.  
		private static String response = String.Empty;

		private void StartClient()
		{
			// Connect to a remote device.  
			try
			{
				// Establish the remote endpoint for the socket.  
				// The name of the
				// remote device is "host.contoso.com".  
				//IPHostEntry ipHostInfo = Dns.GetHostEntry("host.contoso.com");

				string txtIP = "127.0.0.1";
				string txtPort = "12486";

				IPAddress ipAddress = IPAddress.Parse(txtIP);
				IPEndPoint remoteEP = new IPEndPoint(ipAddress, int.Parse(txtPort));


				// Create a TCP/IP socket.  
				Socket client = new Socket(ipAddress.AddressFamily,
					SocketType.Stream, ProtocolType.Tcp);

				// Connect to the remote endpoint.  
				client.BeginConnect(remoteEP,
					new AsyncCallback(ConnectCallback), client);
				connected = true;
				//connectDone.WaitOne();

				// Send test data to the remote device.  
				//Send(client, "This is a test<EOF>");
				//sendDone.WaitOne();

				// Receive the response from the remote device.  
				//Receive(client);
				//receiveDone.WaitOne();

				// Write the response to the console.  
				//Console.WriteLine("Response received : {0}", response);

				// Release the socket.  
				//client.Shutdown(SocketShutdown.Both);
				//client.Close();

			}
			catch (Exception e)
			{
				//Console.WriteLine(e.ToString());
				MessageBox.Show(e.ToString());
				LOG(e.ToString());
			}
		}

		private void ConnectCallback(IAsyncResult ar)
		{
			try
			{
				connectedClient = (Socket)ar.AsyncState;

				// Retrieve the socket from the state object.  
				Socket client = (Socket)ar.AsyncState;


				// Complete the connection.  
				client.EndConnect(ar);

				Receive(client);

				//Console.WriteLine("Socket connected to {0}",
				//    client.RemoteEndPoint.ToString());

				// Signal that the connection has been made.  
				//connectDone.Set();
			}
			catch (Exception e)
			{
				//Console.WriteLine(e.ToString());
				MessageBox.Show(e.ToString());
				LOG(e.ToString());
			}
		}

		private void Receive(Socket client)
		{
			try
			{
				// Create the state object.  
				StateObject state = new StateObject();
				state.workSocket = client;

				// Begin receiving the data from the remote device.  
				client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
					new AsyncCallback(ReceiveCallback), state);
			}
			catch (Exception e)
			{
				//Console.WriteLine(e.ToString());
				MessageBox.Show(e.ToString());
				LOG(e.ToString());
			}
		}

		private void ReceiveCallback(IAsyncResult ar)
		{
			try
			{
				// Retrieve the state object and the client socket
				// from the asynchronous state object.  
				StateObject state = (StateObject)ar.AsyncState;
				Socket client = state.workSocket;

				// Read data from the remote device.  
				int bytesRead = client.EndReceive(ar);

				if (bytesRead > 0)
				{
					// There might be more data, so store the data received so far.  
					//state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));
					string readText = Encoding.Default.GetString(state.buffer, 0, bytesRead);

					string writeText = "{받음}" + "[" + DateTime.Now.ToString() + "] " + readText;


					// Get the rest of the data.  
					client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
						new AsyncCallback(ReceiveCallback), state);
				}
				//else
				//{
				//	// All the data has arrived; put it in response.  
				//	if (state.sb.Length > 1)
				//	{
				//		response = state.sb.ToString();
				//	}
				//	// Signal that all bytes have been received.  
				//	//receiveDone.Set();
				//}
			}
			catch (Exception e)
			{
				//Console.WriteLine(e.ToString());
				MessageBox.Show(e.ToString());
				LOG(e.ToString());
			}
		}

		private void Send(Socket client, String data)
		{
			// Convert the string data to byte data using ASCII encoding.  
			byte[] byteData = Encoding.ASCII.GetBytes(data);

			// Begin sending the data to the remote device.  
			client.BeginSend(byteData, 0, byteData.Length, 0,
				new AsyncCallback(SendCallback), client);
		}

		private void SendCallback(IAsyncResult ar)
		{
			try
			{
				// Retrieve the socket from the state object.  
				Socket client = (Socket)ar.AsyncState;

				// Complete sending the data to the remote device.  
				int bytesSent = client.EndSend(ar);
				//Console.WriteLine("Sent {0} bytes to server.", bytesSent);


				// Signal that all bytes have been sent.  
				//sendDone.Set();
			}
			catch (Exception e)
			{
				//Console.WriteLine(e.ToString());
				MessageBox.Show(e.ToString());
			}
		}

		bool connected = false;
		private void LOG(string msg)
		{
			try
			{
				string strCheckFolder = string.Empty;
				string strFileName = string.Empty;
				string strLocal = System.Environment.CurrentDirectory;

				strCheckFolder = strLocal + "\\LOG";
				if (!Directory.Exists(strCheckFolder))
				{
					Directory.CreateDirectory(strCheckFolder);
				}

				strFileName = strCheckFolder + "\\" + DateTime.Now.ToString("yy_MM_dd") + ".txt";
				StreamWriter FileWriter = new StreamWriter(strFileName, true);
				FileWriter.Write(msg + "\r\n");
				FileWriter.Flush();
				FileWriter.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
