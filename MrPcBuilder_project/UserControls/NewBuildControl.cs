using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MrPcBuilder_project
{
    public partial class NewBuildControl : UserControl
    {
        DBConnect conn = new DBConnect();
        public NewBuildControl()
        {
            InitializeComponent();
        }        

        private void NewBuildControl_Load(object sender, EventArgs e)
        {
            Reset();
            AlwaysDisabled();

            lblNameComponent.Enabled = false;
            lblManufacturerComponent.Enabled = false;
            lblModelComponent.Enabled = false;
            lblQuantityComponent.Enabled = false;
            lblPriceComponent.Enabled = false;
            cbNameComponent.Enabled = false;
            nudQuantity.Enabled = false;
            btnAddComponent.Enabled = false;
            btnRefreshAddComponent.Enabled = false;
            btnDeleteComponent.Enabled = false;
        }

        // ALWAYS DISABLED TEXTBOXES AND MORE
        private void AlwaysDisabled()
        {
            txtManufaturerComponent.Enabled = false;
            txtModelComponent.Enabled = false;
            txtPriceComponent.Enabled = false;
            txtTotalQuantity.Enabled = false;
            txtTotalPrice.Enabled = false;
            dtpOrderDate.Value = DateTime.Today;
            dtpDeliveryDate.Value = dtpOrderDate.Value.AddDays(5);
            dtpOrderDate.Enabled = false;            
        }

        // RESET EVERYTHING
        private void Reset()
        {
            Global.DeactivateEditing(panelNewBuild);
            listViewBuild.Items.Clear();
            cbTypeComponent.Items.Clear();
            cbCustomers.Items.Clear();            
            cbEmployees.Items.Clear();
            cbPaymentMethod.Items.Clear();
            cbTypeComponent.Text = string.Empty;
            cbCustomers.Text = string.Empty;
            cbEmployees.Text = string.Empty;
            cbPaymentMethod.Text = string.Empty;
            txtTotalQuantity.Text = "0";
            txtTotalPrice.Text = "0";

            conn.FillComboBoxComponentType(ref cbTypeComponent);
            conn.FillComboBoxCustomerName(ref cbCustomers);
            conn.FillComboBoxEmployeeName(ref cbEmployees);            
            conn.FillComboBoxPaymentMethod(ref cbPaymentMethod);

            cbTypeComponent.Focus();
        }

        // CALCULATE BUILD TOTAL PRICE AND QUANTITY
        private void CalculateTotalPriceQuantity()
        {
            decimal totalprice = 0;
            int totalquantity = 0;

            foreach (ListViewItem item in listViewBuild.Items)
            {
                decimal price = decimal.Parse(item.SubItems[4].Text);
                int quantity = int.Parse(item.SubItems[5].Text);

                totalprice += price * quantity;
                totalquantity += quantity;
            }

            txtTotalPrice.Text = totalprice.ToString();
            txtTotalQuantity.Text = totalquantity.ToString();
        }

        // NEW BUILD * ADD COMPONENT        
        private void cbTypeComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeComponent.SelectedIndex != -1)
            {
                lblNameComponent.Enabled = true;
                cbNameComponent.Items.Clear();
                cbNameComponent.Text = string.Empty;
                txtManufaturerComponent.Clear();
                txtModelComponent.Clear();
                txtPriceComponent.Clear();
                btnAddComponent.Enabled=false;
                btnRefreshAddComponent.Enabled=false;
                string component_type = cbTypeComponent.SelectedItem.ToString();
                conn.FillComboBoxComponentName(ref cbNameComponent, component_type);
                cbNameComponent.Enabled = true;
                cbNameComponent.Focus();
            }
        }
        private void cbNameComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string component_name = cbNameComponent.SelectedItem.ToString();
            conn.FillComboBoxComponentDetails(component_name, ref txtManufaturerComponent, ref txtModelComponent, ref txtPriceComponent);
            lblManufacturerComponent.Enabled = true;
            lblModelComponent.Enabled = true;
            lblQuantityComponent.Enabled = true;
            lblPriceComponent.Enabled = true;
            nudQuantity.Value = 1;
            nudQuantity.Enabled = true;
            btnAddComponent.Enabled= true;
            btnRefreshAddComponent.Enabled= true;
        }
        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            bool componentExists = false;
            foreach (ListViewItem item in listViewBuild.Items)
            {
                if (item.SubItems[1].Text == cbNameComponent.Text &&
                    item.SubItems[2].Text == txtManufaturerComponent.Text &&
                    item.SubItems[3].Text == txtModelComponent.Text)
                {
                    item.SubItems[5].Text = (int.Parse(item.SubItems[5].Text) + (int)nudQuantity.Value).ToString();
                    componentExists = true;
                    break;
                }
            }

            if (!componentExists)
            {
                ListViewItem item = new ListViewItem(cbTypeComponent.Text);
                item.SubItems.Add(cbNameComponent.Text);
                item.SubItems.Add(txtManufaturerComponent.Text);
                item.SubItems.Add(txtModelComponent.Text);
                item.SubItems.Add(txtPriceComponent.Text);
                item.SubItems.Add(nudQuantity.Value.ToString());
                listViewBuild.Items.Add(item);
            }

            Global.ResizeListViewColumns(listViewBuild);
            CalculateTotalPriceQuantity();
            Global.ActivateEditing(panelNewBuild);           
            btnRefreshAddComponent_Click(sender, e);
        }

        private void btnRefreshAddComponent_Click(object sender, EventArgs e)
        {
            txtManufaturerComponent.Clear();
            txtModelComponent.Clear();
            txtPriceComponent.Clear();
            btnAddComponent.Enabled=false;
            btnRefreshAddComponent.Enabled = false;
            cbNameComponent.Enabled = false;
            cbNameComponent.Text = string.Empty;
            nudQuantity.Value = 0;
            nudQuantity.Enabled = false;
            cbTypeComponent.Items.Clear();
            cbTypeComponent.Text = string.Empty;
            conn.FillComboBoxComponentType(ref cbTypeComponent);
            cbTypeComponent.Focus();
        }

        // NEW BUILD * SAVE BUILD
        private bool CheckNewBuildFields()
        {
            if (listViewBuild.Items.Count == 0)
            {
                MessageBox.Show("No Component Was Added to the Build!");
                cbTypeComponent.Focus();
                return false;
            }
            if (cbCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Select the Customer that is Making the Order!");
                cbCustomers.Focus();
                return false;
            }
            if (dtpDeliveryDate.Value <= dtpOrderDate.Value)
            {
                MessageBox.Show("Select a Delivery Date!");
                dtpDeliveryDate.Focus();
                return false;
            }
            if (cbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Select the Payment Method!");
                cbCustomers.Focus();
                return false;
            }
            return true;
        }

        private void btnSaveBuild_Click(object sender, EventArgs e)
        {
            if (CheckNewBuildFields())
            {
                string employee = cbEmployees.Text;
                string customer = cbCustomers.Text;
                int totalquantity = int.Parse(txtTotalQuantity.Text);
                decimal totalprice = decimal.Parse(txtTotalPrice.Text);
                DateTime orderdate = dtpOrderDate.Value;
                string formatOrderDate = orderdate.ToString("yyyy-MM-dd");
                DateTime deliverydate = dtpDeliveryDate.Value;
                string formatDeliveryDate = deliverydate.ToString("yyyy-MM-dd");
                string paymentmethod = cbPaymentMethod.Text;

                if(conn.InsertNewBuildOrder(employee, customer, totalquantity, totalprice, formatOrderDate, formatDeliveryDate, paymentmethod, listViewBuild))
                {
                    MessageBox.Show("Successfully Created Build!");
                    Reset();
                    cbTypeComponent.Focus();
                }
                else
                {
                    MessageBox.Show("Error While Creating Build!");
                    cbCustomers.Focus();
                }
            }
        }
        
        private void btnDeleteComponent_Click(object sender, EventArgs e)
        {
            if (listViewBuild.CheckedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Delete Component From the List?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ListViewItem item = listViewBuild.CheckedItems[0];
                    listViewBuild.Items.Remove(listViewBuild.CheckedItems[0]);
                    listViewBuild.Refresh();
                    CalculateTotalPriceQuantity();
                    btnDeleteComponent.Enabled = false;
                    cbTypeComponent.Focus();

                    if (listViewBuild.Items.Count == 0)
                    {
                        Global.DeactivateEditing(panelNewBuild);
                    }
                }                
            }
        }

        private void btnRefreshBuild_Click(object sender, EventArgs e)
        {
            cbCustomers.Items.Clear();
            cbEmployees.Items.Clear();
            cbPaymentMethod.Items.Clear();
            cbCustomers.Text = string.Empty;
            cbEmployees.Text = string.Empty;
            cbPaymentMethod.Text = string.Empty;
            conn.FillComboBoxEmployeeName(ref cbEmployees);
            conn.FillComboBoxCustomerName(ref cbCustomers);
            conn.FillComboBoxPaymentMethod(ref cbPaymentMethod);            
        }

        private void btnCancelBuild_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This Will Erase All Components From The List.\nAre You Sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Reset();
            }
        }

        private void listViewBuild_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            foreach (ListViewItem item in listViewBuild.Items)
            {
                if (item.Index != e.Index)
                {
                    item.Checked = false;
                }
            }
        }

        private void listViewBuild_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            bool anyChecked = false;
            foreach (ListViewItem item in listViewBuild.Items)
            {
                if (item.Checked)
                {
                    anyChecked = true;
                    break;
                }
            }
            btnDeleteComponent.Enabled = anyChecked;
        }
    }
}
