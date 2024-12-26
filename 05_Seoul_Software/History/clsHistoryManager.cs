using Cutreson_Utility;
using Seoul_Software.Alarm;
using Seoul_Software.Scanner;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Seoul_Software.History
{
	public class clsHistoryManager
	{
		public static void AddAlarm(AlarmModel alarm)
		{
			if (Global.AlarmHistory.Count > MySetting.Setting.MaxAlarm)
			{
				Global.AlarmHistory.RemoveRange(MySetting.Setting.MaxAlarm - 1, Global.AlarmHistory.Count - MySetting.Setting.MaxAlarm + 1);
			}
			alarm.Time = DateTime.Now;
			Global.AlarmHistory.Insert(0, alarm);
			clsHistoryManager.SaveAlarm();
		}
		public static void AddError(AlarmModel error)
		{
			if (Global.ErrorHistory.Count > MySetting.Setting.MaxError)
			{
				Global.ErrorHistory.RemoveRange(MySetting.Setting.MaxError - 1, Global.ErrorHistory.Count - MySetting.Setting.MaxError + 1);
			}
			error.Time = DateTime.Now;
			Global.ErrorHistory.Insert(0, error);
			clsHistoryManager.SaveError();
		}
		public static void SaveAlarm()
		{
			try
			{
				string pathFile = Path.Combine(clsConfig.DatabasePathFolder, clsConfig.WarningHistoryFile);
				clsSave.WriteToJsonFile<List<AlarmModel>>(pathFile, Global.AlarmHistory, false);
			}
			catch (Exception ex)
			{
				Global.Log.Error("Save history: " + ex.Message);
			}
		}
		public static void SaveError()
		{
			try
			{
				string pathFile = Path.Combine(clsConfig.DatabasePathFolder, clsConfig.AlarmHistoryFile);
				clsSave.WriteToJsonFile<List<AlarmModel>>(pathFile, Global.ErrorHistory, false);
			}
			catch (Exception ex)
			{
				Global.Log.Error("Save history: " + ex.Message);
			}
		}
		public static void LoadAlarm()
		{
			if (!Directory.Exists(clsConfig.DatabasePathFolder))
			{
				Directory.CreateDirectory(clsConfig.DatabasePathFolder);
			}
			try
			{
				string pathFile = Path.Combine(clsConfig.DatabasePathFolder, clsConfig.WarningHistoryFile);
				if (File.Exists(pathFile))
				{
					Global.AlarmHistory = (List<AlarmModel>)clsSave.ReadFromJsonFile<List<AlarmModel>>(pathFile);
				}
				else
				{
					SaveAlarm();
				}
			}
			catch (Exception ex)
			{
				Global.Log.Error("Load history: " + ex.Message);
			}
		}
		public static void LoadError()
		{
			if (!Directory.Exists(clsConfig.DatabasePathFolder))
			{
				Directory.CreateDirectory(clsConfig.DatabasePathFolder);
			}
			try
			{
				string pathFile = Path.Combine(clsConfig.DatabasePathFolder, clsConfig.AlarmHistoryFile);
				if (File.Exists(pathFile))
				{
					Global.ErrorHistory = (List<AlarmModel>)clsSave.ReadFromJsonFile<List<AlarmModel>>(pathFile);
				}
				else
				{
					SaveAlarm();
				}
			}
			catch (Exception ex)
			{
				Global.Log.Error("Load history: " + ex.Message);
			}
		}
	}
}
