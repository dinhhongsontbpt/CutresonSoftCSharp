using ComponentFactory.Krypton.Toolkit;
using Cutreson_PLC.McProtocol;
using Cutreson_Utility;
using Seoul_Software.Alarm;
using Seoul_Software.Data;
using Seoul_Software.History;
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
		public MainWindow()
        {
            InitializeComponent();
			Init();
        }
		private frmAuto frmAuto;
        private void Init()
        {
            //Info
            ucDateTime.IsRun = true;
            ucPcInfo.IsRun = true;
			labelBuildDate.Text = "Built: " + File.GetLastWriteTime(Application.ProductName + ".exe").ToString("yyyy/MM/dd");
			//Load setting
			MySetting.Setting.LoadSetting();
			lbTitle.Text = MySetting.Setting.Title;
			//History
			clsHistoryManager.LoadAlarm();
			clsHistoryManager.LoadError();
			//Login
			Global.Role = MySetting.Setting.AutoLoginAs;
			contextMenuStripData.Visible = false;
			contextMenuStripSetting.Visible = false;
			//PLC
			Global.PLC = new clsControlPLC();
			Global.PLC.PropertyChanged += ControlPLC_PropertyChanged;
			//Auto
			frmAuto = new frmAuto();
			LoadForm(frmAuto);
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
		}

		private void LoadForm(Form form)
		{
			clsControlForm.LoadFormInPanel(panelMain, form);
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
			LoadForm(frmAuto);
		}

		private void lotDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LoadForm(new frmLotData());
		}

		private void ringDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LoadForm(new frmRingData());
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
			frmSystemSetting frmSetting = new frmSystemSetting();
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

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnDataLog_Click(object sender, EventArgs e)
		{
			if (Global.Role == eRole.NONE)
			{
				Global.Log.Alarm("You not login, login please..!!");
				clsMessageBox.Warning("Login please..!!");
				return;
			}
			else
			{
				frmData frmData = new frmData();
				LoadForm(frmData);
			}
		}

		private void btnHistory_Click(object sender, EventArgs e)
		{
			frmHistoryMenu frmHistory = new frmHistoryMenu();
			LoadForm(frmHistory);
		}

		private void btnSettingSystem_Click(object sender, EventArgs e)
		{
			if (Global.Role == eRole.NONE || Global.Role == eRole.OPRERATOR)
			{
				clsMessageBox.Warning("You need login as engineer or admin..!!");
				return;
			}
			else
			{
				frmSettingMenu frmSettingMenu = new frmSettingMenu();
				LoadForm(frmSettingMenu);
			}
		}
	}
}
