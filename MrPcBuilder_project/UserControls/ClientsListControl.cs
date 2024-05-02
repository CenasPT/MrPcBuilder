using System;
using System.Windows.Forms;

namespace MrPcBuilder_project
{
    public partial class ClientsListControl : UserControl
    {
        DBConnect conn = new DBConnect();
        public ClientsListControl()
        {
            InitializeComponent();
        }

        private void ClientsListControl_Load(object sender, EventArgs e)
        {
            dgvListClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListClients.AllowUserToAddRows = false;
            dgvListClients.AllowUserToDeleteRows = false;
            dgvListClients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvListClients.Columns.Add("id", "ID");
            dgvListClients.Columns.Add("name", "Name");
            dgvListClients.Columns.Add("last name", "Last Name");
            dgvListClients.Columns.Add("email", "Email");
            dgvListClients.Columns.Add("contact", "Contact");
            dgvListClients.Columns.Add("tax_id", "Tax_ID");
            dgvListClients.Columns.Add("address", "Address");
            conn.FillComboBoxFilterClient(ref cbNameFilter, ref cbLastNameFilter, ref cbEmailFilter, ref cbZipCodeFilter, ref cbCountryFilter);
            conn.FillDataGridViewListClients(ref dgvListClients, "", "", "", "", "");
            Global.ResizeDGV(dgvListClients);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = cbNameFilter.Text;
            string lastName = cbLastNameFilter.Text;
            string email = cbEmailFilter.Text;
            string zipCode = cbZipCodeFilter.Text;
            string country = cbCountryFilter.Text;
            dgvListClients.Rows.Clear();
            conn.FillDataGridViewListClients(ref dgvListClients, name, lastName, email, zipCode, country);
            Global.ResizeDGV(dgvListClients);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvListClients.Rows.Clear();
            conn.FillDataGridViewListClients(ref dgvListClients, "", "", "", "", "");
            Global.ResizeDGV(dgvListClients);
            cbNameFilter.Text = string.Empty;
            cbLastNameFilter.Text = string.Empty;
            cbEmailFilter.Text = string.Empty;
            cbZipCodeFilter.Text = string.Empty;
            cbCountryFilter.Text = string.Empty;
            cbNameFilter.Items.Clear();
            cbLastNameFilter.Items.Clear();
            cbEmailFilter.Items.Clear();
            cbZipCodeFilter.Items.Clear();
            cbCountryFilter.Items.Clear();
            conn.FillComboBoxFilterClient(ref cbNameFilter, ref cbLastNameFilter, ref cbEmailFilter, ref cbZipCodeFilter, ref cbCountryFilter);
        }
    }
}
