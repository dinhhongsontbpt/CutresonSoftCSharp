namespace Seoul_Software
{
    partial class frmMachineMonitor
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
			this.panelMachine = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panelMachine
			// 
			this.panelMachine.BackgroundImage = global::Seoul_Software.Properties.Resources.Layout;
			this.panelMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelMachine.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMachine.Location = new System.Drawing.Point(0, 0);
			this.panelMachine.Name = "panelMachine";
			this.panelMachine.Size = new System.Drawing.Size(1668, 831);
			this.panelMachine.TabIndex = 2;
			// 
			// frmMachineMonitor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1334, 665);
			this.Controls.Add(this.panelMachine);
			this.Name = "frmMachineMonitor";
			this.Text = "frmMachineMonitor";
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMachine;
    }
}