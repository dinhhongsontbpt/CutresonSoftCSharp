﻿using Cutreson_Utility;
using Seoul_Software.Log;
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
		public string LogAlarmFileName;
		public string PlcIpAddress;
		public int PlcPort;
		public bool CheckBarcodeOverlap;
		public string PrinterIp;
		public int PrinterPort;
		public string PrinterCommand;
		public static MySetting Setting = new MySetting();

		public MySetting()
		{
			Title = "Vision Edition Software";
			CompanyName = "Cutreson Co., Ltd";
			LogOperationFileName = "operation.txt";
			LogAlarmFileName = "alarm.txt";
			LogPathFolder = "log";
			PlcIpAddress = "192.168.3.28";
			PlcPort = 6666;
			CheckBarcodeOverlap = true;
			PrinterIp = "192.168.3.123";
			PrinterPort = 6101;
			PrinterCommand = "^XA^FO20,20^ADN,30,25^FDLot:_lot_^FS^FO20,80^ADN,30,25^FDTotal:_total_pcs^FS^XZ";
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
