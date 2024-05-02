namespace MrPcBuilder_project
{
    partial class ListComponentsControl
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbManufacturerComponent = new System.Windows.Forms.ComboBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.cbTypeComponent = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListComponents = new System.Windows.Forms.DataGridView();
            this.panelNewComponent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNewComponent
            // 
            this.panelNewComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelNewComponent.Controls.Add(this.btnRefresh);
            this.panelNewComponent.Controls.Add(this.btnSearch);
            this.panelNewComponent.Controls.Add(this.cbManufacturerComponent);
            this.panelNewComponent.Controls.Add(this.lblManufacturer);
            this.panelNewComponent.Controls.Add(this.cbTypeComponent);
            this.panelNewComponent.Controls.Add(this.lblType);
            this.panelNewComponent.Location = new System.Drawing.Point(16, 14);
            this.panelNewComponent.Name = "panelNewComponent";
            this.panelNewComponent.Size = new System.Drawing.Size(849, 79);
            this.panelNewComponent.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(688, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(138, 27);
            this.btnRefresh.TabIndex = 5;
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
            this.btnSearch.Location = new System.Drawing.Point(534, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbManufacturerComponent
            // 
            this.cbManufacturerComponent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbManufacturerComponent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbManufacturerComponent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbManufacturerComponent.FormattingEnabled = true;
            this.cbManufacturerComponent.Location = new System.Drawing.Point(275, 32);
            this.cbManufacturerComponent.Name = "cbManufacturerComponent";
            this.cbManufacturerComponent.Size = new System.Drawing.Size(238, 21);
            this.cbManufacturerComponent.TabIndex = 3;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.ForeColor = System.Drawing.Color.White;
            this.lblManufacturer.Location = new System.Drawing.Point(284, 14);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(64, 13);
            this.lblManufacturer.TabIndex = 2;
            this.lblManufacturer.Text = "Manufaturer";
            // 
            // cbTypeComponent
            // 
            this.cbTypeComponent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTypeComponent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTypeComponent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTypeComponent.FormattingEnabled = true;
            this.cbTypeComponent.Location = new System.Drawing.Point(18, 32);
            this.cbTypeComponent.Name = "cbTypeComponent";
            this.cbTypeComponent.Size = new System.Drawing.Size(238, 21);
            this.cbTypeComponent.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(23, 14);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.dgvListComponents);
            this.panel1.Location = new System.Drawing.Point(16, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 536);
            this.panel1.TabIndex = 1;
            // 
            // dgvListComponents
            // 
            this.dgvListComponents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgvListComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListComponents.Location = new System.Drawing.Point(27, 19);
            this.dgvListComponents.Name = "dgvListComponents";
            this.dgvListComponents.Size = new System.Drawing.Size(794, 499);
            this.dgvListComponents.TabIndex = 0;
            // 
            // ListComponentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNewComponent);
            this.Name = "ListComponentsControl";
            this.Size = new System.Drawing.Size(882, 652);
            this.Load += new System.EventHandler(this.ListComponentsControl_Load);
            this.panelNewComponent.ResumeLayout(false);
            this.panelNewComponent.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListComponents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewComponent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbManufacturerComponent;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.ComboBox cbTypeComponent;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListComponents;
        private System.Windows.Forms.Button btnRefresh;
    }
}
