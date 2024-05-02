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
    public partial class ClientsControl : UserControl
    {
        ClientNewControl clientNewControl = new ClientNewControl();
        ClientsListControl clientsListControl = new ClientsListControl();
        ClientEditControl clientEditControl = new ClientEditControl();

        public ClientsControl()
        {
            InitializeComponent();

            panelMain.Controls.Add(clientNewControl);
            panelMain.Controls.Add(clientsListControl);
            panelMain.Controls.Add(clientEditControl);

            clientNewControl.Dock = DockStyle.Fill;
            clientsListControl.Dock = DockStyle.Fill;
            clientEditControl.Dock = DockStyle.Fill;
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            clientNewControl.Visible = true;
        }

        private void btnListClients_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            clientsListControl.Visible = true;
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            clientEditControl.Visible = true;
        }
    }
}
