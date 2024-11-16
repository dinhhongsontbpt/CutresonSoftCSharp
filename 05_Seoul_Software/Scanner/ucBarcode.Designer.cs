namespace Seoul_Software.Scanner
{
	partial class ucBarcode
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lbIndex = new System.Windows.Forms.Label();
			this.lbId = new System.Windows.Forms.Label();
			this.txtBarcode = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.lbIndex, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbId, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtBarcode, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 50);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lbIndex
			// 
			this.lbIndex.AutoSize = true;
			this.lbIndex.BackColor = System.Drawing.Color.DarkOrange;
			this.lbIndex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIndex.Location = new System.Drawing.Point(4, 1);
			this.lbIndex.Name = "lbIndex";
			this.lbIndex.Size = new System.Drawing.Size(44, 48);
			this.lbIndex.TabIndex = 3;
			this.lbIndex.Text = "1";
			this.lbIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbId
			// 
			this.lbId.AutoSize = true;
			this.lbId.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbId.Location = new System.Drawing.Point(55, 1);
			this.lbId.Name = "lbId";
			this.lbId.Size = new System.Drawing.Size(34, 48);
			this.lbId.TabIndex = 0;
			this.lbId.Text = "100";
			this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtBarcode
			// 
			this.txtBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBarcode.Location = new System.Drawing.Point(96, 4);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new System.Drawing.Size(219, 30);
			this.txtBarcode.TabIndex = 2;
			this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
			// 
			// ucBarcode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ucBarcode";
			this.Size = new System.Drawing.Size(319, 50);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lbId;
		private System.Windows.Forms.Label lbIndex;
		public System.Windows.Forms.TextBox txtBarcode;
	}
}
