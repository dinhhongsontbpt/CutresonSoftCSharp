using _07_Kefico_LeakCurrentSystem.Login;
using Cutreson_Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Kefico_LeakCurrentSystem
{
	public class MySetting
	{
		private const string FolderName = "config";
		private const string FileName = "config.ini";
		public string Title;
		public string CompanyName;
		public string LogPathFolder;
		public string LogFileName;
		
		public string PlcIpAddress;
		public int PlcPort;
		//Login
		public string OperatorPassword;
		public string EngineerPassword;
		public string AdminPassword;
		public eRole AutoLoginAs;
	
		public static MySetting Setting = new MySetting();

		public MySetting()
		{
			Title = "Leak Current System";
			CompanyName = "Cutreson Co., Ltd";
			LogFileName = "log.txt";
			LogPathFolder = "log";
			PlcIpAddress = "192.168.3.28";
			PlcPort = 6666;
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
