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
            this.components = new System.ComponentModel.Container();
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
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.picRoom = new System.Windows.Forms.PictureBox();
            this.cboSortPrice = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortPrice = new System.Windows.Forms.Label();
            this.cboRoomStatus = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortTheoLoaiPhong = new System.Windows.Forms.Label();
            this.cboSortRoomType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboSortRoomID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortMaPHG = new System.Windows.Forms.Label();
            this.lblStateRoom = new System.Windows.Forms.Label();
            this.lblStatusRoom = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colMaPHG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaTinhTrangPhong = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSucChuaToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).BeginInit();
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
            this.lblRoom.TabIndex = 1;
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
            this.btnAddRoom.TabIndex = 2;
            this.btnAddRoom.Text = "Thêm";
            this.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddRoom, "Thêm phòng");
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
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
            this.btnEditRoom.TabIndex = 4;
            this.btnEditRoom.Text = "Sửa";
            this.btnEditRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditRoom, "Sửa phòng");
            this.btnEditRoom.UseVisualStyleBackColor = false;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
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
            this.btnDeleteRoom.TabIndex = 3;
            this.btnDeleteRoom.Text = "Xóa";
            this.btnDeleteRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteRoom, "Xóa phòng");
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
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
            this.toolTip1.SetToolTip(this.btnRecoverRoom, "Khôi phục phòng");
            this.btnRecoverRoom.UseVisualStyleBackColor = false;
            this.btnRecoverRoom.Click += new System.EventHandler(this.btnRecoverRoom_Click);
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoom.Location = new System.Drawing.Point(14, 190);
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(251, 40);
            this.txtSearchRoom.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSearchRoom, "Nhập mã phòng ban");
            // 
            // btnTraCuuRoom
            // 
            this.btnTraCuuRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuRoom.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuRoom.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRoom.Location = new System.Drawing.Point(272, 190);
            this.btnTraCuuRoom.Name = "btnTraCuuRoom";
            this.btnTraCuuRoom.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuRoom.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRoom.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRoom.TabIndex = 8;
            this.btnTraCuuRoom.Text = "Tra cứu";
            this.toolTip1.SetToolTip(this.btnTraCuuRoom, "Tra cứu");
            this.btnTraCuuRoom.UseVisualStyleBackColor = false;
            this.btnTraCuuRoom.Click += new System.EventHandler(this.btnTraCuuRoom_Click);
            // 
            // cboStateRoom
            // 
            this.cboStateRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateRoom.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateRoom.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateRoom.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoom.Location = new System.Drawing.Point(236, 476);
            this.cboStateRoom.Name = "cboStateRoom";
            this.cboStateRoom.Size = new System.Drawing.Size(156, 33);
            this.cboStateRoom.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateRoom.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoom.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoom.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateRoom.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoom.TabIndex = 18;
            this.toolTip1.SetToolTip(this.cboStateRoom, "Lọc theo trạng thái");
            this.cboStateRoom.SelectedIndexChanged += new System.EventHandler(this.cboStateRoom_SelectedIndexChanged);
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
            this.spcQuery.Panel1.Controls.Add(this.dgvRoom);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.picRoom);
            this.spcQuery.Panel2.Controls.Add(this.cboSortPrice);
            this.spcQuery.Panel2.Controls.Add(this.lblSortPrice);
            this.spcQuery.Panel2.Controls.Add(this.cboRoomStatus);
            this.spcQuery.Panel2.Controls.Add(this.lblSortTheoLoaiPhong);
            this.spcQuery.Panel2.Controls.Add(this.cboSortRoomType);
            this.spcQuery.Panel2.Controls.Add(this.cboSortRoomID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortMaPHG);
            this.spcQuery.Panel2.Controls.Add(this.lblStateRoom);
            this.spcQuery.Panel2.Controls.Add(this.lblStatusRoom);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchRoom);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuRoom);
            this.spcQuery.Panel2.Controls.Add(this.cboStateRoom);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            this.dgvRoom.AllowUserToResizeColumns = false;
            this.dgvRoom.AllowUserToResizeRows = false;
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPHG,
            this.colMaLoai,
            this.colMaTinhTrangPhong,
            this.colHinhAnh,
            this.colMoTa,
            this.colGiaPhong,
            this.colSucChuaToiDa,
            this.colTrangThai});
            this.dgvRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoom.Location = new System.Drawing.Point(0, 0);
            this.dgvRoom.MultiSelect = false;
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowHeadersVisible = false;
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoom.Size = new System.Drawing.Size(973, 746);
            this.dgvRoom.TabIndex = 6;
            this.dgvRoom.SelectionChanged += new System.EventHandler(this.dgvRoom_SelectionChanged);
            // 
            // picRoom
            // 
            this.picRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picRoom.Image = global::GUI.Properties.Resources.no_pictures;
            this.picRoom.Location = new System.Drawing.Point(46, 19);
            this.picRoom.Name = "picRoom";
            this.picRoom.Size = new System.Drawing.Size(319, 145);
            this.picRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRoom.TabIndex = 41;
            this.picRoom.TabStop = false;
            // 
            // cboSortPrice
            // 
            this.cboSortPrice.DelimiterChar = "";
            this.cboSortPrice.DisplayMember = "";
            this.cboSortPrice.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortPrice.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortPrice.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortPrice.Location = new System.Drawing.Point(236, 362);
            this.cboSortPrice.Name = "cboSortPrice";
            this.cboSortPrice.Size = new System.Drawing.Size(156, 33);
            this.cboSortPrice.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortPrice.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortPrice.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortPrice.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortPrice.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortPrice.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cboSortPrice, "Sắp xếp theo giá");
            this.cboSortPrice.SelectedIndexChanged += new System.EventHandler(this.cboSortPrice_SelectedIndexChanged);
            // 
            // lblSortPrice
            // 
            this.lblSortPrice.AutoSize = true;
            this.lblSortPrice.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortPrice.Location = new System.Drawing.Point(12, 369);
            this.lblSortPrice.Name = "lblSortPrice";
            this.lblSortPrice.Size = new System.Drawing.Size(140, 26);
            this.lblSortPrice.TabIndex = 13;
            this.lblSortPrice.Text = "Sort theo Giá";
            this.lblSortPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRoomStatus
            // 
            this.cboRoomStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRoomStatus.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboRoomStatus.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboRoomStatus.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomStatus.Location = new System.Drawing.Point(234, 249);
            this.cboRoomStatus.Name = "cboRoomStatus";
            this.cboRoomStatus.Size = new System.Drawing.Size(156, 33);
            this.cboRoomStatus.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboRoomStatus.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomStatus.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomStatus.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboRoomStatus.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomStatus.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cboRoomStatus, "Tình trạng phòng");
            this.cboRoomStatus.SelectedIndexChanged += new System.EventHandler(this.cboRoomStatus_SelectedIndexChanged);
            // 
            // lblSortTheoLoaiPhong
            // 
            this.lblSortTheoLoaiPhong.AutoSize = true;
            this.lblSortTheoLoaiPhong.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortTheoLoaiPhong.Location = new System.Drawing.Point(12, 306);
            this.lblSortTheoLoaiPhong.Name = "lblSortTheoLoaiPhong";
            this.lblSortTheoLoaiPhong.Size = new System.Drawing.Size(122, 26);
            this.lblSortTheoLoaiPhong.TabIndex = 11;
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
            this.cboSortRoomType.Location = new System.Drawing.Point(237, 306);
            this.cboSortRoomType.Name = "cboSortRoomType";
            this.cboSortRoomType.Size = new System.Drawing.Size(156, 33);
            this.cboSortRoomType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortRoomType.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortRoomType.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomType.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cboSortRoomType, "Lọc theo loại phòng");
            this.cboSortRoomType.SelectedIndexChanged += new System.EventHandler(this.cboSortRoomType_SelectedIndexChanged);
            // 
            // cboSortRoomID
            // 
            this.cboSortRoomID.DelimiterChar = "";
            this.cboSortRoomID.DisplayMember = "";
            this.cboSortRoomID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortRoomID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortRoomID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Location = new System.Drawing.Point(237, 419);
            this.cboSortRoomID.Name = "cboSortRoomID";
            this.cboSortRoomID.Size = new System.Drawing.Size(156, 33);
            this.cboSortRoomID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortRoomID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortRoomID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.TabIndex = 16;
            this.toolTip1.SetToolTip(this.cboSortRoomID, "Sắp xếp theo mã phòng");
            this.cboSortRoomID.SelectedIndexChanged += new System.EventHandler(this.cboSortRoomID_SelectedIndexChanged);
            // 
            // lblSortMaPHG
            // 
            this.lblSortMaPHG.AutoSize = true;
            this.lblSortMaPHG.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortMaPHG.Location = new System.Drawing.Point(12, 426);
            this.lblSortMaPHG.Name = "lblSortMaPHG";
            this.lblSortMaPHG.Size = new System.Drawing.Size(192, 26);
            this.lblSortMaPHG.TabIndex = 15;
            this.lblSortMaPHG.Text = "Sort theo Room ID";
            this.lblSortMaPHG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateRoom
            // 
            this.lblStateRoom.AutoSize = true;
            this.lblStateRoom.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateRoom.Location = new System.Drawing.Point(12, 483);
            this.lblStateRoom.Name = "lblStateRoom";
            this.lblStateRoom.Size = new System.Drawing.Size(186, 26);
            this.lblStateRoom.TabIndex = 17;
            this.lblStateRoom.Text = "Trạng thái dữ liệu";
            this.lblStateRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusRoom
            // 
            this.lblStatusRoom.AutoSize = true;
            this.lblStatusRoom.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusRoom.Location = new System.Drawing.Point(12, 256);
            this.lblStatusRoom.Name = "lblStatusRoom";
            this.lblStatusRoom.Size = new System.Drawing.Size(183, 26);
            this.lblStatusRoom.TabIndex = 9;
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
            // colMaPHG
            // 
            this.colMaPHG.DataPropertyName = "MaPHG";
            this.colMaPHG.HeaderText = "Mã phòng";
            this.colMaPHG.MinimumWidth = 6;
            this.colMaPHG.Name = "colMaPHG";
            this.colMaPHG.ReadOnly = true;
            this.colMaPHG.Width = 117;
            // 
            // colMaLoai
            // 
            this.colMaLoai.DataPropertyName = "MaLoai";
            this.colMaLoai.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaLoai.HeaderText = "Mã loại";
            this.colMaLoai.MinimumWidth = 6;
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.ReadOnly = true;
            this.colMaLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaLoai.Width = 71;
            // 
            // colMaTinhTrangPhong
            // 
            this.colMaTinhTrangPhong.DataPropertyName = "MaTinhTrangPhong";
            this.colMaTinhTrangPhong.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaTinhTrangPhong.HeaderText = "Mã tình trạng phòng";
            this.colMaTinhTrangPhong.MinimumWidth = 6;
            this.colMaTinhTrangPhong.Name = "colMaTinhTrangPhong";
            this.colMaTinhTrangPhong.ReadOnly = true;
            this.colMaTinhTrangPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaTinhTrangPhong.Width = 162;
            // 
            // colHinhAnh
            // 
            this.colHinhAnh.DataPropertyName = "HinhAnh";
            this.colHinhAnh.HeaderText = "Hình ảnh";
            this.colHinhAnh.MinimumWidth = 6;
            this.colHinhAnh.Name = "colHinhAnh";
            this.colHinhAnh.ReadOnly = true;
            this.colHinhAnh.Visible = false;
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.MinimumWidth = 6;
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            this.colMoTa.Width = 60;
            // 
            // colGiaPhong
            // 
            this.colGiaPhong.DataPropertyName = "GiaPhong";
            this.colGiaPhong.HeaderText = "Giá";
            this.colGiaPhong.MinimumWidth = 6;
            this.colGiaPhong.Name = "colGiaPhong";
            this.colGiaPhong.ReadOnly = true;
            this.colGiaPhong.Width = 60;
            // 
            // colSucChuaToiDa
            // 
            this.colSucChuaToiDa.DataPropertyName = "SucChuaToiDa";
            this.colSucChuaToiDa.HeaderText = "Sức chứa";
            this.colSucChuaToiDa.MinimumWidth = 6;
            this.colSucChuaToiDa.Name = "colSucChuaToiDa";
            this.colSucChuaToiDa.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Visible = false;
            this.colTrangThai.Width = 105;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).EndInit();
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
        private System.Windows.Forms.Label lblStateRoom;
        private System.Windows.Forms.Label lblSortMaPHG;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortRoomType;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortRoomID;
        private System.Windows.Forms.Label lblSortTheoLoaiPhong;
        private Syncfusion.WinForms.ListView.SfComboBox cboRoomStatus;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortPrice;
        private System.Windows.Forms.Label lblSortPrice;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPHG;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaLoai;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaTinhTrangPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSucChuaToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
