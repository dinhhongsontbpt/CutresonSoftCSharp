using System;
using System.Net.Sockets;
using System.Text;

namespace Seoul_Software.Printer
{
	public class clsTcpClient
	{
		private TcpClient client;
		private NetworkStream stream;
		private string serverIp;
		private int port;
		public clsTcpClient(string ip, int port)
		{
			this.serverIp = ip;
			this.port = port;
		}
		public bool Open()
		{
			try
			{
				client = new TcpClient(serverIp, port);
				stream = client.GetStream();
				return true;
			}
			catch (Exception e)
			{
				Global.Log.Error("Can't connect to printer: " + e.Message, Log.eLogLevel.FATAL);
				return false;
			}
		}
		public bool Close()
		{
			try
			{
				if (stream != null)
					stream.Close();

				if (client != null)
					client.Close();

				return true;
			}
			catch (Exception e)
			{
				Global.Log.Error("Can't disconnect printer: " + e.Message, Log.eLogLevel.FATAL);
				return false;
			}
		}
		public bool Send(string message)
		{
			try
			{
				if (stream == null || !client.Connected)
				{
					Global.Log.Error("Please connect to printer");
					return false;
				}

				byte[] data = Encoding.UTF8.GetBytes(message);
				stream.Write(data, 0, data.Length);
				return true;
			}
			catch (Exception e)
			{
				Global.Log.Error("Send data to printer error: " + e.Message, Log.eLogLevel.FATAL);
				return false;
			}
		}
		public bool SendMessage(string message)
		{
			if (Open())
			{
				bool result = Send(message);
				Close();
				return result;
			}
			return false;
		}
	}
}
