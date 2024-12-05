using Cutreson_Utility;
using Seoul_Software.Alarm;
using Seoul_Software.OperatingEvent;
using Seoul_Software.Log;
using Seoul_Software.Scanner;
using System.Collections.Generic;
using Seoul_Software.MachineMonitor;
using Seoul_Software.SQL;

namespace Seoul_Software
{
    public class Global
    {
        public static clsControlPLC PLC;
        public static Logger Log = new Logger();
        public static List<BarcodeModel> Barcodes = new List<BarcodeModel>();
        public static List<AlarmModel> Alarms;
        public static List<AlarmModel> CurrentAlarms = new List<AlarmModel>();
		public static List<OperatingEventModel> OperatingEvents;
		public static List<ControlMonitorModel> ControlMonitors;
        public static DbManager DbManager;
        public static long TotalLot;
        public static long TotalRing;
        public static long TotalChipLed;
	}
}
