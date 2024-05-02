namespace MrPcBuilder_project
{
    partial class PaymentMethodControl
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
            this.panelNewPM = new System.Windows.Forms.Panel();
            this.txtNewPMName = new System.Windows.Forms.TextBox();
            this.btnClearNewPM = new System.Windows.Forms.Button();
            this.btnAddNewPM = new System.Windows.Forms.Button();
            this.lblNewPMName = new System.Windows.Forms.Label();
            this.lblNewPM = new System.Windows.Forms.Label();
            this.panelDeletePM = new System.Windows.Forms.Panel();
            this.btnRefreshDeletePM = new System.Windows.Forms.Button();
            this.btnDeletePM = new System.Windows.Forms.Button();
            this.cbSearchDeletePM = new System.Windows.Forms.ComboBox();
            this.lblDeletePM = new System.Windows.Forms.Label();
            this.lblDeletePMTitle = new System.Windows.Forms.Label();
            this.panelEditPM2 = new System.Windows.Forms.Panel();
            this.txtEditPMName = new System.Windows.Forms.TextBox();
            this.lblEditPMName = new System.Windows.Forms.Label();
            this.btnRefreshEditPM = new System.Windows.Forms.Button();
            this.btnUpdatePM = new System.Windows.Forms.Button();
            this.panelEditPM1 = new System.Windows.Forms.Panel();
            this.btnEditPM = new System.Windows.Forms.Button();
            this.cbSearchEditPM = new System.Windows.Forms.ComboBox();
            this.lblEditPM = new System.Windows.Forms.Label();
            this.lblEditPMTitle = new System.Windows.Forms.Label();
            this.panelNewPM.SuspendLayout();
            this.panelDeletePM.SuspendLayout();
            this.panelEditPM2.SuspendLayout();
            this.panelEditPM1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNewPM
            // 
            this.panelNewPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelNewPM.Controls.Add(this.txtNewPMName);
            this.panelNewPM.Controls.Add(this.btnClearNewPM);
            this.panelNewPM.Controls.Add(this.btnAddNewPM);
            this.panelNewPM.Controls.Add(this.lblNewPMName);
            this.panelNewPM.Controls.Add(this.lblNewPM);
            this.panelNewPM.Location = new System.Drawing.Point(37, 66);
            this.panelNewPM.Name = "panelNewPM";
            this.panelNewPM.Size = new System.Drawing.Size(363, 169);
            this.panelNewPM.TabIndex = 0;
            // 
            // txtNewPMName
            // 
            this.txtNewPMName.Location = new System.Drawing.Point(25, 73);
            this.txtNewPMName.MaxLength = 100;
            this.txtNewPMName.Name = "txtNewPMName";
            this.txtNewPMName.Size = new System.Drawing.Size(306, 20);
            this.txtNewPMName.TabIndex = 2;
            // 
            // btnClearNewPM
            // 
            this.btnClearNewPM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearNewPM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnClearNewPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearNewPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearNewPM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearNewPM.ForeColor = System.Drawing.Color.White;
            this.btnClearNewPM.Location = new System.Drawing.Point(193, 111);
            this.btnClearNewPM.Name = "btnClearNewPM";
            this.btnClearNewPM.Size = new System.Drawing.Size(138, 27);
            this.btnClearNewPM.TabIndex = 4;
            this.btnClearNewPM.Text = "Clear";
            this.btnClearNewPM.UseVisualStyleBackColor = true;
            this.btnClearNewPM.Click += new System.EventHandler(this.btnClearNewPM_Click);
            // 
            // btnAddNewPM
            // 
            this.btnAddNewPM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewPM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAddNewPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPM.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPM.Location = new System.Drawing.Point(25, 111);
            this.btnAddNewPM.Name = "btnAddNewPM";
            this.btnAddNewPM.Size = new System.Drawing.Size(138, 27);
            this.btnAddNewPM.TabIndex = 3;
            this.btnAddNewPM.Text = "Add";
            this.btnAddNewPM.UseVisualStyleBackColor = true;
            this.btnAddNewPM.Click += new System.EventHandler(this.btnAddNewPM_Click);
            // 
            // lblNewPMName
            // 
            this.lblNewPMName.AutoSize = true;
            this.lblNewPMName.ForeColor = System.Drawing.Color.White;
            this.lblNewPMName.Location = new System.Drawing.Point(29, 54);
            this.lblNewPMName.Name = "lblNewPMName";
            this.lblNewPMName.Size = new System.Drawing.Size(42, 13);
            this.lblNewPMName.TabIndex = 1;
            this.lblNewPMName.Text = "Name *";
            // 
            // lblNewPM
            // 
            this.lblNewPM.AutoSize = true;
            this.lblNewPM.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPM.ForeColor = System.Drawing.Color.White;
            this.lblNewPM.Location = new System.Drawing.Point(84, 21);
            this.lblNewPM.Name = "lblNewPM";
            this.lblNewPM.Size = new System.Drawing.Size(199, 20);
            this.lblNewPM.TabIndex = 0;
            this.lblNewPM.Text = "Add New Payment Method";
            // 
            // panelDeletePM
            // 
            this.panelDeletePM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelDeletePM.Controls.Add(this.btnRefreshDeletePM);
            this.panelDeletePM.Controls.Add(this.btnDeletePM);
            this.panelDeletePM.Controls.Add(this.cbSearchDeletePM);
            this.panelDeletePM.Controls.Add(this.lblDeletePM);
            this.panelDeletePM.Controls.Add(this.lblDeletePMTitle);
            this.panelDeletePM.Location = new System.Drawing.Point(37, 317);
            this.panelDeletePM.Name = "panelDeletePM";
            this.panelDeletePM.Size = new System.Drawing.Size(363, 155);
            this.panelDeletePM.TabIndex = 3;
            // 
            // btnRefreshDeletePM
            // 
            this.btnRefreshDeletePM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefreshDeletePM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRefreshDeletePM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefreshDeletePM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDeletePM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDeletePM.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDeletePM.Location = new System.Drawing.Point(193, 103);
            this.btnRefreshDeletePM.Name = "btnRefreshDeletePM";
            this.btnRefreshDeletePM.Size = new System.Drawing.Size(138, 27);
            this.btnRefreshDeletePM.TabIndex = 4;
            this.btnRefreshDeletePM.Text = "Refresh / Clear";
            this.btnRefreshDeletePM.UseVisualStyleBackColor = true;
            this.btnRefreshDeletePM.Click += new System.EventHandler(this.btnRefreshDeletePM_Click);
            // 
            // btnDeletePM
            // 
            this.btnDeletePM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeletePM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDeletePM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeletePM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePM.ForeColor = System.Drawing.Color.White;
            this.btnDeletePM.Location = new System.Drawing.Point(25, 103);
            this.btnDeletePM.Name = "btnDeletePM";
            this.btnDeletePM.Size = new System.Drawing.Size(138, 27);
            this.btnDeletePM.TabIndex = 3;
            this.btnDeletePM.Text = "Delete";
            this.btnDeletePM.UseVisualStyleBackColor = true;
            this.btnDeletePM.Click += new System.EventHandler(this.btnDeletePM_Click);
            // 
            // cbSearchDeletePM
            // 
            this.cbSearchDeletePM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSearchDeletePM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearchDeletePM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSearchDeletePM.FormattingEnabled = true;
            this.cbSearchDeletePM.Location = new System.Drawing.Point(25, 66);
            this.cbSearchDeletePM.Name = "cbSearchDeletePM";
            this.cbSearchDeletePM.Size = new System.Drawing.Size(306, 21);
            this.cbSearchDeletePM.TabIndex = 2;
            // 
            // lblDeletePM
            // 
            this.lblDeletePM.AutoSize = true;
            this.lblDeletePM.ForeColor = System.Drawing.Color.White;
            this.lblDeletePM.Location = new System.Drawing.Point(32, 47);
            this.lblDeletePM.Name = "lblDeletePM";
            this.lblDeletePM.Size = new System.Drawing.Size(87, 13);
            this.lblDeletePM.TabIndex = 1;
            this.lblDeletePM.Text = "Payment Method";
            // 
            // lblDeletePMTitle
            // 
            this.lblDeletePMTitle.AutoSize = true;
            this.lblDeletePMTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletePMTitle.ForeColor = System.Drawing.Color.White;
            this.lblDeletePMTitle.Location = new System.Drawing.Point(106, 16);
            this.lblDeletePMTitle.Name = "lblDeletePMTitle";
            this.lblDeletePMTitle.Size = new System.Drawing.Size(179, 20);
            this.lblDeletePMTitle.TabIndex = 0;
            this.lblDeletePMTitle.Text = "Delete Payment Method";
            // 
            // panelEditPM2
            // 
            this.panelEditPM2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelEditPM2.Controls.Add(this.txtEditPMName);
            this.panelEditPM2.Controls.Add(this.lblEditPMName);
            this.panelEditPM2.Controls.Add(this.btnRefreshEditPM);
            this.panelEditPM2.Controls.Add(this.btnUpdatePM);
            this.panelEditPM2.Location = new System.Drawing.Point(442, 186);
            this.panelEditPM2.Name = "panelEditPM2";
            this.panelEditPM2.Size = new System.Drawing.Size(398, 126);
            this.panelEditPM2.TabIndex = 2;
            // 
            // txtEditPMName
            // 
            this.txtEditPMName.Location = new System.Drawing.Point(44, 35);
            this.txtEditPMName.MaxLength = 100;
            this.txtEditPMName.Name = "txtEditPMName";
            this.txtEditPMName.Size = new System.Drawing.Size(306, 20);
            this.txtEditPMName.TabIndex = 1;
            // 
            // lblEditPMName
            // 
            this.lblEditPMName.AutoSize = true;
            this.lblEditPMName.ForeColor = System.Drawing.Color.White;
            this.lblEditPMName.Location = new System.Drawing.Point(48, 16);
            this.lblEditPMName.Name = "lblEditPMName";
            this.lblEditPMName.Size = new System.Drawing.Size(67, 13);
            this.lblEditPMName.TabIndex = 0;
            this.lblEditPMName.Text = "New Name *";
            // 
            // btnRefreshEditPM
            // 
            this.btnRefreshEditPM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefreshEditPM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRefreshEditPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefreshEditPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshEditPM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshEditPM.ForeColor = System.Drawing.Color.White;
            this.btnRefreshEditPM.Location = new System.Drawing.Point(212, 75);
            this.btnRefreshEditPM.Name = "btnRefreshEditPM";
            this.btnRefreshEditPM.Size = new System.Drawing.Size(138, 27);
            this.btnRefreshEditPM.TabIndex = 3;
            this.btnRefreshEditPM.Text = "Refresh / Clear";
            this.btnRefreshEditPM.UseVisualStyleBackColor = true;
            this.btnRefreshEditPM.Click += new System.EventHandler(this.btnRefreshEditPM_Click);
            // 
            // btnUpdatePM
            // 
            this.btnUpdatePM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdatePM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnUpdatePM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdatePM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePM.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePM.Location = new System.Drawing.Point(44, 75);
            this.btnUpdatePM.Name = "btnUpdatePM";
            this.btnUpdatePM.Size = new System.Drawing.Size(138, 27);
            this.btnUpdatePM.TabIndex = 2;
            this.btnUpdatePM.Text = "Update";
            this.btnUpdatePM.UseVisualStyleBackColor = true;
            this.btnUpdatePM.Click += new System.EventHandler(this.btnUpdatePM_Click);
            // 
            // panelEditPM1
            // 
            this.panelEditPM1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelEditPM1.Controls.Add(this.btnEditPM);
            this.panelEditPM1.Controls.Add(this.cbSearchEditPM);
            this.panelEditPM1.Controls.Add(this.lblEditPM);
            this.panelEditPM1.Controls.Add(this.lblEditPMTitle);
            this.panelEditPM1.Location = new System.Drawing.Point(442, 66);
            this.panelEditPM1.Name = "panelEditPM1";
            this.panelEditPM1.Size = new System.Drawing.Size(398, 119);
            this.panelEditPM1.TabIndex = 1;
            // 
            // btnEditPM
            // 
            this.btnEditPM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditPM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnEditPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPM.ForeColor = System.Drawing.Color.White;
            this.btnEditPM.Location = new System.Drawing.Point(243, 63);
            this.btnEditPM.Name = "btnEditPM";
            this.btnEditPM.Size = new System.Drawing.Size(138, 27);
            this.btnEditPM.TabIndex = 3;
            this.btnEditPM.Text = "Edit";
            this.btnEditPM.UseVisualStyleBackColor = true;
            this.btnEditPM.Click += new System.EventHandler(this.btnEditPM_Click);
            // 
            // cbSearchEditPM
            // 
            this.cbSearchEditPM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSearchEditPM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearchEditPM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSearchEditPM.FormattingEnabled = true;
            this.cbSearchEditPM.Location = new System.Drawing.Point(14, 67);
            this.cbSearchEditPM.Name = "cbSearchEditPM";
            this.cbSearchEditPM.Size = new System.Drawing.Size(211, 21);
            this.cbSearchEditPM.TabIndex = 2;
            // 
            // lblEditPM
            // 
            this.lblEditPM.AutoSize = true;
            this.lblEditPM.ForeColor = System.Drawing.Color.White;
            this.lblEditPM.Location = new System.Drawing.Point(21, 47);
            this.lblEditPM.Name = "lblEditPM";
            this.lblEditPM.Size = new System.Drawing.Size(87, 13);
            this.lblEditPM.TabIndex = 1;
            this.lblEditPM.Text = "Payment Method";
            // 
            // lblEditPMTitle
            // 
            this.lblEditPMTitle.AutoSize = true;
            this.lblEditPMTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPMTitle.ForeColor = System.Drawing.Color.White;
            this.lblEditPMTitle.Location = new System.Drawing.Point(106, 16);
            this.lblEditPMTitle.Name = "lblEditPMTitle";
            this.lblEditPMTitle.Size = new System.Drawing.Size(161, 20);
            this.lblEditPMTitle.TabIndex = 0;
            this.lblEditPMTitle.Text = "Edit Payment Method";
            // 
            // PaymentMethodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEditPM2);
            this.Controls.Add(this.panelEditPM1);
            this.Controls.Add(this.panelDeletePM);
            this.Controls.Add(this.panelNewPM);
            this.Name = "PaymentMethodControl";
            this.Size = new System.Drawing.Size(882, 652);
            this.Load += new System.EventHandler(this.PaymentMethodControl_Load);
            this.panelNewPM.ResumeLayout(false);
            this.panelNewPM.PerformLayout();
            this.panelDeletePM.ResumeLayout(false);
            this.panelDeletePM.PerformLayout();
            this.panelEditPM2.ResumeLayout(false);
            this.panelEditPM2.PerformLayout();
            this.panelEditPM1.ResumeLayout(false);
            this.panelEditPM1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewPM;
        private System.Windows.Forms.TextBox txtNewPMName;
        private System.Windows.Forms.Button btnClearNewPM;
        private System.Windows.Forms.Button btnAddNewPM;
        private System.Windows.Forms.Label lblNewPMName;
        private System.Windows.Forms.Label lblNewPM;
        private System.Windows.Forms.Panel panelDeletePM;
        private System.Windows.Forms.Button btnDeletePM;
        private System.Windows.Forms.ComboBox cbSearchDeletePM;
        private System.Windows.Forms.Label lblDeletePM;
        private System.Windows.Forms.Label lblDeletePMTitle;
        private System.Windows.Forms.Panel panelEditPM2;
        private System.Windows.Forms.TextBox txtEditPMName;
        private System.Windows.Forms.Label lblEditPMName;
        private System.Windows.Forms.Button btnRefreshEditPM;
        private System.Windows.Forms.Button btnUpdatePM;
        private System.Windows.Forms.Panel panelEditPM1;
        private System.Windows.Forms.Button btnEditPM;
        private System.Windows.Forms.ComboBox cbSearchEditPM;
        private System.Windows.Forms.Label lblEditPM;
        private System.Windows.Forms.Label lblEditPMTitle;
        private System.Windows.Forms.Button btnRefreshDeletePM;
    }
}
