namespace GUI.UserControls
{
    partial class ucHousekeeping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHousekeeping));
            this.lblHousekeeping = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchHousekeeping = new System.Windows.Forms.TextBox();
            this.btnTraCuuHousekeeping = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateHousekeeping = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dtpNgayHoanThanh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.lblNgayHoanThanh = new System.Windows.Forms.Label();
            this.cboSortHousekeeping = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortHousekeepingID = new System.Windows.Forms.Label();
            this.lblLocNgayNhan = new System.Windows.Forms.Label();
            this.lblStateHousekeeping = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.dgvHousekeeping = new System.Windows.Forms.DataGridView();
            this.btnAddHousekeeping = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditHousekeeping = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteHousekeeping = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverHousekeeping = new Syncfusion.WinForms.Controls.SfButton();
            this.colMaDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHoanThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateHousekeeping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortHousekeeping)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHousekeeping)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHousekeeping
            // 
            this.lblHousekeeping.BackColor = System.Drawing.Color.Lavender;
            this.lblHousekeeping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHousekeeping.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHousekeeping.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblHousekeeping.Location = new System.Drawing.Point(0, 0);
            this.lblHousekeeping.Name = "lblHousekeeping";
            this.lblHousekeeping.Size = new System.Drawing.Size(972, 94);
            this.lblHousekeeping.TabIndex = 35;
            this.lblHousekeeping.Text = "HOUSEKEEPING";
            this.lblHousekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddHousekeeping, 0, 0);
            this.tlpController.Controls.Add(this.btnEditHousekeeping, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteHousekeeping, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverHousekeeping, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // txtSearchHousekeeping
            // 
            this.txtSearchHousekeeping.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchHousekeeping.Location = new System.Drawing.Point(6, 16);
            this.txtSearchHousekeeping.Name = "txtSearchHousekeeping";
            this.txtSearchHousekeeping.Size = new System.Drawing.Size(251, 40);
            this.txtSearchHousekeeping.TabIndex = 2;
            // 
            // btnTraCuuHousekeeping
            // 
            this.btnTraCuuHousekeeping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuHousekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuHousekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuHousekeeping.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuHousekeeping.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuHousekeeping.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuHousekeeping.Name = "btnTraCuuHousekeeping";
            this.btnTraCuuHousekeeping.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuHousekeeping.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuHousekeeping.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuHousekeeping.TabIndex = 0;
            this.btnTraCuuHousekeeping.Text = "Tra cứu";
            this.btnTraCuuHousekeeping.UseVisualStyleBackColor = false;
            // 
            // cboStateHousekeeping
            // 
            this.cboStateHousekeeping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateHousekeeping.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateHousekeeping.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateHousekeeping.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateHousekeeping.Location = new System.Drawing.Point(221, 257);
            this.cboStateHousekeeping.Name = "cboStateHousekeeping";
            this.cboStateHousekeeping.Size = new System.Drawing.Size(156, 33);
            this.cboStateHousekeeping.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateHousekeeping.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateHousekeeping.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateHousekeeping.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateHousekeeping.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateHousekeeping.TabIndex = 3;
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
            this.spcQuery.Panel1.Controls.Add(this.dgvHousekeeping);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayHoanThanh);
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayNhan);
            this.spcQuery.Panel2.Controls.Add(this.lblNgayHoanThanh);
            this.spcQuery.Panel2.Controls.Add(this.cboSortHousekeeping);
            this.spcQuery.Panel2.Controls.Add(this.lblSortHousekeepingID);
            this.spcQuery.Panel2.Controls.Add(this.lblLocNgayNhan);
            this.spcQuery.Panel2.Controls.Add(this.lblStateHousekeeping);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchHousekeeping);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuHousekeeping);
            this.spcQuery.Panel2.Controls.Add(this.cboStateHousekeeping);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dtpNgayHoanThanh
            // 
            this.dtpNgayHoanThanh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHoanThanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHoanThanh.Location = new System.Drawing.Point(182, 197);
            this.dtpNgayHoanThanh.Name = "dtpNgayHoanThanh";
            this.dtpNgayHoanThanh.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayHoanThanh.TabIndex = 32;
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhan.Location = new System.Drawing.Point(182, 138);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayNhan.TabIndex = 31;
            // 
            // lblNgayHoanThanh
            // 
            this.lblNgayHoanThanh.AutoSize = true;
            this.lblNgayHoanThanh.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHoanThanh.Location = new System.Drawing.Point(1, 198);
            this.lblNgayHoanThanh.Name = "lblNgayHoanThanh";
            this.lblNgayHoanThanh.Size = new System.Drawing.Size(182, 26);
            this.lblNgayHoanThanh.TabIndex = 30;
            this.lblNgayHoanThanh.Text = "Ngày hoàn thành";
            this.lblNgayHoanThanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortHousekeeping
            // 
            this.cboSortHousekeeping.DelimiterChar = "";
            this.cboSortHousekeeping.DisplayMember = "";
            this.cboSortHousekeeping.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortHousekeeping.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortHousekeeping.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortHousekeeping.Location = new System.Drawing.Point(226, 75);
            this.cboSortHousekeeping.Name = "cboSortHousekeeping";
            this.cboSortHousekeeping.Size = new System.Drawing.Size(156, 33);
            this.cboSortHousekeeping.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortHousekeeping.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortHousekeeping.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortHousekeeping.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortHousekeeping.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortHousekeeping.TabIndex = 29;
            // 
            // lblSortHousekeepingID
            // 
            this.lblSortHousekeepingID.AutoSize = true;
            this.lblSortHousekeepingID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortHousekeepingID.Location = new System.Drawing.Point(-3, 82);
            this.lblSortHousekeepingID.Name = "lblSortHousekeepingID";
            this.lblSortHousekeepingID.Size = new System.Drawing.Size(228, 26);
            this.lblSortHousekeepingID.TabIndex = 28;
            this.lblSortHousekeepingID.Text = "Sort Housekeeping ID";
            this.lblSortHousekeepingID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocNgayNhan
            // 
            this.lblLocNgayNhan.AutoSize = true;
            this.lblLocNgayNhan.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocNgayNhan.Location = new System.Drawing.Point(3, 139);
            this.lblLocNgayNhan.Name = "lblLocNgayNhan";
            this.lblLocNgayNhan.Size = new System.Drawing.Size(119, 26);
            this.lblLocNgayNhan.TabIndex = 14;
            this.lblLocNgayNhan.Text = "Ngày nhận";
            this.lblLocNgayNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateHousekeeping
            // 
            this.lblStateHousekeeping.AutoSize = true;
            this.lblStateHousekeeping.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateHousekeeping.Location = new System.Drawing.Point(-3, 264);
            this.lblStateHousekeeping.Name = "lblStateHousekeeping";
            this.lblStateHousekeeping.Size = new System.Drawing.Size(186, 26);
            this.lblStateHousekeeping.TabIndex = 9;
            this.lblStateHousekeeping.Text = "Trạng thái dữ liệu";
            this.lblStateHousekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblHousekeeping);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // dgvHousekeeping
            // 
            this.dgvHousekeeping.AllowUserToAddRows = false;
            this.dgvHousekeeping.AllowUserToDeleteRows = false;
            this.dgvHousekeeping.AllowUserToResizeColumns = false;
            this.dgvHousekeeping.AllowUserToResizeRows = false;
            this.dgvHousekeeping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHousekeeping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHousekeeping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDP,
            this.colMaPhong,
            this.colMaNV,
            this.colNgayNhan,
            this.colNgayHoanThanh,
            this.colTrangThai});
            this.dgvHousekeeping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHousekeeping.Location = new System.Drawing.Point(0, 0);
            this.dgvHousekeeping.MultiSelect = false;
            this.dgvHousekeeping.Name = "dgvHousekeeping";
            this.dgvHousekeeping.ReadOnly = true;
            this.dgvHousekeeping.RowHeadersVisible = false;
            this.dgvHousekeeping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHousekeeping.Size = new System.Drawing.Size(973, 746);
            this.dgvHousekeeping.TabIndex = 0;
            // 
            // btnAddHousekeeping
            // 
            this.btnAddHousekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddHousekeeping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddHousekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHousekeeping.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHousekeeping.ForeColor = System.Drawing.Color.White;
            this.btnAddHousekeeping.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddHousekeeping.Location = new System.Drawing.Point(3, 3);
            this.btnAddHousekeeping.Name = "btnAddHousekeeping";
            this.btnAddHousekeeping.Size = new System.Drawing.Size(191, 41);
            this.btnAddHousekeeping.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddHousekeeping.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddHousekeeping.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddHousekeeping.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddHousekeeping.TabIndex = 1;
            this.btnAddHousekeeping.Text = "Thêm";
            this.btnAddHousekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddHousekeeping.UseVisualStyleBackColor = false;
            this.btnAddHousekeeping.Click += new System.EventHandler(this.btnAddHousekeeping_Click);
            // 
            // btnEditHousekeeping
            // 
            this.btnEditHousekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditHousekeeping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditHousekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditHousekeeping.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditHousekeeping.ForeColor = System.Drawing.Color.White;
            this.btnEditHousekeeping.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditHousekeeping.Location = new System.Drawing.Point(3, 50);
            this.btnEditHousekeeping.Name = "btnEditHousekeeping";
            this.btnEditHousekeeping.Size = new System.Drawing.Size(191, 41);
            this.btnEditHousekeeping.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditHousekeeping.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditHousekeeping.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditHousekeeping.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditHousekeeping.TabIndex = 3;
            this.btnEditHousekeeping.Text = "Sửa";
            this.btnEditHousekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditHousekeeping.UseVisualStyleBackColor = false;
            this.btnEditHousekeeping.Click += new System.EventHandler(this.btnEditHousekeeping_Click);
            // 
            // btnDeleteHousekeeping
            // 
            this.btnDeleteHousekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteHousekeeping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteHousekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHousekeeping.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHousekeeping.ForeColor = System.Drawing.Color.White;
            this.btnDeleteHousekeeping.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteHousekeeping.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteHousekeeping.Name = "btnDeleteHousekeeping";
            this.btnDeleteHousekeeping.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteHousekeeping.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteHousekeeping.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteHousekeeping.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnDeleteHousekeeping.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteHousekeeping.TabIndex = 4;
            this.btnDeleteHousekeeping.Text = "Xóa";
            this.btnDeleteHousekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteHousekeeping.UseVisualStyleBackColor = false;
            this.btnDeleteHousekeeping.Click += new System.EventHandler(this.btnDeleteHousekeeping_Click);
            // 
            // btnRecoverHousekeeping
            // 
            this.btnRecoverHousekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverHousekeeping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverHousekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverHousekeeping.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverHousekeeping.ForeColor = System.Drawing.Color.White;
            this.btnRecoverHousekeeping.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverHousekeeping.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverHousekeeping.Name = "btnRecoverHousekeeping";
            this.btnRecoverHousekeeping.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverHousekeeping.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverHousekeeping.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverHousekeeping.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnRecoverHousekeeping.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverHousekeeping.TabIndex = 5;
            this.btnRecoverHousekeeping.Text = "Khôi phục";
            this.btnRecoverHousekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverHousekeeping.UseVisualStyleBackColor = false;
            this.btnRecoverHousekeeping.Click += new System.EventHandler(this.btnRecoverHousekeeping_Click);
            // 
            // colMaDP
            // 
            this.colMaDP.HeaderText = "Mã dọn phòng";
            this.colMaDP.Name = "colMaDP";
            this.colMaDP.ReadOnly = true;
            // 
            // colMaPhong
            // 
            this.colMaPhong.HeaderText = "Mã phòng";
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.ReadOnly = true;
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            // 
            // colNgayNhan
            // 
            this.colNgayNhan.HeaderText = "Ngày nhận";
            this.colNgayNhan.Name = "colNgayNhan";
            this.colNgayNhan.ReadOnly = true;
            // 
            // colNgayHoanThanh
            // 
            this.colNgayHoanThanh.HeaderText = "Ngày hoàn thành";
            this.colNgayHoanThanh.Name = "colNgayHoanThanh";
            this.colNgayHoanThanh.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Visible = false;
            // 
            // ucHousekeeping
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucHousekeeping";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucHousekeeping_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateHousekeeping)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboSortHousekeeping)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHousekeeping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHousekeeping;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuHousekeeping;
        private Syncfusion.WinForms.Controls.SfButton btnAddHousekeeping;
        private System.Windows.Forms.TextBox txtSearchHousekeeping;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteHousekeeping;
        private Syncfusion.WinForms.Controls.SfButton btnEditHousekeeping;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverHousekeeping;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateHousekeeping;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateHousekeeping;
        private System.Windows.Forms.Label lblLocNgayNhan;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortHousekeeping;
        private System.Windows.Forms.Label lblSortHousekeepingID;
        private System.Windows.Forms.Label lblNgayHoanThanh;
        private System.Windows.Forms.DateTimePicker dtpNgayHoanThanh;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.DataGridView dgvHousekeeping;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
