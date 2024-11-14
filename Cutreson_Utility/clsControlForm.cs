using System.Windows.Forms;

namespace Cutreson_Utility
{
    public class clsControlForm
    {
        public static void LoadFormInPanel(Panel panel, Form form)
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
        public static void LoadFormInControl(Control control, Form form)
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
