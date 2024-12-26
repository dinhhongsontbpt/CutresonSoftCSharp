using Cutreson_PLC.McProtocol;
using Cutreson_Utility;
using Seoul_Software.Alarm;
using Seoul_Software.OperatingEvent;
using Seoul_Software.PLC;
using Seoul_Software.Printer;
using Seoul_Software.Scanner;
using Seoul_Software.SQL;
using Seoul_Software.User;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Seoul_Software.Log;
using Seoul_Software.History;
using Seoul_Software.MachineMonitor;

namespace Seoul_Software
{
	public partial class frmAuto : Form
	{
		private frmAlarm frmAlarm;
		private frmInfo frmInfo;
		private frmProgress frmProgress;
		frmBarcodes frmBarcodes;
		public frmAuto()
		{
			InitializeComponent();
			Init();
		}
		private void Init()
		{
			//Log
			Global.Log.ListBoxViewOperation = listBoxEventLog;
			Global.Log.ListBoxViewError = listBoxError;
			Global.Log.ListBoxViewAlarm = listBoxAlarm;
			Global.Log.Operation("Open software");
			//Load excel config
			if (clsConfig.LoadExcelConfig())
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
			tabControl.Appearance = TabAppearance.FlatButtons;
			tabControl.ItemSize = new Size(0, 1);
			tabControl.SizeMode = TabSizeMode.Fixed;
			ShowAlarm(false);
			//Database
			clsBarcodeManager.Load();
			//PLC
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
			frmProgress = new frmProgress();
			//Scanner
			frmBarcodes = new frmBarcodes(frmInfo, frmProgress);
			//
			clsControlForm.LoadFormInControl(pictureBox, frmBarcodes);
			clsControlForm.LoadFormInPanel(panelInfo, frmInfo);
			clsControlForm.LoadFormInControl(groupBoxProgress, frmProgress);
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
			if (alarm != null)
			{
				if (clsConfig.ShowAlarmDevice)
				{
					if (alarm.Level == Log.eLogLevel.WARNING)
					{
						Global.Log.Alarm($"[{clsConfig.AlarmDeviceType}{clsConfig.AlarmStartAddress + alarm.Index}]{alarm.Text}", alarm.Level, true, e.IsOn, true);
					}
					else
					{
						Global.Log.Error($"[{clsConfig.AlarmDeviceType}{clsConfig.AlarmStartAddress + alarm.Index}]{alarm.Text}", alarm.Level, true, e.IsOn, true);
					}
				}
				else
				{
					if (alarm.Level == Log.eLogLevel.WARNING)
					{
						Global.Log.Alarm(alarm.Text, alarm.Level, true, e.IsOn, true);
					}
					else
					{
						Global.Log.Error(alarm.Text, alarm.Level, true, e.IsOn, true);
					}
				}

				if (e.IsOn && !Global.CurrentAlarms.Contains(alarm))
				{
					Global.CurrentAlarms.Insert(0, alarm);
					//History
					if (alarm.Level == eLogLevel.WARNING)
					{
						alarm.Time = DateTime.Now;
						clsHistoryManager.AddAlarm(alarm);
					}
					else
					{
						alarm.Time = DateTime.Now;
						clsHistoryManager.AddError(alarm);
					}
				}
				else if (!e.IsOn && Global.CurrentAlarms.Contains(alarm))
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
			if (tabControl.InvokeRequired)
			{
				tabControl.Invoke(new Action(() => { ShowAlarm(show); }));
			}
			else
			{
				if (show)
				{
					tabControl.ItemSize = new Size(80, 30);
					tabControl.SelectTab(1);
				}
				else
				{
					tabControl.SelectTab(0);
					tabControl.ItemSize = new Size(0, 1);
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
			if ((e.PropertyName == "PlcPrintRequest"))
			{
				if (Global.PLC.PlcPrintRequest)
				{
					Global.Log.Operation("PLC send print request");
					int[] data = Global.PLC.ReadPrintData();
					if (data != null && data.Length == 5)
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

						if (!checkData || (total1 == 0 && total2 == 0))
						{
							Global.Log.Error("Data print error");
							return;
						}
						else
						{
							if (id2 == 0)
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
					int[] data = Global.PLC.ReadOutputData();
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
									frmProgress.UpdateData();
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
									ringModel.LotNo = $"{lotNo1}; {lotNo2}";
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
									frmProgress.UpdateData();
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

		private void btnLotStart_Click(object sender, EventArgs e)
		{
			frmScanLot frmScanLot = new frmScanLot(frmBarcodes);
			frmBarcodes.EnableControl(true);
			frmScanLot.ShowDialog();
			frmBarcodes.EnableControl(false);
			clsControlForm.LoadFormInControl(pictureBox, frmBarcodes);
		}
	}
}
