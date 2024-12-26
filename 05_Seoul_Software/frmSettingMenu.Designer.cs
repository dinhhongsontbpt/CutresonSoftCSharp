namespace Seoul_Software
{
	partial class frmSettingMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingMenu));
			this.btnTitle = new System.Windows.Forms.Button();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.panelLeft = new System.Windows.Forms.Panel();
			this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
			this.btnPLC = new System.Windows.Forms.Button();
			this.btnPrinter = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.btnSystem = new System.Windows.Forms.Button();
			this.btnUser = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			this.panelLeft.SuspendLayout();
			this.tableLayoutPanelLeft.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnTitle
			// 
			this.btnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
			this.btnTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTitle.ForeColor = System.Drawing.Color.Cyan;
			this.btnTitle.ImageIndex = 0;
			this.btnTitle.Location = new System.Drawing.Point(202, 1);
			this.btnTitle.Margin = new System.Windows.Forms.Padding(0);
			this.btnTitle.Name = "btnTitle";
			this.btnTitle.Size = new System.Drawing.Size(840, 50);
			this.btnTitle.TabIndex = 4;
			this.btnTitle.Text = "TITLE";
			this.btnTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTitle.UseVisualStyleBackColor = false;
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
			this.imageList.Images.SetKeyName(9, "Printer.ico");
			this.imageList.Images.SetKeyName(10, "Setting123.png");
			this.imageList.Images.SetKeyName(11, "UsbConnector.ico");
			this.imageList.Images.SetKeyName(12, "UserGroup.ico");
			this.imageList.Images.SetKeyName(13, "ArrowRight.ico");
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.button3, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.panelLeft, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.panelMain, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.btnTitle, 1, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 2;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(1043, 527);
			this.tableLayoutPanel.TabIndex = 1;
			// 
			// panelLeft
			// 
			this.panelLeft.Controls.Add(this.tableLayoutPanelLeft);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLeft.Location = new System.Drawing.Point(4, 55);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(194, 468);
			this.panelLeft.TabIndex = 0;
			// 
			// tableLayoutPanelLeft
			// 
			this.tableLayoutPanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tableLayoutPanelLeft.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
			this.tableLayoutPanelLeft.ColumnCount = 1;
			this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLeft.Controls.Add(this.btnUser, 0, 3);
			this.tableLayoutPanelLeft.Controls.Add(this.btnSystem, 0, 2);
			this.tableLayoutPanelLeft.Controls.Add(this.btnPLC, 0, 1);
			this.tableLayoutPanelLeft.Controls.Add(this.btnPrinter, 0, 0);
			this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
			this.tableLayoutPanelLeft.RowCount = 5;
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLeft.Size = new System.Drawing.Size(194, 468);
			this.tableLayoutPanelLeft.TabIndex = 0;
			// 
			// btnPLC
			// 
			this.btnPLC.BackColor = System.Drawing.Color.DarkMagenta;
			this.btnPLC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPLC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPLC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPLC.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPLC.ForeColor = System.Drawing.Color.White;
			this.btnPLC.ImageIndex = 13;
			this.btnPLC.ImageList = this.imageList;
			this.btnPLC.Location = new System.Drawing.Point(3, 56);
			this.btnPLC.Margin = new System.Windows.Forms.Padding(0);
			this.btnPLC.Name = "btnPLC";
			this.btnPLC.Size = new System.Drawing.Size(188, 50);
			this.btnPLC.TabIndex = 52;
			this.btnPLC.Text = " CONNECTION";
			this.btnPLC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPLC.UseVisualStyleBackColor = false;
			this.btnPLC.Click += new System.EventHandler(this.btnPLC_Click);
			// 
			// btnPrinter
			// 
			this.btnPrinter.BackColor = System.Drawing.Color.DarkMagenta;
			this.btnPrinter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPrinter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrinter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPrinter.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrinter.ForeColor = System.Drawing.Color.White;
			this.btnPrinter.ImageIndex = 9;
			this.btnPrinter.ImageList = this.imageList;
			this.btnPrinter.Location = new System.Drawing.Point(3, 3);
			this.btnPrinter.Margin = new System.Windows.Forms.Padding(0);
			this.btnPrinter.Name = "btnPrinter";
			this.btnPrinter.Size = new System.Drawing.Size(188, 50);
			this.btnPrinter.TabIndex = 51;
			this.btnPrinter.Text = " PRINTER";
			this.btnPrinter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrinter.UseVisualStyleBackColor = false;
			this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(205, 55);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(834, 468);
			this.panelMain.TabIndex = 3;
			// 
			// btnSystem
			// 
			this.btnSystem.BackColor = System.Drawing.Color.DarkMagenta;
			this.btnSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSystem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSystem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSystem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSystem.ForeColor = System.Drawing.Color.White;
			this.btnSystem.ImageIndex = 10;
			this.btnSystem.ImageList = this.imageList;
			this.btnSystem.Location = new System.Drawing.Point(3, 109);
			this.btnSystem.Margin = new System.Windows.Forms.Padding(0);
			this.btnSystem.Name = "btnSystem";
			this.btnSystem.Size = new System.Drawing.Size(188, 50);
			this.btnSystem.TabIndex = 53;
			this.btnSystem.Text = " SYSTEM";
			this.btnSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSystem.UseVisualStyleBackColor = false;
			this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
			// 
			// btnUser
			// 
			this.btnUser.BackColor = System.Drawing.Color.DarkMagenta;
			this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnUser.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUser.ForeColor = System.Drawing.Color.White;
			this.btnUser.ImageIndex = 1;
			this.btnUser.ImageList = this.imageList;
			this.btnUser.Location = new System.Drawing.Point(3, 162);
			this.btnUser.Margin = new System.Windows.Forms.Padding(0);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(188, 50);
			this.btnUser.TabIndex = 54;
			this.btnUser.Text = " USER MANAGER";
			this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUser.UseVisualStyleBackColor = false;
			this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Yellow;
			this.button3.ImageIndex = 0;
			this.button3.ImageList = this.imageList;
			this.button3.Location = new System.Drawing.Point(1, 1);
			this.button3.Margin = new System.Windows.Forms.Padding(0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(200, 50);
			this.button3.TabIndex = 5;
			this.button3.Text = " SETTING";
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// frmSettingMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1043, 527);
			this.Controls.Add(this.tableLayoutPanel);
			this.Name = "frmSettingMenu";
			this.Text = "frmSettingMenu";
			this.tableLayoutPanel.ResumeLayout(false);
			this.panelLeft.ResumeLayout(false);
			this.tableLayoutPanelLeft.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnTitle;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
		private System.Windows.Forms.Button btnPLC;
		private System.Windows.Forms.Button btnPrinter;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button btnSystem;
		private System.Windows.Forms.Button button3;
	}
}