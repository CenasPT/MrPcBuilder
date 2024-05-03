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
    public partial class ClientEditControl : UserControl
    {
        DBConnect conn = new DBConnect();
        public ClientEditControl()
        {
            InitializeComponent();
        }

        private void ClientEditControl_Load(object sender, EventArgs e)
        {
            Global.DeactivateEditing(panelEditClient2);
            Global.DeactivateEditing(panelEditClient3);
            lblBloquedAccount.Visible = false;
            nudClientID.Focus();
        }        

        // CLIENT SEARCH
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = "", lastname = "", email = "", contact = "", tax_id = "", street = "", zip = "", country = "", user_status = "";

            if (conn.SearchClient(nudClientID.Value.ToString(), ref name, ref lastname, ref email, ref contact, ref tax_id, ref street, ref zip, ref country, ref user_status))
            {
                txtNameClient.Text = name;
                txtLastNameClient.Text = lastname;
                txtEmailClient.Text = email;
                txtContactClient.Text = contact;
                txtTax_IDClient.Text = tax_id;
                txtStreetClient.Text = street;
                txtZipCodeClient.Text = zip;
                txtCountryClient.Text = country;
                txtNewUsernameClient.Enabled = false;
                txtNewPassClient.Enabled = false;

                if (user_status == "Active")
                {
                    Global.ActivateEditing(panelEditClient2);
                    Global.DeactivateEditing(panelEditClient1);
                    txtNameClient.Focus();
                }
                else if (user_status == "Inactive")
                {
                    Global.ActivateEditing(panelEditClient3);
                    Global.DeactivateEditing(panelEditClient2);
                    Global.DeactivateEditing(panelEditClient1);
                    lblBloquedAccount.Visible = true;
                    btnReactivateAcc.Focus();
                }
            }
            else
            {
                MessageBox.Show("Client Not Found!");
                nudClientID.Focus();
            }
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
            return true;
        }

        // SAVE/UPDATE CLIENT ACC
        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            if (CheckClientFields())
            {
                string id = nudClientID.Value.ToString();
                string name = txtNameClient.Text;
                string lastname = txtLastNameClient.Text;
                string email = txtEmailClient.Text;
                string contact = txtContactClient.Text;
                string tax_id = txtTax_IDClient.Text;
                string street = txtStreetClient.Text;
                string zip = txtZipCodeClient.Text;
                string country = txtCountryClient.Text;

                if (conn.UpdateClient(id, name, lastname, email, contact, tax_id, street, zip, country))
                {
                    MessageBox.Show("Client Information Updated Successfully");
                    btnCancelEdit_Click(sender, e);
                    nudClientID.Focus();
                }
                else
                {
                    MessageBox.Show("Error Updating Client Info!");
                    txtNameClient.Focus();
                }
            }
        }

        private void btnRefreshClient_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            txtNameClient.Clear();
            txtLastNameClient.Clear();
            txtEmailClient.Clear();
            txtContactClient.Clear();
            txtTax_IDClient.Clear();
            txtStreetClient.Clear();
            txtZipCodeClient.Clear();
            txtCountryClient.Clear();
            Global.DeactivateEditing(panelEditClient2);
            Global.ActivateEditing(panelEditClient1);
            nudClientID.Focus();
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

        // REACTIVATE ACC

        private void btnReactivateAcc_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are about to REACTIVATE a Bloqued Account!\nAre You Sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string randomUsername = txtEmailClient.Text;
                if (txtEmailClient.Text.Length > 15)
                {
                    randomUsername = txtEmailClient.Text.Substring(0, 15);
                }
                txtNewUsernameClient.Text = randomUsername;
                txtNewPassClient.Text = txtNameClient.Text + "123";
                MessageBox.Show("Attention: Login info will be shown only once. Make sure to save it securely.");
                btnReactivateAcc.Enabled = false;
                lblBloquedAccount.Text = "Make sure to save Login info securely.";
                lblBloquedAccount.Location = new Point(398, 23);
                btnSaveNewLogin.Focus();
            }
        }

        private void btnSaveNewLogin_Click(object sender, EventArgs e)
        {
            string id_search = nudClientID.Value.ToString();
            string username = txtNewUsernameClient.Text;
            string password = txtNewPassClient.Text;
            txtNewUsernameClient.Text = string.Empty;
            txtNewPassClient.Text = string.Empty;

            if (conn.RegenerateClientLogin(id_search, username, password))
            {
                MessageBox.Show("Employee Information Updated Successfully");
                btnCancelNewLogin_Click_1(sender, e);
                nudClientID.Focus();
            }
            else
            {
                MessageBox.Show("Error Updating Employee!");
                btnCancelNewLogin.Focus();
            }
        }

        private void btnCancelNewLogin_Click_1(object sender, EventArgs e)
        {
            btnCancelEdit_Click(sender, e);
            Global.DeactivateEditing(panelEditClient3);
            lblBloquedAccount.Visible = false;
        }
    }
}
