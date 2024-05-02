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
    public partial class ClientNewControl : UserControl
    {
        DBConnect conn = new DBConnect();

        public ClientNewControl()
        {
            InitializeComponent();
        }

        private void ClientNewControl_Load(object sender, EventArgs e)
        {
            txtUsernameClient.Enabled = false;
            txtPassClient.Enabled = false;
            txtNameClient.Focus();
        }

        // CHECK FIELDS
        private bool CheckClientFields()
        {
            Global.RemoveTextSpaces(ref txtNameClient);
            if (txtNameClient.Text.Length < 2)
            {
                MessageBox.Show("Error in Name field!");
                txtNameClient.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtLastNameClient);
            if (txtLastNameClient.Text.Length < 2)
            {
                MessageBox.Show("Error in Last Name field!");
                txtLastNameClient.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtEmailClient);
            if (txtEmailClient.Text.Length < 2)
            {
                MessageBox.Show("Error in Email field!");
                txtEmailClient.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtContactClient);
            if (txtContactClient.Text.Length > 0 && txtContactClient.Text.Length < 5)
            {
                MessageBox.Show("Error in Contact field!");
                txtContactClient.Focus();
                return false;
            }
            return true;
        }

        // GENERATE LOGIN USERNAME & PASSWORD
        private void btnGenerateLoginInfo_Click(object sender, EventArgs e)
        {
            if (CheckClientFields())
            {
                string randomUsername = txtEmailClient.Text;
                if (txtEmailClient.Text.Length > 15)
                {
                    randomUsername = txtEmailClient.Text.Substring(0, 15);
                }
                txtUsernameClient.Text = randomUsername;
                txtPassClient.Text = txtNameClient.Text + "123";
                btnSaveClient.Focus();
            }
        }

        // SAVE NEW CLIENT ACC IN DATABASE
        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            if (txtUsernameClient.Text.Length < 2 || txtPassClient.Text.Length < 2)
            {
                MessageBox.Show("Error in Username/Password Generation!");
                txtNameClient.Focus();
            }
            else
            {
                if (CheckClientFields())
                {
                    string name = txtNameClient.Text;
                    string last_name = txtLastNameClient.Text;
                    string street = txtStreetClient.Text;
                    string zip = txtZipCodeClient.Text;
                    string country = txtCountryClient.Text;
                    string contact = txtContactClient.Text;
                    string email = txtEmailClient.Text;
                    string tax_id = txtTax_IDClient.Text;
                    string username = txtUsernameClient.Text;
                    string password = txtPassClient.Text;

                    if (conn.InsertNewClient(name, last_name, street, zip, country, contact, email, tax_id, username, password))
                    {
                        MessageBox.Show("New Client Information Added");
                        btnRefreshClient_Click(sender, e);
                        txtNameClient.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error While Saving New Client Information!");
                        txtNameClient.Focus();
                    }
                }
            }            
        }

        private void btnRefreshClient_Click(object sender, EventArgs e)
        {
            txtNameClient.Clear();
            txtLastNameClient.Clear();
            txtStreetClient.Clear();
            txtZipCodeClient.Clear();
            txtCountryClient.Clear();
            txtContactClient.Clear();
            txtEmailClient.Clear();
            txtTax_IDClient.Clear();
            txtUsernameClient.Clear();
            txtPassClient.Clear();

            txtNameClient.Focus();
        }

        // LIMIT INPUT TO ONLY DIGITS
        private void txtContactClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.AllowOnlyDigits(sender, e);
        }
        private void txtTax_IDClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.AllowOnlyDigits(sender, e);
        }
    }
}
