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
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.lbAlarm = new System.Windows.Forms.Label();
			this.lbAlarmCount = new System.Windows.Forms.Label();
			this.listBox = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtErrorCode = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.imageBox = new Cutreson_UserControl.MyImageBoxEx();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lbErrorHelp = new System.Windows.Forms.Label();
			this.tableLayoutPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.lbAlarm, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.lbAlarmCount, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.listBox, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.panel2, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.imageBox, 1, 3);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 4;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(1130, 673);
			this.tableLayoutPanel.TabIndex = 1;
			// 
			// lbAlarm
			// 
			this.lbAlarm.AutoSize = true;
			this.lbAlarm.BackColor = System.Drawing.Color.Red;
			this.lbAlarm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAlarm.ForeColor = System.Drawing.Color.Black;
			this.lbAlarm.Location = new System.Drawing.Point(255, 82);
			this.lbAlarm.Name = "lbAlarm";
			this.lbAlarm.Size = new System.Drawing.Size(871, 50);
			this.lbAlarm.TabIndex = 10;
			this.lbAlarm.Text = "Error display here..!!";
			this.lbAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbAlarmCount
			// 
			this.lbAlarmCount.AutoSize = true;
			this.lbAlarmCount.BackColor = System.Drawing.Color.Orange;
			this.lbAlarmCount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbAlarmCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAlarmCount.Location = new System.Drawing.Point(4, 1);
			this.lbAlarmCount.Name = "lbAlarmCount";
			this.lbAlarmCount.Size = new System.Drawing.Size(244, 80);
			this.lbAlarmCount.TabIndex = 11;
			this.lbAlarmCount.Text = "Total: 0";
			this.lbAlarmCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listBox
			// 
			this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox.ForeColor = System.Drawing.Color.Red;
			this.listBox.FormattingEnabled = true;
			this.listBox.HorizontalScrollbar = true;
			this.listBox.ItemHeight = 20;
			this.listBox.Location = new System.Drawing.Point(4, 85);
			this.listBox.Name = "listBox";
			this.tableLayoutPanel.SetRowSpan(this.listBox, 3);
			this.listBox.Size = new System.Drawing.Size(244, 584);
			this.listBox.TabIndex = 12;
			this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtDescription);
			this.panel1.Controls.Add(this.txtUnit);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtErrorCode);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(255, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(871, 74);
			this.panel1.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Error Code";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Description";
			// 
			// txtErrorCode
			// 
			this.txtErrorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtErrorCode.ForeColor = System.Drawing.Color.Red;
			this.txtErrorCode.Location = new System.Drawing.Point(125, 7);
			this.txtErrorCode.Name = "txtErrorCode";
			this.txtErrorCode.Size = new System.Drawing.Size(81, 26);
			this.txtErrorCode.TabIndex = 2;
			this.txtErrorCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(238, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Unit";
			// 
			// txtUnit
			// 
			this.txtUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnit.Location = new System.Drawing.Point(302, 7);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(561, 26);
			this.txtUnit.TabIndex = 4;
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescription.Location = new System.Drawing.Point(125, 39);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(738, 26);
			this.txtDescription.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tableLayoutPanel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(255, 136);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(871, 64);
			this.panel2.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Lime;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 64);
			this.label4.TabIndex = 6;
			this.label4.Text = "Error Help";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// imageBox
			// 
			this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imageBox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
			this.imageBox.GridColorAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.imageBox.Location = new System.Drawing.Point(255, 207);
			this.imageBox.Name = "imageBox";
			this.imageBox.Size = new System.Drawing.Size(871, 462);
			this.imageBox.TabIndex = 15;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.lbErrorHelp, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 64);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lbErrorHelp
			// 
			this.lbErrorHelp.AutoSize = true;
			this.lbErrorHelp.BackColor = System.Drawing.SystemColors.Control;
			this.lbErrorHelp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbErrorHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbErrorHelp.ForeColor = System.Drawing.Color.MediumBlue;
			this.lbErrorHelp.Location = new System.Drawing.Point(133, 0);
			this.lbErrorHelp.Name = "lbErrorHelp";
			this.lbErrorHelp.Size = new System.Drawing.Size(735, 64);
			this.lbErrorHelp.TabIndex = 7;
			this.lbErrorHelp.Text = "Error Help";
			this.lbErrorHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmAlarm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1130, 673);
			this.Controls.Add(this.tableLayoutPanel);
			this.Name = "frmAlarm";
			this.Text = "frmAlarm";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label lbAlarm;
		private System.Windows.Forms.Label lbAlarmCount;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtErrorCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private Cutreson_UserControl.MyImageBoxEx imageBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lbErrorHelp;
	}
}