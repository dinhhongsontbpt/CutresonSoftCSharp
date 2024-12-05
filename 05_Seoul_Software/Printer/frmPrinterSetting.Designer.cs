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
			this.txtCommand1 = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCommand2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtLotNo2 = new System.Windows.Forms.TextBox();
			this.txtTotal2 = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtLotNo1 = new System.Windows.Forms.TextBox();
			this.txtTotal1 = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.txtPort)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTotal2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotal1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnTest
			// 
			this.btnTest.BackColor = System.Drawing.Color.Teal;
			this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnTest.Location = new System.Drawing.Point(28, 102);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(464, 35);
			this.btnTest.TabIndex = 7;
			this.btnTest.Text = "TEST";
			this.btnTest.UseVisualStyleBackColor = false;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
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
			this.label3.Size = new System.Drawing.Size(79, 16);
			this.label3.TabIndex = 9;
			this.label3.Text = "Command 1";
			// 
			// txtCommand1
			// 
			this.txtCommand1.Location = new System.Drawing.Point(118, 71);
			this.txtCommand1.Multiline = true;
			this.txtCommand1.Name = "txtCommand1";
			this.txtCommand1.Size = new System.Drawing.Size(374, 74);
			this.txtCommand1.TabIndex = 10;
			this.txtCommand1.Text = "^XA^FO20,20^ADN,30,25^FDLot:0123456789^FS^FO20,80^ADN,30,25^FDTotal:5pcs^FS^XZ";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Teal;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSave.Location = new System.Drawing.Point(28, 254);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(464, 35);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCommand2);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.txtCommand1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtIp);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtPort);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(518, 304);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Setting";
			// 
			// txtCommand2
			// 
			this.txtCommand2.Location = new System.Drawing.Point(118, 162);
			this.txtCommand2.Multiline = true;
			this.txtCommand2.Name = "txtCommand2";
			this.txtCommand2.Size = new System.Drawing.Size(374, 74);
			this.txtCommand2.TabIndex = 13;
			this.txtCommand2.Text = "^XA^FO20,20^ADN,30,25^FDLot:0123456789^FS^FO20,80^ADN,30,25^FDTotal:5pcs^FS^XZ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 16);
			this.label5.TabIndex = 12;
			this.label5.Text = "Command 2";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtLotNo2);
			this.groupBox2.Controls.Add(this.txtTotal2);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.btnTest);
			this.groupBox2.Controls.Add(this.txtLotNo1);
			this.groupBox2.Controls.Add(this.txtTotal1);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(12, 325);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(518, 153);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Test";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(26, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 16);
			this.label7.TabIndex = 9;
			this.label7.Text = "Lot No. 2";
			// 
			// txtLotNo2
			// 
			this.txtLotNo2.Location = new System.Drawing.Point(119, 65);
			this.txtLotNo2.Name = "txtLotNo2";
			this.txtLotNo2.Size = new System.Drawing.Size(214, 22);
			this.txtLotNo2.TabIndex = 10;
			this.txtLotNo2.Text = "9876543210";
			this.txtLotNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtTotal2
			// 
			this.txtTotal2.Location = new System.Drawing.Point(414, 66);
			this.txtTotal2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.txtTotal2.Name = "txtTotal2";
			this.txtTotal2.Size = new System.Drawing.Size(79, 22);
			this.txtTotal2.TabIndex = 11;
			this.txtTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTotal2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.txtTotal2.ValueChanged += new System.EventHandler(this.txtTotal2_ValueChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(339, 68);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 16);
			this.label8.TabIndex = 12;
			this.label8.Text = "Total Lot 2";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Lot No. 1";
			// 
			// txtLotNo1
			// 
			this.txtLotNo1.Location = new System.Drawing.Point(118, 28);
			this.txtLotNo1.Name = "txtLotNo1";
			this.txtLotNo1.Size = new System.Drawing.Size(214, 22);
			this.txtLotNo1.TabIndex = 5;
			this.txtLotNo1.Text = "0123456789";
			this.txtLotNo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtTotal1
			// 
			this.txtTotal1.Location = new System.Drawing.Point(413, 29);
			this.txtTotal1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.txtTotal1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txtTotal1.Name = "txtTotal1";
			this.txtTotal1.Size = new System.Drawing.Size(79, 22);
			this.txtTotal1.TabIndex = 6;
			this.txtTotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTotal1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.txtTotal1.ValueChanged += new System.EventHandler(this.txtTotal1_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(338, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "Total Lot 1";
			// 
			// frmPrinterSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 480);
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
			((System.ComponentModel.ISupportInitialize)(this.txtTotal2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotal1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.NumericUpDown txtPort;
		private System.Windows.Forms.TextBox txtIp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCommand1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtLotNo1;
		private System.Windows.Forms.NumericUpDown txtTotal1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCommand2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtLotNo2;
		private System.Windows.Forms.NumericUpDown txtTotal2;
		private System.Windows.Forms.Label label8;
	}
}