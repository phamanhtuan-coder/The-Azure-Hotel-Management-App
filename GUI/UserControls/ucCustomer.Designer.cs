namespace GUI.UserControls
{
    partial class ucCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCustomer));
            this.lblCustomer = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnTraCuuCustomer = new Syncfusion.WinForms.Controls.SfButton();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.lvwCustomer = new System.Windows.Forms.ListView();
            this.colMaCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgSinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCCCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboGioiTinh = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortGioiTinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboHangTV = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortHangTV = new System.Windows.Forms.Label();
            this.cboSortCustomerID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortCustomerID = new System.Windows.Forms.Label();
            this.cboStateAccounts = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblStateAccounts = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.btnAddCustomer = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditCustomer = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteCustomer = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverCustomer = new Syncfusion.WinForms.Controls.SfButton();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHangTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateAccounts)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.Color.Lavender;
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomer.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCustomer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCustomer.Location = new System.Drawing.Point(0, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(972, 94);
            this.lblCustomer.TabIndex = 35;
            this.lblCustomer.Text = "CUSTOMERS LIST";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddCustomer, 0, 0);
            this.tlpController.Controls.Add(this.btnEditCustomer, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteCustomer, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverCustomer, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(6, 16);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(251, 40);
            this.txtSearchCustomer.TabIndex = 2;
            // 
            // btnTraCuuCustomer
            // 
            this.btnTraCuuCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuCustomer.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuCustomer.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuCustomer.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuCustomer.Name = "btnTraCuuCustomer";
            this.btnTraCuuCustomer.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuCustomer.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuCustomer.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuCustomer.TabIndex = 0;
            this.btnTraCuuCustomer.Text = "Tra cứu";
            this.btnTraCuuCustomer.UseVisualStyleBackColor = false;
            // 
            // spcQuery
            // 
            this.spcQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcQuery.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcQuery.Location = new System.Drawing.Point(0, 94);
            this.spcQuery.Name = "spcQuery";
            // 
            // spcQuery.Panel1
            // 
            this.spcQuery.Panel1.Controls.Add(this.lvwCustomer);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboGioiTinh);
            this.spcQuery.Panel2.Controls.Add(this.lblSortGioiTinh);
            this.spcQuery.Panel2.Controls.Add(this.dtpNgaySinh);
            this.spcQuery.Panel2.Controls.Add(this.cboHangTV);
            this.spcQuery.Panel2.Controls.Add(this.lblSortHangTV);
            this.spcQuery.Panel2.Controls.Add(this.cboSortCustomerID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortCustomerID);
            this.spcQuery.Panel2.Controls.Add(this.cboStateAccounts);
            this.spcQuery.Panel2.Controls.Add(this.lblNgaySinh);
            this.spcQuery.Panel2.Controls.Add(this.lblStateAccounts);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchCustomer);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuCustomer);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // lvwCustomer
            // 
            this.lvwCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaCustomer,
            this.colMaAccount,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgSinh,
            this.colCCCD,
            this.colDiaChi,
            this.colEmail,
            this.colSDT});
            this.lvwCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCustomer.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwCustomer.FullRowSelect = true;
            this.lvwCustomer.GridLines = true;
            this.lvwCustomer.HideSelection = false;
            this.lvwCustomer.Location = new System.Drawing.Point(0, 0);
            this.lvwCustomer.MultiSelect = false;
            this.lvwCustomer.Name = "lvwCustomer";
            this.lvwCustomer.Size = new System.Drawing.Size(973, 746);
            this.lvwCustomer.TabIndex = 0;
            this.lvwCustomer.UseCompatibleStateImageBehavior = false;
            this.lvwCustomer.View = System.Windows.Forms.View.Details;
            // 
            // colMaCustomer
            // 
            this.colMaCustomer.Text = "Mã Nhân Viên";
            // 
            // colMaAccount
            // 
            this.colMaAccount.Text = "Mã tài khoản";
            this.colMaAccount.Width = 81;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ và Tên";
            this.colHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHoTen.Width = 207;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới Tính";
            this.colGioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGioiTinh.Width = 179;
            // 
            // colNgSinh
            // 
            this.colNgSinh.Text = "Ngày sinh";
            // 
            // colCCCD
            // 
            this.colCCCD.Text = "CCCD";
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            // 
            // colSDT
            // 
            this.colSDT.Text = "SDT";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DelimiterChar = "";
            this.cboGioiTinh.DisplayMember = "";
            this.cboGioiTinh.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboGioiTinh.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboGioiTinh.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.Location = new System.Drawing.Point(226, 197);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(156, 33);
            this.cboGioiTinh.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboGioiTinh.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboGioiTinh.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.TabIndex = 36;
            // 
            // lblSortGioiTinh
            // 
            this.lblSortGioiTinh.AutoSize = true;
            this.lblSortGioiTinh.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortGioiTinh.Location = new System.Drawing.Point(3, 204);
            this.lblSortGioiTinh.Name = "lblSortGioiTinh";
            this.lblSortGioiTinh.Size = new System.Drawing.Size(183, 26);
            this.lblSortGioiTinh.TabIndex = 35;
            this.lblSortGioiTinh.Text = "Lọc theo giới tính";
            this.lblSortGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(182, 255);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 27);
            this.dtpNgaySinh.TabIndex = 32;
            // 
            // cboHangTV
            // 
            this.cboHangTV.DelimiterChar = "";
            this.cboHangTV.DisplayMember = "";
            this.cboHangTV.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboHangTV.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboHangTV.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHangTV.Location = new System.Drawing.Point(226, 139);
            this.cboHangTV.Name = "cboHangTV";
            this.cboHangTV.Size = new System.Drawing.Size(156, 33);
            this.cboHangTV.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboHangTV.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHangTV.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHangTV.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboHangTV.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHangTV.TabIndex = 31;
            // 
            // lblSortHangTV
            // 
            this.lblSortHangTV.AutoSize = true;
            this.lblSortHangTV.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortHangTV.Location = new System.Drawing.Point(3, 146);
            this.lblSortHangTV.Name = "lblSortHangTV";
            this.lblSortHangTV.Size = new System.Drawing.Size(152, 26);
            this.lblSortHangTV.TabIndex = 30;
            this.lblSortHangTV.Text = "Lọc theo hạng";
            this.lblSortHangTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortCustomerID
            // 
            this.cboSortCustomerID.DelimiterChar = "";
            this.cboSortCustomerID.DisplayMember = "";
            this.cboSortCustomerID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortCustomerID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortCustomerID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortCustomerID.Location = new System.Drawing.Point(226, 81);
            this.cboSortCustomerID.Name = "cboSortCustomerID";
            this.cboSortCustomerID.Size = new System.Drawing.Size(156, 33);
            this.cboSortCustomerID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortCustomerID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortCustomerID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortCustomerID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortCustomerID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortCustomerID.TabIndex = 29;
            // 
            // lblSortCustomerID
            // 
            this.lblSortCustomerID.AutoSize = true;
            this.lblSortCustomerID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortCustomerID.Location = new System.Drawing.Point(3, 88);
            this.lblSortCustomerID.Name = "lblSortCustomerID";
            this.lblSortCustomerID.Size = new System.Drawing.Size(217, 26);
            this.lblSortCustomerID.TabIndex = 28;
            this.lblSortCustomerID.Text = "Sort theo ID Account";
            this.lblSortCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStateAccounts
            // 
            this.cboStateAccounts.DelimiterChar = "";
            this.cboStateAccounts.DisplayMember = "";
            this.cboStateAccounts.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateAccounts.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateAccounts.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccounts.Location = new System.Drawing.Point(226, 307);
            this.cboStateAccounts.Name = "cboStateAccounts";
            this.cboStateAccounts.Size = new System.Drawing.Size(156, 33);
            this.cboStateAccounts.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateAccounts.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccounts.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccounts.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateAccounts.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccounts.TabIndex = 23;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(3, 255);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(110, 26);
            this.lblNgaySinh.TabIndex = 14;
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateAccounts
            // 
            this.lblStateAccounts.AutoSize = true;
            this.lblStateAccounts.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateAccounts.Location = new System.Drawing.Point(3, 315);
            this.lblStateAccounts.Name = "lblStateAccounts";
            this.lblStateAccounts.Size = new System.Drawing.Size(186, 26);
            this.lblStateAccounts.TabIndex = 9;
            this.lblStateAccounts.Text = "Trạng thái dữ liệu";
            this.lblStateAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panUcHeader
            // 
            this.panUcHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(224)))), ((int)(((byte)(155)))));
            this.panUcHeader.Controls.Add(this.spcHeader);
            this.panUcHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panUcHeader.Location = new System.Drawing.Point(0, 0);
            this.panUcHeader.Name = "panUcHeader";
            this.panUcHeader.Size = new System.Drawing.Size(1370, 94);
            this.panUcHeader.TabIndex = 37;
            // 
            // spcHeader
            // 
            this.spcHeader.BackColor = System.Drawing.Color.Lavender;
            this.spcHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcHeader.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcHeader.Location = new System.Drawing.Point(0, 0);
            this.spcHeader.Name = "spcHeader";
            // 
            // spcHeader.Panel1
            // 
            this.spcHeader.Panel1.Controls.Add(this.lblCustomer);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddCustomer.Location = new System.Drawing.Point(3, 3);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(191, 41);
            this.btnAddCustomer.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddCustomer.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddCustomer.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomer.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditCustomer.Location = new System.Drawing.Point(3, 50);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(191, 41);
            this.btnEditCustomer.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditCustomer.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomer.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditCustomer.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditCustomer.TabIndex = 3;
            this.btnEditCustomer.Text = "Sửa";
            this.btnEditCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteCustomer.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteCustomer.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteCustomer.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteCustomer.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.TabIndex = 4;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // btnRecoverCustomer
            // 
            this.btnRecoverCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverCustomer.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverCustomer.ForeColor = System.Drawing.Color.White;
            this.btnRecoverCustomer.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverCustomer.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverCustomer.Name = "btnRecoverCustomer";
            this.btnRecoverCustomer.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverCustomer.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverCustomer.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverCustomer.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverCustomer.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverCustomer.TabIndex = 5;
            this.btnRecoverCustomer.Text = "Khôi phục";
            this.btnRecoverCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverCustomer.UseVisualStyleBackColor = false;
            // 
            // ucCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucCustomer";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucCustomer_Load);
            this.tlpController.ResumeLayout(false);
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHangTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateAccounts)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuCustomer;
        private Syncfusion.WinForms.Controls.SfButton btnAddCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteCustomer;
        private Syncfusion.WinForms.Controls.SfButton btnEditCustomer;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverCustomer;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateAccounts;
        private System.Windows.Forms.ListView lvwCustomer;
        private System.Windows.Forms.ColumnHeader colMaAccount;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateAccounts;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortCustomerID;
        private System.Windows.Forms.Label lblSortCustomerID;
        private Syncfusion.WinForms.ListView.SfComboBox cboHangTV;
        private System.Windows.Forms.Label lblSortHangTV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private Syncfusion.WinForms.ListView.SfComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblSortGioiTinh;
        private System.Windows.Forms.ColumnHeader colMaCustomer;
        private System.Windows.Forms.ColumnHeader colNgSinh;
        private System.Windows.Forms.ColumnHeader colCCCD;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colSDT;
    }
}
