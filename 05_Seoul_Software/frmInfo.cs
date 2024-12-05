using Cutreson_Utility;
using Seoul_Software.SQL;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
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
			lbStartupDate.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
			lbStartDate.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
			lbStopDate.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

			using (SeoulDbContext db = new SeoulDbContext())
			{
				Global.TotalLot = db.Lots.LongCount();
				Global.TotalRing = db.Rings.LongCount();
				Global.TotalChipLed = db.Rings.Any() ? db.Rings.Sum(r => (long)r.Total) : 0;
				UpdateData();
			}


			Global.PLC.PropertyChanged += PLC_PropertyChanged;
		}
		public void UpdateData()
		{
			clsInvokeControl.ControlTextInvoke(lbTotalLot, Global.TotalLot.ToString());
			clsInvokeControl.ControlTextInvoke(lbTotalRing, Global.TotalRing.ToString());
			clsInvokeControl.ControlTextInvoke(lbTotalChipLed, Global.TotalChipLed.ToString());
			Global.PLC.WriteCounter();
		}
		private void PLC_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if(e.PropertyName == "AutoRunning")
			{
				if(Global.PLC.AutoRunning)
				{
					clsInvokeControl.ControlTextInvoke(lbStartDate, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

				}
				else
				{
					clsInvokeControl.ControlTextInvoke(lbStopDate, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
				}
			}
			if (e.PropertyName == "AlarmSignal")
			{
				if (Global.PLC.AutoRunning)
				{
					clsInvokeControl.ControlTextInvoke(lbAlarmDate, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

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
