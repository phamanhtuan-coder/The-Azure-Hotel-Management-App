namespace GUI.UserControls
{
    partial class ucDeviceStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDeviceStatus));
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchDeviceStatus = new System.Windows.Forms.TextBox();
            this.btnTraCuuDeviceStatus = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateDeviceStatus = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.lvwDeviceStatus = new System.Windows.Forms.ListView();
            this.colMaDeviceStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenTinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuongPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboSortDeviceStatusID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortDeviceStatusD = new System.Windows.Forms.Label();
            this.cboSortSoLuongTB = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortSoLuongTB = new System.Windows.Forms.Label();
            this.lblStateDeviceStatus = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.btnAddDeviceStatus = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditDeviceStatus = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteDeviceStatus = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverDeviceStatus = new Syncfusion.WinForms.Controls.SfButton();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateDeviceStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortDeviceStatusID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuongTB)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeviceStatus
            // 
            this.lblDeviceStatus.BackColor = System.Drawing.Color.Lavender;
            this.lblDeviceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeviceStatus.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDeviceStatus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDeviceStatus.Location = new System.Drawing.Point(0, 0);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Size = new System.Drawing.Size(972, 94);
            this.lblDeviceStatus.TabIndex = 35;
            this.lblDeviceStatus.Text = "DEVICE STATUS";
            this.lblDeviceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddDeviceStatus, 0, 0);
            this.tlpController.Controls.Add(this.btnEditDeviceStatus, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteDeviceStatus, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverDeviceStatus, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // txtSearchDeviceStatus
            // 
            this.txtSearchDeviceStatus.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDeviceStatus.Location = new System.Drawing.Point(6, 16);
            this.txtSearchDeviceStatus.Name = "txtSearchDeviceStatus";
            this.txtSearchDeviceStatus.Size = new System.Drawing.Size(251, 40);
            this.txtSearchDeviceStatus.TabIndex = 2;
            // 
            // btnTraCuuDeviceStatus
            // 
            this.btnTraCuuDeviceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuDeviceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuDeviceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuDeviceStatus.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuDeviceStatus.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuDeviceStatus.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuDeviceStatus.Name = "btnTraCuuDeviceStatus";
            this.btnTraCuuDeviceStatus.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuDeviceStatus.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuDeviceStatus.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuDeviceStatus.TabIndex = 0;
            this.btnTraCuuDeviceStatus.Text = "Tra cứu";
            this.btnTraCuuDeviceStatus.UseVisualStyleBackColor = false;
            // 
            // cboStateDeviceStatus
            // 
            this.cboStateDeviceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateDeviceStatus.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateDeviceStatus.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateDeviceStatus.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateDeviceStatus.Location = new System.Drawing.Point(226, 193);
            this.cboStateDeviceStatus.Name = "cboStateDeviceStatus";
            this.cboStateDeviceStatus.Size = new System.Drawing.Size(156, 33);
            this.cboStateDeviceStatus.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateDeviceStatus.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateDeviceStatus.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateDeviceStatus.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateDeviceStatus.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateDeviceStatus.TabIndex = 3;
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
            this.spcQuery.Panel1.Controls.Add(this.lvwDeviceStatus);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortDeviceStatusID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortDeviceStatusD);
            this.spcQuery.Panel2.Controls.Add(this.cboSortSoLuongTB);
            this.spcQuery.Panel2.Controls.Add(this.lblSortSoLuongTB);
            this.spcQuery.Panel2.Controls.Add(this.lblStateDeviceStatus);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchDeviceStatus);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuDeviceStatus);
            this.spcQuery.Panel2.Controls.Add(this.cboStateDeviceStatus);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // lvwDeviceStatus
            // 
            this.lvwDeviceStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaDeviceStatus,
            this.colTenTinhTrang,
            this.colSoLuongPhong,
            this.colMoTa});
            this.lvwDeviceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwDeviceStatus.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDeviceStatus.FullRowSelect = true;
            this.lvwDeviceStatus.GridLines = true;
            this.lvwDeviceStatus.HideSelection = false;
            this.lvwDeviceStatus.Location = new System.Drawing.Point(0, 0);
            this.lvwDeviceStatus.MultiSelect = false;
            this.lvwDeviceStatus.Name = "lvwDeviceStatus";
            this.lvwDeviceStatus.Size = new System.Drawing.Size(973, 746);
            this.lvwDeviceStatus.TabIndex = 0;
            this.lvwDeviceStatus.UseCompatibleStateImageBehavior = false;
            this.lvwDeviceStatus.View = System.Windows.Forms.View.Details;
            // 
            // colMaDeviceStatus
            // 
            this.colMaDeviceStatus.Text = "Mã tình trạng thiết bị";
            this.colMaDeviceStatus.Width = 81;
            // 
            // colTenTinhTrang
            // 
            this.colTenTinhTrang.Text = "Tên tình trạng";
            this.colTenTinhTrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenTinhTrang.Width = 207;
            // 
            // colSoLuongPhong
            // 
            this.colSoLuongPhong.Text = "Số lượng thiết bĩ đang trong tình trạng";
            this.colSoLuongPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoLuongPhong.Width = 179;
            // 
            // colMoTa
            // 
            this.colMoTa.Text = "Mô tả";
            this.colMoTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMoTa.Width = 146;
            // 
            // cboSortDeviceStatusID
            // 
            this.cboSortDeviceStatusID.DelimiterChar = "";
            this.cboSortDeviceStatusID.DisplayMember = "";
            this.cboSortDeviceStatusID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortDeviceStatusID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortDeviceStatusID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDeviceStatusID.Location = new System.Drawing.Point(226, 79);
            this.cboSortDeviceStatusID.Name = "cboSortDeviceStatusID";
            this.cboSortDeviceStatusID.Size = new System.Drawing.Size(156, 33);
            this.cboSortDeviceStatusID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortDeviceStatusID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDeviceStatusID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDeviceStatusID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortDeviceStatusID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDeviceStatusID.TabIndex = 29;
            // 
            // lblSortDeviceStatusD
            // 
            this.lblSortDeviceStatusD.AutoSize = true;
            this.lblSortDeviceStatusD.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortDeviceStatusD.Location = new System.Drawing.Point(2, 86);
            this.lblSortDeviceStatusD.Name = "lblSortDeviceStatusD";
            this.lblSortDeviceStatusD.Size = new System.Drawing.Size(170, 26);
            this.lblSortDeviceStatusD.TabIndex = 28;
            this.lblSortDeviceStatusD.Text = "Sort theo ID loại";
            this.lblSortDeviceStatusD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortSoLuongTB
            // 
            this.cboSortSoLuongTB.DelimiterChar = "";
            this.cboSortSoLuongTB.DisplayMember = "";
            this.cboSortSoLuongTB.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortSoLuongTB.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortSoLuongTB.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongTB.Location = new System.Drawing.Point(227, 136);
            this.cboSortSoLuongTB.Name = "cboSortSoLuongTB";
            this.cboSortSoLuongTB.Size = new System.Drawing.Size(156, 33);
            this.cboSortSoLuongTB.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortSoLuongTB.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongTB.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongTB.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortSoLuongTB.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongTB.TabIndex = 23;
            // 
            // lblSortSoLuongTB
            // 
            this.lblSortSoLuongTB.AutoSize = true;
            this.lblSortSoLuongTB.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortSoLuongTB.Location = new System.Drawing.Point(2, 143);
            this.lblSortSoLuongTB.Name = "lblSortSoLuongTB";
            this.lblSortSoLuongTB.Size = new System.Drawing.Size(185, 26);
            this.lblSortSoLuongTB.TabIndex = 14;
            this.lblSortSoLuongTB.Text = "Lọc theo số lượng";
            this.lblSortSoLuongTB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateDeviceStatus
            // 
            this.lblStateDeviceStatus.AutoSize = true;
            this.lblStateDeviceStatus.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateDeviceStatus.Location = new System.Drawing.Point(2, 200);
            this.lblStateDeviceStatus.Name = "lblStateDeviceStatus";
            this.lblStateDeviceStatus.Size = new System.Drawing.Size(186, 26);
            this.lblStateDeviceStatus.TabIndex = 9;
            this.lblStateDeviceStatus.Text = "Trạng thái dữ liệu";
            this.lblStateDeviceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblDeviceStatus);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // btnAddDeviceStatus
            // 
            this.btnAddDeviceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddDeviceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDeviceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeviceStatus.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDeviceStatus.ForeColor = System.Drawing.Color.White;
            this.btnAddDeviceStatus.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddDeviceStatus.Location = new System.Drawing.Point(3, 3);
            this.btnAddDeviceStatus.Name = "btnAddDeviceStatus";
            this.btnAddDeviceStatus.Size = new System.Drawing.Size(191, 41);
            this.btnAddDeviceStatus.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddDeviceStatus.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddDeviceStatus.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddDeviceStatus.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddDeviceStatus.TabIndex = 1;
            this.btnAddDeviceStatus.Text = "Thêm";
            this.btnAddDeviceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDeviceStatus.UseVisualStyleBackColor = false;
            this.btnAddDeviceStatus.Click += new System.EventHandler(this.btnAddDeviceStatus_Click);
            // 
            // btnEditDeviceStatus
            // 
            this.btnEditDeviceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditDeviceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditDeviceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDeviceStatus.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDeviceStatus.ForeColor = System.Drawing.Color.White;
            this.btnEditDeviceStatus.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditDeviceStatus.Location = new System.Drawing.Point(3, 50);
            this.btnEditDeviceStatus.Name = "btnEditDeviceStatus";
            this.btnEditDeviceStatus.Size = new System.Drawing.Size(191, 41);
            this.btnEditDeviceStatus.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditDeviceStatus.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditDeviceStatus.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditDeviceStatus.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditDeviceStatus.TabIndex = 3;
            this.btnEditDeviceStatus.Text = "Sửa";
            this.btnEditDeviceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditDeviceStatus.UseVisualStyleBackColor = false;
            this.btnEditDeviceStatus.Click += new System.EventHandler(this.btnEditDeviceStatus_Click);
            // 
            // btnDeleteDeviceStatus
            // 
            this.btnDeleteDeviceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteDeviceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteDeviceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDeviceStatus.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDeviceStatus.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDeviceStatus.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteDeviceStatus.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteDeviceStatus.Name = "btnDeleteDeviceStatus";
            this.btnDeleteDeviceStatus.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteDeviceStatus.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteDeviceStatus.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDeviceStatus.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteDeviceStatus.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteDeviceStatus.TabIndex = 4;
            this.btnDeleteDeviceStatus.Text = "Xóa";
            this.btnDeleteDeviceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteDeviceStatus.UseVisualStyleBackColor = false;
            // 
            // btnRecoverDeviceStatus
            // 
            this.btnRecoverDeviceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverDeviceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverDeviceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverDeviceStatus.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverDeviceStatus.ForeColor = System.Drawing.Color.White;
            this.btnRecoverDeviceStatus.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverDeviceStatus.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverDeviceStatus.Name = "btnRecoverDeviceStatus";
            this.btnRecoverDeviceStatus.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverDeviceStatus.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverDeviceStatus.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverDeviceStatus.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverDeviceStatus.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverDeviceStatus.TabIndex = 5;
            this.btnRecoverDeviceStatus.Text = "Khôi phục";
            this.btnRecoverDeviceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverDeviceStatus.UseVisualStyleBackColor = false;
            // 
            // ucDeviceStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucDeviceStatus";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucDeviceStatus_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateDeviceStatus)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboSortDeviceStatusID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuongTB)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceStatus;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuDeviceStatus;
        private Syncfusion.WinForms.Controls.SfButton btnAddDeviceStatus;
        private System.Windows.Forms.TextBox txtSearchDeviceStatus;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteDeviceStatus;
        private Syncfusion.WinForms.Controls.SfButton btnEditDeviceStatus;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverDeviceStatus;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateDeviceStatus;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateDeviceStatus;
        private System.Windows.Forms.ListView lvwDeviceStatus;
        private System.Windows.Forms.ColumnHeader colMaDeviceStatus;
        private System.Windows.Forms.ColumnHeader colTenTinhTrang;
        private System.Windows.Forms.ColumnHeader colSoLuongPhong;
        private System.Windows.Forms.ColumnHeader colMoTa;
        private System.Windows.Forms.Label lblSortSoLuongTB;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortSoLuongTB;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortDeviceStatusID;
        private System.Windows.Forms.Label lblSortDeviceStatusD;
    }
}
