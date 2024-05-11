namespace GUI.UserControls
{
    partial class ucBill
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBill));
            this.lblBill = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddBill = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditBill = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteBill = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverBill = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateBooking = new Syncfusion.WinForms.ListView.SfComboBox();
            this.dtpBillDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaThue = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNgayLapHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienThoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtXemCT = new Syncfusion.WinForms.Controls.SfButton();
            this.btnThanhToan = new Syncfusion.WinForms.Controls.SfButton();
            this.btnTraCuuDP = new Syncfusion.WinForms.Controls.SfButton();
            this.dtpNgayDat = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTraCuuUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.btnNgayTao = new Syncfusion.WinForms.Controls.SfButton();
            this.cboSortSumBill = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboSortBillID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortSumBill = new System.Windows.Forms.Label();
            this.lblSortBillID = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblStateBooking = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSumBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBillID)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBill
            // 
            this.lblBill.BackColor = System.Drawing.Color.Lavender;
            this.lblBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBill.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBill.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBill.Location = new System.Drawing.Point(0, 0);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(972, 94);
            this.lblBill.TabIndex = 35;
            this.lblBill.Text = "BILLS";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddBill, 0, 0);
            this.tlpController.Controls.Add(this.btnEditBill, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteBill, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverBill, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tlpController, "Thêm hóa đơn");
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBill.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.ForeColor = System.Drawing.Color.White;
            this.btnAddBill.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddBill.Location = new System.Drawing.Point(3, 3);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(191, 41);
            this.btnAddBill.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddBill.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddBill.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddBill.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddBill.TabIndex = 1;
            this.btnAddBill.Text = "Thêm";
            this.btnAddBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddBill, "Thêm hóa đơn");
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnEditBill
            // 
            this.btnEditBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBill.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBill.ForeColor = System.Drawing.Color.White;
            this.btnEditBill.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditBill.Location = new System.Drawing.Point(3, 50);
            this.btnEditBill.Name = "btnEditBill";
            this.btnEditBill.Size = new System.Drawing.Size(191, 41);
            this.btnEditBill.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditBill.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditBill.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditBill.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditBill.TabIndex = 3;
            this.btnEditBill.Text = "Sửa";
            this.btnEditBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditBill, "Sửa hóa đơn");
            this.btnEditBill.UseVisualStyleBackColor = false;
            this.btnEditBill.Click += new System.EventHandler(this.btnEditBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBill.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBill.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBill.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteBill.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteBill.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteBill.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBill.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteBill.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteBill.TabIndex = 2;
            this.btnDeleteBill.Text = "Xóa";
            this.btnDeleteBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteBill, "Xóa hóa đơn");
            this.btnDeleteBill.UseVisualStyleBackColor = false;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnRecoverBill
            // 
            this.btnRecoverBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverBill.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverBill.ForeColor = System.Drawing.Color.White;
            this.btnRecoverBill.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverBill.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverBill.Name = "btnRecoverBill";
            this.btnRecoverBill.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverBill.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverBill.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverBill.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverBill.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverBill.TabIndex = 4;
            this.btnRecoverBill.Text = "Khôi phục";
            this.btnRecoverBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRecoverBill, "Khôi phục hóa đơn");
            this.btnRecoverBill.UseVisualStyleBackColor = false;
            this.btnRecoverBill.Click += new System.EventHandler(this.btnRecoverBill_Click);
            // 
            // cboStateBooking
            // 
            this.cboStateBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateBooking.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateBooking.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateBooking.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Location = new System.Drawing.Point(192, 172);
            this.cboStateBooking.Name = "cboStateBooking";
            this.cboStateBooking.Size = new System.Drawing.Size(195, 33);
            this.cboStateBooking.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateBooking.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateBooking.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cboStateBooking, "Lọc theo trạng thái");
            this.cboStateBooking.SelectedIndexChanged += new System.EventHandler(this.cboStateBooking_SelectedIndexChanged);
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBillDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpBillDate.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Format = "MM-dd-yyyy";
            this.dtpBillDate.Location = new System.Drawing.Point(192, 120);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(146, 30);
            this.dtpBillDate.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dtpBillDate, "Chọn ngày lập hóa đơn");
            this.dtpBillDate.ToolTipText = "";
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
            this.spcQuery.Panel1.Controls.Add(this.dgvBill);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.txtXemCT);
            this.spcQuery.Panel2.Controls.Add(this.btnThanhToan);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuDP);
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayDat);
            this.spcQuery.Panel2.Controls.Add(this.label3);
            this.spcQuery.Panel2.Controls.Add(this.txtCCCD);
            this.spcQuery.Panel2.Controls.Add(this.label2);
            this.spcQuery.Panel2.Controls.Add(this.txtTraCuuUser);
            this.spcQuery.Panel2.Controls.Add(this.label1);
            this.spcQuery.Panel2.Controls.Add(this.lblBookingDate);
            this.spcQuery.Panel2.Controls.Add(this.btnNgayTao);
            this.spcQuery.Panel2.Controls.Add(this.cboSortSumBill);
            this.spcQuery.Panel2.Controls.Add(this.cboSortBillID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortSumBill);
            this.spcQuery.Panel2.Controls.Add(this.lblSortBillID);
            this.spcQuery.Panel2.Controls.Add(this.lblBillDate);
            this.spcQuery.Panel2.Controls.Add(this.lblStateBooking);
            this.spcQuery.Panel2.Controls.Add(this.dtpBillDate);
            this.spcQuery.Panel2.Controls.Add(this.cboStateBooking);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colMaKH,
            this.colMaNV,
            this.colMaThue,
            this.colNgayLapHoaDon,
            this.colTongHD,
            this.colTienNhan,
            this.colTienThoi,
            this.colTrangThai,
            this.colCCCD,
            this.colTenDN});
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.Location = new System.Drawing.Point(0, 0);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(973, 746);
            this.dgvBill.TabIndex = 0;
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHoaDon";
            this.colMaHD.HeaderText = "Mã hóa đơn";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.ReadOnly = true;
            this.colMaHD.Width = 108;
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "MaKH";
            this.colMaKH.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaKH.HeaderText = "Tên khách hàng";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.ReadOnly = true;
            this.colMaKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaKH.Width = 135;
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaNV.HeaderText = "Tên nhân viên";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            this.colMaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaNV.Width = 122;
            // 
            // colMaThue
            // 
            this.colMaThue.DataPropertyName = "MaThue";
            this.colMaThue.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaThue.HeaderText = "Tên thuế";
            this.colMaThue.Name = "colMaThue";
            this.colMaThue.ReadOnly = true;
            this.colMaThue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaThue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaThue.Width = 89;
            // 
            // colNgayLapHoaDon
            // 
            this.colNgayLapHoaDon.DataPropertyName = "NgayLapHoaDon";
            this.colNgayLapHoaDon.HeaderText = "Ngày lập hóa đơn";
            this.colNgayLapHoaDon.Name = "colNgayLapHoaDon";
            this.colNgayLapHoaDon.ReadOnly = true;
            this.colNgayLapHoaDon.Width = 119;
            // 
            // colTongHD
            // 
            this.colTongHD.DataPropertyName = "TongHoaDon";
            this.colTongHD.HeaderText = "Tổng hóa đơn";
            this.colTongHD.Name = "colTongHD";
            this.colTongHD.ReadOnly = true;
            this.colTongHD.Width = 97;
            // 
            // colTienNhan
            // 
            this.colTienNhan.DataPropertyName = "TienNhan";
            this.colTienNhan.HeaderText = "Tiền nhận";
            this.colTienNhan.Name = "colTienNhan";
            this.colTienNhan.ReadOnly = true;
            this.colTienNhan.Width = 96;
            // 
            // colTienThoi
            // 
            this.colTienThoi.DataPropertyName = "TienThoi";
            this.colTienThoi.HeaderText = "Tiền thối";
            this.colTienThoi.Name = "colTienThoi";
            this.colTienThoi.ReadOnly = true;
            this.colTienThoi.Width = 87;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 97;
            // 
            // colCCCD
            // 
            this.colCCCD.DataPropertyName = "CCCD";
            this.colCCCD.HeaderText = "CCCD";
            this.colCCCD.Name = "colCCCD";
            this.colCCCD.ReadOnly = true;
            this.colCCCD.Visible = false;
            this.colCCCD.Width = 79;
            // 
            // colTenDN
            // 
            this.colTenDN.DataPropertyName = "TenTaiKhoan";
            this.colTenDN.HeaderText = "Tên đăng nhập";
            this.colTenDN.Name = "colTenDN";
            this.colTenDN.ReadOnly = true;
            this.colTenDN.Visible = false;
            this.colTenDN.Width = 129;
            // 
            // txtXemCT
            // 
            this.txtXemCT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXemCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtXemCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtXemCT.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXemCT.ForeColor = System.Drawing.Color.White;
            this.txtXemCT.Location = new System.Drawing.Point(112, 419);
            this.txtXemCT.Name = "txtXemCT";
            this.txtXemCT.Size = new System.Drawing.Size(134, 40);
            this.txtXemCT.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtXemCT.Style.ForeColor = System.Drawing.Color.White;
            this.txtXemCT.TabIndex = 14;
            this.txtXemCT.Text = "Xem chi tiết";
            this.toolTip1.SetToolTip(this.txtXemCT, "Xem chi tiết");
            this.txtXemCT.UseVisualStyleBackColor = false;
            this.txtXemCT.Click += new System.EventHandler(this.txtXemCT_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.Yellow;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Location = new System.Drawing.Point(252, 419);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(135, 40);
            this.btnThanhToan.Style.BackColor = System.Drawing.Color.Yellow;
            this.btnThanhToan.Style.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.TabIndex = 15;
            this.btnThanhToan.Text = "Thanh toán";
            this.toolTip1.SetToolTip(this.btnThanhToan, "Thanh toán");
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // btnTraCuuDP
            // 
            this.btnTraCuuDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuDP.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuDP.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuDP.Location = new System.Drawing.Point(17, 419);
            this.btnTraCuuDP.Name = "btnTraCuuDP";
            this.btnTraCuuDP.Size = new System.Drawing.Size(88, 40);
            this.btnTraCuuDP.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuDP.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuDP.TabIndex = 13;
            this.btnTraCuuDP.Text = "Tra cứu";
            this.toolTip1.SetToolTip(this.btnTraCuuDP, "Tra cứu");
            this.btnTraCuuDP.UseVisualStyleBackColor = false;
            this.btnTraCuuDP.Click += new System.EventHandler(this.btnTraCuuDP_Click);
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayDat.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpNgayDat.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDat.Location = new System.Drawing.Point(148, 370);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(239, 34);
            this.dtpNgayDat.TabIndex = 12;
            this.toolTip1.SetToolTip(this.dtpNgayDat, "Ngày đặt");
            this.dtpNgayDat.ToolTipText = "";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 42;
            this.label3.Text = "CCCD:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(147, 315);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(240, 40);
            this.txtCCCD.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtCCCD, "Căn cước công dân");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTraCuuUser
            // 
            this.txtTraCuuUser.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraCuuUser.Location = new System.Drawing.Point(147, 261);
            this.txtTraCuuUser.Name = "txtTraCuuUser";
            this.txtTraCuuUser.Size = new System.Drawing.Size(240, 40);
            this.txtTraCuuUser.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtTraCuuUser, "Tên đăng nhập");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 26);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tra cứu và Thanh toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.Location = new System.Drawing.Point(12, 378);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(106, 26);
            this.lblBookingDate.TabIndex = 37;
            this.lblBookingDate.Text = "Ngày đặt:";
            this.lblBookingDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNgayTao
            // 
            this.btnNgayTao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNgayTao.BackColor = System.Drawing.Color.White;
            this.btnNgayTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgayTao.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgayTao.ForeColor = System.Drawing.Color.White;
            this.btnNgayTao.Location = new System.Drawing.Point(344, 116);
            this.btnNgayTao.Name = "btnNgayTao";
            this.btnNgayTao.Size = new System.Drawing.Size(43, 34);
            this.btnNgayTao.Style.BackColor = System.Drawing.Color.White;
            this.btnNgayTao.Style.ForeColor = System.Drawing.Color.White;
            this.btnNgayTao.Style.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnNgayTao.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnNgayTao, "Tìm kiếm");
            this.btnNgayTao.UseVisualStyleBackColor = false;
            this.btnNgayTao.Click += new System.EventHandler(this.btnNgayTao_Click);
            // 
            // cboSortSumBill
            // 
            this.cboSortSumBill.DelimiterChar = "";
            this.cboSortSumBill.DisplayMember = "";
            this.cboSortSumBill.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortSumBill.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortSumBill.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSumBill.Location = new System.Drawing.Point(192, 60);
            this.cboSortSumBill.Name = "cboSortSumBill";
            this.cboSortSumBill.Size = new System.Drawing.Size(195, 33);
            this.cboSortSumBill.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortSumBill.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSumBill.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSumBill.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortSumBill.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSumBill.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cboSortSumBill, "Sắp xếp theo tổng tiền");
            this.cboSortSumBill.SelectedIndexChanged += new System.EventHandler(this.cboSortSumBill_SelectedIndexChanged);
            // 
            // cboSortBillID
            // 
            this.cboSortBillID.DelimiterChar = "";
            this.cboSortBillID.DisplayMember = "";
            this.cboSortBillID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortBillID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortBillID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBillID.Location = new System.Drawing.Point(192, 13);
            this.cboSortBillID.Name = "cboSortBillID";
            this.cboSortBillID.Size = new System.Drawing.Size(195, 33);
            this.cboSortBillID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortBillID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBillID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBillID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortBillID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBillID.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cboSortBillID, "Sắp xếp theo mã hóa đơn");
            this.cboSortBillID.SelectedIndexChanged += new System.EventHandler(this.cboSortBillID_SelectedIndexChanged);
            // 
            // lblSortSumBill
            // 
            this.lblSortSumBill.AutoSize = true;
            this.lblSortSumBill.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortSumBill.Location = new System.Drawing.Point(10, 71);
            this.lblSortSumBill.Name = "lblSortSumBill";
            this.lblSortSumBill.Size = new System.Drawing.Size(169, 22);
            this.lblSortSumBill.TabIndex = 16;
            this.lblSortSumBill.Text = "Sort theo tổng tiền";
            this.lblSortSumBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSortBillID
            // 
            this.lblSortBillID.AutoSize = true;
            this.lblSortBillID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBillID.Location = new System.Drawing.Point(8, 24);
            this.lblSortBillID.Name = "lblSortBillID";
            this.lblSortBillID.Size = new System.Drawing.Size(142, 22);
            this.lblSortBillID.TabIndex = 14;
            this.lblSortBillID.Text = "Sort theo Bill ID";
            this.lblSortBillID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.Location = new System.Drawing.Point(10, 128);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(158, 22);
            this.lblBillDate.TabIndex = 10;
            this.lblBillDate.Text = "Ngày lập hóa đơn";
            this.lblBillDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateBooking
            // 
            this.lblStateBooking.AutoSize = true;
            this.lblStateBooking.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateBooking.Location = new System.Drawing.Point(13, 183);
            this.lblStateBooking.Name = "lblStateBooking";
            this.lblStateBooking.Size = new System.Drawing.Size(159, 22);
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
            this.spcHeader.Panel1.Controls.Add(this.lblBill);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucBill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucBill";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucBill_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateBooking)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSumBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBillID)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBill;
        private Syncfusion.WinForms.Controls.SfButton btnAddBill;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteBill;
        private Syncfusion.WinForms.Controls.SfButton btnEditBill;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverBill;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateBooking;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpBillDate;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateBooking;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblSortSumBill;
        private System.Windows.Forms.Label lblSortBillID;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortSumBill;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortBillID;
        private System.Windows.Forms.DataGridView dgvBill;
        private Syncfusion.WinForms.Controls.SfButton btnNgayTao;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpNgayDat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTraCuuUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookingDate;
        private Syncfusion.WinForms.Controls.SfButton btnThanhToan;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuDP;
        private Syncfusion.WinForms.Controls.SfButton txtXemCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLapHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienThoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDN;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
