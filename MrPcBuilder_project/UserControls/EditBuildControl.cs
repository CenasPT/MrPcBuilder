using Microsoft.Win32.SafeHandles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MrPcBuilder_project
{
    public partial class EditBuildControl : UserControl
    {
        DBConnect conn = new DBConnect();
        public EditBuildControl()
        {
            InitializeComponent();
        }

        private void EditBuildControl_Load(object sender, EventArgs e)
        {
            RefreshComboBoxes();
            Reset();
            AlwaysDisabled();
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

        // REFRESH COMBOBOXES
        private void RefreshComboBoxes()
        {
            cbTypeComponent.Items.Clear();
            cbCustomers.Items.Clear();
            cbEmployees.Items.Clear();
            cbPaymentMethod.Items.Clear();

            cbTypeComponent.Text = string.Empty;
            cbCustomers.Text = string.Empty;
            cbEmployees.Text = string.Empty;
            cbPaymentMethod.Text = string.Empty;

            conn.FillComboBoxComponentType(ref cbTypeComponent);
            conn.FillComboBoxCustomerName(ref cbCustomers);
            conn.FillComboBoxEmployeeName(ref cbEmployees);
            conn.FillComboBoxPaymentMethod(ref cbPaymentMethod);            
        }

        // RESET EVERYTHING
        private void Reset()
        {
            Global.DeactivateEditing(panelNewBuild);
            listViewBuild.Items.Clear();
            cbStatus.Text = string.Empty;
            txtTotalQuantity.Text = "0";
            txtTotalPrice.Text = "0";

            lblTypeComponent.Enabled = false;
            lblNameComponent.Enabled = false;
            lblManufacturerComponent.Enabled = false;
            lblModelComponent.Enabled = false;
            lblQuantityComponent.Enabled = false;
            lblPriceComponent.Enabled = false;
            cbTypeComponent.Enabled = false;
            cbNameComponent.Enabled = false;
            nudQuantity.Enabled = false;
            btnAddComponent.Enabled = false;
            btnRefreshAddComponent.Enabled = false;
            btnDeleteComponent.Enabled = false;            
            
            nudBuildID.Focus();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string customer = "", employee = "", order_date = "", delivery_date = "", total_quantity = "", total_price = "", payment_method = "", status = "";

            if (conn.SearchBuild(nudBuildID.Value.ToString(), ref employee, ref customer, ref order_date, ref delivery_date, ref total_quantity, ref total_price, ref payment_method, ref status))
            {
                if (conn.FillEditBuildListView(ref listViewBuild,(int)nudBuildID.Value))
                {
                    cbEmployees.Text = employee;
                    cbCustomers.Text = customer;
                    dtpOrderDate.Text = order_date;
                    dtpDeliveryDate.Text = delivery_date;
                    txtTotalQuantity.Text = total_quantity;
                    txtTotalPrice.Text = total_price;
                    cbPaymentMethod.Text = payment_method;
                    cbStatus.Text = status;

                    Global.ActivateEditing(panelNewBuild);

                    lblTypeComponent.Enabled = true;
                    cbTypeComponent.Enabled = true;
                    nudBuildID.Enabled = false;
                }
                
            }
            else
            {
                MessageBox.Show("Build Not Found!");                
                nudBuildID.Focus();
            }                        
        }

        // EDIT BUILD * ADD COMPONENT
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
                btnAddComponent.Enabled = false;
                btnRefreshAddComponent.Enabled = false;
                string type = cbTypeComponent.SelectedItem.ToString();
                conn.FillComboBoxComponentName(ref cbNameComponent, type);
                cbNameComponent.Enabled = true;
                cbNameComponent.Focus();
            }
        }

        private void cbNameComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbNameComponent.SelectedItem.ToString();
            conn.FillComboBoxComponentDetails(name, ref txtManufaturerComponent, ref txtModelComponent, ref txtPriceComponent);
            lblManufacturerComponent.Enabled = true;
            lblModelComponent.Enabled = true;
            lblQuantityComponent.Enabled = true;
            lblPriceComponent.Enabled = true;
            nudQuantity.Value = 1;
            nudQuantity.Enabled = true;
            btnAddComponent.Enabled = true;
            btnRefreshAddComponent.Enabled = true;
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
            btnAddComponent.Enabled = false;
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

        // EDIT BUILD * SAVE BUILD
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
                int orderID = (int)nudBuildID.Value;
                string employee = cbEmployees.Text;
                string customer = cbCustomers.Text;
                int totalquantity = int.Parse(txtTotalQuantity.Text);
                decimal totalprice = decimal.Parse(txtTotalPrice.Text);
                DateTime orderdate = dtpOrderDate.Value;
                string formatOrderDate = orderdate.ToString("yyyy-MM-dd");
                DateTime deliverydate = dtpDeliveryDate.Value;
                string formatDeliveryDate = deliverydate.ToString("yyyy-MM-dd");
                string paymentmethod = cbPaymentMethod.Text;
                string status = cbStatus.Text;

                if (conn.UpdateBuildOrder(orderID, employee, customer, totalquantity, totalprice, formatOrderDate, formatDeliveryDate, status, paymentmethod, listViewBuild))
                {
                    MessageBox.Show("Successfully Updated Build!");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Error While Updating Build!");
                    cbCustomers.Focus();
                }
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

        private void btnDeleteComponent_Click(object sender, EventArgs e)
        {
            if (listViewBuild.CheckedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Delete Component From the List?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (listViewBuild.Items.Count == 1)
                    {
                        MessageBox.Show("Build needs at least 1 component!");
                    }
                    else
                    {
                        ListViewItem item = listViewBuild.CheckedItems[0];
                        listViewBuild.Items.Remove(listViewBuild.CheckedItems[0]);
                        listViewBuild.Refresh();
                        CalculateTotalPriceQuantity();
                        btnDeleteComponent.Enabled = false;
                        cbTypeComponent.Focus();
                    }                                       
                }
            }
        }

        private void btnRefreshBuild_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All Modifications will revert back to the original!\nAre You Sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cbCustomers.Items.Clear();
                cbEmployees.Items.Clear();
                cbPaymentMethod.Items.Clear();
                conn.FillComboBoxEmployeeName(ref cbEmployees);
                conn.FillComboBoxCustomerName(ref cbCustomers);
                conn.FillComboBoxPaymentMethod(ref cbPaymentMethod);
                btnSearch_Click(sender, e);
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All Modifications Will Be Lost!\nAre You Sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Reset();
            }
        }
    }
}
