namespace GUI.UserControls
{
    partial class ucService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucService));
            this.lblService = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddlService = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditlService = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeletelService = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverlService = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchlService = new System.Windows.Forms.TextBox();
            this.btnTraCuulService = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateService = new Syncfusion.WinForms.ListView.SfComboBox();
            this.dtpServiceDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.colMaDatDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSortServiceD = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortServiceID = new System.Windows.Forms.Label();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.lblStateService = new System.Windows.Forms.Label();
            this.lblSortBookingID = new System.Windows.Forms.Label();
            this.cboSortBookingID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortServiceD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBookingID)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblService
            // 
            this.lblService.BackColor = System.Drawing.Color.Lavender;
            this.lblService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblService.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblService.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblService.Location = new System.Drawing.Point(0, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(972, 94);
            this.lblService.TabIndex = 1;
            this.lblService.Text = "SERVICES";
            this.lblService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddlService, 0, 0);
            this.tlpController.Controls.Add(this.btnEditlService, 0, 1);
            this.tlpController.Controls.Add(this.btnDeletelService, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverlService, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddlService
            // 
            this.btnAddlService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddlService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddlService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddlService.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddlService.ForeColor = System.Drawing.Color.White;
            this.btnAddlService.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddlService.Location = new System.Drawing.Point(3, 3);
            this.btnAddlService.Name = "btnAddlService";
            this.btnAddlService.Size = new System.Drawing.Size(191, 41);
            this.btnAddlService.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddlService.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddlService.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddlService.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddlService.TabIndex = 2;
            this.btnAddlService.Text = "Thêm";
            this.btnAddlService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddlService, "Thêm đặt dịch vụ");
            this.btnAddlService.UseVisualStyleBackColor = false;
            this.btnAddlService.Click += new System.EventHandler(this.btnAddlService_Click);
            // 
            // btnEditlService
            // 
            this.btnEditlService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditlService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditlService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditlService.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditlService.ForeColor = System.Drawing.Color.White;
            this.btnEditlService.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditlService.Location = new System.Drawing.Point(3, 50);
            this.btnEditlService.Name = "btnEditlService";
            this.btnEditlService.Size = new System.Drawing.Size(191, 41);
            this.btnEditlService.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditlService.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditlService.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditlService.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditlService.TabIndex = 4;
            this.btnEditlService.Text = "Sửa";
            this.btnEditlService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditlService, "Sửa đặt dịch vụ");
            this.btnEditlService.UseVisualStyleBackColor = false;
            this.btnEditlService.Click += new System.EventHandler(this.btnEditlService_Click);
            // 
            // btnDeletelService
            // 
            this.btnDeletelService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeletelService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeletelService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletelService.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletelService.ForeColor = System.Drawing.Color.White;
            this.btnDeletelService.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeletelService.Location = new System.Drawing.Point(200, 3);
            this.btnDeletelService.Name = "btnDeletelService";
            this.btnDeletelService.Size = new System.Drawing.Size(191, 41);
            this.btnDeletelService.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeletelService.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeletelService.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeletelService.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeletelService.TabIndex = 3;
            this.btnDeletelService.Text = "Xóa";
            this.btnDeletelService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeletelService, "Xóa đặt dịch vụ");
            this.btnDeletelService.UseVisualStyleBackColor = false;
            this.btnDeletelService.Click += new System.EventHandler(this.btnDeletelService_Click);
            // 
            // btnRecoverlService
            // 
            this.btnRecoverlService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverlService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverlService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverlService.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverlService.ForeColor = System.Drawing.Color.White;
            this.btnRecoverlService.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverlService.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverlService.Name = "btnRecoverlService";
            this.btnRecoverlService.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverlService.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverlService.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverlService.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverlService.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverlService.TabIndex = 5;
            this.btnRecoverlService.Text = "Khôi phục";
            this.btnRecoverlService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRecoverlService, "Khôi phục đặt dịch vụ");
            this.btnRecoverlService.UseVisualStyleBackColor = false;
            this.btnRecoverlService.Click += new System.EventHandler(this.btnRecoverlService_Click);
            // 
            // txtSearchlService
            // 
            this.txtSearchlService.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchlService.Location = new System.Drawing.Point(6, 16);
            this.txtSearchlService.Name = "txtSearchlService";
            this.txtSearchlService.Size = new System.Drawing.Size(251, 40);
            this.txtSearchlService.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSearchlService, "Nhập mã đặt dịch vụ");
            // 
            // btnTraCuulService
            // 
            this.btnTraCuulService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuulService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuulService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuulService.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuulService.ForeColor = System.Drawing.Color.White;
            this.btnTraCuulService.Location = new System.Drawing.Point(263, 16);
            this.btnTraCuulService.Name = "btnTraCuulService";
            this.btnTraCuulService.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuulService.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuulService.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuulService.TabIndex = 8;
            this.btnTraCuulService.Text = "Tra cứu";
            this.toolTip1.SetToolTip(this.btnTraCuulService, "Tra cứu");
            this.btnTraCuulService.UseVisualStyleBackColor = false;
            this.btnTraCuulService.Click += new System.EventHandler(this.btnTraCuulService_Click);
            // 
            // cboStateService
            // 
            this.cboStateService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateService.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateService.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateService.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateService.Location = new System.Drawing.Point(225, 257);
            this.cboStateService.Name = "cboStateService";
            this.cboStateService.Size = new System.Drawing.Size(156, 33);
            this.cboStateService.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateService.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateService.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateService.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateService.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateService.TabIndex = 17;
            this.toolTip1.SetToolTip(this.cboStateService, "Lọc theo trạng thái");
            this.cboStateService.SelectedIndexChanged += new System.EventHandler(this.cboStateService_SelectedIndexChanged);
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpServiceDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpServiceDate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpServiceDate.Location = new System.Drawing.Point(225, 194);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(156, 34);
            this.dtpServiceDate.TabIndex = 14;
            this.dtpServiceDate.ToolTipText = "";
            this.dtpServiceDate.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.dtpServiceDate_ValueChanged);
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
            this.spcQuery.Panel1.Controls.Add(this.dgvServices);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortServiceD);
            this.spcQuery.Panel2.Controls.Add(this.lblSortServiceID);
            this.spcQuery.Panel2.Controls.Add(this.lblServiceDate);
            this.spcQuery.Panel2.Controls.Add(this.lblStateService);
            this.spcQuery.Panel2.Controls.Add(this.lblSortBookingID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortBookingID);
            this.spcQuery.Panel2.Controls.Add(this.dtpServiceDate);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchlService);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuulService);
            this.spcQuery.Panel2.Controls.Add(this.cboStateService);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeColumns = false;
            this.dgvServices.AllowUserToResizeRows = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDatDichVu,
            this.colMaDatPhong,
            this.colMaDV,
            this.colSoLuong,
            this.colNgayDat,
            this.colTrangThai});
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Location = new System.Drawing.Point(0, 0);
            this.dgvServices.MultiSelect = false;
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(973, 746);
            this.dgvServices.TabIndex = 6;
            // 
            // colMaDatDichVu
            // 
            this.colMaDatDichVu.DataPropertyName = "MaDatDichVu";
            this.colMaDatDichVu.HeaderText = "Mã đặt dịch vụ";
            this.colMaDatDichVu.MinimumWidth = 6;
            this.colMaDatDichVu.Name = "colMaDatDichVu";
            this.colMaDatDichVu.ReadOnly = true;
            this.colMaDatDichVu.Width = 152;
            // 
            // colMaDatPhong
            // 
            this.colMaDatPhong.DataPropertyName = "MaDatPhong";
            this.colMaDatPhong.HeaderText = "Mã đặt phòng";
            this.colMaDatPhong.MinimumWidth = 6;
            this.colMaDatPhong.Name = "colMaDatPhong";
            this.colMaDatPhong.ReadOnly = true;
            this.colMaDatPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaDatPhong.Width = 147;
            // 
            // colMaDV
            // 
            this.colMaDV.DataPropertyName = "MaDV";
            this.colMaDV.HeaderText = "Mã dịch vụ";
            this.colMaDV.MinimumWidth = 6;
            this.colMaDV.Name = "colMaDV";
            this.colMaDV.ReadOnly = true;
            this.colMaDV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaDV.Width = 122;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 106;
            // 
            // colNgayDat
            // 
            this.colNgayDat.DataPropertyName = "NgayDat";
            this.colNgayDat.HeaderText = "Ngày đặt";
            this.colNgayDat.MinimumWidth = 6;
            this.colNgayDat.Name = "colNgayDat";
            this.colNgayDat.ReadOnly = true;
            this.colNgayDat.Width = 107;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Visible = false;
            this.colTrangThai.Width = 114;
            // 
            // cboSortServiceD
            // 
            this.cboSortServiceD.DelimiterChar = "";
            this.cboSortServiceD.DisplayMember = "";
            this.cboSortServiceD.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortServiceD.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortServiceD.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortServiceD.Location = new System.Drawing.Point(225, 133);
            this.cboSortServiceD.Name = "cboSortServiceD";
            this.cboSortServiceD.Size = new System.Drawing.Size(156, 33);
            this.cboSortServiceD.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortServiceD.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortServiceD.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortServiceD.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortServiceD.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortServiceD.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cboSortServiceD, "Sắp xếp theo mã đặt dịch vụ");
            this.cboSortServiceD.SelectedIndexChanged += new System.EventHandler(this.cboSortServiceD_SelectedIndexChanged);
            // 
            // lblSortServiceID
            // 
            this.lblSortServiceID.AutoSize = true;
            this.lblSortServiceID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortServiceID.Location = new System.Drawing.Point(5, 140);
            this.lblSortServiceID.Name = "lblSortServiceID";
            this.lblSortServiceID.Size = new System.Drawing.Size(206, 26);
            this.lblSortServiceID.TabIndex = 11;
            this.lblSortServiceID.Text = "Sort theo Service ID";
            this.lblSortServiceID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDate.Location = new System.Drawing.Point(5, 202);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(101, 26);
            this.lblServiceDate.TabIndex = 13;
            this.lblServiceDate.Text = "Ngày đặt";
            this.lblServiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateService
            // 
            this.lblStateService.AutoSize = true;
            this.lblStateService.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateService.Location = new System.Drawing.Point(5, 264);
            this.lblStateService.Name = "lblStateService";
            this.lblStateService.Size = new System.Drawing.Size(186, 26);
            this.lblStateService.TabIndex = 16;
            this.lblStateService.Text = "Trạng thái dữ liệu";
            this.lblStateService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSortBookingID
            // 
            this.lblSortBookingID.AutoSize = true;
            this.lblSortBookingID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBookingID.Location = new System.Drawing.Point(4, 85);
            this.lblSortBookingID.Name = "lblSortBookingID";
            this.lblSortBookingID.Size = new System.Drawing.Size(218, 26);
            this.lblSortBookingID.TabIndex = 9;
            this.lblSortBookingID.Text = "Sort theo Booking ID";
            this.lblSortBookingID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortBookingID
            // 
            this.cboSortBookingID.DelimiterChar = "";
            this.cboSortBookingID.DisplayMember = "";
            this.cboSortBookingID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortBookingID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortBookingID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Location = new System.Drawing.Point(225, 78);
            this.cboSortBookingID.Name = "cboSortBookingID";
            this.cboSortBookingID.Size = new System.Drawing.Size(156, 33);
            this.cboSortBookingID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortBookingID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortBookingID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cboSortBookingID, "Sắp xếp theo mã đặt phòng");
            this.cboSortBookingID.SelectedIndexChanged += new System.EventHandler(this.cboSortBookingID_SelectedIndexChanged);
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
            this.spcHeader.Panel1.Controls.Add(this.lblService);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // colMaDatDichVu
            // 
            this.colMaDatDichVu.DataPropertyName = "MaDatDichVu";
            this.colMaDatDichVu.HeaderText = "Mã đặt dịch vụ";
            this.colMaDatDichVu.MinimumWidth = 6;
            this.colMaDatDichVu.Name = "colMaDatDichVu";
            this.colMaDatDichVu.ReadOnly = true;
            this.colMaDatDichVu.Width = 152;
            // 
            // colMaDatPhong
            // 
            this.colMaDatPhong.DataPropertyName = "MaDatPhong";
            this.colMaDatPhong.HeaderText = "Mã đặt phòng";
            this.colMaDatPhong.MinimumWidth = 6;
            this.colMaDatPhong.Name = "colMaDatPhong";
            this.colMaDatPhong.ReadOnly = true;
            this.colMaDatPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaDatPhong.Width = 147;
            // 
            // colMaDV
            // 
            this.colMaDV.DataPropertyName = "MaDV";
            this.colMaDV.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaDV.HeaderText = "Mã dịch vụ";
            this.colMaDV.MinimumWidth = 6;
            this.colMaDV.Name = "colMaDV";
            this.colMaDV.ReadOnly = true;
            this.colMaDV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaDV.Width = 103;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 106;
            // 
            // colNgayDat
            // 
            this.colNgayDat.DataPropertyName = "NgayDat";
            this.colNgayDat.HeaderText = "Ngày đặt";
            this.colNgayDat.MinimumWidth = 6;
            this.colNgayDat.Name = "colNgayDat";
            this.colNgayDat.ReadOnly = true;
            this.colNgayDat.Width = 107;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Visible = false;
            this.colTrangThai.Width = 114;
            // 
            // ucService
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucService";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucService_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateService)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortServiceD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBookingID)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblService;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuulService;
        private Syncfusion.WinForms.Controls.SfButton btnAddlService;
        private System.Windows.Forms.TextBox txtSearchlService;
        private Syncfusion.WinForms.Controls.SfButton btnDeletelService;
        private Syncfusion.WinForms.Controls.SfButton btnEditlService;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverlService;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateService;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpServiceDate;
        private System.Windows.Forms.SplitContainer spcQuery;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortBookingID;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblSortBookingID;
        private System.Windows.Forms.Label lblStateService;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.Label lblSortServiceID;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortServiceD;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDatDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDatPhong;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
