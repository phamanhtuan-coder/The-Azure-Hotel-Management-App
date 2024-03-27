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
            this.lvwService = new System.Windows.Forms.ListView();
            this.colMaDichVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaDatPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaPHG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayDat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboSortServiceType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboSortServiceD = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortlServiceType = new System.Windows.Forms.Label();
            this.lblSortServiceID = new System.Windows.Forms.Label();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.lblStateService = new System.Windows.Forms.Label();
            this.lblSortBookingID = new System.Windows.Forms.Label();
            this.cboSortBookingID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.lblSortThanhTien = new System.Windows.Forms.Label();
            this.cboSortThanhTien = new Syncfusion.WinForms.ListView.SfComboBox();
            this.colTenDichVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortServiceD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBookingID)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortThanhTien)).BeginInit();
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
            this.lblService.TabIndex = 35;
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
            this.btnAddlService.TabIndex = 1;
            this.btnAddlService.Text = "Thêm";
            this.btnAddlService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddlService.UseVisualStyleBackColor = false;
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
            this.btnEditlService.TabIndex = 3;
            this.btnEditlService.Text = "Sửa";
            this.btnEditlService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditlService.UseVisualStyleBackColor = false;
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
            this.btnDeletelService.TabIndex = 4;
            this.btnDeletelService.Text = "Xóa";
            this.btnDeletelService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletelService.UseVisualStyleBackColor = false;
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
            this.btnRecoverlService.UseVisualStyleBackColor = false;
            // 
            // txtSearchlService
            // 
            this.txtSearchlService.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchlService.Location = new System.Drawing.Point(6, 16);
            this.txtSearchlService.Name = "txtSearchlService";
            this.txtSearchlService.Size = new System.Drawing.Size(251, 40);
            this.txtSearchlService.TabIndex = 2;
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
            this.btnTraCuulService.TabIndex = 0;
            this.btnTraCuulService.Text = "Tra cứu";
            this.btnTraCuulService.UseVisualStyleBackColor = false;
            // 
            // cboStateService
            // 
            this.cboStateService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateService.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateService.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateService.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateService.Location = new System.Drawing.Point(225, 354);
            this.cboStateService.Name = "cboStateService";
            this.cboStateService.Size = new System.Drawing.Size(156, 33);
            this.cboStateService.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateService.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateService.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateService.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateService.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateService.TabIndex = 3;
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpServiceDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpServiceDate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpServiceDate.Location = new System.Drawing.Point(225, 243);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(156, 34);
            this.dtpServiceDate.TabIndex = 6;
            this.dtpServiceDate.ToolTipText = "";
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
            this.spcQuery.Panel1.Controls.Add(this.lvwService);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortThanhTien);
            this.spcQuery.Panel2.Controls.Add(this.lblSortThanhTien);
            this.spcQuery.Panel2.Controls.Add(this.cboSortServiceType);
            this.spcQuery.Panel2.Controls.Add(this.cboSortServiceD);
            this.spcQuery.Panel2.Controls.Add(this.lblSortlServiceType);
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
            // lvwService
            // 
            this.lvwService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaDichVu,
            this.colMaDatPhong,
            this.colTenDichVu,
            this.colMaPHG,
            this.colNgayDat,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.lvwService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwService.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwService.FullRowSelect = true;
            this.lvwService.GridLines = true;
            this.lvwService.HideSelection = false;
            this.lvwService.Location = new System.Drawing.Point(0, 0);
            this.lvwService.MultiSelect = false;
            this.lvwService.Name = "lvwService";
            this.lvwService.Size = new System.Drawing.Size(973, 746);
            this.lvwService.TabIndex = 0;
            this.lvwService.UseCompatibleStateImageBehavior = false;
            this.lvwService.View = System.Windows.Forms.View.Details;
            // 
            // colMaDichVu
            // 
            this.colMaDichVu.Text = "Mã đặt DV";
            this.colMaDichVu.Width = 81;
            // 
            // colMaDatPhong
            // 
            this.colMaDatPhong.Text = "Mã đặt phòng";
            this.colMaDatPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMaDatPhong.Width = 86;
            // 
            // colMaPHG
            // 
            this.colMaPHG.Text = "PHG";
            this.colMaPHG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMaPHG.Width = 93;
            // 
            // colNgayDat
            // 
            this.colNgayDat.Text = "Ngày đặt";
            this.colNgayDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNgayDat.Width = 127;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoLuong.Width = 144;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDonGia.Width = 146;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Text = "Thành Tiền";
            this.colThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colThanhTien.Width = 138;
            // 
            // cboSortServiceType
            // 
            this.cboSortServiceType.DelimiterChar = "";
            this.cboSortServiceType.DisplayMember = "";
            this.cboSortServiceType.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortServiceType.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortServiceType.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortServiceType.Location = new System.Drawing.Point(225, 188);
            this.cboSortServiceType.Name = "cboSortServiceType";
            this.cboSortServiceType.Size = new System.Drawing.Size(156, 33);
            this.cboSortServiceType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortServiceType.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortServiceType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortServiceType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortServiceType.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortServiceType.TabIndex = 24;
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
            this.cboSortServiceD.TabIndex = 23;
            // 
            // lblSortlServiceType
            // 
            this.lblSortlServiceType.AutoSize = true;
            this.lblSortlServiceType.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortlServiceType.Location = new System.Drawing.Point(4, 195);
            this.lblSortlServiceType.Name = "lblSortlServiceType";
            this.lblSortlServiceType.Size = new System.Drawing.Size(220, 26);
            this.lblSortlServiceType.TabIndex = 16;
            this.lblSortlServiceType.Text = "Sort theo loại dịch vụ";
            this.lblSortlServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSortServiceID
            // 
            this.lblSortServiceID.AutoSize = true;
            this.lblSortServiceID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortServiceID.Location = new System.Drawing.Point(5, 140);
            this.lblSortServiceID.Name = "lblSortServiceID";
            this.lblSortServiceID.Size = new System.Drawing.Size(206, 26);
            this.lblSortServiceID.TabIndex = 14;
            this.lblSortServiceID.Text = "Sort theo Service ID";
            this.lblSortServiceID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDate.Location = new System.Drawing.Point(5, 251);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(101, 26);
            this.lblServiceDate.TabIndex = 10;
            this.lblServiceDate.Text = "Ngày đặt";
            this.lblServiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateService
            // 
            this.lblStateService.AutoSize = true;
            this.lblStateService.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateService.Location = new System.Drawing.Point(5, 361);
            this.lblStateService.Name = "lblStateService";
            this.lblStateService.Size = new System.Drawing.Size(186, 26);
            this.lblStateService.TabIndex = 9;
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
            this.lblSortBookingID.TabIndex = 8;
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
            this.cboSortBookingID.TabIndex = 7;
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
            // lblSortThanhTien
            // 
            this.lblSortThanhTien.AutoSize = true;
            this.lblSortThanhTien.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortThanhTien.Location = new System.Drawing.Point(4, 306);
            this.lblSortThanhTien.Name = "lblSortThanhTien";
            this.lblSortThanhTien.Size = new System.Drawing.Size(210, 26);
            this.lblSortThanhTien.TabIndex = 25;
            this.lblSortThanhTien.Text = "Sort theo thành tiền";
            this.lblSortThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortThanhTien
            // 
            this.cboSortThanhTien.DelimiterChar = "";
            this.cboSortThanhTien.DisplayMember = "";
            this.cboSortThanhTien.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortThanhTien.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortThanhTien.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortThanhTien.Location = new System.Drawing.Point(225, 299);
            this.cboSortThanhTien.Name = "cboSortThanhTien";
            this.cboSortThanhTien.Size = new System.Drawing.Size(156, 33);
            this.cboSortThanhTien.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortThanhTien.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortThanhTien.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortThanhTien.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortThanhTien.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortThanhTien.TabIndex = 26;
            // 
            // colTenDichVu
            // 
            this.colTenDichVu.Text = "Tên dịch vụ";
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
            ((System.ComponentModel.ISupportInitialize)(this.cboSortServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortServiceD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBookingID)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboSortThanhTien)).EndInit();
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
        private System.Windows.Forms.ListView lvwService;
        private System.Windows.Forms.ColumnHeader colMaDichVu;
        private System.Windows.Forms.ColumnHeader colMaDatPhong;
        private System.Windows.Forms.ColumnHeader colMaPHG;
        private System.Windows.Forms.ColumnHeader colNgayDat;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colThanhTien;
        private System.Windows.Forms.Label lblSortlServiceType;
        private System.Windows.Forms.Label lblSortServiceID;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortServiceType;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortServiceD;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortThanhTien;
        private System.Windows.Forms.Label lblSortThanhTien;
        private System.Windows.Forms.ColumnHeader colTenDichVu;
    }
}
