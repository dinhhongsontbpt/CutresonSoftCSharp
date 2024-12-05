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
			if (!MySetting.Setting.PrinterCommand1.Contains(clsConfig.Cmd1PrinterLotKey) || !MySetting.Setting.PrinterCommand1.Contains(clsConfig.Cmd1PrinterTotalKey))
			{
				clsMessageBox.Error("Please check _lot_ and _total_ in print command setting");
				return false;
			}
			string command = MySetting.Setting.PrinterCommand1.Replace(clsConfig.Cmd1PrinterLotKey, lotNo).Replace(clsConfig.Cmd1PrinterTotalKey, total.ToString());
			if (_client.SendMessage(command))
			{
				Global.Log.Operation($"Print lot:{lotNo},total:{total}");
				return true;
			}
			Global.Log.Error($"Can't print lot:{lotNo},total:{total}");
			return false;
		}
		public bool Print(string lotNo1, int total1, string lotNo2, int total2)
		{
			total2 = 5 - total1;

			if (!MySetting.Setting.PrinterCommand2.Contains(clsConfig.Cmd2PrinterLotKey1)
				|| !MySetting.Setting.PrinterCommand2.Contains(clsConfig.Cmd2PrinterLotKey2)
				|| !MySetting.Setting.PrinterCommand2.Contains(clsConfig.Cmd2PrinterIndexKey1)
				|| !MySetting.Setting.PrinterCommand2.Contains(clsConfig.Cmd2PrinterIndexKey2)
				)
			{
				clsMessageBox.Error("Please check _lot1_, _lot2_, _index1_, _index2_ in print command setting");
				return false;
			}

			string index1 = "0000", index2 = "0000";
			if(total1 == 1)
			{
				index1 = "1";
				index2 = "2345";
			}
			if (total1 == 2)
			{
				index1 = "12  ";
				index2 = "345 ";
			}
			if (total1 == 3)
			{
				index1 = "123 ";
				index2 = "45  ";
			}
			if (total1 == 4)
			{
				index1 = "1234";
				index2 = "5   ";
			}

			string command = MySetting.Setting.PrinterCommand2
				.Replace(clsConfig.Cmd2PrinterLotKey1, lotNo1)
				.Replace(clsConfig.Cmd2PrinterLotKey2, lotNo2)
				.Replace(clsConfig.Cmd2PrinterIndexKey1, index1)
				.Replace(clsConfig.Cmd2PrinterIndexKey2, index2);
			if (_client.SendMessage(command))
			{
				Global.Log.Operation($"Print lot 1:{lotNo1},total:{total1};lot 2:{lotNo2},total:{total2}");
				return true;
			}
			Global.Log.Error($"Can't print lot 1:{lotNo1},total:{total1};lot 2:{lotNo2},total:{total2}");
			return false;
		}
	}
}
