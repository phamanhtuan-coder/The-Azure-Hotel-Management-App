namespace GUI.UserControls
{
    partial class ucMaintance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMaintance));
            this.lblMaintance = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchMaintance = new System.Windows.Forms.TextBox();
            this.btnTraCuuMaintance = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateMaintance = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.lvwMaintance = new System.Windows.Forms.ListView();
            this.colMaDP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPHG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayNhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayHT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpNgayHoanThanh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.lblNgayHoanThanh = new System.Windows.Forms.Label();
            this.cboSortMaintanceID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortMaintanceID = new System.Windows.Forms.Label();
            this.lblLocNgayNhan = new System.Windows.Forms.Label();
            this.lblStateMaintance = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.btnAddMaintance = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditMaintance = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteMaintance = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverMaintance = new Syncfusion.WinForms.Controls.SfButton();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateMaintance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortMaintanceID)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaintance
            // 
            this.lblMaintance.BackColor = System.Drawing.Color.Lavender;
            this.lblMaintance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaintance.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaintance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblMaintance.Location = new System.Drawing.Point(0, 0);
            this.lblMaintance.Name = "lblMaintance";
            this.lblMaintance.Size = new System.Drawing.Size(972, 94);
            this.lblMaintance.TabIndex = 35;
            this.lblMaintance.Text = "HOUSEKEEPING";
            this.lblMaintance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddMaintance, 0, 0);
            this.tlpController.Controls.Add(this.btnEditMaintance, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteMaintance, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverMaintance, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // txtSearchMaintance
            // 
            this.txtSearchMaintance.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMaintance.Location = new System.Drawing.Point(6, 16);
            this.txtSearchMaintance.Name = "txtSearchMaintance";
            this.txtSearchMaintance.Size = new System.Drawing.Size(251, 40);
            this.txtSearchMaintance.TabIndex = 2;
            // 
            // btnTraCuuMaintance
            // 
            this.btnTraCuuMaintance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuMaintance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuMaintance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuMaintance.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuMaintance.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuMaintance.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuMaintance.Name = "btnTraCuuMaintance";
            this.btnTraCuuMaintance.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuMaintance.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuMaintance.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuMaintance.TabIndex = 0;
            this.btnTraCuuMaintance.Text = "Tra cứu";
            this.btnTraCuuMaintance.UseVisualStyleBackColor = false;
            // 
            // cboStateMaintance
            // 
            this.cboStateMaintance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateMaintance.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateMaintance.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateMaintance.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateMaintance.Location = new System.Drawing.Point(221, 257);
            this.cboStateMaintance.Name = "cboStateMaintance";
            this.cboStateMaintance.Size = new System.Drawing.Size(156, 33);
            this.cboStateMaintance.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateMaintance.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateMaintance.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateMaintance.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateMaintance.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateMaintance.TabIndex = 3;
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
            this.spcQuery.Panel1.Controls.Add(this.lvwMaintance);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayHoanThanh);
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayNhan);
            this.spcQuery.Panel2.Controls.Add(this.lblNgayHoanThanh);
            this.spcQuery.Panel2.Controls.Add(this.cboSortMaintanceID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortMaintanceID);
            this.spcQuery.Panel2.Controls.Add(this.lblLocNgayNhan);
            this.spcQuery.Panel2.Controls.Add(this.lblStateMaintance);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchMaintance);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuMaintance);
            this.spcQuery.Panel2.Controls.Add(this.cboStateMaintance);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // lvwMaintance
            // 
            this.lvwMaintance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaDP,
            this.colPHG,
            this.colNV,
            this.colNgayNhan,
            this.colNgayHT});
            this.lvwMaintance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMaintance.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMaintance.FullRowSelect = true;
            this.lvwMaintance.GridLines = true;
            this.lvwMaintance.HideSelection = false;
            this.lvwMaintance.Location = new System.Drawing.Point(0, 0);
            this.lvwMaintance.MultiSelect = false;
            this.lvwMaintance.Name = "lvwMaintance";
            this.lvwMaintance.Size = new System.Drawing.Size(973, 746);
            this.lvwMaintance.TabIndex = 0;
            this.lvwMaintance.UseCompatibleStateImageBehavior = false;
            this.lvwMaintance.View = System.Windows.Forms.View.Details;
            // 
            // colMaDP
            // 
            this.colMaDP.Text = "Mã dọn phòng";
            this.colMaDP.Width = 81;
            // 
            // colPHG
            // 
            this.colPHG.Text = "Mã phòng";
            this.colPHG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPHG.Width = 207;
            // 
            // colNV
            // 
            this.colNV.Text = "Mã NV";
            this.colNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNV.Width = 179;
            // 
            // colNgayNhan
            // 
            this.colNgayNhan.Text = "Ngày nhận";
            this.colNgayNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNgayNhan.Width = 127;
            // 
            // colNgayHT
            // 
            this.colNgayHT.Text = "Ngày hoàn thành";
            this.colNgayHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNgayHT.Width = 186;
            // 
            // dtpNgayHoanThanh
            // 
            this.dtpNgayHoanThanh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHoanThanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHoanThanh.Location = new System.Drawing.Point(182, 197);
            this.dtpNgayHoanThanh.Name = "dtpNgayHoanThanh";
            this.dtpNgayHoanThanh.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayHoanThanh.TabIndex = 32;
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhan.Location = new System.Drawing.Point(182, 138);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayNhan.TabIndex = 31;
            // 
            // lblNgayHoanThanh
            // 
            this.lblNgayHoanThanh.AutoSize = true;
            this.lblNgayHoanThanh.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHoanThanh.Location = new System.Drawing.Point(1, 198);
            this.lblNgayHoanThanh.Name = "lblNgayHoanThanh";
            this.lblNgayHoanThanh.Size = new System.Drawing.Size(182, 26);
            this.lblNgayHoanThanh.TabIndex = 30;
            this.lblNgayHoanThanh.Text = "Ngày hoàn thành";
            this.lblNgayHoanThanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortMaintanceID
            // 
            this.cboSortMaintanceID.DelimiterChar = "";
            this.cboSortMaintanceID.DisplayMember = "";
            this.cboSortMaintanceID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortMaintanceID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortMaintanceID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortMaintanceID.Location = new System.Drawing.Point(226, 75);
            this.cboSortMaintanceID.Name = "cboSortMaintanceID";
            this.cboSortMaintanceID.Size = new System.Drawing.Size(156, 33);
            this.cboSortMaintanceID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortMaintanceID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortMaintanceID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortMaintanceID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortMaintanceID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortMaintanceID.TabIndex = 29;
            // 
            // lblSortMaintanceID
            // 
            this.lblSortMaintanceID.AutoSize = true;
            this.lblSortMaintanceID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortMaintanceID.Location = new System.Drawing.Point(-3, 82);
            this.lblSortMaintanceID.Name = "lblSortMaintanceID";
            this.lblSortMaintanceID.Size = new System.Drawing.Size(228, 26);
            this.lblSortMaintanceID.TabIndex = 28;
            this.lblSortMaintanceID.Text = "Sort Housekeeping ID";
            this.lblSortMaintanceID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocNgayNhan
            // 
            this.lblLocNgayNhan.AutoSize = true;
            this.lblLocNgayNhan.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocNgayNhan.Location = new System.Drawing.Point(3, 139);
            this.lblLocNgayNhan.Name = "lblLocNgayNhan";
            this.lblLocNgayNhan.Size = new System.Drawing.Size(119, 26);
            this.lblLocNgayNhan.TabIndex = 14;
            this.lblLocNgayNhan.Text = "Ngày nhận";
            this.lblLocNgayNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateMaintance
            // 
            this.lblStateMaintance.AutoSize = true;
            this.lblStateMaintance.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateMaintance.Location = new System.Drawing.Point(-3, 264);
            this.lblStateMaintance.Name = "lblStateMaintance";
            this.lblStateMaintance.Size = new System.Drawing.Size(186, 26);
            this.lblStateMaintance.TabIndex = 9;
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
            this.spcHeader.Panel1.Controls.Add(this.lblMaintance);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // btnAddMaintance
            // 
            this.btnAddMaintance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddMaintance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddMaintance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMaintance.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMaintance.ForeColor = System.Drawing.Color.White;
            this.btnAddMaintance.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddMaintance.Location = new System.Drawing.Point(3, 3);
            this.btnAddMaintance.Name = "btnAddMaintance";
            this.btnAddMaintance.Size = new System.Drawing.Size(191, 41);
            this.btnAddMaintance.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddMaintance.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddMaintance.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddMaintance.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddMaintance.TabIndex = 1;
            this.btnAddMaintance.Text = "Thêm";
            this.btnAddMaintance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMaintance.UseVisualStyleBackColor = false;
            // 
            // btnEditMaintance
            // 
            this.btnEditMaintance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditMaintance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditMaintance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMaintance.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMaintance.ForeColor = System.Drawing.Color.White;
            this.btnEditMaintance.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditMaintance.Location = new System.Drawing.Point(3, 50);
            this.btnEditMaintance.Name = "btnEditMaintance";
            this.btnEditMaintance.Size = new System.Drawing.Size(191, 41);
            this.btnEditMaintance.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditMaintance.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditMaintance.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditMaintance.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditMaintance.TabIndex = 3;
            this.btnEditMaintance.Text = "Sửa";
            this.btnEditMaintance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditMaintance.UseVisualStyleBackColor = false;
            // 
            // btnDeleteMaintance
            // 
            this.btnDeleteMaintance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteMaintance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteMaintance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMaintance.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMaintance.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMaintance.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteMaintance.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteMaintance.Name = "btnDeleteMaintance";
            this.btnDeleteMaintance.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteMaintance.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteMaintance.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMaintance.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteMaintance.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteMaintance.TabIndex = 4;
            this.btnDeleteMaintance.Text = "Xóa";
            this.btnDeleteMaintance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteMaintance.UseVisualStyleBackColor = false;
            // 
            // btnRecoverMaintance
            // 
            this.btnRecoverMaintance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverMaintance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverMaintance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverMaintance.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverMaintance.ForeColor = System.Drawing.Color.White;
            this.btnRecoverMaintance.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverMaintance.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverMaintance.Name = "btnRecoverMaintance";
            this.btnRecoverMaintance.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverMaintance.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverMaintance.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverMaintance.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverMaintance.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverMaintance.TabIndex = 5;
            this.btnRecoverMaintance.Text = "Khôi phục";
            this.btnRecoverMaintance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverMaintance.UseVisualStyleBackColor = false;
            // 
            // ucMaintance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucMaintance";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucMaintance_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateMaintance)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboSortMaintanceID)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaintance;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuMaintance;
        private Syncfusion.WinForms.Controls.SfButton btnAddMaintance;
        private System.Windows.Forms.TextBox txtSearchMaintance;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteMaintance;
        private Syncfusion.WinForms.Controls.SfButton btnEditMaintance;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverMaintance;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateMaintance;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateMaintance;
        private System.Windows.Forms.ListView lvwMaintance;
        private System.Windows.Forms.ColumnHeader colMaDP;
        private System.Windows.Forms.ColumnHeader colPHG;
        private System.Windows.Forms.ColumnHeader colNV;
        private System.Windows.Forms.ColumnHeader colNgayNhan;
        private System.Windows.Forms.ColumnHeader colNgayHT;
        private System.Windows.Forms.Label lblLocNgayNhan;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortMaintanceID;
        private System.Windows.Forms.Label lblSortMaintanceID;
        private System.Windows.Forms.Label lblNgayHoanThanh;
        private System.Windows.Forms.DateTimePicker dtpNgayHoanThanh;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
    }
}
