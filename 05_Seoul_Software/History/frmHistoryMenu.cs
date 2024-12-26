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

namespace Seoul_Software.History
{
	public partial class frmHistoryMenu : Form
	{
		public frmHistoryMenu()
		{
			InitializeComponent();
			frmErrorHistory frmError = new frmErrorHistory();
			LoadForm(frmError);
		}
		private void LoadForm(Form form)
		{
			clsControlForm.LoadFormInPanel(panelMain, form);
			btnTitle.Text = form.Text;
		}
		private void btnAlarmHistory_Click(object sender, EventArgs e)
		{
			frmAlarmHistory frmAlarmHistory = new frmAlarmHistory();
			LoadForm(frmAlarmHistory);
		}

		private void btnErrorHistory_Click(object sender, EventArgs e)
		{
			frmErrorHistory frmError = new frmErrorHistory();
			LoadForm(frmError);
		}
	}
}
