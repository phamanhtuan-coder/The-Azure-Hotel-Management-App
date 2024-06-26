﻿namespace GUI.UserControls
{
    partial class ucRatingHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRatingHistory));
            this.lblRating = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditRating = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDanhGia = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteRating = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverRating = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateRating = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvRating = new System.Windows.Forms.DataGridView();
            this.colMaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanXet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new Syncfusion.WinForms.Controls.SfButton();
            this.dtpNgayDanhGia = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDanhGia = new System.Windows.Forms.Label();
            this.cboRatingValue = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblRatingValue = new System.Windows.Forms.Label();
            this.lblStateRating = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRatingValue)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRating
            // 
            this.lblRating.BackColor = System.Drawing.Color.Lavender;
            this.lblRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRating.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRating.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRating.Location = new System.Drawing.Point(0, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(972, 94);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "LỊCH SỬ ĐÁNH GIÁ";
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnEditRating, 0, 1);
            this.tlpController.Controls.Add(this.btnDanhGia, 0, 0);
            this.tlpController.Controls.Add(this.btnDeleteRating, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverRating, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnEditRating
            // 
            this.btnEditRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRating.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRating.ForeColor = System.Drawing.Color.White;
            this.btnEditRating.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditRating.Location = new System.Drawing.Point(3, 50);
            this.btnEditRating.Name = "btnEditRating";
            this.btnEditRating.Size = new System.Drawing.Size(191, 41);
            this.btnEditRating.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditRating.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditRating.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnEditRating.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditRating.TabIndex = 4;
            this.btnEditRating.Text = "Sửa";
            this.btnEditRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditRating, "Sửa đánh giá");
            this.btnEditRating.UseVisualStyleBackColor = false;
            this.btnEditRating.Click += new System.EventHandler(this.btnEditRating_Click);
            // 
            // btnDanhGia
            // 
            this.btnDanhGia.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDanhGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDanhGia.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.btnDanhGia.ForeColor = System.Drawing.Color.White;
            this.btnDanhGia.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDanhGia.Location = new System.Drawing.Point(3, 3);
            this.btnDanhGia.Name = "btnDanhGia";
            this.btnDanhGia.Size = new System.Drawing.Size(191, 41);
            this.btnDanhGia.Style.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDanhGia.Style.ForeColor = System.Drawing.Color.White;
            this.btnDanhGia.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnDanhGia.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDanhGia.TabIndex = 7;
            this.btnDanhGia.Text = "Đánh giá";
            this.toolTip1.SetToolTip(this.btnDanhGia, "Đánh giá");
            this.btnDanhGia.UseVisualStyleBackColor = false;
            this.btnDanhGia.Click += new System.EventHandler(this.btnDanhGia_Click);
            // 
            // btnDeleteRating
            // 
            this.btnDeleteRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRating.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRating.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRating.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteRating.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteRating.Name = "btnDeleteRating";
            this.btnDeleteRating.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteRating.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRating.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRating.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteRating.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteRating.TabIndex = 3;
            this.btnDeleteRating.Text = "Xóa";
            this.btnDeleteRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteRating, "Xóa đánh giá");
            this.btnDeleteRating.UseVisualStyleBackColor = false;
            this.btnDeleteRating.Click += new System.EventHandler(this.btnDeleteRating_Click);
            // 
            // btnRecoverRating
            // 
            this.btnRecoverRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverRating.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverRating.ForeColor = System.Drawing.Color.White;
            this.btnRecoverRating.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverRating.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverRating.Name = "btnRecoverRating";
            this.btnRecoverRating.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverRating.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverRating.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverRating.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnRecoverRating.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverRating.TabIndex = 5;
            this.btnRecoverRating.Text = "Khôi phục";
            this.btnRecoverRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRecoverRating, "Khôi phụcđánh giá");
            this.btnRecoverRating.UseVisualStyleBackColor = false;
            this.btnRecoverRating.Click += new System.EventHandler(this.btnRecoverRating_Click);
            // 
            // cboStateRating
            // 
            this.cboStateRating.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateRating.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateRating.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRating.Location = new System.Drawing.Point(234, 116);
            this.cboStateRating.Name = "cboStateRating";
            this.cboStateRating.Size = new System.Drawing.Size(143, 33);
            this.cboStateRating.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateRating.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRating.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRating.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateRating.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRating.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cboStateRating, "Lọc theo trạng thái");
            this.cboStateRating.SelectedIndexChanged += new System.EventHandler(this.cboStateRating_SelectedIndexChanged);
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
            this.spcQuery.Panel1.Controls.Add(this.dgvRating);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.btnReturn);
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayDanhGia);
            this.spcQuery.Panel2.Controls.Add(this.lblNgayDanhGia);
            this.spcQuery.Panel2.Controls.Add(this.cboRatingValue);
            this.spcQuery.Panel2.Controls.Add(this.lblRatingValue);
            this.spcQuery.Panel2.Controls.Add(this.lblStateRating);
            this.spcQuery.Panel2.Controls.Add(this.cboStateRating);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvRating
            // 
            this.dgvRating.AllowUserToAddRows = false;
            this.dgvRating.AllowUserToDeleteRows = false;
            this.dgvRating.AllowUserToResizeColumns = false;
            this.dgvRating.AllowUserToResizeRows = false;
            this.dgvRating.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDG,
            this.colMaDP,
            this.colDiemDG,
            this.colNhanXet,
            this.colNgayDG,
            this.colTrangThai});
            this.dgvRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRating.Location = new System.Drawing.Point(0, 0);
            this.dgvRating.MultiSelect = false;
            this.dgvRating.Name = "dgvRating";
            this.dgvRating.ReadOnly = true;
            this.dgvRating.RowHeadersVisible = false;
            this.dgvRating.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRating.Size = new System.Drawing.Size(973, 746);
            this.dgvRating.TabIndex = 6;
            // 
            // colMaDG
            // 
            this.colMaDG.DataPropertyName = "MaDG";
            this.colMaDG.HeaderText = "Mã đánh giá";
            this.colMaDG.Name = "colMaDG";
            this.colMaDG.ReadOnly = true;
            this.colMaDG.Visible = false;
            // 
            // colMaDP
            // 
            this.colMaDP.DataPropertyName = "MaDP";
            this.colMaDP.HeaderText = "Mã đặt phòng";
            this.colMaDP.Name = "colMaDP";
            this.colMaDP.ReadOnly = true;
            this.colMaDP.Width = 147;
            // 
            // colDiemDG
            // 
            this.colDiemDG.DataPropertyName = "DiemDanhGia";
            this.colDiemDG.HeaderText = "Điểm đánh giá";
            this.colDiemDG.Name = "colDiemDG";
            this.colDiemDG.ReadOnly = true;
            this.colDiemDG.Width = 153;
            // 
            // colNhanXet
            // 
            this.colNhanXet.DataPropertyName = "NhanXet";
            this.colNhanXet.HeaderText = "Nhận xét";
            this.colNhanXet.Name = "colNhanXet";
            this.colNhanXet.ReadOnly = true;
            this.colNhanXet.Width = 108;
            // 
            // colNgayDG
            // 
            this.colNgayDG.DataPropertyName = "NgayDanhGia";
            this.colNgayDG.HeaderText = "Ngày đánh giá";
            this.colNgayDG.Name = "colNgayDG";
            this.colNgayDG.ReadOnly = true;
            this.colNgayDG.Width = 151;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturn.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReturn.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(104, 180);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(191, 41);
            this.btnReturn.Style.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReturn.Style.ForeColor = System.Drawing.Color.White;
            this.btnReturn.TabIndex = 32;
            this.btnReturn.Text = "Quay lại";
            this.toolTip1.SetToolTip(this.btnReturn, "Quay lại");
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtpNgayDanhGia
            // 
            this.dtpNgayDanhGia.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDanhGia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDanhGia.Location = new System.Drawing.Point(234, 69);
            this.dtpNgayDanhGia.Name = "dtpNgayDanhGia";
            this.dtpNgayDanhGia.Size = new System.Drawing.Size(143, 27);
            this.dtpNgayDanhGia.TabIndex = 31;
            this.toolTip1.SetToolTip(this.dtpNgayDanhGia, "Ngày đánh giá");
            this.dtpNgayDanhGia.ValueChanged += new System.EventHandler(this.dtpNgayDanhGia_ValueChanged);
            // 
            // lblNgayDanhGia
            // 
            this.lblNgayDanhGia.AutoSize = true;
            this.lblNgayDanhGia.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDanhGia.Location = new System.Drawing.Point(9, 70);
            this.lblNgayDanhGia.Name = "lblNgayDanhGia";
            this.lblNgayDanhGia.Size = new System.Drawing.Size(155, 26);
            this.lblNgayDanhGia.TabIndex = 10;
            this.lblNgayDanhGia.Text = "Ngày đánh giá";
            // 
            // cboRatingValue
            // 
            this.cboRatingValue.DelimiterChar = "";
            this.cboRatingValue.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboRatingValue.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboRatingValue.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRatingValue.Location = new System.Drawing.Point(234, 15);
            this.cboRatingValue.Name = "cboRatingValue";
            this.cboRatingValue.Size = new System.Drawing.Size(143, 33);
            this.cboRatingValue.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboRatingValue.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRatingValue.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRatingValue.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboRatingValue.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRatingValue.TabIndex = 23;
            this.toolTip1.SetToolTip(this.cboRatingValue, "Lọc theo số điểm");
            this.cboRatingValue.SelectedIndexChanged += new System.EventHandler(this.cboRatingValue_SelectedIndexChanged);
            // 
            // lblRatingValue
            // 
            this.lblRatingValue.AutoSize = true;
            this.lblRatingValue.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingValue.Location = new System.Drawing.Point(9, 22);
            this.lblRatingValue.Name = "lblRatingValue";
            this.lblRatingValue.Size = new System.Drawing.Size(179, 26);
            this.lblRatingValue.TabIndex = 8;
            this.lblRatingValue.Text = "Lọc theo số điểm";
            this.lblRatingValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateRating
            // 
            this.lblStateRating.AutoSize = true;
            this.lblStateRating.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateRating.Location = new System.Drawing.Point(9, 123);
            this.lblStateRating.Name = "lblStateRating";
            this.lblStateRating.Size = new System.Drawing.Size(186, 26);
            this.lblStateRating.TabIndex = 12;
            this.lblStateRating.Text = "Trạng thái dữ liệu";
            this.lblStateRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblRating);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucRatingHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucRatingHistory";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucRating_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRating)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRatingValue)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRating;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteRating;
        private Syncfusion.WinForms.Controls.SfButton btnEditRating;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverRating;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateRating;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateRating;
        private System.Windows.Forms.Label lblRatingValue;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboRatingValue;
        private System.Windows.Forms.DateTimePicker dtpNgayDanhGia;
        private System.Windows.Forms.Label lblNgayDanhGia;
        private System.Windows.Forms.DataGridView dgvRating;
        private Syncfusion.WinForms.Controls.SfButton btnDanhGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanXet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.ToolTip toolTip1;
        private Syncfusion.WinForms.Controls.SfButton btnReturn;
    }
}
