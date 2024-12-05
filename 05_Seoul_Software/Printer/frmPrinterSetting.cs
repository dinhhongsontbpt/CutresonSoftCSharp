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
			txtCommand1.Text = MySetting.Setting.PrinterCommand1;
			txtCommand2.Text = MySetting.Setting.PrinterCommand2;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			if(!txtCommand1.Text.Contains(clsConfig.Cmd1PrinterLotKey) || !txtCommand1.Text.Contains(clsConfig.Cmd1PrinterTotalKey))
			{
				clsMessageBox.Error("Please check _lot_ and _total_ in command");
				return;
			}
			MySetting.Setting.PrinterIp = txtIp.Text;
			MySetting.Setting.PrinterPort = (int)txtPort.Value;
			MySetting.Setting.PrinterCommand1 = txtCommand1.Text;
			MySetting.Setting.PrinterCommand2 = txtCommand2.Text;
			MySetting.Setting.SaveSetting();
			Global.Log.Operation($"Save printer setting successfully, IP={txtIp.Text}, Port:{txtPort.Value}, Command: {txtCommand1.Text}");
			clsMessageBox.Info("Save printer setting successfully");
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			if(txtTotal1.Value == 5)
			{
				clsPrinter printer = new clsPrinter();
				printer.Print(txtLotNo1.Text, (int)txtTotal1.Value);
			}
			else
			{
				clsPrinter printer = new clsPrinter();
				printer.Print(txtLotNo1.Text, (int)txtTotal1.Value, txtLotNo2.Text, (int)txtTotal2.Value);
			}	
		}

		private void txtTotal1_ValueChanged(object sender, EventArgs e)
		{
			txtTotal2.Value = 5 - txtTotal1.Value;
		}

		private void txtTotal2_ValueChanged(object sender, EventArgs e)
		{
			txtTotal1.Value = 5 - txtTotal2.Value;
		}
	}
}
