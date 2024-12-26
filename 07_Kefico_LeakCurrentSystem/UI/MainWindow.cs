using _07_Kefico_LeakCurrentSystem.Login;
using _07_Kefico_LeakCurrentSystem.UI;
using Cutreson_Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Kefico_LeakCurrentSystem
{
	public partial class MainWindow : Form
	{
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
			//Log
			Global.Log.ListBoxViewLog = listBoxLog;
			Global.Log.Info("Initial start");
			//Login
			Global.Role = MySetting.Setting.AutoLoginAs;
			//PLC
			Global.PLC = new PLC.clsControlPLC();
			Global.PLC.PropertyChanged += PLC_PropertyChanged;
			//Home
			frmHome frmHome = new frmHome();
			LoadForm(frmHome);
			//
			Global.Log.Info("Initial complete");
		}

		private void PLC_PropertyChanged(object sender, PropertyChangedEventArgs e)
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
		private void btnAuto_Click(object sender, EventArgs e)
		{
			frmHome frmHome = new frmHome();
			LoadForm(frmHome);
		}

		private void btnUser_Click(object sender, EventArgs e)
		{
			frmLogin frmLogin = new frmLogin();
			frmLogin.ShowDialog();
		}

		private void btnDataLog_Click(object sender, EventArgs e)
		{
			if (Global.Role == eRole.NONE)
			{
				Global.Log.Warning("You not login, login please..!!");
				clsMessageBox.Warning("Login please..!!");
				return;
			}
			else
			{
				//frmData frmData = new frmData();
				//LoadForm(frmData);
			}
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

		private void btnKeyBoardSimu_Click(object sender, EventArgs e)
		{
			Process.Start(@"c:\Windows\Sysnative\cmd.exe", "/c osk.exe");
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
