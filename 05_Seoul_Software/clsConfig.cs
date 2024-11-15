using Cutreson_PLC.McProtocol;
using Cutreson_Utility;
using OfficeOpenXml;
using Seoul_Software.Alarm;
using Seoul_Software.OperatingEvent;
using Seoul_Software.Log;
using System;
using System.Collections.Generic;
using System.IO;
using Seoul_Software.MachineMonitor;
using System.Drawing;

namespace Seoul_Software
{
    public class clsConfig
    {
        //FTP smart cam Cognex IS2000
        public static int FtpPort = 21;
        public static string FtpUserName = "son";
        public static string FtpPassword = "son@123";
        public static string FtpFolderPath = "ftp_uploads";
		public static string FtpImageFileName = "image.bmp";
        public static bool IsSaveImageLog = true;
        //Log
        public static bool IsSaveLog = true;
		public static int ListBoxLogMaxRow = 100;
		//Database
        public static string DatabasePathFolder = "data";
        public static string BarcodeFile = "barcode.xml";
        //Id Max
        public static int IdBarcodeMax = 10000;
        //Excel config
        public static string ConfigExcelFile = "config/config.xlsx";
		//Alarm
		public static PlcDeviceType AlarmDeviceType = PlcDeviceType.L;
		public static int AlarmStartAddress = 4000;
		public static int AlarmCount = 1000;
		public static bool ShowAlarmDevice = true;
		//Event log
		public static string StringNotUse = "not use";
		public static PlcDeviceType OperatingEventDeviceType = PlcDeviceType.M;
		public static int OperatingEventStartAddress = 0;
		public static int OperatingEventCount = 400;
		public static bool ShowOperatingEventDevice = true;
		//Control monitor
		public static PlcDeviceType ControlDeviceType = PlcDeviceType.D;
		public static int ControlStartAddress = 100;
		public static int ControlMonitorCount = 100;
		//Vision: Job.Inspection_Completed - Pass - Fail - Job.Inspection_Count - Job.Pass_Count - Job.Fail_Count
		public static PlcDeviceType VisionDeviceType = PlcDeviceType.W;
		public static int VisionStartAddress = 0;
		public static int VisionCount = 10;
		//Printer
		public static string PrinterLotKey = "_lot_";
		public static string PrinterTotalKey = "_total_";

		//////////////////////////////////////////////////////////////////////////////////////
		#region Load config
        public static bool LoadExcelConfig()
        {
            try
            {
				ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
				using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(ConfigExcelFile)))
                {
					if (excelPackage.Workbook.Worksheets.Count == 0)
					{
						clsMessageBox.Error("No worksheets in the Excel file");
						return false;
					}
					//Alarm-----------------------------------------------------------------------
					ExcelWorksheet worksheetAlarm = excelPackage.Workbook.Worksheets[0];
					List<AlarmModel> alarms = new List<AlarmModel>();
					if (worksheetAlarm == null)
					{
						clsMessageBox.Error("Worksheet alarm is null");
						return false;
					}
					if (worksheetAlarm.Dimension == null || worksheetAlarm.Dimension.End.Row == 0)
					{
						clsMessageBox.Error("No data in the worksheet alarm");
						return false;
					}
					for (int i = 3; i <= worksheetAlarm.Dimension.End.Row; i++)
					{
						AlarmModel alarmModel = new AlarmModel();
						alarmModel.No = Convert.ToInt32(worksheetAlarm.Cells[i, 1].Text);
						alarmModel.AlarmLevel = worksheetAlarm.Cells[i, 2].Text == "Light" ? eLogLevel.WARNING : eLogLevel.ERROR;
						alarmModel.Index = Convert.ToInt32(worksheetAlarm.Cells[i, 3].Text);
						alarmModel.Text = worksheetAlarm.Cells[i, 4].Text;
						alarms.Add(alarmModel);
						Global.Alarms = alarms;
					}
					//Event Log-------------------------------------------------------------------
					ExcelWorksheet worksheetEvent = excelPackage.Workbook.Worksheets[1];
					List<OperatingEventModel> eventLogs = new List<OperatingEventModel>();
					if (worksheetEvent == null)
					{
						clsMessageBox.Error("Worksheet event is null");
						return false;
					}
					if (worksheetEvent.Dimension == null || worksheetEvent.Dimension.End.Row == 0)
					{
						clsMessageBox.Error("No data in the worksheet event");
						return false;
					}
					for (int i = 3; i <= worksheetEvent.Dimension.End.Row; i++)
					{
						OperatingEventModel eventLog = new OperatingEventModel();
						eventLog.No = Convert.ToInt32(worksheetEvent.Cells[i, 1].Text);
						eventLog.Index = Convert.ToInt32(worksheetEvent.Cells[i, 2].Text);
						eventLog.MessageOn = worksheetEvent.Cells[i, 3].Text;
						eventLog.MessageOff = worksheetEvent.Cells[i, 4].Text;
						eventLogs.Add(eventLog);
						Global.OperatingEvents = eventLogs;
					}
					//Control Monitor-----------------------------------------------------------------------
					ExcelWorksheet worksheetControl = excelPackage.Workbook.Worksheets[2];
					List<ControlMonitorModel> controlMonitors = new List<ControlMonitorModel>();
					if (worksheetControl == null)
					{
						clsMessageBox.Error("Worksheet control monitor is null");
						return false;
					}
					if (worksheetControl.Dimension == null || worksheetControl.Dimension.End.Row == 0)
					{
						clsMessageBox.Error("No data in the worksheet control monitor");
						return false;
					}
					for (int i = 3; i <= worksheetControl.Dimension.End.Row; i++)
					{
						ControlMonitorModel controlMonitor = new ControlMonitorModel();
						controlMonitor.No = Convert.ToInt32(worksheetControl.Cells[i, 1].Text);
						controlMonitor.Index = Convert.ToInt32(worksheetControl.Cells[i, 2].Text);
						controlMonitor.ControlName = worksheetControl.Cells[i, 3].Text;
						controlMonitor.Value = Convert.ToInt32(worksheetControl.Cells[i, 4].Text);
						controlMonitor.Message = worksheetControl.Cells[i, 5].Text;
						controlMonitor.HexCode = worksheetControl.Cells[i, 6].Text;
						controlMonitors.Add(controlMonitor);
						Global.ControlMonitors = controlMonitors;
					}
				}
			}
            catch(Exception ex)
            {
                string message = "Load config.xlsx: " + ex.Message;
                Global.Log.Alarm(message);
                clsMessageBox.Error(message);
            }

            return true;
        }
		#endregion
	}
}
