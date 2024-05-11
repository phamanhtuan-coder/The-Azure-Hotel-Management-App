namespace GUI.UserControls
{
    partial class ucRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRole));
            this.lblRole = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRole = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditRole = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteRole = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverRole = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchRole = new System.Windows.Forms.TextBox();
            this.btnTraCuuRole = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateRole = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.ucDashboard1 = new GUI.UserControls.ucDashboard();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.colPQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSortRole = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortServiceTypeID = new System.Windows.Forms.Label();
            this.cboSortSoLuong = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortSoLuongRole = new System.Windows.Forms.Label();
            this.lblStateRole = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuong)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Lavender;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRole.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRole.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRole.Location = new System.Drawing.Point(0, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(972, 94);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "PERMISSION";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddRole, 0, 0);
            this.tlpController.Controls.Add(this.btnEditRole, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteRole, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverRole, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.ForeColor = System.Drawing.Color.White;
            this.btnAddRole.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddRole.Location = new System.Drawing.Point(3, 3);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(191, 41);
            this.btnAddRole.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRole.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddRole.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddRole.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddRole.TabIndex = 2;
            this.btnAddRole.Text = "Thêm";
            this.btnAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddRole, "Thêm phân quyền");
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnEditRole
            // 
            this.btnEditRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRole.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRole.ForeColor = System.Drawing.Color.White;
            this.btnEditRole.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditRole.Location = new System.Drawing.Point(3, 50);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(191, 41);
            this.btnEditRole.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditRole.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditRole.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditRole.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditRole.TabIndex = 4;
            this.btnEditRole.Text = "Sửa";
            this.btnEditRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditRole, "Sửa phân quyền");
            this.btnEditRole.UseVisualStyleBackColor = false;
            this.btnEditRole.Click += new System.EventHandler(this.btnEditRole_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRole.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRole.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRole.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteRole.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteRole.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRole.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRole.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteRole.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteRole.TabIndex = 3;
            this.btnDeleteRole.Text = "Xóa";
            this.btnDeleteRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteRole, "Xóa phân quyền");
            this.btnDeleteRole.UseVisualStyleBackColor = false;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnRecoverRole
            // 
            this.btnRecoverRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverRole.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverRole.ForeColor = System.Drawing.Color.White;
            this.btnRecoverRole.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverRole.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverRole.Name = "btnRecoverRole";
            this.btnRecoverRole.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverRole.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverRole.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverRole.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverRole.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverRole.TabIndex = 5;
            this.btnRecoverRole.Text = "Khôi phục";
            this.btnRecoverRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRecoverRole, "Khôi phục phân quyền");
            this.btnRecoverRole.UseVisualStyleBackColor = false;
            this.btnRecoverRole.Click += new System.EventHandler(this.btnRecoverRole_Click);
            // 
            // txtSearchRole
            // 
            this.txtSearchRole.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRole.Location = new System.Drawing.Point(6, 16);
            this.txtSearchRole.Name = "txtSearchRole";
            this.txtSearchRole.Size = new System.Drawing.Size(251, 27);
            this.txtSearchRole.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSearchRole, "Nhập mã phân quyền");
            // 
            // btnTraCuuRole
            // 
            this.btnTraCuuRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuRole.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuRole.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRole.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuRole.Name = "btnTraCuuRole";
            this.btnTraCuuRole.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuRole.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRole.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRole.TabIndex = 8;
            this.btnTraCuuRole.Text = "Tra cứu";
            this.toolTip1.SetToolTip(this.btnTraCuuRole, "Tra cứu");
            this.btnTraCuuRole.UseVisualStyleBackColor = false;
            this.btnTraCuuRole.Click += new System.EventHandler(this.btnTraCuuRole_Click);
            // 
            // cboStateRole
            // 
            this.cboStateRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateRole.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateRole.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateRole.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRole.Location = new System.Drawing.Point(226, 185);
            this.cboStateRole.Name = "cboStateRole";
            this.cboStateRole.Size = new System.Drawing.Size(156, 33);
            this.cboStateRole.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateRole.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRole.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRole.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateRole.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRole.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cboStateRole, "Lọc theo trạng thái");
            this.cboStateRole.SelectedIndexChanged += new System.EventHandler(this.cboStateRole_SelectedIndexChanged);
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
            this.spcQuery.Panel1.Controls.Add(this.ucDashboard1);
            this.spcQuery.Panel1.Controls.Add(this.dgvRole);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortRole);
            this.spcQuery.Panel2.Controls.Add(this.lblSortServiceTypeID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortSoLuong);
            this.spcQuery.Panel2.Controls.Add(this.lblSortSoLuongRole);
            this.spcQuery.Panel2.Controls.Add(this.lblStateRole);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchRole);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuRole);
            this.spcQuery.Panel2.Controls.Add(this.cboStateRole);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // ucDashboard1
            // 
            this.ucDashboard1.BackColor = System.Drawing.Color.White;
            this.ucDashboard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDashboard1.Location = new System.Drawing.Point(976, 2);
            this.ucDashboard1.Margin = new System.Windows.Forms.Padding(0);
            this.ucDashboard1.Name = "ucDashboard1";
            this.ucDashboard1.Size = new System.Drawing.Size(1353, 840);
            this.ucDashboard1.TabIndex = 1;
            // 
            // dgvRole
            // 
            this.dgvRole.AllowUserToAddRows = false;
            this.dgvRole.AllowUserToDeleteRows = false;
            this.dgvRole.AllowUserToResizeColumns = false;
            this.dgvRole.AllowUserToResizeRows = false;
            this.dgvRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPQ,
            this.colVT,
            this.colTenPB,
            this.colSLTK,
            this.colTrangThai,
            this.maph,
            this.MaVt,
            this.MoTa});
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRole.Location = new System.Drawing.Point(0, 0);
            this.dgvRole.MultiSelect = false;
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.ReadOnly = true;
            this.dgvRole.RowHeadersVisible = false;
            this.dgvRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRole.Size = new System.Drawing.Size(973, 746);
            this.dgvRole.TabIndex = 6;
            this.dgvRole.SelectionChanged += new System.EventHandler(this.dgvRole_SelectionChanged);
            // 
            // colPQ
            // 
            this.colPQ.DataPropertyName = "MaPhanQuyen";
            this.colPQ.HeaderText = "Mã phân quyền";
            this.colPQ.Name = "colPQ";
            this.colPQ.ReadOnly = true;
            // 
            // colVT
            // 
            this.colVT.DataPropertyName = "TenVaiTro";
            this.colVT.HeaderText = "Tên vai trò";
            this.colVT.Name = "colVT";
            this.colVT.ReadOnly = true;
            // 
            // colTenPB
            // 
            this.colTenPB.DataPropertyName = "TenPhong";
            this.colTenPB.HeaderText = "Tên phòng ban";
            this.colTenPB.Name = "colTenPB";
            this.colTenPB.ReadOnly = true;
            // 
            // colSLTK
            // 
            this.colSLTK.DataPropertyName = "SoLuongTK";
            this.colSLTK.HeaderText = "Số lượng Tải Khoản";
            this.colSLTK.Name = "colSLTK";
            this.colSLTK.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trang thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // maph
            // 
            this.maph.DataPropertyName = "MaPhongBan";
            this.maph.HeaderText = "MaPhong";
            this.maph.Name = "maph";
            this.maph.ReadOnly = true;
            this.maph.Visible = false;
            // 
            // MaVt
            // 
            this.MaVt.DataPropertyName = "MaVaiTro";
            this.MaVt.HeaderText = "MaVt";
            this.MaVt.Name = "MaVt";
            this.MaVt.ReadOnly = true;
            this.MaVt.Visible = false;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "MoTa";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Visible = false;
            // 
            // cboSortRole
            // 
            this.cboSortRole.DelimiterChar = "";
            this.cboSortRole.DisplayMember = "";
            this.cboSortRole.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortRole.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortRole.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRole.Location = new System.Drawing.Point(226, 77);
            this.cboSortRole.Name = "cboSortRole";
            this.cboSortRole.Size = new System.Drawing.Size(156, 33);
            this.cboSortRole.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortRole.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRole.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRole.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortRole.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRole.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cboSortRole, "Sắp xếp mã phần quyền");
            this.cboSortRole.SelectedIndexChanged += new System.EventHandler(this.cboSortRole_SelectedIndexChanged);
            // 
            // lblSortServiceTypeID
            // 
            this.lblSortServiceTypeID.AutoSize = true;
            this.lblSortServiceTypeID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortServiceTypeID.Location = new System.Drawing.Point(3, 84);
            this.lblSortServiceTypeID.Name = "lblSortServiceTypeID";
            this.lblSortServiceTypeID.Size = new System.Drawing.Size(152, 22);
            this.lblSortServiceTypeID.TabIndex = 9;
            this.lblSortServiceTypeID.Text = "Sort theo Role ID";
            this.lblSortServiceTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortSoLuong
            // 
            this.cboSortSoLuong.DelimiterChar = "";
            this.cboSortSoLuong.DisplayMember = "";
            this.cboSortSoLuong.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortSoLuong.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortSoLuong.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuong.Location = new System.Drawing.Point(227, 131);
            this.cboSortSoLuong.Name = "cboSortSoLuong";
            this.cboSortSoLuong.Size = new System.Drawing.Size(156, 33);
            this.cboSortSoLuong.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortSoLuong.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuong.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuong.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortSoLuong.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuong.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cboSortSoLuong, "Lọc theo số lượng");
            this.cboSortSoLuong.SelectedIndexChanged += new System.EventHandler(this.cboSortSoLuong_SelectedIndexChanged);
            // 
            // lblSortSoLuongRole
            // 
            this.lblSortSoLuongRole.AutoSize = true;
            this.lblSortSoLuongRole.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortSoLuongRole.Location = new System.Drawing.Point(3, 138);
            this.lblSortSoLuongRole.Name = "lblSortSoLuongRole";
            this.lblSortSoLuongRole.Size = new System.Drawing.Size(158, 22);
            this.lblSortSoLuongRole.TabIndex = 11;
            this.lblSortSoLuongRole.Text = "Lọc theo số lượng";
            this.lblSortSoLuongRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateRole
            // 
            this.lblStateRole.AutoSize = true;
            this.lblStateRole.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateRole.Location = new System.Drawing.Point(3, 192);
            this.lblStateRole.Name = "lblStateRole";
            this.lblStateRole.Size = new System.Drawing.Size(159, 22);
            this.lblStateRole.TabIndex = 13;
            this.lblStateRole.Text = "Trạng thái dữ liệu";
            this.lblStateRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblRole);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucRole
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucRole";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucRole_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRole)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuong)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRole;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuRole;
        private Syncfusion.WinForms.Controls.SfButton btnAddRole;
        private System.Windows.Forms.TextBox txtSearchRole;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteRole;
        private Syncfusion.WinForms.Controls.SfButton btnEditRole;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverRole;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateRole;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateRole;
        private System.Windows.Forms.Label lblSortSoLuongRole;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortSoLuong;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortRole;
        private System.Windows.Forms.Label lblSortServiceTypeID;
        private System.Windows.Forms.DataGridView dgvRole;
        private ucDashboard ucDashboard1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maph;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
