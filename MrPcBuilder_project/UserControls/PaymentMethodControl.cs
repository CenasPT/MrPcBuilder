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
    public partial class PaymentMethodControl : UserControl
    {
        DBConnect conn = new DBConnect();
        public PaymentMethodControl()
        {
            InitializeComponent();
        }

        private void PaymentMethodControl_Load(object sender, EventArgs e)
        {
            conn.FillComboBoxPaymentMethod(ref cbSearchEditPM);
            conn.FillComboBoxPaymentMethod(ref cbSearchDeletePM);
            Global.DeactivateEditing(panelEditPM2);
            txtNewPMName.Focus();
        }

        // ADD NEW PM
        private void btnAddNewPM_Click(object sender, EventArgs e)
        {
            if(txtNewPMName.Text.Length < 2)
            {
                MessageBox.Show("Error in Name field!");
                txtNewPMName.Focus();
            }
            else
            {
                if (conn.InsertNewPaymentMethod(txtNewPMName.Text))
                {
                    MessageBox.Show("Successfully Added New Payment Method");
                    btnClearNewPM_Click(sender, e);
                    cbSearchEditPM.Items.Clear();
                    cbSearchEditPM.Text = string.Empty;
                    cbSearchDeletePM.Items.Clear();
                    cbSearchDeletePM.Text = string.Empty;
                    conn.FillComboBoxPaymentMethod(ref cbSearchEditPM);
                    conn.FillComboBoxPaymentMethod(ref cbSearchDeletePM);
                    txtNewPMName.Focus();
                }
                else
                {
                    MessageBox.Show("Error Inserting New Payment Method!");
                    txtNewPMName.Focus();
                }                
            }
        }

        private void btnClearNewPM_Click(object sender, EventArgs e)
        {
            txtNewPMName.Text = string.Empty;
            txtNewPMName.Focus();
        }

        // EDIT PM
        private void btnEditPM_Click(object sender, EventArgs e)
        {
            if (cbSearchEditPM.SelectedIndex != -1)
            {
                Global.DeactivateEditing(panelEditPM1);
                Global.DeactivateEditing(panelNewPM);
                Global.DeactivateEditing(panelDeletePM);
                Global.ActivateEditing(panelEditPM2);
            }
            else
            {
                MessageBox.Show("No Option Selected!");
                cbSearchDeletePM.Focus();
            }
        }

        private void btnUpdatePM_Click(object sender, EventArgs e)
        {
            if (txtEditPMName.Text.Length < 2)
            {
                MessageBox.Show("Error in Name field!");
                txtEditPMName.Focus();
            }
            else
            {
                string old_name = cbSearchEditPM.Text;
                string new_name = txtEditPMName.Text;

                if (conn.UpdatePaymentMethod(old_name, new_name))
                {
                    MessageBox.Show("Successfully Updated Payment Method");
                    btnRefreshEditPM_Click(sender, e);
                    txtEditPMName.Focus();
                }
                else
                {
                    MessageBox.Show("Error Updating Payment Method!");
                    txtEditPMName.Focus();
                }
            }            
        }

        private void btnRefreshEditPM_Click(object sender, EventArgs e)
        {
            cbSearchEditPM.Items.Clear();
            cbSearchEditPM.Text = string.Empty;
            cbSearchDeletePM.Items.Clear();
            cbSearchDeletePM.Text = string.Empty;
            conn.FillComboBoxPaymentMethod(ref cbSearchEditPM);
            conn.FillComboBoxPaymentMethod(ref cbSearchDeletePM);
            txtEditPMName.Text = string.Empty;            
            Global.DeactivateEditing(panelEditPM2);
            Global.ActivateEditing(panelEditPM1);
            Global.ActivateEditing(panelNewPM);
            Global.ActivateEditing(panelDeletePM);
            cbSearchEditPM.Focus();
        }

        private void btnDeletePM_Click(object sender, EventArgs e)
        {
            if (cbSearchDeletePM.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("About to Delete '" + cbSearchDeletePM.Text + "' !\nAre you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (conn.DeletePaymentMethod(cbSearchDeletePM.Text))
                    {
                        MessageBox.Show("Successfully Deleted!");
                        btnRefreshDeletePM_Click(sender, e);
                        cbSearchDeletePM.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete!");
                        cbSearchDeletePM.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("No Option Selected!");
                cbSearchDeletePM.Focus();
            }
        }

        private void btnRefreshDeletePM_Click(object sender, EventArgs e)
        {
            cbSearchEditPM.Items.Clear();
            cbSearchEditPM.Text = string.Empty;
            cbSearchDeletePM.Items.Clear();
            cbSearchDeletePM.Text = string.Empty;
            conn.FillComboBoxPaymentMethod(ref cbSearchEditPM);
            conn.FillComboBoxPaymentMethod(ref cbSearchDeletePM);            
            cbSearchDeletePM.Focus();
        }
    }
}
