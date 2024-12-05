using Cutreson_Utility;
using Seoul_Software.MachineMonitor;
using Seoul_Software.OperatingEvent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seoul_Software
{
    public partial class frmMachineMonitor : Form
    {
        public frmMachineMonitor()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
			Global.PLC.ControlMonitorEvent += PLC_ControlMonitorEvent;
			Global.PLC.InitialControlMonitor();
        }

		private void PLC_ControlMonitorEvent(object sender, ControlMonitorParam e)
		{
			try
			{
				ControlMonitorModel controlMonitor = Global.ControlMonitors.FirstOrDefault(a => a.Index == e.Index && a.Value == e.Value);
				if (controlMonitor != null)
				{
					Control[] controls = tableLayoutPanelMain.Controls.Find(controlMonitor.ControlName, true);
					if (controls.Length == 1)
					{
						ucMachineMonitor uc = (ucMachineMonitor)controls[0];
						uc.SetMessage(controlMonitor.Message, controlMonitor.HexCode);
					}
				}
			}
			catch (Exception ex) 
			{ 
				Global.Log.Error("Control monitor: " + ex.Message);
			}
		}
	}
}
