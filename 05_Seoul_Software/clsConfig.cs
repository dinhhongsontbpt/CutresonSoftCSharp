using Cutreson_PLC.McProtocol;
using Cutreson_Utility;
using OfficeOpenXml;
using Seoul_Software.Alarm;
using Seoul_Software.Log;
using System;
using System.Collections.Generic;
using System.IO;

namespace Seoul_Software
{
    public class clsConfig
    {
        //FTP smart cam Cognex IS2000
        public static int FtpPort = 21;
        public static string FtpUserName = "son";
        public static string FtpPassword = "son@123";
        public static string FtpFolderPath = "ftp_uploads";
        public static bool IsSaveImageLog = false;
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
					//Alarm
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
