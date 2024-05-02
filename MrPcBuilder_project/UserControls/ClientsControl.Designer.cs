namespace MrPcBuilder_project
{
    partial class ClientsControl
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
            this.panelClientsMenu = new System.Windows.Forms.Panel();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnListClients = new System.Windows.Forms.Button();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelClientsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClientsMenu
            // 
            this.panelClientsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelClientsMenu.Controls.Add(this.btnEditClient);
            this.panelClientsMenu.Controls.Add(this.btnListClients);
            this.panelClientsMenu.Controls.Add(this.btnAddNewClient);
            this.panelClientsMenu.Location = new System.Drawing.Point(12, 36);
            this.panelClientsMenu.Name = "panelClientsMenu";
            this.panelClientsMenu.Size = new System.Drawing.Size(195, 163);
            this.panelClientsMenu.TabIndex = 1;
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.Transparent;
            this.btnEditClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnEditClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.ForeColor = System.Drawing.Color.White;
            this.btnEditClient.Location = new System.Drawing.Point(17, 113);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(159, 32);
            this.btnEditClient.TabIndex = 2;
            this.btnEditClient.Text = "Edit Client";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnListClients
            // 
            this.btnListClients.BackColor = System.Drawing.Color.Transparent;
            this.btnListClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnListClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnListClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListClients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListClients.ForeColor = System.Drawing.Color.White;
            this.btnListClients.Location = new System.Drawing.Point(17, 65);
            this.btnListClients.Name = "btnListClients";
            this.btnListClients.Size = new System.Drawing.Size(159, 32);
            this.btnListClients.TabIndex = 1;
            this.btnListClients.Text = "List Clients";
            this.btnListClients.UseVisualStyleBackColor = false;
            this.btnListClients.Click += new System.EventHandler(this.btnListClients_Click);
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAddNewClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnAddNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewClient.ForeColor = System.Drawing.Color.White;
            this.btnAddNewClient.Location = new System.Drawing.Point(17, 17);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(159, 32);
            this.btnAddNewClient.TabIndex = 0;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.UseVisualStyleBackColor = false;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(213, 26);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(882, 652);
            this.panelMain.TabIndex = 2;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1098, 20);
            this.panelTitleBar.TabIndex = 0;
            // 
            // ClientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelClientsMenu);
            this.Name = "ClientsControl";
            this.Size = new System.Drawing.Size(1098, 681);
            this.panelClientsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClientsMenu;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnListClients;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTitleBar;
    }
}
