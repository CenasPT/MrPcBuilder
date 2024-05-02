namespace MrPcBuilder_project
{
    partial class NewComponentControl
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
            this.btnCancelComponent = new System.Windows.Forms.Button();
            this.cbManufacturerComponent = new System.Windows.Forms.ComboBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.cbTypeComponent = new System.Windows.Forms.ComboBox();
            this.txtDescriptionComponent = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPriceComponent = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModelComponent = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSaveComponent = new System.Windows.Forms.Button();
            this.txtNameComponent = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblNewComponent = new System.Windows.Forms.Label();
            this.panelNewType = new System.Windows.Forms.Panel();
            this.txtNewType = new System.Windows.Forms.TextBox();
            this.btnClearType = new System.Windows.Forms.Button();
            this.btnAddNewType = new System.Windows.Forms.Button();
            this.lblNewTypeName = new System.Windows.Forms.Label();
            this.lblNewType = new System.Windows.Forms.Label();
            this.panelNewManufacturer = new System.Windows.Forms.Panel();
            this.txtManuEmail = new System.Windows.Forms.TextBox();
            this.lblManuEmail = new System.Windows.Forms.Label();
            this.txtManuContact = new System.Windows.Forms.TextBox();
            this.lblManuContact = new System.Windows.Forms.Label();
            this.txtManuName = new System.Windows.Forms.TextBox();
            this.btnClearManu = new System.Windows.Forms.Button();
            this.btnAddNewManu = new System.Windows.Forms.Button();
            this.lblManuName = new System.Windows.Forms.Label();
            this.lblNewManufacturer = new System.Windows.Forms.Label();
            this.panelNewComponent.SuspendLayout();
            this.panelNewType.SuspendLayout();
            this.panelNewManufacturer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNewComponent
            // 
            this.panelNewComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelNewComponent.Controls.Add(this.btnCancelComponent);
            this.panelNewComponent.Controls.Add(this.cbManufacturerComponent);
            this.panelNewComponent.Controls.Add(this.lblManufacturer);
            this.panelNewComponent.Controls.Add(this.cbTypeComponent);
            this.panelNewComponent.Controls.Add(this.txtDescriptionComponent);
            this.panelNewComponent.Controls.Add(this.lblDescription);
            this.panelNewComponent.Controls.Add(this.lblPrice);
            this.panelNewComponent.Controls.Add(this.txtPriceComponent);
            this.panelNewComponent.Controls.Add(this.lblModel);
            this.panelNewComponent.Controls.Add(this.txtModelComponent);
            this.panelNewComponent.Controls.Add(this.lblName);
            this.panelNewComponent.Controls.Add(this.btnSaveComponent);
            this.panelNewComponent.Controls.Add(this.txtNameComponent);
            this.panelNewComponent.Controls.Add(this.lblType);
            this.panelNewComponent.Controls.Add(this.lblNewComponent);
            this.panelNewComponent.Location = new System.Drawing.Point(22, 25);
            this.panelNewComponent.Name = "panelNewComponent";
            this.panelNewComponent.Size = new System.Drawing.Size(363, 573);
            this.panelNewComponent.TabIndex = 0;
            // 
            // btnCancelComponent
            // 
            this.btnCancelComponent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelComponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCancelComponent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelComponent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelComponent.ForeColor = System.Drawing.Color.White;
            this.btnCancelComponent.Location = new System.Drawing.Point(192, 519);
            this.btnCancelComponent.Name = "btnCancelComponent";
            this.btnCancelComponent.Size = new System.Drawing.Size(138, 27);
            this.btnCancelComponent.TabIndex = 14;
            this.btnCancelComponent.Text = "Cancel";
            this.btnCancelComponent.UseVisualStyleBackColor = true;
            this.btnCancelComponent.Click += new System.EventHandler(this.btnRefreshComponent_Click);
            // 
            // cbManufacturerComponent
            // 
            this.cbManufacturerComponent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbManufacturerComponent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbManufacturerComponent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbManufacturerComponent.FormattingEnabled = true;
            this.cbManufacturerComponent.Location = new System.Drawing.Point(28, 112);
            this.cbManufacturerComponent.Name = "cbManufacturerComponent";
            this.cbManufacturerComponent.Size = new System.Drawing.Size(306, 21);
            this.cbManufacturerComponent.TabIndex = 4;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.ForeColor = System.Drawing.Color.White;
            this.lblManufacturer.Location = new System.Drawing.Point(32, 94);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(71, 13);
            this.lblManufacturer.TabIndex = 3;
            this.lblManufacturer.Text = "Manufaturer *";
            // 
            // cbTypeComponent
            // 
            this.cbTypeComponent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTypeComponent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTypeComponent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTypeComponent.FormattingEnabled = true;
            this.cbTypeComponent.Location = new System.Drawing.Point(28, 69);
            this.cbTypeComponent.Name = "cbTypeComponent";
            this.cbTypeComponent.Size = new System.Drawing.Size(306, 21);
            this.cbTypeComponent.TabIndex = 2;
            // 
            // txtDescriptionComponent
            // 
            this.txtDescriptionComponent.Location = new System.Drawing.Point(28, 283);
            this.txtDescriptionComponent.MaxLength = 250;
            this.txtDescriptionComponent.Multiline = true;
            this.txtDescriptionComponent.Name = "txtDescriptionComponent";
            this.txtDescriptionComponent.Size = new System.Drawing.Size(306, 204);
            this.txtDescriptionComponent.TabIndex = 12;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(32, 267);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 13);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description *";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(32, 223);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price *";
            // 
            // txtPriceComponent
            // 
            this.txtPriceComponent.Location = new System.Drawing.Point(28, 241);
            this.txtPriceComponent.MaxLength = 8;
            this.txtPriceComponent.Name = "txtPriceComponent";
            this.txtPriceComponent.Size = new System.Drawing.Size(306, 20);
            this.txtPriceComponent.TabIndex = 10;
            this.txtPriceComponent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceComponent_KeyPress);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.Color.White;
            this.lblModel.Location = new System.Drawing.Point(32, 179);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(43, 13);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model *";
            // 
            // txtModelComponent
            // 
            this.txtModelComponent.Location = new System.Drawing.Point(28, 197);
            this.txtModelComponent.MaxLength = 100;
            this.txtModelComponent.Name = "txtModelComponent";
            this.txtModelComponent.Size = new System.Drawing.Size(306, 20);
            this.txtModelComponent.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(32, 136);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name *";
            // 
            // btnSaveComponent
            // 
            this.btnSaveComponent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveComponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSaveComponent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveComponent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveComponent.ForeColor = System.Drawing.Color.White;
            this.btnSaveComponent.Location = new System.Drawing.Point(28, 519);
            this.btnSaveComponent.Name = "btnSaveComponent";
            this.btnSaveComponent.Size = new System.Drawing.Size(138, 27);
            this.btnSaveComponent.TabIndex = 13;
            this.btnSaveComponent.Text = "Save";
            this.btnSaveComponent.UseVisualStyleBackColor = true;
            this.btnSaveComponent.Click += new System.EventHandler(this.btnSaveComponent_Click_1);
            // 
            // txtNameComponent
            // 
            this.txtNameComponent.Location = new System.Drawing.Point(28, 154);
            this.txtNameComponent.MaxLength = 100;
            this.txtNameComponent.Name = "txtNameComponent";
            this.txtNameComponent.Size = new System.Drawing.Size(306, 20);
            this.txtNameComponent.TabIndex = 6;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(32, 51);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(38, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type *";
            // 
            // lblNewComponent
            // 
            this.lblNewComponent.AutoSize = true;
            this.lblNewComponent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewComponent.ForeColor = System.Drawing.Color.White;
            this.lblNewComponent.Location = new System.Drawing.Point(115, 23);
            this.lblNewComponent.Name = "lblNewComponent";
            this.lblNewComponent.Size = new System.Drawing.Size(127, 20);
            this.lblNewComponent.TabIndex = 0;
            this.lblNewComponent.Text = "New Component";
            // 
            // panelNewType
            // 
            this.panelNewType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelNewType.Controls.Add(this.txtNewType);
            this.panelNewType.Controls.Add(this.btnClearType);
            this.panelNewType.Controls.Add(this.btnAddNewType);
            this.panelNewType.Controls.Add(this.lblNewTypeName);
            this.panelNewType.Controls.Add(this.lblNewType);
            this.panelNewType.Location = new System.Drawing.Point(433, 71);
            this.panelNewType.Name = "panelNewType";
            this.panelNewType.Size = new System.Drawing.Size(363, 169);
            this.panelNewType.TabIndex = 1;
            // 
            // txtNewType
            // 
            this.txtNewType.Location = new System.Drawing.Point(25, 73);
            this.txtNewType.MaxLength = 100;
            this.txtNewType.Name = "txtNewType";
            this.txtNewType.Size = new System.Drawing.Size(306, 20);
            this.txtNewType.TabIndex = 2;
            // 
            // btnClearType
            // 
            this.btnClearType.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnClearType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearType.ForeColor = System.Drawing.Color.White;
            this.btnClearType.Location = new System.Drawing.Point(193, 111);
            this.btnClearType.Name = "btnClearType";
            this.btnClearType.Size = new System.Drawing.Size(138, 27);
            this.btnClearType.TabIndex = 4;
            this.btnClearType.Text = "Refresh / Clear";
            this.btnClearType.UseVisualStyleBackColor = true;
            this.btnClearType.Click += new System.EventHandler(this.btnClearType_Click);
            // 
            // btnAddNewType
            // 
            this.btnAddNewType.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAddNewType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewType.ForeColor = System.Drawing.Color.White;
            this.btnAddNewType.Location = new System.Drawing.Point(25, 111);
            this.btnAddNewType.Name = "btnAddNewType";
            this.btnAddNewType.Size = new System.Drawing.Size(138, 27);
            this.btnAddNewType.TabIndex = 3;
            this.btnAddNewType.Text = "Add";
            this.btnAddNewType.UseVisualStyleBackColor = true;
            this.btnAddNewType.Click += new System.EventHandler(this.btnAddNewType_Click);
            // 
            // lblNewTypeName
            // 
            this.lblNewTypeName.AutoSize = true;
            this.lblNewTypeName.ForeColor = System.Drawing.Color.White;
            this.lblNewTypeName.Location = new System.Drawing.Point(29, 54);
            this.lblNewTypeName.Name = "lblNewTypeName";
            this.lblNewTypeName.Size = new System.Drawing.Size(42, 13);
            this.lblNewTypeName.TabIndex = 1;
            this.lblNewTypeName.Text = "Name *";
            // 
            // lblNewType
            // 
            this.lblNewType.AutoSize = true;
            this.lblNewType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewType.ForeColor = System.Drawing.Color.White;
            this.lblNewType.Location = new System.Drawing.Point(91, 21);
            this.lblNewType.Name = "lblNewType";
            this.lblNewType.Size = new System.Drawing.Size(183, 20);
            this.lblNewType.TabIndex = 0;
            this.lblNewType.Text = "New Type of Component";
            // 
            // panelNewManufacturer
            // 
            this.panelNewManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelNewManufacturer.Controls.Add(this.txtManuEmail);
            this.panelNewManufacturer.Controls.Add(this.lblManuEmail);
            this.panelNewManufacturer.Controls.Add(this.txtManuContact);
            this.panelNewManufacturer.Controls.Add(this.lblManuContact);
            this.panelNewManufacturer.Controls.Add(this.txtManuName);
            this.panelNewManufacturer.Controls.Add(this.btnClearManu);
            this.panelNewManufacturer.Controls.Add(this.btnAddNewManu);
            this.panelNewManufacturer.Controls.Add(this.lblManuName);
            this.panelNewManufacturer.Controls.Add(this.lblNewManufacturer);
            this.panelNewManufacturer.Location = new System.Drawing.Point(433, 287);
            this.panelNewManufacturer.Name = "panelNewManufacturer";
            this.panelNewManufacturer.Size = new System.Drawing.Size(363, 269);
            this.panelNewManufacturer.TabIndex = 2;
            // 
            // txtManuEmail
            // 
            this.txtManuEmail.Location = new System.Drawing.Point(25, 166);
            this.txtManuEmail.MaxLength = 255;
            this.txtManuEmail.Name = "txtManuEmail";
            this.txtManuEmail.Size = new System.Drawing.Size(306, 20);
            this.txtManuEmail.TabIndex = 6;
            // 
            // lblManuEmail
            // 
            this.lblManuEmail.AutoSize = true;
            this.lblManuEmail.ForeColor = System.Drawing.Color.White;
            this.lblManuEmail.Location = new System.Drawing.Point(29, 148);
            this.lblManuEmail.Name = "lblManuEmail";
            this.lblManuEmail.Size = new System.Drawing.Size(32, 13);
            this.lblManuEmail.TabIndex = 5;
            this.lblManuEmail.Text = "Email";
            // 
            // txtManuContact
            // 
            this.txtManuContact.Location = new System.Drawing.Point(25, 118);
            this.txtManuContact.MaxLength = 15;
            this.txtManuContact.Name = "txtManuContact";
            this.txtManuContact.Size = new System.Drawing.Size(306, 20);
            this.txtManuContact.TabIndex = 4;
            this.txtManuContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManuContact_KeyPress);
            // 
            // lblManuContact
            // 
            this.lblManuContact.AutoSize = true;
            this.lblManuContact.ForeColor = System.Drawing.Color.White;
            this.lblManuContact.Location = new System.Drawing.Point(29, 100);
            this.lblManuContact.Name = "lblManuContact";
            this.lblManuContact.Size = new System.Drawing.Size(89, 13);
            this.lblManuContact.TabIndex = 3;
            this.lblManuContact.Text = "Contact ( phone )";
            // 
            // txtManuName
            // 
            this.txtManuName.Location = new System.Drawing.Point(25, 73);
            this.txtManuName.MaxLength = 100;
            this.txtManuName.Name = "txtManuName";
            this.txtManuName.Size = new System.Drawing.Size(306, 20);
            this.txtManuName.TabIndex = 2;
            // 
            // btnClearManu
            // 
            this.btnClearManu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearManu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnClearManu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearManu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearManu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearManu.ForeColor = System.Drawing.Color.White;
            this.btnClearManu.Location = new System.Drawing.Point(193, 210);
            this.btnClearManu.Name = "btnClearManu";
            this.btnClearManu.Size = new System.Drawing.Size(138, 27);
            this.btnClearManu.TabIndex = 8;
            this.btnClearManu.Text = "Refresh / Clear";
            this.btnClearManu.UseVisualStyleBackColor = true;
            this.btnClearManu.Click += new System.EventHandler(this.btnClearManu_Click);
            // 
            // btnAddNewManu
            // 
            this.btnAddNewManu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewManu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAddNewManu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewManu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewManu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewManu.ForeColor = System.Drawing.Color.White;
            this.btnAddNewManu.Location = new System.Drawing.Point(25, 210);
            this.btnAddNewManu.Name = "btnAddNewManu";
            this.btnAddNewManu.Size = new System.Drawing.Size(138, 27);
            this.btnAddNewManu.TabIndex = 7;
            this.btnAddNewManu.Text = "Add";
            this.btnAddNewManu.UseVisualStyleBackColor = true;
            this.btnAddNewManu.Click += new System.EventHandler(this.btnAddNewManu_Click);
            // 
            // lblManuName
            // 
            this.lblManuName.AutoSize = true;
            this.lblManuName.ForeColor = System.Drawing.Color.White;
            this.lblManuName.Location = new System.Drawing.Point(29, 55);
            this.lblManuName.Name = "lblManuName";
            this.lblManuName.Size = new System.Drawing.Size(42, 13);
            this.lblManuName.TabIndex = 1;
            this.lblManuName.Text = "Name *";
            // 
            // lblNewManufacturer
            // 
            this.lblNewManufacturer.AutoSize = true;
            this.lblNewManufacturer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewManufacturer.ForeColor = System.Drawing.Color.White;
            this.lblNewManufacturer.Location = new System.Drawing.Point(106, 21);
            this.lblNewManufacturer.Name = "lblNewManufacturer";
            this.lblNewManufacturer.Size = new System.Drawing.Size(141, 20);
            this.lblNewManufacturer.TabIndex = 0;
            this.lblNewManufacturer.Text = "New Manufacturer";
            // 
            // NewComponentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNewManufacturer);
            this.Controls.Add(this.panelNewType);
            this.Controls.Add(this.panelNewComponent);
            this.Name = "NewComponentControl";
            this.Size = new System.Drawing.Size(882, 652);
            this.Load += new System.EventHandler(this.NewComponentControl_Load);
            this.panelNewComponent.ResumeLayout(false);
            this.panelNewComponent.PerformLayout();
            this.panelNewType.ResumeLayout(false);
            this.panelNewType.PerformLayout();
            this.panelNewManufacturer.ResumeLayout(false);
            this.panelNewManufacturer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewComponent;
        private System.Windows.Forms.Button btnCancelComponent;
        private System.Windows.Forms.ComboBox cbManufacturerComponent;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.ComboBox cbTypeComponent;
        private System.Windows.Forms.TextBox txtDescriptionComponent;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPriceComponent;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModelComponent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSaveComponent;
        private System.Windows.Forms.TextBox txtNameComponent;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblNewComponent;
        private System.Windows.Forms.Panel panelNewType;
        private System.Windows.Forms.TextBox txtNewType;
        private System.Windows.Forms.Button btnClearType;
        private System.Windows.Forms.Button btnAddNewType;
        private System.Windows.Forms.Label lblNewTypeName;
        private System.Windows.Forms.Label lblNewType;
        private System.Windows.Forms.Panel panelNewManufacturer;
        private System.Windows.Forms.Button btnClearManu;
        private System.Windows.Forms.Button btnAddNewManu;
        private System.Windows.Forms.Label lblManuName;
        private System.Windows.Forms.Label lblNewManufacturer;
        private System.Windows.Forms.TextBox txtManuName;
        private System.Windows.Forms.TextBox txtManuEmail;
        private System.Windows.Forms.Label lblManuEmail;
        private System.Windows.Forms.TextBox txtManuContact;
        private System.Windows.Forms.Label lblManuContact;
    }
}
