using System;
using System.Windows.Forms;

namespace MrPcBuilder_project
{
    public partial class ListBuildsControl : UserControl
    {
        DBConnect conn = new DBConnect();
        public ListBuildsControl()
        {
            InitializeComponent();
        }

        private void BuildPendingControl_Load(object sender, EventArgs e)
        {
            dgvListBuilds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListBuilds.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListBuilds.AllowUserToAddRows = false;
            dgvListBuilds.AllowUserToDeleteRows = false;
            dgvListBuilds.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvListBuilds.Columns.Add("id", "ID");
            dgvListBuilds.Columns.Add("employee", "Employee");
            dgvListBuilds.Columns.Add("customer", "Customer");
            dgvListBuilds.Columns.Add("orderdate", "Order_Date");
            dgvListBuilds.Columns.Add("deliverydate", "Delivery_Date");
            dgvListBuilds.Columns.Add("totalprice", "Total_Price");
            dgvListBuilds.Columns.Add("components", "Components");
            dgvListBuilds.Columns.Add("status", "Status");
            FillComboBoxes();
            conn.FillDataGridViewListBuilds(ref dgvListBuilds, "", "", "", "", "");
            Global.ResizeDGV(dgvListBuilds);
        }

        // Fill Comboboxes
        private void FillComboBoxes()
        {
            cbEmployeeFilter.Text = string.Empty;
            cbCustomerFilter.Text = string.Empty;
            cbStatusFilter.Text = string.Empty;
            cbOrderDateFilter.Text = string.Empty;
            cbDeliveryDateFilter.Text = string.Empty;
            cbEmployeeFilter.Items.Clear();
            cbCustomerFilter.Items.Clear();
            cbStatusFilter.Items.Clear();
            cbOrderDateFilter.Items.Clear();
            cbDeliveryDateFilter.Items.Clear();
            conn.FillComboBoxEmployeeName(ref cbEmployeeFilter);
            conn.FillComboBoxCustomerName(ref cbCustomerFilter);
            conn.FillComboBoxOrderDate(ref cbOrderDateFilter);
            conn.FillComboBoxDeliveryDate(ref cbDeliveryDateFilter);
            conn.FillComboBoxBuildStatus(ref cbStatusFilter);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {            
            string employee = cbEmployeeFilter.Text;
            string customer = cbCustomerFilter.Text;
            string orderdate = cbOrderDateFilter.Text;
            string deliverydate = cbDeliveryDateFilter.Text;
            string status = cbStatusFilter.Text;
            dgvListBuilds.Rows.Clear();
            conn.FillDataGridViewListBuilds(ref dgvListBuilds, employee, customer, orderdate, deliverydate, status);
            Global.ResizeDGV(dgvListBuilds);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvListBuilds.Rows.Clear();
            conn.FillDataGridViewListBuilds(ref dgvListBuilds, "", "", "", "", "");            
            FillComboBoxes();
            Global.ResizeDGV(dgvListBuilds);
        }
    }
}
