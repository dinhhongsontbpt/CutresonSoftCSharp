using Cutreson_Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Terumo
{
	public enum LogType
	{
		DEBUG,
		INFO,
		WARNING,
		ERROR,
		FATAL
	}

	public class ClassLogger : IDisposable
	{
		private readonly object _LOCK = new object();
		private Queue<string> _logQueue = new Queue<string>();
		private bool isDispose;
		internal ListBox ListBoxViewLog = new ListBox();
		private const int ListBoxRowCount = 1000;
		private const string LogFolder = "Log/Equipment";
		private string LogFileName
		{
			get
			{
				return "Log_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
			}
		}
		internal ClassLogger()
		{
			if (!Directory.Exists(LogFolder))
			{
				Directory.CreateDirectory(LogFolder);
			}
			if (!Directory.Exists("Log\\Data"))
			{
				Directory.CreateDirectory("Log\\Data");
			}
			//Draw
			ListBoxViewLog.DrawMode = DrawMode.OwnerDrawFixed;
			ListBoxViewLog.DrawItem += LstbLog_DrawItem;
			//Auto delete
			AutoDeleteLog(LogFolder, 30);
			AutoDeleteLog("Log\\Data", 100);
			//Thread
			Thread thread = new Thread((ThreadStart)delegate
			{
				SaveLogToFile();
			});
			thread.IsBackground = true;
			thread.Name = "SaveLogStringToFile";
			thread.Start();
		}
		//Draw Item
		public void LstbLog_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index == -1) return;
			var item = ListBoxViewLog.Items[e.Index] as ListBoxItem;

			if (item != null)
			{
				e.Graphics.DrawString(
					item.Text,
					e.Font,
					new SolidBrush(item.Color),
					e.Bounds);
			}
		}
		//Get log type from string
		private LogType GetLogType(string text)
		{
			if (text.Contains("INFO")) return LogType.INFO;
			else if (text.Contains("WARNING")) return LogType.WARNING;
			else if (text.Contains("ERROR")) return LogType.ERROR;
			else if (text.Contains("FATAL")) return LogType.FATAL;
			else return LogType.DEBUG;
		}
		//Get color
		private Color GetLogColor(string text)
		{
			LogType type = GetLogType(text);
			switch (type)
			{
				case LogType.DEBUG:
					return Color.White;
				case LogType.INFO:
					return Color.Lime;
				case LogType.WARNING:
					return Color.Orange;
				case LogType.ERROR:
					return Color.Red;
				case LogType.FATAL:
					return Color.DarkRed;
				default:
					return Color.White;
			}
		}
		//Read log
		public void ReadRecentLog()
		{
			DateTime currentDate = DateTime.Now;
			string logFilePath = Path.Combine(LogFolder, LogFileName);
			if (File.Exists(logFilePath))
			{
				string[] logLines = File.ReadAllLines(logFilePath);
				foreach (string logLine in logLines)
				{
					SetLogView(logLine);
				}
			}
		}
		private void SaveLogToFile()
		{
			if (Config.IsSaveLog)
			{
				while (!isDispose)
				{
					if (_logQueue.Count > 0)
					{
						lock (_LOCK)
						{
							string strLog = _logQueue.Dequeue();
							try
							{
								string fullPath = Path.Combine(LogFolder, LogFileName);
								if (!Directory.Exists(LogFolder))
								{
									Directory.CreateDirectory(LogFolder);
								}

								if (!File.Exists(fullPath))
								{
									using (File.Create(fullPath))
									{
									}
								}

								WriteFile(fullPath, strLog);
							}
							catch
							{
							}
						}
					}
					Thread.Sleep(20);
				}
			}
		}
		private void WriteFile(string filename, string strLog)
		{
			using (StreamWriter streamWriter = File.AppendText(filename))
			{
				streamWriter.WriteLine(strLog);
			}
		}
		private void SetLogView(string log)
		{
			if (ListBoxViewLog == null)
			{
				return;
			}

			if (ListBoxViewLog.InvokeRequired)
			{
				ListBoxViewLog.Invoke((Action)delegate
				{
					Color itemColor = GetLogColor(log);
					if (!Config.IsShowTimeLog)
					{
						log = log.Split(']')[1].Trim();
					}
					ListBoxItem item = new ListBoxItem(log, itemColor);
					ListBoxViewLog.Items.Insert(0, item);
					if (ListBoxViewLog.Items.Count > ListBoxRowCount)
					{
						ListBoxViewLog.Items.RemoveAt(ListBoxViewLog.Items.Count - 1);
					}
				});
			}
			else
			{
				Color itemColor = GetLogColor(log);
				if (!Config.IsShowTimeLog)
				{
					log = log.Split(']')[1].Trim();
				}
				ListBoxItem item = new ListBoxItem(log, itemColor);
				ListBoxViewLog.Items.Insert(0, item);
				if (ListBoxViewLog.Items.Count > ListBoxRowCount)
				{
					ListBoxViewLog.Items.RemoveAt(ListBoxViewLog.Items.Count - 1);
				}
			}
		}
		internal void SaveLog(LogType logType, string strLog)
		{
			lock (_LOCK)
			{
				string text = DateTime.Now.ToString("HH:mm:ss.fff") + " [" + logType.ToString() + "] " + strLog;
				_logQueue.Enqueue(text);
				SetLogView(text);
			}
		}
		private static void AutoDeleteLog(string folder, int saveDay)
		{
			string[] filePaths = Directory.GetFiles(Path.Combine(folder), "*.txt", SearchOption.TopDirectoryOnly);
			if (filePaths.Length == 0) return;
			DateTime testDate = DateTime.Now.AddDays(-saveDay);
			foreach (string path in filePaths)
			{
				FileInfo fileInfo = new FileInfo(path);
				DateTime fileAge = fileInfo.LastWriteTime;
				if (fileAge < testDate)
				{
					File.Delete(fileInfo.FullName);
				}
			}
		}
		public void Dispose()
		{
			isDispose = true;
		}
	}
	public class ListBoxItem
	{
		public ListBoxItem(string text, Color color)
		{
			this.Text = text;
			this.Color = color;
		}
		public string Text;
		public Color Color;
	};
}
