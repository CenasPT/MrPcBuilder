namespace MrPcBuilder_project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelClients = new System.Windows.Forms.Panel();
            this.btnclients = new System.Windows.Forms.Button();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.btnComponents = new System.Windows.Forms.Button();
            this.panelBuild = new System.Windows.Forms.Panel();
            this.btnBuild = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbMenuButton = new System.Windows.Forms.PictureBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTopPanelTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.panelClients.SuspendLayout();
            this.panelProducts.SuspendLayout();
            this.panelBuild.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuButton)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panelSidebar.Controls.Add(this.panelAdmin);
            this.panelSidebar.Controls.Add(this.panelLogout);
            this.panelSidebar.Controls.Add(this.panelClients);
            this.panelSidebar.Controls.Add(this.panelProducts);
            this.panelSidebar.Controls.Add(this.panelBuild);
            this.panelSidebar.Controls.Add(this.panelHome);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.MaximumSize = new System.Drawing.Size(166, 0);
            this.panelSidebar.MinimumSize = new System.Drawing.Size(57, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(166, 681);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.btnAdmin);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmin.Location = new System.Drawing.Point(0, 195);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(166, 36);
            this.panelAdmin.TabIndex = 5;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(-5, -5);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(196, 45);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "          Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.btnLogout);
            this.panelLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogout.Location = new System.Drawing.Point(0, 645);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(166, 36);
            this.panelLogout.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-5, -5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(196, 45);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelClients
            // 
            this.panelClients.Controls.Add(this.btnclients);
            this.panelClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClients.Location = new System.Drawing.Point(0, 159);
            this.panelClients.Name = "panelClients";
            this.panelClients.Size = new System.Drawing.Size(166, 36);
            this.panelClients.TabIndex = 4;
            // 
            // btnclients
            // 
            this.btnclients.BackColor = System.Drawing.Color.Transparent;
            this.btnclients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnclients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnclients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclients.ForeColor = System.Drawing.Color.White;
            this.btnclients.Image = ((System.Drawing.Image)(resources.GetObject("btnclients.Image")));
            this.btnclients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclients.Location = new System.Drawing.Point(-5, -5);
            this.btnclients.Name = "btnclients";
            this.btnclients.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnclients.Size = new System.Drawing.Size(196, 45);
            this.btnclients.TabIndex = 0;
            this.btnclients.Text = "          Clients";
            this.btnclients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclients.UseVisualStyleBackColor = false;
            this.btnclients.Click += new System.EventHandler(this.btnclients_Click);
            // 
            // panelProducts
            // 
            this.panelProducts.Controls.Add(this.btnComponents);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProducts.Location = new System.Drawing.Point(0, 123);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(166, 36);
            this.panelProducts.TabIndex = 3;
            // 
            // btnComponents
            // 
            this.btnComponents.BackColor = System.Drawing.Color.Transparent;
            this.btnComponents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnComponents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComponents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComponents.ForeColor = System.Drawing.Color.White;
            this.btnComponents.Image = ((System.Drawing.Image)(resources.GetObject("btnComponents.Image")));
            this.btnComponents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComponents.Location = new System.Drawing.Point(-5, -5);
            this.btnComponents.Name = "btnComponents";
            this.btnComponents.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnComponents.Size = new System.Drawing.Size(196, 45);
            this.btnComponents.TabIndex = 0;
            this.btnComponents.Text = "          Components";
            this.btnComponents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComponents.UseVisualStyleBackColor = false;
            this.btnComponents.Click += new System.EventHandler(this.btnComponents_Click);
            // 
            // panelBuild
            // 
            this.panelBuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelBuild.Controls.Add(this.btnBuild);
            this.panelBuild.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuild.Location = new System.Drawing.Point(0, 87);
            this.panelBuild.Name = "panelBuild";
            this.panelBuild.Size = new System.Drawing.Size(166, 36);
            this.panelBuild.TabIndex = 2;
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.Transparent;
            this.btnBuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnBuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuild.ForeColor = System.Drawing.Color.White;
            this.btnBuild.Image = ((System.Drawing.Image)(resources.GetObject("btnBuild.Image")));
            this.btnBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuild.Location = new System.Drawing.Point(-5, -5);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBuild.Size = new System.Drawing.Size(196, 45);
            this.btnBuild.TabIndex = 0;
            this.btnBuild.Text = "          Build";
            this.btnBuild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuild.UseVisualStyleBackColor = false;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 51);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(166, 36);
            this.panelHome.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-5, -5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(196, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "          Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblMenu);
            this.panelLogo.Controls.Add(this.pbMenuButton);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(166, 51);
            this.panelLogo.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(55, 19);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(50, 21);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu";
            // 
            // pbMenuButton
            // 
            this.pbMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("pbMenuButton.Image")));
            this.pbMenuButton.Location = new System.Drawing.Point(16, 16);
            this.pbMenuButton.Name = "pbMenuButton";
            this.pbMenuButton.Size = new System.Drawing.Size(26, 26);
            this.pbMenuButton.TabIndex = 0;
            this.pbMenuButton.TabStop = false;
            this.pbMenuButton.Click += new System.EventHandler(this.pbMenuButton_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.AutoSize = true;
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panelTitleBar.Controls.Add(this.lblTopPanelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(166, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1098, 21);
            this.panelTitleBar.TabIndex = 0;
            // 
            // lblTopPanelTitle
            // 
            this.lblTopPanelTitle.AutoSize = true;
            this.lblTopPanelTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopPanelTitle.ForeColor = System.Drawing.Color.White;
            this.lblTopPanelTitle.Location = new System.Drawing.Point(6, 1);
            this.lblTopPanelTitle.Name = "lblTopPanelTitle";
            this.lblTopPanelTitle.Size = new System.Drawing.Size(53, 20);
            this.lblTopPanelTitle.TabIndex = 0;
            this.lblTopPanelTitle.Text = "HOME";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(70, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 21);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(111, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(41, 21);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnX
            // 
            this.btnX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnX.BackgroundImage")));
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnX.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Location = new System.Drawing.Point(152, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(41, 21);
            this.btnX.TabIndex = 3;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(0, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(70, 17);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "UserName";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(166, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1098, 681);
            this.panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Location = new System.Drawing.Point(1071, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 21);
            this.panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MrPcBuilder";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panelSidebar.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.panelClients.ResumeLayout(false);
            this.panelProducts.ResumeLayout(false);
            this.panelBuild.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuButton)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelClients;
        private System.Windows.Forms.Button btnclients;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Panel panelBuild;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pbMenuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTopPanelTitle;
        private System.Windows.Forms.Button btnComponents;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}