namespace _07_Kefico_LeakCurrentSystem.PLC
{
	partial class frmPlcSetting
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
			this.btnSave.Location = new System.Drawing.Point(25, 79);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(399, 34);
			this.btnSave.TabIndex = 21;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 16);
			this.label1.TabIndex = 17;
			this.label1.Text = "IP Address";
			// 
			// txtIp
			// 
			this.txtIp.Location = new System.Drawing.Point(115, 22);
			this.txtIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtIp.Name = "txtIp";
			this.txtIp.Size = new System.Drawing.Size(145, 22);
			this.txtIp.TabIndex = 18;
			this.txtIp.Text = "192.168.3.28";
			this.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(339, 22);
			this.txtPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(85, 22);
			this.txtPort.TabIndex = 19;
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
			this.label2.Location = new System.Drawing.Point(289, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Port";
			// 
			// frmPlcSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 141);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtIp);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.label2);
			this.Name = "frmPlcSetting";
			this.Text = "Connection";
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