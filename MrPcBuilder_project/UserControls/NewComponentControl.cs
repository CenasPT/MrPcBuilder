using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrPcBuilder_project
{
    public partial class NewComponentControl : UserControl
    {
        DBConnect conn = new DBConnect();

        public NewComponentControl()
        {
            InitializeComponent();
        }
        private void NewComponentControl_Load(object sender, EventArgs e)
        {
            RefreshComboBoxes();
            cbTypeComponent.Focus();
        }

        private void RefreshComboBoxes()
        {
            cbManufacturerComponent.Items.Clear();
            cbTypeComponent.Items.Clear();
            cbManufacturerComponent.Text = string.Empty;
            cbTypeComponent.Text = string.Empty;
            conn.FillComboBoxManufacturerName(ref cbManufacturerComponent);
            conn.FillComboBoxComponentType(ref cbTypeComponent);
        }

        // NEW TYPE OF COMPONENT
        private void btnAddNewType_Click(object sender, EventArgs e)
        {
            if (txtNewType.Text.Length < 2)
            {
                MessageBox.Show("Error in Name Field!");
                txtNewType.Focus();                
            }
            else
            {
                string new_type = txtNewType.Text;
                if (conn.InsertNewTypeComponent(new_type))
                {
                    MessageBox.Show("New Type of Component Added");                    
                    btnClearType_Click(sender, e);
                }
            }
        }
        private void btnClearType_Click(object sender, EventArgs e)
        {
            RefreshComboBoxes();
            txtNewType.Clear();
            txtNewType.Focus ();
        }

        // NEW MANUFACTURER
        private bool CheckManuFields()
        {
            if (txtManuName.Text.Length < 2)
            {
                MessageBox.Show("Error in Name field!");
                txtManuName.Focus();
                return false;
            }
            return true;
        }
        private void btnAddNewManu_Click(object sender, EventArgs e)
        {
            if (CheckManuFields())
            {
                string manu_name = txtManuName.Text;
                string manu_contact = txtManuContact.Text;
                string manu_email = txtManuEmail.Text;
                if (conn.InsertManufacturer(manu_name, manu_contact, manu_email))
                {
                    MessageBox.Show("New Manufacturer Added");                    
                    btnClearManu_Click(sender, e);                    
                }
            }
        }
        private void btnClearManu_Click(object sender, EventArgs e)
        {
            RefreshComboBoxes();
            txtManuName.Clear();
            txtManuContact.Clear();
            txtManuEmail.Clear();
            txtManuName.Focus();
        }

        //NEW COMPONENT
        private bool CheckComponentFields()
        {
            if (cbTypeComponent.SelectedIndex == -1)
            {
                MessageBox.Show("Error in Type field!");
                cbTypeComponent.Focus();
                return false;
            }
            if (cbManufacturerComponent.SelectedIndex == -1)
            {
                MessageBox.Show("Error in Type field!");
                cbManufacturerComponent.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtNameComponent);
            if (txtNameComponent.Text.Length < 2)
            {
                MessageBox.Show("Error in Name field!");
                txtNameComponent.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtModelComponent);
            if (txtModelComponent.Text.Length < 2)
            {
                MessageBox.Show("Error in Model field!");
                txtModelComponent.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtPriceComponent);
            if (txtPriceComponent.Text.Length <= 0)
            {
                MessageBox.Show("Error in Price field!");
                txtPriceComponent.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtDescriptionComponent);
            if (txtDescriptionComponent.Text.Length < 2)
            {
                MessageBox.Show("Error in Description field!");
                txtDescriptionComponent.Focus();
                return false;
            }
            return true;
        }
        private void btnSaveComponent_Click_1(object sender, EventArgs e)
        {
            if (CheckComponentFields())
            {
                string type = cbTypeComponent.Text;
                string manufacturer = cbManufacturerComponent.Text;
                string name = txtNameComponent.Text;
                string model = txtModelComponent.Text;
                string price = txtPriceComponent.Text;
                string description = txtDescriptionComponent.Text;                

                if (conn.InsertNewComponent(type, manufacturer, name, model, price, description))
                {
                    MessageBox.Show("New Component Added");
                    btnRefreshComponent_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error While Saving New Component!");
                    cbTypeComponent.Focus();
                }
            }
        }
        private void btnRefreshComponent_Click(object sender, EventArgs e)
        {
            RefreshComboBoxes();
            txtNameComponent.Clear();
            txtModelComponent.Clear();
            txtPriceComponent.Clear();
            txtDescriptionComponent.Clear();
            cbTypeComponent.Focus();
        }

        // LIMIT INPUT TO ONLY DIGITS
        private void txtPriceComponent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == '.') && textBox != null && textBox.Text.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
                private void txtManuContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.AllowOnlyDigits(sender, e);
        }
    }
}
