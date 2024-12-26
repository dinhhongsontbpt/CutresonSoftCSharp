namespace Seoul_Software
{
	partial class frmSystemSetting
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemSetting));
			this.label1 = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.cbBarcode = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaxAlarm = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMaxError = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.txtMaxAlarm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaxError)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Log folder";
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(128, 27);
			this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(565, 23);
			this.txtPath.TabIndex = 1;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Teal;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSave.Location = new System.Drawing.Point(627, 176);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(107, 34);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.BackColor = System.Drawing.Color.Teal;
			this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSelect.Location = new System.Drawing.Point(699, 21);
			this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(35, 34);
			this.btnSelect.TabIndex = 13;
			this.btnSelect.Text = "...";
			this.btnSelect.UseVisualStyleBackColor = false;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// cbBarcode
			// 
			this.cbBarcode.AutoSize = true;
			this.cbBarcode.Location = new System.Drawing.Point(128, 141);
			this.cbBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbBarcode.Name = "cbBarcode";
			this.cbBarcode.Size = new System.Drawing.Size(173, 21);
			this.cbBarcode.TabIndex = 14;
			this.cbBarcode.Text = "Check barcode overlap";
			this.cbBarcode.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 17);
			this.label2.TabIndex = 15;
			this.label2.Text = "Max alarm";
			// 
			// txtMaxAlarm
			// 
			this.txtMaxAlarm.Location = new System.Drawing.Point(128, 67);
			this.txtMaxAlarm.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.txtMaxAlarm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txtMaxAlarm.Name = "txtMaxAlarm";
			this.txtMaxAlarm.Size = new System.Drawing.Size(120, 23);
			this.txtMaxAlarm.TabIndex = 16;
			this.txtMaxAlarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtMaxAlarm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(254, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 17);
			this.label3.TabIndex = 17;
			this.label3.Text = "records";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(254, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 17);
			this.label4.TabIndex = 20;
			this.label4.Text = "records";
			// 
			// txtMaxError
			// 
			this.txtMaxError.Location = new System.Drawing.Point(128, 103);
			this.txtMaxError.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.txtMaxError.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txtMaxError.Name = "txtMaxError";
			this.txtMaxError.Size = new System.Drawing.Size(120, 23);
			this.txtMaxError.TabIndex = 19;
			this.txtMaxError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtMaxError.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 106);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 17);
			this.label5.TabIndex = 18;
			this.label5.Text = "Max error";
			// 
			// frmSystemSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 226);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtMaxError);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMaxAlarm);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbBarcode);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmSystemSetting";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SYSTEM";
			((System.ComponentModel.ISupportInitialize)(this.txtMaxAlarm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaxError)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.CheckBox cbBarcode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown txtMaxAlarm;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown txtMaxError;
		private System.Windows.Forms.Label label5;
	}
}