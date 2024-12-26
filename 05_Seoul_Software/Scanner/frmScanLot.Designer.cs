namespace Seoul_Software.Scanner
{
	partial class frmScanLot
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScanLot));
			this.panelMain = new System.Windows.Forms.Panel();
			this.btnAuto = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtCount = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.txtCount)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Location = new System.Drawing.Point(15, 108);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(531, 513);
			this.panelMain.TabIndex = 0;
			// 
			// btnAuto
			// 
			this.btnAuto.BackColor = System.Drawing.Color.Teal;
			this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnAuto.Location = new System.Drawing.Point(172, 22);
			this.btnAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAuto.Name = "btnAuto";
			this.btnAuto.Size = new System.Drawing.Size(171, 58);
			this.btnAuto.TabIndex = 12;
			this.btnAuto.Text = "AUTO FILL";
			this.btnAuto.UseVisualStyleBackColor = false;
			this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Teal;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCancel.Location = new System.Drawing.Point(375, 22);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(171, 58);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "OK";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtCount
			// 
			this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCount.Location = new System.Drawing.Point(15, 26);
			this.txtCount.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.txtCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(120, 53);
			this.txtCount.TabIndex = 14;
			this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCount.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
			// 
			// frmScanLot
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 641);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAuto);
			this.Controls.Add(this.panelMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmScanLot";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lot Start";
			((System.ComponentModel.ISupportInitialize)(this.txtCount)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button btnAuto;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.NumericUpDown txtCount;
	}
}