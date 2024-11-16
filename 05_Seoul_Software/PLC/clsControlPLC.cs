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
                    Global.Log.Alarm("Can't connect to PLC");
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
		public event EventHandler<int> AlarmEvent;
		//Operating event
		private bool[] ref_OperatingEventArr = new bool[clsConfig.OperatingEventCount];
		public event EventHandler<OperatingEventParam> OperatingEvent;
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
                            if(b_arrALarm[i] && !ref_AlarmArr[i])
                            {
								AlarmEvent?.Invoke(this, i);
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
								OperatingEvent?.Invoke(this, new OperatingEventParam(i, b_arrOprratingEvent[i]));
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
						PlcAlive = client.ReadBit(PlcDeviceType.B, 0);
                        //Barcode
                        PlcGetCvBarcode = client.ReadBit(PlcDeviceType.L, 10000);
						//Printer
						PlcPrintRequest = client.ReadBit(PlcDeviceType.L, 16020);
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
                    Global.Log.Alarm(ex.Message, Log.eLogLevel.FATAL);
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
					Global.Log.Alarm(ex.Message, Log.eLogLevel.FATAL);
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
					Global.Log.Alarm(ex.Message, Log.eLogLevel.FATAL);
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
						return client.ReadWords(PlcDeviceType.ZR, 16000, 2);
					}
				}
				catch (Exception ex)
				{
					Global.Log.Alarm(ex.Message, Log.eLogLevel.FATAL);
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
					Global.Log.Alarm(ex.Message, Log.eLogLevel.FATAL);
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
					Global.Log.Alarm(ex.Message, Log.eLogLevel.FATAL);
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
					Global.Log.Alarm(ex.Message, Log.eLogLevel.FATAL);
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
					Global.Log.Alarm(ex.Message, Log.eLogLevel.FATAL);
				}
			}
		}
	}
	public class OperatingEventParam
	{
		public int Index;
		public bool IsOn;
		public OperatingEventParam(int index, bool isOn)
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
