using Cutreson_Utility;
using Seoul_Software.Log;
using Seoul_Software.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seoul_Software
{
	public class MySetting
	{
		private const string FolderName = "config";
		private const string FileName = "config.ini";
		public string Title;
		public string CompanyName;
		public string LogPathFolder;
		public string LogOperationFileName;
		public string LogErrorFileName;
		public string LogAlarmFileName;
		public string PlcIpAddress;
		public int PlcPort;
		public bool CheckBarcodeOverlap;
		public string PrinterIp;
		public int PrinterPort;
		public string PrinterCommand1;
		public string PrinterCommand2;
		public bool ShowIdBarcode;
		//FTP smart cam Cognex IS2000
		public int FtpPort;
		public string FtpUserName;
		public string FtpPassword;
		public string FtpFolderPath;
		public string FtpImageFileName;
		public bool IsSaveImageLog;
		//SQL
		public string ConnectionString;
		//Login
		public string OperatorPassword;
		public string EngineerPassword;
		public string AdminPassword;
		public eRole AutoLoginAs;

		public static MySetting Setting = new MySetting();
		
		public MySetting()
		{
			Title = "Auto UV Tape Mount Machine";
			CompanyName = "Cutreson Co., Ltd";
			LogOperationFileName = "operation.txt";
			LogErrorFileName = "error.txt";
			LogAlarmFileName = "alarm.txt";
			LogPathFolder = "log";
			PlcIpAddress = "192.168.3.28";
			PlcPort = 6666;
			CheckBarcodeOverlap = true;
			PrinterIp = "192.168.3.123";
			PrinterPort = 6101;
			PrinterCommand1 = "^XA^FO20,20^ADN,30,20^FDLot:_lot_^FS^FO20,80^ADN,30,20^FDTotal:_total_pcs^FS^XZ";
			PrinterCommand2 = "^XA^FO20,20^ADN,30,15^FD 1 2 |_index1_ _lot1_^FS^FO20,80^ADN,30,15^FD3 4 5|_index2_ _lot2_^FS^XZ";
			FtpPort = 22;
			FtpUserName = "son";
			FtpPassword = "son@123";
			FtpFolderPath = "ftp_uploads";
			FtpImageFileName = "image.bmp";
			IsSaveImageLog = true;
			ShowIdBarcode = false;
			ConnectionString = "Server=CUTRESON;Database=Seoul_01;Trusted_Connection=True;";
			OperatorPassword = "1";
			EngineerPassword = "123";
			AdminPassword = "1234";
			AutoLoginAs = eRole.ADMIN;
		}

		public void SaveSetting()
		{
			try
			{
				string pathFile = Path.Combine(FolderName, FileName);
				clsSave.WriteToXmlFile<MySetting>(pathFile, Setting, false);
			}
			catch (Exception ex)
			{
				clsMessageBox.Error("User setting " + ex.Message);
			}
		}

		public bool LoadSetting()
		{
			if (!Directory.Exists(FolderName))
			{
				Directory.CreateDirectory(FolderName);
			}
			try
			{
				string pathFile = Path.Combine(FolderName, FileName);
				if (File.Exists(pathFile))
				{
					Setting = (MySetting)clsSave.ReadFromXmlFile<MySetting>(pathFile);
				}
				else
				{
					SaveSetting();
				}
			}
			catch (Exception ex)
			{
				clsMessageBox.Error(ex.Message);
				return false;
			}
			return true;
		}
	}
}
