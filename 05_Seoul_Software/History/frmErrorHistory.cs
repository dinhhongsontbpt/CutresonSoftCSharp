using Seoul_Software.Alarm;
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
	public partial class frmErrorHistory : Form
	{
		public frmErrorHistory()
		{
			InitializeComponent();
			Init();
		}
		private void Init()
		{
			var topLeftHeaderCell = tbData.TopLeftHeaderCell;

			tbData.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
			tbData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			tbData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
			tbData.ColumnHeadersDefaultCellStyle.Font = new Font(tbData.Font, FontStyle.Bold);
			tbData.ColumnHeadersDefaultCellStyle.Font = new Font(tbData.Font.FontFamily, 10);
			tbData.EnableHeadersVisualStyles = false;
			tbData.DefaultCellStyle.Font = new Font(tbData.Font, FontStyle.Regular);
			tbData.DefaultCellStyle.ForeColor = Color.Black;
			tbData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			for (int i = 0; i < Global.ErrorHistory.Count; i++)
			{
				AlarmModel model = Global.ErrorHistory[i];
				string[] row = new string[] { (i + 1).ToString(), model.Time.ToString("yyyy/MM/dd HH:mm:ss"), model.Code, model.Unit, model.Text };
				tbData.Rows.Add(row);
			}
		}
	}
}
