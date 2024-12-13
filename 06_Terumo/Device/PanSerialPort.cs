using _06_Terumo.Device;
using System;
using System.Collections;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace _06_Terumo
{
	public class PanSerialPort
	{
		public delegate void DataChangedHandler(string strValue);

		private string CH2 = "\u0002";

		private string CH3 = "\u0003";

		private string CRLF = "\r\n";

		private SerialPort m_serialPort;

		private string m_strResponse;

		private byte m_byteResponse;

		public int m_iType;

		public Queue m_Queue;

		private StringBuilder m_strData;

		private int m_iNumByteRead;

		public byte[] m_inputData;

		private byte[] m_ResponseData;

		private bool m_bSetDataRec;

		private int m_iNumTry;

		private string m_strAllData = "";

		private bool m_bExportRecOK;

		private string m_strExportErrorLine = "";

		private int m_iCurExportLine;

		public SerialPort serialPort
		{
			get
			{
				return m_serialPort;
			}
			set
			{
				m_serialPort = value;
			}
		}

		public bool bExportRecOK
		{
			get
			{
				return m_bExportRecOK;
			}
			set
			{
				m_bExportRecOK = value;
			}
		}

		public int iCurExportLine
		{
			get
			{
				return m_iCurExportLine;
			}
			set
			{
				m_iCurExportLine = value;
			}
		}

		public int ComType
		{
			set
			{
				m_iType = value;
			}
		}

		public bool InitPort(string strPortName, int iBaudRate, Parity mParity, int iDataBit, StopBits mStopBit)
		{
			try
			{
				m_serialPort = new SerialPort(strPortName, iBaudRate, mParity, iDataBit, mStopBit);
				m_serialPort.ReadTimeout = 1500;
				m_serialPort.WriteTimeout = 1500;
				m_serialPort.DtrEnable = true;
				m_serialPort.RtsEnable = false;
				m_Queue = new Queue();
				m_strData = new StringBuilder();
				m_inputData = new byte[500000];
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
			return true;
		}

		public void CheckPortNum(string strPortName)
		{
			if (m_serialPort.PortName != strPortName)
			{
				m_serialPort.PortName = strPortName;
			}
		}

		public bool SetupPort()
		{
			int num = 5;
			int i = 0;
			bool flag = false;
			for (; i < num; i++)
			{
				if (flag)
				{
					break;
				}
				Thread.Sleep(100);
				string polarVirtualPortNumber = Nortec.GetPolarVirtualPortNumber();
				if (polarVirtualPortNumber != "" && InitPort(polarVirtualPortNumber, 38400, Parity.None, 8, StopBits.One))
				{
					flag = true;
				}
			}
			Nortec.IsOnLine = flag;
			return flag;
		}

		public void GetAndCheckPortNum()
		{
			int num = 5;
			int i = 0;
			bool flag = false;
			for (; i < num; i++)
			{
				if (flag)
				{
					break;
				}
				Thread.Sleep(100);
				string polarVirtualPortNumber = Nortec.GetPolarVirtualPortNumber();
				if (polarVirtualPortNumber != "")
				{
					CheckPortNum(polarVirtualPortNumber);
					break;
				}
			}
		}

		public bool OpenPort(bool bSetDataRec)
		{
			try
			{
				if (m_serialPort == null)
				{
					return false;
				}
				GetAndCheckPortNum();
				if (!m_serialPort.IsOpen)
				{
					m_serialPort.Open();
				}
				m_bSetDataRec = bSetDataRec;
				if (bSetDataRec)
				{
					m_serialPort.DataReceived += SerialPortDataReceived;
				}
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}

		public bool ClosePort()
		{
			try
			{
				if (m_serialPort != null && m_serialPort.IsOpen)
				{
					m_serialPort.ReadExisting();
					m_Queue.Clear();
					m_serialPort.Close();
					m_serialPort.Dispose();
					if (m_bSetDataRec)
					{
						m_serialPort.DataReceived -= SerialPortDataReceived;
					}
				}
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}

		public void SetDataRevMode(bool bSetDataRec)
		{
			if (m_bSetDataRec != bSetDataRec)
			{
				m_bSetDataRec = bSetDataRec;
				if (bSetDataRec)
				{
					m_serialPort.DataReceived += SerialPortDataReceived;
				}
				else
				{
					m_serialPort.DataReceived -= SerialPortDataReceived;
				}
			}
		}

		private long CalcPacketChkSum(string str)
		{
			long num = 0L;
			char[] array = str.ToCharArray();
			if (array.Length < 40)
			{
				return -1L;
			}
			for (int i = 0; i < 40; i++)
			{
				num += array[i];
			}
			return num;
		}

		public bool JustSendCommand(string strCommand)
		{
			if (!Nortec.MainPort.OpenPort(bSetDataRec: false))
			{
				MessageBox.Show("ERROR: Cannot Connect to Device");
				return false;
			}
			bool result = true;
			ClearBuffer();
			try
			{
				m_serialPort.DiscardOutBuffer();
				m_serialPort.DiscardInBuffer();
				m_strResponse = "";
				m_serialPort.Write(strCommand);
				return result;
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
		}

		public bool SendCommand1(string strCommand)
		{
			if (!Nortec.MainPort.OpenPort(bSetDataRec: false))
			{
				MessageBox.Show("ERROR: Cannot Connect to Device");
				return false;
			}
			bool result = true;
			try
			{
				m_strResponse = "";
				m_serialPort.Write(strCommand);
				bool flag = false;
				int num = 0;
				string text = "";
				m_strResponse = "";
				do
				{
					Thread.Sleep(200);
					text = m_serialPort.ReadExisting();
					if (text.Contains("OK"))
					{
						flag = true;
						result = true;
					}
					else if (text.Contains("ER"))
					{
						flag = true;
						result = false;
					}
					else
					{
						num++;
					}
					m_strResponse += text;
				}
				while (!flag && num < 10);
				m_serialPort.DiscardInBuffer();
				return result;
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
		}

		public bool SendCommand(string strCommand)
		{
			bool flag = false;
			try
			{
				TimeSpan timeSpan = new TimeSpan(DateTime.Now.Ticks);
				m_serialPort.DiscardOutBuffer();
				m_serialPort.DiscardInBuffer();
				m_strResponse = "";
				m_serialPort.Write(strCommand);
				Thread.Sleep(30);
				bool flag2 = false;
				string text = "";
				int num = 0;
				int num2 = 0;
				do
				{
					num = m_serialPort.BytesToRead;
					if (num > 0)
					{
						num2 = 0;
						m_serialPort.Read(m_inputData, 0, num);
						text = Encoding.UTF8.GetString(m_inputData, 0, num);
						if (text.Contains("OK"))
						{
							flag2 = true;
							flag = false;
						}
						else if (text.Contains("ER"))
						{
							flag2 = true;
							flag = true;
							m_strResponse = text;
						}
						m_strResponse += text;
					}
					else
					{
						num2++;
						if (num2 > 300)
						{
							flag2 = true;
							flag = true;
						}
						else
						{
							Thread.Sleep(30);
						}
					}
				}
				while (!flag2);
				TimeSpan timeSpan2 = new TimeSpan(DateTime.Now.Ticks);
				TimeSpan timeSpan3 = timeSpan2 - timeSpan;
				_ = "Time: " + timeSpan3.Minutes + " Min " + timeSpan3.TotalSeconds + " secs " + timeSpan3.Milliseconds + " mSecs";
				m_serialPort.DiscardInBuffer();
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
			return !flag;
		}

		public bool SendScreenCapture()
		{
			try
			{
				m_serialPort.DiscardOutBuffer();
				m_serialPort.DiscardInBuffer();
				string text = "PRINTSCREEN=BMP\r\n";
				m_serialPort.Write(text);
				Thread.Sleep(3000);
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
			return true;
		}

		public bool SendWaveFormBitmapRequest()
		{
			try
			{
				string text = "PRINTSCREEN=BMP\r\n";
				m_serialPort.Write(text);
				Thread.Sleep(3000);
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
			return true;
		}

		public string GetDirListRequest()
		{
			TimeSpan timeSpan = new TimeSpan(DateTime.Now.Ticks);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			string text = "";
			ClearBuffer();
			try
			{
				m_serialPort.DiscardOutBuffer();
				m_serialPort.DiscardInBuffer();
				m_serialPort.Write("FILEDIR?\r\n");
				Thread.Sleep(50);
				string text2 = "";
				m_strResponse = "";
				bool flag = false;
				bool flag2 = false;
				do
				{
					num2 = m_serialPort.BytesToRead;
					if (num2 > 0)
					{
						m_serialPort.Read(m_inputData, 0, num2);
						num += num2;
						num3 = 0;
						text2 = Encoding.UTF8.GetString(m_inputData, 0, num2);
						text += text2;
						int num4 = text.IndexOf("OK\r");
						int num5 = text.IndexOf("ER\r");
						if (num4 > -1 || num5 > -1)
						{
							flag2 = true;
							flag = num5 > -1;
						}
					}
					else
					{
						num3++;
						if (num3 > 20)
						{
							flag2 = true;
							flag = true;
						}
					}
					Thread.Sleep(30);
				}
				while (!flag2);
				if (flag)
				{
					Nortec.DisplayError("Invalid Data send over from the Device.  Please try again.");
					text = "";
				}
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				text = "";
			}
			ClearBuffer();
			TimeSpan timeSpan2 = new TimeSpan(DateTime.Now.Ticks);
			TimeSpan timeSpan3 = timeSpan2 - timeSpan;
			_ = "Bytes: " + num + " / Time: " + timeSpan3.TotalSeconds + " secs";
			return text;
		}

		private void ClearBuffer()
		{
			int bytesToRead = m_serialPort.BytesToRead;
			do
			{
				m_serialPort.Read(m_inputData, 0, bytesToRead);
				bytesToRead = m_serialPort.BytesToRead;
			}
			while (bytesToRead > 0);
			m_serialPort.DiscardOutBuffer();
		}

		[Obsolete]
		public string GetDirListRequest_Old()
		{
			string text = "";
			try
			{
				int iNumOfFiles = 0;
				if (!GetNumOfFilesOnGage(ref iNumOfFiles) && !Nortec.MainPort.RetryGetNumOfFilesOnGage(ref iNumOfFiles))
				{
					Nortec.DisplayError("Cannot get the number of Files from the Gage");
					return "";
				}
				if (iNumOfFiles == 0)
				{
					MessageBox.Show("No File on the Device.");
					return "";
				}
				m_serialPort.DiscardOutBuffer();
				m_serialPort.DiscardInBuffer();
				m_serialPort.Write("FILEDIR?\r\n");
				bool flag = false;
				int num = 0;
				string text2 = "";
				m_strResponse = "";
				int num2 = 0;
				int num3 = 0;
				if (iNumOfFiles < 2)
				{
					num3 = 100;
				}
				int num4 = 0;
				num4 = ((iNumOfFiles >= 300) ? (iNumOfFiles * 80 + num3) : (iNumOfFiles * 60 + num3));
				bool flag2 = true;
				do
				{
					Thread.Sleep(num4);
					text2 = m_serialPort.ReadExisting();
					if (flag2)
					{
						int num5 = text2.IndexOf("SOBDIR");
						if (num5 == -1)
						{
							Thread.Sleep(num4);
							text2 = m_serialPort.ReadExisting();
							num5 = text2.IndexOf("SOBDIR");
							if (num5 == -1)
							{
								Nortec.DisplayError("Invalid Data send over from the Device.  Please try again.");
								return "";
							}
						}
						text2 = text2.Substring(num5, text2.Length - num5);
						flag2 = false;
					}
					if (text2.Contains("OK") || text2.Contains("ER"))
					{
						flag = true;
					}
					else
					{
						num++;
					}
					text += text2;
					num2 += num4;
				}
				while (!flag && num < 20);
				m_serialPort.DiscardInBuffer();
				m_serialPort.DiscardOutBuffer();
				return text;
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				m_serialPort.DiscardInBuffer();
				m_serialPort.DiscardOutBuffer();
				return "";
			}
		}

		public string ReadPortResponse()
		{
			if (m_strResponse == "")
			{
				int num = 0;
				num = m_serialPort.BytesToRead;
				if (num > 0)
				{
					m_serialPort.Read(m_inputData, 0, num);
					m_strResponse = Encoding.UTF8.GetString(m_inputData, 0, num);
				}
			}
			return m_strResponse;
		}

		public string GetPortResponse()
		{
			return m_strResponse;
		}

		public byte GetBytePortResponse()
		{
			return m_byteResponse;
		}

		public void ClearQueue()
		{
			m_Queue.Clear();
		}

		public bool RetryGetNumOfFilesOnGage(ref int iNumOfFiles)
		{
			ClosePort();
			OpenPort(m_bSetDataRec);
			return GetNumOfFilesOnGage(ref iNumOfFiles);
		}

		public bool GetNumOfFilesOnGage(ref int iNumOfFiles)
		{
			string text = "LDN?";
			text += "\r\n";
			string text2 = "";
			iNumOfFiles = 0;
			bool flag = false;
			bool flag2 = false;
			try
			{
				if (SendCommand1(text))
				{
					int num = 0;
					Thread.Sleep(1400);
					while (!flag && num < 15 && !flag2)
					{
						text2 = ReadPortResponse();
						if (text2.Contains("OK"))
						{
							text2 = text2.Replace("\r\n", "");
							text2 = text2.Replace("OK", "");
							if (text2.Length != 0)
							{
								//iNumOfFiles = PanHelper.ConvertToInt(text2);
								flag = true;
								break;
							}
						}
						else if (text2.Contains("ER"))
						{
							iNumOfFiles = 0;
							flag2 = true;
						}
						else
						{
							if (text2.Length != 0)
							{
								//iNumOfFiles = PanHelper.ConvertToInt(text2);
								flag = true;
								break;
							}
							Thread.Sleep(1000);
							num++;
						}
					}
				}
				m_serialPort.DiscardOutBuffer();
				m_serialPort.DiscardInBuffer();
				if (!flag || flag2)
				{
					return false;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool GetNumOfRestoreFiles(ref int iNumOfFiles)
		{
			string text = "DLRC?";
			text += "\r\n";
			string text2 = "";
			iNumOfFiles = 0;
			bool flag = false;
			bool flag2 = false;
			try
			{
				if (SendCommand(text))
				{
					int num = 0;
					Thread.Sleep(500);
					while (!flag && num < 5 && !flag2)
					{
						text2 = ReadPortResponse();
						if (text2.Contains("OK"))
						{
							text2 = text2.Replace("\r\n", "");
							text2 = text2.Replace("OK", "");
							if (text2.Length != 0)
							{
								//iNumOfFiles = PanHelper.ConvertToInt(text2);
								flag = true;
							}
						}
						else if (text2.Contains("ER"))
						{
							iNumOfFiles = 0;
							flag2 = true;
						}
						else
						{
							Thread.Sleep(200);
							num++;
						}
					}
				}
				m_serialPort.DiscardOutBuffer();
				m_serialPort.DiscardInBuffer();
				if (flag2 || !flag)
				{
					return false;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool DeleteFile(string strFileName)
		{
			bool result = true;
			try
			{
				long num = 0L;
				string text = "";
				string text2 = "FILEDELETE";
				text = text2 + CH2 + CRLF;
				text2 = "SOBFDELETE".PadRight(40);
				num += CalcPacketChkSum(text2);
				text = text + text2 + CRLF;
				text2 = "FNA" + strFileName;
				text2 = text2.PadRight(40);
				num += CalcPacketChkSum(text2);
				text = text + text2 + CRLF;
				text2 = "EOB" + (num & 0x1FFF).ToString("0000");
				text2 = text2.PadRight(40);
				text += text2;
				text = text + CRLF + CH3 + CRLF;
				m_serialPort.Write(text);
				Thread.Sleep(300);
				string text3 = "";
				text3 = m_serialPort.ReadExisting();
				if (!text3.Contains("OK"))
				{
					return false;
				}
				return result;
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
		}

		public ArrayList GetFTPLineList(string strInput)
		{
			ArrayList arrayList = new ArrayList();
			string[] separator = new string[1] { "\r\n" };
			string[] array = strInput.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != "OK" && array[i] != "\u0002" && array[i] != "\u0003")
				{
					arrayList.Add(array[i]);
				}
			}
			return arrayList;
		}

		public bool ReadFileRequest(string strFileName)
		{
			bool result = true;
			try
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(strFileName);
				string text = "";
				string text2 = "FILEREADXML?";
				text = text2.PadRight(40) + CH2 + CRLF;
				text2 = "SOBFREAD";
				text = text + text2.PadRight(40) + CRLF;
				text2 = "FNA" + fileNameWithoutExtension;
				text = text + text2.PadRight(40) + CRLF;
				text2 = "EOB1234";
				string text3 = text;
				text = text3 + text2.PadRight(40) + CRLF + CH3 + CRLF;
				m_serialPort.Write(text);
				m_iNumTry = 0;
				m_strAllData = "";
				return result;
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
		}

		public bool ReadFileContent(string strFileName, ref bool bDone)
		{
			bool flag = true;
			int num = 0;
			try
			{
				bDone = false;
				string text = "";
				Thread.Sleep(25);
				num = m_serialPort.BytesToRead;
				if (num > 0)
				{
					m_serialPort.Read(m_inputData, 0, num);
					m_iNumByteRead += num;
					m_iNumTry = 0;
					text = Encoding.UTF8.GetString(m_inputData, 0, num);
					m_strAllData += text;
					bDone = m_strAllData.IndexOf("OK\r") > -1;
				}
				else if (m_iNumTry++ > 50)
				{
					flag = false;
					bDone = true;
				}
				if (bDone)
				{
					if (flag)
					{
						m_strAllData = m_strAllData.Replace("\u0002", "");
						m_strAllData = m_strAllData.Replace("\u0003", "");
						m_strAllData = m_strAllData.Replace("OK\r\n", "");
						using (StreamWriter streamWriter = File.CreateText(strFileName))
						{
							streamWriter.Write(m_strAllData);
						}
						//flag = Global.SurveyInfo.CreateWaveFormDataFiles(strFileName);
						ClearBuffer();
						return flag;
					}
					return flag;
				}
				return flag;
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
		}

		private string GetFTPErrorMessage(string strErrData)
		{
			string[] separator = new string[1] { "\r\n" };
			string[] array = strErrData.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			return array[0];
		}

		public bool WriteFileRequest(string strFilename)
		{
			bool result = true;
			try
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(strFilename);
				string text = "";
				string text2 = "FILEWRITEXML=" + CH2;
				text = text2.PadRight(40) + CRLF;
				text2 = "SOBFWRITE";
				text = text + text2.PadRight(40) + CRLF;
				text2 = "FNA" + fileNameWithoutExtension;
				text = text + text2.PadRight(40) + CRLF;
				text2 = "EOB1234";
				string text3 = text;
				text = text3 + text2.PadRight(40) + CRLF + CH3 + CRLF;
				m_serialPort.Write(text);
				string text4 = "";
				bool flag = false;
				int num = 0;
				string text5 = "";
				do
				{
					Thread.Sleep(500);
					text4 = m_serialPort.ReadExisting();
					if (text4 == "")
					{
						flag = true;
						m_bExportRecOK = true;
					}
					else if (text4.Contains("OK"))
					{
						flag = true;
						m_bExportRecOK = true;
					}
					else if (text4.Contains("ER:"))
					{
						flag = true;
						m_bExportRecOK = false;
						m_strExportErrorLine = GetFTPErrorMessage(text4);
					}
					else
					{
						num++;
					}
					text5 += text4;
				}
				while (!flag && num < 10);
				if (!flag)
				{
					result = false;
				}
				if (!m_bExportRecOK)
				{
					result = false;
				}
				m_serialPort.DiscardInBuffer();
				return result;
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
		}

		public string GetExportError()
		{
			return m_iCurExportLine + ".  " + m_strExportErrorLine;
		}

		public bool WriteFileLine(string Line)
		{
			bool flag = false;
			m_strExportErrorLine = "";
			try
			{
				string text = "";
				Line = Line.Trim();
				text = Line.PadRight(60) + CRLF;
				m_serialPort.DiscardOutBuffer();
				m_serialPort.DiscardInBuffer();
				m_iCurExportLine++;
				m_serialPort.Write(text);
				Thread.Sleep(4);
				bool flag2 = false;
				string text2 = "";
				int num = 0;
				int num2 = 0;
				string text3 = "";
				do
				{
					num = m_serialPort.BytesToRead;
					if (num == 0)
					{
						flag2 = true;
					}
					else if (num > 0)
					{
						m_serialPort.Read(m_inputData, 0, num);
						text2 = Encoding.UTF8.GetString(m_inputData, 0, num);
						if (text2.Contains("OK"))
						{
							flag2 = true;
							flag = false;
							m_bExportRecOK = true;
						}
						else if (text2.Contains("ER"))
						{
							m_strExportErrorLine = GetFTPErrorMessage(text2) + " " + Line;
							flag2 = true;
							flag = true;
						}
						else
						{
							num2++;
						}
						text3 += text2;
					}
				}
				while (!flag2 && num2 < 20 && flag);
				if (!flag2)
				{
					flag = true;
				}
				m_serialPort.DiscardInBuffer();
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
			return !flag;
		}

		public int SerialCheck()
		{
			int result = 0;
			try
			{
				if (m_serialPort != null)
				{
					if (m_serialPort.IsOpen)
					{
						if (m_Queue.Count > 0)
						{
							switch (m_iType)
							{
								case 0:
									{
										string text = (string)m_Queue.Peek();
										return text.Length;
									}
								case 1:
								case 2:
									return m_Queue.Count;
								default:
									return result;
							}
						}
						return result;
					}
					return result;
				}
				return result;
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return 0;
			}
		}

		public string SerialRead()
		{
			return (string)m_Queue.Dequeue();
		}

		public byte[] SerialReadByte()
		{
			int count = m_Queue.Count;
			byte[] array = new byte[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = Convert.ToByte(m_Queue.Dequeue());
			}
			return array;
		}

		public byte[] SerialReadOriginalByte()
		{
			m_iNumByteRead = m_Queue.Count;
			int i = 0;
			try
			{
				for (; i < m_iNumByteRead; i++)
				{
					int value = (int)m_Queue.Dequeue();
					m_inputData[i] = Convert.ToByte(value);
				}
			}
			catch (NullReferenceException)
			{
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return null;
			}
			return m_inputData;
		}

		public int GetSerialNumberReadBytes()
		{
			return m_iNumByteRead;
		}

		public bool SerialWrite(string strData)
		{
			try
			{
				if (m_serialPort != null && m_serialPort.IsOpen)
				{
					m_serialPort.Write(strData);
					return true;
				}
				return false;
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
		}

		public bool SerialWrite(byte[] buf, int buflen)
		{
			try
			{
				if (m_serialPort != null && m_serialPort.IsOpen)
				{
					m_serialPort.Write(buf, 0, buflen);
					return true;
				}
				return false;
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
		}

		private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			int num = 0;
			if (!m_serialPort.IsOpen)
			{
				return;
			}
			try
			{
				switch (m_iType)
				{
					case 0:
						m_strData.Append(m_serialPort.ReadExisting());
						for (num = m_strData.ToString().IndexOf("\r\n"); num >= 0; num = m_strData.ToString().IndexOf("\r\n"))
						{
							string obj = m_strData.ToString(0, num + 2);
							m_strData.Remove(0, num + 2);
							m_Queue.Enqueue(obj);
						}
						break;
					case 1:
						while (m_serialPort.BytesToRead > 3)
						{
							int num3 = serialPort.ReadByte();
							m_Queue.Enqueue(num3);
							num3 = serialPort.ReadByte();
							m_Queue.Enqueue(num3);
							num3 = serialPort.ReadByte();
							m_Queue.Enqueue(num3);
							num3 = serialPort.ReadByte();
							m_Queue.Enqueue(num3);
						}
						break;
					case 2:
						{
							int num2 = m_serialPort.BytesToRead;
							while (num2 > 0)
							{
								int num3 = serialPort.ReadByte();
								num2--;
								m_Queue.Enqueue(num3);
							}
							break;
						}
				}
			}
			catch (Exception)
			{
			}
		}

		public bool RenameFile(int iIndex, string strOldFileName, string strNewFileName)
		{
			bool result = true;
			try
			{
				string strCommand = "PGL=" + iIndex + "\r\n";
				if (!Nortec.MainPort.SendCommand(strCommand))
				{
					Nortec.strErrorMessage = "Cannot Select File on the Gage.";
					return false;
				}
				strCommand = "PGN=" + strNewFileName + "\r\n";
				if (!Nortec.MainPort.SendCommand(strCommand))
				{
					Nortec.strErrorMessage = "Cannot Rename File on the Gage.";
					return false;
				}
				return result;
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
		}

		public bool RecallFile(int iIndex, string strFileName)
		{
			bool result = true;
			try
			{
				string strCommand = "PRC=" + iIndex + "\r\n";
				if (!Nortec.MainPort.SendCommand(strCommand))
				{
					Nortec.strErrorMessage = "Cannot Recall File on the Gage.";
					return false;
				}
				return result;
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
		}

		public bool IsChargerOn(ref bool bChargerOn, ref bool bUnknownState)
		{
			bChargerOn = false;
			bUnknownState = false;
			string strCommand = "BCP?\r\n";
			string text = "";
			bool flag = false;
			try
			{
				if (SendCommand(strCommand))
				{
					int num = 0;
					Thread.Sleep(100);
					while (!flag && num < 5)
					{
						text = ReadPortResponse();
						if (text.Contains("OK"))
						{
							text = text.Replace("\r\n", "");
							text = text.Replace("OK", "");
							if (text == "TRUE")
							{
								bChargerOn = true;
							}
							flag = true;
							break;
						}
						if (text.Contains("?"))
						{
							bUnknownState = true;
							flag = true;
							break;
						}
						Thread.Sleep(50);
						num++;
					}
				}
				m_serialPort.DiscardOutBuffer();
				m_serialPort.DiscardInBuffer();
				if (!flag)
				{
					return false;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool GetGageVersion(string strGageInfo, ref int iGageSwVersion)
		{
			try
			{
				ArrayList fTPLineList = GetFTPLineList(strGageInfo);
				if (fTPLineList.Count != 3)
				{
					return false;
				}
				string text = (string)fTPLineList[1];
				if (text.Length > 15)
				{
					string strVersionValue = text.Substring(15, 5);
					//iGageSwVersion = PanHelper.VersionStringToNumber(strVersionValue);
				}
			}
			catch (Exception theException)
			{
				Nortec.DisplayError(theException);
				return false;
			}
			return true;
		}

		private bool GetGageInfo(ref string strGageInfo)
		{
			strGageInfo = "";
			if (!Nortec.CheckOnLine())
			{
				return false;
			}
			if (!Nortec.IsOnLine)
			{
				return false;
			}
			if (!Nortec.MainPort.OpenPort(bSetDataRec: false))
			{
				MessageBox.Show("ERROR: Cannot Connect to Device");
				return false;
			}
			string strCommand = "GAGEINFO?\r\n";
			if (Nortec.MainPort.SendCommand(strCommand))
			{
				strGageInfo = Nortec.MainPort.GetPortResponse();
			}
			Nortec.MainPort.ClosePort();
			return true;
		}

		public bool CheckUpgradeStatus(ref bool bUpgradeXML, ref bool bDowngradeXML, ref int iGageSwVersion)
		{
			string strGageInfo = "";
			if (!GetGageInfo(ref strGageInfo))
			{
				return false;
			}
			bUpgradeXML = false;
			bDowngradeXML = false;
			iGageSwVersion = 0;
			if (!Nortec.MainPort.GetGageVersion(strGageInfo, ref iGageSwVersion))
			{
				return false;
			}
			//if (Global.SurveyInfo.iFileSwVersion == 129999)
			//{
			//	Global.SurveyInfo.iFileSwVersion = iGageSwVersion;
			//}
			//if (Global.SurveyInfo.iFileSwVersion < 87)
			//{
			//	bUpgradeXML = true;
			//}
			//else if (Global.SurveyInfo.iFileSwVersion > iGageSwVersion)
			//{
			//	bDowngradeXML = true;
			//}
			return true;
		}
	}

}
