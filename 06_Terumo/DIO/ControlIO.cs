using _06_Terumo.CdioCs;
using Cutreson_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Terumo
{
	public class ControlIO : clsBindable
	{
		Cdio dio = new Cdio();
		public short m_Id;
		private Thread _ThreadPLC;
		private readonly object _Lock = new object();

		public ControlIO(out int ret)
		{
			ret = -1;
			if(Connect()) ret = 0;
			if (ret == 0)
			{
				_ThreadPLC = new Thread(DoWork);
				_ThreadPLC.IsBackground = true;
				_ThreadPLC.Start();
			}
		}
		private bool FirstConnect = true;
		private bool Connect()
		{
			try
			{
				int Ret;
				Ret = dio.Init("DIO000", out m_Id);
				string ErrorString;
				dio.GetErrorString(Ret, out ErrorString);
				if (Ret == 0)
				{
					if(FirstConnect)
					{
						Global.Common.LogDebug("Initial DIO successfully");
					}	
					for(int i = 0; i < Global.OutputBitCount; i++)
					{
						WriteBit(i, Global.LogicOFF);
					}
					return true;
				}
				else
				{
					if (FirstConnect)
					{
						Global.Common.LogError("Initial DIO error: Ret = " + System.Convert.ToString(Ret) + " : " + ErrorString);
						//clsMessageBox.Error("Initial DIO error: Ret = " + System.Convert.ToString(Ret) + " : " + ErrorString);
					}
				}
				FirstConnect = false;
			}
			catch (Exception ex)
			{
				LogError(ex);
			}
			return false;
		}
		private void LogError(Exception ex)
		{
			string message = "ControlIO.cs exception: " + ex.Message;
			Global.Common.LogFatal(message);
			//clsMessageBox.Error(message);
		}
		private void LogError(string message)
		{
			Global.Common.LogError(message);
			//clsMessageBox.Error(message);
		}
		private bool GetPortInput(out bool[] bools)
		{
			bool[] result = new bool[Global.InputBitCount];
			int Ret;
			short InpPortNo = 0;
			byte InpPortData;
			Ret = dio.InpByte(m_Id, InpPortNo, out InpPortData);
			string ErrorString;
			dio.GetErrorString(Ret, out ErrorString);
			string errorMessage = "ControlDIO get port input error: Ret = " + System.Convert.ToString(Ret) + " : " + ErrorString;
			if (Ret != (int)CdioConst.DIO_ERR_SUCCESS)
			{
				LogError(errorMessage);				
				bools = new bool[Global.InputBitCount];
				return false;
			}
			else
			{
				for (int i = 0; i < Global.InputBitCount; i++)
				{
					result[i] = (InpPortData & (1 << i)) != 0;
				}
				bools = result;
				return true;
			}
		}
		
		public event EventHandler<EventParam> InputChanged;
		private void DoWork()
		{
			while (true)
			{
				try
				{
					bool[] inputBits;
					bool ret = GetPortInput(out inputBits);
					if (ret)
					{
						for (int i = 0; i < Global.InputBitCount; i++)
						{
							if (inputBits[i] != Global.InputBits[i])
							{
								InputChanged?.Invoke(this, new EventParam(i, inputBits[i]));
							}
							Global.InputBits[i] = inputBits[i];
						}	
					}
					else
					{
						Thread.Sleep(1000);
						Global.Common.LogError("Check connect to DIO");
						Connect();
					}	
				}
				catch (Exception ex)
				{
					LogError(ex.Message);
					Thread.Sleep(2000);
				}
				Thread.Sleep(10);
			}
		}

		public event EventHandler<EventParam> OutputChanged;
		public bool WriteBit(int index, bool value)
		{
			int Ret;
			short OutBitNo;
			byte OutBitData;

			try
			{
				OutBitNo = System.Convert.ToInt16(index);
				OutBitData = System.Convert.ToByte((value == true ? 1 : 0).ToString(), 16);
			}
			catch
			{
				OutBitNo = 0;
				OutBitData = 0;
			}

			Ret = dio.OutBit(m_Id, OutBitNo, OutBitData);
			string ErrorString;
			dio.GetErrorString(Ret, out ErrorString);
			string errorMessage = "ControlDIO write bit error: Ret = " + System.Convert.ToString(Ret) + " : " + ErrorString;
			if (Ret != (int)CdioConst.DIO_ERR_SUCCESS)
			{
				return false;
			}
			Global.OutputBits[index] = value;
			OutputChanged?.Invoke(this, new EventParam(index, value));
			return true;
		}
	}
	public class EventParam
	{
		public int Index;
		public bool Value;
		public EventParam(int index, bool value)
		{
			Index = index;
			Value = value;
		}
	}
}
