namespace Seoul_Software.Data
{
	partial class frmData
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmData));
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.panelLeft = new System.Windows.Forms.Panel();
			this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
			this.btnRingData = new System.Windows.Forms.Button();
			this.btnLotData = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.button3 = new System.Windows.Forms.Button();
			this.btnTitle = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			this.panelLeft.SuspendLayout();
			this.tableLayoutPanelLeft.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.button3, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.btnTitle, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.panelLeft, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.panelMain, 1, 1);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 2;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(1020, 539);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// panelLeft
			// 
			this.panelLeft.Controls.Add(this.tableLayoutPanelLeft);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLeft.Location = new System.Drawing.Point(4, 55);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(194, 480);
			this.panelLeft.TabIndex = 0;
			// 
			// tableLayoutPanelLeft
			// 
			this.tableLayoutPanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tableLayoutPanelLeft.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
			this.tableLayoutPanelLeft.ColumnCount = 1;
			this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLeft.Controls.Add(this.btnRingData, 0, 1);
			this.tableLayoutPanelLeft.Controls.Add(this.btnLotData, 0, 0);
			this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
			this.tableLayoutPanelLeft.RowCount = 3;
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLeft.Size = new System.Drawing.Size(194, 480);
			this.tableLayoutPanelLeft.TabIndex = 0;
			// 
			// btnRingData
			// 
			this.btnRingData.BackColor = System.Drawing.Color.DarkMagenta;
			this.btnRingData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRingData.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRingData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRingData.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRingData.ForeColor = System.Drawing.Color.White;
			this.btnRingData.ImageIndex = 3;
			this.btnRingData.Location = new System.Drawing.Point(3, 56);
			this.btnRingData.Margin = new System.Windows.Forms.Padding(0);
			this.btnRingData.Name = "btnRingData";
			this.btnRingData.Size = new System.Drawing.Size(188, 50);
			this.btnRingData.TabIndex = 52;
			this.btnRingData.Text = "RING DATA";
			this.btnRingData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRingData.UseVisualStyleBackColor = false;
			this.btnRingData.Click += new System.EventHandler(this.btnRingData_Click);
			// 
			// btnLotData
			// 
			this.btnLotData.BackColor = System.Drawing.Color.DarkMagenta;
			this.btnLotData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLotData.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLotData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLotData.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLotData.ForeColor = System.Drawing.Color.White;
			this.btnLotData.ImageIndex = 3;
			this.btnLotData.Location = new System.Drawing.Point(3, 3);
			this.btnLotData.Margin = new System.Windows.Forms.Padding(0);
			this.btnLotData.Name = "btnLotData";
			this.btnLotData.Size = new System.Drawing.Size(188, 50);
			this.btnLotData.TabIndex = 51;
			this.btnLotData.Text = "LOT DATA";
			this.btnLotData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLotData.UseVisualStyleBackColor = false;
			this.btnLotData.Click += new System.EventHandler(this.btnLotData_Click);
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(205, 55);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(811, 480);
			this.panelMain.TabIndex = 3;
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
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Yellow;
			this.button3.ImageIndex = 2;
			this.button3.ImageList = this.imageList;
			this.button3.Location = new System.Drawing.Point(1, 1);
			this.button3.Margin = new System.Windows.Forms.Padding(0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(200, 50);
			this.button3.TabIndex = 7;
			this.button3.Text = " DATA";
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = false;
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
			this.btnTitle.Size = new System.Drawing.Size(817, 50);
			this.btnTitle.TabIndex = 6;
			this.btnTitle.Text = "TITLE";
			this.btnTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTitle.UseVisualStyleBackColor = false;
			// 
			// frmData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1020, 539);
			this.Controls.Add(this.tableLayoutPanel);
			this.Name = "frmData";
			this.Text = "frmData";
			this.tableLayoutPanel.ResumeLayout(false);
			this.panelLeft.ResumeLayout(false);
			this.tableLayoutPanelLeft.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button btnRingData;
		private System.Windows.Forms.Button btnLotData;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnTitle;
	}
}