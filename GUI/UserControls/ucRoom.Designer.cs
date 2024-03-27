namespace GUI.UserControls
{
    partial class ucRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRoom));
            this.lblRoom = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRoom = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditRoom = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteRoom = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverRoom = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchRoom = new System.Windows.Forms.TextBox();
            this.btnTraCuuRoom = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateRoom = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.lvwRoom = new System.Windows.Forms.ListView();
            this.colMaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSucChuaToiDa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaDSTB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTinhTrangPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudSucChua = new System.Windows.Forms.NumericUpDown();
            this.nudPriceMax = new System.Windows.Forms.NumericUpDown();
            this.nudPriceMin = new System.Windows.Forms.NumericUpDown();
            this.cboSortPrice = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortPrice = new System.Windows.Forms.Label();
            this.lblPriceRange = new System.Windows.Forms.Label();
            this.cboRoomStatus = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortTheoLoaiPhong = new System.Windows.Forms.Label();
            this.cboSortRoomType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboSortRoomID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblQuickControl = new System.Windows.Forms.Label();
            this.btnCheckIn = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCheckOut = new Syncfusion.WinForms.Controls.SfButton();
            this.lblSortSucChua = new System.Windows.Forms.Label();
            this.lblSortMaPHG = new System.Windows.Forms.Label();
            this.lblStateBooking = new System.Windows.Forms.Label();
            this.lblStatusRoom = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoomStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomID)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRoom
            // 
            this.lblRoom.BackColor = System.Drawing.Color.Lavender;
            this.lblRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoom.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRoom.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRoom.Location = new System.Drawing.Point(0, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(972, 94);
            this.lblRoom.TabIndex = 35;
            this.lblRoom.Text = "ROOM";
            this.lblRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddRoom, 0, 0);
            this.tlpController.Controls.Add(this.btnEditRoom, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteRoom, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverRoom, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddRoom.Location = new System.Drawing.Point(3, 3);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(191, 41);
            this.btnAddRoom.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRoom.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddRoom.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddRoom.TabIndex = 1;
            this.btnAddRoom.Text = "Thêm";
            this.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRoom.UseVisualStyleBackColor = false;
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRoom.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRoom.ForeColor = System.Drawing.Color.White;
            this.btnEditRoom.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditRoom.Location = new System.Drawing.Point(3, 50);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(191, 41);
            this.btnEditRoom.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditRoom.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditRoom.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditRoom.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditRoom.TabIndex = 3;
            this.btnEditRoom.Text = "Sửa";
            this.btnEditRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditRoom.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteRoom.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteRoom.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRoom.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteRoom.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.TabIndex = 4;
            this.btnDeleteRoom.Text = "Xóa";
            this.btnDeleteRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // btnRecoverRoom
            // 
            this.btnRecoverRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverRoom.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverRoom.ForeColor = System.Drawing.Color.White;
            this.btnRecoverRoom.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverRoom.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverRoom.Name = "btnRecoverRoom";
            this.btnRecoverRoom.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverRoom.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverRoom.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverRoom.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverRoom.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverRoom.TabIndex = 5;
            this.btnRecoverRoom.Text = "Khôi phục";
            this.btnRecoverRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverRoom.UseVisualStyleBackColor = false;
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoom.Location = new System.Drawing.Point(6, 16);
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(251, 40);
            this.txtSearchRoom.TabIndex = 2;
            // 
            // btnTraCuuRoom
            // 
            this.btnTraCuuRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuRoom.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuRoom.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRoom.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuRoom.Name = "btnTraCuuRoom";
            this.btnTraCuuRoom.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuRoom.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRoom.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRoom.TabIndex = 0;
            this.btnTraCuuRoom.Text = "Tra cứu";
            this.btnTraCuuRoom.UseVisualStyleBackColor = false;
            // 
            // cboStateRoom
            // 
            this.cboStateRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateRoom.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateRoom.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateRoom.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoom.Location = new System.Drawing.Point(228, 405);
            this.cboStateRoom.Name = "cboStateRoom";
            this.cboStateRoom.Size = new System.Drawing.Size(156, 33);
            this.cboStateRoom.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateRoom.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoom.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoom.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateRoom.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoom.TabIndex = 3;
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
            this.spcQuery.Panel1.Controls.Add(this.lvwRoom);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.nudSucChua);
            this.spcQuery.Panel2.Controls.Add(this.nudPriceMax);
            this.spcQuery.Panel2.Controls.Add(this.nudPriceMin);
            this.spcQuery.Panel2.Controls.Add(this.cboSortPrice);
            this.spcQuery.Panel2.Controls.Add(this.lblSortPrice);
            this.spcQuery.Panel2.Controls.Add(this.lblPriceRange);
            this.spcQuery.Panel2.Controls.Add(this.cboRoomStatus);
            this.spcQuery.Panel2.Controls.Add(this.lblSortTheoLoaiPhong);
            this.spcQuery.Panel2.Controls.Add(this.cboSortRoomType);
            this.spcQuery.Panel2.Controls.Add(this.cboSortRoomID);
            this.spcQuery.Panel2.Controls.Add(this.lblQuickControl);
            this.spcQuery.Panel2.Controls.Add(this.btnCheckIn);
            this.spcQuery.Panel2.Controls.Add(this.btnCancel);
            this.spcQuery.Panel2.Controls.Add(this.btnCheckOut);
            this.spcQuery.Panel2.Controls.Add(this.lblSortSucChua);
            this.spcQuery.Panel2.Controls.Add(this.lblSortMaPHG);
            this.spcQuery.Panel2.Controls.Add(this.lblStateBooking);
            this.spcQuery.Panel2.Controls.Add(this.lblStatusRoom);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchRoom);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuRoom);
            this.spcQuery.Panel2.Controls.Add(this.cboStateRoom);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // lvwRoom
            // 
            this.lvwRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhong,
            this.colLoaiPhong,
            this.colSucChuaToiDa,
            this.colGia,
            this.colMaDSTB,
            this.colMoTa,
            this.colTinhTrangPhong});
            this.lvwRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwRoom.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwRoom.FullRowSelect = true;
            this.lvwRoom.GridLines = true;
            this.lvwRoom.HideSelection = false;
            this.lvwRoom.Location = new System.Drawing.Point(0, 0);
            this.lvwRoom.MultiSelect = false;
            this.lvwRoom.Name = "lvwRoom";
            this.lvwRoom.Size = new System.Drawing.Size(973, 746);
            this.lvwRoom.TabIndex = 0;
            this.lvwRoom.UseCompatibleStateImageBehavior = false;
            this.lvwRoom.View = System.Windows.Forms.View.Details;
            // 
            // colMaPhong
            // 
            this.colMaPhong.Text = "Mã PHG";
            this.colMaPhong.Width = 81;
            // 
            // colLoaiPhong
            // 
            this.colLoaiPhong.Text = "Loại Phòng";
            this.colLoaiPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLoaiPhong.Width = 207;
            // 
            // colSucChuaToiDa
            // 
            this.colSucChuaToiDa.Text = "Sức chứa";
            this.colSucChuaToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSucChuaToiDa.Width = 179;
            // 
            // colGia
            // 
            this.colGia.Text = "Giá";
            this.colGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGia.Width = 127;
            // 
            // colMaDSTB
            // 
            this.colMaDSTB.Text = "Mã DS Thiết Bị";
            this.colMaDSTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMaDSTB.Width = 186;
            // 
            // colMoTa
            // 
            this.colMoTa.Text = "Mô tả";
            this.colMoTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMoTa.Width = 146;
            // 
            // colTinhTrangPhong
            // 
            this.colTinhTrangPhong.Text = "Tình trạng phòng";
            this.colTinhTrangPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTinhTrangPhong.Width = 138;
            // 
            // nudSucChua
            // 
            this.nudSucChua.Location = new System.Drawing.Point(229, 189);
            this.nudSucChua.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudSucChua.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSucChua.Name = "nudSucChua";
            this.nudSucChua.Size = new System.Drawing.Size(155, 27);
            this.nudSucChua.TabIndex = 32;
            this.nudSucChua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSucChua.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPriceMax
            // 
            this.nudPriceMax.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudPriceMax.Location = new System.Drawing.Point(264, 240);
            this.nudPriceMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPriceMax.Name = "nudPriceMax";
            this.nudPriceMax.Size = new System.Drawing.Size(120, 27);
            this.nudPriceMax.TabIndex = 31;
            this.nudPriceMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPriceMax.ThousandsSeparator = true;
            this.nudPriceMax.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // nudPriceMin
            // 
            this.nudPriceMin.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudPriceMin.Location = new System.Drawing.Point(137, 240);
            this.nudPriceMin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPriceMin.Name = "nudPriceMin";
            this.nudPriceMin.Size = new System.Drawing.Size(120, 27);
            this.nudPriceMin.TabIndex = 30;
            this.nudPriceMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPriceMin.ThousandsSeparator = true;
            // 
            // cboSortPrice
            // 
            this.cboSortPrice.DelimiterChar = "";
            this.cboSortPrice.DisplayMember = "";
            this.cboSortPrice.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortPrice.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortPrice.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortPrice.Location = new System.Drawing.Point(228, 291);
            this.cboSortPrice.Name = "cboSortPrice";
            this.cboSortPrice.Size = new System.Drawing.Size(156, 33);
            this.cboSortPrice.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortPrice.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortPrice.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortPrice.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortPrice.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortPrice.TabIndex = 29;
            // 
            // lblSortPrice
            // 
            this.lblSortPrice.AutoSize = true;
            this.lblSortPrice.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortPrice.Location = new System.Drawing.Point(4, 298);
            this.lblSortPrice.Name = "lblSortPrice";
            this.lblSortPrice.Size = new System.Drawing.Size(140, 26);
            this.lblSortPrice.TabIndex = 28;
            this.lblSortPrice.Text = "Sort theo Giá";
            this.lblSortPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPriceRange
            // 
            this.lblPriceRange.AutoSize = true;
            this.lblPriceRange.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceRange.Location = new System.Drawing.Point(4, 241);
            this.lblPriceRange.Name = "lblPriceRange";
            this.lblPriceRange.Size = new System.Drawing.Size(125, 26);
            this.lblPriceRange.TabIndex = 27;
            this.lblPriceRange.Text = "Khoảng giá";
            this.lblPriceRange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRoomStatus
            // 
            this.cboRoomStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRoomStatus.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboRoomStatus.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboRoomStatus.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomStatus.Location = new System.Drawing.Point(226, 75);
            this.cboRoomStatus.Name = "cboRoomStatus";
            this.cboRoomStatus.Size = new System.Drawing.Size(156, 33);
            this.cboRoomStatus.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboRoomStatus.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomStatus.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomStatus.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboRoomStatus.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomStatus.TabIndex = 26;
            // 
            // lblSortTheoLoaiPhong
            // 
            this.lblSortTheoLoaiPhong.AutoSize = true;
            this.lblSortTheoLoaiPhong.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortTheoLoaiPhong.Location = new System.Drawing.Point(4, 132);
            this.lblSortTheoLoaiPhong.Name = "lblSortTheoLoaiPhong";
            this.lblSortTheoLoaiPhong.Size = new System.Drawing.Size(122, 26);
            this.lblSortTheoLoaiPhong.TabIndex = 25;
            this.lblSortTheoLoaiPhong.Text = "Loại phòng";
            this.lblSortTheoLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortRoomType
            // 
            this.cboSortRoomType.DelimiterChar = "";
            this.cboSortRoomType.DisplayMember = "";
            this.cboSortRoomType.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortRoomType.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortRoomType.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomType.Location = new System.Drawing.Point(229, 132);
            this.cboSortRoomType.Name = "cboSortRoomType";
            this.cboSortRoomType.Size = new System.Drawing.Size(156, 33);
            this.cboSortRoomType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortRoomType.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortRoomType.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomType.TabIndex = 24;
            // 
            // cboSortRoomID
            // 
            this.cboSortRoomID.DelimiterChar = "";
            this.cboSortRoomID.DisplayMember = "";
            this.cboSortRoomID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortRoomID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortRoomID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Location = new System.Drawing.Point(229, 348);
            this.cboSortRoomID.Name = "cboSortRoomID";
            this.cboSortRoomID.Size = new System.Drawing.Size(156, 33);
            this.cboSortRoomID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortRoomID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortRoomID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.TabIndex = 23;
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
            // lblSortSucChua
            // 
            this.lblSortSucChua.AutoSize = true;
            this.lblSortSucChua.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortSucChua.Location = new System.Drawing.Point(4, 188);
            this.lblSortSucChua.Name = "lblSortSucChua";
            this.lblSortSucChua.Size = new System.Drawing.Size(163, 26);
            this.lblSortSucChua.TabIndex = 16;
            this.lblSortSucChua.Text = "Sức chứa tối đa";
            this.lblSortSucChua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSortMaPHG
            // 
            this.lblSortMaPHG.AutoSize = true;
            this.lblSortMaPHG.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortMaPHG.Location = new System.Drawing.Point(4, 355);
            this.lblSortMaPHG.Name = "lblSortMaPHG";
            this.lblSortMaPHG.Size = new System.Drawing.Size(192, 26);
            this.lblSortMaPHG.TabIndex = 14;
            this.lblSortMaPHG.Text = "Sort theo Room ID";
            this.lblSortMaPHG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateBooking
            // 
            this.lblStateBooking.AutoSize = true;
            this.lblStateBooking.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateBooking.Location = new System.Drawing.Point(4, 412);
            this.lblStateBooking.Name = "lblStateBooking";
            this.lblStateBooking.Size = new System.Drawing.Size(186, 26);
            this.lblStateBooking.TabIndex = 9;
            this.lblStateBooking.Text = "Trạng thái dữ liệu";
            this.lblStateBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusRoom
            // 
            this.lblStatusRoom.AutoSize = true;
            this.lblStatusRoom.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusRoom.Location = new System.Drawing.Point(4, 82);
            this.lblStatusRoom.Name = "lblStatusRoom";
            this.lblStatusRoom.Size = new System.Drawing.Size(183, 26);
            this.lblStatusRoom.TabIndex = 8;
            this.lblStatusRoom.Text = "Tình trạng phòng";
            this.lblStatusRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblRoom);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucRoom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucRoom";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucRoom_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRoom)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoomStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomID)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRoom;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuRoom;
        private Syncfusion.WinForms.Controls.SfButton btnAddRoom;
        private System.Windows.Forms.TextBox txtSearchRoom;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteRoom;
        private Syncfusion.WinForms.Controls.SfButton btnEditRoom;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverRoom;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateRoom;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStatusRoom;
        private System.Windows.Forms.Label lblStateBooking;
        private System.Windows.Forms.ListView lvwRoom;
        private System.Windows.Forms.ColumnHeader colMaPhong;
        private System.Windows.Forms.ColumnHeader colLoaiPhong;
        private System.Windows.Forms.ColumnHeader colSucChuaToiDa;
        private System.Windows.Forms.ColumnHeader colGia;
        private System.Windows.Forms.ColumnHeader colMaDSTB;
        private System.Windows.Forms.ColumnHeader colMoTa;
        private System.Windows.Forms.ColumnHeader colTinhTrangPhong;
        private System.Windows.Forms.Label lblSortSucChua;
        private System.Windows.Forms.Label lblSortMaPHG;
        private Syncfusion.WinForms.Controls.SfButton btnCheckIn;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnCheckOut;
        private System.Windows.Forms.Label lblQuickControl;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortRoomType;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortRoomID;
        private System.Windows.Forms.Label lblSortTheoLoaiPhong;
        private Syncfusion.WinForms.ListView.SfComboBox cboRoomStatus;
        private System.Windows.Forms.Label lblPriceRange;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortPrice;
        private System.Windows.Forms.Label lblSortPrice;
        private System.Windows.Forms.NumericUpDown nudPriceMax;
        private System.Windows.Forms.NumericUpDown nudPriceMin;
        private System.Windows.Forms.NumericUpDown nudSucChua;
    }
}
