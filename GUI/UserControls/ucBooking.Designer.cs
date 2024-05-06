namespace GUI.UserControls
{
    partial class ucBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBooking));
            this.lblBooking = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchBooking = new System.Windows.Forms.TextBox();
            this.btnTraCuuBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateBooking = new Syncfusion.WinForms.ListView.SfComboBox();
            this.dtpBookingDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.colMaDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPHG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhanPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncheckout = new System.Windows.Forms.Button();
            this.btncheckin = new System.Windows.Forms.Button();
            this.cboSortRoomID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboSortBookingID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortRoomId = new System.Windows.Forms.Label();
            this.lblSortBookingID = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblStateBooking = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBookingID)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBooking
            // 
            this.lblBooking.BackColor = System.Drawing.Color.Lavender;
            this.lblBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBooking.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBooking.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBooking.Location = new System.Drawing.Point(0, 0);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(972, 94);
            this.lblBooking.TabIndex = 35;
            this.lblBooking.Text = "BOOKING";
            this.lblBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddBooking, 0, 0);
            this.tlpController.Controls.Add(this.btnEditBooking, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteBooking, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverBooking, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooking.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.ForeColor = System.Drawing.Color.White;
            this.btnAddBooking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddBooking.Location = new System.Drawing.Point(3, 3);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(191, 41);
            this.btnAddBooking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddBooking.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddBooking.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddBooking.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddBooking.TabIndex = 1;
            this.btnAddBooking.Text = "Thêm";
            this.btnAddBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBooking.UseVisualStyleBackColor = false;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBooking.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBooking.ForeColor = System.Drawing.Color.White;
            this.btnEditBooking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditBooking.Location = new System.Drawing.Point(3, 50);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(191, 41);
            this.btnEditBooking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditBooking.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditBooking.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditBooking.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditBooking.TabIndex = 3;
            this.btnEditBooking.Text = "Sửa";
            this.btnEditBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditBooking.UseVisualStyleBackColor = false;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBooking.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBooking.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBooking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteBooking.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteBooking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteBooking.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBooking.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteBooking.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteBooking.TabIndex = 4;
            this.btnDeleteBooking.Text = "Xóa";
            this.btnDeleteBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteBooking.UseVisualStyleBackColor = false;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnRecoverBooking
            // 
            this.btnRecoverBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverBooking.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverBooking.ForeColor = System.Drawing.Color.White;
            this.btnRecoverBooking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverBooking.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverBooking.Name = "btnRecoverBooking";
            this.btnRecoverBooking.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverBooking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverBooking.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverBooking.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverBooking.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverBooking.TabIndex = 5;
            this.btnRecoverBooking.Text = "Khôi phục";
            this.btnRecoverBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverBooking.UseVisualStyleBackColor = false;
            this.btnRecoverBooking.Click += new System.EventHandler(this.btnRecoverBooking_Click);
            // 
            // txtSearchBooking
            // 
            this.txtSearchBooking.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBooking.Location = new System.Drawing.Point(6, 16);
            this.txtSearchBooking.Name = "txtSearchBooking";
            this.txtSearchBooking.Size = new System.Drawing.Size(251, 49);
            this.txtSearchBooking.TabIndex = 2;
            // 
            // btnTraCuuBooking
            // 
            this.btnTraCuuBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuBooking.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuBooking.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuBooking.Location = new System.Drawing.Point(263, 16);
            this.btnTraCuuBooking.Name = "btnTraCuuBooking";
            this.btnTraCuuBooking.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuBooking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuBooking.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuBooking.TabIndex = 0;
            this.btnTraCuuBooking.Text = "Tra cứu";
            this.btnTraCuuBooking.UseVisualStyleBackColor = false;
            this.btnTraCuuBooking.Click += new System.EventHandler(this.btnTraCuuBooking_Click);
            // 
            // cboStateBooking
            // 
            this.cboStateBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateBooking.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateBooking.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateBooking.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Location = new System.Drawing.Point(226, 235);
            this.cboStateBooking.Name = "cboStateBooking";
            this.cboStateBooking.Size = new System.Drawing.Size(156, 33);
            this.cboStateBooking.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateBooking.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateBooking.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.TabIndex = 3;
            this.cboStateBooking.SelectedIndexChanged += new System.EventHandler(this.cboStateBooking_SelectedIndexChanged);
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBookingDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpBookingDate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Location = new System.Drawing.Point(225, 185);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(156, 34);
            this.dtpBookingDate.TabIndex = 6;
            this.dtpBookingDate.ToolTipText = "";
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
            this.spcQuery.Panel1.Controls.Add(this.dgvBooking);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.btncheckout);
            this.spcQuery.Panel2.Controls.Add(this.btncheckin);
            this.spcQuery.Panel2.Controls.Add(this.cboSortRoomID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortBookingID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortRoomId);
            this.spcQuery.Panel2.Controls.Add(this.lblSortBookingID);
            this.spcQuery.Panel2.Controls.Add(this.lblBookingDate);
            this.spcQuery.Panel2.Controls.Add(this.lblStateBooking);
            this.spcQuery.Panel2.Controls.Add(this.dtpBookingDate);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchBooking);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuBooking);
            this.spcQuery.Panel2.Controls.Add(this.cboStateBooking);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.AllowUserToResizeColumns = false;
            this.dgvBooking.AllowUserToResizeRows = false;
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDatPhong,
            this.colMaKH,
            this.colMaPHG,
            this.colNgayDatPhong,
            this.colNgayNhanPhong,
            this.colNgayTraPhong,
            this.colSoLuongKH,
            this.colTrangThai});
            this.dgvBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooking.Location = new System.Drawing.Point(0, 0);
            this.dgvBooking.MultiSelect = false;
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersVisible = false;
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.Size = new System.Drawing.Size(973, 746);
            this.dgvBooking.TabIndex = 0;
            // 
            // colMaDatPhong
            // 
            this.colMaDatPhong.DataPropertyName = "MaDatPhong";
            this.colMaDatPhong.HeaderText = "Mã đặt phòng";
            this.colMaDatPhong.MinimumWidth = 6;
            this.colMaDatPhong.Name = "colMaDatPhong";
            this.colMaDatPhong.ReadOnly = true;
            this.colMaDatPhong.Width = 169;
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "MaKH";
            this.colMaKH.HeaderText = "Mã KH";
            this.colMaKH.MinimumWidth = 6;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.ReadOnly = true;
            this.colMaKH.Width = 72;
            // 
            // colMaPHG
            // 
            this.colMaPHG.DataPropertyName = "MaPHG";
            this.colMaPHG.HeaderText = "Mã PHG";
            this.colMaPHG.MinimumWidth = 6;
            this.colMaPHG.Name = "colMaPHG";
            this.colMaPHG.ReadOnly = true;
            this.colMaPHG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaPHG.Width = 112;
            // 
            // colNgayDatPhong
            // 
            this.colNgayDatPhong.DataPropertyName = "NgayDatPhong";
            this.colNgayDatPhong.HeaderText = "Ngày đặt";
            this.colNgayDatPhong.MinimumWidth = 6;
            this.colNgayDatPhong.Name = "colNgayDatPhong";
            this.colNgayDatPhong.ReadOnly = true;
            this.colNgayDatPhong.Width = 122;
            // 
            // colNgayNhanPhong
            // 
            this.colNgayNhanPhong.DataPropertyName = "NgayNhanPhong";
            this.colNgayNhanPhong.HeaderText = "Ngày nhận phòng";
            this.colNgayNhanPhong.MinimumWidth = 6;
            this.colNgayNhanPhong.Name = "colNgayNhanPhong";
            this.colNgayNhanPhong.ReadOnly = true;
            this.colNgayNhanPhong.Width = 207;
            // 
            // colNgayTraPhong
            // 
            this.colNgayTraPhong.DataPropertyName = "NgayTraPhong";
            this.colNgayTraPhong.HeaderText = "Ngày trả phòng";
            this.colNgayTraPhong.MinimumWidth = 6;
            this.colNgayTraPhong.Name = "colNgayTraPhong";
            this.colNgayTraPhong.ReadOnly = true;
            this.colNgayTraPhong.Width = 182;
            // 
            // colSoLuongKH
            // 
            this.colSoLuongKH.DataPropertyName = "SoLuongKH";
            this.colSoLuongKH.HeaderText = "Số lượng KH";
            this.colSoLuongKH.MinimumWidth = 6;
            this.colSoLuongKH.Name = "colSoLuongKH";
            this.colSoLuongKH.ReadOnly = true;
            this.colSoLuongKH.Width = 152;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 131;
            // 
            // btncheckout
            // 
            this.btncheckout.Location = new System.Drawing.Point(182, 302);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(102, 43);
            this.btncheckout.TabIndex = 26;
            this.btncheckout.Text = "checkout";
            this.btncheckout.UseVisualStyleBackColor = true;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click);
            // 
            // btncheckin
            // 
            this.btncheckin.Location = new System.Drawing.Point(39, 302);
            this.btncheckin.Name = "btncheckin";
            this.btncheckin.Size = new System.Drawing.Size(95, 43);
            this.btncheckin.TabIndex = 25;
            this.btncheckin.Text = "checkin";
            this.btncheckin.UseVisualStyleBackColor = true;
            this.btncheckin.Click += new System.EventHandler(this.btncheckin_Click);
            // 
            // cboSortRoomID
            // 
            this.cboSortRoomID.DelimiterChar = "";
            this.cboSortRoomID.DisplayMember = "";
            this.cboSortRoomID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortRoomID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortRoomID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Location = new System.Drawing.Point(225, 129);
            this.cboSortRoomID.Name = "cboSortRoomID";
            this.cboSortRoomID.Size = new System.Drawing.Size(156, 33);
            this.cboSortRoomID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortRoomID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortRoomID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.TabIndex = 24;
            this.cboSortRoomID.SelectedIndexChanged += new System.EventHandler(this.cboSortRoomID_SelectedIndexChanged);
            // 
            // cboSortBookingID
            // 
            this.cboSortBookingID.DelimiterChar = "";
            this.cboSortBookingID.DisplayMember = "";
            this.cboSortBookingID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortBookingID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortBookingID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Location = new System.Drawing.Point(225, 80);
            this.cboSortBookingID.Name = "cboSortBookingID";
            this.cboSortBookingID.Size = new System.Drawing.Size(156, 33);
            this.cboSortBookingID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortBookingID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortBookingID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.TabIndex = 23;
            this.cboSortBookingID.SelectedIndexChanged += new System.EventHandler(this.cboSortBookingID_SelectedIndexChanged);
            // 
            // lblSortRoomId
            // 
            this.lblSortRoomId.AutoSize = true;
            this.lblSortRoomId.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortRoomId.Location = new System.Drawing.Point(4, 136);
            this.lblSortRoomId.Name = "lblSortRoomId";
            this.lblSortRoomId.Size = new System.Drawing.Size(248, 33);
            this.lblSortRoomId.TabIndex = 16;
            this.lblSortRoomId.Text = "Sort theo Room ID";
            this.lblSortRoomId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSortBookingID
            // 
            this.lblSortBookingID.AutoSize = true;
            this.lblSortBookingID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBookingID.Location = new System.Drawing.Point(4, 80);
            this.lblSortBookingID.Name = "lblSortBookingID";
            this.lblSortBookingID.Size = new System.Drawing.Size(280, 33);
            this.lblSortBookingID.TabIndex = 14;
            this.lblSortBookingID.Text = "Sort theo Booking ID";
            this.lblSortBookingID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.Location = new System.Drawing.Point(5, 193);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(129, 33);
            this.lblBookingDate.TabIndex = 10;
            this.lblBookingDate.Text = "Ngày đặt";
            this.lblBookingDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateBooking
            // 
            this.lblStateBooking.AutoSize = true;
            this.lblStateBooking.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateBooking.Location = new System.Drawing.Point(5, 242);
            this.lblStateBooking.Name = "lblStateBooking";
            this.lblStateBooking.Size = new System.Drawing.Size(237, 33);
            this.lblStateBooking.TabIndex = 9;
            this.lblStateBooking.Text = "Trạng thái dữ liệu";
            this.lblStateBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblBooking);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucBooking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucBooking";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucBooking_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateBooking)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBookingID)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBooking;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuBooking;
        private Syncfusion.WinForms.Controls.SfButton btnAddBooking;
        private System.Windows.Forms.TextBox txtSearchBooking;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteBooking;
        private Syncfusion.WinForms.Controls.SfButton btnEditBooking;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverBooking;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateBooking;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpBookingDate;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateBooking;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblSortRoomId;
        private System.Windows.Forms.Label lblSortBookingID;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortRoomID;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortBookingID;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPHG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhanPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTraPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Button btncheckout;
        private System.Windows.Forms.Button btncheckin;
    }
}
