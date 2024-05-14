namespace GUI.UserControls
{
    partial class ucDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDevice));
            this.lblDevice = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddDevice = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditDevice = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteDevice = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverDevice = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchDevice = new System.Windows.Forms.TextBox();
            this.btnTraCuuDevice = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateDeviceStatus = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.cboSortDeviceID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortDeviceID = new System.Windows.Forms.Label();
            this.cboLocTheoTinhTrang = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblLocTheoTinhTrang = new System.Windows.Forms.Label();
            this.lblStateDeviceStatus = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTinhTrangThietBi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateDeviceStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortDeviceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLocTheoTinhTrang)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDevice
            // 
            this.lblDevice.BackColor = System.Drawing.Color.Lavender;
            this.lblDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDevice.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDevice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDevice.Location = new System.Drawing.Point(0, 0);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(972, 94);
            this.lblDevice.TabIndex = 1;
            this.lblDevice.Text = "DEVICES";
            this.lblDevice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddDevice, 0, 0);
            this.tlpController.Controls.Add(this.btnEditDevice, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteDevice, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverDevice, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDevice.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDevice.ForeColor = System.Drawing.Color.White;
            this.btnAddDevice.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddDevice.Location = new System.Drawing.Point(3, 3);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(191, 41);
            this.btnAddDevice.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddDevice.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddDevice.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddDevice.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddDevice.TabIndex = 2;
            this.btnAddDevice.Text = "Thêm";
            this.btnAddDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddDevice, "Thêm thiết bị");
            this.btnAddDevice.UseVisualStyleBackColor = false;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // btnEditDevice
            // 
            this.btnEditDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDevice.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDevice.ForeColor = System.Drawing.Color.White;
            this.btnEditDevice.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditDevice.Location = new System.Drawing.Point(3, 50);
            this.btnEditDevice.Name = "btnEditDevice";
            this.btnEditDevice.Size = new System.Drawing.Size(191, 41);
            this.btnEditDevice.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditDevice.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditDevice.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditDevice.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditDevice.TabIndex = 4;
            this.btnEditDevice.Text = "Sửa";
            this.btnEditDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditDevice, "Sủa thiết bị");
            this.btnEditDevice.UseVisualStyleBackColor = false;
            this.btnEditDevice.Click += new System.EventHandler(this.btnEditDevice_Click);
            // 
            // btnDeleteDevice
            // 
            this.btnDeleteDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDevice.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDevice.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDevice.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteDevice.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteDevice.Name = "btnDeleteDevice";
            this.btnDeleteDevice.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteDevice.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteDevice.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDevice.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteDevice.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteDevice.TabIndex = 3;
            this.btnDeleteDevice.Text = "Xóa";
            this.btnDeleteDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteDevice, "Xóa thiết bị");
            this.btnDeleteDevice.UseVisualStyleBackColor = false;
            this.btnDeleteDevice.Click += new System.EventHandler(this.btnDeleteDevice_Click);
            // 
            // btnRecoverDevice
            // 
            this.btnRecoverDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverDevice.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverDevice.ForeColor = System.Drawing.Color.White;
            this.btnRecoverDevice.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverDevice.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverDevice.Name = "btnRecoverDevice";
            this.btnRecoverDevice.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverDevice.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverDevice.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverDevice.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverDevice.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverDevice.TabIndex = 5;
            this.btnRecoverDevice.Text = "Khôi phục";
            this.btnRecoverDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRecoverDevice, "Khôi phục thiết bị");
            this.btnRecoverDevice.UseVisualStyleBackColor = false;
            this.btnRecoverDevice.Click += new System.EventHandler(this.btnRecoverDevice_Click);
            // 
            // txtSearchDevice
            // 
            this.txtSearchDevice.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDevice.Location = new System.Drawing.Point(6, 16);
            this.txtSearchDevice.Name = "txtSearchDevice";
            this.txtSearchDevice.Size = new System.Drawing.Size(251, 40);
            this.txtSearchDevice.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSearchDevice, "Nhập tên thiết bị");
            // 
            // btnTraCuuDevice
            // 
            this.btnTraCuuDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuDevice.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuDevice.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuDevice.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuDevice.Name = "btnTraCuuDevice";
            this.btnTraCuuDevice.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuDevice.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuDevice.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuDevice.TabIndex = 8;
            this.btnTraCuuDevice.Text = "Tra cứu";
            this.toolTip1.SetToolTip(this.btnTraCuuDevice, "Tra cứu");
            this.btnTraCuuDevice.UseVisualStyleBackColor = false;
            this.btnTraCuuDevice.Click += new System.EventHandler(this.btnTraCuuDevice_Click);
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
            this.cboStateDeviceStatus.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cboStateDeviceStatus, "Lọc theo trạng thái");
            this.cboStateDeviceStatus.SelectedIndexChanged += new System.EventHandler(this.cboStateDeviceStatus_SelectedIndexChanged);
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
            this.spcQuery.Panel1.Controls.Add(this.dgvDevice);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortDeviceID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortDeviceID);
            this.spcQuery.Panel2.Controls.Add(this.cboLocTheoTinhTrang);
            this.spcQuery.Panel2.Controls.Add(this.lblLocTheoTinhTrang);
            this.spcQuery.Panel2.Controls.Add(this.lblStateDeviceStatus);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchDevice);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuDevice);
            this.spcQuery.Panel2.Controls.Add(this.cboStateDeviceStatus);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AllowUserToDeleteRows = false;
            this.dgvDevice.AllowUserToResizeColumns = false;
            this.dgvDevice.AllowUserToResizeRows = false;
            this.dgvDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThietBi,
            this.TenThietBi,
            this.MaTinhTrangThietBi,
            this.TrangThai});
            this.dgvDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevice.Location = new System.Drawing.Point(0, 0);
            this.dgvDevice.MultiSelect = false;
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.ReadOnly = true;
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowHeadersWidth = 51;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(973, 746);
            this.dgvDevice.TabIndex = 6;
            // 
            // cboSortDeviceID
            // 
            this.cboSortDeviceID.DelimiterChar = "";
            this.cboSortDeviceID.DisplayMember = "";
            this.cboSortDeviceID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortDeviceID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortDeviceID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDeviceID.Location = new System.Drawing.Point(226, 79);
            this.cboSortDeviceID.Name = "cboSortDeviceID";
            this.cboSortDeviceID.Size = new System.Drawing.Size(156, 33);
            this.cboSortDeviceID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortDeviceID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDeviceID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDeviceID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortDeviceID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDeviceID.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cboSortDeviceID, "Sắp xếp theo mã loại");
            this.cboSortDeviceID.SelectedIndexChanged += new System.EventHandler(this.cboSortDeviceID_SelectedIndexChanged);
            // 
            // lblSortDeviceID
            // 
            this.lblSortDeviceID.AutoSize = true;
            this.lblSortDeviceID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortDeviceID.Location = new System.Drawing.Point(2, 86);
            this.lblSortDeviceID.Name = "lblSortDeviceID";
            this.lblSortDeviceID.Size = new System.Drawing.Size(170, 26);
            this.lblSortDeviceID.TabIndex = 9;
            this.lblSortDeviceID.Text = "Sort theo ID loại";
            this.lblSortDeviceID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboLocTheoTinhTrang
            // 
            this.cboLocTheoTinhTrang.DelimiterChar = "";
            this.cboLocTheoTinhTrang.DisplayMember = "";
            this.cboLocTheoTinhTrang.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboLocTheoTinhTrang.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboLocTheoTinhTrang.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTheoTinhTrang.Location = new System.Drawing.Point(227, 136);
            this.cboLocTheoTinhTrang.Name = "cboLocTheoTinhTrang";
            this.cboLocTheoTinhTrang.Size = new System.Drawing.Size(156, 33);
            this.cboLocTheoTinhTrang.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboLocTheoTinhTrang.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTheoTinhTrang.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTheoTinhTrang.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboLocTheoTinhTrang.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTheoTinhTrang.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cboLocTheoTinhTrang, "Lọc theo số lượng");
            // 
            // lblLocTheoTinhTrang
            // 
            this.lblLocTheoTinhTrang.AutoSize = true;
            this.lblLocTheoTinhTrang.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocTheoTinhTrang.Location = new System.Drawing.Point(2, 143);
            this.lblLocTheoTinhTrang.Name = "lblLocTheoTinhTrang";
            this.lblLocTheoTinhTrang.Size = new System.Drawing.Size(185, 26);
            this.lblLocTheoTinhTrang.TabIndex = 11;
            this.lblLocTheoTinhTrang.Text = "Lọc theo số lượng";
            this.lblLocTheoTinhTrang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateDeviceStatus
            // 
            this.lblStateDeviceStatus.AutoSize = true;
            this.lblStateDeviceStatus.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateDeviceStatus.Location = new System.Drawing.Point(2, 200);
            this.lblStateDeviceStatus.Name = "lblStateDeviceStatus";
            this.lblStateDeviceStatus.Size = new System.Drawing.Size(186, 26);
            this.lblStateDeviceStatus.TabIndex = 13;
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
            this.spcHeader.Panel1.Controls.Add(this.lblDevice);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // MaThietBi
            // 
            this.MaThietBi.DataPropertyName = "MaThietBi";
            this.MaThietBi.HeaderText = "Mã thiết bị";
            this.MaThietBi.MinimumWidth = 6;
            this.MaThietBi.Name = "MaThietBi";
            this.MaThietBi.ReadOnly = true;
            // 
            // TenThietBi
            // 
            this.TenThietBi.DataPropertyName = "TenThietBi";
            this.TenThietBi.HeaderText = "Tên thiết bị";
            this.TenThietBi.MinimumWidth = 6;
            this.TenThietBi.Name = "TenThietBi";
            this.TenThietBi.ReadOnly = true;
            // 
            // MaTinhTrangThietBi
            // 
            this.MaTinhTrangThietBi.DataPropertyName = "MaTinhTrangThietBi";
            this.MaTinhTrangThietBi.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MaTinhTrangThietBi.HeaderText = "Tình trạng thiết bị";
            this.MaTinhTrangThietBi.MinimumWidth = 6;
            this.MaTinhTrangThietBi.Name = "MaTinhTrangThietBi";
            this.MaTinhTrangThietBi.ReadOnly = true;
            this.MaTinhTrangThietBi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaTinhTrangThietBi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            // 
            // ucDevice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucDevice";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucDevice_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateDeviceStatus)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortDeviceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLocTheoTinhTrang)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDevice;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuDevice;
        private Syncfusion.WinForms.Controls.SfButton btnAddDevice;
        private System.Windows.Forms.TextBox txtSearchDevice;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteDevice;
        private Syncfusion.WinForms.Controls.SfButton btnEditDevice;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverDevice;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateDeviceStatus;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateDeviceStatus;
        private System.Windows.Forms.Label lblLocTheoTinhTrang;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboLocTheoTinhTrang;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortDeviceID;
        private System.Windows.Forms.Label lblSortDeviceID;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThietBi;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaTinhTrangThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}
