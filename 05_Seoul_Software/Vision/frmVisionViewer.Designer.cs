namespace Seoul_Software.Vision
{
	partial class frmVisionViewer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisionViewer));
			this.imageBox = new Cutreson_UserControl.MyImageBoxEx();
			this.SuspendLayout();
			// 
			// imageBox
			// 
			this.imageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
			this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imageBox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
			this.imageBox.GridColorAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.imageBox.Location = new System.Drawing.Point(0, 0);
			this.imageBox.Name = "imageBox";
			this.imageBox.Size = new System.Drawing.Size(1182, 853);
			this.imageBox.TabIndex = 0;
			// 
			// frmVisionViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1182, 853);
			this.Controls.Add(this.imageBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmVisionViewer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vision Viewer";
			this.ResumeLayout(false);

		}

		#endregion

		private Cutreson_UserControl.MyImageBoxEx imageBox;
	}
}