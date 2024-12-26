using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Terumo
{
	public class MySetting
	{
		private const string FolderName = "config";
		private const string FileName = "config.ini";
		public static MySetting Setting = new MySetting();
		public string[] CommandKeys;
		public bool PositiveLogic;
		public string PortName;
		public int BaudRate;
		public string Parity;
		public int DataBit;
		public string StopBit;
		public string DeviceName;
		public MySetting()
		{
			CommandKeys = new string[] { "KEY=NUL", "Spare", "Spare", "Spare", "KEY=MEMORY", "KEY=A", "KEY=MAIN", "PLC COMMAND MODEL NO." }; //"PRC=1"
			PositiveLogic = true;
			PortName = "COM0";
			BaudRate = 9600;
			Parity = "None";
			DataBit = 8;
			StopBit = "One";
			DeviceName = "DIO000";
		}
		public void SaveSetting()
		{
			try
			{
				string pathFile = Path.Combine(FolderName, FileName);
				Global.Common.Save.WriteToXmlFile<MySetting>(pathFile, Setting, false);
			}
			catch (Exception ex)
			{
				// Log
				Global.Common.Log(LogType.FATAL, "User setting " + ex.Message);
			}
		}
		public void LoadSetting()
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
					Setting = (MySetting)Global.Common.Save.ReadFromXmlFile<MySetting>(pathFile);
					// Log
					Global.Common.Log(LogType.DEBUG, "Load user setting successfully: " + pathFile);
				}
				else
				{
					SaveSetting();
				}	
			}
			catch (Exception ex)
			{
				// Log
				Global.Common.Log(LogType.FATAL, "User setting " + ex.Message);
			}
		}
	}
}
