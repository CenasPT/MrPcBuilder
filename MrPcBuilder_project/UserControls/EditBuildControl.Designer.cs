namespace MrPcBuilder_project
{
    partial class EditBuildControl
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
            this.panelAddComponent = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteComponent = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudBuildID = new System.Windows.Forms.NumericUpDown();
            this.lblQuantityComponent = new System.Windows.Forms.Label();
            this.txtModelComponent = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtManufaturerComponent = new System.Windows.Forms.TextBox();
            this.txtPriceComponent = new System.Windows.Forms.TextBox();
            this.lblSearchBuild = new System.Windows.Forms.Label();
            this.lblPriceComponent = new System.Windows.Forms.Label();
            this.lblManufacturerComponent = new System.Windows.Forms.Label();
            this.lblModelComponent = new System.Windows.Forms.Label();
            this.cbNameComponent = new System.Windows.Forms.ComboBox();
            this.cbTypeComponent = new System.Windows.Forms.ComboBox();
            this.btnRefreshAddComponent = new System.Windows.Forms.Button();
            this.lblNameComponent = new System.Windows.Forms.Label();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.lblTypeComponent = new System.Windows.Forms.Label();
            this.panelNewBuild = new System.Windows.Forms.Panel();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPM = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblBuilder = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtTotalQuantity = new System.Windows.Forms.TextBox();
            this.listViewBuild = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.btnRefreshBuild = new System.Windows.Forms.Button();
            this.btnSaveBuild = new System.Windows.Forms.Button();
            this.panelAddComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuildID)).BeginInit();
            this.panelNewBuild.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddComponent
            // 
            this.panelAddComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelAddComponent.Controls.Add(this.btnSearch);
            this.panelAddComponent.Controls.Add(this.btnDeleteComponent);
            this.panelAddComponent.Controls.Add(this.nudQuantity);
            this.panelAddComponent.Controls.Add(this.nudBuildID);
            this.panelAddComponent.Controls.Add(this.lblQuantityComponent);
            this.panelAddComponent.Controls.Add(this.txtModelComponent);
            this.panelAddComponent.Controls.Add(this.lblID);
            this.panelAddComponent.Controls.Add(this.txtManufaturerComponent);
            this.panelAddComponent.Controls.Add(this.txtPriceComponent);
            this.panelAddComponent.Controls.Add(this.lblSearchBuild);
            this.panelAddComponent.Controls.Add(this.lblPriceComponent);
            this.panelAddComponent.Controls.Add(this.lblManufacturerComponent);
            this.panelAddComponent.Controls.Add(this.lblModelComponent);
            this.panelAddComponent.Controls.Add(this.cbNameComponent);
            this.panelAddComponent.Controls.Add(this.cbTypeComponent);
            this.panelAddComponent.Controls.Add(this.btnRefreshAddComponent);
            this.panelAddComponent.Controls.Add(this.lblNameComponent);
            this.panelAddComponent.Controls.Add(this.btnAddComponent);
            this.panelAddComponent.Controls.Add(this.lblTypeComponent);
            this.panelAddComponent.Location = new System.Drawing.Point(3, 10);
            this.panelAddComponent.Name = "panelAddComponent";
            this.panelAddComponent.Size = new System.Drawing.Size(876, 166);
            this.panelAddComponent.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(136, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteComponent
            // 
            this.btnDeleteComponent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteComponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDeleteComponent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteComponent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteComponent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteComponent.Location = new System.Drawing.Point(352, 119);
            this.btnDeleteComponent.Name = "btnDeleteComponent";
            this.btnDeleteComponent.Size = new System.Drawing.Size(138, 27);
            this.btnDeleteComponent.TabIndex = 18;
            this.btnDeleteComponent.Text = "Delete Component";
            this.btnDeleteComponent.UseVisualStyleBackColor = true;
            this.btnDeleteComponent.Click += new System.EventHandler(this.btnDeleteComponent_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(536, 126);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(53, 20);
            this.nudQuantity.TabIndex = 15;
            // 
            // nudBuildID
            // 
            this.nudBuildID.Location = new System.Drawing.Point(53, 63);
            this.nudBuildID.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudBuildID.Name = "nudBuildID";
            this.nudBuildID.Size = new System.Drawing.Size(68, 20);
            this.nudBuildID.TabIndex = 2;
            // 
            // lblQuantityComponent
            // 
            this.lblQuantityComponent.AutoSize = true;
            this.lblQuantityComponent.ForeColor = System.Drawing.Color.White;
            this.lblQuantityComponent.Location = new System.Drawing.Point(538, 108);
            this.lblQuantityComponent.Name = "lblQuantityComponent";
            this.lblQuantityComponent.Size = new System.Drawing.Size(46, 13);
            this.lblQuantityComponent.TabIndex = 14;
            this.lblQuantityComponent.Text = "Quantity";
            // 
            // txtModelComponent
            // 
            this.txtModelComponent.Location = new System.Drawing.Point(612, 81);
            this.txtModelComponent.MaxLength = 100;
            this.txtModelComponent.Name = "txtModelComponent";
            this.txtModelComponent.Size = new System.Drawing.Size(235, 20);
            this.txtModelComponent.TabIndex = 11;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(63, 43);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(44, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Build ID";
            // 
            // txtManufaturerComponent
            // 
            this.txtManufaturerComponent.Location = new System.Drawing.Point(352, 81);
            this.txtManufaturerComponent.MaxLength = 100;
            this.txtManufaturerComponent.Name = "txtManufaturerComponent";
            this.txtManufaturerComponent.Size = new System.Drawing.Size(235, 20);
            this.txtManufaturerComponent.TabIndex = 7;
            // 
            // txtPriceComponent
            // 
            this.txtPriceComponent.Location = new System.Drawing.Point(612, 126);
            this.txtPriceComponent.MaxLength = 8;
            this.txtPriceComponent.Name = "txtPriceComponent";
            this.txtPriceComponent.Size = new System.Drawing.Size(235, 20);
            this.txtPriceComponent.TabIndex = 13;
            // 
            // lblSearchBuild
            // 
            this.lblSearchBuild.AutoSize = true;
            this.lblSearchBuild.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBuild.ForeColor = System.Drawing.Color.White;
            this.lblSearchBuild.Location = new System.Drawing.Point(114, 14);
            this.lblSearchBuild.Name = "lblSearchBuild";
            this.lblSearchBuild.Size = new System.Drawing.Size(95, 20);
            this.lblSearchBuild.TabIndex = 0;
            this.lblSearchBuild.Text = "Search Build";
            // 
            // lblPriceComponent
            // 
            this.lblPriceComponent.AutoSize = true;
            this.lblPriceComponent.ForeColor = System.Drawing.Color.White;
            this.lblPriceComponent.Location = new System.Drawing.Point(616, 107);
            this.lblPriceComponent.Name = "lblPriceComponent";
            this.lblPriceComponent.Size = new System.Drawing.Size(31, 13);
            this.lblPriceComponent.TabIndex = 12;
            this.lblPriceComponent.Text = "Price";
            // 
            // lblManufacturerComponent
            // 
            this.lblManufacturerComponent.AutoSize = true;
            this.lblManufacturerComponent.ForeColor = System.Drawing.Color.White;
            this.lblManufacturerComponent.Location = new System.Drawing.Point(356, 62);
            this.lblManufacturerComponent.Name = "lblManufacturerComponent";
            this.lblManufacturerComponent.Size = new System.Drawing.Size(70, 13);
            this.lblManufacturerComponent.TabIndex = 6;
            this.lblManufacturerComponent.Text = "Manufacturer";
            // 
            // lblModelComponent
            // 
            this.lblModelComponent.AutoSize = true;
            this.lblModelComponent.ForeColor = System.Drawing.Color.White;
            this.lblModelComponent.Location = new System.Drawing.Point(616, 61);
            this.lblModelComponent.Name = "lblModelComponent";
            this.lblModelComponent.Size = new System.Drawing.Size(36, 13);
            this.lblModelComponent.TabIndex = 10;
            this.lblModelComponent.Text = "Model";
            // 
            // cbNameComponent
            // 
            this.cbNameComponent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNameComponent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNameComponent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbNameComponent.FormattingEnabled = true;
            this.cbNameComponent.Location = new System.Drawing.Point(612, 33);
            this.cbNameComponent.Name = "cbNameComponent";
            this.cbNameComponent.Size = new System.Drawing.Size(235, 21);
            this.cbNameComponent.TabIndex = 9;
            this.cbNameComponent.SelectedIndexChanged += new System.EventHandler(this.cbNameComponent_SelectedIndexChanged);
            // 
            // cbTypeComponent
            // 
            this.cbTypeComponent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTypeComponent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTypeComponent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTypeComponent.FormattingEnabled = true;
            this.cbTypeComponent.Location = new System.Drawing.Point(352, 34);
            this.cbTypeComponent.Name = "cbTypeComponent";
            this.cbTypeComponent.Size = new System.Drawing.Size(235, 21);
            this.cbTypeComponent.TabIndex = 5;
            this.cbTypeComponent.SelectedIndexChanged += new System.EventHandler(this.cbTypeComponent_SelectedIndexChanged);
            // 
            // btnRefreshAddComponent
            // 
            this.btnRefreshAddComponent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefreshAddComponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRefreshAddComponent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefreshAddComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshAddComponent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshAddComponent.ForeColor = System.Drawing.Color.White;
            this.btnRefreshAddComponent.Location = new System.Drawing.Point(188, 119);
            this.btnRefreshAddComponent.Name = "btnRefreshAddComponent";
            this.btnRefreshAddComponent.Size = new System.Drawing.Size(138, 27);
            this.btnRefreshAddComponent.TabIndex = 17;
            this.btnRefreshAddComponent.Text = "Refresh / Clear";
            this.btnRefreshAddComponent.UseVisualStyleBackColor = true;
            this.btnRefreshAddComponent.Click += new System.EventHandler(this.btnRefreshAddComponent_Click);
            // 
            // lblNameComponent
            // 
            this.lblNameComponent.AutoSize = true;
            this.lblNameComponent.ForeColor = System.Drawing.Color.White;
            this.lblNameComponent.Location = new System.Drawing.Point(616, 14);
            this.lblNameComponent.Name = "lblNameComponent";
            this.lblNameComponent.Size = new System.Drawing.Size(42, 13);
            this.lblNameComponent.TabIndex = 8;
            this.lblNameComponent.Text = "Name *";
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddComponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAddComponent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComponent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComponent.ForeColor = System.Drawing.Color.White;
            this.btnAddComponent.Location = new System.Drawing.Point(26, 119);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(138, 27);
            this.btnAddComponent.TabIndex = 16;
            this.btnAddComponent.Text = "Add";
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // lblTypeComponent
            // 
            this.lblTypeComponent.AutoSize = true;
            this.lblTypeComponent.ForeColor = System.Drawing.Color.White;
            this.lblTypeComponent.Location = new System.Drawing.Point(356, 16);
            this.lblTypeComponent.Name = "lblTypeComponent";
            this.lblTypeComponent.Size = new System.Drawing.Size(38, 13);
            this.lblTypeComponent.TabIndex = 4;
            this.lblTypeComponent.Text = "Type *";
            // 
            // panelNewBuild
            // 
            this.panelNewBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelNewBuild.Controls.Add(this.btnCancelEdit);
            this.panelNewBuild.Controls.Add(this.cbStatus);
            this.panelNewBuild.Controls.Add(this.lblStatus);
            this.panelNewBuild.Controls.Add(this.cbPaymentMethod);
            this.panelNewBuild.Controls.Add(this.lblPM);
            this.panelNewBuild.Controls.Add(this.dtpOrderDate);
            this.panelNewBuild.Controls.Add(this.dtpDeliveryDate);
            this.panelNewBuild.Controls.Add(this.lblDeliveryDate);
            this.panelNewBuild.Controls.Add(this.lblOrderDate);
            this.panelNewBuild.Controls.Add(this.txtTotalPrice);
            this.panelNewBuild.Controls.Add(this.cbEmployees);
            this.panelNewBuild.Controls.Add(this.cbCustomers);
            this.panelNewBuild.Controls.Add(this.lblTotalPrice);
            this.panelNewBuild.Controls.Add(this.lblBuilder);
            this.panelNewBuild.Controls.Add(this.lblCustomer);
            this.panelNewBuild.Controls.Add(this.txtTotalQuantity);
            this.panelNewBuild.Controls.Add(this.listViewBuild);
            this.panelNewBuild.Controls.Add(this.lblTotalQuantity);
            this.panelNewBuild.Controls.Add(this.btnRefreshBuild);
            this.panelNewBuild.Controls.Add(this.btnSaveBuild);
            this.panelNewBuild.Location = new System.Drawing.Point(3, 177);
            this.panelNewBuild.Name = "panelNewBuild";
            this.panelNewBuild.Size = new System.Drawing.Size(876, 472);
            this.panelNewBuild.TabIndex = 1;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCancelEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Location = new System.Drawing.Point(349, 424);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(138, 27);
            this.btnCancelEdit.TabIndex = 19;
            this.btnCancelEdit.Text = "Cancel Edit";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Completed"});
            this.cbStatus.Location = new System.Drawing.Point(513, 377);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(195, 21);
            this.cbStatus.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(517, 357);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Build Status *";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPaymentMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Location = new System.Drawing.Point(513, 329);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(195, 21);
            this.cbPaymentMethod.TabIndex = 10;
            // 
            // lblPM
            // 
            this.lblPM.AutoSize = true;
            this.lblPM.ForeColor = System.Drawing.Color.White;
            this.lblPM.Location = new System.Drawing.Point(517, 309);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(94, 13);
            this.lblPM.TabIndex = 9;
            this.lblPM.Text = "Payment Method *";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "yyyy - MM - dd";
            this.dtpOrderDate.Location = new System.Drawing.Point(286, 377);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtpOrderDate.TabIndex = 8;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.CustomFormat = "yyyy - MM - dd";
            this.dtpDeliveryDate.Location = new System.Drawing.Point(286, 329);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDeliveryDate.TabIndex = 6;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.ForeColor = System.Drawing.Color.White;
            this.lblDeliveryDate.Location = new System.Drawing.Point(290, 309);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(78, 13);
            this.lblDeliveryDate.TabIndex = 5;
            this.lblDeliveryDate.Text = "Delivery Date *";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.ForeColor = System.Drawing.Color.White;
            this.lblOrderDate.Location = new System.Drawing.Point(290, 358);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(59, 13);
            this.lblOrderDate.TabIndex = 7;
            this.lblOrderDate.Text = "Order Date";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(732, 377);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(115, 20);
            this.txtTotalPrice.TabIndex = 16;
            // 
            // cbEmployees
            // 
            this.cbEmployees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmployees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Location = new System.Drawing.Point(26, 377);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(235, 21);
            this.cbEmployees.TabIndex = 4;
            // 
            // cbCustomers
            // 
            this.cbCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(26, 329);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(235, 21);
            this.cbCustomers.TabIndex = 2;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(736, 358);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(58, 13);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // lblBuilder
            // 
            this.lblBuilder.AutoSize = true;
            this.lblBuilder.ForeColor = System.Drawing.Color.White;
            this.lblBuilder.Location = new System.Drawing.Point(30, 357);
            this.lblBuilder.Name = "lblBuilder";
            this.lblBuilder.Size = new System.Drawing.Size(119, 13);
            this.lblBuilder.TabIndex = 3;
            this.lblBuilder.Text = "Builder ( responsible for)";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(30, 311);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(101, 13);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Order by Customer *";
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Location = new System.Drawing.Point(732, 329);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.Size = new System.Drawing.Size(115, 20);
            this.txtTotalQuantity.TabIndex = 14;
            // 
            // listViewBuild
            // 
            this.listViewBuild.BackColor = System.Drawing.SystemColors.Window;
            this.listViewBuild.CheckBoxes = true;
            this.listViewBuild.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewBuild.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewBuild.HideSelection = false;
            this.listViewBuild.Location = new System.Drawing.Point(26, 10);
            this.listViewBuild.Name = "listViewBuild";
            this.listViewBuild.Size = new System.Drawing.Size(821, 291);
            this.listViewBuild.TabIndex = 0;
            this.listViewBuild.UseCompatibleStateImageBehavior = false;
            this.listViewBuild.View = System.Windows.Forms.View.Details;
            this.listViewBuild.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewBuild_ItemCheck);
            this.listViewBuild.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewBuild_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Manufacturer";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Model";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantity";
            this.columnHeader6.Width = 100;
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.ForeColor = System.Drawing.Color.White;
            this.lblTotalQuantity.Location = new System.Drawing.Point(736, 310);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(73, 13);
            this.lblTotalQuantity.TabIndex = 13;
            this.lblTotalQuantity.Text = "Total Quantity";
            // 
            // btnRefreshBuild
            // 
            this.btnRefreshBuild.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefreshBuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRefreshBuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefreshBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshBuild.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshBuild.ForeColor = System.Drawing.Color.White;
            this.btnRefreshBuild.Location = new System.Drawing.Point(187, 424);
            this.btnRefreshBuild.Name = "btnRefreshBuild";
            this.btnRefreshBuild.Size = new System.Drawing.Size(138, 27);
            this.btnRefreshBuild.TabIndex = 18;
            this.btnRefreshBuild.Text = "Refresh";
            this.btnRefreshBuild.UseVisualStyleBackColor = true;
            this.btnRefreshBuild.Click += new System.EventHandler(this.btnRefreshBuild_Click);
            // 
            // btnSaveBuild
            // 
            this.btnSaveBuild.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveBuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSaveBuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBuild.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBuild.ForeColor = System.Drawing.Color.White;
            this.btnSaveBuild.Location = new System.Drawing.Point(26, 424);
            this.btnSaveBuild.Name = "btnSaveBuild";
            this.btnSaveBuild.Size = new System.Drawing.Size(138, 27);
            this.btnSaveBuild.TabIndex = 17;
            this.btnSaveBuild.Text = "Save";
            this.btnSaveBuild.UseVisualStyleBackColor = true;
            this.btnSaveBuild.Click += new System.EventHandler(this.btnSaveBuild_Click);
            // 
            // EditBuildControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAddComponent);
            this.Controls.Add(this.panelNewBuild);
            this.Name = "EditBuildControl";
            this.Size = new System.Drawing.Size(882, 652);
            this.Load += new System.EventHandler(this.EditBuildControl_Load);
            this.panelAddComponent.ResumeLayout(false);
            this.panelAddComponent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuildID)).EndInit();
            this.panelNewBuild.ResumeLayout(false);
            this.panelNewBuild.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddComponent;
        private System.Windows.Forms.Button btnDeleteComponent;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantityComponent;
        private System.Windows.Forms.TextBox txtModelComponent;
        private System.Windows.Forms.TextBox txtManufaturerComponent;
        private System.Windows.Forms.TextBox txtPriceComponent;
        private System.Windows.Forms.Label lblPriceComponent;
        private System.Windows.Forms.Label lblManufacturerComponent;
        private System.Windows.Forms.Label lblModelComponent;
        private System.Windows.Forms.ComboBox cbNameComponent;
        private System.Windows.Forms.ComboBox cbTypeComponent;
        private System.Windows.Forms.Button btnRefreshAddComponent;
        private System.Windows.Forms.Label lblNameComponent;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Label lblTypeComponent;
        private System.Windows.Forms.Panel panelNewBuild;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label lblPM;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalQuantity;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.ComboBox cbEmployees;
        private System.Windows.Forms.ComboBox cbCustomers;
        private System.Windows.Forms.Label lblBuilder;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ListView listViewBuild;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnRefreshBuild;
        private System.Windows.Forms.Button btnSaveBuild;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown nudBuildID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSearchBuild;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}
