using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Terumo.Device
{
	public class RS232
	{
		public static SerialPort Port = new SerialPort();
		public RS232()
		{

		}

		public bool Connect(string portName, int baudRate, string parity, int dataBit, string stopBit)
		{
			Port.PortName = portName;
			Port.BaudRate = baudRate;
			Port.Parity = (Parity)Enum.Parse(typeof(Parity), parity);
			Port.DataBits = dataBit;
			Port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBit);

			try
			{
				Port.Open();
				if (Port.IsOpen)
				{
					Global.Common.LogDebug("Connected to PLC via " + portName);
					return true;
				}
				else
				{
					Global.Common.LogError("Not connected to PLC via " + portName);
					return false;
				}	
			}
			catch (Exception ex)
			{
				Global.Common.LogError("RS232: " + ex.Message);
				return false;
			}
		}
		public void Disconnect()
		{
			try
			{
				if (Port != null & Port.IsOpen)
				{
					Port.Close();
				}
			}
			catch (Exception ex)
			{
				Global.Common.LogError("RS232: " + ex.Message);
			}
		}
	}
}
