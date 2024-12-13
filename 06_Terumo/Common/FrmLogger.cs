using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Terumo
{
	public partial class FrmLogger : Form
	{
		public FrmLogger()
		{
			InitializeComponent();
			Global.Common.ListBoxViewLog = listBoxLog;
		}

		private void btnClearLog_Click(object sender, EventArgs e)
		{
			listBoxLog.Items.Clear();
		}
	}
}
