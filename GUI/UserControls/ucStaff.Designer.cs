namespace GUI.UserControls
{
    partial class ucStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStaff));
            this.lblStaff = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddStaff = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditStaff = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteStaff = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverStaff = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchStaff = new System.Windows.Forms.TextBox();
            this.btnTraCuuStaff = new Syncfusion.WinForms.Controls.SfButton();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.lvwStaff = new System.Windows.Forms.ListView();
            this.colMaNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgSinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCCCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaNQL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboNguoiQuanLy = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortNQL = new System.Windows.Forms.Label();
            this.cboGioiTinh = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortGioiTinh = new System.Windows.Forms.Label();
            this.cboPhongBan = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSorttheoPhong = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboPhanQuyen = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortMaPQ = new System.Windows.Forms.Label();
            this.cboSortStaffID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortStaffID = new System.Windows.Forms.Label();
            this.cboStateAccounts = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblStateAccounts = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguoiQuanLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortStaffID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateAccounts)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStaff
            // 
            this.lblStaff.BackColor = System.Drawing.Color.Lavender;
            this.lblStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStaff.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaff.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblStaff.Location = new System.Drawing.Point(0, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(972, 94);
            this.lblStaff.TabIndex = 35;
            this.lblStaff.Text = "STAFFS LIST";
            this.lblStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddStaff, 0, 0);
            this.tlpController.Controls.Add(this.btnEditStaff, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteStaff, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverStaff, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddStaff.Location = new System.Drawing.Point(3, 3);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(191, 41);
            this.btnAddStaff.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddStaff.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddStaff.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddStaff.TabIndex = 1;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStaff.UseVisualStyleBackColor = false;
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaff.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaff.ForeColor = System.Drawing.Color.White;
            this.btnEditStaff.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditStaff.Location = new System.Drawing.Point(3, 50);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(191, 41);
            this.btnEditStaff.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditStaff.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditStaff.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditStaff.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditStaff.TabIndex = 3;
            this.btnEditStaff.Text = "Sửa";
            this.btnEditStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditStaff.UseVisualStyleBackColor = false;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteStaff.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteStaff.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteStaff.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteStaff.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.TabIndex = 4;
            this.btnDeleteStaff.Text = "Xóa";
            this.btnDeleteStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            // 
            // btnRecoverStaff
            // 
            this.btnRecoverStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverStaff.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverStaff.ForeColor = System.Drawing.Color.White;
            this.btnRecoverStaff.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverStaff.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverStaff.Name = "btnRecoverStaff";
            this.btnRecoverStaff.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverStaff.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverStaff.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverStaff.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverStaff.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverStaff.TabIndex = 5;
            this.btnRecoverStaff.Text = "Khôi phục";
            this.btnRecoverStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverStaff.UseVisualStyleBackColor = false;
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStaff.Location = new System.Drawing.Point(6, 16);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(251, 40);
            this.txtSearchStaff.TabIndex = 2;
            // 
            // btnTraCuuStaff
            // 
            this.btnTraCuuStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuStaff.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuStaff.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuStaff.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuStaff.Name = "btnTraCuuStaff";
            this.btnTraCuuStaff.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuStaff.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuStaff.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuStaff.TabIndex = 0;
            this.btnTraCuuStaff.Text = "Tra cứu";
            this.btnTraCuuStaff.UseVisualStyleBackColor = false;
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
            this.spcQuery.Panel1.Controls.Add(this.lvwStaff);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboNguoiQuanLy);
            this.spcQuery.Panel2.Controls.Add(this.lblSortNQL);
            this.spcQuery.Panel2.Controls.Add(this.cboGioiTinh);
            this.spcQuery.Panel2.Controls.Add(this.lblSortGioiTinh);
            this.spcQuery.Panel2.Controls.Add(this.cboPhongBan);
            this.spcQuery.Panel2.Controls.Add(this.lblSorttheoPhong);
            this.spcQuery.Panel2.Controls.Add(this.dtpNgaySinh);
            this.spcQuery.Panel2.Controls.Add(this.cboPhanQuyen);
            this.spcQuery.Panel2.Controls.Add(this.lblSortMaPQ);
            this.spcQuery.Panel2.Controls.Add(this.cboSortStaffID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortStaffID);
            this.spcQuery.Panel2.Controls.Add(this.cboStateAccounts);
            this.spcQuery.Panel2.Controls.Add(this.lblNgaySinh);
            this.spcQuery.Panel2.Controls.Add(this.lblStateAccounts);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchStaff);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuStaff);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // lvwStaff
            // 
            this.lvwStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNhanVien,
            this.colMaAccount,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgSinh,
            this.colCCCD,
            this.colDiaChi,
            this.colEmail,
            this.colSDT,
            this.colMaNQL});
            this.lvwStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwStaff.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwStaff.FullRowSelect = true;
            this.lvwStaff.GridLines = true;
            this.lvwStaff.HideSelection = false;
            this.lvwStaff.Location = new System.Drawing.Point(0, 0);
            this.lvwStaff.MultiSelect = false;
            this.lvwStaff.Name = "lvwStaff";
            this.lvwStaff.Size = new System.Drawing.Size(973, 746);
            this.lvwStaff.TabIndex = 0;
            this.lvwStaff.UseCompatibleStateImageBehavior = false;
            this.lvwStaff.View = System.Windows.Forms.View.Details;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.Text = "Mã Nhân Viên";
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
            // colMaNQL
            // 
            this.colMaNQL.Text = "Quản lý";
            // 
            // cboNguoiQuanLy
            // 
            this.cboNguoiQuanLy.DelimiterChar = "";
            this.cboNguoiQuanLy.DisplayMember = "";
            this.cboNguoiQuanLy.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboNguoiQuanLy.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboNguoiQuanLy.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNguoiQuanLy.Location = new System.Drawing.Point(226, 365);
            this.cboNguoiQuanLy.Name = "cboNguoiQuanLy";
            this.cboNguoiQuanLy.Size = new System.Drawing.Size(156, 33);
            this.cboNguoiQuanLy.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboNguoiQuanLy.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNguoiQuanLy.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNguoiQuanLy.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboNguoiQuanLy.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNguoiQuanLy.TabIndex = 38;
            // 
            // lblSortNQL
            // 
            this.lblSortNQL.AutoSize = true;
            this.lblSortNQL.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortNQL.Location = new System.Drawing.Point(3, 372);
            this.lblSortNQL.Name = "lblSortNQL";
            this.lblSortNQL.Size = new System.Drawing.Size(149, 26);
            this.lblSortNQL.TabIndex = 37;
            this.lblSortNQL.Text = "Người quản lý";
            this.lblSortNQL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DelimiterChar = "";
            this.cboGioiTinh.DisplayMember = "";
            this.cboGioiTinh.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboGioiTinh.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboGioiTinh.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.Location = new System.Drawing.Point(226, 255);
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
            this.lblSortGioiTinh.Location = new System.Drawing.Point(3, 262);
            this.lblSortGioiTinh.Name = "lblSortGioiTinh";
            this.lblSortGioiTinh.Size = new System.Drawing.Size(183, 26);
            this.lblSortGioiTinh.TabIndex = 35;
            this.lblSortGioiTinh.Text = "Lọc theo giới tính";
            this.lblSortGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DelimiterChar = "";
            this.cboPhongBan.DisplayMember = "";
            this.cboPhongBan.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboPhongBan.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboPhongBan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhongBan.Location = new System.Drawing.Point(226, 197);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(156, 33);
            this.cboPhongBan.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboPhongBan.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhongBan.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhongBan.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboPhongBan.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhongBan.TabIndex = 34;
            // 
            // lblSorttheoPhong
            // 
            this.lblSorttheoPhong.AutoSize = true;
            this.lblSorttheoPhong.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorttheoPhong.Location = new System.Drawing.Point(3, 204);
            this.lblSorttheoPhong.Name = "lblSorttheoPhong";
            this.lblSorttheoPhong.Size = new System.Drawing.Size(166, 26);
            this.lblSorttheoPhong.TabIndex = 33;
            this.lblSorttheoPhong.Text = "Lọc theo Phòng";
            this.lblSorttheoPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(182, 313);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 27);
            this.dtpNgaySinh.TabIndex = 32;
            // 
            // cboPhanQuyen
            // 
            this.cboPhanQuyen.DelimiterChar = "";
            this.cboPhanQuyen.DisplayMember = "";
            this.cboPhanQuyen.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboPhanQuyen.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboPhanQuyen.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanQuyen.Location = new System.Drawing.Point(226, 139);
            this.cboPhanQuyen.Name = "cboPhanQuyen";
            this.cboPhanQuyen.Size = new System.Drawing.Size(156, 33);
            this.cboPhanQuyen.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboPhanQuyen.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanQuyen.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanQuyen.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboPhanQuyen.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanQuyen.TabIndex = 31;
            // 
            // lblSortMaPQ
            // 
            this.lblSortMaPQ.AutoSize = true;
            this.lblSortMaPQ.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortMaPQ.Location = new System.Drawing.Point(3, 146);
            this.lblSortMaPQ.Name = "lblSortMaPQ";
            this.lblSortMaPQ.Size = new System.Drawing.Size(163, 26);
            this.lblSortMaPQ.TabIndex = 30;
            this.lblSortMaPQ.Text = "Lọc theo vai trò";
            this.lblSortMaPQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortStaffID
            // 
            this.cboSortStaffID.DelimiterChar = "";
            this.cboSortStaffID.DisplayMember = "";
            this.cboSortStaffID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortStaffID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortStaffID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortStaffID.Location = new System.Drawing.Point(226, 81);
            this.cboSortStaffID.Name = "cboSortStaffID";
            this.cboSortStaffID.Size = new System.Drawing.Size(156, 33);
            this.cboSortStaffID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortStaffID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortStaffID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortStaffID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortStaffID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortStaffID.TabIndex = 29;
            // 
            // lblSortStaffID
            // 
            this.lblSortStaffID.AutoSize = true;
            this.lblSortStaffID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortStaffID.Location = new System.Drawing.Point(3, 88);
            this.lblSortStaffID.Name = "lblSortStaffID";
            this.lblSortStaffID.Size = new System.Drawing.Size(217, 26);
            this.lblSortStaffID.TabIndex = 28;
            this.lblSortStaffID.Text = "Sort theo ID Account";
            this.lblSortStaffID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStateAccounts
            // 
            this.cboStateAccounts.DelimiterChar = "";
            this.cboStateAccounts.DisplayMember = "";
            this.cboStateAccounts.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateAccounts.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateAccounts.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccounts.Location = new System.Drawing.Point(226, 423);
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
            this.lblNgaySinh.Location = new System.Drawing.Point(3, 314);
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
            this.lblStateAccounts.Location = new System.Drawing.Point(3, 430);
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
            this.spcHeader.Panel1.Controls.Add(this.lblStaff);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucStaff";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucStaff_Load);
            this.tlpController.ResumeLayout(false);
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboNguoiQuanLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortStaffID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateAccounts)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStaff;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuStaff;
        private Syncfusion.WinForms.Controls.SfButton btnAddStaff;
        private System.Windows.Forms.TextBox txtSearchStaff;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteStaff;
        private Syncfusion.WinForms.Controls.SfButton btnEditStaff;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverStaff;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateAccounts;
        private System.Windows.Forms.ListView lvwStaff;
        private System.Windows.Forms.ColumnHeader colMaAccount;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateAccounts;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortStaffID;
        private System.Windows.Forms.Label lblSortStaffID;
        private Syncfusion.WinForms.ListView.SfComboBox cboPhanQuyen;
        private System.Windows.Forms.Label lblSortMaPQ;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private Syncfusion.WinForms.ListView.SfComboBox cboPhongBan;
        private System.Windows.Forms.Label lblSorttheoPhong;
        private Syncfusion.WinForms.ListView.SfComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblSortGioiTinh;
        private System.Windows.Forms.ColumnHeader colMaNhanVien;
        private System.Windows.Forms.ColumnHeader colNgSinh;
        private System.Windows.Forms.ColumnHeader colCCCD;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colSDT;
        private System.Windows.Forms.ColumnHeader colMaNQL;
        private Syncfusion.WinForms.ListView.SfComboBox cboNguoiQuanLy;
        private System.Windows.Forms.Label lblSortNQL;
    }
}
