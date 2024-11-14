using ComponentFactory.Krypton.Toolkit;
using Cutreson_Utility;
using Seoul_Software.Alarm;
using Seoul_Software.Printer;
using Seoul_Software.Scanner;
using System;
using System.Drawing;
using System.Linq;

namespace Seoul_Software
{
	public partial class MainWindow : KryptonForm
    {
        private frmAlarm frmAlarm;
		public MainWindow()
        {
            InitializeComponent();
			Init();
        }
        private void Init()
        {
            //Info
            ucDateTime.IsRun = true;
            ucPcInfo.IsRun = true;
            //Load setting
            MySetting.Setting.LoadSetting();
            //Log
            Global.Log.ListBoxViewOperation = listBoxEventLog;
            Global.Log.ListBoxViewAlarm = listBoxAlarm;
			Global.Log.Operation("Open software");
			//Load excel config
            if(clsConfig.LoadExcelConfig())
            {
                Global.Log.Operation($"Load {clsConfig.ConfigExcelFile} successfully");
            }
            else
            {
                Global.Log.Alarm($"Can't load {clsConfig.ConfigExcelFile}");
            }
            //Alarm
            frmAlarm = new frmAlarm();
			clsControlForm.LoadFormInPanel(panelAlarm, frmAlarm);
			ShowAlarm(false);
			//Load data
			clsBarcodeManager.Load();
			//PLC
			Global.PLC = new clsControlPLC();
            Global.PLC.PropertyChanged += ControlPLC_PropertyChanged;
			Global.PLC.AlarmEvent += PLC_AlarmEvent;
            //Home
            frmMachineMonitor frmMachineMonitor = new frmMachineMonitor();
            clsControlForm.LoadFormInPanel(panelMain, frmMachineMonitor);
			//Vision Monitor
			frmVisionMonitor frmVisionMonitor = new frmVisionMonitor();
			clsControlForm.LoadFormInPanel(panelVisionMonitor, frmVisionMonitor);
			//Scanner
			frmBarcodes frmScanner = new frmBarcodes();
            clsControlForm.LoadFormInControl(groupBoxScanner, frmScanner);
            //////////////////////////////////////////////////////////////////////////
            Global.Log.Operation("Open software complete");
        }

		private void PLC_AlarmEvent(object sender, int e)
		{
            AlarmModel alarm = Global.Alarms.FirstOrDefault(a => a.Index == e);
            if(alarm != null)
            {
                if(clsConfig.ShowAlarmDevice)
                {
					Global.Log.Alarm($"[L{4000 + alarm.Index}]{alarm.Text}", alarm.AlarmLevel);
				}
                else
                {
					Global.Log.Alarm(alarm.Text, alarm.AlarmLevel);
				}
			}
            else
            {
                Global.Log.Alarm("Alarm not definition");
                alarm = new AlarmModel();
                alarm.Text = "Alarm not definition";
                alarm.AlarmLevel = Log.eLogLevel.ERROR;
			}
			frmAlarm.SetAlarm(alarm);
		}

        private void ShowAlarm(bool show)
        {
            if(tableLayoutMachineMobitor.InvokeRequired)
            {
                tableLayoutMachineMobitor.Invoke((Action)delegate
                {
					if (show)
					{
						tableLayoutMachineMobitor.RowStyles[1].Height = 40;
					}
					else
					{
						tableLayoutMachineMobitor.RowStyles[1].Height = 0;
					}
				});
            }
           else
            {
				if (show)
				{
					tableLayoutMachineMobitor.RowStyles[1].Height = 40;
				}
				else
				{
					tableLayoutMachineMobitor.RowStyles[1].Height = 0;
				}
			}
        }
		private void ControlPLC_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "PlcAlive")
            {
                if (Global.PLC.PlcAlive)
                {
                    lampPlcAlive.BackColor = Color.Lime;
                }
                else
                {
                    lampPlcAlive.BackColor = Color.Red;
				}
            }
			if (e.PropertyName == "AlarmSignal")
			{
				if (Global.PLC.AlarmSignal)
				{
                    ShowAlarm(true);
				}
				else
				{
					ShowAlarm(false);
				}
			}
		}

		private void btnPrinter_Click(object sender, EventArgs e)
		{
            frmPrinterSetting frmPrinterSetting = new frmPrinterSetting();
            frmPrinterSetting.ShowDialog();
		}
	}
}
