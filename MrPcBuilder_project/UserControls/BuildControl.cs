using System;
using System.Windows.Forms;

namespace MrPcBuilder_project
{
    public partial class BuildControl : UserControl
    {
        NewBuildControl newbuildControl = new NewBuildControl();
        ListBuildsControl listBuildsControl = new ListBuildsControl();
        EditBuildControl editBuildControl = new EditBuildControl();
        public BuildControl()
        {
            InitializeComponent();

            panelMain.Controls.Add(newbuildControl);
            panelMain.Controls.Add(listBuildsControl);
            panelMain.Controls.Add(editBuildControl);

            listBuildsControl.Dock = DockStyle.Fill;
            newbuildControl.Dock = DockStyle.Fill;
            editBuildControl.Dock = DockStyle.Fill;
        }

        private void btnNewBuild_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            newbuildControl.Visible = true;
        }
        private void btnListBuilds_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            listBuildsControl.Visible = true;
        }

        private void btnEditBuild_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            editBuildControl.Visible = true;
        }
    }
}
