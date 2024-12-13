namespace Seoul_Software.Data
{
	partial class frmRingData
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbSearchResult = new System.Windows.Forms.Label();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnSearchLot = new System.Windows.Forms.Button();
			this.txtLot = new System.Windows.Forms.TextBox();
			this.btnSearchTime = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
			this.lbYear = new System.Windows.Forms.Label();
			this.lbMonth = new System.Windows.Forms.Label();
			this.lbWeek = new System.Windows.Forms.Label();
			this.lbToday = new System.Windows.Forms.Label();
			this.lbTotal = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.tbData = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnExport = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbData)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbSearchResult
			// 
			this.lbSearchResult.AutoSize = true;
			this.lbSearchResult.Location = new System.Drawing.Point(604, 14);
			this.lbSearchResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbSearchResult.Name = "lbSearchResult";
			this.lbSearchResult.Size = new System.Drawing.Size(81, 20);
			this.lbSearchResult.TabIndex = 18;
			this.lbSearchResult.Text = "Search: 0";
			// 
			// btnPrevious
			// 
			this.btnPrevious.BackColor = System.Drawing.Color.Teal;
			this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnPrevious.Location = new System.Drawing.Point(604, 43);
			this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(90, 40);
			this.btnPrevious.TabIndex = 17;
			this.btnPrevious.Text = "<<<";
			this.btnPrevious.UseVisualStyleBackColor = false;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.Color.Teal;
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnNext.Location = new System.Drawing.Point(699, 43);
			this.btnNext.Margin = new System.Windows.Forms.Padding(4);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(90, 40);
			this.btnNext.TabIndex = 16;
			this.btnNext.Text = ">>>";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnSearchLot
			// 
			this.btnSearchLot.BackColor = System.Drawing.Color.Teal;
			this.btnSearchLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchLot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSearchLot.Location = new System.Drawing.Point(392, 42);
			this.btnSearchLot.Margin = new System.Windows.Forms.Padding(4);
			this.btnSearchLot.Name = "btnSearchLot";
			this.btnSearchLot.Size = new System.Drawing.Size(196, 41);
			this.btnSearchLot.TabIndex = 15;
			this.btnSearchLot.Text = "Search by Lot";
			this.btnSearchLot.UseVisualStyleBackColor = false;
			this.btnSearchLot.Click += new System.EventHandler(this.btnSearchLot_Click);
			// 
			// txtLot
			// 
			this.txtLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLot.ForeColor = System.Drawing.Color.Blue;
			this.txtLot.Location = new System.Drawing.Point(392, 11);
			this.txtLot.Name = "txtLot";
			this.txtLot.Size = new System.Drawing.Size(196, 26);
			this.txtLot.TabIndex = 14;
			this.txtLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnSearchTime
			// 
			this.btnSearchTime.BackColor = System.Drawing.Color.Teal;
			this.btnSearchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSearchTime.Location = new System.Drawing.Point(257, 10);
			this.btnSearchTime.Margin = new System.Windows.Forms.Padding(4);
			this.btnSearchTime.Name = "btnSearchTime";
			this.btnSearchTime.Size = new System.Drawing.Size(121, 73);
			this.btnSearchTime.TabIndex = 13;
			this.btnSearchTime.Text = "Search by Time";
			this.btnSearchTime.UseVisualStyleBackColor = false;
			this.btnSearchTime.Click += new System.EventHandler(this.btnSearchTime_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 59);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "To";
			// 
			// dateTimePickerTo
			// 
			this.dateTimePickerTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerTo.Location = new System.Drawing.Point(67, 57);
			this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePickerTo.Name = "dateTimePickerTo";
			this.dateTimePickerTo.Size = new System.Drawing.Size(181, 26);
			this.dateTimePickerTo.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "From";
			// 
			// dateTimePickerFrom
			// 
			this.dateTimePickerFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerFrom.Location = new System.Drawing.Point(67, 14);
			this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePickerFrom.Name = "dateTimePickerFrom";
			this.dateTimePickerFrom.Size = new System.Drawing.Size(181, 26);
			this.dateTimePickerFrom.TabIndex = 0;
			// 
			// lbYear
			// 
			this.lbYear.AutoSize = true;
			this.lbYear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbYear.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.lbYear.Location = new System.Drawing.Point(901, 1);
			this.lbYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbYear.Name = "lbYear";
			this.lbYear.Size = new System.Drawing.Size(215, 34);
			this.lbYear.TabIndex = 4;
			this.lbYear.Text = "Year";
			this.lbYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbMonth
			// 
			this.lbMonth.AutoSize = true;
			this.lbMonth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMonth.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.lbMonth.Location = new System.Drawing.Point(677, 1);
			this.lbMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbMonth.Name = "lbMonth";
			this.lbMonth.Size = new System.Drawing.Size(215, 34);
			this.lbMonth.TabIndex = 3;
			this.lbMonth.Text = "Month";
			this.lbMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbWeek
			// 
			this.lbWeek.AutoSize = true;
			this.lbWeek.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbWeek.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.lbWeek.Location = new System.Drawing.Point(453, 1);
			this.lbWeek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbWeek.Name = "lbWeek";
			this.lbWeek.Size = new System.Drawing.Size(215, 34);
			this.lbWeek.TabIndex = 2;
			this.lbWeek.Text = "Week";
			this.lbWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbToday
			// 
			this.lbToday.AutoSize = true;
			this.lbToday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbToday.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.lbToday.Location = new System.Drawing.Point(229, 1);
			this.lbToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbToday.Name = "lbToday";
			this.lbToday.Size = new System.Drawing.Size(215, 34);
			this.lbToday.TabIndex = 1;
			this.lbToday.Text = "Today";
			this.lbToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbTotal
			// 
			this.lbTotal.AutoSize = true;
			this.lbTotal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotal.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.lbTotal.Location = new System.Drawing.Point(5, 1);
			this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotal.Name = "lbTotal";
			this.lbTotal.Size = new System.Drawing.Size(215, 34);
			this.lbTotal.TabIndex = 0;
			this.lbTotal.Text = "Total";
			this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.lbYear, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbMonth, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbWeek, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbToday, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbTotal, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 577);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1121, 36);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 1;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.tbData, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 3;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(1129, 617);
			this.tableLayoutPanel.TabIndex = 1;
			// 
			// tbData
			// 
			this.tbData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tbData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbData.Location = new System.Drawing.Point(4, 104);
			this.tbData.Margin = new System.Windows.Forms.Padding(4);
			this.tbData.Name = "tbData";
			this.tbData.RowHeadersWidth = 51;
			this.tbData.RowTemplate.Height = 24;
			this.tbData.Size = new System.Drawing.Size(1121, 465);
			this.tbData.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnExport);
			this.panel1.Controls.Add(this.lbSearchResult);
			this.panel1.Controls.Add(this.btnPrevious);
			this.panel1.Controls.Add(this.btnNext);
			this.panel1.Controls.Add(this.btnSearchLot);
			this.panel1.Controls.Add(this.txtLot);
			this.panel1.Controls.Add(this.btnSearchTime);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dateTimePickerTo);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.dateTimePickerFrom);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(4, 4);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1121, 92);
			this.panel1.TabIndex = 2;
			// 
			// btnExport
			// 
			this.btnExport.BackColor = System.Drawing.Color.Teal;
			this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnExport.Location = new System.Drawing.Point(811, 9);
			this.btnExport.Margin = new System.Windows.Forms.Padding(4);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(121, 73);
			this.btnExport.TabIndex = 20;
			this.btnExport.Text = "Export to Excel";
			this.btnExport.UseVisualStyleBackColor = false;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// frmRingData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1129, 617);
			this.Controls.Add(this.tableLayoutPanel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmRingData";
			this.Text = "Ring Data";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tbData)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbSearchResult;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnSearchLot;
		private System.Windows.Forms.TextBox txtLot;
		private System.Windows.Forms.Button btnSearchTime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePickerTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
		private System.Windows.Forms.Label lbYear;
		private System.Windows.Forms.Label lbMonth;
		private System.Windows.Forms.Label lbWeek;
		private System.Windows.Forms.Label lbToday;
		private System.Windows.Forms.Label lbTotal;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.DataGridView tbData;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnExport;
	}
}