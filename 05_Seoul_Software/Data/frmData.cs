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

namespace Seoul_Software.Data
{
	public partial class frmData : Form
	{
		public frmData()
		{
			InitializeComponent();
			frmLotData frmLotData = new frmLotData();
			LoadForm(frmLotData);
		}
		private void LoadForm(Form form)
		{
			clsControlForm.LoadFormInPanel(panelMain, form);
			btnTitle.Text = form.Text;
		}
		private void btnLotData_Click(object sender, EventArgs e)
		{
			frmLotData frmLotData = new frmLotData();
			LoadForm(frmLotData);
		}

		private void btnRingData_Click(object sender, EventArgs e)
		{
			frmRingData frmRingData = new frmRingData();
			LoadForm(frmRingData);
		}
	}
}
