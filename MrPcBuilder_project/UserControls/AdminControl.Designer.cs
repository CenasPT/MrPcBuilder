namespace MrPcBuilder_project
{
    partial class AdminControl
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBuildsMenu = new System.Windows.Forms.Panel();
            this.btnEmployeeRole = new System.Windows.Forms.Button();
            this.btnEditEmployeeAcc = new System.Windows.Forms.Button();
            this.btnNewEmployeeAcc = new System.Windows.Forms.Button();
            this.btnListEmployeeAcc = new System.Windows.Forms.Button();
            this.btnPaymentMethod = new System.Windows.Forms.Button();
            this.panelBuildsMenu.SuspendLayout();
            this.SuspendLayout();
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
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(213, 26);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(882, 652);
            this.panelMain.TabIndex = 2;
            // 
            // panelBuildsMenu
            // 
            this.panelBuildsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelBuildsMenu.Controls.Add(this.btnEmployeeRole);
            this.panelBuildsMenu.Controls.Add(this.btnEditEmployeeAcc);
            this.panelBuildsMenu.Controls.Add(this.btnNewEmployeeAcc);
            this.panelBuildsMenu.Controls.Add(this.btnListEmployeeAcc);
            this.panelBuildsMenu.Controls.Add(this.btnPaymentMethod);
            this.panelBuildsMenu.Location = new System.Drawing.Point(12, 36);
            this.panelBuildsMenu.Name = "panelBuildsMenu";
            this.panelBuildsMenu.Size = new System.Drawing.Size(195, 256);
            this.panelBuildsMenu.TabIndex = 1;
            // 
            // btnEmployeeRole
            // 
            this.btnEmployeeRole.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeRole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnEmployeeRole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnEmployeeRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeRole.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeRole.Location = new System.Drawing.Point(18, 157);
            this.btnEmployeeRole.Name = "btnEmployeeRole";
            this.btnEmployeeRole.Size = new System.Drawing.Size(159, 32);
            this.btnEmployeeRole.TabIndex = 3;
            this.btnEmployeeRole.Text = "Company Roles";
            this.btnEmployeeRole.UseVisualStyleBackColor = false;
            this.btnEmployeeRole.Click += new System.EventHandler(this.btnCompanyPositions_Click);
            // 
            // btnEditEmployeeAcc
            // 
            this.btnEditEmployeeAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnEditEmployeeAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnEditEmployeeAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnEditEmployeeAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmployeeAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployeeAcc.ForeColor = System.Drawing.Color.White;
            this.btnEditEmployeeAcc.Location = new System.Drawing.Point(18, 111);
            this.btnEditEmployeeAcc.Name = "btnEditEmployeeAcc";
            this.btnEditEmployeeAcc.Size = new System.Drawing.Size(159, 32);
            this.btnEditEmployeeAcc.TabIndex = 2;
            this.btnEditEmployeeAcc.Text = "Edit Employee Acc";
            this.btnEditEmployeeAcc.UseVisualStyleBackColor = false;
            this.btnEditEmployeeAcc.Click += new System.EventHandler(this.btnEditEmployeeAcc_Click);
            // 
            // btnNewEmployeeAcc
            // 
            this.btnNewEmployeeAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnNewEmployeeAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnNewEmployeeAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnNewEmployeeAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEmployeeAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmployeeAcc.ForeColor = System.Drawing.Color.White;
            this.btnNewEmployeeAcc.Location = new System.Drawing.Point(18, 19);
            this.btnNewEmployeeAcc.Name = "btnNewEmployeeAcc";
            this.btnNewEmployeeAcc.Size = new System.Drawing.Size(159, 32);
            this.btnNewEmployeeAcc.TabIndex = 0;
            this.btnNewEmployeeAcc.Text = "New Employee Acc";
            this.btnNewEmployeeAcc.UseVisualStyleBackColor = false;
            this.btnNewEmployeeAcc.Click += new System.EventHandler(this.btnNewEmployeeAcc_Click);
            // 
            // btnListEmployeeAcc
            // 
            this.btnListEmployeeAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnListEmployeeAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnListEmployeeAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnListEmployeeAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListEmployeeAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListEmployeeAcc.ForeColor = System.Drawing.Color.White;
            this.btnListEmployeeAcc.Location = new System.Drawing.Point(18, 65);
            this.btnListEmployeeAcc.Name = "btnListEmployeeAcc";
            this.btnListEmployeeAcc.Size = new System.Drawing.Size(159, 32);
            this.btnListEmployeeAcc.TabIndex = 1;
            this.btnListEmployeeAcc.Text = "List Employees Acc";
            this.btnListEmployeeAcc.UseVisualStyleBackColor = false;
            this.btnListEmployeeAcc.Click += new System.EventHandler(this.btnListEmployeeAcc_Click);
            // 
            // btnPaymentMethod
            // 
            this.btnPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.btnPaymentMethod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnPaymentMethod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.btnPaymentMethod.Location = new System.Drawing.Point(18, 203);
            this.btnPaymentMethod.Name = "btnPaymentMethod";
            this.btnPaymentMethod.Size = new System.Drawing.Size(159, 32);
            this.btnPaymentMethod.TabIndex = 4;
            this.btnPaymentMethod.Text = "Payment Methods";
            this.btnPaymentMethod.UseVisualStyleBackColor = false;
            this.btnPaymentMethod.Click += new System.EventHandler(this.btnPaymentMethod_Click);
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBuildsMenu);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(1098, 681);
            this.panelBuildsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBuildsMenu;
        private System.Windows.Forms.Button btnEditEmployeeAcc;
        private System.Windows.Forms.Button btnNewEmployeeAcc;
        private System.Windows.Forms.Button btnListEmployeeAcc;
        private System.Windows.Forms.Button btnPaymentMethod;
        private System.Windows.Forms.Button btnEmployeeRole;
    }
}
