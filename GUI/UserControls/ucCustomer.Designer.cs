﻿namespace GUI.UserControls
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
            this.btnAddCustomer = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditCustomer = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteCustomer = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverCustomer = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnTraCuuCustomer = new Syncfusion.WinForms.Controls.SfButton();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiHangTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
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
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
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
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
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
            this.btnDeleteCustomer.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnDeleteCustomer.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.TabIndex = 4;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
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
            this.btnRecoverCustomer.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnRecoverCustomer.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverCustomer.TabIndex = 5;
            this.btnRecoverCustomer.Text = "Khôi phục";
            this.btnRecoverCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverCustomer.UseVisualStyleBackColor = false;
            this.btnRecoverCustomer.Click += new System.EventHandler(this.btnRecoverCustomer_Click);
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
            this.spcQuery.Panel1.Controls.Add(this.dgvCustomer);
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
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeColumns = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaTaiKhoan,
            this.MaLoaiHangTV,
            this.HinhAnh,
            this.HoTen,
            this.CCCD,
            this.NgaySinh,
            this.SDT,
            this.Email,
            this.DiaChi,
            this.TrangThai});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.Size = new System.Drawing.Size(973, 746);
            this.dgvCustomer.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã khách hàng";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // MaTaiKhoan
            // 
            this.MaTaiKhoan.HeaderText = "Mã tài khoản";
            this.MaTaiKhoan.Name = "MaTaiKhoan";
            this.MaTaiKhoan.ReadOnly = true;
            // 
            // MaLoaiHangTV
            // 
            this.MaLoaiHangTV.HeaderText = "Hạng thành viên";
            this.MaLoaiHangTV.Name = "MaLoaiHangTV";
            this.MaLoaiHangTV.ReadOnly = true;
            // 
            // HinhAnh
            // 
            this.HinhAnh.HeaderText = "Hình ảnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // CCCD
            // 
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiHangTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}
