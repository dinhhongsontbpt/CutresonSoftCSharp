namespace Seoul_Software.History
{
	partial class frmHistoryMenu
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoryMenu));
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.button3 = new System.Windows.Forms.Button();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.btnTitle = new System.Windows.Forms.Button();
			this.panelLeft = new System.Windows.Forms.Panel();
			this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
			this.btnErrorHistory = new System.Windows.Forms.Button();
			this.btnAlarmHistory = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.tableLayoutPanel.SuspendLayout();
			this.panelLeft.SuspendLayout();
			this.tableLayoutPanelLeft.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.button3, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.btnTitle, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.panelLeft, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.panelMain, 1, 1);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 2;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(1067, 554);
			this.tableLayoutPanel.TabIndex = 1;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Yellow;
			this.button3.ImageList = this.imageList;
			this.button3.Location = new System.Drawing.Point(1, 1);
			this.button3.Margin = new System.Windows.Forms.Padding(0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(267, 62);
			this.button3.TabIndex = 7;
			this.button3.Text = "HISTORY";
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "SettingWhite.png");
			this.imageList.Images.SetKeyName(1, "UserGroup.ico");
			this.imageList.Images.SetKeyName(2, "DatabaseView.ico");
			this.imageList.Images.SetKeyName(3, "Home.ico");
			this.imageList.Images.SetKeyName(4, "worker.png");
			this.imageList.Images.SetKeyName(5, "history.png");
			this.imageList.Images.SetKeyName(6, "file.png");
			this.imageList.Images.SetKeyName(7, "iclogout.png");
			this.imageList.Images.SetKeyName(8, "Keyboard.png");
			// 
			// btnTitle
			// 
			this.btnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
			this.btnTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTitle.ForeColor = System.Drawing.Color.Cyan;
			this.btnTitle.ImageIndex = 0;
			this.btnTitle.Location = new System.Drawing.Point(269, 1);
			this.btnTitle.Margin = new System.Windows.Forms.Padding(0);
			this.btnTitle.Name = "btnTitle";
			this.btnTitle.Size = new System.Drawing.Size(797, 62);
			this.btnTitle.TabIndex = 6;
			this.btnTitle.Text = "TITLE";
			this.btnTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTitle.UseVisualStyleBackColor = false;
			// 
			// panelLeft
			// 
			this.panelLeft.Controls.Add(this.tableLayoutPanelLeft);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLeft.Location = new System.Drawing.Point(5, 68);
			this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(259, 481);
			this.panelLeft.TabIndex = 0;
			// 
			// tableLayoutPanelLeft
			// 
			this.tableLayoutPanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tableLayoutPanelLeft.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
			this.tableLayoutPanelLeft.ColumnCount = 1;
			this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLeft.Controls.Add(this.btnErrorHistory, 0, 1);
			this.tableLayoutPanelLeft.Controls.Add(this.btnAlarmHistory, 0, 0);
			this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
			this.tableLayoutPanelLeft.RowCount = 3;
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLeft.Size = new System.Drawing.Size(259, 481);
			this.tableLayoutPanelLeft.TabIndex = 0;
			// 
			// btnErrorHistory
			// 
			this.btnErrorHistory.BackColor = System.Drawing.Color.DarkMagenta;
			this.btnErrorHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnErrorHistory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnErrorHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnErrorHistory.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnErrorHistory.ForeColor = System.Drawing.Color.White;
			this.btnErrorHistory.ImageIndex = 3;
			this.btnErrorHistory.Location = new System.Drawing.Point(3, 68);
			this.btnErrorHistory.Margin = new System.Windows.Forms.Padding(0);
			this.btnErrorHistory.Name = "btnErrorHistory";
			this.btnErrorHistory.Size = new System.Drawing.Size(253, 62);
			this.btnErrorHistory.TabIndex = 52;
			this.btnErrorHistory.Text = "ALARM HISTORY";
			this.btnErrorHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnErrorHistory.UseVisualStyleBackColor = false;
			this.btnErrorHistory.Click += new System.EventHandler(this.btnErrorHistory_Click);
			// 
			// btnAlarmHistory
			// 
			this.btnAlarmHistory.BackColor = System.Drawing.Color.DarkMagenta;
			this.btnAlarmHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAlarmHistory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAlarmHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAlarmHistory.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlarmHistory.ForeColor = System.Drawing.Color.White;
			this.btnAlarmHistory.ImageIndex = 3;
			this.btnAlarmHistory.Location = new System.Drawing.Point(3, 3);
			this.btnAlarmHistory.Margin = new System.Windows.Forms.Padding(0);
			this.btnAlarmHistory.Name = "btnAlarmHistory";
			this.btnAlarmHistory.Size = new System.Drawing.Size(253, 62);
			this.btnAlarmHistory.TabIndex = 51;
			this.btnAlarmHistory.Text = "WARNING HISTORY";
			this.btnAlarmHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAlarmHistory.UseVisualStyleBackColor = false;
			this.btnAlarmHistory.Click += new System.EventHandler(this.btnAlarmHistory_Click);
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(273, 68);
			this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(789, 481);
			this.panelMain.TabIndex = 3;
			// 
			// frmHistoryMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.tableLayoutPanel);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmHistoryMenu";
			this.Text = "frmHistoryMenu";
			this.tableLayoutPanel.ResumeLayout(false);
			this.panelLeft.ResumeLayout(false);
			this.tableLayoutPanelLeft.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.Button btnTitle;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
		private System.Windows.Forms.Button btnErrorHistory;
		private System.Windows.Forms.Button btnAlarmHistory;
		private System.Windows.Forms.Panel panelMain;
	}
}