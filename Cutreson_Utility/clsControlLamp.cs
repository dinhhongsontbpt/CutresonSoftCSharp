using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cutreson_Utility
{
	public class clsControlLamp
	{
		public static void ControlLamp(Label lamp, bool value)
		{
			if(value)
			{
				clsInvokeControl.ControlBackColorInvoke(lamp, Color.Lime);
			}
			else
			{
				clsInvokeControl.ControlBackColorInvoke(lamp, Color.Red);
			}
		}
	}
}
