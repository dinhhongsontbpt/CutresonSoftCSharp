namespace Seoul_Software.User
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManager));
			this.label1 = new System.Windows.Forms.Label();
			this.txtAdmin = new System.Windows.Forms.TextBox();
			this.cboRole = new System.Windows.Forms.ComboBox();
			this.txtEngineer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOperator = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Admin Password";
			// 
			// txtAdmin
			// 
			this.txtAdmin.Location = new System.Drawing.Point(193, 16);
			this.txtAdmin.Name = "txtAdmin";
			this.txtAdmin.Size = new System.Drawing.Size(189, 26);
			this.txtAdmin.TabIndex = 1;
			this.txtAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cboRole
			// 
			this.cboRole.FormattingEnabled = true;
			this.cboRole.Items.AddRange(new object[] {
            "None",
            "Operator",
            "Engineer",
            "Admin"});
			this.cboRole.Location = new System.Drawing.Point(193, 148);
			this.cboRole.Name = "cboRole";
			this.cboRole.Size = new System.Drawing.Size(189, 28);
			this.cboRole.TabIndex = 2;
			this.cboRole.TabStop = false;
			// 
			// txtEngineer
			// 
			this.txtEngineer.Location = new System.Drawing.Point(193, 60);
			this.txtEngineer.Name = "txtEngineer";
			this.txtEngineer.Size = new System.Drawing.Size(189, 26);
			this.txtEngineer.TabIndex = 4;
			this.txtEngineer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Engineer Password";
			// 
			// txtOperator
			// 
			this.txtOperator.Location = new System.Drawing.Point(193, 104);
			this.txtOperator.Name = "txtOperator";
			this.txtOperator.Size = new System.Drawing.Size(189, 26);
			this.txtOperator.TabIndex = 6;
			this.txtOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Operator Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 154);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Auto login as";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Teal;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSave.Location = new System.Drawing.Point(29, 194);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(353, 44);
			this.btnSave.TabIndex = 18;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmUserManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 253);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtOperator);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEngineer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboRole);
			this.Controls.Add(this.txtAdmin);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(430, 300);
			this.MinimumSize = new System.Drawing.Size(430, 300);
			this.Name = "frmUserManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User Manager";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAdmin;
		private System.Windows.Forms.ComboBox cboRole;
		private System.Windows.Forms.TextBox txtEngineer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOperator;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSave;
	}
}