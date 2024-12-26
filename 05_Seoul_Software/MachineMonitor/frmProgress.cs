using Seoul_Software.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Seoul_Software.MachineMonitor
{
	public partial class frmProgress : Form
	{
		public frmProgress()
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

			UpdateData();
		}

		SeoulDbContext context = new SeoulDbContext();

		public void UpdateData()
		{
			var newData = context.Lots
				.OrderByDescending(a => a.TimeOutput)
				.Select(a => new { a.LotNo, a.Total })
				.ToList();

			if (tbData.InvokeRequired)
			{
				tbData.Invoke(new Action(() =>
				{
					tbData.DataSource = null;
					tbData.DataSource = newData;
				}));
			}
			else
			{
				tbData.DataSource = null;
				tbData.DataSource = newData;
			}
		}


	}
}
