namespace Seoul_Software.PLC
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
			this.btnSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIp = new System.Windows.Forms.TextBox();
			this.txtPort = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.txtPort)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Teal;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSave.Location = new System.Drawing.Point(41, 88);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(399, 35);
			this.btnSave.TabIndex = 16;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "IP Address";
			// 
			// txtIp
			// 
			this.txtIp.Location = new System.Drawing.Point(131, 32);
			this.txtIp.Name = "txtIp";
			this.txtIp.Size = new System.Drawing.Size(145, 22);
			this.txtIp.TabIndex = 13;
			this.txtIp.Text = "192.168.3.28";
			this.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(354, 32);
			this.txtPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(86, 22);
			this.txtPort.TabIndex = 14;
			this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPort.Value = new decimal(new int[] {
            6666,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(305, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 16);
			this.label2.TabIndex = 15;
			this.label2.Text = "Port";
			// 
			// FrmPlcSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 150);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtIp);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmPlcSetting";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PLC Setting";
			((System.ComponentModel.ISupportInitialize)(this.txtPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIp;
		private System.Windows.Forms.NumericUpDown txtPort;
		private System.Windows.Forms.Label label2;
	}
}