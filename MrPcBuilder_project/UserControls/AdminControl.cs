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
    public partial class AdminControl : UserControl
    {               
        NewEmployeeAccControl newEmployeeAccControl = new NewEmployeeAccControl();
        ListEmployeesAccControl listEmployeesAccControl = new ListEmployeesAccControl();
        EditEmployeeControl editEmployeeControl = new EditEmployeeControl();
        PaymentMethodControl paymentMethodControl = new PaymentMethodControl();
        CompanyRolesControl companyRolesControl = new CompanyRolesControl();

        public AdminControl()
        {
            InitializeComponent();
                        
            panelMain.Controls.Add(newEmployeeAccControl);
            panelMain.Controls.Add(listEmployeesAccControl);
            panelMain.Controls.Add(editEmployeeControl);
            panelMain.Controls.Add(paymentMethodControl);
            panelMain.Controls.Add(companyRolesControl);

            newEmployeeAccControl.Dock = DockStyle.Fill;
            listEmployeesAccControl.Dock = DockStyle.Fill;
            editEmployeeControl.Dock = DockStyle.Fill;
            paymentMethodControl.Dock = DockStyle.Fill;
            companyRolesControl.Dock = DockStyle.Fill;
        }

        private void btnPaymentMethod_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            paymentMethodControl.Visible = true;
        }

        private void btnNewEmployeeAcc_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            newEmployeeAccControl.Visible = true;
        }

        private void btnListEmployeeAcc_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            listEmployeesAccControl.Visible = true;
        }

        private void btnEditEmployeeAcc_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            editEmployeeControl.Visible = true;
        }

        private void btnCompanyPositions_Click(object sender, EventArgs e)
        {
            Global.HideAllUserControls(panelMain);
            companyRolesControl.Visible = true;
        }
    }
}
