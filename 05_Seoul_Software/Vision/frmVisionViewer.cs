using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seoul_Software.Vision
{
	public partial class frmVisionViewer : Form
	{
		public frmVisionViewer(Image image)
		{
			InitializeComponent();
			this.imageBox.Image = image;
			this.imageBox.SizeMode = Cutreson_UserControl.ImageBox.ImageBoxSizeMode.Fit;
			this.imageBox.SizeMode = Cutreson_UserControl.ImageBox.ImageBoxSizeMode.Normal;
		}
	}
}
