﻿namespace MrPcBuilder_project
{
    partial class EditEmployeeControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelEditEmployee2 = new System.Windows.Forms.Panel();
            this.txtEditTax_IDEmployee = new System.Windows.Forms.TextBox();
            this.lblEditRoleEmployee = new System.Windows.Forms.Label();
            this.lblEditTax_IDEmployee = new System.Windows.Forms.Label();
            this.lblEditEmailEmployee = new System.Windows.Forms.Label();
            this.txtEditEmailEmployee = new System.Windows.Forms.TextBox();
            this.lblEditNameEmployee = new System.Windows.Forms.Label();
            this.txtEditNameEmployee = new System.Windows.Forms.TextBox();
            this.btnRefreshEditEmployee = new System.Windows.Forms.Button();
            this.btnSaveEditEmployee = new System.Windows.Forms.Button();
            this.panelEditEmployee1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.nudEmployeeID = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEditEmployeeTitle = new System.Windows.Forms.Label();
            this.cbEditRoleEmployee = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelEditEmployee2.SuspendLayout();
            this.panelEditEmployee1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmployeeID)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEditEmployee2
            // 
            this.panelEditEmployee2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelEditEmployee2.Controls.Add(this.btnCancel);
            this.panelEditEmployee2.Controls.Add(this.cbEditRoleEmployee);
            this.panelEditEmployee2.Controls.Add(this.txtEditTax_IDEmployee);
            this.panelEditEmployee2.Controls.Add(this.lblEditRoleEmployee);
            this.panelEditEmployee2.Controls.Add(this.lblEditTax_IDEmployee);
            this.panelEditEmployee2.Controls.Add(this.lblEditEmailEmployee);
            this.panelEditEmployee2.Controls.Add(this.txtEditEmailEmployee);
            this.panelEditEmployee2.Controls.Add(this.lblEditNameEmployee);
            this.panelEditEmployee2.Controls.Add(this.txtEditNameEmployee);
            this.panelEditEmployee2.Controls.Add(this.btnRefreshEditEmployee);
            this.panelEditEmployee2.Controls.Add(this.btnSaveEditEmployee);
            this.panelEditEmployee2.Location = new System.Drawing.Point(65, 156);
            this.panelEditEmployee2.Name = "panelEditEmployee2";
            this.panelEditEmployee2.Size = new System.Drawing.Size(696, 151);
            this.panelEditEmployee2.TabIndex = 1;
            // 
            // txtEditTax_IDEmployee
            // 
            this.txtEditTax_IDEmployee.Location = new System.Drawing.Point(356, 29);
            this.txtEditTax_IDEmployee.MaxLength = 15;
            this.txtEditTax_IDEmployee.Name = "txtEditTax_IDEmployee";
            this.txtEditTax_IDEmployee.Size = new System.Drawing.Size(306, 20);
            this.txtEditTax_IDEmployee.TabIndex = 5;
            this.txtEditTax_IDEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditTax_IDEmployee_KeyPress);
            // 
            // lblEditRoleEmployee
            // 
            this.lblEditRoleEmployee.AutoSize = true;
            this.lblEditRoleEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEditRoleEmployee.Location = new System.Drawing.Point(360, 55);
            this.lblEditRoleEmployee.Name = "lblEditRoleEmployee";
            this.lblEditRoleEmployee.Size = new System.Drawing.Size(36, 13);
            this.lblEditRoleEmployee.TabIndex = 6;
            this.lblEditRoleEmployee.Text = "Role *";
            // 
            // lblEditTax_IDEmployee
            // 
            this.lblEditTax_IDEmployee.AutoSize = true;
            this.lblEditTax_IDEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEditTax_IDEmployee.Location = new System.Drawing.Point(360, 10);
            this.lblEditTax_IDEmployee.Name = "lblEditTax_IDEmployee";
            this.lblEditTax_IDEmployee.Size = new System.Drawing.Size(49, 13);
            this.lblEditTax_IDEmployee.TabIndex = 4;
            this.lblEditTax_IDEmployee.Text = "Tax_ID *";
            // 
            // lblEditEmailEmployee
            // 
            this.lblEditEmailEmployee.AutoSize = true;
            this.lblEditEmailEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEditEmailEmployee.Location = new System.Drawing.Point(30, 55);
            this.lblEditEmailEmployee.Name = "lblEditEmailEmployee";
            this.lblEditEmailEmployee.Size = new System.Drawing.Size(39, 13);
            this.lblEditEmailEmployee.TabIndex = 2;
            this.lblEditEmailEmployee.Text = "Email *";
            // 
            // txtEditEmailEmployee
            // 
            this.txtEditEmailEmployee.Location = new System.Drawing.Point(26, 73);
            this.txtEditEmailEmployee.MaxLength = 255;
            this.txtEditEmailEmployee.Name = "txtEditEmailEmployee";
            this.txtEditEmailEmployee.Size = new System.Drawing.Size(306, 20);
            this.txtEditEmailEmployee.TabIndex = 3;
            // 
            // lblEditNameEmployee
            // 
            this.lblEditNameEmployee.AutoSize = true;
            this.lblEditNameEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEditNameEmployee.Location = new System.Drawing.Point(30, 11);
            this.lblEditNameEmployee.Name = "lblEditNameEmployee";
            this.lblEditNameEmployee.Size = new System.Drawing.Size(42, 13);
            this.lblEditNameEmployee.TabIndex = 0;
            this.lblEditNameEmployee.Text = "Name *";
            // 
            // txtEditNameEmployee
            // 
            this.txtEditNameEmployee.Location = new System.Drawing.Point(26, 29);
            this.txtEditNameEmployee.MaxLength = 20;
            this.txtEditNameEmployee.Name = "txtEditNameEmployee";
            this.txtEditNameEmployee.Size = new System.Drawing.Size(306, 20);
            this.txtEditNameEmployee.TabIndex = 1;
            // 
            // btnRefreshEditEmployee
            // 
            this.btnRefreshEditEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefreshEditEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRefreshEditEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefreshEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshEditEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshEditEmployee.ForeColor = System.Drawing.Color.White;
            this.btnRefreshEditEmployee.Location = new System.Drawing.Point(192, 109);
            this.btnRefreshEditEmployee.Name = "btnRefreshEditEmployee";
            this.btnRefreshEditEmployee.Size = new System.Drawing.Size(138, 27);
            this.btnRefreshEditEmployee.TabIndex = 9;
            this.btnRefreshEditEmployee.Text = "Refresh";
            this.btnRefreshEditEmployee.UseVisualStyleBackColor = true;
            this.btnRefreshEditEmployee.Click += new System.EventHandler(this.btnRefreshEditEmployee_Click_1);
            // 
            // btnSaveEditEmployee
            // 
            this.btnSaveEditEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveEditEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSaveEditEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEditEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSaveEditEmployee.Location = new System.Drawing.Point(28, 109);
            this.btnSaveEditEmployee.Name = "btnSaveEditEmployee";
            this.btnSaveEditEmployee.Size = new System.Drawing.Size(138, 27);
            this.btnSaveEditEmployee.TabIndex = 8;
            this.btnSaveEditEmployee.Text = "Save";
            this.btnSaveEditEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEditEmployee.Click += new System.EventHandler(this.btnSaveEditEmployee_Click_1);
            // 
            // panelEditEmployee1
            // 
            this.panelEditEmployee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelEditEmployee1.Controls.Add(this.btnSearch);
            this.panelEditEmployee1.Controls.Add(this.nudEmployeeID);
            this.panelEditEmployee1.Controls.Add(this.lblID);
            this.panelEditEmployee1.Controls.Add(this.lblEditEmployeeTitle);
            this.panelEditEmployee1.Location = new System.Drawing.Point(231, 65);
            this.panelEditEmployee1.Name = "panelEditEmployee1";
            this.panelEditEmployee1.Size = new System.Drawing.Size(363, 90);
            this.panelEditEmployee1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(178, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // nudEmployeeID
            // 
            this.nudEmployeeID.Location = new System.Drawing.Point(42, 53);
            this.nudEmployeeID.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudEmployeeID.Name = "nudEmployeeID";
            this.nudEmployeeID.Size = new System.Drawing.Size(120, 20);
            this.nudEmployeeID.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(46, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Client ID";
            // 
            // lblEditEmployeeTitle
            // 
            this.lblEditEmployeeTitle.AutoSize = true;
            this.lblEditEmployeeTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEmployeeTitle.ForeColor = System.Drawing.Color.White;
            this.lblEditEmployeeTitle.Location = new System.Drawing.Point(111, 11);
            this.lblEditEmployeeTitle.Name = "lblEditEmployeeTitle";
            this.lblEditEmployeeTitle.Size = new System.Drawing.Size(137, 20);
            this.lblEditEmployeeTitle.TabIndex = 0;
            this.lblEditEmployeeTitle.Text = "Edit Employee Acc";
            // 
            // cbEditRoleEmployee
            // 
            this.cbEditRoleEmployee.FormattingEnabled = true;
            this.cbEditRoleEmployee.Location = new System.Drawing.Point(356, 72);
            this.cbEditRoleEmployee.Name = "cbEditRoleEmployee";
            this.cbEditRoleEmployee.Size = new System.Drawing.Size(306, 21);
            this.cbEditRoleEmployee.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(356, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 27);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditEmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEditEmployee2);
            this.Controls.Add(this.panelEditEmployee1);
            this.Name = "EditEmployeeControl";
            this.Size = new System.Drawing.Size(882, 652);
            this.Load += new System.EventHandler(this.EditEmployeeControl_Load);
            this.panelEditEmployee2.ResumeLayout(false);
            this.panelEditEmployee2.PerformLayout();
            this.panelEditEmployee1.ResumeLayout(false);
            this.panelEditEmployee1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmployeeID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEditEmployee2;
        private System.Windows.Forms.TextBox txtEditTax_IDEmployee;
        private System.Windows.Forms.Label lblEditRoleEmployee;
        private System.Windows.Forms.Label lblEditTax_IDEmployee;
        private System.Windows.Forms.Label lblEditEmailEmployee;
        private System.Windows.Forms.TextBox txtEditEmailEmployee;
        private System.Windows.Forms.Label lblEditNameEmployee;
        private System.Windows.Forms.TextBox txtEditNameEmployee;
        private System.Windows.Forms.Button btnRefreshEditEmployee;
        private System.Windows.Forms.Button btnSaveEditEmployee;
        private System.Windows.Forms.Panel panelEditEmployee1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown nudEmployeeID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEditEmployeeTitle;
        private System.Windows.Forms.ComboBox cbEditRoleEmployee;
        private System.Windows.Forms.Button btnCancel;
    }
}