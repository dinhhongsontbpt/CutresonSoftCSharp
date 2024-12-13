using Cutreson_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Terumo
{
	public class ClassCommon
	{
		public static ClassInvokeControl InvokeControl = new ClassInvokeControl();
		public ControlForm ControlForm = new ControlForm();
		public ClassSave Save = new ClassSave();
		#region Logger
		internal static ClassLogger logger = new ClassLogger();
		private ListBox listBoxViewLog;
		//
		// Summary:
		//     Truyền ListBox để tự động lưu Log
		public ListBox ListBoxViewLog
		{
			get
			{
				return listBoxViewLog;
			}
			set
			{
				listBoxViewLog = value;
				logger.ListBoxViewLog = value;
				//Thêm sự kiện
				ListBoxViewLog.DrawMode = DrawMode.OwnerDrawFixed;
				ListBoxViewLog.DrawItem += logger.LstbLog_DrawItem;
				//Read log
				logger.ReadRecentLog();
			}
		}
		//
		// Summary:
		//     Thêm 1 dòng Log mới bên dưới File Log. Tự động lưu lại File Log sau 20ms
		//
		// Parameters:
		//   logType:
		//
		//   strLog:
		public void Log(LogType logType, string strLog)
		{
			logger.SaveLog(logType, strLog);
		}
		public void LogDebug(string strLog)
		{
			Log(LogType.DEBUG, strLog);
		}
		public void LogInfor(string strLog)
		{
			Log(LogType.INFO, strLog);
		}
		public void LogWarning(string strLog)
		{
			Log(LogType.WARNING, strLog);
		}
		public void LogError(string strLog)
		{
			Log(LogType.ERROR, strLog);
		}
		public void LogFatal(string strLog)
		{
			Log(LogType.FATAL, strLog);
		}
		public void Dispose()
		{
			logger.Dispose();
		}

		#endregion

	}
}
