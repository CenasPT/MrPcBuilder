namespace MrPcBuilder_project
{
    partial class ListEmployeesAccControl
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
            this.panelListEmployees = new System.Windows.Forms.Panel();
            this.dgvListEmployees = new System.Windows.Forms.DataGridView();
            this.panelFilterEmployees = new System.Windows.Forms.Panel();
            this.cbPositionFilter = new System.Windows.Forms.ComboBox();
            this.cbNameFilter = new System.Windows.Forms.ComboBox();
            this.lblPositionEmployee = new System.Windows.Forms.Label();
            this.lblNameEmployee = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelListEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).BeginInit();
            this.panelFilterEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListEmployees
            // 
            this.panelListEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelListEmployees.Controls.Add(this.dgvListEmployees);
            this.panelListEmployees.Location = new System.Drawing.Point(17, 143);
            this.panelListEmployees.Name = "panelListEmployees";
            this.panelListEmployees.Size = new System.Drawing.Size(849, 494);
            this.panelListEmployees.TabIndex = 1;
            // 
            // dgvListEmployees
            // 
            this.dgvListEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgvListEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListEmployees.Location = new System.Drawing.Point(27, 19);
            this.dgvListEmployees.Name = "dgvListEmployees";
            this.dgvListEmployees.Size = new System.Drawing.Size(794, 454);
            this.dgvListEmployees.TabIndex = 0;
            // 
            // panelFilterEmployees
            // 
            this.panelFilterEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelFilterEmployees.Controls.Add(this.cbPositionFilter);
            this.panelFilterEmployees.Controls.Add(this.cbNameFilter);
            this.panelFilterEmployees.Controls.Add(this.lblPositionEmployee);
            this.panelFilterEmployees.Controls.Add(this.lblNameEmployee);
            this.panelFilterEmployees.Controls.Add(this.btnRefresh);
            this.panelFilterEmployees.Controls.Add(this.btnSearch);
            this.panelFilterEmployees.Location = new System.Drawing.Point(165, 16);
            this.panelFilterEmployees.Name = "panelFilterEmployees";
            this.panelFilterEmployees.Size = new System.Drawing.Size(555, 121);
            this.panelFilterEmployees.TabIndex = 0;
            // 
            // cbPositionFilter
            // 
            this.cbPositionFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPositionFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPositionFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPositionFilter.FormattingEnabled = true;
            this.cbPositionFilter.Location = new System.Drawing.Point(290, 32);
            this.cbPositionFilter.Name = "cbPositionFilter";
            this.cbPositionFilter.Size = new System.Drawing.Size(238, 21);
            this.cbPositionFilter.TabIndex = 3;
            // 
            // cbNameFilter
            // 
            this.cbNameFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNameFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNameFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbNameFilter.FormattingEnabled = true;
            this.cbNameFilter.Location = new System.Drawing.Point(27, 32);
            this.cbNameFilter.Name = "cbNameFilter";
            this.cbNameFilter.Size = new System.Drawing.Size(238, 21);
            this.cbNameFilter.TabIndex = 1;
            // 
            // lblPositionEmployee
            // 
            this.lblPositionEmployee.AutoSize = true;
            this.lblPositionEmployee.ForeColor = System.Drawing.Color.White;
            this.lblPositionEmployee.Location = new System.Drawing.Point(295, 15);
            this.lblPositionEmployee.Name = "lblPositionEmployee";
            this.lblPositionEmployee.Size = new System.Drawing.Size(44, 13);
            this.lblPositionEmployee.TabIndex = 2;
            this.lblPositionEmployee.Text = "Position";
            // 
            // lblNameEmployee
            // 
            this.lblNameEmployee.AutoSize = true;
            this.lblNameEmployee.ForeColor = System.Drawing.Color.White;
            this.lblNameEmployee.Location = new System.Drawing.Point(31, 14);
            this.lblNameEmployee.Name = "lblNameEmployee";
            this.lblNameEmployee.Size = new System.Drawing.Size(35, 13);
            this.lblNameEmployee.TabIndex = 0;
            this.lblNameEmployee.Text = "Name";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(290, 73);
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
            this.btnSearch.Location = new System.Drawing.Point(127, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ListEmployeesAccControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelListEmployees);
            this.Controls.Add(this.panelFilterEmployees);
            this.Name = "ListEmployeesAccControl";
            this.Size = new System.Drawing.Size(882, 652);
            this.Load += new System.EventHandler(this.ListEmployeesAccControl_Load);
            this.panelListEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).EndInit();
            this.panelFilterEmployees.ResumeLayout(false);
            this.panelFilterEmployees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelListEmployees;
        private System.Windows.Forms.DataGridView dgvListEmployees;
        private System.Windows.Forms.Panel panelFilterEmployees;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPositionEmployee;
        private System.Windows.Forms.Label lblNameEmployee;
        private System.Windows.Forms.ComboBox cbPositionFilter;
        private System.Windows.Forms.ComboBox cbNameFilter;
    }
}
