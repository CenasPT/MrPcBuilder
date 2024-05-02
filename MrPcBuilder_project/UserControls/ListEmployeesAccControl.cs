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
    public partial class ListEmployeesAccControl : UserControl
    {
        DBConnect conn = new DBConnect();
        public ListEmployeesAccControl()
        {
            InitializeComponent();
        }

        private void ListEmployeesAccControl_Load(object sender, EventArgs e)
        {
            dgvListEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListEmployees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListEmployees.AllowUserToAddRows = false;
            dgvListEmployees.AllowUserToDeleteRows = false;
            dgvListEmployees.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvListEmployees.Columns.Add("id", "ID");
            dgvListEmployees.Columns.Add("name", "Name");
            dgvListEmployees.Columns.Add("position", "Position");
            dgvListEmployees.Columns.Add("email", "Email");
            dgvListEmployees.Columns.Add("tax_id", "Tax_ID");
            dgvListEmployees.Columns.Add("status", "Status");
            conn.FillComboBoxEmployeeName(ref cbNameFilter);
            conn.FillComboBoxEmployeeRole(ref cbPositionFilter);
            conn.FillDataGridViewListEmployees(ref dgvListEmployees, "", "");
            Global.ResizeDGV(dgvListEmployees);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = cbNameFilter.Text;
            string position = cbPositionFilter.Text;
            dgvListEmployees.Rows.Clear();
            conn.FillDataGridViewListEmployees(ref dgvListEmployees, name, position);
            Global.ResizeDGV(dgvListEmployees);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvListEmployees.Rows.Clear();
            conn.FillDataGridViewListEmployees(ref dgvListEmployees, "", "");
            Global.ResizeDGV(dgvListEmployees);
            cbNameFilter.Text = string.Empty;
            cbPositionFilter.Text = string.Empty;
            cbNameFilter.Items.Clear();
            cbPositionFilter.Items.Clear();
            conn.FillComboBoxEmployeeName(ref cbNameFilter);
            conn.FillComboBoxEmployeeRole(ref cbPositionFilter);
        }
    }
}
