using System;
using System.Windows.Forms;

namespace MrPcBuilder_project
{
    public partial class ComponentsControl : UserControl
    {
        NewComponentControl newcomponentControl = new NewComponentControl();
        ListComponentsControl listComponentsControl = new ListComponentsControl();
        EditComponentControl editComponentControl = new EditComponentControl();

        public ComponentsControl()
        {
            InitializeComponent();

            panelMain.Controls.Add(newcomponentControl);
            panelMain.Controls.Add(listComponentsControl);
            panelMain.Controls.Add(editComponentControl);

            newcomponentControl.Dock = DockStyle.Fill;
            listComponentsControl.Dock = DockStyle.Fill;
            editComponentControl.Dock = DockStyle.Fill;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            newcomponentControl.Visible = true;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            listComponentsControl.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            editComponentControl.Visible = true;
        }
    }
}
