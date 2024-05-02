namespace MrPcBuilder_project
{
    partial class NewEmployeeAccControl
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
            this.panelNewComponent = new System.Windows.Forms.Panel();
            this.cbRoleEmployee = new System.Windows.Forms.ComboBox();
            this.btnGenerateLoginEmployee = new System.Windows.Forms.Button();
            this.txtTax_IDEmployee = new System.Windows.Forms.TextBox();
            this.lblRoleEmployee = new System.Windows.Forms.Label();
            this.txtPassEmployee = new System.Windows.Forms.TextBox();
            this.lblPassEmployee = new System.Windows.Forms.Label();
            this.lblUsernameEmployee = new System.Windows.Forms.Label();
            this.txtUsernameEmployee = new System.Windows.Forms.TextBox();
            this.lblLoginInfoClient = new System.Windows.Forms.Label();
            this.btnRefreshEmployeeInfo = new System.Windows.Forms.Button();
            this.lblTax_IDEmployee = new System.Windows.Forms.Label();
            this.lblEmailEmployee = new System.Windows.Forms.Label();
            this.txtEmailEmployee = new System.Windows.Forms.TextBox();
            this.lblNameEmployee = new System.Windows.Forms.Label();
            this.btnSaveEmployeeAcc = new System.Windows.Forms.Button();
            this.txtNameEmployee = new System.Windows.Forms.TextBox();
            this.lblGeneralInfoEmployee = new System.Windows.Forms.Label();
            this.panelNewComponent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNewComponent
            // 
            this.panelNewComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelNewComponent.Controls.Add(this.cbRoleEmployee);
            this.panelNewComponent.Controls.Add(this.btnGenerateLoginEmployee);
            this.panelNewComponent.Controls.Add(this.txtTax_IDEmployee);
            this.panelNewComponent.Controls.Add(this.lblRoleEmployee);
            this.panelNewComponent.Controls.Add(this.txtPassEmployee);
            this.panelNewComponent.Controls.Add(this.lblPassEmployee);
            this.panelNewComponent.Controls.Add(this.lblUsernameEmployee);
            this.panelNewComponent.Controls.Add(this.txtUsernameEmployee);
            this.panelNewComponent.Controls.Add(this.lblLoginInfoClient);
            this.panelNewComponent.Controls.Add(this.btnRefreshEmployeeInfo);
            this.panelNewComponent.Controls.Add(this.lblTax_IDEmployee);
            this.panelNewComponent.Controls.Add(this.lblEmailEmployee);
            this.panelNewComponent.Controls.Add(this.txtEmailEmployee);
            this.panelNewComponent.Controls.Add(this.lblNameEmployee);
            this.panelNewComponent.Controls.Add(this.btnSaveEmployeeAcc);
            this.panelNewComponent.Controls.Add(this.txtNameEmployee);
            this.panelNewComponent.Controls.Add(this.lblGeneralInfoEmployee);
            this.panelNewComponent.Location = new System.Drawing.Point(21, 25);
            this.panelNewComponent.Name = "panelNewComponent";
            this.panelNewComponent.Size = new System.Drawing.Size(696, 319);
            this.panelNewComponent.TabIndex = 0;
            // 
            // cbRoleEmployee
            // 
            this.cbRoleEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRoleEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRoleEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRoleEmployee.FormattingEnabled = true;
            this.cbRoleEmployee.Location = new System.Drawing.Point(358, 118);
            this.cbRoleEmployee.Name = "cbRoleEmployee";
            this.cbRoleEmployee.Size = new System.Drawing.Size(306, 21);
            this.cbRoleEmployee.TabIndex = 8;
            // 
            // btnGenerateLoginEmployee
            // 
            this.btnGenerateLoginEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerateLoginEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnGenerateLoginEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenerateLoginEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateLoginEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateLoginEmployee.ForeColor = System.Drawing.Color.White;
            this.btnGenerateLoginEmployee.Location = new System.Drawing.Point(179, 166);
            this.btnGenerateLoginEmployee.Name = "btnGenerateLoginEmployee";
            this.btnGenerateLoginEmployee.Size = new System.Drawing.Size(138, 27);
            this.btnGenerateLoginEmployee.TabIndex = 10;
            this.btnGenerateLoginEmployee.Text = "Generate";
            this.btnGenerateLoginEmployee.UseVisualStyleBackColor = true;
            this.btnGenerateLoginEmployee.Click += new System.EventHandler(this.btnGenerateLoginEmployee_Click);
            // 
            // txtTax_IDEmployee
            // 
            this.txtTax_IDEmployee.Location = new System.Drawing.Point(358, 74);
            this.txtTax_IDEmployee.MaxLength = 15;
            this.txtTax_IDEmployee.Name = "txtTax_IDEmployee";
            this.txtTax_IDEmployee.Size = new System.Drawing.Size(306, 20);
            this.txtTax_IDEmployee.TabIndex = 6;
            this.txtTax_IDEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_IDEmployee_KeyPress);
            // 
            // lblRoleEmployee
            // 
            this.lblRoleEmployee.AutoSize = true;
            this.lblRoleEmployee.ForeColor = System.Drawing.Color.White;
            this.lblRoleEmployee.Location = new System.Drawing.Point(362, 100);
            this.lblRoleEmployee.Name = "lblRoleEmployee";
            this.lblRoleEmployee.Size = new System.Drawing.Size(36, 13);
            this.lblRoleEmployee.TabIndex = 7;
            this.lblRoleEmployee.Text = "Role *";
            // 
            // txtPassEmployee
            // 
            this.txtPassEmployee.Location = new System.Drawing.Point(28, 261);
            this.txtPassEmployee.MaxLength = 128;
            this.txtPassEmployee.Name = "txtPassEmployee";
            this.txtPassEmployee.Size = new System.Drawing.Size(306, 20);
            this.txtPassEmployee.TabIndex = 14;
            // 
            // lblPassEmployee
            // 
            this.lblPassEmployee.AutoSize = true;
            this.lblPassEmployee.ForeColor = System.Drawing.Color.White;
            this.lblPassEmployee.Location = new System.Drawing.Point(32, 243);
            this.lblPassEmployee.Name = "lblPassEmployee";
            this.lblPassEmployee.Size = new System.Drawing.Size(60, 13);
            this.lblPassEmployee.TabIndex = 13;
            this.lblPassEmployee.Text = "Password *";
            // 
            // lblUsernameEmployee
            // 
            this.lblUsernameEmployee.AutoSize = true;
            this.lblUsernameEmployee.ForeColor = System.Drawing.Color.White;
            this.lblUsernameEmployee.Location = new System.Drawing.Point(32, 200);
            this.lblUsernameEmployee.Name = "lblUsernameEmployee";
            this.lblUsernameEmployee.Size = new System.Drawing.Size(62, 13);
            this.lblUsernameEmployee.TabIndex = 11;
            this.lblUsernameEmployee.Text = "Username *";
            // 
            // txtUsernameEmployee
            // 
            this.txtUsernameEmployee.Location = new System.Drawing.Point(28, 218);
            this.txtUsernameEmployee.MaxLength = 15;
            this.txtUsernameEmployee.Name = "txtUsernameEmployee";
            this.txtUsernameEmployee.Size = new System.Drawing.Size(306, 20);
            this.txtUsernameEmployee.TabIndex = 12;
            // 
            // lblLoginInfoClient
            // 
            this.lblLoginInfoClient.AutoSize = true;
            this.lblLoginInfoClient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInfoClient.ForeColor = System.Drawing.Color.White;
            this.lblLoginInfoClient.Location = new System.Drawing.Point(24, 168);
            this.lblLoginInfoClient.Name = "lblLoginInfoClient";
            this.lblLoginInfoClient.Size = new System.Drawing.Size(137, 20);
            this.lblLoginInfoClient.TabIndex = 9;
            this.lblLoginInfoClient.Text = "Login Information";
            // 
            // btnRefreshEmployeeInfo
            // 
            this.btnRefreshEmployeeInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefreshEmployeeInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRefreshEmployeeInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefreshEmployeeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshEmployeeInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshEmployeeInfo.ForeColor = System.Drawing.Color.White;
            this.btnRefreshEmployeeInfo.Location = new System.Drawing.Point(526, 236);
            this.btnRefreshEmployeeInfo.Name = "btnRefreshEmployeeInfo";
            this.btnRefreshEmployeeInfo.Size = new System.Drawing.Size(138, 27);
            this.btnRefreshEmployeeInfo.TabIndex = 16;
            this.btnRefreshEmployeeInfo.Text = "Refresh / Clear";
            this.btnRefreshEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnRefreshEmployeeInfo.Click += new System.EventHandler(this.btnRefreshEmployeeInfo_Click);
            // 
            // lblTax_IDEmployee
            // 
            this.lblTax_IDEmployee.AutoSize = true;
            this.lblTax_IDEmployee.ForeColor = System.Drawing.Color.White;
            this.lblTax_IDEmployee.Location = new System.Drawing.Point(362, 55);
            this.lblTax_IDEmployee.Name = "lblTax_IDEmployee";
            this.lblTax_IDEmployee.Size = new System.Drawing.Size(49, 13);
            this.lblTax_IDEmployee.TabIndex = 5;
            this.lblTax_IDEmployee.Text = "Tax_ID *";
            // 
            // lblEmailEmployee
            // 
            this.lblEmailEmployee.AutoSize = true;
            this.lblEmailEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEmailEmployee.Location = new System.Drawing.Point(32, 100);
            this.lblEmailEmployee.Name = "lblEmailEmployee";
            this.lblEmailEmployee.Size = new System.Drawing.Size(39, 13);
            this.lblEmailEmployee.TabIndex = 3;
            this.lblEmailEmployee.Text = "Email *";
            // 
            // txtEmailEmployee
            // 
            this.txtEmailEmployee.Location = new System.Drawing.Point(28, 118);
            this.txtEmailEmployee.MaxLength = 255;
            this.txtEmailEmployee.Name = "txtEmailEmployee";
            this.txtEmailEmployee.Size = new System.Drawing.Size(306, 20);
            this.txtEmailEmployee.TabIndex = 4;
            // 
            // lblNameEmployee
            // 
            this.lblNameEmployee.AutoSize = true;
            this.lblNameEmployee.ForeColor = System.Drawing.Color.White;
            this.lblNameEmployee.Location = new System.Drawing.Point(32, 56);
            this.lblNameEmployee.Name = "lblNameEmployee";
            this.lblNameEmployee.Size = new System.Drawing.Size(42, 13);
            this.lblNameEmployee.TabIndex = 1;
            this.lblNameEmployee.Text = "Name *";
            // 
            // btnSaveEmployeeAcc
            // 
            this.btnSaveEmployeeAcc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveEmployeeAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSaveEmployeeAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveEmployeeAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEmployeeAcc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmployeeAcc.ForeColor = System.Drawing.Color.White;
            this.btnSaveEmployeeAcc.Location = new System.Drawing.Point(362, 236);
            this.btnSaveEmployeeAcc.Name = "btnSaveEmployeeAcc";
            this.btnSaveEmployeeAcc.Size = new System.Drawing.Size(138, 27);
            this.btnSaveEmployeeAcc.TabIndex = 15;
            this.btnSaveEmployeeAcc.Text = "Save";
            this.btnSaveEmployeeAcc.UseVisualStyleBackColor = true;
            this.btnSaveEmployeeAcc.Click += new System.EventHandler(this.btnSaveEmployeeAcc_Click);
            // 
            // txtNameEmployee
            // 
            this.txtNameEmployee.Location = new System.Drawing.Point(28, 74);
            this.txtNameEmployee.MaxLength = 20;
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.Size = new System.Drawing.Size(306, 20);
            this.txtNameEmployee.TabIndex = 2;
            // 
            // lblGeneralInfoEmployee
            // 
            this.lblGeneralInfoEmployee.AutoSize = true;
            this.lblGeneralInfoEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralInfoEmployee.ForeColor = System.Drawing.Color.White;
            this.lblGeneralInfoEmployee.Location = new System.Drawing.Point(24, 20);
            this.lblGeneralInfoEmployee.Name = "lblGeneralInfoEmployee";
            this.lblGeneralInfoEmployee.Size = new System.Drawing.Size(152, 20);
            this.lblGeneralInfoEmployee.TabIndex = 0;
            this.lblGeneralInfoEmployee.Text = "General Information";
            // 
            // NewEmployeeAccControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNewComponent);
            this.Name = "NewEmployeeAccControl";
            this.Size = new System.Drawing.Size(882, 652);
            this.Load += new System.EventHandler(this.EditEmployeeAccControl_Load);
            this.panelNewComponent.ResumeLayout(false);
            this.panelNewComponent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewComponent;
        private System.Windows.Forms.TextBox txtTax_IDEmployee;
        private System.Windows.Forms.Label lblRoleEmployee;
        private System.Windows.Forms.TextBox txtPassEmployee;
        private System.Windows.Forms.Label lblPassEmployee;
        private System.Windows.Forms.Label lblUsernameEmployee;
        private System.Windows.Forms.TextBox txtUsernameEmployee;
        private System.Windows.Forms.Label lblLoginInfoClient;
        private System.Windows.Forms.Button btnRefreshEmployeeInfo;
        private System.Windows.Forms.Label lblTax_IDEmployee;
        private System.Windows.Forms.Label lblEmailEmployee;
        private System.Windows.Forms.TextBox txtEmailEmployee;
        private System.Windows.Forms.Label lblNameEmployee;
        private System.Windows.Forms.Button btnSaveEmployeeAcc;
        private System.Windows.Forms.TextBox txtNameEmployee;
        private System.Windows.Forms.Label lblGeneralInfoEmployee;
        private System.Windows.Forms.Button btnGenerateLoginEmployee;
        private System.Windows.Forms.ComboBox cbRoleEmployee;
    }
}
