using Cutreson_Utility;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Seoul_Software.MachineMonitor
{
	public partial class ucMachineMonitor : UserControl
	{
		private Color defaultBackColor;
		public ucMachineMonitor()
		{
			InitializeComponent();
			label.Text = "N/A";
		}
		public void SetMessage(string message, string hexCode)
		{
			Color color = ColorTranslator.FromHtml(hexCode);
			clsInvokeControl.ControlBackColorInvoke(label, color);
			clsInvokeControl.ControlTextInvoke(label, message);
		}

		[Category("Custom Properties")]
		[Description("Sets the font of the label.")]
		public Font LabelFont
		{
			get => label.Font;
			set => label.Font = value;
		}

		[Category("Custom Properties")]
		[Description("Sets the background color of the label.")]
		public Color LabelBackColor
		{
			get => label.BackColor;
			set => label.BackColor = value;
		}

		[Category("Custom Properties")]
		[Description("Sets the text color of the label.")]
		public Color LabelForeColor
		{
			get => label.ForeColor;
			set => label.ForeColor = value;
		}
	}
}
