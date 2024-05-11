namespace GUI.UserControls
{
    partial class ucServiceType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucServiceType));
            this.lblServiceType = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddServiceType = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditServiceType = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteServiceType = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverServiceType = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchServiceType = new System.Windows.Forms.TextBox();
            this.btnTraCuuServiceType = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateRoomType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvServiceType = new System.Windows.Forms.DataGridView();
            this.cboSortServiceTypeID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortServiceTypeID = new System.Windows.Forms.Label();
            this.cboSortGiaServiceType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortGiaServiceTypeID = new System.Windows.Forms.Label();
            this.lblStateRoomType = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.picDichVu = new System.Windows.Forms.PictureBox();
            this.colMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortServiceTypeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortGiaServiceType)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiceType
            // 
            this.lblServiceType.BackColor = System.Drawing.Color.Lavender;
            this.lblServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServiceType.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblServiceType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblServiceType.Location = new System.Drawing.Point(0, 0);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(972, 94);
            this.lblServiceType.TabIndex = 35;
            this.lblServiceType.Text = "SERVICE TYPE";
            this.lblServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddServiceType, 0, 0);
            this.tlpController.Controls.Add(this.btnEditServiceType, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteServiceType, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverServiceType, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddServiceType
            // 
            this.btnAddServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServiceType.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServiceType.ForeColor = System.Drawing.Color.White;
            this.btnAddServiceType.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddServiceType.Location = new System.Drawing.Point(3, 3);
            this.btnAddServiceType.Name = "btnAddServiceType";
            this.btnAddServiceType.Size = new System.Drawing.Size(191, 41);
            this.btnAddServiceType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddServiceType.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddServiceType.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddServiceType.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddServiceType.TabIndex = 1;
            this.btnAddServiceType.Text = "Thêm";
            this.btnAddServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddServiceType.UseVisualStyleBackColor = false;
            this.btnAddServiceType.Click += new System.EventHandler(this.btnAddServiceType_Click);
            // 
            // btnEditServiceType
            // 
            this.btnEditServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditServiceType.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditServiceType.ForeColor = System.Drawing.Color.White;
            this.btnEditServiceType.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditServiceType.Location = new System.Drawing.Point(3, 50);
            this.btnEditServiceType.Name = "btnEditServiceType";
            this.btnEditServiceType.Size = new System.Drawing.Size(191, 41);
            this.btnEditServiceType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditServiceType.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditServiceType.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditServiceType.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditServiceType.TabIndex = 3;
            this.btnEditServiceType.Text = "Sửa";
            this.btnEditServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditServiceType.UseVisualStyleBackColor = false;
            this.btnEditServiceType.Click += new System.EventHandler(this.btnEditServiceType_Click);
            // 
            // btnDeleteServiceType
            // 
            this.btnDeleteServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteServiceType.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteServiceType.ForeColor = System.Drawing.Color.White;
            this.btnDeleteServiceType.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteServiceType.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteServiceType.Name = "btnDeleteServiceType";
            this.btnDeleteServiceType.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteServiceType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteServiceType.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteServiceType.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteServiceType.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteServiceType.TabIndex = 4;
            this.btnDeleteServiceType.Text = "Xóa";
            this.btnDeleteServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteServiceType.UseVisualStyleBackColor = false;
            this.btnDeleteServiceType.Click += new System.EventHandler(this.btnDeleteServiceType_Click);
            // 
            // btnRecoverServiceType
            // 
            this.btnRecoverServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverServiceType.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverServiceType.ForeColor = System.Drawing.Color.White;
            this.btnRecoverServiceType.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverServiceType.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverServiceType.Name = "btnRecoverServiceType";
            this.btnRecoverServiceType.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverServiceType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverServiceType.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverServiceType.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverServiceType.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverServiceType.TabIndex = 5;
            this.btnRecoverServiceType.Text = "Khôi phục";
            this.btnRecoverServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverServiceType.UseVisualStyleBackColor = false;
            this.btnRecoverServiceType.Click += new System.EventHandler(this.btnRecoverServiceType_Click);
            // 
            // txtSearchServiceType
            // 
            this.txtSearchServiceType.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchServiceType.Location = new System.Drawing.Point(14, 172);
            this.txtSearchServiceType.Name = "txtSearchServiceType";
            this.txtSearchServiceType.Size = new System.Drawing.Size(251, 40);
            this.txtSearchServiceType.TabIndex = 2;
            // 
            // btnTraCuuServiceType
            // 
            this.btnTraCuuServiceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuServiceType.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuServiceType.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuServiceType.Location = new System.Drawing.Point(272, 172);
            this.btnTraCuuServiceType.Name = "btnTraCuuServiceType";
            this.btnTraCuuServiceType.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuServiceType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuServiceType.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuServiceType.TabIndex = 0;
            this.btnTraCuuServiceType.Text = "Tra cứu";
            this.btnTraCuuServiceType.UseVisualStyleBackColor = false;
            this.btnTraCuuServiceType.Click += new System.EventHandler(this.btnTraCuuServiceType_Click);
            // 
            // cboStateRoomType
            // 
            this.cboStateRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateRoomType.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateRoomType.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateRoomType.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoomType.Location = new System.Drawing.Point(233, 342);
            this.cboStateRoomType.Name = "cboStateRoomType";
            this.cboStateRoomType.Size = new System.Drawing.Size(156, 33);
            this.cboStateRoomType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateRoomType.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoomType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoomType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateRoomType.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoomType.TabIndex = 3;
            this.cboStateRoomType.SelectedIndexChanged += new System.EventHandler(this.cboStateRoomType_SelectedIndexChanged);
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
            this.spcQuery.Panel1.Controls.Add(this.dgvServiceType);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.picDichVu);
            this.spcQuery.Panel2.Controls.Add(this.cboSortServiceTypeID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortServiceTypeID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortGiaServiceType);
            this.spcQuery.Panel2.Controls.Add(this.lblSortGiaServiceTypeID);
            this.spcQuery.Panel2.Controls.Add(this.lblStateRoomType);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchServiceType);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuServiceType);
            this.spcQuery.Panel2.Controls.Add(this.cboStateRoomType);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvServiceType
            // 
            this.dgvServiceType.AllowUserToAddRows = false;
            this.dgvServiceType.AllowUserToDeleteRows = false;
            this.dgvServiceType.AllowUserToResizeColumns = false;
            this.dgvServiceType.AllowUserToResizeRows = false;
            this.dgvServiceType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvServiceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDV,
            this.colTenDV,
            this.colGiaDV,
            this.colTrangThai,
            this.colHinhAnh});
            this.dgvServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceType.Location = new System.Drawing.Point(0, 0);
            this.dgvServiceType.MultiSelect = false;
            this.dgvServiceType.Name = "dgvServiceType";
            this.dgvServiceType.ReadOnly = true;
            this.dgvServiceType.RowHeadersVisible = false;
            this.dgvServiceType.RowHeadersWidth = 51;
            this.dgvServiceType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceType.Size = new System.Drawing.Size(973, 746);
            this.dgvServiceType.TabIndex = 1;
            this.dgvServiceType.SelectionChanged += new System.EventHandler(this.dgvServiceType_SelectionChanged);
            // 
            // cboSortServiceTypeID
            // 
            this.cboSortServiceTypeID.DelimiterChar = "";
            this.cboSortServiceTypeID.DisplayMember = "";
            this.cboSortServiceTypeID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortServiceTypeID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortServiceTypeID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortServiceTypeID.Location = new System.Drawing.Point(234, 234);
            this.cboSortServiceTypeID.Name = "cboSortServiceTypeID";
            this.cboSortServiceTypeID.Size = new System.Drawing.Size(156, 33);
            this.cboSortServiceTypeID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortServiceTypeID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortServiceTypeID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortServiceTypeID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortServiceTypeID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortServiceTypeID.TabIndex = 29;
            this.cboSortServiceTypeID.SelectedIndexChanged += new System.EventHandler(this.cboSortServiceTypeID_SelectedIndexChanged);
            // 
            // lblSortServiceTypeID
            // 
            this.lblSortServiceTypeID.AutoSize = true;
            this.lblSortServiceTypeID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortServiceTypeID.Location = new System.Drawing.Point(11, 241);
            this.lblSortServiceTypeID.Name = "lblSortServiceTypeID";
            this.lblSortServiceTypeID.Size = new System.Drawing.Size(208, 26);
            this.lblSortServiceTypeID.TabIndex = 28;
            this.lblSortServiceTypeID.Text = "Sort Service Type ID";
            this.lblSortServiceTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortGiaServiceType
            // 
            this.cboSortGiaServiceType.DelimiterChar = "";
            this.cboSortGiaServiceType.DisplayMember = "";
            this.cboSortGiaServiceType.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortGiaServiceType.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortGiaServiceType.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortGiaServiceType.Location = new System.Drawing.Point(235, 289);
            this.cboSortGiaServiceType.Name = "cboSortGiaServiceType";
            this.cboSortGiaServiceType.Size = new System.Drawing.Size(156, 33);
            this.cboSortGiaServiceType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortGiaServiceType.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortGiaServiceType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortGiaServiceType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortGiaServiceType.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortGiaServiceType.TabIndex = 23;
            this.cboSortGiaServiceType.SelectedIndexChanged += new System.EventHandler(this.cboSortGiaServiceType_SelectedIndexChanged);
            // 
            // lblSortGiaServiceTypeID
            // 
            this.lblSortGiaServiceTypeID.AutoSize = true;
            this.lblSortGiaServiceTypeID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortGiaServiceTypeID.Location = new System.Drawing.Point(11, 296);
            this.lblSortGiaServiceTypeID.Name = "lblSortGiaServiceTypeID";
            this.lblSortGiaServiceTypeID.Size = new System.Drawing.Size(138, 26);
            this.lblSortGiaServiceTypeID.TabIndex = 14;
            this.lblSortGiaServiceTypeID.Text = "Sort theo giá";
            this.lblSortGiaServiceTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateRoomType
            // 
            this.lblStateRoomType.AutoSize = true;
            this.lblStateRoomType.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateRoomType.Location = new System.Drawing.Point(10, 349);
            this.lblStateRoomType.Name = "lblStateRoomType";
            this.lblStateRoomType.Size = new System.Drawing.Size(186, 26);
            this.lblStateRoomType.TabIndex = 9;
            this.lblStateRoomType.Text = "Trạng thái dữ liệu";
            this.lblStateRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblServiceType);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // picDichVu
            // 
            this.picDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picDichVu.Image = global::GUI.Properties.Resources.no_pictures;
            this.picDichVu.Location = new System.Drawing.Point(61, 18);
            this.picDichVu.Name = "picDichVu";
            this.picDichVu.Size = new System.Drawing.Size(295, 131);
            this.picDichVu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDichVu.TabIndex = 40;
            this.picDichVu.TabStop = false;
            // 
            // colMaDV
            // 
            this.colMaDV.DataPropertyName = "MaDV";
            this.colMaDV.HeaderText = "Mã dịch vụ";
            this.colMaDV.MinimumWidth = 6;
            this.colMaDV.Name = "colMaDV";
            this.colMaDV.ReadOnly = true;
            this.colMaDV.Width = 122;
            // 
            // colTenDV
            // 
            this.colTenDV.DataPropertyName = "TenDV";
            this.colTenDV.HeaderText = "Tên dịch vụ";
            this.colTenDV.MinimumWidth = 6;
            this.colTenDV.Name = "colTenDV";
            this.colTenDV.ReadOnly = true;
            this.colTenDV.Width = 127;
            // 
            // colGiaDV
            // 
            this.colGiaDV.DataPropertyName = "GiaDV";
            this.colGiaDV.HeaderText = "Giá";
            this.colGiaDV.MinimumWidth = 6;
            this.colGiaDV.Name = "colGiaDV";
            this.colGiaDV.ReadOnly = true;
            this.colGiaDV.Width = 60;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Visible = false;
            this.colTrangThai.Width = 114;
            // 
            // colHinhAnh
            // 
            this.colHinhAnh.DataPropertyName = "HinhAnh";
            this.colHinhAnh.HeaderText = "Hình ảnh";
            this.colHinhAnh.Name = "colHinhAnh";
            this.colHinhAnh.ReadOnly = true;
            this.colHinhAnh.Visible = false;
            this.colHinhAnh.Width = 90;
            // 
            // ucServiceType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucServiceType";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucServiceType_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRoomType)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortServiceTypeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortGiaServiceType)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServiceType;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuServiceType;
        private Syncfusion.WinForms.Controls.SfButton btnAddServiceType;
        private System.Windows.Forms.TextBox txtSearchServiceType;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteServiceType;
        private Syncfusion.WinForms.Controls.SfButton btnEditServiceType;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverServiceType;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateRoomType;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateRoomType;
        private System.Windows.Forms.Label lblSortGiaServiceTypeID;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortGiaServiceType;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortServiceTypeID;
        private System.Windows.Forms.Label lblSortServiceTypeID;
        private System.Windows.Forms.DataGridView dgvServiceType;
        private System.Windows.Forms.PictureBox picDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewImageColumn colHinhAnh;
    }
}
