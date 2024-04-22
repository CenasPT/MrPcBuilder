using System;
using System.Windows.Forms;

namespace MrPcBuilder_project
{
    public partial class MainForm : Form
    {
        LogInForm login = new LogInForm();
        public MainForm()
        {
            InitializeComponent();            
        }

        private void Main_Load(object sender, EventArgs e)
        {            
            if (login.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            
        }
    }
}
