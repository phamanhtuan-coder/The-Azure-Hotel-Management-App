namespace GUI.UserControls
{
    partial class ucDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDepartment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddDepartment = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditDepartment = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteDepartment = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverDepartment = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchDepartment = new System.Windows.Forms.TextBox();
            this.btnTraCuuDepartment = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateDepartment = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.colMaPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTruongPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhanChuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSortDepartment = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortDepartmentID = new System.Windows.Forms.Label();
            this.cboSortSoLuongNV = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortSoLuongNV = new System.Windows.Forms.Label();
            this.lblStateDepartment = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuongNV)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepartment
            // 
            this.lblDepartment.BackColor = System.Drawing.Color.Lavender;
            this.lblDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepartment.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDepartment.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDepartment.Location = new System.Drawing.Point(0, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(972, 94);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "DEPARTMENT";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddDepartment, 0, 0);
            this.tlpController.Controls.Add(this.btnEditDepartment, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteDepartment, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverDepartment, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddDepartment.Location = new System.Drawing.Point(3, 3);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(191, 41);
            this.btnAddDepartment.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddDepartment.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddDepartment.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.TabIndex = 2;
            this.btnAddDepartment.Text = "Thêm";
            this.btnAddDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddDepartment, "Thêm phòng ban");
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDepartment.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDepartment.ForeColor = System.Drawing.Color.White;
            this.btnEditDepartment.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditDepartment.Location = new System.Drawing.Point(3, 50);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(191, 41);
            this.btnEditDepartment.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditDepartment.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditDepartment.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditDepartment.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditDepartment.TabIndex = 4;
            this.btnEditDepartment.Text = "Sửa";
            this.btnEditDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditDepartment, "Sửa phòng ban");
            this.btnEditDepartment.UseVisualStyleBackColor = false;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDepartment.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDepartment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDepartment.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteDepartment.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteDepartment.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteDepartment.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDepartment.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteDepartment.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteDepartment.TabIndex = 3;
            this.btnDeleteDepartment.Text = "Xóa";
            this.btnDeleteDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteDepartment, "Xóa phòng ban");
            this.btnDeleteDepartment.UseVisualStyleBackColor = false;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // btnRecoverDepartment
            // 
            this.btnRecoverDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverDepartment.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverDepartment.ForeColor = System.Drawing.Color.White;
            this.btnRecoverDepartment.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverDepartment.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverDepartment.Name = "btnRecoverDepartment";
            this.btnRecoverDepartment.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverDepartment.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverDepartment.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverDepartment.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverDepartment.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverDepartment.TabIndex = 5;
            this.btnRecoverDepartment.Text = "Khôi phục";
            this.btnRecoverDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRecoverDepartment, "Khôi phục phòng ban");
            this.btnRecoverDepartment.UseVisualStyleBackColor = false;
            this.btnRecoverDepartment.Click += new System.EventHandler(this.btnRecoverDepartment_Click);
            // 
            // txtSearchDepartment
            // 
            this.txtSearchDepartment.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDepartment.Location = new System.Drawing.Point(6, 16);
            this.txtSearchDepartment.Name = "txtSearchDepartment";
            this.txtSearchDepartment.Size = new System.Drawing.Size(251, 40);
            this.txtSearchDepartment.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSearchDepartment, "Nhập mã phòng ban");
            // 
            // btnTraCuuDepartment
            // 
            this.btnTraCuuDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuDepartment.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuDepartment.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuDepartment.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuDepartment.Name = "btnTraCuuDepartment";
            this.btnTraCuuDepartment.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuDepartment.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuDepartment.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuDepartment.TabIndex = 8;
            this.btnTraCuuDepartment.Text = "Tra cứu";
            this.toolTip1.SetToolTip(this.btnTraCuuDepartment, "Tra cứu");
            this.btnTraCuuDepartment.UseVisualStyleBackColor = false;
            this.btnTraCuuDepartment.Click += new System.EventHandler(this.btnTraCuuDepartment_Click);
            // 
            // cboStateDepartment
            // 
            this.cboStateDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateDepartment.BackColor = System.Drawing.Color.White;
            this.cboStateDepartment.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateDepartment.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateDepartment.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateDepartment.Location = new System.Drawing.Point(226, 185);
            this.cboStateDepartment.Name = "cboStateDepartment";
            this.cboStateDepartment.Size = new System.Drawing.Size(156, 33);
            this.cboStateDepartment.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateDepartment.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.cboStateDepartment.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateDepartment.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateDepartment.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateDepartment.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateDepartment.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cboStateDepartment, "Lọc theo trạng thái");
            this.cboStateDepartment.SelectedIndexChanged += new System.EventHandler(this.cboStateDepartment_SelectedIndexChanged);
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
            this.spcQuery.Panel1.Controls.Add(this.dgvDepartment);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortDepartment);
            this.spcQuery.Panel2.Controls.Add(this.lblSortDepartmentID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortSoLuongNV);
            this.spcQuery.Panel2.Controls.Add(this.lblSortSoLuongNV);
            this.spcQuery.Panel2.Controls.Add(this.lblStateDepartment);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchDepartment);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuDepartment);
            this.spcQuery.Panel2.Controls.Add(this.cboStateDepartment);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AllowUserToAddRows = false;
            this.dgvDepartment.AllowUserToDeleteRows = false;
            this.dgvDepartment.AllowUserToResizeColumns = false;
            this.dgvDepartment.AllowUserToResizeRows = false;
            this.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhongBan,
            this.colTenPhong,
            this.colTruongPhong,
            this.colNgayNhanChuc,
            this.colTrangThai});
            this.dgvDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartment.Location = new System.Drawing.Point(0, 0);
            this.dgvDepartment.MultiSelect = false;
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.ReadOnly = true;
            this.dgvDepartment.RowHeadersVisible = false;
            this.dgvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartment.Size = new System.Drawing.Size(973, 746);
            this.dgvDepartment.TabIndex = 6;
            // 
            // colMaPhongBan
            // 
            this.colMaPhongBan.DataPropertyName = "MaPhongBan";
            this.colMaPhongBan.HeaderText = "Mã phòng ban";
            this.colMaPhongBan.Name = "colMaPhongBan";
            this.colMaPhongBan.ReadOnly = true;
            // 
            // colTenPhong
            // 
            this.colTenPhong.DataPropertyName = "TenPhong";
            this.colTenPhong.HeaderText = "Tên phòng ban";
            this.colTenPhong.Name = "colTenPhong";
            this.colTenPhong.ReadOnly = true;
            // 
            // colTruongPhong
            // 
            this.colTruongPhong.DataPropertyName = "TruongPhong";
            this.colTruongPhong.HeaderText = "Trưởng phòng";
            this.colTruongPhong.Name = "colTruongPhong";
            this.colTruongPhong.ReadOnly = true;
            // 
            // colNgayNhanChuc
            // 
            this.colNgayNhanChuc.DataPropertyName = "NgayNhanChuc";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.colNgayNhanChuc.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNgayNhanChuc.HeaderText = "Ngày nhận chức";
            this.colNgayNhanChuc.Name = "colNgayNhanChuc";
            this.colNgayNhanChuc.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Visible = false;
            // 
            // cboSortDepartment
            // 
            this.cboSortDepartment.BackColor = System.Drawing.Color.White;
            this.cboSortDepartment.DelimiterChar = "";
            this.cboSortDepartment.DisplayMember = "";
            this.cboSortDepartment.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortDepartment.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortDepartment.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDepartment.Location = new System.Drawing.Point(226, 77);
            this.cboSortDepartment.Name = "cboSortDepartment";
            this.cboSortDepartment.Size = new System.Drawing.Size(156, 33);
            this.cboSortDepartment.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortDepartment.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.cboSortDepartment.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDepartment.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDepartment.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortDepartment.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDepartment.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cboSortDepartment, "Sắp xếp mã phòng ban");
            this.cboSortDepartment.SelectedIndexChanged += new System.EventHandler(this.cboSortDepartment_SelectedIndexChanged);
            // 
            // lblSortDepartmentID
            // 
            this.lblSortDepartmentID.AutoSize = true;
            this.lblSortDepartmentID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortDepartmentID.Location = new System.Drawing.Point(3, 84);
            this.lblSortDepartmentID.Name = "lblSortDepartmentID";
            this.lblSortDepartmentID.Size = new System.Drawing.Size(206, 26);
            this.lblSortDepartmentID.TabIndex = 9;
            this.lblSortDepartmentID.Text = "Sort Department ID";
            this.lblSortDepartmentID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortSoLuongNV
            // 
            this.cboSortSoLuongNV.BackColor = System.Drawing.Color.White;
            this.cboSortSoLuongNV.DelimiterChar = "";
            this.cboSortSoLuongNV.DisplayMember = "";
            this.cboSortSoLuongNV.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortSoLuongNV.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortSoLuongNV.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongNV.Location = new System.Drawing.Point(227, 131);
            this.cboSortSoLuongNV.Name = "cboSortSoLuongNV";
            this.cboSortSoLuongNV.Size = new System.Drawing.Size(156, 33);
            this.cboSortSoLuongNV.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortSoLuongNV.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.cboSortSoLuongNV.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongNV.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongNV.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortSoLuongNV.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongNV.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cboSortSoLuongNV, "Lọc theo số lượng");
            // 
            // lblSortSoLuongNV
            // 
            this.lblSortSoLuongNV.AutoSize = true;
            this.lblSortSoLuongNV.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortSoLuongNV.Location = new System.Drawing.Point(3, 138);
            this.lblSortSoLuongNV.Name = "lblSortSoLuongNV";
            this.lblSortSoLuongNV.Size = new System.Drawing.Size(185, 26);
            this.lblSortSoLuongNV.TabIndex = 11;
            this.lblSortSoLuongNV.Text = "Lọc theo số lượng";
            this.lblSortSoLuongNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateDepartment
            // 
            this.lblStateDepartment.AutoSize = true;
            this.lblStateDepartment.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateDepartment.Location = new System.Drawing.Point(3, 192);
            this.lblStateDepartment.Name = "lblStateDepartment";
            this.lblStateDepartment.Size = new System.Drawing.Size(186, 26);
            this.lblStateDepartment.TabIndex = 13;
            this.lblStateDepartment.Text = "Trạng thái dữ liệu";
            this.lblStateDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblDepartment);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucDepartment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucDepartment";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucDepartment_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateDepartment)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuongNV)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDepartment;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuDepartment;
        private Syncfusion.WinForms.Controls.SfButton btnAddDepartment;
        private System.Windows.Forms.TextBox txtSearchDepartment;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteDepartment;
        private Syncfusion.WinForms.Controls.SfButton btnEditDepartment;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverDepartment;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateDepartment;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateDepartment;
        private System.Windows.Forms.Label lblSortSoLuongNV;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortSoLuongNV;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortDepartment;
        private System.Windows.Forms.Label lblSortDepartmentID;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTruongPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhanChuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
