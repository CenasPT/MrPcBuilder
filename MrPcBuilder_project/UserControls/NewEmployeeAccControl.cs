using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MrPcBuilder_project
{
    public partial class NewEmployeeAccControl : UserControl
    {
        DBConnect conn = new DBConnect();
        public NewEmployeeAccControl()
        {            
            InitializeComponent();
        }

        private void EditEmployeeAccControl_Load(object sender, EventArgs e)
        {
            txtUsernameEmployee.Enabled = false;
            txtPassEmployee.Enabled = false;
            conn.FillComboBoxEmployeeRole(ref cbRoleEmployee);
            txtNameEmployee.Focus();
        }        

        // CHECK FIELDS
        private bool CheckEmployeeFields()
        {
            Global.RemoveTextSpaces(ref txtNameEmployee);
            if (txtNameEmployee.Text.Length < 2)
            {
                MessageBox.Show("Error in Name field!");
                txtNameEmployee.Focus();
                return false;
            }
            if (cbRoleEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("Error in Role field!");
                cbRoleEmployee.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtEmailEmployee);
            if (txtEmailEmployee.Text.Length < 2)
            {
                MessageBox.Show("Error in Email field!");
                txtEmailEmployee.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtTax_IDEmployee);
            if (txtTax_IDEmployee.Text.Length < 2)
            {
                MessageBox.Show("Error in Tax ID field!");
                txtTax_IDEmployee.Focus();
                return false;
            }
            return true;
        }

        // GENERATE LOGIN USERNAME & PASSWORD
        private void btnGenerateLoginEmployee_Click(object sender, EventArgs e)
        {
            if (CheckEmployeeFields())
            {
                string randomUsername = txtEmailEmployee.Text;
                if (txtEmailEmployee.Text.Length > 15)
                {
                    randomUsername = txtEmailEmployee.Text.Substring(0, 15);
                }
                txtUsernameEmployee.Text = randomUsername;
                txtPassEmployee.Text = txtNameEmployee.Text + "123";
                btnSaveEmployeeAcc.Focus();
            }
        }

        // SAVE NEW EMPLOYEE ACC IN DATABASE
        private void btnSaveEmployeeAcc_Click(object sender, EventArgs e)
        {
            if (CheckEmployeeFields())
            {
                if (txtUsernameEmployee.Text.Length < 2 || txtPassEmployee.Text.Length < 2)
                {
                    MessageBox.Show("Error in Username/Password Generation!");
                    txtNameEmployee.Focus();
                }
                else
                {
                    string name = txtNameEmployee.Text;
                    string role = cbRoleEmployee.Text;
                    string email = txtEmailEmployee.Text;
                    string tax_id = txtTax_IDEmployee.Text;
                    string username = txtUsernameEmployee.Text;
                    string password = txtPassEmployee.Text;

                    if (conn.InsertNewEmployee(name, role, email, tax_id, username, password))
                    {
                        MessageBox.Show("New Employee Information Added");
                        btnRefreshEmployeeInfo_Click(sender, e);
                        txtNameEmployee.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error While Saving New Employee Information!");
                        txtNameEmployee.Focus();
                    }
                }                
            }
        }
        private void btnRefreshEmployeeInfo_Click(object sender, EventArgs e)
        {
            txtNameEmployee.Clear();
            cbRoleEmployee.Text = string.Empty;
            cbRoleEmployee.Items.Clear();
            conn.FillComboBoxEmployeeRole(ref cbRoleEmployee);
            txtEmailEmployee.Clear();
            txtTax_IDEmployee.Clear();
            txtUsernameEmployee.Clear();
            txtPassEmployee.Clear();

            txtNameEmployee.Focus();
        }

        // LIMIT INPUT TO ONLY DIGITS
        private void txtTax_IDEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.AllowOnlyDigits(sender, e);
        }
    }
}
