namespace GUI.UserControls
{
    partial class ucAccountType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAccountType));
            this.lblAccountType = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddAccountType = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditAccountType = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteAccountType = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverAccountType = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchAccountType = new System.Windows.Forms.TextBox();
            this.btnTraCuuAccountType = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateAccountType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.lvwAccountType = new System.Windows.Forms.ListView();
            this.colMaPhanQuyen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVaiTro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhongBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuongTaiKhoan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboChucVu = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortTheoChucVu = new System.Windows.Forms.Label();
            this.cboSortAccountTypeID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortAccountTypeID = new System.Windows.Forms.Label();
            this.cboSortSoLuongAccount = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortSoLuongAccount = new System.Windows.Forms.Label();
            this.lblStateAccountType = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortAccountTypeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuongAccount)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccountType
            // 
            this.lblAccountType.BackColor = System.Drawing.Color.Lavender;
            this.lblAccountType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountType.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAccountType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAccountType.Location = new System.Drawing.Point(0, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(972, 94);
            this.lblAccountType.TabIndex = 35;
            this.lblAccountType.Text = "ACCOUNT TYPE";
            this.lblAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddAccountType, 0, 0);
            this.tlpController.Controls.Add(this.btnEditAccountType, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteAccountType, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverAccountType, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddAccountType
            // 
            this.btnAddAccountType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddAccountType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccountType.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccountType.ForeColor = System.Drawing.Color.White;
            this.btnAddAccountType.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddAccountType.Location = new System.Drawing.Point(3, 3);
            this.btnAddAccountType.Name = "btnAddAccountType";
            this.btnAddAccountType.Size = new System.Drawing.Size(191, 41);
            this.btnAddAccountType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddAccountType.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddAccountType.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddAccountType.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddAccountType.TabIndex = 1;
            this.btnAddAccountType.Text = "Thêm";
            this.btnAddAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAccountType.UseVisualStyleBackColor = false;
            // 
            // btnEditAccountType
            // 
            this.btnEditAccountType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditAccountType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAccountType.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccountType.ForeColor = System.Drawing.Color.White;
            this.btnEditAccountType.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditAccountType.Location = new System.Drawing.Point(3, 50);
            this.btnEditAccountType.Name = "btnEditAccountType";
            this.btnEditAccountType.Size = new System.Drawing.Size(191, 41);
            this.btnEditAccountType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditAccountType.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditAccountType.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditAccountType.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditAccountType.TabIndex = 3;
            this.btnEditAccountType.Text = "Sửa";
            this.btnEditAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditAccountType.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAccountType
            // 
            this.btnDeleteAccountType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteAccountType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccountType.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccountType.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccountType.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteAccountType.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteAccountType.Name = "btnDeleteAccountType";
            this.btnDeleteAccountType.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteAccountType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteAccountType.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccountType.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteAccountType.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteAccountType.TabIndex = 4;
            this.btnDeleteAccountType.Text = "Xóa";
            this.btnDeleteAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAccountType.UseVisualStyleBackColor = false;
            // 
            // btnRecoverAccountType
            // 
            this.btnRecoverAccountType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverAccountType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverAccountType.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverAccountType.ForeColor = System.Drawing.Color.White;
            this.btnRecoverAccountType.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverAccountType.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverAccountType.Name = "btnRecoverAccountType";
            this.btnRecoverAccountType.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverAccountType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverAccountType.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverAccountType.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverAccountType.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverAccountType.TabIndex = 5;
            this.btnRecoverAccountType.Text = "Khôi phục";
            this.btnRecoverAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverAccountType.UseVisualStyleBackColor = false;
            // 
            // txtSearchAccountType
            // 
            this.txtSearchAccountType.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccountType.Location = new System.Drawing.Point(6, 16);
            this.txtSearchAccountType.Name = "txtSearchAccountType";
            this.txtSearchAccountType.Size = new System.Drawing.Size(251, 40);
            this.txtSearchAccountType.TabIndex = 2;
            // 
            // btnTraCuuAccountType
            // 
            this.btnTraCuuAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuAccountType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuAccountType.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuAccountType.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuAccountType.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuAccountType.Name = "btnTraCuuAccountType";
            this.btnTraCuuAccountType.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuAccountType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuAccountType.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuAccountType.TabIndex = 0;
            this.btnTraCuuAccountType.Text = "Tra cứu";
            this.btnTraCuuAccountType.UseVisualStyleBackColor = false;
            // 
            // cboStateAccountType
            // 
            this.cboStateAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateAccountType.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateAccountType.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateAccountType.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccountType.Location = new System.Drawing.Point(226, 243);
            this.cboStateAccountType.Name = "cboStateAccountType";
            this.cboStateAccountType.Size = new System.Drawing.Size(156, 33);
            this.cboStateAccountType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateAccountType.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccountType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccountType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateAccountType.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateAccountType.TabIndex = 3;
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
            this.spcQuery.Panel1.Controls.Add(this.lvwAccountType);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboChucVu);
            this.spcQuery.Panel2.Controls.Add(this.lblSortTheoChucVu);
            this.spcQuery.Panel2.Controls.Add(this.cboSortAccountTypeID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortAccountTypeID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortSoLuongAccount);
            this.spcQuery.Panel2.Controls.Add(this.lblSortSoLuongAccount);
            this.spcQuery.Panel2.Controls.Add(this.lblStateAccountType);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchAccountType);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuAccountType);
            this.spcQuery.Panel2.Controls.Add(this.cboStateAccountType);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // lvwAccountType
            // 
            this.lvwAccountType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhanQuyen,
            this.colVaiTro,
            this.colPhongBan,
            this.colMoTa,
            this.colSoLuongTaiKhoan});
            this.lvwAccountType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAccountType.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAccountType.FullRowSelect = true;
            this.lvwAccountType.GridLines = true;
            this.lvwAccountType.HideSelection = false;
            this.lvwAccountType.Location = new System.Drawing.Point(0, 0);
            this.lvwAccountType.MultiSelect = false;
            this.lvwAccountType.Name = "lvwAccountType";
            this.lvwAccountType.Size = new System.Drawing.Size(973, 746);
            this.lvwAccountType.TabIndex = 0;
            this.lvwAccountType.UseCompatibleStateImageBehavior = false;
            this.lvwAccountType.View = System.Windows.Forms.View.Details;
            // 
            // colMaPhanQuyen
            // 
            this.colMaPhanQuyen.Text = "Mã phân quyền";
            this.colMaPhanQuyen.Width = 81;
            // 
            // colVaiTro
            // 
            this.colVaiTro.Text = "Vai trò";
            this.colVaiTro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colVaiTro.Width = 207;
            // 
            // colPhongBan
            // 
            this.colPhongBan.Text = "Phòng ban";
            this.colPhongBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPhongBan.Width = 179;
            // 
            // colMoTa
            // 
            this.colMoTa.Text = "Mô tả";
            this.colMoTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMoTa.Width = 146;
            // 
            // colSoLuongTaiKhoan
            // 
            this.colSoLuongTaiKhoan.Text = "Số lượng tài khoản";
            // 
            // cboChucVu
            // 
            this.cboChucVu.DelimiterChar = "";
            this.cboChucVu.DisplayMember = "";
            this.cboChucVu.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboChucVu.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboChucVu.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucVu.Location = new System.Drawing.Point(226, 133);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(156, 33);
            this.cboChucVu.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboChucVu.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucVu.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucVu.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboChucVu.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucVu.TabIndex = 31;
            // 
            // lblSortTheoChucVu
            // 
            this.lblSortTheoChucVu.AutoSize = true;
            this.lblSortTheoChucVu.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortTheoChucVu.Location = new System.Drawing.Point(3, 140);
            this.lblSortTheoChucVu.Name = "lblSortTheoChucVu";
            this.lblSortTheoChucVu.Size = new System.Drawing.Size(184, 26);
            this.lblSortTheoChucVu.TabIndex = 30;
            this.lblSortTheoChucVu.Text = "Sort theo chức vụ";
            this.lblSortTheoChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortAccountTypeID
            // 
            this.cboSortAccountTypeID.DelimiterChar = "";
            this.cboSortAccountTypeID.DisplayMember = "";
            this.cboSortAccountTypeID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortAccountTypeID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortAccountTypeID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortAccountTypeID.Location = new System.Drawing.Point(226, 78);
            this.cboSortAccountTypeID.Name = "cboSortAccountTypeID";
            this.cboSortAccountTypeID.Size = new System.Drawing.Size(156, 33);
            this.cboSortAccountTypeID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortAccountTypeID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortAccountTypeID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortAccountTypeID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortAccountTypeID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortAccountTypeID.TabIndex = 29;
            // 
            // lblSortAccountTypeID
            // 
            this.lblSortAccountTypeID.AutoSize = true;
            this.lblSortAccountTypeID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortAccountTypeID.Location = new System.Drawing.Point(3, 85);
            this.lblSortAccountTypeID.Name = "lblSortAccountTypeID";
            this.lblSortAccountTypeID.Size = new System.Drawing.Size(170, 26);
            this.lblSortAccountTypeID.TabIndex = 28;
            this.lblSortAccountTypeID.Text = "Sort theo ID loại";
            this.lblSortAccountTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortSoLuongAccount
            // 
            this.cboSortSoLuongAccount.DelimiterChar = "";
            this.cboSortSoLuongAccount.DisplayMember = "";
            this.cboSortSoLuongAccount.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortSoLuongAccount.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortSoLuongAccount.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongAccount.Location = new System.Drawing.Point(226, 188);
            this.cboSortSoLuongAccount.Name = "cboSortSoLuongAccount";
            this.cboSortSoLuongAccount.Size = new System.Drawing.Size(156, 33);
            this.cboSortSoLuongAccount.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortSoLuongAccount.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongAccount.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongAccount.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortSoLuongAccount.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongAccount.TabIndex = 23;
            // 
            // lblSortSoLuongAccount
            // 
            this.lblSortSoLuongAccount.AutoSize = true;
            this.lblSortSoLuongAccount.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortSoLuongAccount.Location = new System.Drawing.Point(3, 195);
            this.lblSortSoLuongAccount.Name = "lblSortSoLuongAccount";
            this.lblSortSoLuongAccount.Size = new System.Drawing.Size(191, 26);
            this.lblSortSoLuongAccount.TabIndex = 14;
            this.lblSortSoLuongAccount.Text = "Sort theo số lượng";
            this.lblSortSoLuongAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateAccountType
            // 
            this.lblStateAccountType.AutoSize = true;
            this.lblStateAccountType.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateAccountType.Location = new System.Drawing.Point(3, 250);
            this.lblStateAccountType.Name = "lblStateAccountType";
            this.lblStateAccountType.Size = new System.Drawing.Size(186, 26);
            this.lblStateAccountType.TabIndex = 9;
            this.lblStateAccountType.Text = "Trạng thái dữ liệu";
            this.lblStateAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblAccountType);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucAccountType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucAccountType";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucAccountType_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateAccountType)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortAccountTypeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuongAccount)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAccountType;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuAccountType;
        private Syncfusion.WinForms.Controls.SfButton btnAddAccountType;
        private System.Windows.Forms.TextBox txtSearchAccountType;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteAccountType;
        private Syncfusion.WinForms.Controls.SfButton btnEditAccountType;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverAccountType;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateAccountType;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateAccountType;
        private System.Windows.Forms.ListView lvwAccountType;
        private System.Windows.Forms.ColumnHeader colMaPhanQuyen;
        private System.Windows.Forms.ColumnHeader colVaiTro;
        private System.Windows.Forms.ColumnHeader colPhongBan;
        private System.Windows.Forms.ColumnHeader colMoTa;
        private System.Windows.Forms.Label lblSortSoLuongAccount;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortSoLuongAccount;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortAccountTypeID;
        private System.Windows.Forms.Label lblSortAccountTypeID;
        private System.Windows.Forms.ColumnHeader colSoLuongTaiKhoan;
        private Syncfusion.WinForms.ListView.SfComboBox cboChucVu;
        private System.Windows.Forms.Label lblSortTheoChucVu;
    }
}
