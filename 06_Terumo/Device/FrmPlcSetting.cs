using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Terumo.Device
{
	public partial class FrmPlcSetting : Form
	{
		public FrmPlcSetting()
		{
			InitializeComponent();
			Init();
		}
		private void Init()
		{
			var ports = SerialPort.GetPortNames();
			if (ports.Length > 0)
			{
				cboPortName.DataSource = ports;
			}
			else
			{
				cboPortName.Items.Add("Null");
			}

			cboPortName.Text = MySetting.Setting.PortName;
			cboBaudRate.Text = MySetting.Setting.BaudRate.ToString();
			cboParity.Text = MySetting.Setting.Parity;
			cboDataBit.Text = MySetting.Setting.DataBit.ToString();
			cboStopBit.Text = MySetting.Setting.StopBit;
			cbPositiveLogic.Checked = MySetting.Setting.PositiveLogic;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			MySetting.Setting.PortName = cboPortName.Text;
			MySetting.Setting.BaudRate = Convert.ToInt32(cboBaudRate.Text);
			MySetting.Setting.Parity = cboParity.Text;
			MySetting.Setting.DataBit = Convert.ToInt32(cboDataBit.Text);
			MySetting.Setting.StopBit = cboStopBit.Text;
			MySetting.Setting.PositiveLogic = cbPositiveLogic.Checked;
			MySetting.Setting.SaveSetting();
			Application.Restart();
		}
	}
}
