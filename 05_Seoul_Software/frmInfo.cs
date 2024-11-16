using Cutreson_Utility;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Seoul_Software
{
	public partial class frmInfo : Form
	{
		public PrivateFontCollection FontCollection = new PrivateFontCollection();
		Font dotMatrixFont;
		public frmInfo()
		{
			InitializeComponent();
			Init();
		}
		private void Init()
		{
			//Font
			//AddToFontCollection(Path.Combine(Application.StartupPath, "Dotmatrx.ttf"));
			//dotMatrixFont = new Font(FontCollection.Families[0], 14, FontStyle.Bold);
			//lbStartupDate.Font = dotMatrixFont;
			//lbStartupTime.Font = dotMatrixFont;
			//lbStopDate.Font = dotMatrixFont;	
			//lbStopTime.Font = dotMatrixFont;
			//lbAlarmDate.Font = dotMatrixFont;
			//lbAlarmTime.Font = dotMatrixFont;
			//Time open
			lbStartupDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
			lbStartupTime.Text = DateTime.Now.ToString("HH:mm:ss");
			lbStartDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
			lbStartTime.Text = DateTime.Now.ToString("HH:mm:ss");
			lbStopDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
			lbStopTime.Text = DateTime.Now.ToString("HH:mm:ss"); ;

			Global.PLC.PropertyChanged += PLC_PropertyChanged;
		}

		private void PLC_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if(e.PropertyName == "AutoRunning")
			{
				if(Global.PLC.AutoRunning)
				{
					clsInvokeControl.ControlTextInvoke(lbStartDate, DateTime.Now.ToString("yyyy/MM/dd"));
					clsInvokeControl.ControlTextInvoke(lbStartTime, DateTime.Now.ToString("HH:mm:ss"));

				}
				else
				{
					clsInvokeControl.ControlTextInvoke(lbStopDate, DateTime.Now.ToString("yyyy/MM/dd"));
					clsInvokeControl.ControlTextInvoke(lbStopTime, DateTime.Now.ToString("HH:mm:ss"));
				}
			}
			if (e.PropertyName == "AlarmSignal")
			{
				if (Global.PLC.AutoRunning)
				{
					clsInvokeControl.ControlTextInvoke(lbAlarmDate, DateTime.Now.ToString("yyyy/MM/dd"));
					clsInvokeControl.ControlTextInvoke(lbAlarmTime, DateTime.Now.ToString("HH:mm:ss"));

				}
			}
		}

		public FontFamily AddToFontCollection(string path)
			=> AddToFontCollection(File.ReadAllBytes(path));
		public FontFamily AddToFontCollection(byte[] fontBytes)
		{
			var handle = System.Runtime.InteropServices.GCHandle.Alloc(fontBytes, System.Runtime.InteropServices.GCHandleType.Pinned);
			IntPtr pointer = handle.AddrOfPinnedObject();
			try
			{
				FontCollection.AddMemoryFont(pointer, fontBytes.Length);
			}
			finally
			{
				handle.Free();
			}
			return FontCollection.Families.LastOrDefault();
		}
	}
}
