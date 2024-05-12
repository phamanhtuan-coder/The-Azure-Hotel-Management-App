namespace GUI.UserControls
{
    partial class ucCustomerRanking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCustomerRanking));
            this.lblCustomerRanking = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddCustomerRanking = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditCustomerRanking = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteCustomerRanking = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverCustomerRanking = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchCustomerRanking = new System.Windows.Forms.TextBox();
            this.btnTraCuuCustomerRanking = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateCustomerRanking = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvCustomerRank = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSortCustomerRankingID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortCustomerRankingID = new System.Windows.Forms.Label();
            this.cboSortSoLuongKH = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortSoLuongKH = new System.Windows.Forms.Label();
            this.lblStateCustomerRanking = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateCustomerRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortCustomerRankingID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuongKH)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerRanking
            // 
            this.lblCustomerRanking.BackColor = System.Drawing.Color.Lavender;
            this.lblCustomerRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerRanking.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCustomerRanking.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCustomerRanking.Location = new System.Drawing.Point(0, 0);
            this.lblCustomerRanking.Name = "lblCustomerRanking";
            this.lblCustomerRanking.Size = new System.Drawing.Size(972, 94);
            this.lblCustomerRanking.TabIndex = 1;
            this.lblCustomerRanking.Text = "CUSTOMER\'S RANKS";
            this.lblCustomerRanking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddCustomerRanking, 0, 0);
            this.tlpController.Controls.Add(this.btnEditCustomerRanking, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteCustomerRanking, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverCustomerRanking, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tlpController, "Xóa hạng nhân viên");
            // 
            // btnAddCustomerRanking
            // 
            this.btnAddCustomerRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddCustomerRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCustomerRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomerRanking.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomerRanking.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomerRanking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddCustomerRanking.Location = new System.Drawing.Point(3, 3);
            this.btnAddCustomerRanking.Name = "btnAddCustomerRanking";
            this.btnAddCustomerRanking.Size = new System.Drawing.Size(191, 41);
            this.btnAddCustomerRanking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddCustomerRanking.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomerRanking.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddCustomerRanking.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddCustomerRanking.TabIndex = 2;
            this.btnAddCustomerRanking.Text = "Thêm";
            this.btnAddCustomerRanking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddCustomerRanking, "Thêm hạng nhân viên");
            this.btnAddCustomerRanking.UseVisualStyleBackColor = false;
            this.btnAddCustomerRanking.Click += new System.EventHandler(this.btnAddCustomerRanking_Click);
            // 
            // btnEditCustomerRanking
            // 
            this.btnEditCustomerRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditCustomerRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditCustomerRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomerRanking.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.btnEditCustomerRanking.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomerRanking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditCustomerRanking.Location = new System.Drawing.Point(3, 50);
            this.btnEditCustomerRanking.Name = "btnEditCustomerRanking";
            this.btnEditCustomerRanking.Size = new System.Drawing.Size(191, 41);
            this.btnEditCustomerRanking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditCustomerRanking.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomerRanking.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditCustomerRanking.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditCustomerRanking.TabIndex = 4;
            this.btnEditCustomerRanking.Text = "Sửa";
            this.btnEditCustomerRanking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditCustomerRanking, "Sửa hạng nhân viên");
            this.btnEditCustomerRanking.UseVisualStyleBackColor = false;
            this.btnEditCustomerRanking.Click += new System.EventHandler(this.btnEditCustomerRanking_Click);
            // 
            // btnDeleteCustomerRanking
            // 
            this.btnDeleteCustomerRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteCustomerRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteCustomerRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomerRanking.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCustomerRanking.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomerRanking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteCustomerRanking.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteCustomerRanking.Name = "btnDeleteCustomerRanking";
            this.btnDeleteCustomerRanking.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteCustomerRanking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteCustomerRanking.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomerRanking.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteCustomerRanking.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomerRanking.TabIndex = 3;
            this.btnDeleteCustomerRanking.Text = "Xóa";
            this.btnDeleteCustomerRanking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCustomerRanking.UseVisualStyleBackColor = false;
            this.btnDeleteCustomerRanking.Click += new System.EventHandler(this.btnDeleteCustomerRanking_Click);
            // 
            // btnRecoverCustomerRanking
            // 
            this.btnRecoverCustomerRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverCustomerRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverCustomerRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverCustomerRanking.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.btnRecoverCustomerRanking.ForeColor = System.Drawing.Color.White;
            this.btnRecoverCustomerRanking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverCustomerRanking.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverCustomerRanking.Name = "btnRecoverCustomerRanking";
            this.btnRecoverCustomerRanking.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverCustomerRanking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverCustomerRanking.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverCustomerRanking.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverCustomerRanking.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverCustomerRanking.TabIndex = 5;
            this.btnRecoverCustomerRanking.Text = "Khôi phục";
            this.btnRecoverCustomerRanking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRecoverCustomerRanking, "Khôi phục hạng nhân viên");
            this.btnRecoverCustomerRanking.UseVisualStyleBackColor = false;
            this.btnRecoverCustomerRanking.Click += new System.EventHandler(this.btnRecoverCustomerRanking_Click);
            // 
            // txtSearchCustomerRanking
            // 
            this.txtSearchCustomerRanking.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.txtSearchCustomerRanking.Location = new System.Drawing.Point(-1, 26);
            this.txtSearchCustomerRanking.Name = "txtSearchCustomerRanking";
            this.txtSearchCustomerRanking.Size = new System.Drawing.Size(251, 30);
            this.txtSearchCustomerRanking.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSearchCustomerRanking, "Nhập tên hạng");
            // 
            // btnTraCuuCustomerRanking
            // 
            this.btnTraCuuCustomerRanking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuCustomerRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuCustomerRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuCustomerRanking.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuCustomerRanking.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuCustomerRanking.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuCustomerRanking.Name = "btnTraCuuCustomerRanking";
            this.btnTraCuuCustomerRanking.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuCustomerRanking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuCustomerRanking.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuCustomerRanking.TabIndex = 8;
            this.btnTraCuuCustomerRanking.Text = "Tra cứu";
            this.toolTip1.SetToolTip(this.btnTraCuuCustomerRanking, "Tra cứu");
            this.btnTraCuuCustomerRanking.UseVisualStyleBackColor = false;
            this.btnTraCuuCustomerRanking.Click += new System.EventHandler(this.btnTraCuuCustomerRanking_Click);
            // 
            // cboStateCustomerRanking
            // 
            this.cboStateCustomerRanking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateCustomerRanking.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateCustomerRanking.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateCustomerRanking.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.cboStateCustomerRanking.Location = new System.Drawing.Point(226, 193);
            this.cboStateCustomerRanking.Name = "cboStateCustomerRanking";
            this.cboStateCustomerRanking.Size = new System.Drawing.Size(156, 33);
            this.cboStateCustomerRanking.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateCustomerRanking.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.cboStateCustomerRanking.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.cboStateCustomerRanking.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateCustomerRanking.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.cboStateCustomerRanking.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cboStateCustomerRanking, "Lọc theo trạng thái");
            this.cboStateCustomerRanking.SelectedIndexChanged += new System.EventHandler(this.cboStateCustomerRanking_SelectedIndexChanged);
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
            this.spcQuery.Panel1.Controls.Add(this.dgvCustomerRank);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortCustomerRankingID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortCustomerRankingID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortSoLuongKH);
            this.spcQuery.Panel2.Controls.Add(this.lblSortSoLuongKH);
            this.spcQuery.Panel2.Controls.Add(this.lblStateCustomerRanking);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchCustomerRanking);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuCustomerRanking);
            this.spcQuery.Panel2.Controls.Add(this.cboStateCustomerRanking);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvCustomerRank
            // 
            this.dgvCustomerRank.AllowUserToAddRows = false;
            this.dgvCustomerRank.AllowUserToDeleteRows = false;
            this.dgvCustomerRank.AllowUserToResizeColumns = false;
            this.dgvCustomerRank.AllowUserToResizeRows = false;
            this.dgvCustomerRank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerRank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenHang,
            this.MucGiamGia,
            this.colSoLuong,
            this.TrangThai});
            this.dgvCustomerRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerRank.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerRank.MultiSelect = false;
            this.dgvCustomerRank.Name = "dgvCustomerRank";
            this.dgvCustomerRank.ReadOnly = true;
            this.dgvCustomerRank.RowHeadersVisible = false;
            this.dgvCustomerRank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerRank.Size = new System.Drawing.Size(973, 746);
            this.dgvCustomerRank.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "MaLoaiHangThanhVien";
            this.ID.HeaderText = "Mã hạng thành viện";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên hạng";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // MucGiamGia
            // 
            this.MucGiamGia.DataPropertyName = "MucGiamGia";
            this.MucGiamGia.HeaderText = "Mức giảm giá";
            this.MucGiamGia.Name = "MucGiamGia";
            this.MucGiamGia.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            // 
            // cboSortCustomerRankingID
            // 
            this.cboSortCustomerRankingID.DelimiterChar = "";
            this.cboSortCustomerRankingID.DisplayMember = "";
            this.cboSortCustomerRankingID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortCustomerRankingID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortCustomerRankingID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.cboSortCustomerRankingID.Location = new System.Drawing.Point(226, 79);
            this.cboSortCustomerRankingID.Name = "cboSortCustomerRankingID";
            this.cboSortCustomerRankingID.Size = new System.Drawing.Size(156, 33);
            this.cboSortCustomerRankingID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortCustomerRankingID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.cboSortCustomerRankingID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.cboSortCustomerRankingID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortCustomerRankingID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.cboSortCustomerRankingID.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cboSortCustomerRankingID, "Sắp xếp mã loại");
            this.cboSortCustomerRankingID.SelectedIndexChanged += new System.EventHandler(this.cboSortCustomerRankingID_SelectedIndexChanged);
            // 
            // lblSortCustomerRankingID
            // 
            this.lblSortCustomerRankingID.AutoSize = true;
            this.lblSortCustomerRankingID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.lblSortCustomerRankingID.Location = new System.Drawing.Point(2, 86);
            this.lblSortCustomerRankingID.Name = "lblSortCustomerRankingID";
            this.lblSortCustomerRankingID.Size = new System.Drawing.Size(170, 26);
            this.lblSortCustomerRankingID.TabIndex = 9;
            this.lblSortCustomerRankingID.Text = "Sort theo ID loại";
            this.lblSortCustomerRankingID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortSoLuongKH
            // 
            this.cboSortSoLuongKH.DelimiterChar = "";
            this.cboSortSoLuongKH.DisplayMember = "";
            this.cboSortSoLuongKH.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortSoLuongKH.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortSoLuongKH.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.cboSortSoLuongKH.Location = new System.Drawing.Point(227, 136);
            this.cboSortSoLuongKH.Name = "cboSortSoLuongKH";
            this.cboSortSoLuongKH.Size = new System.Drawing.Size(156, 33);
            this.cboSortSoLuongKH.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortSoLuongKH.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.cboSortSoLuongKH.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.cboSortSoLuongKH.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortSoLuongKH.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.cboSortSoLuongKH.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cboSortSoLuongKH, "Sắp xếp số lượng");
            this.cboSortSoLuongKH.SelectedIndexChanged += new System.EventHandler(this.cboSortSoLuongKH_SelectedIndexChanged);
            // 
            // lblSortSoLuongKH
            // 
            this.lblSortSoLuongKH.AutoSize = true;
            this.lblSortSoLuongKH.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.lblSortSoLuongKH.Location = new System.Drawing.Point(1, 143);
            this.lblSortSoLuongKH.Name = "lblSortSoLuongKH";
            this.lblSortSoLuongKH.Size = new System.Drawing.Size(191, 26);
            this.lblSortSoLuongKH.TabIndex = 11;
            this.lblSortSoLuongKH.Text = "Sort theo số lượng";
            this.lblSortSoLuongKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateCustomerRanking
            // 
            this.lblStateCustomerRanking.AutoSize = true;
            this.lblStateCustomerRanking.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.lblStateCustomerRanking.Location = new System.Drawing.Point(2, 200);
            this.lblStateCustomerRanking.Name = "lblStateCustomerRanking";
            this.lblStateCustomerRanking.Size = new System.Drawing.Size(186, 26);
            this.lblStateCustomerRanking.TabIndex = 13;
            this.lblStateCustomerRanking.Text = "Trạng thái dữ liệu";
            this.lblStateCustomerRanking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblCustomerRanking);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucCustomerRanking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucCustomerRanking";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucCustomerRanking_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateCustomerRanking)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortCustomerRankingID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuongKH)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerRanking;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuCustomerRanking;
        private Syncfusion.WinForms.Controls.SfButton btnAddCustomerRanking;
        private System.Windows.Forms.TextBox txtSearchCustomerRanking;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteCustomerRanking;
        private Syncfusion.WinForms.Controls.SfButton btnEditCustomerRanking;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverCustomerRanking;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateCustomerRanking;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateCustomerRanking;
        private System.Windows.Forms.Label lblSortSoLuongKH;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortSoLuongKH;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortCustomerRankingID;
        private System.Windows.Forms.Label lblSortCustomerRankingID;
        private System.Windows.Forms.DataGridView dgvCustomerRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
