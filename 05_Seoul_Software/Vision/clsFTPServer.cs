using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Seoul_Software
{
    public class clsFTPServer
    {
        private TcpListener _listener;
        private readonly int _port;
        private readonly string _username;
        private readonly string _password;
        private readonly string _uploadDirectory;
        private IPAddress dataConnectionIP;
        private int dataConnectionPort;

        public clsFTPServer(int port, string username, string password, string uploadDirectory)
        {
            _port = port;
            _username = username;
            _password = password;
            _uploadDirectory = uploadDirectory;

            if (!Directory.Exists(uploadDirectory))
            {
                Directory.CreateDirectory(uploadDirectory);
            }
        }

        public void Start()
        {
            _listener = new TcpListener(IPAddress.Any, _port);
            _listener.Start();
            Console.WriteLine($"FTP server started on port {_port}...");

            Task.Run(() => ListenForClients());
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
                if (request == null) break;  // Nếu không có yêu cầu nào từ client, thoát ra

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
                    // Chấp nhận lệnh TYPE I để chuyển sang chế độ truyền nhị phân
                    await writer.WriteLineAsync("200 Command OK.");
                }
                else if (request.StartsWith("PORT"))
                {
                    // Xử lý lệnh PORT để lấy địa chỉ IP và cổng dữ liệu
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

                    // Tạo kết nối dữ liệu mới đến cổng và IP client yêu cầu
                    TcpClient dataClient = new TcpClient();
                    await dataClient.ConnectAsync(dataConnectionIP, dataConnectionPort);
                    NetworkStream dataStream = dataClient.GetStream();

                    // Đọc dữ liệu file từ stream và lưu vào filePath
                    using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        await dataStream.CopyToAsync(fileStream);
                    }

                    await writer.WriteLineAsync("226 Transfer complete.");
                    Console.WriteLine($"File {fileName} received.");

                    // Đóng kết nối dữ liệu
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

            // Đóng kết nối chính sau khi xử lý xong
            client.Close();
            Console.WriteLine("Client disconnected.");
        }
    }
}
