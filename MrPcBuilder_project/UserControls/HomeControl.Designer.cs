namespace MrPcBuilder_project
{
    partial class HomeControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.panelBuilds = new System.Windows.Forms.Panel();
            this.lblBuildCompletedCounter = new System.Windows.Forms.Label();
            this.lblBuildCompleted = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblBuildInProgressCounter = new System.Windows.Forms.Label();
            this.lblBuildPendingCounter = new System.Windows.Forms.Label();
            this.lblBuildInProgress = new System.Windows.Forms.Label();
            this.lblBuildPending = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMainPanelBuild = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelClock = new System.Windows.Forms.Panel();
            this.lblDateToday = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelBuilds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuilds
            // 
            this.panelBuilds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelBuilds.Controls.Add(this.lblBuildCompletedCounter);
            this.panelBuilds.Controls.Add(this.lblBuildCompleted);
            this.panelBuilds.Controls.Add(this.pictureBox3);
            this.panelBuilds.Controls.Add(this.lblBuildInProgressCounter);
            this.panelBuilds.Controls.Add(this.lblBuildPendingCounter);
            this.panelBuilds.Controls.Add(this.lblBuildInProgress);
            this.panelBuilds.Controls.Add(this.lblBuildPending);
            this.panelBuilds.Controls.Add(this.pictureBox2);
            this.panelBuilds.Controls.Add(this.pictureBox1);
            this.panelBuilds.Controls.Add(this.lblMainPanelBuild);
            this.panelBuilds.Location = new System.Drawing.Point(16, 45);
            this.panelBuilds.Name = "panelBuilds";
            this.panelBuilds.Size = new System.Drawing.Size(257, 162);
            this.panelBuilds.TabIndex = 1;
            // 
            // lblBuildCompletedCounter
            // 
            this.lblBuildCompletedCounter.AutoSize = true;
            this.lblBuildCompletedCounter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildCompletedCounter.ForeColor = System.Drawing.Color.White;
            this.lblBuildCompletedCounter.Location = new System.Drawing.Point(167, 118);
            this.lblBuildCompletedCounter.Name = "lblBuildCompletedCounter";
            this.lblBuildCompletedCounter.Size = new System.Drawing.Size(16, 21);
            this.lblBuildCompletedCounter.TabIndex = 6;
            this.lblBuildCompletedCounter.Text = "-";
            // 
            // lblBuildCompleted
            // 
            this.lblBuildCompleted.AutoSize = true;
            this.lblBuildCompleted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildCompleted.ForeColor = System.Drawing.Color.White;
            this.lblBuildCompleted.Location = new System.Drawing.Point(50, 118);
            this.lblBuildCompleted.Name = "lblBuildCompleted";
            this.lblBuildCompleted.Size = new System.Drawing.Size(86, 21);
            this.lblBuildCompleted.TabIndex = 5;
            this.lblBuildCompleted.Text = "Completed";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // lblBuildInProgressCounter
            // 
            this.lblBuildInProgressCounter.AutoSize = true;
            this.lblBuildInProgressCounter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildInProgressCounter.ForeColor = System.Drawing.Color.White;
            this.lblBuildInProgressCounter.Location = new System.Drawing.Point(167, 86);
            this.lblBuildInProgressCounter.Name = "lblBuildInProgressCounter";
            this.lblBuildInProgressCounter.Size = new System.Drawing.Size(16, 21);
            this.lblBuildInProgressCounter.TabIndex = 4;
            this.lblBuildInProgressCounter.Text = "-";
            // 
            // lblBuildPendingCounter
            // 
            this.lblBuildPendingCounter.AutoSize = true;
            this.lblBuildPendingCounter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildPendingCounter.ForeColor = System.Drawing.Color.White;
            this.lblBuildPendingCounter.Location = new System.Drawing.Point(167, 57);
            this.lblBuildPendingCounter.Name = "lblBuildPendingCounter";
            this.lblBuildPendingCounter.Size = new System.Drawing.Size(16, 21);
            this.lblBuildPendingCounter.TabIndex = 2;
            this.lblBuildPendingCounter.Text = "-";
            // 
            // lblBuildInProgress
            // 
            this.lblBuildInProgress.AutoSize = true;
            this.lblBuildInProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildInProgress.ForeColor = System.Drawing.Color.White;
            this.lblBuildInProgress.Location = new System.Drawing.Point(50, 86);
            this.lblBuildInProgress.Name = "lblBuildInProgress";
            this.lblBuildInProgress.Size = new System.Drawing.Size(88, 21);
            this.lblBuildInProgress.TabIndex = 3;
            this.lblBuildInProgress.Text = "In Progress";
            // 
            // lblBuildPending
            // 
            this.lblBuildPending.AutoSize = true;
            this.lblBuildPending.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildPending.ForeColor = System.Drawing.Color.White;
            this.lblBuildPending.Location = new System.Drawing.Point(50, 56);
            this.lblBuildPending.Name = "lblBuildPending";
            this.lblBuildPending.Size = new System.Drawing.Size(66, 21);
            this.lblBuildPending.TabIndex = 1;
            this.lblBuildPending.Text = "Pending";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblMainPanelBuild
            // 
            this.lblMainPanelBuild.AutoSize = true;
            this.lblMainPanelBuild.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainPanelBuild.ForeColor = System.Drawing.Color.White;
            this.lblMainPanelBuild.Location = new System.Drawing.Point(29, 14);
            this.lblMainPanelBuild.Name = "lblMainPanelBuild";
            this.lblMainPanelBuild.Size = new System.Drawing.Size(70, 28);
            this.lblMainPanelBuild.TabIndex = 0;
            this.lblMainPanelBuild.Text = "Builds";
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
            // panelClock
            // 
            this.panelClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelClock.Controls.Add(this.lblDateToday);
            this.panelClock.Controls.Add(this.lblClock);
            this.panelClock.Location = new System.Drawing.Point(822, 589);
            this.panelClock.Name = "panelClock";
            this.panelClock.Size = new System.Drawing.Size(273, 89);
            this.panelClock.TabIndex = 2;
            // 
            // lblDateToday
            // 
            this.lblDateToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateToday.AutoSize = true;
            this.lblDateToday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateToday.ForeColor = System.Drawing.Color.White;
            this.lblDateToday.Location = new System.Drawing.Point(69, 53);
            this.lblDateToday.Name = "lblDateToday";
            this.lblDateToday.Size = new System.Drawing.Size(42, 21);
            this.lblDateToday.TabIndex = 1;
            this.lblDateToday.Text = "Date";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Nachlieli CLM", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(61, 12);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(152, 41);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1098, 664);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelClock);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelBuilds);
            this.Controls.Add(this.pictureBox4);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1098, 681);
            this.Load += new System.EventHandler(this.UserControlHome_Load);
            this.panelBuilds.ResumeLayout(false);
            this.panelBuilds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelClock.ResumeLayout(false);
            this.panelClock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuilds;
        private System.Windows.Forms.Label lblBuildInProgressCounter;
        private System.Windows.Forms.Label lblBuildPendingCounter;
        private System.Windows.Forms.Label lblBuildInProgress;
        private System.Windows.Forms.Label lblBuildPending;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMainPanelBuild;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblBuildCompletedCounter;
        private System.Windows.Forms.Label lblBuildCompleted;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelClock;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDateToday;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
