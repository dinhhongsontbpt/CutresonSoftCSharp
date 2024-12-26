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

namespace Seoul_Software.Scanner
{
	public partial class frmScanLot : Form
	{
		private frmBarcodes frmBarcodes;
		public frmScanLot(frmBarcodes frm)
		{
			InitializeComponent();
			this.frmBarcodes = frm;
			clsControlForm.LoadFormInPanel(panelMain, frmBarcodes);
		}

		private void btnAuto_Click(object sender, EventArgs e)
		{
			frmBarcodes.AutoGenerate((int)txtCount.Value);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
