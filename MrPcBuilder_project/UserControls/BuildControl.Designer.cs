namespace MrPcBuilder_project
{
    partial class BuildControl
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
            this.panelBuildsMenu = new System.Windows.Forms.Panel();
            this.btnListBuilds = new System.Windows.Forms.Button();
            this.btnEditBuild = new System.Windows.Forms.Button();
            this.btnNewBuild = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelBuildsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBuildsMenu
            // 
            this.panelBuildsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelBuildsMenu.Controls.Add(this.btnListBuilds);
            this.panelBuildsMenu.Controls.Add(this.btnEditBuild);
            this.panelBuildsMenu.Controls.Add(this.btnNewBuild);
            this.panelBuildsMenu.Location = new System.Drawing.Point(12, 36);
            this.panelBuildsMenu.Name = "panelBuildsMenu";
            this.panelBuildsMenu.Size = new System.Drawing.Size(195, 168);
            this.panelBuildsMenu.TabIndex = 1;
            // 
            // btnListBuilds
            // 
            this.btnListBuilds.BackColor = System.Drawing.Color.Transparent;
            this.btnListBuilds.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnListBuilds.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnListBuilds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListBuilds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListBuilds.ForeColor = System.Drawing.Color.White;
            this.btnListBuilds.Location = new System.Drawing.Point(18, 64);
            this.btnListBuilds.Name = "btnListBuilds";
            this.btnListBuilds.Size = new System.Drawing.Size(159, 32);
            this.btnListBuilds.TabIndex = 1;
            this.btnListBuilds.Text = "List Builds";
            this.btnListBuilds.UseVisualStyleBackColor = false;
            this.btnListBuilds.Click += new System.EventHandler(this.btnListBuilds_Click);
            // 
            // btnEditBuild
            // 
            this.btnEditBuild.BackColor = System.Drawing.Color.Transparent;
            this.btnEditBuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnEditBuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnEditBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBuild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBuild.ForeColor = System.Drawing.Color.White;
            this.btnEditBuild.Location = new System.Drawing.Point(18, 112);
            this.btnEditBuild.Name = "btnEditBuild";
            this.btnEditBuild.Size = new System.Drawing.Size(159, 32);
            this.btnEditBuild.TabIndex = 2;
            this.btnEditBuild.Text = "Edit build";
            this.btnEditBuild.UseVisualStyleBackColor = false;
            this.btnEditBuild.Click += new System.EventHandler(this.btnEditBuild_Click);
            // 
            // btnNewBuild
            // 
            this.btnNewBuild.BackColor = System.Drawing.Color.Transparent;
            this.btnNewBuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnNewBuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnNewBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBuild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBuild.ForeColor = System.Drawing.Color.White;
            this.btnNewBuild.Location = new System.Drawing.Point(18, 16);
            this.btnNewBuild.Name = "btnNewBuild";
            this.btnNewBuild.Size = new System.Drawing.Size(159, 32);
            this.btnNewBuild.TabIndex = 0;
            this.btnNewBuild.Text = "Create New Build";
            this.btnNewBuild.UseVisualStyleBackColor = false;
            this.btnNewBuild.Click += new System.EventHandler(this.btnNewBuild_Click);
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
            // BuildControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBuildsMenu);
            this.Name = "BuildControl";
            this.Size = new System.Drawing.Size(1098, 681);
            this.panelBuildsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuildsMenu;
        private System.Windows.Forms.Button btnListBuilds;
        private System.Windows.Forms.Button btnEditBuild;
        private System.Windows.Forms.Button btnNewBuild;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTitleBar;
    }
}
