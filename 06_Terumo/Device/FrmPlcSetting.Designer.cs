namespace _06_Terumo.Device
{
	partial class FrmPlcSetting
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlcSetting));
			this.cboDataBit = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cboStopBit = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cboParity = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboBaudRate = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cboPortName = new System.Windows.Forms.ComboBox();
			this.cbPositiveLogic = new System.Windows.Forms.CheckBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cboDataBit
			// 
			this.cboDataBit.FormattingEnabled = true;
			this.cboDataBit.Items.AddRange(new object[] {
            "7",
            "8"});
			this.cboDataBit.Location = new System.Drawing.Point(157, 175);
			this.cboDataBit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboDataBit.Name = "cboDataBit";
			this.cboDataBit.Size = new System.Drawing.Size(121, 28);
			this.cboDataBit.TabIndex = 35;
			this.cboDataBit.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 228);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 20);
			this.label5.TabIndex = 34;
			this.label5.Text = "Stop Bits";
			// 
			// cboStopBit
			// 
			this.cboStopBit.FormattingEnabled = true;
			this.cboStopBit.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three"});
			this.cboStopBit.Location = new System.Drawing.Point(157, 225);
			this.cboStopBit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboStopBit.Name = "cboStopBit";
			this.cboStopBit.Size = new System.Drawing.Size(121, 28);
			this.cboStopBit.TabIndex = 33;
			this.cboStopBit.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 20);
			this.label4.TabIndex = 32;
			this.label4.Text = "Data Bits";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 20);
			this.label3.TabIndex = 31;
			this.label3.Text = "Parity";
			// 
			// cboParity
			// 
			this.cboParity.FormattingEnabled = true;
			this.cboParity.Items.AddRange(new object[] {
            "None",
            "Event",
            "Odd"});
			this.cboParity.Location = new System.Drawing.Point(157, 125);
			this.cboParity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboParity.Name = "cboParity";
			this.cboParity.Size = new System.Drawing.Size(121, 28);
			this.cboParity.TabIndex = 30;
			this.cboParity.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 20);
			this.label2.TabIndex = 29;
			this.label2.Text = "Baud Rate";
			// 
			// cboBaudRate
			// 
			this.cboBaudRate.FormattingEnabled = true;
			this.cboBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
			this.cboBaudRate.Location = new System.Drawing.Point(157, 74);
			this.cboBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboBaudRate.Name = "cboBaudRate";
			this.cboBaudRate.Size = new System.Drawing.Size(121, 28);
			this.cboBaudRate.TabIndex = 28;
			this.cboBaudRate.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 20);
			this.label1.TabIndex = 27;
			this.label1.Text = "Port Name";
			// 
			// cboPortName
			// 
			this.cboPortName.FormattingEnabled = true;
			this.cboPortName.Location = new System.Drawing.Point(157, 25);
			this.cboPortName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboPortName.Name = "cboPortName";
			this.cboPortName.Size = new System.Drawing.Size(121, 28);
			this.cboPortName.TabIndex = 26;
			this.cboPortName.TabStop = false;
			// 
			// cbPositiveLogic
			// 
			this.cbPositiveLogic.AutoSize = true;
			this.cbPositiveLogic.Location = new System.Drawing.Point(44, 273);
			this.cbPositiveLogic.Name = "cbPositiveLogic";
			this.cbPositiveLogic.Size = new System.Drawing.Size(136, 24);
			this.cbPositiveLogic.TabIndex = 36;
			this.cbPositiveLogic.Text = "Positive Logic";
			this.cbPositiveLogic.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Teal;
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(0, 312);
			this.btnSave.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(329, 52);
			this.btnSave.TabIndex = 90;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FrmPlcSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 364);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cbPositiveLogic);
			this.Controls.Add(this.cboDataBit);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboStopBit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cboParity);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboBaudRate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboPortName);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmPlcSetting";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PLC Communication";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboDataBit;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboStopBit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboParity;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboBaudRate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboPortName;
		private System.Windows.Forms.CheckBox cbPositiveLogic;
		private System.Windows.Forms.Button btnSave;
	}
}