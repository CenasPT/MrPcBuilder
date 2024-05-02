using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrPcBuilder_project
{
    internal class Global
    {
        // REMOVE SPACES
        public static void RemoveTextSpaces(ref TextBox textbox)
        {
            textbox.Text = Regex.Replace(textbox.Text.Trim(), @"\s+", " ");
        }

        // DISABLE AND ENABLE PANELS FOR EDITING
        public static void DeactivateEditing(Panel panel)
        {
            panel.Enabled = false;

            foreach (Control control in panel.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.BackColor = Color.Gray;
                }
            }
        }
        public static void ActivateEditing(Panel panel)
        {
            panel.Enabled = true;

            foreach (Control control in panel.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.BackColor = Color.White;
                }
            }
        }

        // HIDE USERCONTROLS IN PANEL
        public static void HideAllUserControls(Control panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is UserControl)
                {
                    control.Visible = false;
                }
            }
        }

        // ALLOW ONLY DIGITS 
        public static void AllowOnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // RESIZE DATAGRIDVIEWS
        public static void ResizeDGV(DataGridView dgv)
        {
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Width < 100)
                {
                    column.Width = 100;
                }
            }
        }

        // RESIZE LISTVIEWS
        public static void ResizeListViewColumns(ListView listView)
        {
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            foreach (ColumnHeader column in listView.Columns)
            {
                if (column.Width < 100)
                {
                    column.Width = 100;
                }
            }
        }
    }    

    public static class FormAddProperty
    {
        // Constants needed for dragging the form
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        // Import the SendMessage function to send messages to the system
        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        // Method to enable dragging of a form using a panel
        public static void EnableFormDragging(Form form, Control panel)
        {
            panel.MouseDown += (sender, e) =>
            {
                // Check if left mouse button is clicked
                if (e.Button == MouseButtons.Left)
                {
                    // Send a message to the system to move the form
                    ReleaseCapture();
                    SendMessage(form.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
        }
    }
}
