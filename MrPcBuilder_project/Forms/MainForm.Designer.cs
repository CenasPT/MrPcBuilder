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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelSidebar = new System.Windows.Forms.Panel();
            panelAdmin = new System.Windows.Forms.Panel();
            btnAdmin = new System.Windows.Forms.Button();
            panelLogout = new System.Windows.Forms.Panel();
            btnLogout = new System.Windows.Forms.Button();
            panelClients = new System.Windows.Forms.Panel();
            btnclients = new System.Windows.Forms.Button();
            panelProducts = new System.Windows.Forms.Panel();
            btnComponents = new System.Windows.Forms.Button();
            panelBuild = new System.Windows.Forms.Panel();
            btnBuild = new System.Windows.Forms.Button();
            panelHome = new System.Windows.Forms.Panel();
            btnHome = new System.Windows.Forms.Button();
            panelLogo = new System.Windows.Forms.Panel();
            lblMenu = new System.Windows.Forms.Label();
            pbMenuButton = new System.Windows.Forms.PictureBox();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            panelTitleBar = new System.Windows.Forms.Panel();
            lblTopPanelTitle = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            btnMaximize = new System.Windows.Forms.Button();
            btnX = new System.Windows.Forms.Button();
            lblUserName = new System.Windows.Forms.Label();
            panelMain = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panelSidebar.SuspendLayout();
            panelAdmin.SuspendLayout();
            panelLogout.SuspendLayout();
            panelClients.SuspendLayout();
            panelProducts.SuspendLayout();
            panelBuild.SuspendLayout();
            panelHome.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMenuButton).BeginInit();
            panelTitleBar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = System.Drawing.Color.FromArgb(30, 30, 40);
            panelSidebar.Controls.Add(panelAdmin);
            panelSidebar.Controls.Add(panelLogout);
            panelSidebar.Controls.Add(panelClients);
            panelSidebar.Controls.Add(panelProducts);
            panelSidebar.Controls.Add(panelBuild);
            panelSidebar.Controls.Add(panelHome);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            panelSidebar.Location = new System.Drawing.Point(0, 0);
            panelSidebar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelSidebar.MaximumSize = new System.Drawing.Size(194, 0);
            panelSidebar.MinimumSize = new System.Drawing.Size(66, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new System.Drawing.Size(194, 786);
            panelSidebar.TabIndex = 0;
            // 
            // panelAdmin
            // 
            panelAdmin.Controls.Add(btnAdmin);
            panelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            panelAdmin.Location = new System.Drawing.Point(0, 227);
            panelAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new System.Drawing.Size(194, 42);
            panelAdmin.TabIndex = 5;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = System.Drawing.Color.Transparent;
            btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 50);
            btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = System.Drawing.Color.White;
            btnAdmin.Image = (System.Drawing.Image)resources.GetObject("btnAdmin.Image");
            btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAdmin.Location = new System.Drawing.Point(-6, -6);
            btnAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            btnAdmin.Size = new System.Drawing.Size(229, 52);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "          Admin";
            btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // panelLogout
            // 
            panelLogout.Controls.Add(btnLogout);
            panelLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelLogout.Location = new System.Drawing.Point(0, 744);
            panelLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelLogout.Name = "panelLogout";
            panelLogout.Size = new System.Drawing.Size(194, 42);
            panelLogout.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.Transparent;
            btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 50);
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLogout.ForeColor = System.Drawing.Color.White;
            btnLogout.Image = (System.Drawing.Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogout.Location = new System.Drawing.Point(-6, -6);
            btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            btnLogout.Size = new System.Drawing.Size(229, 52);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "          Logout";
            btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelClients
            // 
            panelClients.Controls.Add(btnclients);
            panelClients.Dock = System.Windows.Forms.DockStyle.Top;
            panelClients.Location = new System.Drawing.Point(0, 185);
            panelClients.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelClients.Name = "panelClients";
            panelClients.Size = new System.Drawing.Size(194, 42);
            panelClients.TabIndex = 4;
            // 
            // btnclients
            // 
            btnclients.BackColor = System.Drawing.Color.Transparent;
            btnclients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            btnclients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 50);
            btnclients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnclients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnclients.ForeColor = System.Drawing.Color.White;
            btnclients.Image = (System.Drawing.Image)resources.GetObject("btnclients.Image");
            btnclients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnclients.Location = new System.Drawing.Point(-6, -6);
            btnclients.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnclients.Name = "btnclients";
            btnclients.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            btnclients.Size = new System.Drawing.Size(229, 52);
            btnclients.TabIndex = 0;
            btnclients.Text = "          Clients";
            btnclients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnclients.UseVisualStyleBackColor = false;
            btnclients.Click += btnclients_Click;
            // 
            // panelProducts
            // 
            panelProducts.Controls.Add(btnComponents);
            panelProducts.Dock = System.Windows.Forms.DockStyle.Top;
            panelProducts.Location = new System.Drawing.Point(0, 143);
            panelProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelProducts.Name = "panelProducts";
            panelProducts.Size = new System.Drawing.Size(194, 42);
            panelProducts.TabIndex = 3;
            // 
            // btnComponents
            // 
            btnComponents.BackColor = System.Drawing.Color.Transparent;
            btnComponents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            btnComponents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 50);
            btnComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnComponents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnComponents.ForeColor = System.Drawing.Color.White;
            btnComponents.Image = (System.Drawing.Image)resources.GetObject("btnComponents.Image");
            btnComponents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnComponents.Location = new System.Drawing.Point(-6, -6);
            btnComponents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnComponents.Name = "btnComponents";
            btnComponents.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            btnComponents.Size = new System.Drawing.Size(229, 52);
            btnComponents.TabIndex = 0;
            btnComponents.Text = "          Components";
            btnComponents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnComponents.UseVisualStyleBackColor = false;
            btnComponents.Click += btnComponents_Click;
            // 
            // panelBuild
            // 
            panelBuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panelBuild.Controls.Add(btnBuild);
            panelBuild.Dock = System.Windows.Forms.DockStyle.Top;
            panelBuild.Location = new System.Drawing.Point(0, 101);
            panelBuild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelBuild.Name = "panelBuild";
            panelBuild.Size = new System.Drawing.Size(194, 42);
            panelBuild.TabIndex = 2;
            // 
            // btnBuild
            // 
            btnBuild.BackColor = System.Drawing.Color.Transparent;
            btnBuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            btnBuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 50);
            btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnBuild.ForeColor = System.Drawing.Color.White;
            btnBuild.Image = (System.Drawing.Image)resources.GetObject("btnBuild.Image");
            btnBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBuild.Location = new System.Drawing.Point(-6, -6);
            btnBuild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBuild.Name = "btnBuild";
            btnBuild.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            btnBuild.Size = new System.Drawing.Size(229, 52);
            btnBuild.TabIndex = 0;
            btnBuild.Text = "          Build";
            btnBuild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBuild.UseVisualStyleBackColor = false;
            btnBuild.Click += btnBuild_Click;
            // 
            // panelHome
            // 
            panelHome.Controls.Add(btnHome);
            panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            panelHome.Location = new System.Drawing.Point(0, 59);
            panelHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelHome.Name = "panelHome";
            panelHome.Size = new System.Drawing.Size(194, 42);
            panelHome.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = System.Drawing.Color.Transparent;
            btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 50);
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnHome.ForeColor = System.Drawing.Color.White;
            btnHome.Image = (System.Drawing.Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHome.Location = new System.Drawing.Point(-6, -6);
            btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHome.Name = "btnHome";
            btnHome.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            btnHome.Size = new System.Drawing.Size(229, 52);
            btnHome.TabIndex = 0;
            btnHome.Text = "          Home";
            btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lblMenu);
            panelLogo.Controls.Add(pbMenuButton);
            panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            panelLogo.Location = new System.Drawing.Point(0, 0);
            panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new System.Drawing.Size(194, 59);
            panelLogo.TabIndex = 0;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMenu.ForeColor = System.Drawing.Color.White;
            lblMenu.Location = new System.Drawing.Point(64, 22);
            lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new System.Drawing.Size(50, 21);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Menu";
            // 
            // pbMenuButton
            // 
            pbMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            pbMenuButton.Image = (System.Drawing.Image)resources.GetObject("pbMenuButton.Image");
            pbMenuButton.Location = new System.Drawing.Point(19, 18);
            pbMenuButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pbMenuButton.Name = "pbMenuButton";
            pbMenuButton.Size = new System.Drawing.Size(30, 30);
            pbMenuButton.TabIndex = 0;
            pbMenuButton.TabStop = false;
            pbMenuButton.Click += pbMenuButton_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // panelTitleBar
            // 
            panelTitleBar.AutoSize = true;
            panelTitleBar.BackColor = System.Drawing.Color.FromArgb(30, 30, 40);
            panelTitleBar.Controls.Add(lblTopPanelTitle);
            panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            panelTitleBar.Location = new System.Drawing.Point(194, 0);
            panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new System.Drawing.Size(1281, 21);
            panelTitleBar.TabIndex = 0;
            // 
            // lblTopPanelTitle
            // 
            lblTopPanelTitle.AutoSize = true;
            lblTopPanelTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTopPanelTitle.ForeColor = System.Drawing.Color.White;
            lblTopPanelTitle.Location = new System.Drawing.Point(7, 1);
            lblTopPanelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTopPanelTitle.Name = "lblTopPanelTitle";
            lblTopPanelTitle.Size = new System.Drawing.Size(53, 20);
            lblTopPanelTitle.TabIndex = 0;
            lblTopPanelTitle.Text = "HOME";
            // 
            // button1
            // 
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button1.Dock = System.Windows.Forms.DockStyle.Right;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 30, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(81, 0);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(48, 24);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 30, 40);
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMaximize.Location = new System.Drawing.Point(129, 0);
            btnMaximize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new System.Drawing.Size(48, 24);
            btnMaximize.TabIndex = 2;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnX
            // 
            btnX.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnX.BackgroundImage");
            btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnX.Dock = System.Windows.Forms.DockStyle.Right;
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnX.Location = new System.Drawing.Point(177, 0);
            btnX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnX.Name = "btnX";
            btnX.Size = new System.Drawing.Size(48, 24);
            btnX.TabIndex = 3;
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += btnX_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = System.Windows.Forms.DockStyle.Left;
            lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblUserName.ForeColor = System.Drawing.Color.White;
            lblUserName.Location = new System.Drawing.Point(0, 0);
            lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(70, 17);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "UserName";
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(194, 0);
            panelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1281, 786);
            panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = System.Drawing.Color.FromArgb(30, 30, 40);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnX);
            panel1.Location = new System.Drawing.Point(1250, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(225, 24);
            panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1475, 786);
            Controls.Add(panel1);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MrPcBuilder";
            Load += Main_Load;
            Shown += MainForm_Shown;
            panelSidebar.ResumeLayout(false);
            panelAdmin.ResumeLayout(false);
            panelLogout.ResumeLayout(false);
            panelClients.ResumeLayout(false);
            panelProducts.ResumeLayout(false);
            panelBuild.ResumeLayout(false);
            panelHome.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMenuButton).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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