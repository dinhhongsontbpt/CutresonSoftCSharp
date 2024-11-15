using ComponentFactory.Krypton.Toolkit;
using Cutreson_Utility;
using Seoul_Software.Alarm;
using Seoul_Software.OperatingEvent;
using Seoul_Software.PLC;
using Seoul_Software.Printer;
using Seoul_Software.Scanner;
using System;
using System.Diagnostics;
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
			Global.PLC.OperatingEvent += PLC_OperatingEvent;
            //Home
            frmMachineMonitor frmMachineMonitor = new frmMachineMonitor();
            clsControlForm.LoadFormInPanel(panelMain, frmMachineMonitor);
			//Vision monitor
			frmVisionMonitor frmVisionMonitor = new frmVisionMonitor();
			clsControlForm.LoadFormInPanel(panelVisionMonitor, frmVisionMonitor);
			//Scanner
			frmBarcodes frmScanner = new frmBarcodes();
            clsControlForm.LoadFormInControl(groupBoxScanner, frmScanner);
            //////////////////////////////////////////////////////////////////////////
            Global.Log.Operation("Open software complete");
        }

		private void PLC_OperatingEvent(object sender, OperatingEventParam e)
		{
			OperatingEventModel operatingEvent = Global.OperatingEvents.FirstOrDefault(a => a.Index == e.Index);
			if (operatingEvent != null)
			{
				if (e.IsOn && operatingEvent.MessageOn.ToUpper() != clsConfig.StringNotUse.ToUpper())
                {
					if (clsConfig.ShowAlarmDevice)
					{
						Global.Log.Operation($"[{clsConfig.OperatingEventDeviceType}{clsConfig.OperatingEventStartAddress + operatingEvent.Index}]{operatingEvent.MessageOn}");
					}
					else
					{
						Global.Log.Operation($"{operatingEvent.MessageOn}");
					}
				}
				if (!e.IsOn && operatingEvent.MessageOff.ToUpper() != clsConfig.StringNotUse.ToUpper())
				{
					if (clsConfig.ShowAlarmDevice)
					{
						Global.Log.Operation($"[{clsConfig.OperatingEventDeviceType}{clsConfig.OperatingEventStartAddress + operatingEvent.Index}]{operatingEvent.MessageOff}");
					}
					else
					{
						Global.Log.Operation($"{operatingEvent.MessageOff}");
					}
				}
			}
			else
			{
				Global.Log.Alarm($"[{clsConfig.OperatingEventDeviceType}{clsConfig.OperatingEventStartAddress + e.Index}]Operating event not definition");
			}
		}

		private void PLC_AlarmEvent(object sender, int e)
		{
            AlarmModel alarm = Global.Alarms.FirstOrDefault(a => a.Index == e);
            if(alarm != null)
            {
                if(clsConfig.ShowAlarmDevice)
                {
					Global.Log.Alarm($"[{clsConfig.AlarmDeviceType}{clsConfig.AlarmStartAddress + alarm.Index}]{alarm.Text}", alarm.AlarmLevel);
				}
                else
                {
					Global.Log.Alarm(alarm.Text, alarm.AlarmLevel);
				}
			}
            else
            {
				Global.Log.Alarm($"[{clsConfig.AlarmDeviceType}{clsConfig.AlarmStartAddress + e}]Alarm not definition");
				alarm = new AlarmModel();
                alarm.Text = $"[{clsConfig.AlarmDeviceType}{clsConfig.AlarmStartAddress + e}]Alarm not definition";
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
            if((e.PropertyName == "PlcPrintRequest"))
            {
                if(Global.PLC.PlcPrintRequest)
                {
                    Global.Log.Operation("PLC send print request");
                    int[] data = Global.PLC.ReadPrintData();
                    if(data != null && data.Length == 2 && data[0] != 0 && data[1] != 0)
                    {
                        BarcodeModel barcode = Global.Barcodes.FirstOrDefault(a => a.Id == data[0]);
                        if(barcode == null)
                        {
                            Global.Log.Alarm("No barcode data in software, please initial system");
                        }
                        else
                        {
                            clsPrinter printer = new clsPrinter();
                            printer.Print(barcode.Data, data[1]);
                            Global.PLC.WritePrintComplete();
                        }
                    }
                }    
            }
		}

		private void btnPrinter_Click(object sender, EventArgs e)
		{
            frmPrinterSetting frmPrinterSetting = new frmPrinterSetting();
            frmPrinterSetting.ShowDialog();
		}

		private void btnPlcSetting_Click(object sender, EventArgs e)
		{
            FrmPlcSetting frmPlcSetting = new FrmPlcSetting();
            frmPlcSetting.ShowDialog();
		}

		private void btnSetting_Click(object sender, EventArgs e)
		{
            frmSetting frmSetting = new frmSetting();
            frmSetting.ShowDialog();
		}

		private void btnKeyboard_Click(object sender, EventArgs e)
		{
			Process.Start(@"c:\Windows\Sysnative\cmd.exe", "/c osk.exe");
		}
	}
}
