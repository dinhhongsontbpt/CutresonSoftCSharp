using Cutreson_Utility;

namespace Seoul_Software.Printer
{
	public class clsPrinter
	{
		private clsTcpClient _client;
		public clsPrinter()
		{
			_client = new clsTcpClient(MySetting.Setting.PrinterIp, MySetting.Setting.PrinterPort);
		}
		public bool Print(string lotNo, int total)
		{
			if (!MySetting.Setting.PrinterCommand.Contains(clsConfig.PrinterLotKey) || !MySetting.Setting.PrinterCommand.Contains(clsConfig.PrinterTotalKey))
			{
				clsMessageBox.Error("Please check _lot_ and _total_ in print command setting");
				return false;
			}
			string command = MySetting.Setting.PrinterCommand.Replace(clsConfig.PrinterLotKey, lotNo).Replace(clsConfig.PrinterTotalKey, total.ToString());
			if (_client.SendMessage(command))
			{
				Global.Log.Operation($"Print lot:{lotNo},total:{total}");
				return true;
			}
			Global.Log.Alarm($"Can't print lot:{lotNo},total:{total}");
			return false;
		}
	}
}
