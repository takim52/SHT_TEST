using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TcpClient_TEST
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		public System.Windows.Forms.NotifyIcon notify;

		Socket connectedClient;

		DispatcherTimer timer = new DispatcherTimer();

		DispatcherTimer repeatDataTimer = new DispatcherTimer();

		string repeatData = string.Empty;
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

				string txtIP = txt_ip.Text;
				string txtPort = txt_port.Text;

				IPAddress ipAddress = IPAddress.Parse(txtIP);
				IPEndPoint remoteEP = new IPEndPoint(ipAddress, int.Parse(txtPort));

				AppConfiguration.SetAppConfig("DMR_ip", txtIP);
				AppConfiguration.SetAppConfig("DMR_port", txtPort);

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

				if (connectedClient.Connected)
				{
					timer.Start();
					Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
					{
						btn_Connect.Background = Brushes.Green;
						btnTEXT.Text = "Disconnect";
					}));
					writeMessage("[" + DateTime.Now.ToString() + "] " + client.RemoteEndPoint.ToString() + " Connected");
				}

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

					string writeText = "{받음}"+ "[" + DateTime.Now.ToString() + "] " + readText;

					writeMessage(writeText);

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
				writeMessage("Sent "+ bytesSent.ToString()+" bytes to server.");
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


		public MainWindow()
        {
            InitializeComponent();

			txt_ip.Text = AppConfiguration.GetAppConfig("DMR_ip");
			txt_port.Text = AppConfiguration.GetAppConfig("DMR_port");
			txt_sendData.Text = AppConfiguration.GetAppConfig("repeatData");
			txt_repeatTime.Text = AppConfiguration.GetAppConfig("repeatTime");

			timer.Interval = TimeSpan.FromMilliseconds(10);    //시간간격 설정

			timer.Tick += new EventHandler(timer_Tick);          //이벤트 추가

			repeatDataTimer.Tick += new EventHandler(repeatDataTimer_Tick);

		}

		private void btn_Connect_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				if (btnTEXT.Text.Equals("Disconnect"))
				{
					connectedClient.Disconnect(true);
					Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
					{
						btn_Connect.Background = Brushes.Red;
						btnTEXT.Text = "Connect";
					}));
					writeMessage("[" + DateTime.Now.ToString() + "] " + connectedClient.RemoteEndPoint.ToString() + " Disconnected");
					timer.Stop();
				}
				else
				{
					StartClient();
				}
			}
			catch (Exception ex)
			{
				LOG(ex.ToString());
				MessageBox.Show(ex.ToString());
			}

		}

		private void btn_repeatStart_Click(object sender, RoutedEventArgs e)
		{
			try
			{
                if (!connected)
                {
					MessageBox.Show("연결이 끊어져 있습니다. 소켓 연결부터 해주세요!");
					return;
                }

				double repeatTime_plat = 0;

                if (txt_sendData.Text.Length > 0)
                {
					AppConfiguration.SetAppConfig("repeatData", txt_sendData.Text);
                }
                else
                {
					MessageBox.Show("반복할 문자를 입력해주세요!");
					return;
                }

                if (txt_repeatTime.Text.Length > 0 && double.TryParse(txt_repeatTime.Text, out repeatTime_plat))
                {
					AppConfiguration.SetAppConfig("repeatTime", txt_repeatTime.Text);
				}else
                {
					MessageBox.Show("반복 시간을 지정되지 않았거나 숫자가 아닙니다!");
					return;
                }

				repeatData = txt_sendData.Text;

				repeatDataTimer.Interval = TimeSpan.FromMilliseconds(repeatTime_plat);


				btn_repeatStop.IsEnabled = true;
				btn_repeatStart.IsEnabled = false;
				txt_sendData.IsEnabled = false;
				txt_repeatTime.IsEnabled = false;

				repeatDataTimer.Start();


			}
			catch (Exception ex)
			{
				LOG(ex.ToString());
			}
		}

		private void btn_repeatStop_Click(object sender, RoutedEventArgs e)
		{
            try
            {
				repeatDataTimer.Stop();

				btn_repeatStop.IsEnabled = false;
				btn_repeatStart.IsEnabled = true;
				txt_sendData.IsEnabled = true;
				txt_repeatTime.IsEnabled = true;
			}
            catch (Exception ex)
            {
				LOG(ex.ToString());
			}
		}

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

		private void timer_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!SocketConnected(connectedClient))
				{
					connected = false;
					Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
					{
						btn_Connect.Background = Brushes.Red;
						btnTEXT.Text = "Connect";
					}));
					writeMessage("[" + DateTime.Now.ToString() + "] " + connectedClient.RemoteEndPoint.ToString() + " Disconnected");
					timer.Stop();
				}
			}
			catch (Exception ex)
			{
				LOG(ex.ToString());
			}

		}

		private void repeatDataTimer_Tick(object sender, EventArgs e)
		{
			try
			{
                if (connected)
                {
					writeMessage("{보냄}" + "[" + DateTime.Now.ToString() + "] " + repeatData);
					Send(connectedClient, repeatData);
				}else
                {
					writeMessage("소켓 연결이 끊어졌습니다!");
                }
			}
			catch (Exception ex)
			{
				LOG(ex.ToString());
			}

		}

		private void writeMessage(string msg)
		{
			try
			{
				Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
				{
					if (lbBox.Items.Count > 1000)
					{
						lbBox.Items.Clear();
					}
					string logText = "(" + (lbBox.Items.Count + 1) + ") " + msg;
					lbBox.Items.Insert(0, logText);
				}));

				LOG(msg);
			}
			catch (Exception ex)
			{
				LOG(ex.ToString());
			}
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			try
			{
				System.Windows.Forms.ContextMenu menu = new System.Windows.Forms.ContextMenu();
				// 아이콘 설정부분
				notify = new System.Windows.Forms.NotifyIcon();
				//notify.Icon = new System.Drawing.Icon(Application.Current @"TiimeAlram.ico");  // 외부아이콘 사용 시
				notify.Icon = Properties.Resources.sht_logo;   // Resources 아이콘 사용 시
																 //notify.Visible = true;
				notify.ContextMenu = menu;
				notify.Text = "DMR 확인용";

				// 아이콘 더블클릭 이벤트 설정
				notify.DoubleClick += Notify_DoubleClick;

				System.Windows.Forms.MenuItem item2 = new System.Windows.Forms.MenuItem();
				menu.MenuItems.Add(item2);
				item2.Index = 0;
				item2.Text = "프로그램 열기";
				item2.Click += delegate (object click, EventArgs eClick)
				{
					try
					{
						this.WindowState = WindowState.Normal;
						this.Visibility = Visibility.Visible;
						this.ShowInTaskbar = true;
						notify.Visible = false;
					}
					catch (Exception ex)
					{
						LOG(ex.ToString());
					}

				};

				System.Windows.Forms.MenuItem item3 = new System.Windows.Forms.MenuItem();
				menu.MenuItems.Add(item3);
				item3.Index = 1;
				item3.Text = "프로그램 종료";
				item3.Click += delegate (object click, EventArgs eClick)
				{
					try
					{
						this.Close();
					}
					catch (Exception ex)
					{
						LOG(ex.ToString());
					}

				};

				//this.Close();   // 시작시 창 닫음 (아이콘만 띄우기 위함)
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				LOG(ex.ToString());
			}
		}

		private void Notify_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				this.WindowState = WindowState.Normal;

				this.ShowInTaskbar = true;

				notify.Visible = false;
			}
			catch (Exception ex)
			{
				LOG(ex.ToString());
			}

		}

		private void Window_StateChanged(object sender, EventArgs e)
		{
			try
			{
				if (WindowState.Minimized == this.WindowState)
				{
					notify.Visible = true;
					this.ShowInTaskbar = false;
				}
			}
			catch (Exception ex)
			{
				LOG(ex.ToString());
			}

		}

		bool SocketConnected(Socket s)
		{
			bool part1 = s.Poll(1000, SelectMode.SelectRead);
			bool part2 = (s.Available == 0);
			if (part1 && part2)
				return false;
			else
				return true;
		}

		private void Mywindow_Closed(object sender, EventArgs e)
		{
			notify.Icon.Dispose();

			notify.Dispose();
		}

		private void btn_Cloaking_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				this.WindowState = WindowState.Minimized;
			}
			catch (Exception ex)
			{
				LOG(ex.ToString());
			}
		}

        private void btn_dataClear_Click(object sender, RoutedEventArgs e)
        {
			lbBox.Items.Clear();

		}
    }
}
