using Cutreson_Utility;
using Cutreson_PLC.McProtocol;
using System;
using System.Threading;
using Seoul_Software.Scanner;
using System.Reflection;
using System.Linq;

namespace Seoul_Software
{
    public class clsControlPLC : clsBindable
    {
        McProtocolTcp client;
        private Thread _ThreadPLC;
        private readonly object _Lock = new object();
        public clsControlPLC()
        {
			ref_ControlMonitorArr = Enumerable.Repeat(6969, clsConfig.ControlMonitorCount).ToArray();
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
                if(client.Open())
                {
                    Global.Log.Operation("Connected to PLC");
                }
                else
                {
                    Global.Log.Error("Can't connect to PLC");
                }
            }
            catch(Exception ex)
            {

            }
        }
        private bool _alive;
        public bool PlcAlive
        {
            get { return _alive; }
            set { Set(ref _alive, value); }
        }
        private bool _plcGetCvBarcode;
		public bool PlcGetCvBarcode
		{
			get { return _plcGetCvBarcode; }
			set { Set(ref _plcGetCvBarcode, value); }
		}
		private bool _plcPrintRequest;
		public bool PlcPrintRequest
		{
			get { return _plcPrintRequest; }
			set { Set(ref _plcPrintRequest, value); }
		}
		private bool _plcOutRing;
		public bool PlcOutRingRequest
		{
			get { return _plcOutRing; }
			set { Set(ref _plcOutRing, value); }
		}
		private bool _initial;
		public bool Initial
		{
			get { return _initial; }
			set { Set(ref _initial, value); }
		}
		//Alarm
		private bool _alarmSignal;
		public bool AlarmSignal
		{
			get { return _alarmSignal; }
			set { Set(ref _alarmSignal, value); }
		}
		//Auto running
		private bool _autoRunning;
		public bool AutoRunning
		{
			get { return _autoRunning; }
			set { Set(ref _autoRunning, value); }
		}
		private bool[] ref_AlarmArr = new bool[clsConfig.AlarmCount];		
		public event EventHandler<EventParam> AlarmEvent;
		//Operating event
		private bool[] ref_OperatingEventArr = new bool[clsConfig.OperatingEventCount];
		public event EventHandler<EventParam> OperatingEvent;
		//COntrol monitor
		private int[] ref_ControlMonitorArr = new int[clsConfig.ControlMonitorCount];
		public event EventHandler<ControlMonitorParam> ControlMonitorEvent;
		//Vision
		private int _visionComplete;
		public int VisionComplete
		{
			get { return _visionComplete; }
			set { Set(ref _visionComplete, value); }
		}
		private void DoWork()
        {
            while (true)
            {
                try
                {
                    if(client.IsConnect())
                    {
                        //Read bit
                        bool[] m0_m299 = client.ReadBits(PlcDeviceType.M, 0, 300);
						Initial = m0_m299[107];
                        AlarmSignal = m0_m299[113];
						AutoRunning = m0_m299[103];
                        //-----------------------Alarm----------------------------------------------------
                        bool[] b_arrALarm = client.ReadBits(clsConfig.AlarmDeviceType, clsConfig.AlarmStartAddress, clsConfig.AlarmCount);
                        for (int i = 0; i < b_arrALarm.Length; i++)
                        {
                            if(b_arrALarm[i] != ref_AlarmArr[i])
                            {
								AlarmEvent?.Invoke(this, new EventParam(i, b_arrALarm[i]));
							}
                            ref_AlarmArr[i] = b_arrALarm[i];
                        }
						//---------------------------------------------------------------------------------
						//-----------------------Operating Event-------------------------------------------
						bool[] b_arrOprratingEvent = client.ReadBits(clsConfig.OperatingEventDeviceType, clsConfig.OperatingEventStartAddress, clsConfig.OperatingEventCount);
						for (int i = 0; i < b_arrOprratingEvent.Length; i++)
						{
							if (b_arrOprratingEvent[i] != ref_OperatingEventArr[i])
							{
								OperatingEvent?.Invoke(this, new EventParam(i, b_arrOprratingEvent[i]));
							}
							ref_OperatingEventArr[i] = b_arrOprratingEvent[i];
						}
						//---------------------------------------------------------------------------------
						//-----------------------Control Monitor-------------------------------------------
						int[] b_arrControlMonitor = client.ReadWords(clsConfig.ControlDeviceType, clsConfig.ControlStartAddress, clsConfig.ControlMonitorCount);
						for (int i = 0; i < b_arrControlMonitor.Length; i++)
						{
							if (b_arrControlMonitor[i] != ref_ControlMonitorArr[i])
							{
								ControlMonitorEvent?.Invoke(this, new ControlMonitorParam(i, b_arrControlMonitor[i]));
							}
							ref_ControlMonitorArr[i] = b_arrControlMonitor[i];
						}
						//---------------------------------------------------------------------------------
						//Alive
						PlcAlive = m0_m299[10];
                        //Barcode
                        PlcGetCvBarcode = client.ReadBit(PlcDeviceType.L, 10000);
						//Printer
						PlcPrintRequest = client.ReadBit(PlcDeviceType.L, 16020);
						//Out Ring
						PlcOutRingRequest = client.ReadBit(PlcDeviceType.L, 17050);
						//Vision
						VisionComplete = client.ReadWord(clsConfig.VisionDeviceType, clsConfig.VisionStartAddress);
					}
                    else
                    {
                        Connect();
                        Thread.Sleep(200);
                    }
                }
                catch (Exception ex)
                {
                    Global.Log.Error(ex.Message, Log.eLogLevel.FATAL);
                }
                Thread.Sleep(1);
            }
        }
        public bool WriteBarcode(BarcodeModel barcode)
        {
            lock (_Lock)
            {
                try
                {
                    if(client.IsConnect())
                    {
                        bool b = client.WriteWord(PlcDeviceType.ZR, 10000 + barcode.Index, barcode.Id);
                        return b;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch(Exception ex) 
                {
					Global.Log.Error(ex.Message, Log.eLogLevel.FATAL);
				}
				return false;
			} 
                
        }
		public int[] ReadBarcodeIdInput()
		{
			lock (_Lock)
			{
				try
				{
					if (client.IsConnect())
					{						
						return client.ReadWords(PlcDeviceType.ZR, 10000, 10);
					}
				}
				catch (Exception ex)
				{
					Global.Log.Error(ex.Message, Log.eLogLevel.FATAL);
				}
                return null;
			}

		}
		public int[] ReadPrintData()
		{
			lock (_Lock)
			{
				try
				{
					if (client.IsConnect())
					{
						return client.ReadWords(PlcDeviceType.ZR, 16051, 5);
					}
				}
				catch (Exception ex)
				{
					Global.Log.Error(ex.Message, Log.eLogLevel.FATAL);
				}
				return null;
			}

		}
		public int[] ReadVisionData()
		{
			lock (_Lock)
			{
				try
				{
					if (client.IsConnect())
					{
						return client.ReadWords(clsConfig.VisionDeviceType, clsConfig.VisionStartAddress, clsConfig.VisionCount);
					}
				}
				catch (Exception ex)
				{
					Global.Log.Error(ex.Message, Log.eLogLevel.FATAL);
				}
				return null;
			}

		}
		public bool WritePrintComplete()
		{
			lock (_Lock)
			{
				try
				{
					if (client.IsConnect())
					{
						bool b = client.SetBit(PlcDeviceType.L, 16021, true);
						return b;
					}
					else
					{
						return false;
					}
				}
				catch (Exception ex)
				{
					Global.Log.Error(ex.Message, Log.eLogLevel.FATAL);
				}
				return false;
			}

		}
		public bool WriteOutRingComplete()
		{
			lock (_Lock)
			{
				try
				{
					if (client.IsConnect())
					{
						bool b = client.SetBit(PlcDeviceType.L, 17051, true);
						return b;
					}
					else
					{
						return false;
					}
				}
				catch (Exception ex)
				{
					Global.Log.Error(ex.Message, Log.eLogLevel.FATAL);
				}
				return false;
			}

		}
		public bool WriteGetBarcodeComplete()
		{
			lock (_Lock)
			{
				try
				{
					if (client.IsConnect())
					{
						bool b = client.SetBit(PlcDeviceType.L, 10001, true);
						return b;
					}
					else
					{
						return false;
					}
				}
				catch (Exception ex)
				{
					Global.Log.Error(ex.Message, Log.eLogLevel.FATAL);
				}
				return false;
			}

		}
		public bool Setbit(PlcDeviceType iType, int iAddress, bool value)
		{
			lock (_Lock)
			{
				try
				{
					if (client.IsConnect())
					{
						bool b = client.SetBit(iType, iAddress, value);
						return b;
					}
					else
					{
						return false;
					}
				}
				catch (Exception ex)
				{
					Global.Log.Error(ex.Message, Log.eLogLevel.FATAL);
				}
				return false;
			}

		}
		public void InitialControlMonitor()
		{
			lock (_Lock)
			{
				try
				{
					if (client.IsConnect())
					{
						//-----------------------Control Monitor-------------------------------------------
						int[] b_arrControlMonitor = client.ReadWords(clsConfig.ControlDeviceType, clsConfig.ControlStartAddress, clsConfig.ControlMonitorCount);
						for (int i = 0; i < b_arrControlMonitor.Length; i++)
						{
							ControlMonitorEvent?.Invoke(this, new ControlMonitorParam(i, b_arrControlMonitor[i]));
						}
					}
				}
				catch (Exception ex)
				{
					Global.Log.Error(ex.Message, Log.eLogLevel.FATAL);
				}
			}
		}
		public bool WriteCounter()
		{
			lock (_Lock)
			{
				try
				{
					if (client.IsConnect())
					{
						int[] arr1 = SplitLongToIntArray(Global.TotalLot);
						int[] arr2 = SplitLongToIntArray(Global.TotalRing);
						int[] arr3 = SplitLongToIntArray(Global.TotalChipLed);
						int[] result = new int[arr1.Length + arr2.Length + arr3.Length];
						Array.Copy(arr1, 0, result, 0, arr1.Length);
						Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
						Array.Copy(arr3, 0, result, arr1.Length + arr2.Length, arr3.Length);
						bool b = client.WriteWords(PlcDeviceType.ZR, 10, 12, result);
						return b;
					}
					else
					{
						return false;
					}
				}
				catch (Exception ex)
				{
					Global.Log.Error(ex.Message, Log.eLogLevel.FATAL);
				}
				return false;
			}

		}
		private int[] SplitLongToIntArray(long number)
		{
			int[] result = new int[4];
			result[3] = (int)((number >> 48) & 0xFFFF); 
			result[2] = (int)((number >> 32) & 0xFFFF);
			result[1] = (int)((number >> 16) & 0xFFFF);
			result[0] = (int)(number & 0xFFFF);
			return result;
		}
	}
	public class EventParam
	{
		public int Index;
		public bool IsOn;
		public EventParam(int index, bool isOn)
		{
			Index = index;
			IsOn = isOn;
		}
	}
}
public class ControlMonitorParam
{
	public int Index;
	public int Value;
	public ControlMonitorParam(int index, int value)
	{
		Index = index;
		Value = value;
	}
}
