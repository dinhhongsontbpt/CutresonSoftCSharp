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

namespace Seoul_Software
{
	public partial class frmSystemSetting : Form
	{
		public frmSystemSetting()
		{
			InitializeComponent();
			txtPath.Text = MySetting.Setting.LogPathFolder;
			cbBarcode.Checked = MySetting.Setting.CheckBarcodeOverlap;
			txtMaxAlarm.Value = MySetting.Setting.MaxAlarm;
			txtMaxError.Value = MySetting.Setting.MaxError;
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
			MySetting.Setting.CheckBarcodeOverlap = cbBarcode.Checked;
			MySetting.Setting.MaxAlarm = (int)txtMaxAlarm.Value;
			MySetting.Setting.MaxError = (int)txtMaxError.Value;
			MySetting.Setting.SaveSetting();
			clsMessageBox.Info("Save successfully..!!");
		}
	}
}
