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
            this.lvwMaintentance = new System.Windows.Forms.ListView();
            this.colMaDP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPHG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayNhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayHT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpNgayHoanThanh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.lblNgayHoanThanh = new System.Windows.Forms.Label();
            this.cboSortMaintentanceD = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortMaintentanceID = new System.Windows.Forms.Label();
            this.lblLocNgayNhan = new System.Windows.Forms.Label();
            this.lblStateMaintance = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateMaintentance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
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
            this.lblMaintentance.TabIndex = 35;
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
            this.btnAddMaintentance.TabIndex = 1;
            this.btnAddMaintentance.Text = "Thêm";
            this.btnAddMaintentance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMaintentance.UseVisualStyleBackColor = false;
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
            this.btnEditMaintentance.TabIndex = 3;
            this.btnEditMaintentance.Text = "Sửa";
            this.btnEditMaintentance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditMaintentance.UseVisualStyleBackColor = false;
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
            this.btnDeleteMaintentance.TabIndex = 4;
            this.btnDeleteMaintentance.Text = "Xóa";
            this.btnDeleteMaintentance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteMaintentance.UseVisualStyleBackColor = false;
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
            this.btnRecoverMaintentance.UseVisualStyleBackColor = false;
            // 
            // txtSearchMaintentance
            // 
            this.txtSearchMaintentance.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMaintentance.Location = new System.Drawing.Point(6, 16);
            this.txtSearchMaintentance.Name = "txtSearchMaintentance";
            this.txtSearchMaintentance.Size = new System.Drawing.Size(251, 40);
            this.txtSearchMaintentance.TabIndex = 2;
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
            this.btnTraCuuMaintentance.TabIndex = 0;
            this.btnTraCuuMaintentance.Text = "Tra cứu";
            this.btnTraCuuMaintentance.UseVisualStyleBackColor = false;
            // 
            // cboStateMaintentance
            // 
            this.cboStateMaintentance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateMaintentance.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateMaintentance.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateMaintentance.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateMaintentance.Location = new System.Drawing.Point(221, 257);
            this.cboStateMaintentance.Name = "cboStateMaintentance";
            this.cboStateMaintentance.Size = new System.Drawing.Size(156, 33);
            this.cboStateMaintentance.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateMaintentance.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateMaintentance.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateMaintentance.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateMaintentance.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateMaintentance.TabIndex = 3;
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
            this.spcQuery.Panel1.Controls.Add(this.lvwMaintentance);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayHoanThanh);
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayNhan);
            this.spcQuery.Panel2.Controls.Add(this.lblNgayHoanThanh);
            this.spcQuery.Panel2.Controls.Add(this.cboSortMaintentanceD);
            this.spcQuery.Panel2.Controls.Add(this.lblSortMaintentanceID);
            this.spcQuery.Panel2.Controls.Add(this.lblLocNgayNhan);
            this.spcQuery.Panel2.Controls.Add(this.lblStateMaintance);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchMaintentance);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuMaintentance);
            this.spcQuery.Panel2.Controls.Add(this.cboStateMaintentance);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // lvwMaintentance
            // 
            this.lvwMaintentance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaDP,
            this.colPHG,
            this.colNV,
            this.colNgayNhan,
            this.colNgayHT});
            this.lvwMaintentance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMaintentance.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMaintentance.FullRowSelect = true;
            this.lvwMaintentance.GridLines = true;
            this.lvwMaintentance.HideSelection = false;
            this.lvwMaintentance.Location = new System.Drawing.Point(0, 0);
            this.lvwMaintentance.MultiSelect = false;
            this.lvwMaintentance.Name = "lvwMaintentance";
            this.lvwMaintentance.Size = new System.Drawing.Size(973, 746);
            this.lvwMaintentance.TabIndex = 0;
            this.lvwMaintentance.UseCompatibleStateImageBehavior = false;
            this.lvwMaintentance.View = System.Windows.Forms.View.Details;
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
            this.cboSortMaintentanceD.TabIndex = 29;
            // 
            // lblSortMaintentanceID
            // 
            this.lblSortMaintentanceID.AutoSize = true;
            this.lblSortMaintentanceID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortMaintentanceID.Location = new System.Drawing.Point(-3, 82);
            this.lblSortMaintentanceID.Name = "lblSortMaintentanceID";
            this.lblSortMaintentanceID.Size = new System.Drawing.Size(222, 26);
            this.lblSortMaintentanceID.TabIndex = 28;
            this.lblSortMaintentanceID.Text = "Sort Maintentance ID";
            this.lblSortMaintentanceID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblMaintentance);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.cboStateMaintentance)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
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
        private System.Windows.Forms.ListView lvwMaintentance;
        private System.Windows.Forms.ColumnHeader colMaDP;
        private System.Windows.Forms.ColumnHeader colPHG;
        private System.Windows.Forms.ColumnHeader colNV;
        private System.Windows.Forms.ColumnHeader colNgayNhan;
        private System.Windows.Forms.ColumnHeader colNgayHT;
        private System.Windows.Forms.Label lblLocNgayNhan;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortMaintentanceD;
        private System.Windows.Forms.Label lblSortMaintentanceID;
        private System.Windows.Forms.Label lblNgayHoanThanh;
        private System.Windows.Forms.DateTimePicker dtpNgayHoanThanh;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
    }
}
