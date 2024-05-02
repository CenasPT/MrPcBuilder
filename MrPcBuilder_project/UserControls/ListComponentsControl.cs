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
    public partial class ListComponentsControl : UserControl
    {
        DBConnect conn = new DBConnect();
        public ListComponentsControl()
        {
            InitializeComponent();
        }

        private void ListComponentsControl_Load(object sender, EventArgs e)
        {
            dgvListComponents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListComponents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListComponents.AllowUserToAddRows = false;
            dgvListComponents.AllowUserToDeleteRows = false;
            dgvListComponents.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvListComponents.Columns.Add("id", "ID");
            dgvListComponents.Columns.Add("type", "Type");
            dgvListComponents.Columns.Add("name", "Name");
            dgvListComponents.Columns.Add("model", "Model");
            dgvListComponents.Columns.Add("manufacturer", "Manufacturer");
            dgvListComponents.Columns.Add("price", "Price");
            dgvListComponents.Columns.Add("description", "Description");
            conn.FillComboBoxManufacturerName(ref cbManufacturerComponent);
            conn.FillComboBoxComponentType(ref cbTypeComponent);
            conn.FillDataGridViewListComponents(ref dgvListComponents, "", "");
            Global.ResizeDGV(dgvListComponents);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string type = cbTypeComponent.Text;
            string manufacturer = cbManufacturerComponent.Text;
            dgvListComponents.Rows.Clear();
            conn.FillDataGridViewListComponents(ref dgvListComponents, type, manufacturer);
            Global.ResizeDGV(dgvListComponents);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvListComponents.Rows.Clear();
            conn.FillDataGridViewListComponents(ref dgvListComponents, "", "");
            Global.ResizeDGV(dgvListComponents);
            cbManufacturerComponent.Text = string.Empty;
            cbTypeComponent.Text = string.Empty;
            cbManufacturerComponent.Items.Clear();
            cbTypeComponent.Items.Clear();
            conn.FillComboBoxManufacturerName(ref cbManufacturerComponent);
            conn.FillComboBoxComponentType(ref cbTypeComponent);
        }
    }
}
