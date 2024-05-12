namespace GUI.UserControls
{
    partial class ucMaintentance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMaintentance));
            this.lblMaintentance = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddMaintentance = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditMaintentance = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteMaintentance = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverMaintentance = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchMaintentance = new System.Windows.Forms.TextBox();
            this.btnTraCuuMaintentance = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateMaintentance = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.colMaBaoTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaThietBi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNgayHuHong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBaoTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgayBaoTri = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayHuHong = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBaoTri = new System.Windows.Forms.Label();
            this.cboSortMaintentanceD = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortMaintentanceID = new System.Windows.Forms.Label();
            this.lblLocNgayHuHong = new System.Windows.Forms.Label();
            this.lblStateMaintance = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateMaintentance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortMaintentanceD)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaintentance
            // 
            this.lblMaintentance.BackColor = System.Drawing.Color.Lavender;
            this.lblMaintentance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaintentance.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaintentance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblMaintentance.Location = new System.Drawing.Point(0, 0);
            this.lblMaintentance.Name = "lblMaintentance";
            this.lblMaintentance.Size = new System.Drawing.Size(972, 94);
            this.lblMaintentance.TabIndex = 1;
            this.lblMaintentance.Text = "MAINTENANCE";
            this.lblMaintentance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddMaintentance, 0, 0);
            this.tlpController.Controls.Add(this.btnEditMaintentance, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteMaintentance, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverMaintentance, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddMaintentance
            // 
            this.btnAddMaintentance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddMaintentance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddMaintentance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMaintentance.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMaintentance.ForeColor = System.Drawing.Color.White;
            this.btnAddMaintentance.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddMaintentance.Location = new System.Drawing.Point(3, 3);
            this.btnAddMaintentance.Name = "btnAddMaintentance";
            this.btnAddMaintentance.Size = new System.Drawing.Size(191, 41);
            this.btnAddMaintentance.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddMaintentance.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddMaintentance.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddMaintentance.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddMaintentance.TabIndex = 2;
            this.btnAddMaintentance.Text = "Thêm";
            this.btnAddMaintentance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddMaintentance, "Thêm bảo trì");
            this.btnAddMaintentance.UseVisualStyleBackColor = false;
            this.btnAddMaintentance.Click += new System.EventHandler(this.btnAddMaintentance_Click);
            // 
            // btnEditMaintentance
            // 
            this.btnEditMaintentance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditMaintentance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditMaintentance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMaintentance.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMaintentance.ForeColor = System.Drawing.Color.White;
            this.btnEditMaintentance.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditMaintentance.Location = new System.Drawing.Point(3, 50);
            this.btnEditMaintentance.Name = "btnEditMaintentance";
            this.btnEditMaintentance.Size = new System.Drawing.Size(191, 41);
            this.btnEditMaintentance.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditMaintentance.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditMaintentance.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditMaintentance.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditMaintentance.TabIndex = 4;
            this.btnEditMaintentance.Text = "Sửa";
            this.btnEditMaintentance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditMaintentance, "Sửa bảo trì");
            this.btnEditMaintentance.UseVisualStyleBackColor = false;
            this.btnEditMaintentance.Click += new System.EventHandler(this.btnEditMaintentance_Click);
            // 
            // btnDeleteMaintentance
            // 
            this.btnDeleteMaintentance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteMaintentance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteMaintentance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMaintentance.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMaintentance.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMaintentance.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteMaintentance.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteMaintentance.Name = "btnDeleteMaintentance";
            this.btnDeleteMaintentance.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteMaintentance.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteMaintentance.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMaintentance.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteMaintentance.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteMaintentance.TabIndex = 3;
            this.btnDeleteMaintentance.Text = "Xóa";
            this.btnDeleteMaintentance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteMaintentance, "Xóa bảo trì");
            this.btnDeleteMaintentance.UseVisualStyleBackColor = false;
            this.btnDeleteMaintentance.Click += new System.EventHandler(this.btnDeleteMaintentance_Click);
            // 
            // btnRecoverMaintentance
            // 
            this.btnRecoverMaintentance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverMaintentance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverMaintentance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverMaintentance.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverMaintentance.ForeColor = System.Drawing.Color.White;
            this.btnRecoverMaintentance.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverMaintentance.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverMaintentance.Name = "btnRecoverMaintentance";
            this.btnRecoverMaintentance.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverMaintentance.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverMaintentance.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverMaintentance.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverMaintentance.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverMaintentance.TabIndex = 5;
            this.btnRecoverMaintentance.Text = "Khôi phục";
            this.btnRecoverMaintentance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRecoverMaintentance, "Khôi phục bảo trì");
            this.btnRecoverMaintentance.UseVisualStyleBackColor = false;
            this.btnRecoverMaintentance.Click += new System.EventHandler(this.btnRecoverMaintentance_Click);
            // 
            // txtSearchMaintentance
            // 
            this.txtSearchMaintentance.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMaintentance.Location = new System.Drawing.Point(6, 16);
            this.txtSearchMaintentance.Name = "txtSearchMaintentance";
            this.txtSearchMaintentance.Size = new System.Drawing.Size(251, 40);
            this.txtSearchMaintentance.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSearchMaintentance, "Nhập mã bảo trì");
            // 
            // btnTraCuuMaintentance
            // 
            this.btnTraCuuMaintentance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuMaintentance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuMaintentance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuMaintentance.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuMaintentance.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuMaintentance.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuMaintentance.Name = "btnTraCuuMaintentance";
            this.btnTraCuuMaintentance.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuMaintentance.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuMaintentance.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuMaintentance.TabIndex = 8;
            this.btnTraCuuMaintentance.Text = "Tra cứu";
            this.toolTip1.SetToolTip(this.btnTraCuuMaintentance, "Tra cứu");
            this.btnTraCuuMaintentance.UseVisualStyleBackColor = false;
            this.btnTraCuuMaintentance.Click += new System.EventHandler(this.btnTraCuuMaintentance_Click);
            // 
            // cboStateMaintentance
            // 
            this.cboStateMaintentance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateMaintentance.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateMaintentance.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateMaintentance.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateMaintentance.Location = new System.Drawing.Point(226, 250);
            this.cboStateMaintentance.Name = "cboStateMaintentance";
            this.cboStateMaintentance.Size = new System.Drawing.Size(156, 33);
            this.cboStateMaintentance.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateMaintentance.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateMaintentance.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateMaintentance.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateMaintentance.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateMaintentance.TabIndex = 16;
            this.toolTip1.SetToolTip(this.cboStateMaintentance, "Lọc theo trạng thái");
            this.cboStateMaintentance.SelectedIndexChanged += new System.EventHandler(this.cboStateMaintentance_SelectedIndexChanged);
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
            this.spcQuery.Panel1.Controls.Add(this.dgvMaintenance);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayBaoTri);
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayHuHong);
            this.spcQuery.Panel2.Controls.Add(this.lblNgayBaoTri);
            this.spcQuery.Panel2.Controls.Add(this.cboSortMaintentanceD);
            this.spcQuery.Panel2.Controls.Add(this.lblSortMaintentanceID);
            this.spcQuery.Panel2.Controls.Add(this.lblLocNgayHuHong);
            this.spcQuery.Panel2.Controls.Add(this.lblStateMaintance);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchMaintentance);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuMaintentance);
            this.spcQuery.Panel2.Controls.Add(this.cboStateMaintentance);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvMaintenance
            // 
            this.dgvMaintenance.AllowUserToAddRows = false;
            this.dgvMaintenance.AllowUserToDeleteRows = false;
            this.dgvMaintenance.AllowUserToResizeColumns = false;
            this.dgvMaintenance.AllowUserToResizeRows = false;
            this.dgvMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBaoTri,
            this.colMaThietBi,
            this.colMaNV,
            this.colNgayHuHong,
            this.colNgayBaoTri,
            this.colTrangThai});
            this.dgvMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaintenance.Location = new System.Drawing.Point(0, 0);
            this.dgvMaintenance.MultiSelect = false;
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.ReadOnly = true;
            this.dgvMaintenance.RowHeadersVisible = false;
            this.dgvMaintenance.RowHeadersWidth = 51;
            this.dgvMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaintenance.Size = new System.Drawing.Size(973, 746);
            this.dgvMaintenance.TabIndex = 6;
            // 
            // colMaBaoTri
            // 
            this.colMaBaoTri.DataPropertyName = "MaBaoTri";
            this.colMaBaoTri.HeaderText = "Mã bảo trì";
            this.colMaBaoTri.MinimumWidth = 6;
            this.colMaBaoTri.Name = "colMaBaoTri";
            this.colMaBaoTri.ReadOnly = true;
            // 
            // colMaThietBi
            // 
            this.colMaThietBi.DataPropertyName = "MaThietBi";
            this.colMaThietBi.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaThietBi.HeaderText = "Tên thiết bị";
            this.colMaThietBi.MinimumWidth = 6;
            this.colMaThietBi.Name = "colMaThietBi";
            this.colMaThietBi.ReadOnly = true;
            this.colMaThietBi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaThietBi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaNV.HeaderText = "Nhân viên thực hiện";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            this.colMaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colNgayHuHong
            // 
            this.colNgayHuHong.DataPropertyName = "NgayHuHong";
            this.colNgayHuHong.HeaderText = "Ngày hư hỏng";
            this.colNgayHuHong.MinimumWidth = 6;
            this.colNgayHuHong.Name = "colNgayHuHong";
            this.colNgayHuHong.ReadOnly = true;
            // 
            // colNgayBaoTri
            // 
            this.colNgayBaoTri.DataPropertyName = "NgayBaoTri";
            this.colNgayBaoTri.HeaderText = "Ngày bảo trì";
            this.colNgayBaoTri.MinimumWidth = 6;
            this.colNgayBaoTri.Name = "colNgayBaoTri";
            this.colNgayBaoTri.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Visible = false;
            // 
            // dtpNgayBaoTri
            // 
            this.dtpNgayBaoTri.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBaoTri.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBaoTri.Location = new System.Drawing.Point(182, 197);
            this.dtpNgayBaoTri.Name = "dtpNgayBaoTri";
            this.dtpNgayBaoTri.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayBaoTri.TabIndex = 14;
            this.toolTip1.SetToolTip(this.dtpNgayBaoTri, "Ngày bảo trì");
            // 
            // dtpNgayHuHong
            // 
            this.dtpNgayHuHong.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHuHong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHuHong.Location = new System.Drawing.Point(182, 138);
            this.dtpNgayHuHong.Name = "dtpNgayHuHong";
            this.dtpNgayHuHong.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayHuHong.TabIndex = 12;
            this.toolTip1.SetToolTip(this.dtpNgayHuHong, "Ngày hỏng");
            // 
            // lblNgayBaoTri
            // 
            this.lblNgayBaoTri.AutoSize = true;
            this.lblNgayBaoTri.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBaoTri.Location = new System.Drawing.Point(1, 198);
            this.lblNgayBaoTri.Name = "lblNgayBaoTri";
            this.lblNgayBaoTri.Size = new System.Drawing.Size(132, 26);
            this.lblNgayBaoTri.TabIndex = 13;
            this.lblNgayBaoTri.Text = "Ngày bảo trì";
            this.lblNgayBaoTri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortMaintentanceD
            // 
            this.cboSortMaintentanceD.DelimiterChar = "";
            this.cboSortMaintentanceD.DisplayMember = "";
            this.cboSortMaintentanceD.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortMaintentanceD.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortMaintentanceD.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortMaintentanceD.Location = new System.Drawing.Point(226, 75);
            this.cboSortMaintentanceD.Name = "cboSortMaintentanceD";
            this.cboSortMaintentanceD.Size = new System.Drawing.Size(156, 33);
            this.cboSortMaintentanceD.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortMaintentanceD.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortMaintentanceD.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortMaintentanceD.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortMaintentanceD.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortMaintentanceD.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cboSortMaintentanceD, "Sắp xếp mã bảo trì");
            this.cboSortMaintentanceD.SelectedIndexChanged += new System.EventHandler(this.cboSortMaintentanceD_SelectedIndexChanged);
            // 
            // lblSortMaintentanceID
            // 
            this.lblSortMaintentanceID.AutoSize = true;
            this.lblSortMaintentanceID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortMaintentanceID.Location = new System.Drawing.Point(-3, 82);
            this.lblSortMaintentanceID.Name = "lblSortMaintentanceID";
            this.lblSortMaintentanceID.Size = new System.Drawing.Size(222, 26);
            this.lblSortMaintentanceID.TabIndex = 9;
            this.lblSortMaintentanceID.Text = "Sort Maintentance ID";
            this.lblSortMaintentanceID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocNgayHuHong
            // 
            this.lblLocNgayHuHong.AutoSize = true;
            this.lblLocNgayHuHong.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocNgayHuHong.Location = new System.Drawing.Point(3, 139);
            this.lblLocNgayHuHong.Name = "lblLocNgayHuHong";
            this.lblLocNgayHuHong.Size = new System.Drawing.Size(150, 26);
            this.lblLocNgayHuHong.TabIndex = 11;
            this.lblLocNgayHuHong.Text = "Ngày hư hỏng";
            this.lblLocNgayHuHong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateMaintance
            // 
            this.lblStateMaintance.AutoSize = true;
            this.lblStateMaintance.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateMaintance.Location = new System.Drawing.Point(2, 257);
            this.lblStateMaintance.Name = "lblStateMaintance";
            this.lblStateMaintance.Size = new System.Drawing.Size(186, 26);
            this.lblStateMaintance.TabIndex = 15;
            this.lblStateMaintance.Text = "Trạng thái dữ liệu";
            this.lblStateMaintance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblMaintentance);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucMaintentance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucMaintentance";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucMaintance_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateMaintentance)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortMaintentanceD)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaintentance;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuMaintentance;
        private Syncfusion.WinForms.Controls.SfButton btnAddMaintentance;
        private System.Windows.Forms.TextBox txtSearchMaintentance;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteMaintentance;
        private Syncfusion.WinForms.Controls.SfButton btnEditMaintentance;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverMaintentance;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateMaintentance;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateMaintance;
        private System.Windows.Forms.Label lblLocNgayHuHong;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortMaintentanceD;
        private System.Windows.Forms.Label lblSortMaintentanceID;
        private System.Windows.Forms.Label lblNgayBaoTri;
        private System.Windows.Forms.DateTimePicker dtpNgayBaoTri;
        private System.Windows.Forms.DateTimePicker dtpNgayHuHong;
        private System.Windows.Forms.DataGridView dgvMaintenance;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBaoTri;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaThietBi;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHuHong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBaoTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
