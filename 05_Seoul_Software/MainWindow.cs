using ComponentFactory.Krypton.Toolkit;
using Cutreson_PLC.McProtocol;
using Cutreson_Utility;
using Seoul_Software.Alarm;
using Seoul_Software.Data;
using Seoul_Software.Log;
using Seoul_Software.OperatingEvent;
using Seoul_Software.PLC;
using Seoul_Software.Printer;
using Seoul_Software.Scanner;
using Seoul_Software.SQL;
using Seoul_Software.User;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Seoul_Software
{
	public partial class MainWindow : KryptonForm
    {
        private frmAlarm frmAlarm;
		private frmInfo frmInfo;
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
			labelBuildDate.Text = "Built: " + File.GetLastWriteTime(Application.ProductName + ".exe").ToString("yyyy/MM/dd");
			//Load setting
			MySetting.Setting.LoadSetting();
			lbTitle.Text = MySetting.Setting.Title;
			//Login
			Global.Role = MySetting.Setting.AutoLoginAs;
			contextMenuStripData.Visible = false;
			contextMenuStripSetting.Visible = false;
            //Log
            Global.Log.ListBoxViewOperation = listBoxEventLog;
            Global.Log.ListBoxViewError = listBoxError;
			Global.Log.ListBoxViewAlarm = listBoxAlarm;
			Global.Log.Operation("Open software");
			//Load excel config
            if(clsConfig.LoadExcelConfig())
            {
                Global.Log.Operation($"Load {clsConfig.ConfigExcelFile} successfully");
            }
            else
            {
                Global.Log.Error($"Can't load {clsConfig.ConfigExcelFile}");
            }
            //Alarm
            frmAlarm = new frmAlarm();
			clsControlForm.LoadFormInPanel(panelAlarm, frmAlarm);
			ShowAlarm(false);
			//Database
			clsBarcodeManager.Load();
			//PLC
			Global.PLC = new clsControlPLC();
            Global.PLC.PropertyChanged += ControlPLC_PropertyChanged;
			Global.PLC.AlarmEvent += PLC_AlarmEvent;
			Global.PLC.OperatingEvent += PLC_OperatingEvent;
            //Home
            frmMachineMonitor frmMachineMonitor = new frmMachineMonitor();
			LoadForm(frmMachineMonitor);
			//Vision monitor
			frmVisionMonitor frmVisionMonitor = new frmVisionMonitor();
			clsControlForm.LoadFormInPanel(panelVisionMonitor, frmVisionMonitor);
			//Info
			frmInfo = new frmInfo();
			//Scanner
			frmBarcodes frmScanner = new frmBarcodes(frmInfo);
			//
            clsControlForm.LoadFormInControl(groupBoxScanner, frmScanner);
			clsControlForm.LoadFormInPanel(panelInfo, frmInfo);
            //////////////////////////////////////////////////////////////////////////
            Global.Log.Operation("Open software complete");
        }
		private void PLC_OperatingEvent(object sender, EventParam e)
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
				Global.Log.Error($"[{clsConfig.OperatingEventDeviceType}{clsConfig.OperatingEventStartAddress + e.Index}]Operating event not definition");
			}
		}

		private void PLC_AlarmEvent(object sender, EventParam e)
		{
            AlarmModel alarm = Global.Alarms.FirstOrDefault(a => a.Index == e.Index);
            if(alarm != null)
            {
                if(clsConfig.ShowAlarmDevice)
                {
					if(alarm.AlarmLevel == Log.eLogLevel.ALARM)
					{
						Global.Log.Alarm($"[{clsConfig.AlarmDeviceType}{clsConfig.AlarmStartAddress + alarm.Index}]{alarm.Text}", alarm.AlarmLevel, true, e.IsOn);
					}
					else
					{
						Global.Log.Error($"[{clsConfig.AlarmDeviceType}{clsConfig.AlarmStartAddress + alarm.Index}]{alarm.Text}", alarm.AlarmLevel, true, e.IsOn);
					}
				}
                else
                {
					if (alarm.AlarmLevel == Log.eLogLevel.ALARM)
					{
						Global.Log.Alarm(alarm.Text, alarm.AlarmLevel, true, e.IsOn);
					}
					else
					{
						Global.Log.Error(alarm.Text, alarm.AlarmLevel, true, e.IsOn);
					}					
				}
				if(e.IsOn && !Global.CurrentAlarms.Contains(alarm))
				{
					Global.CurrentAlarms.Insert(0, alarm);
				}
				else if(!e.IsOn && Global.CurrentAlarms.Contains(alarm))
				{
					Global.CurrentAlarms.Remove(alarm);
				}

				frmAlarm.UpdateList();
				frmAlarm.ViewAlarm(0);
			}
            else
            {
				Global.Log.Error($"[{clsConfig.AlarmDeviceType}{clsConfig.AlarmStartAddress + e.Index}]Alarm not definition");
			}
		}

        private void ShowAlarm(bool show)
        {
            if(tabControl.InvokeRequired)
            {
				tabControl.Invoke(new Action(() => { ShowAlarm(show); }));
            }
           else
            {
				if (show)
				{
					tabControl.SelectTab(1);
				}
				else
				{
					tabControl.SelectTab(0);
					if (clsConfig.ClearAlarm)
					{
						if (listBoxError.InvokeRequired)
						{
							listBoxError.Invoke((Action)delegate
							{
								listBoxError.Items.Clear();
							});
						}
						else
						{
							listBoxError.Items.Clear();
						}
					}
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
					if(data != null && data.Length == 5)
					{
						bool checkData = true;
						int id1 = 0, id2 = 0, total1 = 0, total2 = 0;
						if (data[0] != 0) id1 = data[0];
						for (int i = 0; i < 5; i++)
						{
							if (data[i] != 0 && data[i] != id1) id2 = data[i];
							if (data[i] != 0 && data[i] != id2 && id2 != 0) checkData = false;
							if (id1 != 0 && data[i] == id1) total1++;
							if (id2 != 0 && data[i] == id2) total2++;
						}

						if(!checkData || (total1 == 0 && total2 == 0))
						{
							Global.Log.Error("Data print error");
							return;
						}
						else
						{
							if(id2 == 0)
							{
								if (id1 == 32000)
								{
									clsPrinter printer = new clsPrinter();
									printer.Print("Print Demo", 5);
									Global.PLC.WritePrintComplete();
									return;
								}

								BarcodeModel barcode = Global.Barcodes.FirstOrDefault(a => a.Id == id1);
								if (barcode == null)
								{
									Global.Log.Error("No barcode data in software, please initial system");
									return;
								}
								else
								{
									clsPrinter printer = new clsPrinter();
									printer.Print(barcode.Data, total1);
									Global.PLC.WritePrintComplete();
								}
							}
							else
							{
								BarcodeModel barcode1 = Global.Barcodes.FirstOrDefault(a => a.Id == id1);
								BarcodeModel barcode2 = Global.Barcodes.FirstOrDefault(a => a.Id == id1);
								if (barcode1 == null || barcode2 == null)
								{
									Global.Log.Error("No barcode data in software, please initial system");
									return;
								}
								else
								{
									clsPrinter printer = new clsPrinter();
									printer.Print(barcode1.Data, total1, barcode2.Data, total2);
									Global.PLC.WritePrintComplete();
								}
							}
						}
					} 
                }    
            }

			if ((e.PropertyName == "PlcOutRingRequest"))
			{
				if (Global.PLC.PlcOutRingRequest)
				{
					Global.Log.Operation("PLC send output ring request");
					int[] data = Global.PLC.ReadPrintData();
					if (data != null && data.Length == 5)
					{
						bool checkData = true;
						int id1 = 0, id2 = 0, total1 = 0, total2 = 0;
						if (data[0] != 0) id1 = data[0];
						for (int i = 0; i < 5; i++)
						{
							if (data[i] != id1) id2 = data[i];
							if (data[i] != id2 && id2 != 0) checkData = false;
							if (id1 != 0 && data[i] == id1) total1++;
							if (id2 != 0 && data[i] == id2) total2++;
						}

						if (!checkData || (total1 == 0 && total2 == 0))
						{
							Global.Log.Error("Data output ring error");
							return;
						}
						else
						{
							if (id2 == 0)
							{
								BarcodeModel barcode1 = Global.Barcodes.FirstOrDefault(a => a.Id == id1);
								if (barcode1 == null)
								{
									Global.Log.Error("No barcode data in software, please initial system");
									return;
								}
								string lotNo1 = barcode1.Data;
								using (SeoulDbContext db = new SeoulDbContext())
								{
									RingModel ringModel = new RingModel();
									ringModel.LotNo = lotNo1;
									ringModel.Total = total1;
									ringModel.TimeOutput = DateTime.Now;
									db.Rings.Add(ringModel);
									//
									LotModel lot = db.Lots.FirstOrDefault(l => l.LotNo == lotNo1);
									if (lot != null)
									{
										lot.TimeOutput = DateTime.Now;
										lot.Total += total1;
									}
									db.SaveChanges();
									Global.PLC.WriteOutRingComplete();
									Global.Log.Operation($"Output ring lotNo:{lotNo1}, total:{total1}");
									//
									Global.TotalRing++;
									Global.TotalChipLed += total1;
									frmInfo.UpdateData();
								}
							}
							else
							{
								BarcodeModel barcode1 = Global.Barcodes.FirstOrDefault(a => a.Id == id1);
								BarcodeModel barcode2 = Global.Barcodes.FirstOrDefault(a => a.Id == id2);
								if (barcode1 == null || barcode2 == null)
								{
									Global.Log.Error("No barcode data in software, please initial system");
									return;
								}
								string lotNo1 = barcode1.Data;
								string lotNo2 = barcode2.Data;
								using (SeoulDbContext db = new SeoulDbContext())
								{
									RingModel ringModel = new RingModel();
									ringModel.LotNo = $"{lotNo1}; {lotNo2}" ;
									ringModel.Total = total1 + total2;
									ringModel.TimeOutput = DateTime.Now;
									db.Rings.Add(ringModel);
									//
									LotModel lot1 = db.Lots.FirstOrDefault(l => l.LotNo == lotNo1);
									LotModel lot2 = db.Lots.FirstOrDefault(l => l.LotNo == lotNo2);
									if (lot1 != null)
									{
										lot1.TimeOutput = DateTime.Now;
										lot1.Total += total1;
									}
									if (lot2 != null)
									{
										lot2.TimeOutput = DateTime.Now;
										lot2.Total += total2;
									}
									db.SaveChanges();
									Global.PLC.WriteOutRingComplete();
									Global.Log.Operation($"Output ring lot1:{lotNo1}, total:{total1}; lot1:{lotNo2}, total:{total2}");
									//
									Global.TotalRing++;
									Global.TotalChipLed += total1 + total2;
									frmInfo.UpdateData();
								}
							}
						}
					}				
				}
			}
		}

		private void LoadForm(Form form)
		{
			clsControlForm.LoadFormInPanel(panelMain, form);
			tabPage1.Text = form.Text;
		}

		private void btnSetting_Click(object sender, EventArgs e)
		{
			if (Global.Role == eRole.NONE || Global.Role == eRole.OPRERATOR)
			{
				contextMenuStripSetting.Visible = false;
				clsMessageBox.Warning("You need login as engineer or admin..!!");
				return;
			}
			else
			{
				contextMenuStripSetting.Visible = true;
			}
			if(Global.Role == eRole.ADMIN)
			{
				contextMenuStripSetting.Items[3].Visible = true;
			}
			else
			{
				contextMenuStripSetting.Items[3].Visible = false;
			}
			contextMenuStripSetting.Show(btnSetting, new Point(btnSetting.Width,btnSetting.Height / 2));
		}

		private void btnKeyboard_Click(object sender, EventArgs e)
		{
			Process.Start(@"c:\Windows\Sysnative\cmd.exe", "/c osk.exe");
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (Global.Role == eRole.NONE)
			{
				Global.Log.Alarm("You not login, login please..!!");
				clsMessageBox.Warning("Login please..!!");
				return;
			}
			Global.PLC.Setbit(PlcDeviceType.M, 23, true);			
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			if (Global.Role == eRole.NONE)
			{
				Global.Log.Alarm("You not login, login please..!!");
				clsMessageBox.Warning("Login please..!!");
				return;
			}
			Global.PLC.Setbit(PlcDeviceType.M, 24, true);
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			if (Global.Role == eRole.NONE)
			{
				Global.Log.Alarm("You not login, login please..!!");
				clsMessageBox.Warning("Login please..!!");
				return;
			}
			Global.PLC.Setbit(PlcDeviceType.M, 25, true);
		}

		private void btnOrigin_Click(object sender, EventArgs e)
		{
			if (Global.Role == eRole.NONE)
			{
				Global.Log.Alarm("You not login, login please..!!");
				clsMessageBox.Warning("Login please..!!");
				return;
			}
			Global.PLC.Setbit(PlcDeviceType.M, 26, true);
		}

		private void btnInitial_Click(object sender, EventArgs e)
		{
			if (Global.Role == eRole.NONE)
			{
				Global.Log.Alarm("You not login, login please..!!");
				clsMessageBox.Warning("Login please..!!");
				return;
			}
			Global.PLC.Setbit(PlcDeviceType.M, 27, true);
		}

		private void btnData_Click(object sender, EventArgs e)
		{
			if(Global.Role == eRole.NONE)
			{
				contextMenuStripData.Visible = false;
				Global.Log.Alarm("You not login, login please..!!");
				clsMessageBox.Warning("Login please..!!");
				return;
			}
			else
			{
				contextMenuStripData.Visible = true;
			}
			contextMenuStripData.Show(btnData, new Point(btnData.Width, btnData.Height / 2));
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			frmMachineMonitor frmMachineMonitor = new frmMachineMonitor();
			LoadForm(frmMachineMonitor);
		}

		private void lotDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LoadForm(new frmLotData());
		}

		private void ringDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LoadForm(new frmRingData());
		}

		private void listBoxError_DoubleClick(object sender, EventArgs e)
		{
			frmViewLog frmViewLog = new frmViewLog(listBoxError);
			frmViewLog.Text = "Error";
			frmViewLog.ShowDialog();
		}

		private void listBoxEventLog_DoubleClick(object sender, EventArgs e)
		{
			frmViewLog frmViewLog = new frmViewLog(listBoxEventLog);
			frmViewLog.Text = "Operation & Event Log";
			frmViewLog.ShowDialog();
		}

		private void listBoxAlarm_DoubleClick(object sender, EventArgs e)
		{
			frmViewLog frmViewLog = new frmViewLog(listBoxAlarm);
			frmViewLog.Text = "Alarm";
			frmViewLog.ShowDialog();
		}

		private void printerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPrinterSetting frmPrinterSetting = new frmPrinterSetting();
			frmPrinterSetting.ShowDialog();
		}

		private void pLCToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmPlcSetting frmPlcSetting = new FrmPlcSetting();
			frmPlcSetting.ShowDialog();
		}

		private void systemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmSetting frmSetting = new frmSetting();
			frmSetting.ShowDialog();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			frmLogin frmLogin = new frmLogin();
			frmLogin.ShowDialog();
			contextMenuStripData.Visible = false;
			contextMenuStripSetting.Visible = false;
		}

		private void userManagerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmUserManager frmUserManager = new frmUserManager();
			frmUserManager.ShowDialog();
			contextMenuStripData.Visible = false;
			contextMenuStripSetting.Visible = false;
		}
	}
}
