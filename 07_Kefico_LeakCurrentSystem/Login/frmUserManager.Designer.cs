namespace _07_Kefico_LeakCurrentSystem.Login
{
	partial class frmUserManager
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
			this.label4 = new System.Windows.Forms.Label();
			this.txtOperator = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEngineer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboRole = new System.Windows.Forms.ComboBox();
			this.txtAdmin = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Teal;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSave.Location = new System.Drawing.Point(28, 194);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(353, 44);
			this.btnSave.TabIndex = 27;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 154);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 16);
			this.label4.TabIndex = 26;
			this.label4.Text = "Auto login as";
			// 
			// txtOperator
			// 
			this.txtOperator.Location = new System.Drawing.Point(192, 104);
			this.txtOperator.Name = "txtOperator";
			this.txtOperator.Size = new System.Drawing.Size(189, 22);
			this.txtOperator.TabIndex = 25;
			this.txtOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 16);
			this.label3.TabIndex = 24;
			this.label3.Text = "Operator Password";
			// 
			// txtEngineer
			// 
			this.txtEngineer.Location = new System.Drawing.Point(192, 60);
			this.txtEngineer.Name = "txtEngineer";
			this.txtEngineer.Size = new System.Drawing.Size(189, 22);
			this.txtEngineer.TabIndex = 23;
			this.txtEngineer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 16);
			this.label2.TabIndex = 22;
			this.label2.Text = "Engineer Password";
			// 
			// cboRole
			// 
			this.cboRole.FormattingEnabled = true;
			this.cboRole.Items.AddRange(new object[] {
            "None",
            "Operator",
            "Engineer",
            "Admin"});
			this.cboRole.Location = new System.Drawing.Point(192, 148);
			this.cboRole.Name = "cboRole";
			this.cboRole.Size = new System.Drawing.Size(189, 24);
			this.cboRole.TabIndex = 21;
			this.cboRole.TabStop = false;
			// 
			// txtAdmin
			// 
			this.txtAdmin.Location = new System.Drawing.Point(192, 16);
			this.txtAdmin.Name = "txtAdmin";
			this.txtAdmin.Size = new System.Drawing.Size(189, 22);
			this.txtAdmin.TabIndex = 20;
			this.txtAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 16);
			this.label1.TabIndex = 19;
			this.label1.Text = "Admin Password";
			// 
			// frmUserManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 254);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtOperator);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEngineer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboRole);
			this.Controls.Add(this.txtAdmin);
			this.Controls.Add(this.label1);
			this.Name = "frmUserManager";
			this.Text = "User Manager";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtOperator;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEngineer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboRole;
		private System.Windows.Forms.TextBox txtAdmin;
		private System.Windows.Forms.Label label1;
	}
}