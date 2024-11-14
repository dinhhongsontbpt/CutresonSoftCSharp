namespace Seoul_Software.Printer
{
	partial class frmPrinterSetting
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrinterSetting));
			this.btnTest = new System.Windows.Forms.Button();
			this.txtPort = new System.Windows.Forms.NumericUpDown();
			this.txtIp = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCommand = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtLotNo = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.txtPort)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
			this.SuspendLayout();
			// 
			// btnTest
			// 
			this.btnTest.BackColor = System.Drawing.Color.Teal;
			this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnTest.Location = new System.Drawing.Point(28, 70);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(464, 35);
			this.btnTest.TabIndex = 7;
			this.btnTest.Text = "TEST";
			this.btnTest.UseVisualStyleBackColor = false;
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(406, 28);
			this.txtPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(86, 22);
			this.txtPort.TabIndex = 6;
			this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPort.Value = new decimal(new int[] {
            6101,
            0,
            0,
            0});
			// 
			// txtIp
			// 
			this.txtIp.Location = new System.Drawing.Point(118, 28);
			this.txtIp.Name = "txtIp";
			this.txtIp.Size = new System.Drawing.Size(145, 22);
			this.txtIp.TabIndex = 5;
			this.txtIp.Text = "192.168.3.123";
			this.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "IP Address";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(357, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "Port";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 16);
			this.label3.TabIndex = 9;
			this.label3.Text = "Command";
			// 
			// txtCommand
			// 
			this.txtCommand.Location = new System.Drawing.Point(118, 71);
			this.txtCommand.Multiline = true;
			this.txtCommand.Name = "txtCommand";
			this.txtCommand.Size = new System.Drawing.Size(374, 74);
			this.txtCommand.TabIndex = 10;
			this.txtCommand.Text = "^XA^FO20,20^ADN,30,25^FDLot:0123456789^FS^FO20,80^ADN,30,25^FDTotal:5pcs^FS^XZ";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Teal;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSave.Location = new System.Drawing.Point(28, 165);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(464, 35);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.txtCommand);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtIp);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtPort);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(518, 216);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Setting";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.btnTest);
			this.groupBox2.Controls.Add(this.txtLotNo);
			this.groupBox2.Controls.Add(this.txtTotal);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(12, 251);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(518, 123);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Test";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Lot No.";
			// 
			// txtLotNo
			// 
			this.txtLotNo.Location = new System.Drawing.Point(118, 28);
			this.txtLotNo.Name = "txtLotNo";
			this.txtLotNo.Size = new System.Drawing.Size(214, 22);
			this.txtLotNo.TabIndex = 5;
			this.txtLotNo.Text = "0123456789";
			this.txtLotNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(406, 29);
			this.txtTotal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(86, 22);
			this.txtTotal.TabIndex = 6;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTotal.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(357, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "Total";
			// 
			// frmPrinterSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 391);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmPrinterSetting";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Printer Setting";
			((System.ComponentModel.ISupportInitialize)(this.txtPort)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.NumericUpDown txtPort;
		private System.Windows.Forms.TextBox txtIp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCommand;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtLotNo;
		private System.Windows.Forms.NumericUpDown txtTotal;
		private System.Windows.Forms.Label label6;
	}
}