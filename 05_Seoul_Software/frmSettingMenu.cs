using Cutreson_Utility;
using Seoul_Software.PLC;
using Seoul_Software.Printer;
using Seoul_Software.User;
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
	public partial class frmSettingMenu : Form
	{
		public frmSettingMenu()
		{
			InitializeComponent();
			frmPrinterSetting frmPrinterSetting = new frmPrinterSetting();
			LoadForm(frmPrinterSetting);
		}
		private void LoadForm(Form form)
		{
			clsControlForm.LoadFormInPanel(panelMain, form);
			btnTitle.Text = form.Text;
		}
		private void btnPrinter_Click(object sender, EventArgs e)
		{
			frmPrinterSetting frmPrinterSetting = new frmPrinterSetting();
			LoadForm(frmPrinterSetting);
		}

		private void btnPLC_Click(object sender, EventArgs e)
		{
			FrmPlcSetting frmPlcSetting = new FrmPlcSetting();
			LoadForm(frmPlcSetting);
		}

		private void btnSystem_Click(object sender, EventArgs e)
		{
			frmSystemSetting frmSystemSetting = new frmSystemSetting();
			LoadForm(frmSystemSetting);
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
	}
}
