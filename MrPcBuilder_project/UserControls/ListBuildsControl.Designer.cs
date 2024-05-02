namespace MrPcBuilder_project
{
    partial class ListBuildsControl
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
            this.panelListBuild2 = new System.Windows.Forms.Panel();
            this.dgvListBuilds = new System.Windows.Forms.DataGridView();
            this.panelListBuild1 = new System.Windows.Forms.Panel();
            this.cbStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.cbDeliveryDateFilter = new System.Windows.Forms.ComboBox();
            this.lblDeliveryDateFilter = new System.Windows.Forms.Label();
            this.cbOrderDateFilter = new System.Windows.Forms.ComboBox();
            this.lblOrderDateFilter = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbCustomerFilter = new System.Windows.Forms.ComboBox();
            this.lblCustomerFilter = new System.Windows.Forms.Label();
            this.cbEmployeeFilter = new System.Windows.Forms.ComboBox();
            this.lblEmployeeFilter = new System.Windows.Forms.Label();
            this.panelListBuild2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBuilds)).BeginInit();
            this.panelListBuild1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListBuild2
            // 
            this.panelListBuild2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelListBuild2.Controls.Add(this.dgvListBuilds);
            this.panelListBuild2.Location = new System.Drawing.Point(17, 143);
            this.panelListBuild2.Name = "panelListBuild2";
            this.panelListBuild2.Size = new System.Drawing.Size(849, 494);
            this.panelListBuild2.TabIndex = 1;
            // 
            // dgvListBuilds
            // 
            this.dgvListBuilds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgvListBuilds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBuilds.Location = new System.Drawing.Point(27, 19);
            this.dgvListBuilds.Name = "dgvListBuilds";
            this.dgvListBuilds.Size = new System.Drawing.Size(794, 454);
            this.dgvListBuilds.TabIndex = 0;
            // 
            // panelListBuild1
            // 
            this.panelListBuild1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelListBuild1.Controls.Add(this.cbStatusFilter);
            this.panelListBuild1.Controls.Add(this.lblStatusFilter);
            this.panelListBuild1.Controls.Add(this.cbDeliveryDateFilter);
            this.panelListBuild1.Controls.Add(this.lblDeliveryDateFilter);
            this.panelListBuild1.Controls.Add(this.cbOrderDateFilter);
            this.panelListBuild1.Controls.Add(this.lblOrderDateFilter);
            this.panelListBuild1.Controls.Add(this.btnRefresh);
            this.panelListBuild1.Controls.Add(this.btnSearch);
            this.panelListBuild1.Controls.Add(this.cbCustomerFilter);
            this.panelListBuild1.Controls.Add(this.lblCustomerFilter);
            this.panelListBuild1.Controls.Add(this.cbEmployeeFilter);
            this.panelListBuild1.Controls.Add(this.lblEmployeeFilter);
            this.panelListBuild1.Location = new System.Drawing.Point(17, 16);
            this.panelListBuild1.Name = "panelListBuild1";
            this.panelListBuild1.Size = new System.Drawing.Size(849, 121);
            this.panelListBuild1.TabIndex = 0;
            // 
            // cbStatusFilter
            // 
            this.cbStatusFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStatusFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStatusFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbStatusFilter.FormattingEnabled = true;
            this.cbStatusFilter.Location = new System.Drawing.Point(533, 32);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.Size = new System.Drawing.Size(238, 21);
            this.cbStatusFilter.TabIndex = 5;
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.ForeColor = System.Drawing.Color.White;
            this.lblStatusFilter.Location = new System.Drawing.Point(541, 14);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(37, 13);
            this.lblStatusFilter.TabIndex = 4;
            this.lblStatusFilter.Text = "Status";
            // 
            // cbDeliveryDateFilter
            // 
            this.cbDeliveryDateFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDeliveryDateFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDeliveryDateFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDeliveryDateFilter.FormattingEnabled = true;
            this.cbDeliveryDateFilter.Location = new System.Drawing.Point(275, 78);
            this.cbDeliveryDateFilter.Name = "cbDeliveryDateFilter";
            this.cbDeliveryDateFilter.Size = new System.Drawing.Size(238, 21);
            this.cbDeliveryDateFilter.TabIndex = 9;
            // 
            // lblDeliveryDateFilter
            // 
            this.lblDeliveryDateFilter.AutoSize = true;
            this.lblDeliveryDateFilter.ForeColor = System.Drawing.Color.White;
            this.lblDeliveryDateFilter.Location = new System.Drawing.Point(280, 60);
            this.lblDeliveryDateFilter.Name = "lblDeliveryDateFilter";
            this.lblDeliveryDateFilter.Size = new System.Drawing.Size(71, 13);
            this.lblDeliveryDateFilter.TabIndex = 8;
            this.lblDeliveryDateFilter.Text = "Delivery Date";
            // 
            // cbOrderDateFilter
            // 
            this.cbOrderDateFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOrderDateFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOrderDateFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbOrderDateFilter.FormattingEnabled = true;
            this.cbOrderDateFilter.Location = new System.Drawing.Point(18, 78);
            this.cbOrderDateFilter.Name = "cbOrderDateFilter";
            this.cbOrderDateFilter.Size = new System.Drawing.Size(238, 21);
            this.cbOrderDateFilter.TabIndex = 7;
            // 
            // lblOrderDateFilter
            // 
            this.lblOrderDateFilter.AutoSize = true;
            this.lblOrderDateFilter.ForeColor = System.Drawing.Color.White;
            this.lblOrderDateFilter.Location = new System.Drawing.Point(23, 60);
            this.lblOrderDateFilter.Name = "lblOrderDateFilter";
            this.lblOrderDateFilter.Size = new System.Drawing.Size(59, 13);
            this.lblOrderDateFilter.TabIndex = 6;
            this.lblOrderDateFilter.Text = "Order Date";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(687, 74);
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
            this.btnSearch.Location = new System.Drawing.Point(533, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 27);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbCustomerFilter
            // 
            this.cbCustomerFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCustomerFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCustomerFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCustomerFilter.FormattingEnabled = true;
            this.cbCustomerFilter.Location = new System.Drawing.Point(275, 32);
            this.cbCustomerFilter.Name = "cbCustomerFilter";
            this.cbCustomerFilter.Size = new System.Drawing.Size(238, 21);
            this.cbCustomerFilter.TabIndex = 3;
            // 
            // lblCustomerFilter
            // 
            this.lblCustomerFilter.AutoSize = true;
            this.lblCustomerFilter.ForeColor = System.Drawing.Color.White;
            this.lblCustomerFilter.Location = new System.Drawing.Point(284, 14);
            this.lblCustomerFilter.Name = "lblCustomerFilter";
            this.lblCustomerFilter.Size = new System.Drawing.Size(51, 13);
            this.lblCustomerFilter.TabIndex = 2;
            this.lblCustomerFilter.Text = "Customer";
            // 
            // cbEmployeeFilter
            // 
            this.cbEmployeeFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmployeeFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmployeeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEmployeeFilter.FormattingEnabled = true;
            this.cbEmployeeFilter.Location = new System.Drawing.Point(18, 32);
            this.cbEmployeeFilter.Name = "cbEmployeeFilter";
            this.cbEmployeeFilter.Size = new System.Drawing.Size(238, 21);
            this.cbEmployeeFilter.TabIndex = 1;
            // 
            // lblEmployeeFilter
            // 
            this.lblEmployeeFilter.AutoSize = true;
            this.lblEmployeeFilter.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeFilter.Location = new System.Drawing.Point(23, 14);
            this.lblEmployeeFilter.Name = "lblEmployeeFilter";
            this.lblEmployeeFilter.Size = new System.Drawing.Size(53, 13);
            this.lblEmployeeFilter.TabIndex = 0;
            this.lblEmployeeFilter.Text = "Employee";
            // 
            // ListBuildsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelListBuild2);
            this.Controls.Add(this.panelListBuild1);
            this.Name = "ListBuildsControl";
            this.Size = new System.Drawing.Size(882, 652);
            this.Load += new System.EventHandler(this.BuildPendingControl_Load);
            this.panelListBuild2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBuilds)).EndInit();
            this.panelListBuild1.ResumeLayout(false);
            this.panelListBuild1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelListBuild2;
        private System.Windows.Forms.DataGridView dgvListBuilds;
        private System.Windows.Forms.Panel panelListBuild1;
        private System.Windows.Forms.ComboBox cbDeliveryDateFilter;
        private System.Windows.Forms.Label lblDeliveryDateFilter;
        private System.Windows.Forms.ComboBox cbOrderDateFilter;
        private System.Windows.Forms.Label lblOrderDateFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbCustomerFilter;
        private System.Windows.Forms.Label lblCustomerFilter;
        private System.Windows.Forms.ComboBox cbEmployeeFilter;
        private System.Windows.Forms.Label lblEmployeeFilter;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cbStatusFilter;
    }
}
