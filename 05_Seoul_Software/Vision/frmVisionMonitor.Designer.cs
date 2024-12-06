namespace Seoul_Software
{
    partial class frmVisionMonitor
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lbNG = new System.Windows.Forms.Label();
			this.lbOK = new System.Windows.Forms.Label();
			this.imageBox = new System.Windows.Forms.PictureBox();
			this.lbTotal = new System.Windows.Forms.Label();
			this.btnResult = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(614, 336);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Vision Monitor";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
			this.tableLayoutPanel1.Controls.Add(this.lbNG, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.lbOK, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.imageBox, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbTotal, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnResult, 3, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 315);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// lbNG
			// 
			this.lbNG.AutoSize = true;
			this.lbNG.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNG.ForeColor = System.Drawing.Color.Red;
			this.lbNG.Location = new System.Drawing.Point(376, 264);
			this.lbNG.Name = "lbNG";
			this.lbNG.Size = new System.Drawing.Size(168, 50);
			this.lbNG.TabIndex = 6;
			this.lbNG.Text = "NG: 1000";
			this.lbNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbOK
			// 
			this.lbOK.AutoSize = true;
			this.lbOK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbOK.ForeColor = System.Drawing.Color.Green;
			this.lbOK.Location = new System.Drawing.Point(201, 264);
			this.lbOK.Name = "lbOK";
			this.lbOK.Size = new System.Drawing.Size(168, 50);
			this.lbOK.TabIndex = 5;
			this.lbOK.Text = "OK: 9000";
			this.lbOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// imageBox
			// 
			this.imageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
			this.tableLayoutPanel1.SetColumnSpan(this.imageBox, 4);
			this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imageBox.Location = new System.Drawing.Point(1, 1);
			this.imageBox.Margin = new System.Windows.Forms.Padding(0);
			this.imageBox.Name = "imageBox";
			this.imageBox.Size = new System.Drawing.Size(606, 262);
			this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imageBox.TabIndex = 3;
			this.imageBox.TabStop = false;
			this.imageBox.DoubleClick += new System.EventHandler(this.imageBox_DoubleClick);
			// 
			// lbTotal
			// 
			this.lbTotal.AutoSize = true;
			this.lbTotal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotal.ForeColor = System.Drawing.Color.DarkViolet;
			this.lbTotal.Location = new System.Drawing.Point(4, 264);
			this.lbTotal.Name = "lbTotal";
			this.lbTotal.Size = new System.Drawing.Size(190, 50);
			this.lbTotal.TabIndex = 4;
			this.lbTotal.Text = "Total: 10000";
			this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnResult
			// 
			this.btnResult.BackColor = System.Drawing.Color.Lime;
			this.btnResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResult.Location = new System.Drawing.Point(548, 264);
			this.btnResult.Margin = new System.Windows.Forms.Padding(0);
			this.btnResult.Name = "btnResult";
			this.btnResult.Size = new System.Drawing.Size(59, 50);
			this.btnResult.TabIndex = 7;
			this.btnResult.Text = "OK";
			this.btnResult.UseVisualStyleBackColor = false;
			// 
			// frmVisionMonitor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 336);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmVisionMonitor";
			this.Text = "frmVisionMonitor";
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label lbNG;
        private System.Windows.Forms.Label lbOK;
        private System.Windows.Forms.Label lbTotal;
		private System.Windows.Forms.Button btnResult;
	}
}