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

namespace _07_Kefico_LeakCurrentSystem.PLC
{
	public partial class frmPlcSetting : Form
	{
		public frmPlcSetting()
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
			Global.Log.Debug($"Save PLC setting IP:{txtIp.Text},Port:{txtPort.Value}");
			clsMessageBox.Info($"Save PLC setting IP:{txtIp.Text},Port:{txtPort.Value}");
		}
	}
}
