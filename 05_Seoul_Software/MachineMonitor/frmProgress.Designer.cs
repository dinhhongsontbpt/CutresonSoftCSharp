namespace Seoul_Software.MachineMonitor
{
	partial class frmProgress
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
			this.tbData = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.tbData)).BeginInit();
			this.SuspendLayout();
			// 
			// tbData
			// 
			this.tbData.AllowUserToAddRows = false;
			this.tbData.AllowUserToDeleteRows = false;
			this.tbData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tbData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			this.tbData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbData.Location = new System.Drawing.Point(0, 0);
			this.tbData.Margin = new System.Windows.Forms.Padding(4);
			this.tbData.Name = "tbData";
			this.tbData.ReadOnly = true;
			this.tbData.RowHeadersVisible = false;
			this.tbData.RowHeadersWidth = 51;
			this.tbData.RowTemplate.Height = 24;
			this.tbData.Size = new System.Drawing.Size(551, 352);
			this.tbData.TabIndex = 3;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.DataPropertyName = "LotNo";
			this.Column1.HeaderText = "Magazine No";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column2.DataPropertyName = "Total";
			this.Column2.HeaderText = "Total";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 65;
			// 
			// frmProgress
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 352);
			this.Controls.Add(this.tbData);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmProgress";
			this.Text = "frmProgress";
			((System.ComponentModel.ISupportInitialize)(this.tbData)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView tbData;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
	}
}