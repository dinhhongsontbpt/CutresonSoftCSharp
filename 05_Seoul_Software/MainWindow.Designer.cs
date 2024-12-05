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
			this.groupBoxScanner = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelInfo = new System.Windows.Forms.Panel();
			this.btnInitial = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.lampPlcAlive = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOrigin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnReset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnStop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnStart = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnKeyboard = new System.Windows.Forms.Button();
			this.btnPrinter = new System.Windows.Forms.Button();
			this.btnPlcSetting = new System.Windows.Forms.Button();
			this.btnSetting = new System.Windows.Forms.Button();
			this.btnData = new System.Windows.Forms.Button();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.lotDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ringDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnHome = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.panelVisionMonitor = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listBoxError = new System.Windows.Forms.ListBox();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panelMain = new System.Windows.Forms.Panel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panelAlarm = new System.Windows.Forms.Panel();
			this.lbTitle = new System.Windows.Forms.Label();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.labelBuildDate = new System.Windows.Forms.Label();
			this.tableLayoutPanelFooter = new System.Windows.Forms.TableLayoutPanel();
			this.lbCompanyName = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.pictureBoxCompanyLogo = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ucDateTime = new Cutreson_UserControl.UcDateTime();
			this.ucPcInfo = new Cutreson_UserControl.UspcInfor();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listBoxEventLog = new System.Windows.Forms.ListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.listBoxAlarm = new System.Windows.Forms.ListBox();
			this.panel.SuspendLayout();
			this.tableLayoutPanelMain.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelMenu.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panelTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.tableLayoutPanelFooter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompanyLogo)).BeginInit();
			this.tableLayoutPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainPalette
			// 
			this.MainPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.Lavender;
			this.MainPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.Lavender;
			this.MainPalette.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.Lavender;
			this.MainPalette.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.Lavender;
			this.MainPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.Lavender;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.Lavender;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.Lavender;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.Lavender;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.Rounding = 0;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Black;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color2 = System.Drawing.Color.Black;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, 10, -1, 0);
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Lavender;
			this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// panel
			// 
			this.panel.Controls.Add(this.tableLayoutPanelMain);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(3, 78);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(1576, 732);
			this.panel.TabIndex = 6;
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanelMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanelMain.ColumnCount = 4;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299F));
			this.tableLayoutPanelMain.Controls.Add(this.groupBoxScanner, 1, 1);
			this.tableLayoutPanelMain.Controls.Add(this.panel1, 3, 0);
			this.tableLayoutPanelMain.Controls.Add(this.panelMenu, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanelMain.Controls.Add(this.tabControl, 2, 0);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 1;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(1576, 732);
			this.tableLayoutPanelMain.TabIndex = 1;
			// 
			// groupBoxScanner
			// 
			this.tableLayoutPanelMain.SetColumnSpan(this.groupBoxScanner, 2);
			this.groupBoxScanner.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxScanner.Location = new System.Drawing.Point(65, 614);
			this.groupBoxScanner.Name = "groupBoxScanner";
			this.groupBoxScanner.Size = new System.Drawing.Size(1207, 114);
			this.groupBoxScanner.TabIndex = 7;
			this.groupBoxScanner.TabStop = false;
			this.groupBoxScanner.Text = "Scanner";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panelInfo);
			this.panel1.Controls.Add(this.btnInitial);
			this.panel1.Controls.Add(this.lampPlcAlive);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnOrigin);
			this.panel1.Controls.Add(this.btnReset);
			this.panel1.Controls.Add(this.btnStop);
			this.panel1.Controls.Add(this.btnStart);
			this.panel1.Controls.Add(this.ucPcInfo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(1279, 4);
			this.panel1.Name = "panel1";
			this.tableLayoutPanelMain.SetRowSpan(this.panel1, 2);
			this.panel1.Size = new System.Drawing.Size(293, 724);
			this.panel1.TabIndex = 3;
			// 
			// panelInfo
			// 
			this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelInfo.Location = new System.Drawing.Point(10, 127);
			this.panelInfo.Name = "panelInfo";
			this.panelInfo.Size = new System.Drawing.Size(273, 338);
			this.panelInfo.TabIndex = 44;
			// 
			// btnInitial
			// 
			this.btnInitial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInitial.Location = new System.Drawing.Point(10, 667);
			this.btnInitial.Name = "btnInitial";
			this.btnInitial.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
			this.btnInitial.Size = new System.Drawing.Size(274, 44);
			this.btnInitial.StateNormal.Back.Color1 = System.Drawing.Color.Teal;
			this.btnInitial.StateNormal.Back.Color2 = System.Drawing.Color.Violet;
			this.btnInitial.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInitial.StatePressed.Back.Color1 = System.Drawing.Color.Teal;
			this.btnInitial.StatePressed.Back.Color2 = System.Drawing.Color.Yellow;
			this.btnInitial.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
			this.btnInitial.StateTracking.Back.Color1 = System.Drawing.Color.Yellow;
			this.btnInitial.StateTracking.Back.Color2 = System.Drawing.Color.Teal;
			this.btnInitial.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInitial.TabIndex = 43;
			this.btnInitial.Values.Text = "INITIAL";
			this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
			// 
			// lampPlcAlive
			// 
			this.lampPlcAlive.AutoSize = true;
			this.lampPlcAlive.BackColor = System.Drawing.Color.Red;
			this.lampPlcAlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lampPlcAlive.Location = new System.Drawing.Point(54, 87);
			this.lampPlcAlive.Name = "lampPlcAlive";
			this.lampPlcAlive.Size = new System.Drawing.Size(159, 20);
			this.lampPlcAlive.TabIndex = 42;
			this.lampPlcAlive.Text = "                              ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 16);
			this.label1.TabIndex = 41;
			this.label1.Text = "Alive";
			// 
			// btnOrigin
			// 
			this.btnOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOrigin.Location = new System.Drawing.Point(10, 618);
			this.btnOrigin.Name = "btnOrigin";
			this.btnOrigin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
			this.btnOrigin.Size = new System.Drawing.Size(274, 44);
			this.btnOrigin.StateNormal.Back.Color1 = System.Drawing.Color.Blue;
			this.btnOrigin.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnOrigin.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrigin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnOrigin.StatePressed.Back.Color2 = System.Drawing.Color.Navy;
			this.btnOrigin.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
			this.btnOrigin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnOrigin.StateTracking.Back.Color2 = System.Drawing.Color.Blue;
			this.btnOrigin.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrigin.TabIndex = 40;
			this.btnOrigin.Values.Text = "HOME";
			this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.Location = new System.Drawing.Point(10, 569);
			this.btnReset.Name = "btnReset";
			this.btnReset.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
			this.btnReset.Size = new System.Drawing.Size(274, 44);
			this.btnReset.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnReset.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnReset.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnReset.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnReset.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
			this.btnReset.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnReset.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnReset.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.TabIndex = 39;
			this.btnReset.Values.Text = "RESET";
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnStop
			// 
			this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStop.Location = new System.Drawing.Point(10, 520);
			this.btnStop.Name = "btnStop";
			this.btnStop.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
			this.btnStop.Size = new System.Drawing.Size(274, 44);
			this.btnStop.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnStop.StateNormal.Back.Color2 = System.Drawing.Color.Maroon;
			this.btnStop.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStop.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnStop.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnStop.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
			this.btnStop.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnStop.StateTracking.Back.Color2 = System.Drawing.Color.Red;
			this.btnStop.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStop.TabIndex = 38;
			this.btnStop.Values.Text = "STOP";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStart.Location = new System.Drawing.Point(10, 471);
			this.btnStart.Name = "btnStart";
			this.btnStart.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
			this.btnStart.Size = new System.Drawing.Size(274, 44);
			this.btnStart.StateNormal.Back.Color1 = System.Drawing.Color.SeaGreen;
			this.btnStart.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnStart.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.StatePressed.Back.Color1 = System.Drawing.Color.SeaGreen;
			this.btnStart.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnStart.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
			this.btnStart.StateTracking.Back.Color1 = System.Drawing.Color.LightSeaGreen;
			this.btnStart.StateTracking.Back.Color2 = System.Drawing.Color.Turquoise;
			this.btnStart.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.TabIndex = 37;
			this.btnStart.Values.Text = "START";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
			this.panelMenu.Controls.Add(this.btnKeyboard);
			this.panelMenu.Controls.Add(this.btnPrinter);
			this.panelMenu.Controls.Add(this.btnPlcSetting);
			this.panelMenu.Controls.Add(this.btnSetting);
			this.panelMenu.Controls.Add(this.btnData);
			this.panelMenu.Controls.Add(this.btnHome);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMenu.Location = new System.Drawing.Point(1, 1);
			this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
			this.panelMenu.Name = "panelMenu";
			this.tableLayoutPanelMain.SetRowSpan(this.panelMenu, 2);
			this.panelMenu.Size = new System.Drawing.Size(60, 730);
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
			this.btnKeyboard.Location = new System.Drawing.Point(0, 275);
			this.btnKeyboard.Margin = new System.Windows.Forms.Padding(0);
			this.btnKeyboard.Name = "btnKeyboard";
			this.btnKeyboard.Size = new System.Drawing.Size(60, 55);
			this.btnKeyboard.TabIndex = 61;
			this.btnKeyboard.UseVisualStyleBackColor = false;
			this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
			// 
			// btnPrinter
			// 
			this.btnPrinter.BackColor = System.Drawing.Color.Teal;
			this.btnPrinter.BackgroundImage = global::Seoul_Software.Properties.Resources.Printer1;
			this.btnPrinter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPrinter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrinter.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPrinter.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrinter.ForeColor = System.Drawing.Color.White;
			this.btnPrinter.Location = new System.Drawing.Point(0, 220);
			this.btnPrinter.Margin = new System.Windows.Forms.Padding(0);
			this.btnPrinter.Name = "btnPrinter";
			this.btnPrinter.Size = new System.Drawing.Size(60, 55);
			this.btnPrinter.TabIndex = 60;
			this.btnPrinter.UseVisualStyleBackColor = false;
			this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
			// 
			// btnPlcSetting
			// 
			this.btnPlcSetting.BackColor = System.Drawing.Color.Teal;
			this.btnPlcSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPlcSetting.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPlcSetting.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPlcSetting.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlcSetting.ForeColor = System.Drawing.Color.White;
			this.btnPlcSetting.Location = new System.Drawing.Point(0, 165);
			this.btnPlcSetting.Margin = new System.Windows.Forms.Padding(0);
			this.btnPlcSetting.Name = "btnPlcSetting";
			this.btnPlcSetting.Size = new System.Drawing.Size(60, 55);
			this.btnPlcSetting.TabIndex = 59;
			this.btnPlcSetting.Text = "PLC";
			this.btnPlcSetting.UseVisualStyleBackColor = false;
			this.btnPlcSetting.Click += new System.EventHandler(this.btnPlcSetting_Click);
			// 
			// btnSetting
			// 
			this.btnSetting.BackColor = System.Drawing.Color.Teal;
			this.btnSetting.BackgroundImage = global::Seoul_Software.Properties.Resources.SettingWhite;
			this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSetting.Location = new System.Drawing.Point(0, 110);
			this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(60, 55);
			this.btnSetting.TabIndex = 57;
			this.btnSetting.UseVisualStyleBackColor = false;
			this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
			// 
			// btnData
			// 
			this.btnData.BackColor = System.Drawing.Color.Teal;
			this.btnData.BackgroundImage = global::Seoul_Software.Properties.Resources.DatabaseView;
			this.btnData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnData.ContextMenuStrip = this.contextMenuStrip;
			this.btnData.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnData.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnData.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnData.ForeColor = System.Drawing.Color.White;
			this.btnData.Location = new System.Drawing.Point(0, 55);
			this.btnData.Margin = new System.Windows.Forms.Padding(0);
			this.btnData.Name = "btnData";
			this.btnData.Size = new System.Drawing.Size(60, 55);
			this.btnData.TabIndex = 54;
			this.btnData.UseVisualStyleBackColor = false;
			this.btnData.Click += new System.EventHandler(this.btnData_Click);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lotDataToolStripMenuItem,
            this.ringDataToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(149, 56);
			// 
			// lotDataToolStripMenuItem
			// 
			this.lotDataToolStripMenuItem.BackgroundImage = global::Seoul_Software.Properties.Resources.DatabaseView;
			this.lotDataToolStripMenuItem.Image = global::Seoul_Software.Properties.Resources.Chart;
			this.lotDataToolStripMenuItem.Name = "lotDataToolStripMenuItem";
			this.lotDataToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
			this.lotDataToolStripMenuItem.Text = "Lot Data";
			this.lotDataToolStripMenuItem.Click += new System.EventHandler(this.lotDataToolStripMenuItem_Click);
			// 
			// ringDataToolStripMenuItem
			// 
			this.ringDataToolStripMenuItem.Image = global::Seoul_Software.Properties.Resources.Chart;
			this.ringDataToolStripMenuItem.Name = "ringDataToolStripMenuItem";
			this.ringDataToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
			this.ringDataToolStripMenuItem.Text = "Ring Data";
			this.ringDataToolStripMenuItem.Click += new System.EventHandler(this.ringDataToolStripMenuItem_Click);
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
			this.btnHome.Size = new System.Drawing.Size(60, 55);
			this.btnHome.TabIndex = 49;
			this.btnHome.UseVisualStyleBackColor = false;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.panelVisionMonitor, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 3);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(65, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 603);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// panelVisionMonitor
			// 
			this.panelVisionMonitor.Location = new System.Drawing.Point(3, 3);
			this.panelVisionMonitor.Name = "panelVisionMonitor";
			this.panelVisionMonitor.Size = new System.Drawing.Size(388, 344);
			this.panelVisionMonitor.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listBoxError);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 529);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(388, 71);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Error";
			// 
			// listBoxError
			// 
			this.listBoxError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.listBoxError.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxError.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
			this.listBoxError.FormattingEnabled = true;
			this.listBoxError.HorizontalScrollbar = true;
			this.listBoxError.ItemHeight = 18;
			this.listBoxError.Location = new System.Drawing.Point(3, 18);
			this.listBoxError.Name = "listBoxError";
			this.listBoxError.Size = new System.Drawing.Size(382, 50);
			this.listBoxError.TabIndex = 0;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(466, 4);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(806, 603);
			this.tabControl.TabIndex = 8;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panelMain);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(798, 574);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Operation";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(3, 3);
			this.panelMain.Margin = new System.Windows.Forms.Padding(0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(792, 568);
			this.panelMain.TabIndex = 8;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.panelAlarm);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(798, 574);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Error & Alarm";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// panelAlarm
			// 
			this.panelAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelAlarm.Location = new System.Drawing.Point(3, 3);
			this.panelAlarm.Margin = new System.Windows.Forms.Padding(0);
			this.panelAlarm.Name = "panelAlarm";
			this.panelAlarm.Size = new System.Drawing.Size(792, 568);
			this.panelAlarm.TabIndex = 9;
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(70)))));
			this.lbTitle.Location = new System.Drawing.Point(114, 15);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(826, 39);
			this.lbTitle.TabIndex = 1;
			this.lbTitle.Text = "Tape tensioning and pressing machine for led chip";
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.Color.Lavender;
			this.panelTitle.Controls.Add(this.ucDateTime);
			this.panelTitle.Controls.Add(this.lbTitle);
			this.panelTitle.Controls.Add(this.pbLogo);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
			this.panelTitle.Location = new System.Drawing.Point(3, 3);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(1576, 69);
			this.panelTitle.TabIndex = 4;
			// 
			// pbLogo
			// 
			this.pbLogo.Image = global::Seoul_Software.Properties.Resources.Seoul;
			this.pbLogo.Location = new System.Drawing.Point(9, 9);
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
			this.labelBuildDate.Size = new System.Drawing.Size(299, 34);
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
			this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
			this.tableLayoutPanelFooter.Controls.Add(this.lbCompanyName, 2, 0);
			this.tableLayoutPanelFooter.Controls.Add(this.labelVersion, 0, 0);
			this.tableLayoutPanelFooter.Controls.Add(this.labelBuildDate, 0, 0);
			this.tableLayoutPanelFooter.Controls.Add(this.pictureBoxCompanyLogo, 3, 0);
			this.tableLayoutPanelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelFooter.Location = new System.Drawing.Point(3, 816);
			this.tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
			this.tableLayoutPanelFooter.RowCount = 1;
			this.tableLayoutPanelFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelFooter.Size = new System.Drawing.Size(1576, 34);
			this.tableLayoutPanelFooter.TabIndex = 5;
			// 
			// lbCompanyName
			// 
			this.lbCompanyName.AutoSize = true;
			this.lbCompanyName.BackColor = System.Drawing.SystemColors.Control;
			this.lbCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.lbCompanyName.Location = new System.Drawing.Point(1223, 0);
			this.lbCompanyName.Name = "lbCompanyName";
			this.lbCompanyName.Size = new System.Drawing.Size(299, 34);
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
			this.labelVersion.Location = new System.Drawing.Point(308, 0);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(909, 34);
			this.labelVersion.TabIndex = 14;
			this.labelVersion.Text = "Version: V1.0";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxCompanyLogo
			// 
			this.pictureBoxCompanyLogo.BackgroundImage = global::Seoul_Software.Properties.Resources.IconSora;
			this.pictureBoxCompanyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxCompanyLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxCompanyLogo.Location = new System.Drawing.Point(1528, 3);
			this.pictureBoxCompanyLogo.Name = "pictureBoxCompanyLogo";
			this.pictureBoxCompanyLogo.Size = new System.Drawing.Size(45, 28);
			this.pictureBoxCompanyLogo.TabIndex = 16;
			this.pictureBoxCompanyLogo.TabStop = false;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.BackColor = System.Drawing.Color.Lavender;
			this.tableLayoutPanel.ColumnCount = 1;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelFooter, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.panelTitle, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.panel, 0, 1);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 3;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(1582, 853);
			this.tableLayoutPanel.TabIndex = 1;
			// 
			// ucDateTime
			// 
			this.ucDateTime.BackColor = System.Drawing.Color.Transparent;
			this.ucDateTime.Dock = System.Windows.Forms.DockStyle.Right;
			this.ucDateTime.IsRun = false;
			this.ucDateTime.Location = new System.Drawing.Point(1139, 0);
			this.ucDateTime.Margin = new System.Windows.Forms.Padding(4);
			this.ucDateTime.Name = "ucDateTime";
			this.ucDateTime.Size = new System.Drawing.Size(437, 69);
			this.ucDateTime.TabIndex = 2;
			// 
			// ucPcInfo
			// 
			this.ucPcInfo.BackColor = System.Drawing.Color.Transparent;
			this.ucPcInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.ucPcInfo.IsRun = false;
			this.ucPcInfo.Location = new System.Drawing.Point(0, 0);
			this.ucPcInfo.Name = "ucPcInfo";
			this.ucPcInfo.Size = new System.Drawing.Size(293, 82);
			this.ucPcInfo.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listBoxEventLog);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 353);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(388, 95);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Operating & Event Log";
			// 
			// listBoxEventLog
			// 
			this.listBoxEventLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.listBoxEventLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxEventLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxEventLog.ForeColor = System.Drawing.SystemColors.Window;
			this.listBoxEventLog.FormattingEnabled = true;
			this.listBoxEventLog.HorizontalScrollbar = true;
			this.listBoxEventLog.ItemHeight = 18;
			this.listBoxEventLog.Location = new System.Drawing.Point(3, 18);
			this.listBoxEventLog.Name = "listBoxEventLog";
			this.listBoxEventLog.Size = new System.Drawing.Size(382, 74);
			this.listBoxEventLog.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.listBoxAlarm);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(3, 454);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(388, 69);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Alarm";
			// 
			// listBoxAlarm
			// 
			this.listBoxAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.listBoxAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxAlarm.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxAlarm.ForeColor = System.Drawing.Color.Yellow;
			this.listBoxAlarm.FormattingEnabled = true;
			this.listBoxAlarm.HorizontalScrollbar = true;
			this.listBoxAlarm.ItemHeight = 18;
			this.listBoxAlarm.Location = new System.Drawing.Point(3, 18);
			this.listBoxAlarm.Name = "listBoxAlarm";
			this.listBoxAlarm.Size = new System.Drawing.Size(382, 48);
			this.listBoxAlarm.TabIndex = 0;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1582, 853);
			this.Controls.Add(this.tableLayoutPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.Palette = this.MainPalette;
			this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel.ResumeLayout(false);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelMenu.ResumeLayout(false);
			this.contextMenuStrip.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.tableLayoutPanelFooter.ResumeLayout(false);
			this.tableLayoutPanelFooter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompanyLogo)).EndInit();
			this.tableLayoutPanel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette MainPalette;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelBuildDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFooter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private Cutreson_UserControl.UcDateTime ucDateTime;
        private Cutreson_UserControl.UspcInfor ucPcInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOrigin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReset;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStop;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStart;
        private System.Windows.Forms.Label lampPlcAlive;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBoxScanner;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox listBoxError;
		private System.Windows.Forms.Panel panelVisionMonitor;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnInitial;
		private System.Windows.Forms.Panel panelInfo;
		private System.Windows.Forms.Label lbCompanyName;
		private System.Windows.Forms.PictureBox pictureBoxCompanyLogo;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panelAlarm;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Button btnKeyboard;
		private System.Windows.Forms.Button btnPrinter;
		private System.Windows.Forms.Button btnPlcSetting;
		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.Button btnData;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem lotDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ringDataToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBoxEventLog;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox listBoxAlarm;
	}
}

