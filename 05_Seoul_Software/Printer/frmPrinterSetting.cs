using Cutreson_Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seoul_Software.Printer
{
	public partial class frmPrinterSetting : Form
	{
		public frmPrinterSetting()
		{
			InitializeComponent();
			Init();
		}
		private void Init()
		{
			txtIp.Text = MySetting.Setting.PrinterIp;
			txtPort.Value = MySetting.Setting.PrinterPort;
			txtCommand.Text = MySetting.Setting.PrinterCommand;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			if(!txtCommand.Text.Contains(clsConfig.PrinterLotKey) || !txtCommand.Text.Contains(clsConfig.PrinterTotalKey))
			{
				clsMessageBox.Error("Please check _lot_ and _total_ in command");
				return;
			}
			MySetting.Setting.PrinterIp = txtIp.Text;
			MySetting.Setting.PrinterPort = (int)txtPort.Value;
			MySetting.Setting.PrinterCommand = txtCommand.Text;
			MySetting.Setting.SaveSetting();
			Global.Log.Operation($"Save printer setting successfully, IP={txtIp.Text}, Port:{txtPort.Value}, Command: {txtCommand.Text}");
			clsMessageBox.Info("Save printer setting successfully");
		}
	}
}
