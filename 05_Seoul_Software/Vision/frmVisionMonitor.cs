using Cutreson_Utility;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Seoul_Software
{
    public partial class frmVisionMonitor : Form
    {
        private TcpListener _listener;
        private readonly int _port;
        private readonly string _username;
        private readonly string _password;
        private readonly string _uploadDirectory;
        private IPAddress dataConnectionIP;
        private int dataConnectionPort;
        public frmVisionMonitor()
        {
            InitializeComponent();
            _port = MySetting.Setting.FtpPort;
            _username = MySetting.Setting.FtpUserName;
            _password = MySetting.Setting.FtpPassword;
            _uploadDirectory = MySetting.Setting.FtpFolderPath;

            if (!Directory.Exists(_uploadDirectory))
            {
                Directory.CreateDirectory(_uploadDirectory);
            }

            Start();

			Global.PLC.PropertyChanged += PLC_PropertyChanged;
			UpdateData();
		}

		private void PLC_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
            if (e.PropertyName == "VisionComplete")
            {
                UpdateData();
			}
		}
        private void UpdateData()
        {
			int[] data = Global.PLC.ReadVisionData();
			if (data != null && data.Length >= 6)
			{
				if (data[1] == 1)
				{
					clsInvokeControl.ControlTextInvoke(btnResult, "OK");
					clsInvokeControl.ControlBackColorInvoke(btnResult, Color.Lime);
				}
				if (data[2] == 1)
				{
					clsInvokeControl.ControlTextInvoke(btnResult, "NG");
					clsInvokeControl.ControlBackColorInvoke(btnResult, Color.Red);
				}
				clsInvokeControl.ControlTextInvoke(lbTotal, $"Total: {data[3].ToString()}");
				clsInvokeControl.ControlTextInvoke(lbOK, $"OK: {data[4].ToString()}");
				clsInvokeControl.ControlTextInvoke(lbNG, $"NG: {data[5].ToString()}");
			}
		}
		public void Start()
        {
            try
            {
				_listener = new TcpListener(IPAddress.Any, _port);
				_listener.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
				_listener.Start();
				Console.WriteLine($"FTP server started on port {_port}...");

				Task.Run(() => ListenForClients());
			}
            catch(Exception ex)
            {
                Global.Log.Error($"Ftp server: " + ex.Message);
            }
        }

        private async Task ListenForClients()
        {
            while (true)
            {
                TcpClient client = await _listener.AcceptTcpClientAsync();
                Console.WriteLine("Client connected.");
                _ = HandleClient(client);  // Không chờ, để tiếp tục chấp nhận kết nối mới
            }
        }
        private async Task HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            StreamWriter writer = new StreamWriter(stream, Encoding.ASCII) { AutoFlush = true };
            StreamReader reader = new StreamReader(stream, Encoding.ASCII);

            await writer.WriteLineAsync("220 Simple FTP Server");

            string user = null;
            string pass = null;
            bool isAuthenticated = false;

            while (client.Connected)
            {
                string request = await reader.ReadLineAsync();
                if (request == null) break;

                Console.WriteLine($"Request: {request}");

                if (request.StartsWith("USER"))
                {
                    user = request.Split(' ')[1];
                    await writer.WriteLineAsync("331 Username OK, need password.");
                }
                else if (request.StartsWith("PASS"))
                {
                    pass = request.Split(' ')[1];
                    if (user == _username && pass == _password)
                    {
                        await writer.WriteLineAsync("230 User logged in.");
                        isAuthenticated = true;
                    }
                    else
                    {
                        await writer.WriteLineAsync("530 Login incorrect.");
                        client.Close();
                        return;
                    }
                }
                else if (request.StartsWith("TYPE I"))
                {
                    await writer.WriteLineAsync("200 Command OK.");
                }
                else if (request.StartsWith("PORT"))
                {
                    string[] parts = request.Split(' ')[1].Split(',');
                    dataConnectionIP = IPAddress.Parse($"{parts[0]}.{parts[1]}.{parts[2]}.{parts[3]}");
                    dataConnectionPort = int.Parse(parts[4]) * 256 + int.Parse(parts[5]);

                    await writer.WriteLineAsync("200 PORT command successful.");
                }
                else if (isAuthenticated && request.StartsWith("STOR"))
                {
                    string fileName = request.Split(' ')[1];
                    string filePath = Path.Combine(_uploadDirectory, fileName);

                    await writer.WriteLineAsync("150 Ready to receive file.");

                    TcpClient dataClient = new TcpClient();
                    await dataClient.ConnectAsync(dataConnectionIP, dataConnectionPort);
                    NetworkStream dataStream = dataClient.GetStream();

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        await dataStream.CopyToAsync(memoryStream);

                        if (MySetting.Setting.IsSaveImageLog)
                        {
                            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                            {
                                memoryStream.Seek(0, SeekOrigin.Begin);
                                await memoryStream.CopyToAsync(fileStream);
                            }
                            await writer.WriteLineAsync("226 Transfer complete.");
                            Console.WriteLine($"File {fileName} saved.");
                        }

                        Image receivedImage = Image.FromStream(memoryStream);
                        ViewImage(receivedImage);
                        await writer.WriteLineAsync("226 Transfer complete (Image displayed).");
                        Console.WriteLine($"File {fileName} received and displayed.");
                    }

                    dataClient.Close();
                    break;
                }
                else if (request.StartsWith("QUIT"))
                {
                    await writer.WriteLineAsync("221 Goodbye.");
                    break;
                }
                else
                {
                    await writer.WriteLineAsync("502 Command not implemented.");
                }
            }

            client.Close();
            Console.WriteLine("Client disconnected.");
        }

        private void ViewImage(Image image)
        {
            if (imageBox.Image != null) imageBox.Image.Dispose();
            imageBox.Image = image;
        }
    }
}
