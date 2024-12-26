using Cutreson_UserControl;
namespace _07_Kefico_LeakCurrentSystem
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.labelBuildDate = new System.Windows.Forms.Label();
			this.tableLayoutPanelFooter = new System.Windows.Forms.TableLayoutPanel();
			this.lbCompanyName = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.pictureBoxCompanyLogo = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.ucDateTime = new Cutreson_UserControl.UcDateTime();
			this.lbTitle = new System.Windows.Forms.Label();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.panel = new System.Windows.Forms.Panel();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.panelMain = new System.Windows.Forms.Panel();
			this.panelRight = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.listBoxLog = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lampPlcAlive = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ucPcInfo = new Cutreson_UserControl.UspcInfor();
			this.tableLayoutPanelTabButton = new System.Windows.Forms.TableLayoutPanel();
			this.btnKeyBoardSimu = new System.Windows.Forms.Button();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.btnExit = new System.Windows.Forms.Button();
			this.btnUser = new System.Windows.Forms.Button();
			this.btnSettingSystem = new System.Windows.Forms.Button();
			this.btnDataLog = new System.Windows.Forms.Button();
			this.btnAuto = new System.Windows.Forms.Button();
			this.MainPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
			this.contextMenuStripSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.printerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStripData = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.lotDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ringDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanelFooter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompanyLogo)).BeginInit();
			this.tableLayoutPanel.SuspendLayout();
			this.panelTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.panel.SuspendLayout();
			this.tableLayoutPanelMain.SuspendLayout();
			this.panelRight.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanelTabButton.SuspendLayout();
			this.contextMenuStripSetting.SuspendLayout();
			this.contextMenuStripData.SuspendLayout();
			this.SuspendLayout();
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
			this.labelBuildDate.Size = new System.Drawing.Size(276, 35);
			this.labelBuildDate.TabIndex = 13;
			this.labelBuildDate.Text = "Built: 2024/10/18";
			this.labelBuildDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanelFooter
			// 
			this.tableLayoutPanelFooter.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanelFooter.ColumnCount = 4;
			this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanelFooter.Controls.Add(this.lbCompanyName, 2, 0);
			this.tableLayoutPanelFooter.Controls.Add(this.labelVersion, 0, 0);
			this.tableLayoutPanelFooter.Controls.Add(this.labelBuildDate, 0, 0);
			this.tableLayoutPanelFooter.Controls.Add(this.pictureBoxCompanyLogo, 3, 0);
			this.tableLayoutPanelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelFooter.Location = new System.Drawing.Point(3, 671);
			this.tableLayoutPanelFooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
			this.tableLayoutPanelFooter.RowCount = 1;
			this.tableLayoutPanelFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelFooter.Size = new System.Drawing.Size(1470, 35);
			this.tableLayoutPanelFooter.TabIndex = 5;
			// 
			// lbCompanyName
			// 
			this.lbCompanyName.AutoSize = true;
			this.lbCompanyName.BackColor = System.Drawing.SystemColors.Control;
			this.lbCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.lbCompanyName.Location = new System.Drawing.Point(1131, 0);
			this.lbCompanyName.Name = "lbCompanyName";
			this.lbCompanyName.Size = new System.Drawing.Size(276, 35);
			this.lbCompanyName.TabIndex = 15;
			this.lbCompanyName.Text = "SORA.Co, Ltd";
			this.lbCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.BackColor = System.Drawing.SystemColors.Control;
			this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.labelVersion.Location = new System.Drawing.Point(285, 0);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(840, 35);
			this.labelVersion.TabIndex = 14;
			this.labelVersion.Text = "Version: V1.0";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxCompanyLogo
			// 
			this.pictureBoxCompanyLogo.BackgroundImage = global::_07_Kefico_LeakCurrentSystem.Properties.Resources.LogoSORA;
			this.pictureBoxCompanyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxCompanyLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxCompanyLogo.Location = new System.Drawing.Point(1413, 2);
			this.pictureBoxCompanyLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBoxCompanyLogo.Name = "pictureBoxCompanyLogo";
			this.pictureBoxCompanyLogo.Size = new System.Drawing.Size(54, 31);
			this.pictureBoxCompanyLogo.TabIndex = 16;
			this.pictureBoxCompanyLogo.TabStop = false;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.BackColor = System.Drawing.Color.Lavender;
			this.tableLayoutPanel.ColumnCount = 1;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelFooter, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.panelTitle, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.panel, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelTabButton, 0, 1);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 4;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(1476, 708);
			this.tableLayoutPanel.TabIndex = 2;
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelTitle.Controls.Add(this.ucDateTime);
			this.panelTitle.Controls.Add(this.lbTitle);
			this.panelTitle.Controls.Add(this.pbLogo);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
			this.panelTitle.Location = new System.Drawing.Point(3, 2);
			this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(1470, 70);
			this.panelTitle.TabIndex = 4;
			// 
			// ucDateTime
			// 
			this.ucDateTime.BackColor = System.Drawing.Color.Transparent;
			this.ucDateTime.Dock = System.Windows.Forms.DockStyle.Right;
			this.ucDateTime.IsRun = false;
			this.ucDateTime.Location = new System.Drawing.Point(1057, 0);
			this.ucDateTime.Margin = new System.Windows.Forms.Padding(5);
			this.ucDateTime.Name = "ucDateTime";
			this.ucDateTime.Size = new System.Drawing.Size(413, 70);
			this.ucDateTime.TabIndex = 3;
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.lbTitle.ForeColor = System.Drawing.Color.DarkBlue;
			this.lbTitle.Location = new System.Drawing.Point(157, 15);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(354, 39);
			this.lbTitle.TabIndex = 1;
			this.lbTitle.Text = "Leak Current System";
			// 
			// pbLogo
			// 
			this.pbLogo.BackColor = System.Drawing.Color.White;
			this.pbLogo.BackgroundImage = global::_07_Kefico_LeakCurrentSystem.Properties.Resources.logoKefico;
			this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbLogo.Location = new System.Drawing.Point(0, 2);
			this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(151, 66);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbLogo.TabIndex = 0;
			this.pbLogo.TabStop = false;
			// 
			// panel
			// 
			this.panel.Controls.Add(this.tableLayoutPanelMain);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(3, 138);
			this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(1470, 529);
			this.panel.TabIndex = 6;
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanelMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanelMain.ColumnCount = 2;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302F));
			this.tableLayoutPanelMain.Controls.Add(this.panelMain, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.panelRight, 1, 0);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 1;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(1470, 529);
			this.tableLayoutPanelMain.TabIndex = 1;
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(1, 1);
			this.panelMain.Margin = new System.Windows.Forms.Padding(0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(1165, 527);
			this.panelMain.TabIndex = 4;
			// 
			// panelRight
			// 
			this.panelRight.Controls.Add(this.groupBox3);
			this.panelRight.Controls.Add(this.groupBox2);
			this.panelRight.Controls.Add(this.groupBox1);
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelRight.Location = new System.Drawing.Point(1170, 4);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(296, 521);
			this.panelRight.TabIndex = 5;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.listBoxLog);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(0, 199);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(296, 318);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "System Log";
			// 
			// listBoxLog
			// 
			this.listBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxLog.FormattingEnabled = true;
			this.listBoxLog.HorizontalScrollbar = true;
			this.listBoxLog.ItemHeight = 18;
			this.listBoxLog.Location = new System.Drawing.Point(3, 22);
			this.listBoxLog.Name = "listBoxLog";
			this.listBoxLog.Size = new System.Drawing.Size(290, 293);
			this.listBoxLog.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lampPlcAlive);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(0, 122);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(296, 78);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "PLC";
			// 
			// lampPlcAlive
			// 
			this.lampPlcAlive.AutoSize = true;
			this.lampPlcAlive.BackColor = System.Drawing.Color.Red;
			this.lampPlcAlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lampPlcAlive.Location = new System.Drawing.Point(76, 38);
			this.lampPlcAlive.Name = "lampPlcAlive";
			this.lampPlcAlive.Size = new System.Drawing.Size(34, 20);
			this.lampPlcAlive.TabIndex = 44;
			this.lampPlcAlive.Text = "     ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Alive";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ucPcInfo);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(296, 122);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "PC Info";
			// 
			// ucPcInfo
			// 
			this.ucPcInfo.BackColor = System.Drawing.Color.Transparent;
			this.ucPcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPcInfo.IsRun = false;
			this.ucPcInfo.Location = new System.Drawing.Point(3, 22);
			this.ucPcInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ucPcInfo.Name = "ucPcInfo";
			this.ucPcInfo.Size = new System.Drawing.Size(290, 97);
			this.ucPcInfo.TabIndex = 1;
			// 
			// tableLayoutPanelTabButton
			// 
			this.tableLayoutPanelTabButton.BackColor = System.Drawing.Color.Lavender;
			this.tableLayoutPanelTabButton.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanelTabButton.ColumnCount = 6;
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelTabButton.Controls.Add(this.btnKeyBoardSimu, 4, 0);
			this.tableLayoutPanelTabButton.Controls.Add(this.btnExit, 5, 0);
			this.tableLayoutPanelTabButton.Controls.Add(this.btnUser, 3, 0);
			this.tableLayoutPanelTabButton.Controls.Add(this.btnSettingSystem, 2, 0);
			this.tableLayoutPanelTabButton.Controls.Add(this.btnDataLog, 1, 0);
			this.tableLayoutPanelTabButton.Controls.Add(this.btnAuto, 0, 0);
			this.tableLayoutPanelTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelTabButton.Location = new System.Drawing.Point(4, 78);
			this.tableLayoutPanelTabButton.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanelTabButton.Name = "tableLayoutPanelTabButton";
			this.tableLayoutPanelTabButton.RowCount = 1;
			this.tableLayoutPanelTabButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelTabButton.Size = new System.Drawing.Size(1468, 54);
			this.tableLayoutPanelTabButton.TabIndex = 7;
			// 
			// btnKeyBoardSimu
			// 
			this.btnKeyBoardSimu.BackColor = System.Drawing.Color.Teal;
			this.btnKeyBoardSimu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnKeyBoardSimu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKeyBoardSimu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnKeyBoardSimu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKeyBoardSimu.ForeColor = System.Drawing.Color.White;
			this.btnKeyBoardSimu.ImageIndex = 8;
			this.btnKeyBoardSimu.ImageList = this.imageList;
			this.btnKeyBoardSimu.Location = new System.Drawing.Point(977, 1);
			this.btnKeyBoardSimu.Margin = new System.Windows.Forms.Padding(0);
			this.btnKeyBoardSimu.Name = "btnKeyBoardSimu";
			this.btnKeyBoardSimu.Size = new System.Drawing.Size(243, 52);
			this.btnKeyBoardSimu.TabIndex = 57;
			this.btnKeyBoardSimu.Text = "KEYBOARD";
			this.btnKeyBoardSimu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnKeyBoardSimu.UseVisualStyleBackColor = false;
			this.btnKeyBoardSimu.Click += new System.EventHandler(this.btnKeyBoardSimu_Click);
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "");
			this.imageList.Images.SetKeyName(1, "");
			this.imageList.Images.SetKeyName(2, "");
			this.imageList.Images.SetKeyName(3, "");
			this.imageList.Images.SetKeyName(4, "");
			this.imageList.Images.SetKeyName(5, "");
			this.imageList.Images.SetKeyName(6, "");
			this.imageList.Images.SetKeyName(7, "");
			this.imageList.Images.SetKeyName(8, "");
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Teal;
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.ImageIndex = 7;
			this.btnExit.ImageList = this.imageList;
			this.btnExit.Location = new System.Drawing.Point(1221, 1);
			this.btnExit.Margin = new System.Windows.Forms.Padding(0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(246, 52);
			this.btnExit.TabIndex = 56;
			this.btnExit.Text = " EXIT";
			this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnUser
			// 
			this.btnUser.BackColor = System.Drawing.Color.Teal;
			this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnUser.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUser.ForeColor = System.Drawing.Color.White;
			this.btnUser.ImageIndex = 1;
			this.btnUser.ImageList = this.imageList;
			this.btnUser.Location = new System.Drawing.Point(733, 1);
			this.btnUser.Margin = new System.Windows.Forms.Padding(0);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(243, 52);
			this.btnUser.TabIndex = 54;
			this.btnUser.Text = " USER";
			this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUser.UseVisualStyleBackColor = false;
			this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
			// 
			// btnSettingSystem
			// 
			this.btnSettingSystem.BackColor = System.Drawing.Color.Teal;
			this.btnSettingSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSettingSystem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSettingSystem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSettingSystem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSettingSystem.ForeColor = System.Drawing.Color.White;
			this.btnSettingSystem.ImageIndex = 0;
			this.btnSettingSystem.ImageList = this.imageList;
			this.btnSettingSystem.Location = new System.Drawing.Point(489, 1);
			this.btnSettingSystem.Margin = new System.Windows.Forms.Padding(0);
			this.btnSettingSystem.Name = "btnSettingSystem";
			this.btnSettingSystem.Size = new System.Drawing.Size(243, 52);
			this.btnSettingSystem.TabIndex = 53;
			this.btnSettingSystem.Text = " SETTING";
			this.btnSettingSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSettingSystem.UseVisualStyleBackColor = false;
			this.btnSettingSystem.Click += new System.EventHandler(this.btnSettingSystem_Click);
			// 
			// btnDataLog
			// 
			this.btnDataLog.BackColor = System.Drawing.Color.Teal;
			this.btnDataLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnDataLog.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDataLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDataLog.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDataLog.ForeColor = System.Drawing.Color.White;
			this.btnDataLog.ImageIndex = 2;
			this.btnDataLog.ImageList = this.imageList;
			this.btnDataLog.Location = new System.Drawing.Point(245, 1);
			this.btnDataLog.Margin = new System.Windows.Forms.Padding(0);
			this.btnDataLog.Name = "btnDataLog";
			this.btnDataLog.Size = new System.Drawing.Size(243, 52);
			this.btnDataLog.TabIndex = 52;
			this.btnDataLog.Text = " DATA";
			this.btnDataLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDataLog.UseVisualStyleBackColor = false;
			this.btnDataLog.Click += new System.EventHandler(this.btnDataLog_Click);
			// 
			// btnAuto
			// 
			this.btnAuto.BackColor = System.Drawing.Color.Teal;
			this.btnAuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAuto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAuto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAuto.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAuto.ForeColor = System.Drawing.Color.White;
			this.btnAuto.ImageIndex = 3;
			this.btnAuto.ImageList = this.imageList;
			this.btnAuto.Location = new System.Drawing.Point(1, 1);
			this.btnAuto.Margin = new System.Windows.Forms.Padding(0);
			this.btnAuto.Name = "btnAuto";
			this.btnAuto.Size = new System.Drawing.Size(243, 52);
			this.btnAuto.TabIndex = 50;
			this.btnAuto.Text = "MAIN";
			this.btnAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAuto.UseVisualStyleBackColor = false;
			this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
			// 
			// MainPalette
			// 
			this.MainPalette.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
			this.MainPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.Lavender;
			this.MainPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.Lavender;
			this.MainPalette.FormStyles.FormMain.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
			this.MainPalette.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.Lavender;
			this.MainPalette.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.Lavender;
			this.MainPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.MainPalette.FormStyles.FormMain.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.Lavender;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.Lavender;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.Lavender;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.Lavender;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.Rounding = 0;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Black;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color2 = System.Drawing.Color.Black;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, 10, -1, 0);
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Lavender;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
			// 
			// contextMenuStripSetting
			// 
			this.contextMenuStripSetting.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.contextMenuStripSetting.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStripSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printerToolStripMenuItem,
            this.pLCToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.userManagerToolStripMenuItem});
			this.contextMenuStripSetting.Name = "contextMenuStripSetting";
			this.contextMenuStripSetting.Size = new System.Drawing.Size(171, 116);
			// 
			// printerToolStripMenuItem
			// 
			this.printerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.printerToolStripMenuItem.Name = "printerToolStripMenuItem";
			this.printerToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
			this.printerToolStripMenuItem.Text = "Printer";
			// 
			// pLCToolStripMenuItem
			// 
			this.pLCToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.pLCToolStripMenuItem.Name = "pLCToolStripMenuItem";
			this.pLCToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
			this.pLCToolStripMenuItem.Text = "PLC";
			// 
			// systemToolStripMenuItem
			// 
			this.systemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
			this.systemToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
			this.systemToolStripMenuItem.Text = "System";
			// 
			// userManagerToolStripMenuItem
			// 
			this.userManagerToolStripMenuItem.Name = "userManagerToolStripMenuItem";
			this.userManagerToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
			this.userManagerToolStripMenuItem.Text = "User Manager";
			// 
			// contextMenuStripData
			// 
			this.contextMenuStripData.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.contextMenuStripData.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStripData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lotDataToolStripMenuItem,
            this.ringDataToolStripMenuItem});
			this.contextMenuStripData.Name = "contextMenuStrip";
			this.contextMenuStripData.Size = new System.Drawing.Size(155, 60);
			// 
			// lotDataToolStripMenuItem
			// 
			this.lotDataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lotDataToolStripMenuItem.Name = "lotDataToolStripMenuItem";
			this.lotDataToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
			this.lotDataToolStripMenuItem.Text = "Lot Data";
			// 
			// ringDataToolStripMenuItem
			// 
			this.ringDataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.ringDataToolStripMenuItem.Name = "ringDataToolStripMenuItem";
			this.ringDataToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
			this.ringDataToolStripMenuItem.Text = "Ring Data";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1476, 708);
			this.Controls.Add(this.tableLayoutPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Leak Current System";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.tableLayoutPanelFooter.ResumeLayout(false);
			this.tableLayoutPanelFooter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompanyLogo)).EndInit();
			this.tableLayoutPanel.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.panel.ResumeLayout(false);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.panelRight.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanelTabButton.ResumeLayout(false);
			this.contextMenuStripSetting.ResumeLayout(false);
			this.contextMenuStripData.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label labelBuildDate;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFooter;
		private System.Windows.Forms.Label lbCompanyName;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTabButton;
		private System.Windows.Forms.ImageList imageList;
		private ComponentFactory.Krypton.Toolkit.KryptonPalette MainPalette;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripSetting;
		private System.Windows.Forms.ToolStripMenuItem printerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pLCToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userManagerToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripData;
		private System.Windows.Forms.ToolStripMenuItem lotDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ringDataToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBoxCompanyLogo;
		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.Button btnKeyBoardSimu;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button btnSettingSystem;
		private System.Windows.Forms.Button btnDataLog;
		private System.Windows.Forms.Button btnAuto;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Panel panelRight;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private UspcInfor ucPcInfo;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox listBoxLog;
		private System.Windows.Forms.Label lampPlcAlive;
		private System.Windows.Forms.Label label1;
		private UcDateTime ucDateTime;
	}
}

