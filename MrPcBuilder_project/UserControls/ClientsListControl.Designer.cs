namespace MrPcBuilder_project
{
    partial class ClientsListControl
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
            this.panelListClients = new System.Windows.Forms.Panel();
            this.dgvListClients = new System.Windows.Forms.DataGridView();
            this.panelFilterClients = new System.Windows.Forms.Panel();
            this.cbCountryFilter = new System.Windows.Forms.ComboBox();
            this.lblCountryFilter = new System.Windows.Forms.Label();
            this.cbEmailFilter = new System.Windows.Forms.ComboBox();
            this.lblEmailFilter = new System.Windows.Forms.Label();
            this.cbZipCodeFilter = new System.Windows.Forms.ComboBox();
            this.lblZipCodeFilter = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbLastNameFilter = new System.Windows.Forms.ComboBox();
            this.lblLastNameFilter = new System.Windows.Forms.Label();
            this.cbNameFilter = new System.Windows.Forms.ComboBox();
            this.lblNameFilter = new System.Windows.Forms.Label();
            this.panelListClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClients)).BeginInit();
            this.panelFilterClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListClients
            // 
            this.panelListClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelListClients.Controls.Add(this.dgvListClients);
            this.panelListClients.Location = new System.Drawing.Point(17, 143);
            this.panelListClients.Name = "panelListClients";
            this.panelListClients.Size = new System.Drawing.Size(849, 494);
            this.panelListClients.TabIndex = 1;
            // 
            // dgvListClients
            // 
            this.dgvListClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgvListClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListClients.Location = new System.Drawing.Point(27, 19);
            this.dgvListClients.Name = "dgvListClients";
            this.dgvListClients.Size = new System.Drawing.Size(794, 454);
            this.dgvListClients.TabIndex = 0;
            // 
            // panelFilterClients
            // 
            this.panelFilterClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelFilterClients.Controls.Add(this.cbCountryFilter);
            this.panelFilterClients.Controls.Add(this.lblCountryFilter);
            this.panelFilterClients.Controls.Add(this.cbEmailFilter);
            this.panelFilterClients.Controls.Add(this.lblEmailFilter);
            this.panelFilterClients.Controls.Add(this.cbZipCodeFilter);
            this.panelFilterClients.Controls.Add(this.lblZipCodeFilter);
            this.panelFilterClients.Controls.Add(this.btnRefresh);
            this.panelFilterClients.Controls.Add(this.btnSearch);
            this.panelFilterClients.Controls.Add(this.cbLastNameFilter);
            this.panelFilterClients.Controls.Add(this.lblLastNameFilter);
            this.panelFilterClients.Controls.Add(this.cbNameFilter);
            this.panelFilterClients.Controls.Add(this.lblNameFilter);
            this.panelFilterClients.Location = new System.Drawing.Point(17, 16);
            this.panelFilterClients.Name = "panelFilterClients";
            this.panelFilterClients.Size = new System.Drawing.Size(849, 121);
            this.panelFilterClients.TabIndex = 0;
            // 
            // cbCountryFilter
            // 
            this.cbCountryFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCountryFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCountryFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCountryFilter.FormattingEnabled = true;
            this.cbCountryFilter.Location = new System.Drawing.Point(275, 78);
            this.cbCountryFilter.Name = "cbCountryFilter";
            this.cbCountryFilter.Size = new System.Drawing.Size(238, 21);
            this.cbCountryFilter.TabIndex = 7;
            // 
            // lblCountryFilter
            // 
            this.lblCountryFilter.AutoSize = true;
            this.lblCountryFilter.ForeColor = System.Drawing.Color.White;
            this.lblCountryFilter.Location = new System.Drawing.Point(280, 60);
            this.lblCountryFilter.Name = "lblCountryFilter";
            this.lblCountryFilter.Size = new System.Drawing.Size(43, 13);
            this.lblCountryFilter.TabIndex = 6;
            this.lblCountryFilter.Text = "Country";
            // 
            // cbEmailFilter
            // 
            this.cbEmailFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmailFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmailFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEmailFilter.FormattingEnabled = true;
            this.cbEmailFilter.Location = new System.Drawing.Point(534, 32);
            this.cbEmailFilter.Name = "cbEmailFilter";
            this.cbEmailFilter.Size = new System.Drawing.Size(238, 21);
            this.cbEmailFilter.TabIndex = 9;
            // 
            // lblEmailFilter
            // 
            this.lblEmailFilter.AutoSize = true;
            this.lblEmailFilter.ForeColor = System.Drawing.Color.White;
            this.lblEmailFilter.Location = new System.Drawing.Point(543, 14);
            this.lblEmailFilter.Name = "lblEmailFilter";
            this.lblEmailFilter.Size = new System.Drawing.Size(32, 13);
            this.lblEmailFilter.TabIndex = 8;
            this.lblEmailFilter.Text = "Email";
            // 
            // cbZipCodeFilter
            // 
            this.cbZipCodeFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbZipCodeFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbZipCodeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbZipCodeFilter.FormattingEnabled = true;
            this.cbZipCodeFilter.Location = new System.Drawing.Point(18, 78);
            this.cbZipCodeFilter.Name = "cbZipCodeFilter";
            this.cbZipCodeFilter.Size = new System.Drawing.Size(238, 21);
            this.cbZipCodeFilter.TabIndex = 3;
            // 
            // lblZipCodeFilter
            // 
            this.lblZipCodeFilter.AutoSize = true;
            this.lblZipCodeFilter.ForeColor = System.Drawing.Color.White;
            this.lblZipCodeFilter.Location = new System.Drawing.Point(23, 60);
            this.lblZipCodeFilter.Name = "lblZipCodeFilter";
            this.lblZipCodeFilter.Size = new System.Drawing.Size(50, 13);
            this.lblZipCodeFilter.TabIndex = 2;
            this.lblZipCodeFilter.Text = "Zip Code";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(688, 74);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(138, 27);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(534, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 27);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbLastNameFilter
            // 
            this.cbLastNameFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLastNameFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLastNameFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbLastNameFilter.FormattingEnabled = true;
            this.cbLastNameFilter.Location = new System.Drawing.Point(275, 32);
            this.cbLastNameFilter.Name = "cbLastNameFilter";
            this.cbLastNameFilter.Size = new System.Drawing.Size(238, 21);
            this.cbLastNameFilter.TabIndex = 5;
            // 
            // lblLastNameFilter
            // 
            this.lblLastNameFilter.AutoSize = true;
            this.lblLastNameFilter.ForeColor = System.Drawing.Color.White;
            this.lblLastNameFilter.Location = new System.Drawing.Point(284, 14);
            this.lblLastNameFilter.Name = "lblLastNameFilter";
            this.lblLastNameFilter.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameFilter.TabIndex = 4;
            this.lblLastNameFilter.Text = "Last Name";
            // 
            // cbNameFilter
            // 
            this.cbNameFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNameFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNameFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbNameFilter.FormattingEnabled = true;
            this.cbNameFilter.Location = new System.Drawing.Point(18, 32);
            this.cbNameFilter.Name = "cbNameFilter";
            this.cbNameFilter.Size = new System.Drawing.Size(238, 21);
            this.cbNameFilter.TabIndex = 1;
            // 
            // lblNameFilter
            // 
            this.lblNameFilter.AutoSize = true;
            this.lblNameFilter.ForeColor = System.Drawing.Color.White;
            this.lblNameFilter.Location = new System.Drawing.Point(23, 14);
            this.lblNameFilter.Name = "lblNameFilter";
            this.lblNameFilter.Size = new System.Drawing.Size(35, 13);
            this.lblNameFilter.TabIndex = 0;
            this.lblNameFilter.Text = "Name";
            // 
            // ClientsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelListClients);
            this.Controls.Add(this.panelFilterClients);
            this.Name = "ClientsListControl";
            this.Size = new System.Drawing.Size(882, 652);
            this.Load += new System.EventHandler(this.ClientsListControl_Load);
            this.panelListClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClients)).EndInit();
            this.panelFilterClients.ResumeLayout(false);
            this.panelFilterClients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelListClients;
        private System.Windows.Forms.DataGridView dgvListClients;
        private System.Windows.Forms.Panel panelFilterClients;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbLastNameFilter;
        private System.Windows.Forms.Label lblLastNameFilter;
        private System.Windows.Forms.ComboBox cbNameFilter;
        private System.Windows.Forms.Label lblNameFilter;
        private System.Windows.Forms.ComboBox cbEmailFilter;
        private System.Windows.Forms.Label lblEmailFilter;
        private System.Windows.Forms.ComboBox cbZipCodeFilter;
        private System.Windows.Forms.Label lblZipCodeFilter;
        private System.Windows.Forms.ComboBox cbCountryFilter;
        private System.Windows.Forms.Label lblCountryFilter;
    }
}
