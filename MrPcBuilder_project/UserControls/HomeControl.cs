using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace MrPcBuilder_project
{
    public partial class HomeControl : UserControl
    {
        DBConnect conn = new DBConnect();
        public int id_employee = 0;

        public HomeControl()
        {
            InitializeComponent();
        }

        private void UserControlHome_Load(object sender, EventArgs e)
        {
            UpdateStatusCounter();
            timer1.Start();
            lblDateToday.Text = DateTime.Now.ToLongDateString();            
            panelEditPersonalAcc2.Visible = false;
        }

        // BUILDS STATUS
        public void UpdateStatusCounter()
        {
            string pending = "";
            string inprogress = "";
            string completed = "";
            conn.BuildsStatusCounter(out pending, out inprogress, out completed);
            lblBuildPendingCounter.Text = pending;
            lblBuildInProgressCounter.Text = inprogress;
            lblBuildCompletedCounter.Text = completed;
        }

        // CLOCK
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        // EDIT PERSONAL ACCOUNT
        private void FillPersonalAccountDetails()
        {
            string name = "", email = "", tax_id = "", username = "", password = "";
            conn.FillPersonalAccountDetails(id_employee, ref name, ref email, ref tax_id, ref username, ref password);
            txtEditName.Text = name;
            txtEditEmail.Text = email;
            txtEditTax_ID.Text = tax_id;
            txtUsernameEmployee.Text = username;
            txtPassEmployee.Text = password;
        }

        private void btnPersonalAccount_Click(object sender, EventArgs e)
        {
            FillPersonalAccountDetails();

            if (panelEditPersonalAcc2.Visible == false)
            {
                panelEditPersonalAcc2.Visible = true;
            }
            else
            {
                panelEditPersonalAcc2.Visible = false;
            }            
        }

        // CHECK FIELDS
        private bool CheckClientFields()
        {
            Global.RemoveTextSpaces(ref txtEditName);
            if (txtEditName.Text.Length < 2)
            {
                MessageBox.Show("Error in Name field!");
                txtEditName.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtEditEmail);
            if (txtEditEmail.Text.Length < 2)
            {
                MessageBox.Show("Error in Email field!");
                txtEditEmail.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtEditTax_ID);
            if (txtEditTax_ID.Text.Length < 2)
            {
                MessageBox.Show("Error in Tax ID field!");
                txtEditTax_ID.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtUsernameEmployee);
            if (txtUsernameEmployee.Text.Length < 2)
            {
                MessageBox.Show("Error in Username field!");
                txtUsernameEmployee.Focus();
                return false;
            }
            Global.RemoveTextSpaces(ref txtPassEmployee);
            if (txtPassEmployee.Text.Length < 2)
            {
                MessageBox.Show("Error in Password field!");
                txtPassEmployee.Focus();
                return false;
            }
            return true;
        }

        // SAVE/UPDATE CLIENT ACC
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (CheckClientFields())
            {
                string name = txtEditName.Text;
                string email = txtEditEmail.Text;
                string tax_id = txtEditTax_ID.Text;
                string username = txtUsernameEmployee.Text;
                string password = txtPassEmployee.Text;

                if (conn.UpdatePersonalAccountsDetails(id_employee, name, email, tax_id, username, password))
                {
                    MessageBox.Show("Personal Information Updated Successfully");
                    btnCancel_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error Updating Personal Info!");
                    txtEditName.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelEditPersonalAcc2.Visible = false;
            btnPersonalAccount.Focus();
        }
    }
}
