﻿namespace GUI.UserControls
{
    partial class ucRating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRating));
            this.lblRating = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRating = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditRating = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteRating = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverRating = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchRating = new System.Windows.Forms.TextBox();
            this.btnTraCuuRating = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateRating = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dtpNgayDanhGia = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDanhGia = new System.Windows.Forms.Label();
            this.cboSortRatingID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortRatingID = new System.Windows.Forms.Label();
            this.cboRatingValue = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblRatingValue = new System.Windows.Forms.Label();
            this.lblStateRating = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.dgvRating = new System.Windows.Forms.DataGridView();
            this.colMaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanXet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRatingID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRatingValue)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).BeginInit();
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
            this.lblRating.TabIndex = 35;
            this.lblRating.Text = "RATINGS";
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddRating, 0, 0);
            this.tlpController.Controls.Add(this.btnEditRating, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteRating, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverRating, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddRating
            // 
            this.btnAddRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRating.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRating.ForeColor = System.Drawing.Color.White;
            this.btnAddRating.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddRating.Location = new System.Drawing.Point(3, 3);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(191, 41);
            this.btnAddRating.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRating.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddRating.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddRating.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddRating.TabIndex = 1;
            this.btnAddRating.Text = "Thêm";
            this.btnAddRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRating.UseVisualStyleBackColor = false;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
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
            this.btnEditRating.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditRating.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditRating.TabIndex = 3;
            this.btnEditRating.Text = "Sửa";
            this.btnEditRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditRating.UseVisualStyleBackColor = false;
            this.btnEditRating.Click += new System.EventHandler(this.btnEditRating_Click);
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
            this.btnDeleteRating.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnDeleteRating.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteRating.TabIndex = 4;
            this.btnDeleteRating.Text = "Xóa";
            this.btnDeleteRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnRecoverRating.UseVisualStyleBackColor = false;
            this.btnRecoverRating.Click += new System.EventHandler(this.btnRecoverRating_Click);
            // 
            // txtSearchRating
            // 
            this.txtSearchRating.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRating.Location = new System.Drawing.Point(6, 16);
            this.txtSearchRating.Name = "txtSearchRating";
            this.txtSearchRating.Size = new System.Drawing.Size(251, 40);
            this.txtSearchRating.TabIndex = 2;
            // 
            // btnTraCuuRating
            // 
            this.btnTraCuuRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuRating.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuRating.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRating.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuRating.Name = "btnTraCuuRating";
            this.btnTraCuuRating.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuRating.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRating.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRating.TabIndex = 0;
            this.btnTraCuuRating.Text = "Tra cứu";
            this.btnTraCuuRating.UseVisualStyleBackColor = false;
            // 
            // cboStateRating
            // 
            this.cboStateRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateRating.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateRating.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateRating.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRating.Location = new System.Drawing.Point(226, 233);
            this.cboStateRating.Name = "cboStateRating";
            this.cboStateRating.Size = new System.Drawing.Size(156, 33);
            this.cboStateRating.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateRating.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRating.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRating.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateRating.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRating.TabIndex = 3;
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
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayDanhGia);
            this.spcQuery.Panel2.Controls.Add(this.lblNgayDanhGia);
            this.spcQuery.Panel2.Controls.Add(this.cboSortRatingID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortRatingID);
            this.spcQuery.Panel2.Controls.Add(this.cboRatingValue);
            this.spcQuery.Panel2.Controls.Add(this.lblRatingValue);
            this.spcQuery.Panel2.Controls.Add(this.lblStateRating);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchRating);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuRating);
            this.spcQuery.Panel2.Controls.Add(this.cboStateRating);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dtpNgayDanhGia
            // 
            this.dtpNgayDanhGia.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDanhGia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDanhGia.Location = new System.Drawing.Point(182, 192);
            this.dtpNgayDanhGia.Name = "dtpNgayDanhGia";
            this.dtpNgayDanhGia.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayDanhGia.TabIndex = 31;
            // 
            // lblNgayDanhGia
            // 
            this.lblNgayDanhGia.AutoSize = true;
            this.lblNgayDanhGia.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDanhGia.Location = new System.Drawing.Point(1, 193);
            this.lblNgayDanhGia.Name = "lblNgayDanhGia";
            this.lblNgayDanhGia.Size = new System.Drawing.Size(155, 26);
            this.lblNgayDanhGia.TabIndex = 30;
            this.lblNgayDanhGia.Text = "Ngày đánh giá";
            this.lblNgayDanhGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortRatingID
            // 
            this.cboSortRatingID.DelimiterChar = "";
            this.cboSortRatingID.DisplayMember = "";
            this.cboSortRatingID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortRatingID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortRatingID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRatingID.Location = new System.Drawing.Point(226, 79);
            this.cboSortRatingID.Name = "cboSortRatingID";
            this.cboSortRatingID.Size = new System.Drawing.Size(156, 33);
            this.cboSortRatingID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortRatingID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRatingID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRatingID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortRatingID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRatingID.TabIndex = 29;
            // 
            // lblSortRatingID
            // 
            this.lblSortRatingID.AutoSize = true;
            this.lblSortRatingID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortRatingID.Location = new System.Drawing.Point(2, 86);
            this.lblSortRatingID.Name = "lblSortRatingID";
            this.lblSortRatingID.Size = new System.Drawing.Size(221, 26);
            this.lblSortRatingID.TabIndex = 28;
            this.lblSortRatingID.Text = "Sort theo ID đánh giá";
            this.lblSortRatingID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRatingValue
            // 
            this.cboRatingValue.DelimiterChar = "";
            this.cboRatingValue.DisplayMember = "";
            this.cboRatingValue.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboRatingValue.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboRatingValue.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRatingValue.Location = new System.Drawing.Point(227, 136);
            this.cboRatingValue.Name = "cboRatingValue";
            this.cboRatingValue.Size = new System.Drawing.Size(156, 33);
            this.cboRatingValue.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboRatingValue.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRatingValue.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRatingValue.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboRatingValue.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRatingValue.TabIndex = 23;
            // 
            // lblRatingValue
            // 
            this.lblRatingValue.AutoSize = true;
            this.lblRatingValue.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingValue.Location = new System.Drawing.Point(2, 143);
            this.lblRatingValue.Name = "lblRatingValue";
            this.lblRatingValue.Size = new System.Drawing.Size(179, 26);
            this.lblRatingValue.TabIndex = 14;
            this.lblRatingValue.Text = "Lọc theo số điểm";
            this.lblRatingValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateRating
            // 
            this.lblStateRating.AutoSize = true;
            this.lblStateRating.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateRating.Location = new System.Drawing.Point(2, 240);
            this.lblStateRating.Name = "lblStateRating";
            this.lblStateRating.Size = new System.Drawing.Size(186, 26);
            this.lblStateRating.TabIndex = 9;
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
            // dgvRating
            // 
            this.dgvRating.AllowUserToAddRows = false;
            this.dgvRating.AllowUserToDeleteRows = false;
            this.dgvRating.AllowUserToResizeColumns = false;
            this.dgvRating.AllowUserToResizeRows = false;
            this.dgvRating.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgvRating.TabIndex = 0;
            // 
            // colMaDG
            // 
            this.colMaDG.HeaderText = "Mã đánh giá";
            this.colMaDG.Name = "colMaDG";
            this.colMaDG.ReadOnly = true;
            // 
            // colMaDP
            // 
            this.colMaDP.HeaderText = "Mã đặt phòng";
            this.colMaDP.Name = "colMaDP";
            this.colMaDP.ReadOnly = true;
            // 
            // colDiemDG
            // 
            this.colDiemDG.HeaderText = "Điểm đánh giá";
            this.colDiemDG.Name = "colDiemDG";
            this.colDiemDG.ReadOnly = true;
            // 
            // colNhanXet
            // 
            this.colNhanXet.HeaderText = "Nhận xét";
            this.colNhanXet.Name = "colNhanXet";
            this.colNhanXet.ReadOnly = true;
            // 
            // colNgayDG
            // 
            this.colNgayDG.HeaderText = "Ngày đánh giá";
            this.colNgayDG.Name = "colNgayDG";
            this.colNgayDG.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Visible = false;
            // 
            // ucRating
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucRating";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucRating_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRating)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRatingID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRatingValue)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRating;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuRating;
        private Syncfusion.WinForms.Controls.SfButton btnAddRating;
        private System.Windows.Forms.TextBox txtSearchRating;
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
        private Syncfusion.WinForms.ListView.SfComboBox cboSortRatingID;
        private System.Windows.Forms.Label lblSortRatingID;
        private System.Windows.Forms.DateTimePicker dtpNgayDanhGia;
        private System.Windows.Forms.Label lblNgayDanhGia;
        private System.Windows.Forms.DataGridView dgvRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanXet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
