using Cutreson_Utility;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Seoul_Software.Alarm
{
	public partial class frmAlarm : Form
	{
		private Thread thread;
		private AlarmModel alarm;
		public frmAlarm()
		{
			InitializeComponent();
			clsInvokeControl.ControlTextInvoke(lbAlarm, string.Empty);
			thread = new Thread(Blink);
			thread.IsBackground = true;
			thread.Start();
		}
		public void ViewAlarm(int index)
		{
			if(Global.CurrentAlarms.Count > index)
			{
				ViewAlarm(Global.CurrentAlarms[index]);
			}
		}
		public void ViewAlarm(AlarmModel _alarm)
		{
			this.alarm = _alarm;
			clsInvokeControl.ControlTextInvoke(txtErrorCode, alarm.Code);
			clsInvokeControl.ControlTextInvoke(txtUnit, alarm.Unit);
			clsInvokeControl.ControlTextInvoke(txtDescription, alarm.Description);
			clsInvokeControl.ControlTextInvoke(lbErrorHelp, alarm.Help);
			clsInvokeControl.ControlTextInvoke(lbAlarm, alarm.Text);
			if (imageBox.InvokeRequired)
			{
				imageBox.Invoke(new Action(() => {
					imageBox.Image = alarm.Image;
					imageBox.SizeMode = Cutreson_UserControl.ImageBox.ImageBoxSizeMode.Fit;
					imageBox.SizeMode = Cutreson_UserControl.ImageBox.ImageBoxSizeMode.Normal;
				}));
			}
			else
			{
				imageBox.Image = alarm.Image;
				imageBox.SizeMode = Cutreson_UserControl.ImageBox.ImageBoxSizeMode.Fit;
				imageBox.SizeMode = Cutreson_UserControl.ImageBox.ImageBoxSizeMode.Normal;
			}
		}
		public void UpdateList()
		{
			if(listBox.InvokeRequired) listBox.Invoke(new Action(() => UpdateList())); 
			else
			{
				listBox.Items.Clear();
				foreach(var item in Global.CurrentAlarms)
				{
					listBox.Items.Add($"[{item.Code}]{item.Text}");
				}
			}
			if(Global.CurrentAlarms.Count == 0)
			{
				ViewAlarm(new AlarmModel());
			}
			clsInvokeControl.ControlTextInvoke(lbAlarmCount, $"Current Error{'\n'}Total: {Global.CurrentAlarms.Count}");
		}

		private bool blink;
		private void Blink()
		{
			while (true)
			{
				if (alarm != null)
				{
					if(blink)
					{
						if (alarm.Level == Log.eLogLevel.WARNING)
						{
							clsInvokeControl.ControlBackColorInvoke(lbAlarm, Color.Yellow);
						}
						else
						{
							clsInvokeControl.ControlBackColorInvoke(lbAlarm, Color.Red);
						}
						blink = false;
					}
					else
					{
						clsInvokeControl.ControlBackColorInvoke(lbAlarm, Color.White);
						blink = true;
					}
				}
				Thread.Sleep(500);
			}
		}

		public void SetAlarm(AlarmModel alarm)
		{
			if (alarm == null) return;
			this.alarm = alarm;
			clsInvokeControl.ControlTextInvoke(lbAlarm, alarm.Text);
		}

		private void listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ViewAlarm(listBox.SelectedIndex);
		}
	}
}
