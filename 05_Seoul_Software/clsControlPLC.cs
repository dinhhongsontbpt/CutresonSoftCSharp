using Cutreson_Utility;
using Cutreson_PLC.McProtocol;
using System;
using System.Threading;
using Seoul_Software.Scanner;
using System.Reflection;

namespace Seoul_Software
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
		private bool _initial;
		public bool Initial
		{
			get { return _initial; }
			set { Set(ref _initial, value); }
		}
		private bool _alarmSignal;
		public bool AlarmSignal
		{
			get { return _alarmSignal; }
			set { Set(ref _alarmSignal, value); }
		}
		private bool[] ref_AlarmArr = new bool[clsConfig.AlarmCount];
		public event EventHandler<int> AlarmEvent;
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
                        //-----------------------Alarm----------------------------------------------------
                        bool[] b_arrLarm = client.ReadBits(clsConfig.AlarmDeviceType, clsConfig.AlarmStartAddress, clsConfig.AlarmCount);
                        for (int i = 0; i < b_arrLarm.Length; i++)
                        {
                            if(b_arrLarm[i] && !ref_AlarmArr[i])
                            {
								AlarmEvent?.Invoke(this, i);
							}
                            ref_AlarmArr[i] = b_arrLarm[i];
                        }
                        //---------------------------------------------------------------------------------
						//Alive
						PlcAlive = client.ReadBit(PlcDeviceType.B, 0);
                        //
                        PlcGetCvBarcode = client.ReadBit(PlcDeviceType.L, 10000);
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
					Global.Log.Alarm(ex.Message, Log.eLogLevel.ERROR);
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
					Global.Log.Alarm(ex.Message, Log.eLogLevel.ERROR);
				}
                return null;
			}

		}
	}
}
