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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
			txtPassword.PasswordChar = '*';
			cboRole.SelectedIndex = 0;
		}
		private void Login()
		{
			if (cboRole.SelectedIndex == 0 && txtPassword.Text == MySetting.Setting.OperatorPassword)
			{
				Global.Role = eRole.OPRERATOR;
				Global.Log.Info("Login as Operator");
			}
			else if (cboRole.SelectedIndex == 1 && txtPassword.Text == MySetting.Setting.EngineerPassword)
			{
				Global.Role = eRole.ENGINEER;
				Global.Log.Info("Login as Engineer");
			}
			else if (cboRole.SelectedIndex == 2 && txtPassword.Text == MySetting.Setting.AdminPassword)
			{
				Global.Role = eRole.ADMIN;
				Global.Log.Info("Login as Admin");
			}
			else
			{
				clsMessageBox.Error("Password error..!!");
				return;
			}
			this.Close();
		}
		private void btnLogin_Click(object sender, EventArgs e)
		{
			Login();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			if (Global.Role == eRole.NONE) return;
			Global.Role = eRole.NONE;
			Global.Log.Warning("Logout");
			this.Close();
		}

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Login();
			}
		}
	}
}
