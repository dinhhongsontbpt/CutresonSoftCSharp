using Cutreson_Utility;
using Seoul_Software.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Seoul_Software.Data
{
	public partial class frmLotData : Form
	{
		private SeoulDbContext db = new SeoulDbContext();
		private List<LotModel> listSearch = new List<LotModel>();
		private List<LotModel> listView = new List<LotModel>();
		private int currentPage = 0; 
		private const int pageSize = 1000;
		public frmLotData()
		{
			InitializeComponent();
			Init();
		}
		private void Init()
		{
			var topLeftHeaderCell = tbData.TopLeftHeaderCell;

			lbTotal.Text = $"Total: {db.Lots.LongCount()}";

			var today = DateTime.Today;
			var tomorrow = today.AddDays(1);
			var startOfWeek = today.AddDays(-(int)today.DayOfWeek + (int)DayOfWeek.Monday);
			var endOfWeek = startOfWeek.AddDays(7);
			var startOfMonth = new DateTime(today.Year, today.Month, 1); 
			var startOfNextMonth = startOfMonth.AddMonths(1); 
			var startOfYear = new DateTime(today.Year, 1, 1); 
			var startOfNextYear = startOfYear.AddYears(1);
			//
			lbToday.Text = $"Today: {db.Lots.Count(l => l.TimeOutput >= today && l.TimeOutput < tomorrow)}";
			lbWeek.Text = $"This Week: {db.Lots.Count(l => l.TimeOutput >= startOfWeek && l.TimeOutput < endOfWeek)}";
			lbMonth.Text = $"This Month: {db.Lots.Count(l => l.TimeOutput >= startOfMonth && l.TimeOutput < startOfNextMonth)}";
			lbYear.Text = $"This Year: {db.Lots.Count(l => l.TimeOutput >= startOfYear && l.TimeOutput < startOfNextYear)}";
			//
			dateTimePickerFrom.Value = startOfMonth;
			dateTimePickerTo.Value = DateTime.Now;
			//
			tbData.CellFormatting += TbData_CellFormatting;
			//
			SearchByTime();
		}
		private void ViewData()
		{
			lbSearchResult.Text = $"Search result: {listSearch.Count}";
			listView = listSearch.Skip(currentPage * pageSize).Take(pageSize).ToList();
			UpdatePaginationButtons();
			tbData.DataSource = listView;

			tbData.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
			tbData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			tbData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
			tbData.ColumnHeadersDefaultCellStyle.Font = new Font(tbData.Font, FontStyle.Bold);
			tbData.ColumnHeadersDefaultCellStyle.Font = new Font(tbData.Font.FontFamily, 10);
			tbData.EnableHeadersVisualStyles = false;
			tbData.DefaultCellStyle.Font = new Font(tbData.Font, FontStyle.Regular);
			tbData.DefaultCellStyle.ForeColor = Color.Black;
			tbData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			foreach (DataGridViewColumn column in tbData.Columns)
			{
				column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
		}
		private void TbData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (tbData.Columns[e.ColumnIndex].Name == "TimeInput" || tbData.Columns[e.ColumnIndex].Name == "TimeOutput")
			{
				if (e.Value is DateTime dateTimeValue)
				{
					e.Value = dateTimeValue.ToString("yyyy-MM-dd HH:mm:ss");
					e.FormattingApplied = true;
				}
			}
		}
		private void SearchByTime()
		{
			var timeStart = dateTimePickerFrom.Value;
			var timeEnd = dateTimePickerTo.Value;
			listSearch = db.Lots.Where(l => l.TimeOutput >= timeStart && l.TimeOutput < timeEnd).OrderByDescending(l => l.TimeInput).ToList();
			currentPage = 0;
			ViewData();
		}
		private void UpdatePaginationButtons()
		{
			btnPrevious.Enabled = currentPage > 0;
			btnNext.Enabled = (currentPage + 1) * pageSize < listSearch.Count;
		}
		private void btnSearchLot_Click(object sender, EventArgs e)
		{
			listSearch = db.Lots.Where(l => l.LotNo == txtLot.Text).OrderByDescending(l => l.TimeInput).ToList();
			currentPage = 0;
			ViewData();
		}

		private void btnSearchTime_Click(object sender, EventArgs e)
		{
			currentPage = 0;
			SearchByTime();
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			if (currentPage > 0)
			{
				currentPage--;
				ViewData();
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			currentPage++;
			ViewData();
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			clsSave.ExportToExcel(tbData, "Lot Data", DateTime.Now.ToString("yyyyMMdd"));
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			currentPage = 0;
			SearchByTime();
		}
	}
}
