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
    public partial class CompanyRolesControl : UserControl
    {
        DBConnect conn = new DBConnect();
        public CompanyRolesControl()
        {
            InitializeComponent();
        }

        private void CompanyPositionsControl_Load(object sender, EventArgs e)
        {
            conn.FillComboBoxEmployeeRole(ref cbSearchEditCompanyRole);
            conn.FillComboBoxEmployeeRole(ref cbSearchDeleteCompanyRole);
            Global.DeactivateEditing(panelEdit2);
            txtNewCompanyRole.Focus();
        }

        // ADD NEW COMPANY ROLE
        private void btnAddNewCompanyPosition_Click(object sender, EventArgs e)
        {
            if (txtNewCompanyRole.Text.Length < 2)
            {
                MessageBox.Show("Error in Name field!");
                txtNewCompanyRole.Focus();
            }
            else
            {
                if (conn.InsertNewCompanyRole(txtNewCompanyRole.Text))
                {
                    MessageBox.Show("Successfully Added New Company Role");
                    btnClearNewCompanyPosition_Click(sender, e);
                    cbSearchEditCompanyRole.Items.Clear();
                    cbSearchEditCompanyRole.Text = string.Empty;
                    cbSearchDeleteCompanyRole.Items.Clear();
                    cbSearchDeleteCompanyRole.Text = string.Empty;
                    conn.FillComboBoxEmployeeRole(ref cbSearchEditCompanyRole);
                    conn.FillComboBoxEmployeeRole(ref cbSearchDeleteCompanyRole);
                    txtNewCompanyRole.Focus();
                }
                else
                {
                    MessageBox.Show("Error Inserting New Company Role!");
                    txtNewCompanyRole.Focus();
                }
            }
        }

        private void btnClearNewCompanyPosition_Click(object sender, EventArgs e)
        {
            txtNewCompanyRole.Text = string.Empty;
            txtNewCompanyRole.Focus();
        }

        // EDIT COMPANY ROLES
        private void btnEditCompanyPosition_Click(object sender, EventArgs e)
        {
            Global.DeactivateEditing(panelEdit1);
            Global.DeactivateEditing(panelNew);
            Global.DeactivateEditing(panelDelete);
            Global.ActivateEditing(panelEdit2);            
        }

        private void btnUpdateCompanyPosition_Click(object sender, EventArgs e)
        {
            if (txtEditCompanyRoleName.Text.Length < 2)
            {
                MessageBox.Show("Error in Name field!");
                txtEditCompanyRoleName.Focus();
            }
            else
            {
                string old_name = cbSearchEditCompanyRole.Text;
                string new_name = txtEditCompanyRoleName.Text;

                if (conn.UpdateCompanyRole(old_name, new_name))
                {
                    MessageBox.Show("Successfully Updated Company Role");
                    btnRefreshEditCompanyPosition_Click(sender, e);
                    cbSearchEditCompanyRole.Focus();
                }
                else
                {
                    MessageBox.Show("Error Updating Company Role!");
                    cbSearchEditCompanyRole.Focus();
                }
            }
        }

        private void btnRefreshEditCompanyPosition_Click(object sender, EventArgs e)
        {
            cbSearchEditCompanyRole.Items.Clear();
            cbSearchEditCompanyRole.Text = string.Empty;
            cbSearchDeleteCompanyRole.Items.Clear();
            cbSearchDeleteCompanyRole.Text = string.Empty;
            conn.FillComboBoxEmployeeRole(ref cbSearchEditCompanyRole);
            conn.FillComboBoxEmployeeRole(ref cbSearchDeleteCompanyRole);
            txtEditCompanyRoleName.Text = string.Empty;
            Global.DeactivateEditing(panelEdit2);
            Global.ActivateEditing(panelEdit1);
            Global.ActivateEditing(panelNew);
            Global.ActivateEditing(panelDelete);
            cbSearchEditCompanyRole.Focus();
        }

        private void btnDeleteCompanyPosition_Click(object sender, EventArgs e)
        {
            if (cbSearchDeleteCompanyRole.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("About to Delete '" + cbSearchDeleteCompanyRole.Text + "' !\nAre you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (conn.DeleteCompanyRole(cbSearchDeleteCompanyRole.Text))
                    {
                        MessageBox.Show("Successfully Deleted!");
                        btnRefreshDeleteCompanyPosition_Click(sender, e);
                        cbSearchDeleteCompanyRole.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete!");
                        cbSearchDeleteCompanyRole.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("No Option Selected!");
                cbSearchDeleteCompanyRole.Focus();
            }
        }

        private void btnRefreshDeleteCompanyPosition_Click(object sender, EventArgs e)
        {
            cbSearchEditCompanyRole.Items.Clear();
            cbSearchEditCompanyRole.Text = string.Empty;
            cbSearchDeleteCompanyRole.Items.Clear();
            cbSearchDeleteCompanyRole.Text = string.Empty;
            conn.FillComboBoxEmployeeRole(ref cbSearchEditCompanyRole);
            conn.FillComboBoxEmployeeRole(ref cbSearchDeleteCompanyRole);
            cbSearchDeleteCompanyRole.Focus();
        }
    }
}
