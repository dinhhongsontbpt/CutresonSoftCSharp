using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Terumo
{
	public class ControlForm
	{
		public void LoadFormInPanel(Panel panel, Form form)
		{
			//int panelWidth = panel.Width;
			//int panelHeight = panel.Height;
			form.TopLevel = false;
			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;
			panel.Controls.Clear();
			panel.Controls.Add(form);
			form.Show();
		}
		public void LoadFormInControl(Control control, Form form)
		{
			//int panelWidth = panel.Width;
			//int panelHeight = panel.Height;
			form.TopLevel = false;
			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;
			control.Controls.Clear();
			control.Controls.Add(form);
			form.Show();
		}
	}
}
