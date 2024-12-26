using Cutreson_PLC.McProtocol;
using Cutreson_Utility;
using System;
using System.Linq;
using System.Threading;

namespace _07_Kefico_LeakCurrentSystem.PLC
{
	public class clsControlPLC : clsBindable
	{
		McProtocolTcp client;
		private Thread _ThreadPLC;
		private readonly object _Lock = new object();

		public clsControlPLC()
		{
			Connect();
			_ThreadPLC = new Thread(DoWork);
			_ThreadPLC.IsBackground = true;
			_ThreadPLC.Start();
		}
		private void Connect()
		{
			try
			{
				client = new McProtocolTcp(MySetting.Setting.PlcIpAddress, MySetting.Setting.PlcPort, "BINARY", "QSerise");
				if (client.Open())
				{
					Global.Log.Debug("Connected to PLC");
				}
				else
				{
					Global.Log.Error("Can't connect to PLC");
				}
			}
			catch (Exception ex)
			{

			}
		}
		private bool _alive;
		public bool PlcAlive
		{
			get { return _alive; }
			set { Set(ref _alive, value); }
		}
		private void DoWork()
		{
			while (true)
			{
				try
				{
					if (client.IsConnect())
					{
						//Read bit
						bool[] bitArr = client.ReadBits(PlcDeviceType.M, 0, 300);
						//Alive
						PlcAlive = bitArr[0];
					}
					else
					{
						Connect();
						Thread.Sleep(2000);
					}
				}
				catch (Exception ex)
				{
					Global.Log.Error("clsControlPLC.cs" + ex.Message);
				}
				Thread.Sleep(1);
			}
		}
	}
}
