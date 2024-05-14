namespace GUI.UserControls
{
    partial class ucBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBooking));
            this.lblBooking = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchBooking = new System.Windows.Forms.TextBox();
            this.btnTraCuuBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateBooking = new Syncfusion.WinForms.ListView.SfComboBox();
            this.dtpNgayDat = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTraCuuUser = new System.Windows.Forms.TextBox();
            this.btnTraCuuDP = new Syncfusion.WinForms.Controls.SfButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuickControl = new System.Windows.Forms.Label();
            this.btnCheckIn = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCheckOut = new Syncfusion.WinForms.Controls.SfButton();
            this.cboSortRoomID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboSortBookingID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortRoomId = new System.Windows.Forms.Label();
            this.lblSortBookingID = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblStateBooking = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colMaDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaPHG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhanPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBookingID)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBooking
            // 
            this.lblBooking.BackColor = System.Drawing.Color.Lavender;
            this.lblBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBooking.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBooking.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBooking.Location = new System.Drawing.Point(0, 0);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(972, 94);
            this.lblBooking.TabIndex = 1;
            this.lblBooking.Text = "BOOKING";
            this.lblBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddBooking, 0, 0);
            this.tlpController.Controls.Add(this.btnEditBooking, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteBooking, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverBooking, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tlpController, "Khôi phục đặt phòng");
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooking.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.ForeColor = System.Drawing.Color.White;
            this.btnAddBooking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddBooking.Location = new System.Drawing.Point(3, 3);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(191, 41);
            this.btnAddBooking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddBooking.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddBooking.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddBooking.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddBooking.TabIndex = 2;
            this.btnAddBooking.Text = "Thêm";
            this.btnAddBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddBooking, "Thêm đặt phòng");
            this.btnAddBooking.UseVisualStyleBackColor = false;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBooking.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBooking.ForeColor = System.Drawing.Color.White;
            this.btnEditBooking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditBooking.Location = new System.Drawing.Point(3, 50);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(191, 41);
            this.btnEditBooking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditBooking.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditBooking.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditBooking.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditBooking.TabIndex = 4;
            this.btnEditBooking.Text = "Sửa";
            this.btnEditBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditBooking, "Sửa đặt phòng");
            this.btnEditBooking.UseVisualStyleBackColor = false;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBooking.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBooking.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBooking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteBooking.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteBooking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteBooking.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBooking.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteBooking.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteBooking.TabIndex = 3;
            this.btnDeleteBooking.Text = "Xóa";
            this.btnDeleteBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteBooking, "Xóa đặt phòng");
            this.btnDeleteBooking.UseVisualStyleBackColor = false;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnRecoverBooking
            // 
            this.btnRecoverBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverBooking.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverBooking.ForeColor = System.Drawing.Color.White;
            this.btnRecoverBooking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverBooking.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverBooking.Name = "btnRecoverBooking";
            this.btnRecoverBooking.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverBooking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverBooking.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverBooking.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverBooking.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverBooking.TabIndex = 5;
            this.btnRecoverBooking.Text = "Khôi phục";
            this.btnRecoverBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverBooking.UseVisualStyleBackColor = false;
            this.btnRecoverBooking.Click += new System.EventHandler(this.btnRecoverBooking_Click);
            // 
            // txtSearchBooking
            // 
            this.txtSearchBooking.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBooking.Location = new System.Drawing.Point(6, 16);
            this.txtSearchBooking.Name = "txtSearchBooking";
            this.txtSearchBooking.Size = new System.Drawing.Size(251, 40);
            this.txtSearchBooking.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSearchBooking, "Nhập mã đặt phòng");
            // 
            // btnTraCuuBooking
            // 
            this.btnTraCuuBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuBooking.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuBooking.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuBooking.Location = new System.Drawing.Point(263, 16);
            this.btnTraCuuBooking.Name = "btnTraCuuBooking";
            this.btnTraCuuBooking.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuBooking.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuBooking.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuBooking.TabIndex = 8;
            this.btnTraCuuBooking.Text = "Tra cứu";
            this.toolTip1.SetToolTip(this.btnTraCuuBooking, "Tra cứu");
            this.btnTraCuuBooking.UseVisualStyleBackColor = false;
            this.btnTraCuuBooking.Click += new System.EventHandler(this.btnTraCuuBooking_Click);
            // 
            // cboStateBooking
            // 
            this.cboStateBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateBooking.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateBooking.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateBooking.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Location = new System.Drawing.Point(225, 158);
            this.cboStateBooking.Name = "cboStateBooking";
            this.cboStateBooking.Size = new System.Drawing.Size(156, 33);
            this.cboStateBooking.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateBooking.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateBooking.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cboStateBooking, "Sắp xếp theo trạng thái");
            this.cboStateBooking.SelectedIndexChanged += new System.EventHandler(this.cboStateBooking_SelectedIndexChanged);
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayDat.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpNgayDat.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDat.Location = new System.Drawing.Point(141, 346);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(239, 34);
            this.dtpNgayDat.TabIndex = 21;
            this.toolTip1.SetToolTip(this.dtpNgayDat, "ngày đặt");
            this.dtpNgayDat.ToolTipText = "";
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
            this.spcQuery.Panel1.Controls.Add(this.dgvBooking);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.label3);
            this.spcQuery.Panel2.Controls.Add(this.txtCCCD);
            this.spcQuery.Panel2.Controls.Add(this.label2);
            this.spcQuery.Panel2.Controls.Add(this.txtTraCuuUser);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuDP);
            this.spcQuery.Panel2.Controls.Add(this.label1);
            this.spcQuery.Panel2.Controls.Add(this.lblQuickControl);
            this.spcQuery.Panel2.Controls.Add(this.btnCheckIn);
            this.spcQuery.Panel2.Controls.Add(this.btnCancel);
            this.spcQuery.Panel2.Controls.Add(this.btnCheckOut);
            this.spcQuery.Panel2.Controls.Add(this.cboSortRoomID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortBookingID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortRoomId);
            this.spcQuery.Panel2.Controls.Add(this.lblSortBookingID);
            this.spcQuery.Panel2.Controls.Add(this.lblBookingDate);
            this.spcQuery.Panel2.Controls.Add(this.lblStateBooking);
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayDat);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchBooking);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuBooking);
            this.spcQuery.Panel2.Controls.Add(this.cboStateBooking);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.AllowUserToResizeColumns = false;
            this.dgvBooking.AllowUserToResizeRows = false;
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDatPhong,
            this.colMaKH,
            this.colMaPHG,
            this.colCCCD,
            this.colTenTaiKhoan,
            this.colSoLuongKH,
            this.colNgayDatPhong,
            this.colNgayNhanPhong,
            this.colNgayTraPhong,
            this.colTrangThai});
            this.dgvBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooking.Location = new System.Drawing.Point(0, 0);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersVisible = false;
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.Size = new System.Drawing.Size(973, 746);
            this.dgvBooking.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "CCCD:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(141, 300);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(240, 40);
            this.txtCCCD.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txtCCCD, "Căn cước công dân");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTraCuuUser
            // 
            this.txtTraCuuUser.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraCuuUser.Location = new System.Drawing.Point(141, 254);
            this.txtTraCuuUser.Name = "txtTraCuuUser";
            this.txtTraCuuUser.Size = new System.Drawing.Size(240, 40);
            this.txtTraCuuUser.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtTraCuuUser, "Tên đăng nhập");
            // 
            // btnTraCuuDP
            // 
            this.btnTraCuuDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuDP.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuDP.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuDP.Location = new System.Drawing.Point(236, 397);
            this.btnTraCuuDP.Name = "btnTraCuuDP";
            this.btnTraCuuDP.Size = new System.Drawing.Size(145, 40);
            this.btnTraCuuDP.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuDP.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuDP.TabIndex = 22;
            this.btnTraCuuDP.Text = "Tìm kiếm";
            this.toolTip1.SetToolTip(this.btnTraCuuDP, "Tra cứu");
            this.btnTraCuuDP.UseVisualStyleBackColor = false;
            this.btnTraCuuDP.Click += new System.EventHandler(this.btnTraCuuDP_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tra cứu đặt phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuickControl
            // 
            this.lblQuickControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuickControl.AutoSize = true;
            this.lblQuickControl.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickControl.Location = new System.Drawing.Point(69, 475);
            this.lblQuickControl.Name = "lblQuickControl";
            this.lblQuickControl.Size = new System.Drawing.Size(273, 26);
            this.lblQuickControl.TabIndex = 23;
            this.lblQuickControl.Text = "Cập nhật trạng thái nhanh";
            this.lblQuickControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheckIn.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCheckIn.Location = new System.Drawing.Point(11, 522);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(108, 64);
            this.btnCheckIn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCheckIn.Style.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnCheckIn.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnCheckIn.TabIndex = 24;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCancel.Location = new System.Drawing.Point(273, 522);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 64);
            this.btnCancel.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.Style.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnCancel.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheckOut.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCheckOut.Location = new System.Drawing.Point(142, 522);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(108, 64);
            this.btnCheckOut.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCheckOut.Style.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.btnCheckOut.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnCheckOut.TabIndex = 25;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // cboSortRoomID
            // 
            this.cboSortRoomID.DelimiterChar = "";
            this.cboSortRoomID.DisplayMember = "";
            this.cboSortRoomID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortRoomID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortRoomID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Location = new System.Drawing.Point(225, 119);
            this.cboSortRoomID.Name = "cboSortRoomID";
            this.cboSortRoomID.Size = new System.Drawing.Size(156, 33);
            this.cboSortRoomID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortRoomID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortRoomID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomID.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cboSortRoomID, "Sắp xếp theo mã phòng");
            this.cboSortRoomID.SelectedIndexChanged += new System.EventHandler(this.cboSortRoomID_SelectedIndexChanged);
            // 
            // cboSortBookingID
            // 
            this.cboSortBookingID.DelimiterChar = "";
            this.cboSortBookingID.DisplayMember = "";
            this.cboSortBookingID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortBookingID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortBookingID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Location = new System.Drawing.Point(225, 80);
            this.cboSortBookingID.Name = "cboSortBookingID";
            this.cboSortBookingID.Size = new System.Drawing.Size(156, 33);
            this.cboSortBookingID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortBookingID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortBookingID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cboSortBookingID, "Sắp xếp theo mã đặt phòng");
            this.cboSortBookingID.SelectedIndexChanged += new System.EventHandler(this.cboSortBookingID_SelectedIndexChanged);
            // 
            // lblSortRoomId
            // 
            this.lblSortRoomId.AutoSize = true;
            this.lblSortRoomId.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortRoomId.Location = new System.Drawing.Point(4, 126);
            this.lblSortRoomId.Name = "lblSortRoomId";
            this.lblSortRoomId.Size = new System.Drawing.Size(192, 26);
            this.lblSortRoomId.TabIndex = 11;
            this.lblSortRoomId.Text = "Sort theo Room ID";
            this.lblSortRoomId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSortBookingID
            // 
            this.lblSortBookingID.AutoSize = true;
            this.lblSortBookingID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBookingID.Location = new System.Drawing.Point(4, 87);
            this.lblSortBookingID.Name = "lblSortBookingID";
            this.lblSortBookingID.Size = new System.Drawing.Size(218, 26);
            this.lblSortBookingID.TabIndex = 9;
            this.lblSortBookingID.Text = "Sort theo Booking ID";
            this.lblSortBookingID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.Location = new System.Drawing.Point(12, 354);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(106, 26);
            this.lblBookingDate.TabIndex = 20;
            this.lblBookingDate.Text = "Ngày đặt:";
            this.lblBookingDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateBooking
            // 
            this.lblStateBooking.AutoSize = true;
            this.lblStateBooking.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateBooking.Location = new System.Drawing.Point(5, 165);
            this.lblStateBooking.Name = "lblStateBooking";
            this.lblStateBooking.Size = new System.Drawing.Size(186, 26);
            this.lblStateBooking.TabIndex = 13;
            this.lblStateBooking.Text = "Trạng thái dữ liệu";
            this.lblStateBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblBooking);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // colMaDatPhong
            // 
            this.colMaDatPhong.DataPropertyName = "MaDatPhong";
            this.colMaDatPhong.HeaderText = "Mã đặt phòng";
            this.colMaDatPhong.MinimumWidth = 6;
            this.colMaDatPhong.Name = "colMaDatPhong";
            this.colMaDatPhong.ReadOnly = true;
            this.colMaDatPhong.Width = 147;
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "MaKH";
            this.colMaKH.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaKH.HeaderText = "Tên Khách Hàng";
            this.colMaKH.MinimumWidth = 6;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.ReadOnly = true;
            this.colMaKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaKH.Width = 133;
            // 
            // colMaPHG
            // 
            this.colMaPHG.DataPropertyName = "MaPHG";
            this.colMaPHG.HeaderText = "Mã PHG";
            this.colMaPHG.MinimumWidth = 6;
            this.colMaPHG.Name = "colMaPHG";
            this.colMaPHG.ReadOnly = true;
            this.colMaPHG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaPHG.Width = 91;
            // 
            // colCCCD
            // 
            this.colCCCD.DataPropertyName = "CCCD";
            this.colCCCD.HeaderText = "CCCD";
            this.colCCCD.Name = "colCCCD";
            this.colCCCD.ReadOnly = true;
            this.colCCCD.Visible = false;
            this.colCCCD.Width = 84;
            // 
            // colTenTaiKhoan
            // 
            this.colTenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.colTenTaiKhoan.HeaderText = "Tên Tài Khoản";
            this.colTenTaiKhoan.Name = "colTenTaiKhoan";
            this.colTenTaiKhoan.ReadOnly = true;
            this.colTenTaiKhoan.Visible = false;
            this.colTenTaiKhoan.Width = 133;
            // 
            // colSoLuongKH
            // 
            this.colSoLuongKH.DataPropertyName = "SoLuongKH";
            this.colSoLuongKH.HeaderText = "Số lượng KH";
            this.colSoLuongKH.MinimumWidth = 6;
            this.colSoLuongKH.Name = "colSoLuongKH";
            this.colSoLuongKH.ReadOnly = true;
            this.colSoLuongKH.Width = 123;
            // 
            // colNgayDatPhong
            // 
            this.colNgayDatPhong.DataPropertyName = "NgayDatPhong";
            this.colNgayDatPhong.HeaderText = "Ngày đặt";
            this.colNgayDatPhong.MinimumWidth = 6;
            this.colNgayDatPhong.Name = "colNgayDatPhong";
            this.colNgayDatPhong.ReadOnly = true;
            this.colNgayDatPhong.Width = 98;
            // 
            // colNgayNhanPhong
            // 
            this.colNgayNhanPhong.DataPropertyName = "NgayNhanPhong";
            this.colNgayNhanPhong.HeaderText = "Ngày nhận phòng";
            this.colNgayNhanPhong.MinimumWidth = 6;
            this.colNgayNhanPhong.Name = "colNgayNhanPhong";
            this.colNgayNhanPhong.ReadOnly = true;
            this.colNgayNhanPhong.Width = 165;
            // 
            // colNgayTraPhong
            // 
            this.colNgayTraPhong.DataPropertyName = "NgayTraPhong";
            this.colNgayTraPhong.HeaderText = "Ngày trả phòng";
            this.colNgayTraPhong.MinimumWidth = 6;
            this.colNgayTraPhong.Name = "colNgayTraPhong";
            this.colNgayTraPhong.ReadOnly = true;
            this.colNgayTraPhong.Width = 145;
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
            // ucBooking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucBooking";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucBooking_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateBooking)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBookingID)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBooking;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuBooking;
        private Syncfusion.WinForms.Controls.SfButton btnAddBooking;
        private System.Windows.Forms.TextBox txtSearchBooking;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteBooking;
        private Syncfusion.WinForms.Controls.SfButton btnEditBooking;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverBooking;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateBooking;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpNgayDat;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateBooking;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblSortRoomId;
        private System.Windows.Forms.Label lblSortBookingID;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortRoomID;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortBookingID;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label lblQuickControl;
        private Syncfusion.WinForms.Controls.SfButton btnCheckIn;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnCheckOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTraCuuUser;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDatPhong;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPHG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhanPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTraPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
