namespace GUI.UserControls
{
    partial class ucAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAccounts));
            this.lblAccounts = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddAccounts = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditAccounts = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteAccounts = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverAccounts = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchAccounts = new System.Windows.Forms.TextBox();
            this.btnTraCuuAccounts = new Syncfusion.WinForms.Controls.SfButton();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.lvwAccounts = new System.Windows.Forms.ListView();
            this.colMaAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaPQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.cboPhanQuyen = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortTheoPhanQuyen = new System.Windows.Forms.Label();
            this.cboSortAccountsID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortAccountsID = new System.Windows.Forms.Label();
            this.cboStateAccounts = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblStateAccounts = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortAccountsID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateAccounts)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccounts
            // 
            this.lblAccounts.BackColor = System.Drawing.Color.Lavender;
            this.lblAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccounts.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAccounts.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAccounts.Location = new System.Drawing.Point(0, 0);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(972, 94);
            this.lblAccounts.TabIndex = 35;
            this.lblAccounts.Text = "ACCOUNTS LIST";
            this.lblAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddAccounts, 0, 0);
            this.tlpController.Controls.Add(this.btnEditAccounts, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteAccounts, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverAccounts, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddAccounts
            // 
            this.btnAddAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccounts.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccounts.ForeColor = System.Drawing.Color.White;
            this.btnAddAccounts.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddAccounts.Location = new System.Drawing.Point(3, 3);
            this.btnAddAccounts.Name = "btnAddAccounts";
            this.btnAddAccounts.Size = new System.Drawing.Size(191, 41);
            this.btnAddAccounts.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddAccounts.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddAccounts.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddAccounts.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddAccounts.TabIndex = 1;
            this.btnAddAccounts.Text = "Thêm";
            this.btnAddAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAccounts.UseVisualStyleBackColor = false;
            // 
            // btnEditAccounts
            // 
            this.btnEditAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAccounts.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccounts.ForeColor = System.Drawing.Color.White;
            this.btnEditAccounts.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditAccounts.Location = new System.Drawing.Point(3, 50);
            this.btnEditAccounts.Name = "btnEditAccounts";
            this.btnEditAccounts.Size = new System.Drawing.Size(191, 41);
            this.btnEditAccounts.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditAccounts.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditAccounts.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditAccounts.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditAccounts.TabIndex = 3;
            this.btnEditAccounts.Text = "Sửa";
            this.btnEditAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditAccounts.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAccounts
            // 
            this.btnDeleteAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccounts.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccounts.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccounts.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteAccounts.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteAccounts.Name = "btnDeleteAccounts";
            this.btnDeleteAccounts.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteAccounts.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteAccounts.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccounts.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteAccounts.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteAccounts.TabIndex = 4;
            this.btnDeleteAccounts.Text = "Xóa";
            this.btnDeleteAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAccounts.UseVisualStyleBackColor = false;
            // 
            // btnRecoverAccounts
            // 
            this.btnRecoverAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverAccounts.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverAccounts.ForeColor = System.Drawing.Color.White;
            this.btnRecoverAccounts.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverAccounts.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverAccounts.Name = "btnRecoverAccounts";
            this.btnRecoverAccounts.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverAccounts.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverAccounts.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverAccounts.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverAccounts.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverAccounts.TabIndex = 5;
            this.btnRecoverAccounts.Text = "Khôi phục";
            this.btnRecoverAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverAccounts.UseVisualStyleBackColor = false;
            // 
            // txtSearchAccounts
            // 
            this.txtSearchAccounts.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccounts.Location = new System.Drawing.Point(6, 16);
            this.txtSearchAccounts.Name = "txtSearchAccounts";
            this.txtSearchAccounts.Size = new System.Drawing.Size(251, 40);
            this.txtSearchAccounts.TabIndex = 2;
            // 
            // btnTraCuuAccounts
            // 
            this.btnTraCuuAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuAccounts.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuAccounts.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuAccounts.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuAccounts.Name = "btnTraCuuAccounts";
            this.btnTraCuuAccounts.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuAccounts.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuAccounts.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuAccounts.TabIndex = 0;
            this.btnTraCuuAccounts.Text = "Tra cứu";
            this.btnTraCuuAccounts.UseVisualStyleBackColor = false;
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
            this.spcQuery.Panel1.Controls.Add(this.lvwAccounts);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.dtpNgayTao);
            this.spcQuery.Panel2.Controls.Add(this.cboPhanQuyen);
            this.spcQuery.Panel2.Controls.Add(this.lblSortTheoPhanQuyen);
            this.spcQuery.Panel2.Controls.Add(this.cboSortAccountsID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortAccountsID);
            this.spcQuery.Panel2.Controls.Add(this.cboStateAccounts);
            this.spcQuery.Panel2.Controls.Add(this.lblNgayTao);
            this.spcQuery.Panel2.Controls.Add(this.lblStateAccounts);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchAccounts);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuAccounts);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // lvwAccounts
            // 
            this.lvwAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaAccount,
            this.colUsername,
            this.colMaPQ});
            this.lvwAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAccounts.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAccounts.FullRowSelect = true;
            this.lvwAccounts.GridLines = true;
            this.lvwAccounts.HideSelection = false;
            this.lvwAccounts.Location = new System.Drawing.Point(0, 0);
            this.lvwAccounts.MultiSelect = false;
            this.lvwAccounts.Name = "lvwAccounts";
            this.lvwAccounts.Size = new System.Drawing.Size(973, 746);
            this.lvwAccounts.TabIndex = 0;
            this.lvwAccounts.UseCompatibleStateImageBehavior = false;
            this.lvwAccounts.View = System.Windows.Forms.View.Details;
            // 
            // colMaAccount
            // 
            this.colMaAccount.Text = "Mã tài khoản";
            this.colMaAccount.Width = 81;
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            this.colUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colUsername.Width = 207;
            // 
            // colMaPQ
            // 
            this.colMaPQ.Text = "Mã Phân Quyền";
            this.colMaPQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMaPQ.Width = 179;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTao.Location = new System.Drawing.Point(182, 194);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayTao.TabIndex = 32;
            // 
            // cboPhanQuyen
            // 
            this.cboPhanQuyen.DelimiterChar = "";
            this.cboPhanQuyen.DisplayMember = "";
            this.cboPhanQuyen.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboPhanQuyen.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboPhanQuyen.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanQuyen.Location = new System.Drawing.Point(226, 133);
            this.cboPhanQuyen.Name = "cboPhanQuyen";
            this.cboPhanQuyen.Size = new System.Drawing.Size(156, 33);
            this.cboPhanQuyen.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboPhanQuyen.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanQuyen.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanQuyen.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboPhanQuyen.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanQuyen.TabIndex = 31;
            // 
            // lblSortTheoPhanQuyen
            // 
            this.lblSortTheoPhanQuyen.AutoSize = true;
            this.lblSortTheoPhanQuyen.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortTheoPhanQuyen.Location = new System.Drawing.Point(3, 140);
            this.lblSortTheoPhanQuyen.Name = "lblSortTheoPhanQuyen";
            this.lblSortTheoPhanQuyen.Size = new System.Drawing.Size(219, 26);
            this.lblSortTheoPhanQuyen.TabIndex = 30;
            this.lblSortTheoPhanQuyen.Text = "Lọc theo phân quyền";
            this.lblSortTheoPhanQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortAccountsID
            // 
            this.cboSortAccountsID.DelimiterChar = "";
            this.cboSortAccountsID.DisplayMember = "";
            this.cboSortAccountsID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortAccountsID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortAccountsID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortAccountsID.Location = new System.Drawing.Point(226, 78);
            this.cboSortAccountsID.Name = "cboSortAccountsID";
            this.cboSortAccountsID.Size = new System.Drawing.Size(156, 33);
            this.cboSortAccountsID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortAccountsID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortAccountsID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortAccountsID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortAccountsID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortAccountsID.TabIndex = 29;
            // 
            // lblSortAccountsID
            // 
            this.lblSortAccountsID.AutoSize = true;
            this.lblSortAccountsID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortAccountsID.Location = new System.Drawing.Point(3, 85);
            this.lblSortAccountsID.Name = "lblSortAccountsID";
            this.lblSortAccountsID.Size = new System.Drawing.Size(217, 26);
            this.lblSortAccountsID.TabIndex = 28;
            this.lblSortAccountsID.Text = "Sort theo ID Account";
            this.lblSortAccountsID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStateAccounts
            // 
            this.cboStateAccounts.DelimiterChar = "";
            this.cboStateAccounts.DisplayMember = "";
            this.cboStateAccounts.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateAccounts.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateAccounts.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccounts.Location = new System.Drawing.Point(226, 243);
            this.cboStateAccounts.Name = "cboStateAccounts";
            this.cboStateAccounts.Size = new System.Drawing.Size(156, 33);
            this.cboStateAccounts.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateAccounts.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccounts.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccounts.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateAccounts.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccounts.TabIndex = 23;
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTao.Location = new System.Drawing.Point(3, 195);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(100, 26);
            this.lblNgayTao.TabIndex = 14;
            this.lblNgayTao.Text = "Ngày tạo";
            this.lblNgayTao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateAccounts
            // 
            this.lblStateAccounts.AutoSize = true;
            this.lblStateAccounts.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateAccounts.Location = new System.Drawing.Point(3, 250);
            this.lblStateAccounts.Name = "lblStateAccounts";
            this.lblStateAccounts.Size = new System.Drawing.Size(186, 26);
            this.lblStateAccounts.TabIndex = 9;
            this.lblStateAccounts.Text = "Trạng thái dữ liệu";
            this.lblStateAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblAccounts);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucAccounts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucAccounts";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucAccounts_Load);
            this.tlpController.ResumeLayout(false);
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortAccountsID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateAccounts)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAccounts;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuAccounts;
        private Syncfusion.WinForms.Controls.SfButton btnAddAccounts;
        private System.Windows.Forms.TextBox txtSearchAccounts;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteAccounts;
        private Syncfusion.WinForms.Controls.SfButton btnEditAccounts;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverAccounts;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateAccounts;
        private System.Windows.Forms.ListView lvwAccounts;
        private System.Windows.Forms.ColumnHeader colMaAccount;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colMaPQ;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateAccounts;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortAccountsID;
        private System.Windows.Forms.Label lblSortAccountsID;
        private Syncfusion.WinForms.ListView.SfComboBox cboPhanQuyen;
        private System.Windows.Forms.Label lblSortTheoPhanQuyen;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.Label lblNgayTao;
    }
}
