namespace _06_Terumo
{
	partial class FrmLogger
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
			this.tableLayoutPanelLog = new System.Windows.Forms.TableLayoutPanel();
			this.btnClearLog = new System.Windows.Forms.Button();
			this.listBoxLog = new System.Windows.Forms.ListBox();
			this.tableLayoutPanelLog.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelLog
			// 
			this.tableLayoutPanelLog.ColumnCount = 1;
			this.tableLayoutPanelLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanelLog.Controls.Add(this.btnClearLog, 0, 1);
			this.tableLayoutPanelLog.Controls.Add(this.listBoxLog, 0, 0);
			this.tableLayoutPanelLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelLog.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelLog.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanelLog.Name = "tableLayoutPanelLog";
			this.tableLayoutPanelLog.RowCount = 2;
			this.tableLayoutPanelLog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanelLog.Size = new System.Drawing.Size(1000, 562);
			this.tableLayoutPanelLog.TabIndex = 2;
			// 
			// btnClearLog
			// 
			this.btnClearLog.BackColor = System.Drawing.Color.Teal;
			this.btnClearLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnClearLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearLog.ForeColor = System.Drawing.Color.White;
			this.btnClearLog.Location = new System.Drawing.Point(5, 514);
			this.btnClearLog.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.btnClearLog.Name = "btnClearLog";
			this.btnClearLog.Size = new System.Drawing.Size(990, 46);
			this.btnClearLog.TabIndex = 88;
			this.btnClearLog.Text = "CLEAR";
			this.btnClearLog.UseVisualStyleBackColor = false;
			this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
			// 
			// listBoxLog
			// 
			this.listBoxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.listBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxLog.Font = new System.Drawing.Font("Consolas", 10F);
			this.listBoxLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.listBoxLog.FormattingEnabled = true;
			this.listBoxLog.HorizontalExtent = 10000;
			this.listBoxLog.HorizontalScrollbar = true;
			this.listBoxLog.ItemHeight = 20;
			this.listBoxLog.Location = new System.Drawing.Point(4, 4);
			this.listBoxLog.Margin = new System.Windows.Forms.Padding(4);
			this.listBoxLog.Name = "listBoxLog";
			this.listBoxLog.Size = new System.Drawing.Size(992, 504);
			this.listBoxLog.TabIndex = 6;
			// 
			// FrmLogger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 562);
			this.Controls.Add(this.tableLayoutPanelLog);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmLogger";
			this.Text = "FrmLogger";
			this.tableLayoutPanelLog.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLog;
		private System.Windows.Forms.Button btnClearLog;
		private System.Windows.Forms.ListBox listBoxLog;
	}
}