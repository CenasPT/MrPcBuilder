using System;
using System.Windows.Forms;

namespace MrPcBuilder_project
{
    public partial class LogInForm : Form
    {
        DBConnect connection = new DBConnect();
        public LogInForm()
        {
            InitializeComponent();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Insert a username!");
            }else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Insert a password!");
            }else if (connection.ValidateLogin(txtUserName.Text, txtPassword.Text))
            {
                DialogResult = DialogResult.OK;             
            }
            else
            {                
                Clean();
            }
        }

        private void Clean()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            panel2.Focus();
            txtUserName.Focus();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
