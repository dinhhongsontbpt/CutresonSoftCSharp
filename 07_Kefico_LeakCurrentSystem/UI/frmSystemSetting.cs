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

namespace _07_Kefico_LeakCurrentSystem.UI
{
	public partial class frmSystemSetting : Form
	{
		public frmSystemSetting()
		{
			InitializeComponent();
			txtPath.Text = MySetting.Setting.LogPathFolder;
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
			{
				if (folderDialog.ShowDialog() == DialogResult.OK)
				{
					txtPath.Text = folderDialog.SelectedPath;
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			MySetting.Setting.LogPathFolder = txtPath.Text;
			MySetting.Setting.SaveSetting();
			clsMessageBox.Info("Save successfully..!!");
		}
	}
}
