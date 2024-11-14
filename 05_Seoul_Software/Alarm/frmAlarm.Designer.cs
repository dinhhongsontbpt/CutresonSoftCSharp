namespace Seoul_Software.Alarm
{
	partial class frmAlarm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lbAlarm = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.lbAlarm, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1330, 55);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lbAlarm
			// 
			this.lbAlarm.AutoSize = true;
			this.lbAlarm.BackColor = System.Drawing.Color.Red;
			this.lbAlarm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAlarm.ForeColor = System.Drawing.Color.Black;
			this.lbAlarm.Location = new System.Drawing.Point(3, 0);
			this.lbAlarm.Name = "lbAlarm";
			this.lbAlarm.Size = new System.Drawing.Size(1324, 55);
			this.lbAlarm.TabIndex = 9;
			this.lbAlarm.Text = "Alarm display here..!!";
			this.lbAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmAlarm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1330, 55);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "frmAlarm";
			this.Text = "frmAlarm";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lbAlarm;
	}
}