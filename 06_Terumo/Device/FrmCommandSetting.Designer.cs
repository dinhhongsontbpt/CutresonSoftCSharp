namespace _06_Terumo
{
	partial class FrmCommandSetting
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCommandSetting));
			this.btnSave = new System.Windows.Forms.Button();
			this.tbInput = new System.Windows.Forms.TableLayoutPanel();
			this.tbLampInput = new System.Windows.Forms.TableLayoutPanel();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Teal;
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(0, 401);
			this.btnSave.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(482, 52);
			this.btnSave.TabIndex = 89;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tbInput
			// 
			this.tbInput.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tbInput.ColumnCount = 1;
			this.tbInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbInput.Location = new System.Drawing.Point(62, 0);
			this.tbInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbInput.Name = "tbInput";
			this.tbInput.RowCount = 1;
			this.tbInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbInput.Size = new System.Drawing.Size(420, 401);
			this.tbInput.TabIndex = 91;
			// 
			// tbLampInput
			// 
			this.tbLampInput.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tbLampInput.ColumnCount = 1;
			this.tbLampInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbLampInput.Dock = System.Windows.Forms.DockStyle.Left;
			this.tbLampInput.Location = new System.Drawing.Point(0, 0);
			this.tbLampInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbLampInput.Name = "tbLampInput";
			this.tbLampInput.RowCount = 1;
			this.tbLampInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbLampInput.Size = new System.Drawing.Size(62, 401);
			this.tbLampInput.TabIndex = 90;
			// 
			// FrmCommandSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 453);
			this.Controls.Add(this.tbInput);
			this.Controls.Add(this.tbLampInput);
			this.Controls.Add(this.btnSave);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmCommandSetting";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Command Setting";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TableLayoutPanel tbInput;
		private System.Windows.Forms.TableLayoutPanel tbLampInput;
	}
}