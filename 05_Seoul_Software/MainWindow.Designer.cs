namespace Seoul_Software
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
			this.MainPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
			this.panel = new System.Windows.Forms.Panel();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnKeyboard = new System.Windows.Forms.Button();
			this.btnSetting = new System.Windows.Forms.Button();
			this.btnData = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.contextMenuStripSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.printerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStripData = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.lotDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ringDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lbTitle = new System.Windows.Forms.Label();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.tableLayoutPanelTR = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.labelBuildDate = new System.Windows.Forms.Label();
			this.tableLayoutPanelFooter = new System.Windows.Forms.TableLayoutPanel();
			this.lbCompanyName = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.pictureBoxCompanyLogo = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelTabButton = new System.Windows.Forms.TableLayoutPanel();
			this.btnKeyBoardSimu = new System.Windows.Forms.Button();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.btnExit = new System.Windows.Forms.Button();
			this.btnHistory = new System.Windows.Forms.Button();
			this.btnUser = new System.Windows.Forms.Button();
			this.btnSettingSystem = new System.Windows.Forms.Button();
			this.btnDataLog = new System.Windows.Forms.Button();
			this.btnAuto = new System.Windows.Forms.Button();
			this.tableLayoutPanelAlive = new System.Windows.Forms.TableLayoutPanel();
			this.lampPlcAlive = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ucDateTime = new Cutreson_UserControl.UcDateTime();
			this.ucPcInfo = new Cutreson_UserControl.UspcInfor();
			this.panel.SuspendLayout();
			this.tableLayoutPanelMain.SuspendLayout();
			this.panelMenu.SuspendLayout();
			this.contextMenuStripSetting.SuspendLayout();
			this.contextMenuStripData.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.tableLayoutPanelTR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.tableLayoutPanelFooter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompanyLogo)).BeginInit();
			this.tableLayoutPanel.SuspendLayout();
			this.tableLayoutPanelTabButton.SuspendLayout();
			this.tableLayoutPanelAlive.SuspendLayout();
			this.SuspendLayout();
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
			// panel
			// 
			this.panel.Controls.Add(this.tableLayoutPanelMain);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(3, 138);
			this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(1578, 683);
			this.panel.TabIndex = 6;
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanelMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanelMain.ColumnCount = 2;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.Controls.Add(this.panelMenu, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.panelMain, 1, 0);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 1;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(1578, 683);
			this.tableLayoutPanelMain.TabIndex = 1;
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
			this.panelMenu.Controls.Add(this.btnKeyboard);
			this.panelMenu.Controls.Add(this.btnSetting);
			this.panelMenu.Controls.Add(this.btnData);
			this.panelMenu.Controls.Add(this.btnLogin);
			this.panelMenu.Controls.Add(this.btnHome);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMenu.Location = new System.Drawing.Point(1, 1);
			this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(1, 681);
			this.panelMenu.TabIndex = 2;
			// 
			// btnKeyboard
			// 
			this.btnKeyboard.BackColor = System.Drawing.Color.Teal;
			this.btnKeyboard.BackgroundImage = global::Seoul_Software.Properties.Resources.Keyboard;
			this.btnKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnKeyboard.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKeyboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnKeyboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKeyboard.ForeColor = System.Drawing.Color.White;
			this.btnKeyboard.Location = new System.Drawing.Point(0, 220);
			this.btnKeyboard.Margin = new System.Windows.Forms.Padding(0);
			this.btnKeyboard.Name = "btnKeyboard";
			this.btnKeyboard.Size = new System.Drawing.Size(1, 55);
			this.btnKeyboard.TabIndex = 65;
			this.btnKeyboard.UseVisualStyleBackColor = false;
			this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
			// 
			// btnSetting
			// 
			this.btnSetting.BackColor = System.Drawing.Color.Teal;
			this.btnSetting.BackgroundImage = global::Seoul_Software.Properties.Resources.SettingWhite;
			this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSetting.Location = new System.Drawing.Point(0, 165);
			this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(1, 55);
			this.btnSetting.TabIndex = 64;
			this.btnSetting.UseVisualStyleBackColor = false;
			this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
			// 
			// btnData
			// 
			this.btnData.BackColor = System.Drawing.Color.Teal;
			this.btnData.BackgroundImage = global::Seoul_Software.Properties.Resources.DatabaseView;
			this.btnData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnData.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnData.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnData.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnData.ForeColor = System.Drawing.Color.White;
			this.btnData.Location = new System.Drawing.Point(0, 110);
			this.btnData.Margin = new System.Windows.Forms.Padding(0);
			this.btnData.Name = "btnData";
			this.btnData.Size = new System.Drawing.Size(1, 55);
			this.btnData.TabIndex = 63;
			this.btnData.UseVisualStyleBackColor = false;
			this.btnData.Click += new System.EventHandler(this.btnData_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Teal;
			this.btnLogin.BackgroundImage = global::Seoul_Software.Properties.Resources.UserGroup;
			this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(0, 55);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(1, 55);
			this.btnLogin.TabIndex = 62;
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnHome
			// 
			this.btnHome.BackColor = System.Drawing.Color.Teal;
			this.btnHome.BackgroundImage = global::Seoul_Software.Properties.Resources.Home;
			this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnHome.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHome.ForeColor = System.Drawing.Color.White;
			this.btnHome.Location = new System.Drawing.Point(0, 0);
			this.btnHome.Margin = new System.Windows.Forms.Padding(0);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(1, 55);
			this.btnHome.TabIndex = 49;
			this.btnHome.UseVisualStyleBackColor = false;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(2, 1);
			this.panelMain.Margin = new System.Windows.Forms.Padding(0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(1575, 681);
			this.panelMain.TabIndex = 3;
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
			this.contextMenuStripSetting.Size = new System.Drawing.Size(175, 116);
			// 
			// printerToolStripMenuItem
			// 
			this.printerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.printerToolStripMenuItem.Image = global::Seoul_Software.Properties.Resources.Printer;
			this.printerToolStripMenuItem.Name = "printerToolStripMenuItem";
			this.printerToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
			this.printerToolStripMenuItem.Text = "Printer";
			this.printerToolStripMenuItem.Click += new System.EventHandler(this.printerToolStripMenuItem_Click);
			// 
			// pLCToolStripMenuItem
			// 
			this.pLCToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.pLCToolStripMenuItem.Image = global::Seoul_Software.Properties.Resources.UsbConnector;
			this.pLCToolStripMenuItem.Name = "pLCToolStripMenuItem";
			this.pLCToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
			this.pLCToolStripMenuItem.Text = "PLC";
			this.pLCToolStripMenuItem.Click += new System.EventHandler(this.pLCToolStripMenuItem_Click);
			// 
			// systemToolStripMenuItem
			// 
			this.systemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.systemToolStripMenuItem.Image = global::Seoul_Software.Properties.Resources.SystemSetting;
			this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
			this.systemToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
			this.systemToolStripMenuItem.Text = "System";
			this.systemToolStripMenuItem.Click += new System.EventHandler(this.systemToolStripMenuItem_Click);
			// 
			// userManagerToolStripMenuItem
			// 
			this.userManagerToolStripMenuItem.Image = global::Seoul_Software.Properties.Resources.UserGroup;
			this.userManagerToolStripMenuItem.Name = "userManagerToolStripMenuItem";
			this.userManagerToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
			this.userManagerToolStripMenuItem.Text = "User Manager";
			this.userManagerToolStripMenuItem.Click += new System.EventHandler(this.userManagerToolStripMenuItem_Click);
			// 
			// contextMenuStripData
			// 
			this.contextMenuStripData.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.contextMenuStripData.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStripData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lotDataToolStripMenuItem,
            this.ringDataToolStripMenuItem});
			this.contextMenuStripData.Name = "contextMenuStrip";
			this.contextMenuStripData.Size = new System.Drawing.Size(159, 60);
			// 
			// lotDataToolStripMenuItem
			// 
			this.lotDataToolStripMenuItem.BackgroundImage = global::Seoul_Software.Properties.Resources.DatabaseView;
			this.lotDataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lotDataToolStripMenuItem.Image = global::Seoul_Software.Properties.Resources.Chart;
			this.lotDataToolStripMenuItem.Name = "lotDataToolStripMenuItem";
			this.lotDataToolStripMenuItem.Size = new System.Drawing.Size(158, 28);
			this.lotDataToolStripMenuItem.Text = "Lot Data";
			this.lotDataToolStripMenuItem.Click += new System.EventHandler(this.lotDataToolStripMenuItem_Click);
			// 
			// ringDataToolStripMenuItem
			// 
			this.ringDataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.ringDataToolStripMenuItem.Image = global::Seoul_Software.Properties.Resources.Chart;
			this.ringDataToolStripMenuItem.Name = "ringDataToolStripMenuItem";
			this.ringDataToolStripMenuItem.Size = new System.Drawing.Size(158, 28);
			this.ringDataToolStripMenuItem.Text = "Ring Data";
			this.ringDataToolStripMenuItem.Click += new System.EventHandler(this.ringDataToolStripMenuItem_Click);
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(70)))));
			this.lbTitle.Location = new System.Drawing.Point(115, 15);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(498, 39);
			this.lbTitle.TabIndex = 1;
			this.lbTitle.Text = "Auto UV Tape Mount Machine";
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.Color.Lavender;
			this.panelTitle.Controls.Add(this.tableLayoutPanelTR);
			this.panelTitle.Controls.Add(this.lbTitle);
			this.panelTitle.Controls.Add(this.pbLogo);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
			this.panelTitle.Location = new System.Drawing.Point(3, 2);
			this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(1578, 70);
			this.panelTitle.TabIndex = 4;
			// 
			// tableLayoutPanelTR
			// 
			this.tableLayoutPanelTR.ColumnCount = 4;
			this.tableLayoutPanelTR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
			this.tableLayoutPanelTR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanelTR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
			this.tableLayoutPanelTR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440F));
			this.tableLayoutPanelTR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanelTR.Controls.Add(this.label4, 2, 0);
			this.tableLayoutPanelTR.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanelTR.Controls.Add(this.ucDateTime, 3, 0);
			this.tableLayoutPanelTR.Controls.Add(this.ucPcInfo, 1, 0);
			this.tableLayoutPanelTR.Dock = System.Windows.Forms.DockStyle.Right;
			this.tableLayoutPanelTR.Location = new System.Drawing.Point(933, 0);
			this.tableLayoutPanelTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanelTR.Name = "tableLayoutPanelTR";
			this.tableLayoutPanelTR.RowCount = 1;
			this.tableLayoutPanelTR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelTR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanelTR.Size = new System.Drawing.Size(645, 70);
			this.tableLayoutPanelTR.TabIndex = 43;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.MediumVioletRed;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(206, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(1, 70);
			this.label4.TabIndex = 45;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.MediumVioletRed;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(1, 70);
			this.label3.TabIndex = 44;
			// 
			// pbLogo
			// 
			this.pbLogo.Image = global::Seoul_Software.Properties.Resources.Seoul;
			this.pbLogo.Location = new System.Drawing.Point(9, 9);
			this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(100, 50);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbLogo.TabIndex = 0;
			this.pbLogo.TabStop = false;
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
			this.labelBuildDate.Size = new System.Drawing.Size(297, 35);
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
			this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
			this.tableLayoutPanelFooter.Controls.Add(this.lbCompanyName, 2, 0);
			this.tableLayoutPanelFooter.Controls.Add(this.labelVersion, 0, 0);
			this.tableLayoutPanelFooter.Controls.Add(this.labelBuildDate, 0, 0);
			this.tableLayoutPanelFooter.Controls.Add(this.pictureBoxCompanyLogo, 3, 0);
			this.tableLayoutPanelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelFooter.Location = new System.Drawing.Point(3, 825);
			this.tableLayoutPanelFooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
			this.tableLayoutPanelFooter.RowCount = 1;
			this.tableLayoutPanelFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelFooter.Size = new System.Drawing.Size(1578, 35);
			this.tableLayoutPanelFooter.TabIndex = 5;
			// 
			// lbCompanyName
			// 
			this.lbCompanyName.AutoSize = true;
			this.lbCompanyName.BackColor = System.Drawing.SystemColors.Control;
			this.lbCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.lbCompanyName.Location = new System.Drawing.Point(1520, 0);
			this.lbCompanyName.Name = "lbCompanyName";
			this.lbCompanyName.Size = new System.Drawing.Size(297, 35);
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
			this.labelVersion.Location = new System.Drawing.Point(306, 0);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(1130, 44);
			this.labelVersion.TabIndex = 14;
			this.labelVersion.Text = "Version: V1.0";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxCompanyLogo
			// 
			this.pictureBoxCompanyLogo.BackgroundImage = global::Seoul_Software.Properties.Resources.IconSora;
			this.pictureBoxCompanyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxCompanyLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxCompanyLogo.Location = new System.Drawing.Point(1899, 3);
			this.pictureBoxCompanyLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBoxCompanyLogo.Name = "pictureBoxCompanyLogo";
			this.pictureBoxCompanyLogo.Size = new System.Drawing.Size(70, 39);
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
			this.tableLayoutPanel.Size = new System.Drawing.Size(1584, 862);
			this.tableLayoutPanel.TabIndex = 1;
			// 
			// tableLayoutPanelTabButton
			// 
			this.tableLayoutPanelTabButton.BackColor = System.Drawing.Color.Lavender;
			this.tableLayoutPanelTabButton.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanelTabButton.ColumnCount = 8;
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.5F));
			this.tableLayoutPanelTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanelTabButton.Controls.Add(this.btnKeyBoardSimu, 5, 0);
			this.tableLayoutPanelTabButton.Controls.Add(this.btnExit, 6, 0);
			this.tableLayoutPanelTabButton.Controls.Add(this.btnHistory, 2, 0);
			this.tableLayoutPanelTabButton.Controls.Add(this.btnUser, 4, 0);
			this.tableLayoutPanelTabButton.Controls.Add(this.btnSettingSystem, 3, 0);
			this.tableLayoutPanelTabButton.Controls.Add(this.btnDataLog, 1, 0);
			this.tableLayoutPanelTabButton.Controls.Add(this.btnAuto, 0, 0);
			this.tableLayoutPanelTabButton.Controls.Add(this.tableLayoutPanelAlive, 7, 0);
			this.tableLayoutPanelTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelTabButton.Location = new System.Drawing.Point(4, 78);
			this.tableLayoutPanelTabButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanelTabButton.Name = "tableLayoutPanelTabButton";
			this.tableLayoutPanelTabButton.RowCount = 1;
			this.tableLayoutPanelTabButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelTabButton.Size = new System.Drawing.Size(1576, 54);
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
			this.btnKeyBoardSimu.Location = new System.Drawing.Point(1061, 1);
			this.btnKeyBoardSimu.Margin = new System.Windows.Forms.Padding(0);
			this.btnKeyBoardSimu.Name = "btnKeyBoardSimu";
			this.btnKeyBoardSimu.Size = new System.Drawing.Size(211, 52);
			this.btnKeyBoardSimu.TabIndex = 57;
			this.btnKeyBoardSimu.Text = "KEYBOARD";
			this.btnKeyBoardSimu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnKeyBoardSimu.UseVisualStyleBackColor = false;
			this.btnKeyBoardSimu.Click += new System.EventHandler(this.btnKeyboard_Click);
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
			this.btnExit.Location = new System.Drawing.Point(1273, 1);
			this.btnExit.Margin = new System.Windows.Forms.Padding(0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(211, 52);
			this.btnExit.TabIndex = 56;
			this.btnExit.Text = " EXIT";
			this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnHistory
			// 
			this.btnHistory.BackColor = System.Drawing.Color.Teal;
			this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnHistory.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHistory.ForeColor = System.Drawing.Color.White;
			this.btnHistory.ImageIndex = 5;
			this.btnHistory.ImageList = this.imageList;
			this.btnHistory.Location = new System.Drawing.Point(425, 1);
			this.btnHistory.Margin = new System.Windows.Forms.Padding(0);
			this.btnHistory.Name = "btnHistory";
			this.btnHistory.Size = new System.Drawing.Size(211, 52);
			this.btnHistory.TabIndex = 55;
			this.btnHistory.Text = " HISTORY";
			this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHistory.UseVisualStyleBackColor = false;
			this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
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
			this.btnUser.Location = new System.Drawing.Point(849, 1);
			this.btnUser.Margin = new System.Windows.Forms.Padding(0);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(211, 52);
			this.btnUser.TabIndex = 54;
			this.btnUser.Text = " USER";
			this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUser.UseVisualStyleBackColor = false;
			this.btnUser.Click += new System.EventHandler(this.btnLogin_Click);
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
			this.btnSettingSystem.Location = new System.Drawing.Point(637, 1);
			this.btnSettingSystem.Margin = new System.Windows.Forms.Padding(0);
			this.btnSettingSystem.Name = "btnSettingSystem";
			this.btnSettingSystem.Size = new System.Drawing.Size(211, 52);
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
			this.btnDataLog.Location = new System.Drawing.Point(213, 1);
			this.btnDataLog.Margin = new System.Windows.Forms.Padding(0);
			this.btnDataLog.Name = "btnDataLog";
			this.btnDataLog.Size = new System.Drawing.Size(211, 52);
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
			this.btnAuto.Size = new System.Drawing.Size(211, 52);
			this.btnAuto.TabIndex = 50;
			this.btnAuto.Text = "AUTO";
			this.btnAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAuto.UseVisualStyleBackColor = false;
			this.btnAuto.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// tableLayoutPanelAlive
			// 
			this.tableLayoutPanelAlive.BackColor = System.Drawing.Color.LightGreen;
			this.tableLayoutPanelAlive.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanelAlive.ColumnCount = 1;
			this.tableLayoutPanelAlive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelAlive.Controls.Add(this.lampPlcAlive, 0, 1);
			this.tableLayoutPanelAlive.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanelAlive.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelAlive.Location = new System.Drawing.Point(1489, 5);
			this.tableLayoutPanelAlive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanelAlive.Name = "tableLayoutPanelAlive";
			this.tableLayoutPanelAlive.RowCount = 2;
			this.tableLayoutPanelAlive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelAlive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelAlive.Size = new System.Drawing.Size(82, 44);
			this.tableLayoutPanelAlive.TabIndex = 58;
			// 
			// lampPlcAlive
			// 
			this.lampPlcAlive.AutoSize = true;
			this.lampPlcAlive.BackColor = System.Drawing.Color.Red;
			this.lampPlcAlive.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lampPlcAlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lampPlcAlive.Location = new System.Drawing.Point(4, 22);
			this.lampPlcAlive.Name = "lampPlcAlive";
			this.lampPlcAlive.Size = new System.Drawing.Size(74, 21);
			this.lampPlcAlive.TabIndex = 43;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Teal;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 20);
			this.label1.TabIndex = 42;
			this.label1.Text = "Alive";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ucDateTime
			// 
			this.ucDateTime.BackColor = System.Drawing.Color.Transparent;
			this.ucDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucDateTime.IsRun = false;
			this.ucDateTime.Location = new System.Drawing.Point(211, 5);
			this.ucDateTime.Margin = new System.Windows.Forms.Padding(5);
			this.ucDateTime.Name = "ucDateTime";
			this.ucDateTime.Size = new System.Drawing.Size(430, 60);
			this.ucDateTime.TabIndex = 2;
			// 
			// ucPcInfo
			// 
			this.ucPcInfo.BackColor = System.Drawing.Color.Transparent;
			this.ucPcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPcInfo.IsRun = false;
			this.ucPcInfo.Location = new System.Drawing.Point(6, 2);
			this.ucPcInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ucPcInfo.Name = "ucPcInfo";
			this.ucPcInfo.Size = new System.Drawing.Size(194, 66);
			this.ucPcInfo.TabIndex = 0;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1584, 862);
			this.Controls.Add(this.tableLayoutPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainWindow";
			this.Palette = this.MainPalette;
			this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel.ResumeLayout(false);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.panelMenu.ResumeLayout(false);
			this.contextMenuStripSetting.ResumeLayout(false);
			this.contextMenuStripData.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.tableLayoutPanelTR.ResumeLayout(false);
			this.tableLayoutPanelTR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.tableLayoutPanelFooter.ResumeLayout(false);
			this.tableLayoutPanelFooter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompanyLogo)).EndInit();
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanelTabButton.ResumeLayout(false);
			this.tableLayoutPanelAlive.ResumeLayout(false);
			this.tableLayoutPanelAlive.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette MainPalette;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelBuildDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFooter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Cutreson_UserControl.UcDateTime ucDateTime;
        private Cutreson_UserControl.UspcInfor ucPcInfo;
		private System.Windows.Forms.Label lbCompanyName;
		private System.Windows.Forms.PictureBox pictureBoxCompanyLogo;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripData;
		private System.Windows.Forms.ToolStripMenuItem lotDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ringDataToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripSetting;
		private System.Windows.Forms.ToolStripMenuItem printerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pLCToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userManagerToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTR;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Button btnKeyboard;
		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.Button btnData;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTabButton;
		private System.Windows.Forms.Button btnAuto;
		private System.Windows.Forms.Button btnDataLog;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button btnSettingSystem;
		private System.Windows.Forms.Button btnHistory;
		private System.Windows.Forms.Button btnKeyBoardSimu;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAlive;
		private System.Windows.Forms.Label lampPlcAlive;
		private System.Windows.Forms.Label label1;
	}
}

