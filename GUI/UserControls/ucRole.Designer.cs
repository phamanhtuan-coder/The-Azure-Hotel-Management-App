namespace GUI.UserControls
{
    partial class ucRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRole));
            this.lblRole = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRole = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditRole = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteRole = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverRole = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchRole = new System.Windows.Forms.TextBox();
            this.btnTraCuuRole = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateRole = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.lvwRole = new System.Windows.Forms.ListView();
            this.colMaRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboSortRole = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortServiceTypeID = new System.Windows.Forms.Label();
            this.cboSortSoLuong = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortSoLuongRole = new System.Windows.Forms.Label();
            this.lblStateRole = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuong)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Lavender;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRole.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRole.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRole.Location = new System.Drawing.Point(0, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(972, 94);
            this.lblRole.TabIndex = 35;
            this.lblRole.Text = "ROLE";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddRole, 0, 0);
            this.tlpController.Controls.Add(this.btnEditRole, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteRole, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverRole, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.ForeColor = System.Drawing.Color.White;
            this.btnAddRole.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddRole.Location = new System.Drawing.Point(3, 3);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(191, 41);
            this.btnAddRole.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRole.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddRole.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddRole.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddRole.TabIndex = 1;
            this.btnAddRole.Text = "Thêm";
            this.btnAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRole.UseVisualStyleBackColor = false;
            // 
            // btnEditRole
            // 
            this.btnEditRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRole.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRole.ForeColor = System.Drawing.Color.White;
            this.btnEditRole.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditRole.Location = new System.Drawing.Point(3, 50);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(191, 41);
            this.btnEditRole.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditRole.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditRole.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditRole.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditRole.TabIndex = 3;
            this.btnEditRole.Text = "Sửa";
            this.btnEditRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditRole.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRole.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRole.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRole.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteRole.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteRole.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRole.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRole.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteRole.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteRole.TabIndex = 4;
            this.btnDeleteRole.Text = "Xóa";
            this.btnDeleteRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteRole.UseVisualStyleBackColor = false;
            // 
            // btnRecoverRole
            // 
            this.btnRecoverRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverRole.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverRole.ForeColor = System.Drawing.Color.White;
            this.btnRecoverRole.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverRole.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverRole.Name = "btnRecoverRole";
            this.btnRecoverRole.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverRole.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverRole.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverRole.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverRole.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverRole.TabIndex = 5;
            this.btnRecoverRole.Text = "Khôi phục";
            this.btnRecoverRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverRole.UseVisualStyleBackColor = false;
            // 
            // txtSearchRole
            // 
            this.txtSearchRole.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRole.Location = new System.Drawing.Point(6, 16);
            this.txtSearchRole.Name = "txtSearchRole";
            this.txtSearchRole.Size = new System.Drawing.Size(251, 40);
            this.txtSearchRole.TabIndex = 2;
            // 
            // btnTraCuuRole
            // 
            this.btnTraCuuRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuRole.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuRole.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRole.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuRole.Name = "btnTraCuuRole";
            this.btnTraCuuRole.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuRole.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRole.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRole.TabIndex = 0;
            this.btnTraCuuRole.Text = "Tra cứu";
            this.btnTraCuuRole.UseVisualStyleBackColor = false;
            // 
            // cboStateRole
            // 
            this.cboStateRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateRole.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateRole.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateRole.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRole.Location = new System.Drawing.Point(226, 185);
            this.cboStateRole.Name = "cboStateRole";
            this.cboStateRole.Size = new System.Drawing.Size(156, 33);
            this.cboStateRole.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateRole.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRole.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRole.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateRole.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRole.TabIndex = 3;
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
            this.spcQuery.Panel1.Controls.Add(this.lvwRole);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortRole);
            this.spcQuery.Panel2.Controls.Add(this.lblSortServiceTypeID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortSoLuong);
            this.spcQuery.Panel2.Controls.Add(this.lblSortSoLuongRole);
            this.spcQuery.Panel2.Controls.Add(this.lblStateRole);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchRole);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuRole);
            this.spcQuery.Panel2.Controls.Add(this.cboStateRole);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // lvwRole
            // 
            this.lvwRole.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaRole,
            this.colTenRole,
            this.colSoLuong,
            this.colMoTa});
            this.lvwRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwRole.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwRole.FullRowSelect = true;
            this.lvwRole.GridLines = true;
            this.lvwRole.HideSelection = false;
            this.lvwRole.Location = new System.Drawing.Point(0, 0);
            this.lvwRole.MultiSelect = false;
            this.lvwRole.Name = "lvwRole";
            this.lvwRole.Size = new System.Drawing.Size(973, 746);
            this.lvwRole.TabIndex = 0;
            this.lvwRole.UseCompatibleStateImageBehavior = false;
            this.lvwRole.View = System.Windows.Forms.View.Details;
            // 
            // colMaRole
            // 
            this.colMaRole.Text = "Mã vai trò";
            this.colMaRole.Width = 81;
            // 
            // colTenRole
            // 
            this.colTenRole.Text = "Tên vai trò";
            this.colTenRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenRole.Width = 207;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng tài khoản theo role";
            this.colSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoLuong.Width = 179;
            // 
            // colMoTa
            // 
            this.colMoTa.Text = "Mô tả";
            this.colMoTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMoTa.Width = 146;
            // 
            // cboSortRole
            // 
            this.cboSortRole.DelimiterChar = "";
            this.cboSortRole.DisplayMember = "";
            this.cboSortRole.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortRole.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortRole.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRole.Location = new System.Drawing.Point(226, 77);
            this.cboSortRole.Name = "cboSortRole";
            this.cboSortRole.Size = new System.Drawing.Size(156, 33);
            this.cboSortRole.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortRole.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRole.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRole.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortRole.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRole.TabIndex = 29;
            // 
            // lblSortServiceTypeID
            // 
            this.lblSortServiceTypeID.AutoSize = true;
            this.lblSortServiceTypeID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortServiceTypeID.Location = new System.Drawing.Point(3, 84);
            this.lblSortServiceTypeID.Name = "lblSortServiceTypeID";
            this.lblSortServiceTypeID.Size = new System.Drawing.Size(178, 26);
            this.lblSortServiceTypeID.TabIndex = 28;
            this.lblSortServiceTypeID.Text = "Sort theo Role ID";
            this.lblSortServiceTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortSoLuong
            // 
            this.cboSortSoLuong.DelimiterChar = "";
            this.cboSortSoLuong.DisplayMember = "";
            this.cboSortSoLuong.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortSoLuong.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortSoLuong.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuong.Location = new System.Drawing.Point(227, 131);
            this.cboSortSoLuong.Name = "cboSortSoLuong";
            this.cboSortSoLuong.Size = new System.Drawing.Size(156, 33);
            this.cboSortSoLuong.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortSoLuong.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuong.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuong.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortSoLuong.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuong.TabIndex = 23;
            // 
            // lblSortSoLuongRole
            // 
            this.lblSortSoLuongRole.AutoSize = true;
            this.lblSortSoLuongRole.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortSoLuongRole.Location = new System.Drawing.Point(3, 138);
            this.lblSortSoLuongRole.Name = "lblSortSoLuongRole";
            this.lblSortSoLuongRole.Size = new System.Drawing.Size(191, 26);
            this.lblSortSoLuongRole.TabIndex = 14;
            this.lblSortSoLuongRole.Text = "Sort theo số lượng";
            this.lblSortSoLuongRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateRole
            // 
            this.lblStateRole.AutoSize = true;
            this.lblStateRole.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateRole.Location = new System.Drawing.Point(3, 192);
            this.lblStateRole.Name = "lblStateRole";
            this.lblStateRole.Size = new System.Drawing.Size(186, 26);
            this.lblStateRole.TabIndex = 9;
            this.lblStateRole.Text = "Trạng thái dữ liệu";
            this.lblStateRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblRole);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucRole
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucRole";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucRole_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRole)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuong)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRole;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuRole;
        private Syncfusion.WinForms.Controls.SfButton btnAddRole;
        private System.Windows.Forms.TextBox txtSearchRole;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteRole;
        private Syncfusion.WinForms.Controls.SfButton btnEditRole;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverRole;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateRole;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateRole;
        private System.Windows.Forms.ListView lvwRole;
        private System.Windows.Forms.ColumnHeader colMaRole;
        private System.Windows.Forms.ColumnHeader colTenRole;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colMoTa;
        private System.Windows.Forms.Label lblSortSoLuongRole;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortSoLuong;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortRole;
        private System.Windows.Forms.Label lblSortServiceTypeID;
    }
}
