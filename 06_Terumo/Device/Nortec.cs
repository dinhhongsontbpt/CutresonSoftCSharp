using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Terumo.Device
{
	public class Nortec
	{
		public static PanSerialPort m_MainPort;
		public static PanSerialPort MainPort
		{
			get
			{
				return m_MainPort;
			}
			set
			{
				m_MainPort = value;
			}
		}

		public static bool m_IsOnLine;
		public static bool IsOnLine
		{
			get
			{
				return m_IsOnLine;
			}
			set
			{
				m_IsOnLine = value;
			}
		}

		public static void DisplayError(string strError)
		{
			string messageBoxText = "Error: " + strError;
			MessageBox.Show(messageBoxText, "Error", MessageBoxButtons.OK);
		}

		public static void DisplayError(Exception theException)
		{
			string messageBoxText;
			if (theException.Message.Contains("The port is closed."))
			{
				messageBoxText = "ERROR: " + theException.Message + "\n\nPlease Unplug and Replug the USB to Connect the Gage.";
			}
			else if (theException.Message.Contains("The device is not connected."))
			{
				messageBoxText = "ERROR: " + theException.Message + "\n\nPlease Unplug and Replug the USB to Connect the Gage.";
			}
			else if (theException.Message.Contains("The write timed out."))
			{
				messageBoxText = "ERROR: " + theException.Message + "\n\nThe Device does not Reponse.  Please Restart the Gage.";
			}
			else if (theException.Message.Contains("The process cannot access the file"))
			{
				messageBoxText = "ERROR: " + theException.Message + "\n\nPlease close the File and try again.";
			}
			else
			{
				messageBoxText = "Error: ";
				messageBoxText += theException.Message;
				messageBoxText += "\n\nTargetSite: ";
				messageBoxText += theException.TargetSite;
				messageBoxText += "\n\nSource: ";
				messageBoxText += theException.Source;
				messageBoxText += "\n\nStackTrace: ";
				messageBoxText += theException.StackTrace;
			}
			MessageBox.Show(messageBoxText);
		}
		public static string GetPolarVirtualPortNumber()
		{
			string text = "";
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("select * from Win32_PnPEntity");
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				string text2 = item["PNPDeviceID"].ToString();
				if (text2.Contains("VID_1245&PID_0097"))
				{
					string text3 = item["Name"].ToString();
					int num = text3.IndexOf("(COM");
					if (num > 0)
					{
						text3 = text3.Substring(num + 1);
						int num2 = text3.IndexOf(")");
						text = text3.Substring(3, num2 - 3);
						break;
					}
				}
			}
			managementObjectSearcher.Dispose();
			if (text != "")
			{
				text = "COM" + text;
			}
			return text;
		}

		private static string m_strErrorMessage;
		public static string strErrorMessage
		{
			get
			{
				return m_strErrorMessage;
			}
			set
			{
				m_strErrorMessage = value;
			}
		}

		public static bool CheckOnLine()
		{
			string polarVirtualPortNumber = GetPolarVirtualPortNumber();
			if (polarVirtualPortNumber == "")
			{
				IsOnLine = false;
			}
			if (!IsOnLine)
			{
				Global.Common.LogDebug("Connect Nortec to PC via USB");
				IsOnLine = MainPort.SetupPort();
			}
			if (!IsOnLine)
			{
				Global.Common.LogError("Nortec is not Connected to PC via USB.");
			}
			else
			{
				Global.Common.LogDebug("Connected Nortec to PC via USB");
			}	
			return IsOnLine;
		}
	}
}
