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

namespace Seoul_Software.PLC
{
	public partial class FrmPlcSetting : Form
	{
		public FrmPlcSetting()
		{
			InitializeComponent();
			txtIp.Text = MySetting.Setting.PlcIpAddress;
			txtPort.Value = MySetting.Setting.PlcPort;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			MySetting.Setting.PlcIpAddress = txtIp.Text;
			MySetting.Setting.PlcPort = (int)txtPort.Value;
			MySetting.Setting.SaveSetting();
			Global.Log.Operation($"Save PLC setting IP:{txtIp.Text},Port:{txtPort.Value}");
			clsMessageBox.Info($"Save PLC setting IP:{txtIp.Text},Port:{txtPort.Value}");
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void txtIp_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtPort_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
