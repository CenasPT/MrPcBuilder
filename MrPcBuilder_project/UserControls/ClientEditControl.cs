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
            nudClientID.Focus();
        }        

        // CLIENT SEARCH
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = "", lastname = "", email = "", contact = "", tax_id = "", street = "", zip = "", country = "";

            if (conn.SearchClient(nudClientID.Value.ToString(), ref name, ref lastname, ref email, ref contact, ref tax_id, ref street, ref zip, ref country))
            {
                txtNameClient.Text = name;
                txtLastNameClient.Text = lastname;
                txtEmailClient.Text = email;
                txtContactClient.Text = contact;
                txtTax_IDClient.Text = tax_id;
                txtStreetClient.Text = street;
                txtZipCodeClient.Text = zip;
                txtCountryClient.Text = country;

                Global.ActivateEditing(panelEditClient2);
                Global.DeactivateEditing(panelEditClient1);
                txtNameClient.Focus();
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
    }
}
