using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Terumo
{
	public partial class FrmCommandSetting : Form
	{
		public FrmCommandSetting()
		{
			InitializeComponent();
			Init();
		}
		List<TextBox> _list = new List<TextBox>();
		private void Init()
		{
			tbInput.RowCount = Global.InputBitCount;
			tbLampInput.RowCount = Global.InputBitCount;
			tbInput.RowStyles.Clear();
			tbLampInput.RowStyles.Clear();
			for (int i = 0; i < Global.InputBitCount; i++)
			{
				tbInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / Global.InputBitCount));
				tbLampInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / Global.InputBitCount));
			}

			for (int i = 0; i < Global.InputBitCount; i++)
			{
				TextBox textBox = new TextBox();
				textBox.Text = Global.CommandKeys[i];
				textBox.Dock = DockStyle.Fill;
				textBox.TextAlign = HorizontalAlignment.Center;
				textBox.Multiline = true;
				tbInput.Controls.Add(textBox);
				_list.Add(textBox);

				Label lamp = new Label();
				lamp.Dock = DockStyle.Fill;
				lamp.TextAlign = ContentAlignment.MiddleCenter;
				lamp.Text = i.ToString();
				tbLampInput.Controls.Add(lamp);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			MySetting.Setting.CommandKeys = new string[Global.InputBitCount];
			for (int i = 0; i < Global.InputBitCount; i++)
			{
				MySetting.Setting.CommandKeys[i] = _list[i].Text;
			}
			MySetting.Setting.SaveSetting();
			Application.Restart();
		}
	}
}
