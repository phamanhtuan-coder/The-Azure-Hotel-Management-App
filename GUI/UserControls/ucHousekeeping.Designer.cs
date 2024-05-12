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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHousekeeping));
            this.lblHousekeeping = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddHousekeeping = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditHousekeeping = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteHousekeeping = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverHousekeeping = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchHousekeeping = new System.Windows.Forms.TextBox();
            this.btnTraCuuHousekeeping = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateHousekeeping = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvHousekeeping = new System.Windows.Forms.DataGridView();
            this.colMaDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHoanThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.cboSortHousekeeping = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortHousekeepingID = new System.Windows.Forms.Label();
            this.lblLocNgayNhan = new System.Windows.Forms.Label();
            this.lblStateHousekeeping = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateHousekeeping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHousekeeping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortHousekeeping)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHousekeeping
            // 
            this.lblHousekeeping.BackColor = System.Drawing.Color.Lavender;
            this.lblHousekeeping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHousekeeping.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHousekeeping.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblHousekeeping.Location = new System.Drawing.Point(0, 0);
            this.lblHousekeeping.Name = "lblHousekeeping";
            this.lblHousekeeping.Size = new System.Drawing.Size(972, 94);
            this.lblHousekeeping.TabIndex = 1;
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
            // btnAddHousekeeping
            // 
            this.btnAddHousekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddHousekeeping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddHousekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHousekeeping.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHousekeeping.ForeColor = System.Drawing.Color.White;
            this.btnAddHousekeeping.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddHousekeeping.Location = new System.Drawing.Point(3, 3);
            this.btnAddHousekeeping.Name = "btnAddHousekeeping";
            this.btnAddHousekeeping.Size = new System.Drawing.Size(191, 41);
            this.btnAddHousekeeping.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddHousekeeping.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddHousekeeping.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddHousekeeping.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddHousekeeping.TabIndex = 2;
            this.btnAddHousekeeping.Text = "Thêm";
            this.btnAddHousekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddHousekeeping, "Thêm dọn phòng");
            this.btnAddHousekeeping.UseVisualStyleBackColor = false;
            this.btnAddHousekeeping.Click += new System.EventHandler(this.btnAddHousekeeping_Click);
            // 
            // btnEditHousekeeping
            // 
            this.btnEditHousekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditHousekeeping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditHousekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditHousekeeping.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditHousekeeping.ForeColor = System.Drawing.Color.White;
            this.btnEditHousekeeping.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditHousekeeping.Location = new System.Drawing.Point(3, 50);
            this.btnEditHousekeeping.Name = "btnEditHousekeeping";
            this.btnEditHousekeeping.Size = new System.Drawing.Size(191, 41);
            this.btnEditHousekeeping.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditHousekeeping.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditHousekeeping.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditHousekeeping.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditHousekeeping.TabIndex = 4;
            this.btnEditHousekeeping.Text = "Sửa";
            this.btnEditHousekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditHousekeeping, "Sửa dọn phòng");
            this.btnEditHousekeeping.UseVisualStyleBackColor = false;
            this.btnEditHousekeeping.Click += new System.EventHandler(this.btnEditHousekeeping_Click);
            // 
            // btnDeleteHousekeeping
            // 
            this.btnDeleteHousekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteHousekeeping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteHousekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHousekeeping.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHousekeeping.ForeColor = System.Drawing.Color.White;
            this.btnDeleteHousekeeping.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteHousekeeping.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteHousekeeping.Name = "btnDeleteHousekeeping";
            this.btnDeleteHousekeeping.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteHousekeeping.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteHousekeeping.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteHousekeeping.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteHousekeeping.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteHousekeeping.TabIndex = 3;
            this.btnDeleteHousekeeping.Text = "Xóa";
            this.btnDeleteHousekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteHousekeeping, "Xóa dọn phòng");
            this.btnDeleteHousekeeping.UseVisualStyleBackColor = false;
            this.btnDeleteHousekeeping.Click += new System.EventHandler(this.btnDeleteHousekeeping_Click);
            // 
            // btnRecoverHousekeeping
            // 
            this.btnRecoverHousekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverHousekeeping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverHousekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverHousekeeping.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverHousekeeping.ForeColor = System.Drawing.Color.White;
            this.btnRecoverHousekeeping.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverHousekeeping.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverHousekeeping.Name = "btnRecoverHousekeeping";
            this.btnRecoverHousekeeping.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverHousekeeping.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverHousekeeping.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverHousekeeping.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverHousekeeping.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverHousekeeping.TabIndex = 5;
            this.btnRecoverHousekeeping.Text = "Khôi phục";
            this.btnRecoverHousekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRecoverHousekeeping, "Khôi phục dọn phòng");
            this.btnRecoverHousekeeping.UseVisualStyleBackColor = false;
            this.btnRecoverHousekeeping.Click += new System.EventHandler(this.btnRecoverHousekeeping_Click);
            // 
            // txtSearchHousekeeping
            // 
            this.txtSearchHousekeeping.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchHousekeeping.Location = new System.Drawing.Point(10, 16);
            this.txtSearchHousekeeping.Name = "txtSearchHousekeeping";
            this.txtSearchHousekeeping.Size = new System.Drawing.Size(248, 27);
            this.txtSearchHousekeeping.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSearchHousekeeping, "Nhập mã dọn phòng");
            // 
            // btnTraCuuHousekeeping
            // 
            this.btnTraCuuHousekeeping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuHousekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuHousekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuHousekeeping.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuHousekeeping.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuHousekeeping.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuHousekeeping.Name = "btnTraCuuHousekeeping";
            this.btnTraCuuHousekeeping.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuHousekeeping.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuHousekeeping.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuHousekeeping.TabIndex = 8;
            this.btnTraCuuHousekeeping.Text = "Tra cứu";
            this.toolTip1.SetToolTip(this.btnTraCuuHousekeeping, "Tra cứu");
            this.btnTraCuuHousekeeping.UseVisualStyleBackColor = false;
            this.btnTraCuuHousekeeping.Click += new System.EventHandler(this.btnTraCuuHousekeeping_Click);
            // 
            // cboStateHousekeeping
            // 
            this.cboStateHousekeeping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateHousekeeping.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateHousekeeping.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateHousekeeping.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateHousekeeping.Location = new System.Drawing.Point(226, 173);
            this.cboStateHousekeeping.Name = "cboStateHousekeeping";
            this.cboStateHousekeeping.Size = new System.Drawing.Size(156, 33);
            this.cboStateHousekeeping.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateHousekeeping.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateHousekeeping.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateHousekeeping.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateHousekeeping.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateHousekeeping.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cboStateHousekeeping, "Lọc trạng thái");
            this.cboStateHousekeeping.SelectedIndexChanged += new System.EventHandler(this.cboStateHousekeeping_SelectedIndexChanged);
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
            this.spcQuery.Panel2.Controls.Add(this.button1);
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayNhan);
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
            // dgvHousekeeping
            // 
            this.dgvHousekeeping.AllowUserToAddRows = false;
            this.dgvHousekeeping.AllowUserToDeleteRows = false;
            this.dgvHousekeeping.AllowUserToResizeColumns = false;
            this.dgvHousekeeping.AllowUserToResizeRows = false;
            this.dgvHousekeeping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.dgvHousekeeping.TabIndex = 6;
            // 
            // colMaDP
            // 
            this.colMaDP.DataPropertyName = "MaDonPhong";
            this.colMaDP.HeaderText = "Mã dọn phòng";
            this.colMaDP.Name = "colMaDP";
            this.colMaDP.ReadOnly = true;
            this.colMaDP.Width = 136;
            // 
            // colMaPhong
            // 
            this.colMaPhong.DataPropertyName = "MaPhong";
            this.colMaPhong.HeaderText = "Mã phòng";
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.ReadOnly = true;
            this.colMaPhong.Width = 105;
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaNV.HeaderText = "Nhân viên";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            this.colMaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaNV.Width = 104;
            // 
            // colNgayNhan
            // 
            this.colNgayNhan.DataPropertyName = "NgayNhan";
            this.colNgayNhan.HeaderText = "Ngày nhận";
            this.colNgayNhan.Name = "colNgayNhan";
            this.colNgayNhan.ReadOnly = true;
            this.colNgayNhan.Width = 110;
            // 
            // colNgayHoanThanh
            // 
            this.colNgayHoanThanh.DataPropertyName = "NgayHoanThanh";
            this.colNgayHoanThanh.HeaderText = "Ngày hoàn thành";
            this.colNgayHoanThanh.Name = "colNgayHoanThanh";
            this.colNgayHoanThanh.ReadOnly = true;
            this.colNgayHoanThanh.Width = 155;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Visible = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(354, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 31);
            this.button1.TabIndex = 13;
            this.toolTip1.SetToolTip(this.button1, "Tra cứu ngày nhân");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhan.Location = new System.Drawing.Point(226, 124);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(119, 27);
            this.dtpNgayNhan.TabIndex = 12;
            this.toolTip1.SetToolTip(this.dtpNgayNhan, "Ngày nhận");
            // 
            // cboSortHousekeeping
            // 
            this.cboSortHousekeeping.DelimiterChar = "";
            this.cboSortHousekeeping.DisplayMember = "";
            this.cboSortHousekeeping.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortHousekeeping.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortHousekeeping.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortHousekeeping.Location = new System.Drawing.Point(226, 71);
            this.cboSortHousekeeping.Name = "cboSortHousekeeping";
            this.cboSortHousekeeping.Size = new System.Drawing.Size(156, 33);
            this.cboSortHousekeeping.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortHousekeeping.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortHousekeeping.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortHousekeeping.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortHousekeeping.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortHousekeeping.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cboSortHousekeeping, "Sắp xếp mã dọn phòng");
            this.cboSortHousekeeping.SelectedIndexChanged += new System.EventHandler(this.cboSortHousekeeping_SelectedIndexChanged);
            // 
            // lblSortHousekeepingID
            // 
            this.lblSortHousekeepingID.AutoSize = true;
            this.lblSortHousekeepingID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortHousekeepingID.Location = new System.Drawing.Point(6, 80);
            this.lblSortHousekeepingID.Name = "lblSortHousekeepingID";
            this.lblSortHousekeepingID.Size = new System.Drawing.Size(193, 22);
            this.lblSortHousekeepingID.TabIndex = 9;
            this.lblSortHousekeepingID.Text = "Sort Housekeeping ID";
            this.lblSortHousekeepingID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocNgayNhan
            // 
            this.lblLocNgayNhan.AutoSize = true;
            this.lblLocNgayNhan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocNgayNhan.Location = new System.Drawing.Point(6, 126);
            this.lblLocNgayNhan.Name = "lblLocNgayNhan";
            this.lblLocNgayNhan.Size = new System.Drawing.Size(102, 22);
            this.lblLocNgayNhan.TabIndex = 11;
            this.lblLocNgayNhan.Text = "Ngày nhận";
            this.lblLocNgayNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateHousekeeping
            // 
            this.lblStateHousekeeping.AutoSize = true;
            this.lblStateHousekeeping.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateHousekeeping.Location = new System.Drawing.Point(8, 182);
            this.lblStateHousekeeping.Name = "lblStateHousekeeping";
            this.lblStateHousekeeping.Size = new System.Drawing.Size(159, 22);
            this.lblStateHousekeeping.TabIndex = 14;
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
            // ucHousekeeping
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvHousekeeping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortHousekeeping)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.DataGridView dgvHousekeeping;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
