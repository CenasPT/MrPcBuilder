using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MrPcBuilder_project
{
    public partial class EditComponentControl : UserControl
    {
        DBConnect conn = new DBConnect();

        public EditComponentControl()
        {
            InitializeComponent();
        }

        private void EditComponentControl_Load(object sender, EventArgs e)
        {
            RefreshComboBoxes();
            Global.DeactivateEditing(panelEditComponent2);
            Global.DeactivateEditing(panelEditType2);
            Global.DeactivateEditing(panelEditManufacturer2);
            nudComponentID.Focus();
        }

        private void RefreshComboBoxes()
        {
            cbSearchType.Items.Clear();
            cbSearchManufacturer.Items.Clear();
            cbTypeComponent.Items.Clear();
            cbManufacturerComponent.Items.Clear();
            cbSearchType.Text = string.Empty;
            cbSearchManufacturer.Text = string.Empty;
            cbTypeComponent.Text = string.Empty;
            cbManufacturerComponent.Text = string.Empty;
            conn.FillComboBoxComponentType(ref cbSearchType);
            conn.FillComboBoxManufacturerName(ref cbSearchManufacturer);
            conn.FillComboBoxComponentType(ref cbTypeComponent);
            conn.FillComboBoxManufacturerName(ref cbManufacturerComponent);
        }

        // COMPONENT SEARCH FOR EDITING
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string type = "", name = "", model = "", manufacturer = "", price = "", description = "";

            if (conn.SearchComponent(nudComponentID.Value.ToString(), ref type, ref name, ref model, ref manufacturer, ref price, ref description))
            {
                cbTypeComponent.Text = type;
                cbManufacturerComponent.Text = manufacturer;
                txtNameComponent.Text = name;
                txtModelComponent.Text = model;
                txtPriceComponent.Text = price;
                txtDescriptionComponent.Text = description;

                Global.ActivateEditing(panelEditComponent2);
                Global.DeactivateEditing(panelEditComponent1);
                cbTypeComponent.Focus();
            }
            else
            {
                MessageBox.Show("Component Not Found!");
                nudComponentID.Focus();
            }
        }

        // CHECK EDITED COMPONENT FIELDS
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
                MessageBox.Show("Error in Manufacturer field!");
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
            if (txtPriceComponent.Text.Length < 2)
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

        // SAVE/UPDATE COMPONENT
        private void btnSaveComponent_Click(object sender, EventArgs e)
        {
            if (CheckComponentFields())
            {
                string id = nudComponentID.Value.ToString();
                string type = cbTypeComponent.Text;
                string manufacturer = cbManufacturerComponent.Text;
                string name = txtNameComponent.Text;
                string model = txtModelComponent.Text;
                string price = txtPriceComponent.Text;
                string description = txtDescriptionComponent.Text;

                if (conn.UpdateComponent(id, type, manufacturer, name, model, price, description))
                {
                    MessageBox.Show("Component Updated Successfully");
                    btnRefreshComponent_Click(sender, e);
                    txtNameComponent.Clear();
                    txtModelComponent.Clear();
                    txtPriceComponent.Clear();
                    txtDescriptionComponent.Clear();
                }
                else
                {
                    MessageBox.Show("Error Updating Component!");
                    cbTypeComponent.Focus();
                }
            }
        }
        private void btnRefreshComponent_Click(object sender, EventArgs e)
        {            
            RefreshComboBoxes();
            Global.DeactivateEditing(panelEditComponent2);
            Global.ActivateEditing(panelEditComponent1);
            nudComponentID.Focus();
        }

        // EDIT TYPE OF COMPONENT
        private void btnEditType_Click(object sender, EventArgs e)
        {
            if (cbSearchType.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Type!");
                cbSearchType.Focus();
            }
            else
            {
                Global.DeactivateEditing(panelEditType1);
                Global.ActivateEditing(panelEditType2);
                txtUpdateTypeName.Text = cbSearchType.Text;
                txtUpdateTypeName.Focus();
            }
        }

        // SAVE/UPDATE TYPE OF COMPONENT
        private void btnSaveUpdateType_Click(object sender, EventArgs e)
        {
            if (txtUpdateTypeName.Text.Length < 2)
            {
                MessageBox.Show("Insert a New Name for: " + cbSearchType.Text);
                txtUpdateTypeName.Focus();
            }
            else
            {
                string old_type_name = cbSearchType.Text;
                string new_type_name = txtUpdateTypeName.Text;

                if (conn.UpdateComponentType(old_type_name, new_type_name))
                {
                    MessageBox.Show("Type of Component Updated Successfully");
                    btnRefreshUpdateType_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error Updating Type of Component!");
                    txtUpdateTypeName.Focus();
                }
            }
        }
        private void btnRefreshUpdateType_Click(object sender, EventArgs e)
        {
            RefreshComboBoxes();
            Global.DeactivateEditing(panelEditType2);
            Global.ActivateEditing(panelEditType1);
            cbSearchType.Focus();
        }

        // EDIT MANUFACTURER
        private void btnEditManufacturer_Click(object sender, EventArgs e)
        {
            string contact = "";
            string email = "";
            if (cbSearchManufacturer.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Manufacturer!");
                cbSearchManufacturer.Focus();
            }
            else
            {
                Global.DeactivateEditing(panelEditManufacturer1);
                Global.ActivateEditing(panelEditManufacturer2);
                txtUpdateManuName.Text = cbSearchManufacturer.Text;
                conn.SearchManufacturer(txtUpdateManuName.Text, ref contact, ref email);
                txtUpdateManuContact.Text = contact;
                txtUpdateManuEmail.Text = email;
            }
        }
        private bool CheckManuFields()
        {
            if (txtUpdateManuName.Text.Length < 2)
            {
                MessageBox.Show("Error in Name field!");
                txtUpdateManuName.Focus();
                return false;
            }
            return true;
        }

        // SAVE/UPDATE MANUFACTURER
        private void btnSaveUpdateManu_Click(object sender, EventArgs e)
        {
            if (CheckManuFields())
            {
                string old_name = cbSearchManufacturer.Text;
                string new_name = txtUpdateManuName.Text;
                string new_contact = txtUpdateManuContact.Text;
                string new_email = txtUpdateManuEmail.Text;
                if (conn.UpdateManufacturer(old_name, new_name, new_contact, new_email))
                {
                    MessageBox.Show("Manufacturer Updated Successfully");
                    btnRefreshUpdateManu_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error Updating Manufacturer!");
                    txtUpdateManuName.Focus();
                }
            }
        }
        private void btnRefreshUpdateManu_Click(object sender, EventArgs e)
        {            
            RefreshComboBoxes();
            Global.DeactivateEditing(panelEditManufacturer2);
            Global.ActivateEditing(panelEditManufacturer1);
            cbSearchManufacturer.Focus();
        }
    }
}
