namespace _06_Terumo
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnCommandSetting = new System.Windows.Forms.ToolStripButton();
			this.btnSetting = new System.Windows.Forms.ToolStripButton();
			this.btnExit = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelFooter = new System.Windows.Forms.TableLayoutPanel();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelBuildDate = new System.Windows.Forms.Label();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxLog = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbOutput = new System.Windows.Forms.TableLayoutPanel();
			this.tbLampOutput = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbInput = new System.Windows.Forms.TableLayoutPanel();
			this.tbLampInput = new System.Windows.Forms.TableLayoutPanel();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanelMain.SuspendLayout();
			this.tableLayoutPanelFooter.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCommandSetting,
            this.btnSetting,
            this.btnExit});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(978, 31);
			this.toolStrip1.TabIndex = 5;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnCommandSetting
			// 
			this.btnCommandSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnCommandSetting.Image = global::_06_Terumo.Properties.Resources.Edit1;
			this.btnCommandSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCommandSetting.Name = "btnCommandSetting";
			this.btnCommandSetting.Size = new System.Drawing.Size(29, 28);
			this.btnCommandSetting.Text = "Command Keys";
			this.btnCommandSetting.Click += new System.EventHandler(this.btnCommandSetting_Click);
			// 
			// btnSetting
			// 
			this.btnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnSetting.Image = global::_06_Terumo.Properties.Resources.SystemSetting;
			this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(29, 28);
			this.btnSetting.Text = "Setting";
			this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
			// 
			// btnExit
			// 
			this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnExit.Image = global::_06_Terumo.Properties.Resources.iclogout;
			this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(29, 28);
			this.btnExit.Text = "Exit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 1;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelFooter, 0, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 31);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 2;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(978, 660);
			this.tableLayoutPanelMain.TabIndex = 8;
			// 
			// tableLayoutPanelFooter
			// 
			this.tableLayoutPanelFooter.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanelFooter.ColumnCount = 2;
			this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelFooter.Controls.Add(this.labelVersion, 0, 0);
			this.tableLayoutPanelFooter.Controls.Add(this.labelBuildDate, 0, 0);
			this.tableLayoutPanelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelFooter.Location = new System.Drawing.Point(3, 633);
			this.tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
			this.tableLayoutPanelFooter.RowCount = 1;
			this.tableLayoutPanelFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelFooter.Size = new System.Drawing.Size(972, 24);
			this.tableLayoutPanelFooter.TabIndex = 8;
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.BackColor = System.Drawing.SystemColors.Control;
			this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.labelVersion.Location = new System.Drawing.Point(489, 0);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(480, 24);
			this.labelVersion.TabIndex = 14;
			this.labelVersion.Text = "Version: V1.0";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelBuildDate
			// 
			this.labelBuildDate.AutoSize = true;
			this.labelBuildDate.BackColor = System.Drawing.SystemColors.Control;
			this.labelBuildDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBuildDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBuildDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.labelBuildDate.Location = new System.Drawing.Point(3, 0);
			this.labelBuildDate.Name = "labelBuildDate";
			this.labelBuildDate.Size = new System.Drawing.Size(480, 24);
			this.labelBuildDate.TabIndex = 13;
			this.labelBuildDate.Text = "Built: 2024/10/18";
			this.labelBuildDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.Controls.Add(this.groupBoxLog, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.groupBox2, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 2;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(970, 622);
			this.tableLayoutPanel.TabIndex = 9;
			// 
			// groupBoxLog
			// 
			this.tableLayoutPanel.SetColumnSpan(this.groupBoxLog, 2);
			this.groupBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxLog.Location = new System.Drawing.Point(5, 315);
			this.groupBoxLog.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxLog.Name = "groupBoxLog";
			this.groupBoxLog.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxLog.Size = new System.Drawing.Size(960, 302);
			this.groupBoxLog.TabIndex = 2;
			this.groupBoxLog.TabStop = false;
			this.groupBoxLog.Text = "System Log";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbOutput);
			this.groupBox2.Controls.Add(this.tbLampOutput);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(489, 5);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(476, 301);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Output";
			// 
			// tbOutput
			// 
			this.tbOutput.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tbOutput.ColumnCount = 1;
			this.tbOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbOutput.Location = new System.Drawing.Point(54, 23);
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.RowCount = 1;
			this.tbOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbOutput.Size = new System.Drawing.Size(418, 274);
			this.tbOutput.TabIndex = 2;
			// 
			// tbLampOutput
			// 
			this.tbLampOutput.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tbLampOutput.ColumnCount = 1;
			this.tbLampOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbLampOutput.Dock = System.Windows.Forms.DockStyle.Left;
			this.tbLampOutput.Location = new System.Drawing.Point(4, 23);
			this.tbLampOutput.Name = "tbLampOutput";
			this.tbLampOutput.RowCount = 1;
			this.tbLampOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbLampOutput.Size = new System.Drawing.Size(50, 274);
			this.tbLampOutput.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbInput);
			this.groupBox1.Controls.Add(this.tbLampInput);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(5, 5);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(475, 301);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input";
			// 
			// tbInput
			// 
			this.tbInput.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tbInput.ColumnCount = 1;
			this.tbInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbInput.Location = new System.Drawing.Point(54, 23);
			this.tbInput.Name = "tbInput";
			this.tbInput.RowCount = 1;
			this.tbInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbInput.Size = new System.Drawing.Size(417, 274);
			this.tbInput.TabIndex = 1;
			// 
			// tbLampInput
			// 
			this.tbLampInput.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tbLampInput.ColumnCount = 1;
			this.tbLampInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbLampInput.Dock = System.Windows.Forms.DockStyle.Left;
			this.tbLampInput.Location = new System.Drawing.Point(4, 23);
			this.tbLampInput.Name = "tbLampInput";
			this.tbLampInput.RowCount = 1;
			this.tbLampInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbLampInput.Size = new System.Drawing.Size(50, 274);
			this.tbLampInput.TabIndex = 0;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 691);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(100000, 100000);
			this.MinimumSize = new System.Drawing.Size(996, 738);
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Interface for Nortec 600";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelFooter.ResumeLayout(false);
			this.tableLayoutPanelFooter.PerformLayout();
			this.tableLayoutPanel.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnSetting;
		private System.Windows.Forms.ToolStripButton btnCommandSetting;
		private System.Windows.Forms.ToolStripButton btnExit;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.GroupBox groupBoxLog;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TableLayoutPanel tbOutput;
		private System.Windows.Forms.TableLayoutPanel tbLampOutput;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tbInput;
		private System.Windows.Forms.TableLayoutPanel tbLampInput;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFooter;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label labelBuildDate;
	}
}

