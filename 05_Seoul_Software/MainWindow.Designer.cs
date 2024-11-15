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
			this.lampPlcAlive = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOrigin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnReset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnStop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnStart = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.panelVisionMonitor = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listBoxAlarm = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listBoxEventLog = new System.Windows.Forms.ListBox();
			this.tableLayoutMachineMobitor = new System.Windows.Forms.TableLayoutPanel();
			this.panelMain = new System.Windows.Forms.Panel();
			this.lbTitle = new System.Windows.Forms.Label();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.lbCompanyName = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelBuildDate = new System.Windows.Forms.Label();
			this.tableLayoutPanelFooter = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.panelAlarm = new System.Windows.Forms.Panel();
			this.btnPlcSetting = new System.Windows.Forms.Button();
			this.pictureBoxCompanyLogo = new System.Windows.Forms.PictureBox();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.btnKeyboard = new System.Windows.Forms.Button();
			this.btnSetting = new System.Windows.Forms.Button();
			this.btnPrinter = new System.Windows.Forms.Button();
			this.ucDateTime = new Cutreson_UserControl.UcDateTime();
			this.ucPcInfo = new Cutreson_UserControl.UspcInfor();
			this.panel.SuspendLayout();
			this.tableLayoutPanelMain.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelMenu.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutMachineMobitor.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.tableLayoutPanelFooter.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompanyLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
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
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
			this.tableLayoutPanelMain.Controls.Add(this.groupBoxScanner, 1, 1);
			this.tableLayoutPanelMain.Controls.Add(this.panel1, 3, 0);
			this.tableLayoutPanelMain.Controls.Add(this.panelMenu, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutMachineMobitor, 2, 0);
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
			this.groupBoxScanner.Size = new System.Drawing.Size(1225, 114);
			this.groupBoxScanner.TabIndex = 7;
			this.groupBoxScanner.TabStop = false;
			this.groupBoxScanner.Text = "Scanner";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lampPlcAlive);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnOrigin);
			this.panel1.Controls.Add(this.btnReset);
			this.panel1.Controls.Add(this.btnStop);
			this.panel1.Controls.Add(this.btnStart);
			this.panel1.Controls.Add(this.ucPcInfo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(1297, 4);
			this.panel1.Name = "panel1";
			this.tableLayoutPanelMain.SetRowSpan(this.panel1, 2);
			this.panel1.Size = new System.Drawing.Size(275, 724);
			this.panel1.TabIndex = 3;
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
			this.btnOrigin.Location = new System.Drawing.Point(10, 680);
			this.btnOrigin.Name = "btnOrigin";
			this.btnOrigin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
			this.btnOrigin.Size = new System.Drawing.Size(255, 38);
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
			this.btnOrigin.Values.Text = "RETURN";
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.Location = new System.Drawing.Point(10, 636);
			this.btnReset.Name = "btnReset";
			this.btnReset.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
			this.btnReset.Size = new System.Drawing.Size(256, 38);
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
			// 
			// btnStop
			// 
			this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStop.Location = new System.Drawing.Point(10, 592);
			this.btnStop.Name = "btnStop";
			this.btnStop.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
			this.btnStop.Size = new System.Drawing.Size(256, 38);
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
			// 
			// btnStart
			// 
			this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStart.Location = new System.Drawing.Point(10, 548);
			this.btnStart.Name = "btnStart";
			this.btnStart.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
			this.btnStart.Size = new System.Drawing.Size(256, 38);
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
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
			this.panelMenu.Controls.Add(this.btnKeyboard);
			this.panelMenu.Controls.Add(this.btnSetting);
			this.panelMenu.Controls.Add(this.btnPrinter);
			this.panelMenu.Controls.Add(this.btnPlcSetting);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMenu.Location = new System.Drawing.Point(1, 1);
			this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
			this.panelMenu.Name = "panelMenu";
			this.tableLayoutPanelMain.SetRowSpan(this.panelMenu, 2);
			this.panelMenu.Size = new System.Drawing.Size(60, 730);
			this.panelMenu.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.panelVisionMonitor, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(65, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
			this.groupBox2.Controls.Add(this.listBoxAlarm);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 479);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(388, 121);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Alarm";
			// 
			// listBoxAlarm
			// 
			this.listBoxAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.listBoxAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxAlarm.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxAlarm.ForeColor = System.Drawing.SystemColors.Window;
			this.listBoxAlarm.FormattingEnabled = true;
			this.listBoxAlarm.HorizontalScrollbar = true;
			this.listBoxAlarm.ItemHeight = 18;
			this.listBoxAlarm.Location = new System.Drawing.Point(3, 18);
			this.listBoxAlarm.Name = "listBoxAlarm";
			this.listBoxAlarm.Size = new System.Drawing.Size(382, 100);
			this.listBoxAlarm.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listBoxEventLog);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 353);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(388, 120);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Operating & Event Log";
			// 
			// listBoxEventLog
			// 
			this.listBoxEventLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.listBoxEventLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxEventLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxEventLog.ForeColor = System.Drawing.SystemColors.Window;
			this.listBoxEventLog.FormattingEnabled = true;
			this.listBoxEventLog.HorizontalScrollbar = true;
			this.listBoxEventLog.ItemHeight = 18;
			this.listBoxEventLog.Location = new System.Drawing.Point(3, 18);
			this.listBoxEventLog.Name = "listBoxEventLog";
			this.listBoxEventLog.Size = new System.Drawing.Size(382, 99);
			this.listBoxEventLog.TabIndex = 0;
			// 
			// tableLayoutMachineMobitor
			// 
			this.tableLayoutMachineMobitor.ColumnCount = 1;
			this.tableLayoutMachineMobitor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutMachineMobitor.Controls.Add(this.panelMain, 0, 0);
			this.tableLayoutMachineMobitor.Controls.Add(this.panelAlarm, 0, 1);
			this.tableLayoutMachineMobitor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutMachineMobitor.Location = new System.Drawing.Point(463, 1);
			this.tableLayoutMachineMobitor.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutMachineMobitor.Name = "tableLayoutMachineMobitor";
			this.tableLayoutMachineMobitor.RowCount = 2;
			this.tableLayoutMachineMobitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutMachineMobitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutMachineMobitor.Size = new System.Drawing.Size(830, 609);
			this.tableLayoutMachineMobitor.TabIndex = 8;
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 0);
			this.panelMain.Margin = new System.Windows.Forms.Padding(0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(830, 559);
			this.panelMain.TabIndex = 7;
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
			// lbCompanyName
			// 
			this.lbCompanyName.AutoSize = true;
			this.lbCompanyName.BackColor = System.Drawing.SystemColors.Control;
			this.lbCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.lbCompanyName.Location = new System.Drawing.Point(976, 0);
			this.lbCompanyName.Name = "lbCompanyName";
			this.lbCompanyName.Size = new System.Drawing.Size(550, 34);
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
			this.labelVersion.Location = new System.Drawing.Point(559, 0);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(411, 34);
			this.labelVersion.TabIndex = 14;
			this.labelVersion.Text = "Version: V1.0";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.labelBuildDate.Size = new System.Drawing.Size(550, 34);
			this.labelBuildDate.TabIndex = 13;
			this.labelBuildDate.Text = "Built: 2024/10/18";
			this.labelBuildDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanelFooter
			// 
			this.tableLayoutPanelFooter.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanelFooter.ColumnCount = 4;
			this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
			this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
			this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
			this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
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
			// panelAlarm
			// 
			this.panelAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelAlarm.Location = new System.Drawing.Point(3, 562);
			this.panelAlarm.Name = "panelAlarm";
			this.panelAlarm.Size = new System.Drawing.Size(824, 44);
			this.panelAlarm.TabIndex = 8;
			// 
			// btnPlcSetting
			// 
			this.btnPlcSetting.BackColor = System.Drawing.Color.Teal;
			this.btnPlcSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPlcSetting.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPlcSetting.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPlcSetting.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlcSetting.ForeColor = System.Drawing.Color.White;
			this.btnPlcSetting.Location = new System.Drawing.Point(0, 0);
			this.btnPlcSetting.Margin = new System.Windows.Forms.Padding(0);
			this.btnPlcSetting.Name = "btnPlcSetting";
			this.btnPlcSetting.Size = new System.Drawing.Size(60, 55);
			this.btnPlcSetting.TabIndex = 42;
			this.btnPlcSetting.Text = "PLC";
			this.btnPlcSetting.UseVisualStyleBackColor = false;
			this.btnPlcSetting.Click += new System.EventHandler(this.btnPlcSetting_Click);
			// 
			// pictureBoxCompanyLogo
			// 
			this.pictureBoxCompanyLogo.BackgroundImage = global::Seoul_Software.Properties.Resources.IconSora;
			this.pictureBoxCompanyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxCompanyLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxCompanyLogo.Location = new System.Drawing.Point(1532, 3);
			this.pictureBoxCompanyLogo.Name = "pictureBoxCompanyLogo";
			this.pictureBoxCompanyLogo.Size = new System.Drawing.Size(41, 28);
			this.pictureBoxCompanyLogo.TabIndex = 16;
			this.pictureBoxCompanyLogo.TabStop = false;
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
			// btnKeyboard
			// 
			this.btnKeyboard.BackColor = System.Drawing.Color.Teal;
			this.btnKeyboard.BackgroundImage = global::Seoul_Software.Properties.Resources.Keyboard;
			this.btnKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnKeyboard.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKeyboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnKeyboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKeyboard.ForeColor = System.Drawing.Color.White;
			this.btnKeyboard.Location = new System.Drawing.Point(0, 165);
			this.btnKeyboard.Margin = new System.Windows.Forms.Padding(0);
			this.btnKeyboard.Name = "btnKeyboard";
			this.btnKeyboard.Size = new System.Drawing.Size(60, 55);
			this.btnKeyboard.TabIndex = 47;
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
			this.btnSetting.Location = new System.Drawing.Point(0, 110);
			this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(60, 55);
			this.btnSetting.TabIndex = 46;
			this.btnSetting.UseVisualStyleBackColor = false;
			this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
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
			this.btnPrinter.Location = new System.Drawing.Point(0, 55);
			this.btnPrinter.Margin = new System.Windows.Forms.Padding(0);
			this.btnPrinter.Name = "btnPrinter";
			this.btnPrinter.Size = new System.Drawing.Size(60, 55);
			this.btnPrinter.TabIndex = 45;
			this.btnPrinter.UseVisualStyleBackColor = false;
			this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
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
			this.ucPcInfo.Size = new System.Drawing.Size(275, 82);
			this.ucPcInfo.TabIndex = 0;
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
			this.Text = "Software";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel.ResumeLayout(false);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelMenu.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutMachineMobitor.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.tableLayoutPanelFooter.ResumeLayout(false);
			this.tableLayoutPanelFooter.PerformLayout();
			this.tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompanyLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette MainPalette;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelBuildDate;
        private System.Windows.Forms.PictureBox pictureBoxCompanyLogo;
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
		private System.Windows.Forms.ListBox listBoxAlarm;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBoxEventLog;
		private System.Windows.Forms.Panel panelVisionMonitor;
		private System.Windows.Forms.TableLayoutPanel tableLayoutMachineMobitor;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Panel panelAlarm;
		private System.Windows.Forms.Button btnPlcSetting;
		private System.Windows.Forms.Button btnKeyboard;
		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.Button btnPrinter;
	}
}

