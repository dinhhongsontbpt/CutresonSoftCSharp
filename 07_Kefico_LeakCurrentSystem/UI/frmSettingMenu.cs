using _07_Kefico_LeakCurrentSystem.Login;
using _07_Kefico_LeakCurrentSystem.PLC;
using Cutreson_Utility;
using System;
using System.Windows.Forms;

namespace _07_Kefico_LeakCurrentSystem.UI
{
	public partial class frmSettingMenu : Form
	{
		public frmSettingMenu()
		{
			InitializeComponent();
		}
		private void LoadForm(Form form)
		{
			clsControlForm.LoadFormInPanel(panelMain, form);
			btnTitle.Text = form.Text;
		}
		private void btnUser_Click(object sender, EventArgs e)
		{
			if (Global.Role != eRole.ADMIN)
			{
				clsMessageBox.Warning("You need login as admin..!!");
				return;
			}
			else
			{
				frmUserManager frmUserManager = new frmUserManager();
				LoadForm(frmUserManager);
			}
		}

		private void btnSystem_Click(object sender, EventArgs e)
		{
			frmSystemSetting frmSystemSetting = new frmSystemSetting();
			LoadForm(frmSystemSetting);
		}

		private void btnPLC_Click(object sender, EventArgs e)
		{
			frmPlcSetting frmPlcSetting = new frmPlcSetting();
			LoadForm(frmPlcSetting);
		}
	}
}
