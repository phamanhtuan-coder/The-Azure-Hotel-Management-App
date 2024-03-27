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
            this.btnRecoverBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchBooking = new System.Windows.Forms.TextBox();
            this.btnTraCuuBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateBooking = new Syncfusion.WinForms.ListView.SfComboBox();
            this.dtpCheckOutDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtpCheckInDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtpBookingDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.lvwBooking = new System.Windows.Forms.ListView();
            this.colMaDatPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaPHG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayDat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuongKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTinhTrangDat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblQuickControl = new System.Windows.Forms.Label();
            this.btnCheckIn = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCheckOut = new Syncfusion.WinForms.Controls.SfButton();
            this.lblSortRoomId = new System.Windows.Forms.Label();
            this.lblSortBookingID = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblStateBooking = new System.Windows.Forms.Label();
            this.lblStatusBooking = new System.Windows.Forms.Label();
            this.cboStatusBooking = new Syncfusion.WinForms.ListView.SfComboBox();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.cboSortBookingID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboSortRoomID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatusBooking)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBookingID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomID)).BeginInit();
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
            // 
            // txtSearchBooking
            // 
            this.txtSearchBooking.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBooking.Location = new System.Drawing.Point(6, 16);
            this.txtSearchBooking.Name = "txtSearchBooking";
            this.txtSearchBooking.Size = new System.Drawing.Size(251, 40);
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
            // 
            // cboStateBooking
            // 
            this.cboStateBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateBooking.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateBooking.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateBooking.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Location = new System.Drawing.Point(225, 411);
            this.cboStateBooking.Name = "cboStateBooking";
            this.cboStateBooking.Size = new System.Drawing.Size(156, 33);
            this.cboStateBooking.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateBooking.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateBooking.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.TabIndex = 3;
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCheckOutDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpCheckOutDate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOutDate.Location = new System.Drawing.Point(225, 354);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(156, 34);
            this.dtpCheckOutDate.TabIndex = 4;
            this.dtpCheckOutDate.ToolTipText = "";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCheckInDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpCheckInDate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckInDate.Location = new System.Drawing.Point(225, 297);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(156, 34);
            this.dtpCheckInDate.TabIndex = 5;
            this.dtpCheckInDate.ToolTipText = "";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBookingDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpBookingDate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Location = new System.Drawing.Point(225, 240);
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
            this.spcQuery.Panel1.Controls.Add(this.lvwBooking);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortRoomID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortBookingID);
            this.spcQuery.Panel2.Controls.Add(this.lblQuickControl);
            this.spcQuery.Panel2.Controls.Add(this.btnCheckIn);
            this.spcQuery.Panel2.Controls.Add(this.btnCancel);
            this.spcQuery.Panel2.Controls.Add(this.btnCheckOut);
            this.spcQuery.Panel2.Controls.Add(this.lblSortRoomId);
            this.spcQuery.Panel2.Controls.Add(this.lblSortBookingID);
            this.spcQuery.Panel2.Controls.Add(this.lblCheckOutDate);
            this.spcQuery.Panel2.Controls.Add(this.lblCheckInDate);
            this.spcQuery.Panel2.Controls.Add(this.lblBookingDate);
            this.spcQuery.Panel2.Controls.Add(this.lblStateBooking);
            this.spcQuery.Panel2.Controls.Add(this.lblStatusBooking);
            this.spcQuery.Panel2.Controls.Add(this.cboStatusBooking);
            this.spcQuery.Panel2.Controls.Add(this.dtpBookingDate);
            this.spcQuery.Panel2.Controls.Add(this.dtpCheckInDate);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchBooking);
            this.spcQuery.Panel2.Controls.Add(this.dtpCheckOutDate);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuBooking);
            this.spcQuery.Panel2.Controls.Add(this.cboStateBooking);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // lvwBooking
            // 
            this.lvwBooking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaDatPhong,
            this.colMaKH,
            this.colMaPHG,
            this.colNgayDat,
            this.colCheckIn,
            this.colCheckOut,
            this.colSoLuongKH,
            this.colTinhTrangDat});
            this.lvwBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwBooking.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwBooking.FullRowSelect = true;
            this.lvwBooking.GridLines = true;
            this.lvwBooking.HideSelection = false;
            this.lvwBooking.Location = new System.Drawing.Point(0, 0);
            this.lvwBooking.MultiSelect = false;
            this.lvwBooking.Name = "lvwBooking";
            this.lvwBooking.Size = new System.Drawing.Size(973, 746);
            this.lvwBooking.TabIndex = 0;
            this.lvwBooking.UseCompatibleStateImageBehavior = false;
            this.lvwBooking.View = System.Windows.Forms.View.Details;
            // 
            // colMaDatPhong
            // 
            this.colMaDatPhong.Text = "Mã DP";
            this.colMaDatPhong.Width = 81;
            // 
            // colMaKH
            // 
            this.colMaKH.Text = "Mã KH";
            this.colMaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMaKH.Width = 86;
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
            // colCheckIn
            // 
            this.colCheckIn.Text = "Ngày nhận";
            this.colCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCheckIn.Width = 144;
            // 
            // colCheckOut
            // 
            this.colCheckOut.Text = "Ngày Trả";
            this.colCheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCheckOut.Width = 146;
            // 
            // colSoLuongKH
            // 
            this.colSoLuongKH.Text = "Số lượng KH";
            this.colSoLuongKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoLuongKH.Width = 138;
            // 
            // colTinhTrangDat
            // 
            this.colTinhTrangDat.Text = "Tình trạng đặt";
            this.colTinhTrangDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTinhTrangDat.Width = 157;
            // 
            // lblQuickControl
            // 
            this.lblQuickControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuickControl.AutoSize = true;
            this.lblQuickControl.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickControl.Location = new System.Drawing.Point(69, 471);
            this.lblQuickControl.Name = "lblQuickControl";
            this.lblQuickControl.Size = new System.Drawing.Size(273, 26);
            this.lblQuickControl.TabIndex = 22;
            this.lblQuickControl.Text = "Cập nhật trạng thái nhanh";
            this.lblQuickControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheckIn.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCheckIn.Location = new System.Drawing.Point(14, 522);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(108, 64);
            this.btnCheckIn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCheckIn.Style.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnCheckIn.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnCheckIn.TabIndex = 13;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCancel.Location = new System.Drawing.Point(276, 522);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 64);
            this.btnCancel.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.Style.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnCancel.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheckOut.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCheckOut.Location = new System.Drawing.Point(145, 522);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(108, 64);
            this.btnCheckOut.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCheckOut.Style.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.btnCheckOut.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnCheckOut.TabIndex = 20;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // lblSortRoomId
            // 
            this.lblSortRoomId.AutoSize = true;
            this.lblSortRoomId.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortRoomId.Location = new System.Drawing.Point(4, 191);
            this.lblSortRoomId.Name = "lblSortRoomId";
            this.lblSortRoomId.Size = new System.Drawing.Size(192, 26);
            this.lblSortRoomId.TabIndex = 16;
            this.lblSortRoomId.Text = "Sort theo Room ID";
            this.lblSortRoomId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSortBookingID
            // 
            this.lblSortBookingID.AutoSize = true;
            this.lblSortBookingID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBookingID.Location = new System.Drawing.Point(4, 135);
            this.lblSortBookingID.Name = "lblSortBookingID";
            this.lblSortBookingID.Size = new System.Drawing.Size(218, 26);
            this.lblSortBookingID.TabIndex = 14;
            this.lblSortBookingID.Text = "Sort theo Booking ID";
            this.lblSortBookingID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutDate.Location = new System.Drawing.Point(4, 362);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(175, 26);
            this.lblCheckOutDate.TabIndex = 12;
            this.lblCheckOutDate.Text = "Ngày Check-Out";
            this.lblCheckOutDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInDate.Location = new System.Drawing.Point(4, 305);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(157, 26);
            this.lblCheckInDate.TabIndex = 11;
            this.lblCheckInDate.Text = "Ngày Check-In";
            this.lblCheckInDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.Location = new System.Drawing.Point(4, 248);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(101, 26);
            this.lblBookingDate.TabIndex = 10;
            this.lblBookingDate.Text = "Ngày đặt";
            this.lblBookingDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateBooking
            // 
            this.lblStateBooking.AutoSize = true;
            this.lblStateBooking.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateBooking.Location = new System.Drawing.Point(4, 418);
            this.lblStateBooking.Name = "lblStateBooking";
            this.lblStateBooking.Size = new System.Drawing.Size(186, 26);
            this.lblStateBooking.TabIndex = 9;
            this.lblStateBooking.Text = "Trạng thái dữ liệu";
            this.lblStateBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusBooking
            // 
            this.lblStatusBooking.AutoSize = true;
            this.lblStatusBooking.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBooking.Location = new System.Drawing.Point(4, 79);
            this.lblStatusBooking.Name = "lblStatusBooking";
            this.lblStatusBooking.Size = new System.Drawing.Size(201, 26);
            this.lblStatusBooking.TabIndex = 8;
            this.lblStatusBooking.Text = "Tình trạng booking";
            this.lblStatusBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStatusBooking
            // 
            this.cboStatusBooking.DelimiterChar = "";
            this.cboStatusBooking.DisplayMember = "";
            this.cboStatusBooking.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStatusBooking.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStatusBooking.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatusBooking.Location = new System.Drawing.Point(225, 72);
            this.cboStatusBooking.Name = "cboStatusBooking";
            this.cboStatusBooking.Size = new System.Drawing.Size(156, 33);
            this.cboStatusBooking.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStatusBooking.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatusBooking.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatusBooking.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStatusBooking.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatusBooking.TabIndex = 7;
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
            // cboSortBookingID
            // 
            this.cboSortBookingID.DelimiterChar = "";
            this.cboSortBookingID.DisplayMember = "";
            this.cboSortBookingID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortBookingID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortBookingID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Location = new System.Drawing.Point(225, 135);
            this.cboSortBookingID.Name = "cboSortBookingID";
            this.cboSortBookingID.Size = new System.Drawing.Size(156, 33);
            this.cboSortBookingID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortBookingID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortBookingID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.TabIndex = 23;
            // 
            // cboSortRoomID
            // 
            this.cboSortRoomID.DelimiterChar = "";
            this.cboSortRoomID.DisplayMember = "";
            this.cboSortRoomID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortRoomID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortRoomID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Location = new System.Drawing.Point(225, 184);
            this.cboSortRoomID.Name = "cboSortRoomID";
            this.cboSortRoomID.Size = new System.Drawing.Size(156, 33);
            this.cboSortRoomID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortRoomID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortRoomID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.TabIndex = 24;
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
            ((System.ComponentModel.ISupportInitialize)(this.cboStatusBooking)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBookingID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomID)).EndInit();
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
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpCheckInDate;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpCheckOutDate;
        private System.Windows.Forms.SplitContainer spcQuery;
        private Syncfusion.WinForms.ListView.SfComboBox cboStatusBooking;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStatusBooking;
        private System.Windows.Forms.Label lblStateBooking;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.ListView lvwBooking;
        private System.Windows.Forms.ColumnHeader colMaDatPhong;
        private System.Windows.Forms.ColumnHeader colMaKH;
        private System.Windows.Forms.ColumnHeader colMaPHG;
        private System.Windows.Forms.ColumnHeader colNgayDat;
        private System.Windows.Forms.ColumnHeader colCheckIn;
        private System.Windows.Forms.ColumnHeader colCheckOut;
        private System.Windows.Forms.ColumnHeader colSoLuongKH;
        private System.Windows.Forms.ColumnHeader colTinhTrangDat;
        private System.Windows.Forms.Label lblSortRoomId;
        private System.Windows.Forms.Label lblSortBookingID;
        private Syncfusion.WinForms.Controls.SfButton btnCheckIn;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnCheckOut;
        private System.Windows.Forms.Label lblQuickControl;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortRoomID;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortBookingID;
    }
}
