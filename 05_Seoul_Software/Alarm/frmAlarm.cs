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
		private bool blink;
		private void Blink()
		{
			while (true)
			{
				if (alarm != null)
				{
					if(blink)
					{
						if (alarm.AlarmLevel == Log.eLogLevel.WARNING)
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
	}
}
