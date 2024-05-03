using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MrPcBuilder_project
{
    public partial class EditEmployeeControl : UserControl
    {
        DBConnect conn = new DBConnect();
        public EditEmployeeControl()
        {
            InitializeComponent();
        }

        private void EditEmployeeControl_Load(object sender, EventArgs e)
        {
            Global.DeactivateEditing(panelEditEmployee2);
            conn.FillComboBoxEmployeeRole(ref cbEditRoleEmployee);
            Global.DeactivateEditing(panelEditEmployee3);
            lblBloquedAccount.Visible = false;
            nudEmployeeID.Focus();
        }

        // EMPLOYEE SEARCH
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string name = "", role = "", email = "", tax_id = "", user_status = "";

            if (conn.SearchEmployee(nudEmployeeID.Value.ToString(), ref name, ref role, ref email, ref tax_id, ref user_status))
            {
                txtEditNameEmployee.Text = name;
                cbEditRoleEmployee.Text = role;
                txtEditEmailEmployee.Text = email;
                txtEditTax_IDEmployee.Text = tax_id;
                txtUsernameEmployee.Enabled = false;
                txtPassEmployee.Enabled = false;

                if (user_status == "Active")
                {
                    Global.ActivateEditing(panelEditEmployee2);
                    Global.DeactivateEditing(panelEditEmployee1);                    
                    txtEditNameEmployee.Focus();
                }
                else if (user_status =="Inactive")
                {
                    Global.ActivateEditing(panelEditEmployee3);
                    Global.DeactivateEditing(panelEditEmployee2);
                    Global.DeactivateEditing(panelEditEmployee1);
                    lblBloquedAccount.Visible = true;
                    btnReactivateAcc.Focus();
                }                
            }
            else
            {
                MessageBox.Show("Employee Not Found!");
                nudEmployeeID.Focus();
            }
        }

        // CHECK FIELDS 
        private bool CheckEditEmployeeFields()
        {
            Global.RemoveTextSpaces(ref txtEditNameEmployee);
            if (txtEditNameEmployee.Text.Length < 2)
            {
                MessageBox.Show("Error in Name field!");
                txtEditNameEmployee.Focus();
                return false;
            }
            if (cbEditRoleEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("Error in Role Selection!");
                cbEditRoleEmployee.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtEditEmailEmployee);
            if (txtEditEmailEmployee.Text.Length < 2)
            {
                MessageBox.Show("Error in Email field!");
                txtEditEmailEmployee.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtEditTax_IDEmployee);
            if (txtEditTax_IDEmployee.Text.Length < 2)
            {
                MessageBox.Show("Error in Tax ID field!");
                txtEditTax_IDEmployee.Focus();
                return false;
            }
            return true;
        }

        // EDIT/UPDATE EMPLOYEE ACC 
        private void btnSaveEditEmployee_Click_1(object sender, EventArgs e)
        {
            if (CheckEditEmployeeFields())
            {
                string id = nudEmployeeID.Value.ToString();
                string name = txtEditNameEmployee.Text;
                string role = cbEditRoleEmployee.Text;
                string email = txtEditEmailEmployee.Text;
                string tax_id = txtEditTax_IDEmployee.Text;

                if (conn.UpdateEmployee(id, name, role, email, tax_id))
                {
                    MessageBox.Show("Employee Information Updated Successfully");
                    btnCancel_Click(sender, e);
                    nudEmployeeID.Focus();
                }
                else
                {
                    MessageBox.Show("Error Updating Employee!");
                    txtEditNameEmployee.Focus();
                }
            }
        }
        private void btnRefreshEditEmployee_Click_1(object sender, EventArgs e)
        {
            btnSearch_Click_1(sender, e);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEditNameEmployee.Clear();
            cbEditRoleEmployee.Text = string.Empty;
            cbEditRoleEmployee.Items.Clear();
            conn.FillComboBoxEmployeeRole(ref cbEditRoleEmployee);
            txtEditEmailEmployee.Clear();
            txtEditTax_IDEmployee.Clear();
            Global.DeactivateEditing(panelEditEmployee2);
            Global.ActivateEditing(panelEditEmployee1);
            nudEmployeeID.Focus();
        }

        // LIMIT INPUT TO ONLY DIGITS
        private void txtEditTax_IDEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.AllowOnlyDigits(sender, e);
        }

        // REACTIVATE ACC
        private void btnReactivateAcc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are about to REACTIVATE a Bloqued Account!\nAre You Sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string randomUsername = txtEditEmailEmployee.Text;
                if (txtEditEmailEmployee.Text.Length > 15)
                {
                    randomUsername = txtEditEmailEmployee.Text.Substring(0, 15);
                }
                txtUsernameEmployee.Text = randomUsername;
                txtPassEmployee.Text = txtEditNameEmployee.Text + "123";
                MessageBox.Show("Attention: Login info will be shown only once. Make sure to save it securely.");
                btnReactivateAcc.Enabled = false;
                lblBloquedAccount.Text = "Make sure to save Login info securely.";
                lblBloquedAccount.Location = new Point(398,23);
                btnSaveEmployeeAcc.Focus();
            }
        }
        
        private void btnSaveEmployeeAcc_Click(object sender, EventArgs e)
        {
            string id_search = nudEmployeeID.Value.ToString();
            string username = txtUsernameEmployee.Text;
            string password = txtPassEmployee.Text;
            txtUsernameEmployee.Text = string.Empty;
            txtPassEmployee.Text = string.Empty;

            if (conn.RegenerateEmployeeLogin(id_search, username, password))
            {
                MessageBox.Show("Employee Information Updated Successfully");
                btnCancelNewLogin_Click(sender, e);
                nudEmployeeID.Focus();
            }
            else
            {
                MessageBox.Show("Error Updating Employee!");
                btnCancel.Focus();
            }            
        }

        private void btnCancelNewLogin_Click(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
            Global.DeactivateEditing(panelEditEmployee3);
            lblBloquedAccount.Visible = false;
        }
    }
}
