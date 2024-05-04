using System;
using System.Drawing;
using System.Windows.Forms;

namespace MrPcBuilder_project
{
    public partial class LogInForm : Form
    {
        DBConnect connection = new DBConnect();
        public string nameOfUser = "";
        public string role = "";
        public int idEmployee = 0;
        NewEmployeeAccControl newEmployeeAccControl = new NewEmployeeAccControl();
        public LogInForm()
        {
            InitializeComponent();
            FormAddProperty.EnableFormDragging(this, panel1);
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            Clean();
            lblIvalidUsername.Text = string.Empty;
            lblInvalidPassword.Text = string.Empty;
            lblBloquedUser.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblIvalidUsername.Text = string.Empty;
            lblInvalidPassword.Text = string.Empty;
            lblBloquedUser.Text = string.Empty;
            int fail_message = 0;

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                lblIvalidUsername.Text = "Insert a username!";
            }else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblInvalidPassword.Text = "Insert a password!";
            }else if (connection.ValidateLogin(txtUserName.Text, txtPassword.Text, ref nameOfUser, ref role, ref idEmployee, ref fail_message))
            {
                DialogResult = DialogResult.OK;  
            }
            else
            {
                if (fail_message == 1)
                {
                    lblIvalidUsername.Text = "Invalid Username!";
                }
                else if (fail_message == 2)
                {
                    lblInvalidPassword.Text = "Invalid Password!";
                }
                else if (fail_message == 3)
                {
                    lblBloquedUser.Text = "Blocked User! Contact System Administrator.";
                }                
                Clean();
            }
        }

        private void Clean()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            panelLogin.Focus();
            txtUserName.Focus();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }

        private void LogInForm_Shown(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
    }
}
