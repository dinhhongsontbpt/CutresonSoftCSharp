using Cutreson_Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Kefico_LeakCurrentSystem.Login
{
	public partial class frmUserManager : Form
	{
		public frmUserManager()
		{
			InitializeComponent();
			txtAdmin.Text = MySetting.Setting.AdminPassword;
			txtEngineer.Text = MySetting.Setting.EngineerPassword;
			txtOperator.Text = MySetting.Setting.OperatorPassword;
			cboRole.SelectedIndex = (int)MySetting.Setting.AutoLoginAs;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			MySetting.Setting.AdminPassword = txtAdmin.Text;
			MySetting.Setting.EngineerPassword = txtEngineer.Text;
			MySetting.Setting.OperatorPassword = txtOperator.Text;
			MySetting.Setting.AutoLoginAs = (eRole)cboRole.SelectedIndex;
			MySetting.Setting.SaveSetting();
			clsMessageBox.Info("Save successfully..!!");
		}
	}
}
