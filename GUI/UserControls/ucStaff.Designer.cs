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
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picAvata = new System.Windows.Forms.PictureBox();
            this.cboNguoiQuanLy = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortNQL = new System.Windows.Forms.Label();
            this.cboGioiTinh = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortGioiTinh = new System.Windows.Forms.Label();
            this.cboPhongBan = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSorttheoPhong = new System.Windows.Forms.Label();
            this.cboPhanQuyen = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortMaPQ = new System.Windows.Forms.Label();
            this.cboSortStaffID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortStaffID = new System.Windows.Forms.Label();
            this.cboStateAccounts = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblStateAccounts = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvata)).BeginInit();
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
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnRecoverStaff
            // 
            this.btnRecoverStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnRecoverStaff.Click += new System.EventHandler(this.btnRecoverStaff_Click);
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStaff.Location = new System.Drawing.Point(7, 153);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(208, 38);
            this.txtSearchStaff.TabIndex = 2;
            // 
            // btnTraCuuStaff
            // 
            this.btnTraCuuStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuStaff.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuStaff.Location = new System.Drawing.Point(226, 153);
            this.btnTraCuuStaff.Name = "btnTraCuuStaff";
            this.btnTraCuuStaff.Size = new System.Drawing.Size(156, 40);
            this.btnTraCuuStaff.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuStaff.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuStaff.TabIndex = 0;
            this.btnTraCuuStaff.Text = "Tra cứu";
            this.btnTraCuuStaff.UseVisualStyleBackColor = false;
            this.btnTraCuuStaff.Click += new System.EventHandler(this.btnTraCuuStaff_Click);
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
            this.spcQuery.Panel1.Controls.Add(this.dgvStaff);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.picAvata);
            this.spcQuery.Panel2.Controls.Add(this.cboNguoiQuanLy);
            this.spcQuery.Panel2.Controls.Add(this.lblSortNQL);
            this.spcQuery.Panel2.Controls.Add(this.cboGioiTinh);
            this.spcQuery.Panel2.Controls.Add(this.lblSortGioiTinh);
            this.spcQuery.Panel2.Controls.Add(this.cboPhongBan);
            this.spcQuery.Panel2.Controls.Add(this.lblSorttheoPhong);
            this.spcQuery.Panel2.Controls.Add(this.cboPhanQuyen);
            this.spcQuery.Panel2.Controls.Add(this.lblSortMaPQ);
            this.spcQuery.Panel2.Controls.Add(this.cboSortStaffID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortStaffID);
            this.spcQuery.Panel2.Controls.Add(this.cboStateAccounts);
            this.spcQuery.Panel2.Controls.Add(this.lblStateAccounts);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchStaff);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuStaff);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AllowUserToResizeColumns = false;
            this.dgvStaff.AllowUserToResizeRows = false;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colTTK,
            this.MaNQL,
            this.MaTaiKhoan,
            this.HoTen,
            this.colGioiTinh,
            this.HinhAnh,
            this.SDT,
            this.Email,
            this.CCCD,
            this.NgaySinh,
            this.DiaChi,
            this.Luong,
            this.TrangThai});
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.Location = new System.Drawing.Point(0, 0);
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(973, 746);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.SelectionChanged += new System.EventHandler(this.dgvStaff_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "MaNV";
            this.ID.HeaderText = "Mã nhân viên";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 128;
            // 
            // colTTK
            // 
            this.colTTK.DataPropertyName = "TenTaiKhoan";
            this.colTTK.HeaderText = "Tên tài khoản";
            this.colTTK.Name = "colTTK";
            this.colTTK.Visible = false;
            this.colTTK.Width = 130;
            // 
            // MaNQL
            // 
            this.MaNQL.DataPropertyName = "MaNQL";
            this.MaNQL.HeaderText = "Mã người quản lý";
            this.MaNQL.Name = "MaNQL";
            this.MaNQL.Visible = false;
            this.MaNQL.Width = 153;
            // 
            // MaTaiKhoan
            // 
            this.MaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.MaTaiKhoan.HeaderText = "Mã tài khoản";
            this.MaTaiKhoan.Name = "MaTaiKhoan";
            this.MaTaiKhoan.Visible = false;
            this.MaTaiKhoan.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTenNV";
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 102;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Width = 92;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình ảnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HinhAnh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HinhAnh.Visible = false;
            this.HinhAnh.Width = 98;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.Width = 66;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 73;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.Name = "CCCD";
            this.CCCD.Width = 79;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 103;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 82;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            this.Luong.Width = 79;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 105;
            // 
            // picAvata
            // 
            this.picAvata.Location = new System.Drawing.Point(131, 6);
            this.picAvata.Name = "picAvata";
            this.picAvata.Size = new System.Drawing.Size(147, 131);
            this.picAvata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvata.TabIndex = 39;
            this.picAvata.TabStop = false;
            // 
            // cboNguoiQuanLy
            // 
            this.cboNguoiQuanLy.DelimiterChar = "";
            this.cboNguoiQuanLy.DisplayMember = "";
            this.cboNguoiQuanLy.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboNguoiQuanLy.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboNguoiQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNguoiQuanLy.Location = new System.Drawing.Point(226, 437);
            this.cboNguoiQuanLy.Name = "cboNguoiQuanLy";
            this.cboNguoiQuanLy.Size = new System.Drawing.Size(156, 33);
            this.cboNguoiQuanLy.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboNguoiQuanLy.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNguoiQuanLy.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNguoiQuanLy.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboNguoiQuanLy.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNguoiQuanLy.TabIndex = 38;
            this.cboNguoiQuanLy.SelectedIndexChanged += new System.EventHandler(this.cboNguoiQuanLy_SelectedIndexChanged);
            // 
            // lblSortNQL
            // 
            this.lblSortNQL.AutoSize = true;
            this.lblSortNQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortNQL.Location = new System.Drawing.Point(3, 444);
            this.lblSortNQL.Name = "lblSortNQL";
            this.lblSortNQL.Size = new System.Drawing.Size(140, 24);
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
            this.cboGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.Location = new System.Drawing.Point(226, 383);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(156, 33);
            this.cboGioiTinh.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboGioiTinh.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboGioiTinh.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.TabIndex = 36;
            this.cboGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cboGioiTinh_SelectedIndexChanged);
            // 
            // lblSortGioiTinh
            // 
            this.lblSortGioiTinh.AutoSize = true;
            this.lblSortGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortGioiTinh.Location = new System.Drawing.Point(3, 390);
            this.lblSortGioiTinh.Name = "lblSortGioiTinh";
            this.lblSortGioiTinh.Size = new System.Drawing.Size(171, 24);
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
            this.cboPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhongBan.Location = new System.Drawing.Point(226, 325);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(156, 33);
            this.cboPhongBan.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboPhongBan.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhongBan.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhongBan.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboPhongBan.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhongBan.TabIndex = 34;
            this.cboPhongBan.SelectedIndexChanged += new System.EventHandler(this.cboPhongBan_SelectedIndexChanged);
            // 
            // lblSorttheoPhong
            // 
            this.lblSorttheoPhong.AutoSize = true;
            this.lblSorttheoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorttheoPhong.Location = new System.Drawing.Point(3, 332);
            this.lblSorttheoPhong.Name = "lblSorttheoPhong";
            this.lblSorttheoPhong.Size = new System.Drawing.Size(158, 24);
            this.lblSorttheoPhong.TabIndex = 33;
            this.lblSorttheoPhong.Text = "Lọc theo Phòng";
            this.lblSorttheoPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboPhanQuyen
            // 
            this.cboPhanQuyen.DelimiterChar = "";
            this.cboPhanQuyen.DisplayMember = "";
            this.cboPhanQuyen.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboPhanQuyen.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanQuyen.Location = new System.Drawing.Point(226, 267);
            this.cboPhanQuyen.Name = "cboPhanQuyen";
            this.cboPhanQuyen.Size = new System.Drawing.Size(156, 33);
            this.cboPhanQuyen.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboPhanQuyen.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanQuyen.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanQuyen.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboPhanQuyen.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanQuyen.TabIndex = 31;
            this.cboPhanQuyen.SelectedIndexChanged += new System.EventHandler(this.cboPhanQuyen_SelectedIndexChanged);
            // 
            // lblSortMaPQ
            // 
            this.lblSortMaPQ.AutoSize = true;
            this.lblSortMaPQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortMaPQ.Location = new System.Drawing.Point(3, 274);
            this.lblSortMaPQ.Name = "lblSortMaPQ";
            this.lblSortMaPQ.Size = new System.Drawing.Size(153, 24);
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
            this.cboSortStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortStaffID.Location = new System.Drawing.Point(226, 209);
            this.cboSortStaffID.Name = "cboSortStaffID";
            this.cboSortStaffID.Size = new System.Drawing.Size(156, 33);
            this.cboSortStaffID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortStaffID.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortStaffID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortStaffID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortStaffID.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortStaffID.TabIndex = 29;
            this.cboSortStaffID.SelectedIndexChanged += new System.EventHandler(this.cboSortAccountTypeID_SelectedIndexChanged);
            // 
            // lblSortStaffID
            // 
            this.lblSortStaffID.AutoSize = true;
            this.lblSortStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortStaffID.Location = new System.Drawing.Point(3, 216);
            this.lblSortStaffID.Name = "lblSortStaffID";
            this.lblSortStaffID.Size = new System.Drawing.Size(202, 24);
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
            this.cboStateAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccounts.Location = new System.Drawing.Point(226, 495);
            this.cboStateAccounts.Name = "cboStateAccounts";
            this.cboStateAccounts.Size = new System.Drawing.Size(156, 33);
            this.cboStateAccounts.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateAccounts.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccounts.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccounts.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateAccounts.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccounts.TabIndex = 23;
            this.cboStateAccounts.SelectedIndexChanged += new System.EventHandler(this.cboStateAccounts_SelectedIndexChanged);
            // 
            // lblStateAccounts
            // 
            this.lblStateAccounts.AutoSize = true;
            this.lblStateAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateAccounts.Location = new System.Drawing.Point(3, 502);
            this.lblStateAccounts.Name = "lblStateAccounts";
            this.lblStateAccounts.Size = new System.Drawing.Size(174, 24);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvata)).EndInit();
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
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateAccounts;
        private System.Windows.Forms.Label lblSortStaffID;
        private Syncfusion.WinForms.ListView.SfComboBox cboPhanQuyen;
        private System.Windows.Forms.Label lblSortMaPQ;
        private Syncfusion.WinForms.ListView.SfComboBox cboPhongBan;
        private System.Windows.Forms.Label lblSorttheoPhong;
        private Syncfusion.WinForms.ListView.SfComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblSortGioiTinh;
        private Syncfusion.WinForms.ListView.SfComboBox cboNguoiQuanLy;
        private System.Windows.Forms.Label lblSortNQL;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.PictureBox picAvata;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortStaffID;
    }
}
