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
            int fails = 0;
            if (connection.ValidateLogin(txtUserName.Text, txtPassword.Text, ref fails))
            {
                DialogResult = DialogResult.OK;             
            }
            else
            {
                MessageBox.Show("Failed Authentication!\nFails: " + fails + "\nFail limit: 5");
                Clean();
            }
        }

        private void Clean()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
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
