using System;
using System.Windows.Forms;

namespace MrPcBuilder_project
{
    public partial class MainForm : Form
    {
        LogInForm login = new LogInForm();        
        
        HomeControl homeControl = new HomeControl();
        BuildControl buildControl = new BuildControl();
        ComponentsControl componentsControl = new ComponentsControl();
        ClientsControl clientsControl = new ClientsControl();
        AdminControl adminControl = new AdminControl();
        bool sidebarExpand = true;        

        public MainForm()
        {
            InitializeComponent();
            FormAddProperty.EnableFormDragging(this, panelTitleBar);
            this.DoubleBuffered = true; // Helps sidebar transition become smoother        
        }

        private void Main_Load(object sender, EventArgs e)
        {            
            if (login.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                panelMain.Controls.Add(homeControl);
                panelMain.Controls.Add(buildControl);      
                panelMain.Controls.Add(componentsControl);
                panelMain.Controls.Add(clientsControl);
                panelMain.Controls.Add(adminControl);

                buildControl.Dock = DockStyle.Fill;
                homeControl.Dock = DockStyle.Fill;
                componentsControl.Dock = DockStyle.Fill;
                clientsControl.Dock = DockStyle.Fill;
                adminControl.Dock = DockStyle.Fill;

                Global.HideAllUserControls(panelMain);
                homeControl.Visible = true;                
            }            
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            btnHome.Focus();
            lblUserName.Text = login.nameOfUser;
            homeControl.id_employee = login.idEmployee;
            if (login.role == "Administrator")
            {
                btnAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
            }
        }

        // Sidebar Menu Selection
        private void btnHome_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            homeControl.UpdateStatusCounter();
            homeControl.Visible = true;
            lblTopPanelTitle.Text = "HOME";
        }
        private void btnBuild_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            buildControl.Visible = true;
            lblTopPanelTitle.Text = "BUILD";
        }        
        private void btnComponents_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            componentsControl.Visible = true;
            lblTopPanelTitle.Text = "COMPONENTS";
        }

        private void btnclients_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            clientsControl.Visible = true;
            lblTopPanelTitle.Text = "CLIENTS";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            adminControl.Visible = true;
            lblTopPanelTitle.Text = "ADMIN";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("About to Log Out.\nAre you sure?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                lblUserName.Text = "";
                this.Visible = false;
                
                if (login.ShowDialog() != DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    this.Visible=true;
                    MainForm_Shown(sender, e);
                }
            }
            
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Close and open Sidebar Menu
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // Contract or expand sidebar width untill max or min width
            if (sidebarExpand)
            {
                panelSidebar.Width -= 10;
                if (panelSidebar.Width == panelSidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                panelSidebar.Width += 10;
                if (panelSidebar.Width == panelSidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }        
        private void pbMenuButton_Click(object sender, EventArgs e)
        {            
            sidebarTimer.Start();
        }

        // Manimize or minimize Window
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }        
    }
}
