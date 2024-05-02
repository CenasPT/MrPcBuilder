namespace MrPcBuilder_project
{
    partial class ClientEditControl
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
            this.panelEditClient1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.nudClientID = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEditClientTitle = new System.Windows.Forms.Label();
            this.panelEditClient2 = new System.Windows.Forms.Panel();
            this.txtZipCodeClient = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtCountryClient = new System.Windows.Forms.TextBox();
            this.lblCountryClient = new System.Windows.Forms.Label();
            this.txtTax_IDClient = new System.Windows.Forms.TextBox();
            this.txtStreetClient = new System.Windows.Forms.TextBox();
            this.lblLastNameClient = new System.Windows.Forms.Label();
            this.txtLastNameClient = new System.Windows.Forms.TextBox();
            this.btnRefreshClient = new System.Windows.Forms.Button();
            this.lblTax_IDClient = new System.Windows.Forms.Label();
            this.lblEmailClient = new System.Windows.Forms.Label();
            this.txtEmailClient = new System.Windows.Forms.TextBox();
            this.lblContactClient = new System.Windows.Forms.Label();
            this.txtContactClient = new System.Windows.Forms.TextBox();
            this.lblNameClient = new System.Windows.Forms.Label();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblGeneralInfoClient = new System.Windows.Forms.Label();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.panelEditClient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClientID)).BeginInit();
            this.panelEditClient2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEditClient1
            // 
            this.panelEditClient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelEditClient1.Controls.Add(this.btnSearch);
            this.panelEditClient1.Controls.Add(this.nudClientID);
            this.panelEditClient1.Controls.Add(this.lblID);
            this.panelEditClient1.Controls.Add(this.lblEditClientTitle);
            this.panelEditClient1.Location = new System.Drawing.Point(251, 33);
            this.panelEditClient1.Name = "panelEditClient1";
            this.panelEditClient1.Size = new System.Drawing.Size(363, 113);
            this.panelEditClient1.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(179, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 27);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // nudClientID
            // 
            this.nudClientID.Location = new System.Drawing.Point(43, 65);
            this.nudClientID.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudClientID.Name = "nudClientID";
            this.nudClientID.Size = new System.Drawing.Size(120, 20);
            this.nudClientID.TabIndex = 45;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(47, 45);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 13);
            this.lblID.TabIndex = 44;
            this.lblID.Text = "Client ID";
            // 
            // lblEditClientTitle
            // 
            this.lblEditClientTitle.AutoSize = true;
            this.lblEditClientTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClientTitle.ForeColor = System.Drawing.Color.White;
            this.lblEditClientTitle.Location = new System.Drawing.Point(112, 15);
            this.lblEditClientTitle.Name = "lblEditClientTitle";
            this.lblEditClientTitle.Size = new System.Drawing.Size(124, 20);
            this.lblEditClientTitle.TabIndex = 30;
            this.lblEditClientTitle.Text = "Choose Client ID";
            // 
            // panelEditClient2
            // 
            this.panelEditClient2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelEditClient2.Controls.Add(this.btnCancelEdit);
            this.panelEditClient2.Controls.Add(this.txtZipCodeClient);
            this.panelEditClient2.Controls.Add(this.lblZipCode);
            this.panelEditClient2.Controls.Add(this.txtCountryClient);
            this.panelEditClient2.Controls.Add(this.lblCountryClient);
            this.panelEditClient2.Controls.Add(this.txtTax_IDClient);
            this.panelEditClient2.Controls.Add(this.txtStreetClient);
            this.panelEditClient2.Controls.Add(this.lblLastNameClient);
            this.panelEditClient2.Controls.Add(this.txtLastNameClient);
            this.panelEditClient2.Controls.Add(this.btnRefreshClient);
            this.panelEditClient2.Controls.Add(this.lblTax_IDClient);
            this.panelEditClient2.Controls.Add(this.lblEmailClient);
            this.panelEditClient2.Controls.Add(this.txtEmailClient);
            this.panelEditClient2.Controls.Add(this.lblContactClient);
            this.panelEditClient2.Controls.Add(this.txtContactClient);
            this.panelEditClient2.Controls.Add(this.lblNameClient);
            this.panelEditClient2.Controls.Add(this.btnSaveClient);
            this.panelEditClient2.Controls.Add(this.txtNameClient);
            this.panelEditClient2.Controls.Add(this.lblStreet);
            this.panelEditClient2.Controls.Add(this.lblGeneralInfoClient);
            this.panelEditClient2.Location = new System.Drawing.Point(85, 152);
            this.panelEditClient2.Name = "panelEditClient2";
            this.panelEditClient2.Size = new System.Drawing.Size(696, 313);
            this.panelEditClient2.TabIndex = 18;
            // 
            // txtZipCodeClient
            // 
            this.txtZipCodeClient.Location = new System.Drawing.Point(358, 162);
            this.txtZipCodeClient.MaxLength = 20;
            this.txtZipCodeClient.Name = "txtZipCodeClient";
            this.txtZipCodeClient.Size = new System.Drawing.Size(306, 20);
            this.txtZipCodeClient.TabIndex = 23;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.ForeColor = System.Drawing.Color.White;
            this.lblZipCode.Location = new System.Drawing.Point(362, 144);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(103, 13);
            this.lblZipCode.TabIndex = 22;
            this.lblZipCode.Text = "Address ( Zip Code )";
            // 
            // txtCountryClient
            // 
            this.txtCountryClient.Location = new System.Drawing.Point(358, 205);
            this.txtCountryClient.MaxLength = 30;
            this.txtCountryClient.Name = "txtCountryClient";
            this.txtCountryClient.Size = new System.Drawing.Size(306, 20);
            this.txtCountryClient.TabIndex = 21;
            // 
            // lblCountryClient
            // 
            this.lblCountryClient.AutoSize = true;
            this.lblCountryClient.ForeColor = System.Drawing.Color.White;
            this.lblCountryClient.Location = new System.Drawing.Point(362, 187);
            this.lblCountryClient.Name = "lblCountryClient";
            this.lblCountryClient.Size = new System.Drawing.Size(96, 13);
            this.lblCountryClient.TabIndex = 20;
            this.lblCountryClient.Text = "Address ( Country )";
            // 
            // txtTax_IDClient
            // 
            this.txtTax_IDClient.Location = new System.Drawing.Point(358, 74);
            this.txtTax_IDClient.MaxLength = 15;
            this.txtTax_IDClient.Name = "txtTax_IDClient";
            this.txtTax_IDClient.Size = new System.Drawing.Size(306, 20);
            this.txtTax_IDClient.TabIndex = 12;
            this.txtTax_IDClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_IDClient_KeyPress);
            // 
            // txtStreetClient
            // 
            this.txtStreetClient.Location = new System.Drawing.Point(358, 118);
            this.txtStreetClient.MaxLength = 100;
            this.txtStreetClient.Name = "txtStreetClient";
            this.txtStreetClient.Size = new System.Drawing.Size(306, 20);
            this.txtStreetClient.TabIndex = 6;
            // 
            // lblLastNameClient
            // 
            this.lblLastNameClient.AutoSize = true;
            this.lblLastNameClient.ForeColor = System.Drawing.Color.White;
            this.lblLastNameClient.Location = new System.Drawing.Point(32, 100);
            this.lblLastNameClient.Name = "lblLastNameClient";
            this.lblLastNameClient.Size = new System.Drawing.Size(65, 13);
            this.lblLastNameClient.TabIndex = 3;
            this.lblLastNameClient.Text = "Last Name *";
            // 
            // txtLastNameClient
            // 
            this.txtLastNameClient.Location = new System.Drawing.Point(28, 118);
            this.txtLastNameClient.MaxLength = 20;
            this.txtLastNameClient.Name = "txtLastNameClient";
            this.txtLastNameClient.Size = new System.Drawing.Size(306, 20);
            this.txtLastNameClient.TabIndex = 4;
            // 
            // btnRefreshClient
            // 
            this.btnRefreshClient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefreshClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRefreshClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefreshClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshClient.ForeColor = System.Drawing.Color.White;
            this.btnRefreshClient.Location = new System.Drawing.Point(194, 256);
            this.btnRefreshClient.Name = "btnRefreshClient";
            this.btnRefreshClient.Size = new System.Drawing.Size(138, 27);
            this.btnRefreshClient.TabIndex = 19;
            this.btnRefreshClient.Text = "Refresh";
            this.btnRefreshClient.UseVisualStyleBackColor = true;
            this.btnRefreshClient.Click += new System.EventHandler(this.btnRefreshClient_Click);
            // 
            // lblTax_IDClient
            // 
            this.lblTax_IDClient.AutoSize = true;
            this.lblTax_IDClient.ForeColor = System.Drawing.Color.White;
            this.lblTax_IDClient.Location = new System.Drawing.Point(362, 55);
            this.lblTax_IDClient.Name = "lblTax_IDClient";
            this.lblTax_IDClient.Size = new System.Drawing.Size(42, 13);
            this.lblTax_IDClient.TabIndex = 11;
            this.lblTax_IDClient.Text = "Tax_ID";
            // 
            // lblEmailClient
            // 
            this.lblEmailClient.AutoSize = true;
            this.lblEmailClient.ForeColor = System.Drawing.Color.White;
            this.lblEmailClient.Location = new System.Drawing.Point(32, 144);
            this.lblEmailClient.Name = "lblEmailClient";
            this.lblEmailClient.Size = new System.Drawing.Size(39, 13);
            this.lblEmailClient.TabIndex = 9;
            this.lblEmailClient.Text = "Email *";
            // 
            // txtEmailClient
            // 
            this.txtEmailClient.Location = new System.Drawing.Point(28, 162);
            this.txtEmailClient.MaxLength = 255;
            this.txtEmailClient.Name = "txtEmailClient";
            this.txtEmailClient.Size = new System.Drawing.Size(306, 20);
            this.txtEmailClient.TabIndex = 10;
            // 
            // lblContactClient
            // 
            this.lblContactClient.AutoSize = true;
            this.lblContactClient.ForeColor = System.Drawing.Color.White;
            this.lblContactClient.Location = new System.Drawing.Point(32, 187);
            this.lblContactClient.Name = "lblContactClient";
            this.lblContactClient.Size = new System.Drawing.Size(44, 13);
            this.lblContactClient.TabIndex = 7;
            this.lblContactClient.Text = "Contact";
            // 
            // txtContactClient
            // 
            this.txtContactClient.Location = new System.Drawing.Point(28, 205);
            this.txtContactClient.MaxLength = 15;
            this.txtContactClient.Name = "txtContactClient";
            this.txtContactClient.Size = new System.Drawing.Size(306, 20);
            this.txtContactClient.TabIndex = 8;
            this.txtContactClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactClient_KeyPress);
            // 
            // lblNameClient
            // 
            this.lblNameClient.AutoSize = true;
            this.lblNameClient.ForeColor = System.Drawing.Color.White;
            this.lblNameClient.Location = new System.Drawing.Point(32, 56);
            this.lblNameClient.Name = "lblNameClient";
            this.lblNameClient.Size = new System.Drawing.Size(42, 13);
            this.lblNameClient.TabIndex = 1;
            this.lblNameClient.Text = "Name *";
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSaveClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClient.ForeColor = System.Drawing.Color.White;
            this.btnSaveClient.Location = new System.Drawing.Point(30, 256);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(138, 27);
            this.btnSaveClient.TabIndex = 18;
            this.btnSaveClient.Text = "Save";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // txtNameClient
            // 
            this.txtNameClient.Location = new System.Drawing.Point(28, 74);
            this.txtNameClient.MaxLength = 20;
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(306, 20);
            this.txtNameClient.TabIndex = 2;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.ForeColor = System.Drawing.Color.White;
            this.lblStreet.Location = new System.Drawing.Point(362, 100);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(86, 13);
            this.lblStreet.TabIndex = 5;
            this.lblStreet.Text = "Address ( street )";
            // 
            // lblGeneralInfoClient
            // 
            this.lblGeneralInfoClient.AutoSize = true;
            this.lblGeneralInfoClient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralInfoClient.ForeColor = System.Drawing.Color.White;
            this.lblGeneralInfoClient.Location = new System.Drawing.Point(24, 20);
            this.lblGeneralInfoClient.Name = "lblGeneralInfoClient";
            this.lblGeneralInfoClient.Size = new System.Drawing.Size(152, 20);
            this.lblGeneralInfoClient.TabIndex = 0;
            this.lblGeneralInfoClient.Text = "General Information";
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCancelEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Location = new System.Drawing.Point(358, 256);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(138, 27);
            this.btnCancelEdit.TabIndex = 24;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // ClientEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEditClient2);
            this.Controls.Add(this.panelEditClient1);
            this.Name = "ClientEditControl";
            this.Size = new System.Drawing.Size(882, 652);
            this.Load += new System.EventHandler(this.ClientEditControl_Load);
            this.panelEditClient1.ResumeLayout(false);
            this.panelEditClient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClientID)).EndInit();
            this.panelEditClient2.ResumeLayout(false);
            this.panelEditClient2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEditClient1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown nudClientID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEditClientTitle;
        private System.Windows.Forms.Panel panelEditClient2;
        private System.Windows.Forms.TextBox txtZipCodeClient;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtCountryClient;
        private System.Windows.Forms.Label lblCountryClient;
        private System.Windows.Forms.TextBox txtTax_IDClient;
        private System.Windows.Forms.TextBox txtStreetClient;
        private System.Windows.Forms.Label lblLastNameClient;
        private System.Windows.Forms.TextBox txtLastNameClient;
        private System.Windows.Forms.Label lblTax_IDClient;
        private System.Windows.Forms.Label lblEmailClient;
        private System.Windows.Forms.TextBox txtEmailClient;
        private System.Windows.Forms.Label lblContactClient;
        private System.Windows.Forms.TextBox txtContactClient;
        private System.Windows.Forms.Label lblNameClient;
        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblGeneralInfoClient;
        private System.Windows.Forms.Button btnRefreshClient;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}
