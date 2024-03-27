namespace GUI.UserControls
{
    partial class ucRoomType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRoomType));
            this.lblRoomType = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRoomType = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditRoomType = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteRoomType = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverRoomType = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchRoomType = new System.Windows.Forms.TextBox();
            this.btnTraCuuRoomType = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateRoomType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.lvwRoomType = new System.Windows.Forms.ListView();
            this.colMaRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuongPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboSortRoomTypeID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortRoomTypeID = new System.Windows.Forms.Label();
            this.cboSortSoLuongRoom = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortSoLuongRoom = new System.Windows.Forms.Label();
            this.lblStateRoomType = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomTypeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuongRoom)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRoomType
            // 
            this.lblRoomType.BackColor = System.Drawing.Color.Lavender;
            this.lblRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomType.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRoomType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRoomType.Location = new System.Drawing.Point(0, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(972, 94);
            this.lblRoomType.TabIndex = 35;
            this.lblRoomType.Text = "ROOM TYPE";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddRoomType, 0, 0);
            this.tlpController.Controls.Add(this.btnEditRoomType, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteRoomType, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverRoomType, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddRoomType
            // 
            this.btnAddRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoomType.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoomType.ForeColor = System.Drawing.Color.White;
            this.btnAddRoomType.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddRoomType.Location = new System.Drawing.Point(3, 3);
            this.btnAddRoomType.Name = "btnAddRoomType";
            this.btnAddRoomType.Size = new System.Drawing.Size(191, 41);
            this.btnAddRoomType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRoomType.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddRoomType.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddRoomType.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddRoomType.TabIndex = 1;
            this.btnAddRoomType.Text = "Thêm";
            this.btnAddRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRoomType.UseVisualStyleBackColor = false;
            // 
            // btnEditRoomType
            // 
            this.btnEditRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRoomType.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRoomType.ForeColor = System.Drawing.Color.White;
            this.btnEditRoomType.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditRoomType.Location = new System.Drawing.Point(3, 50);
            this.btnEditRoomType.Name = "btnEditRoomType";
            this.btnEditRoomType.Size = new System.Drawing.Size(191, 41);
            this.btnEditRoomType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditRoomType.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditRoomType.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditRoomType.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditRoomType.TabIndex = 3;
            this.btnEditRoomType.Text = "Sửa";
            this.btnEditRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditRoomType.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRoomType
            // 
            this.btnDeleteRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoomType.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoomType.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoomType.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteRoomType.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteRoomType.Name = "btnDeleteRoomType";
            this.btnDeleteRoomType.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteRoomType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRoomType.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoomType.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteRoomType.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteRoomType.TabIndex = 4;
            this.btnDeleteRoomType.Text = "Xóa";
            this.btnDeleteRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteRoomType.UseVisualStyleBackColor = false;
            // 
            // btnRecoverRoomType
            // 
            this.btnRecoverRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverRoomType.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverRoomType.ForeColor = System.Drawing.Color.White;
            this.btnRecoverRoomType.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverRoomType.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverRoomType.Name = "btnRecoverRoomType";
            this.btnRecoverRoomType.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverRoomType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverRoomType.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverRoomType.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverRoomType.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverRoomType.TabIndex = 5;
            this.btnRecoverRoomType.Text = "Khôi phục";
            this.btnRecoverRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverRoomType.UseVisualStyleBackColor = false;
            // 
            // txtSearchRoomType
            // 
            this.txtSearchRoomType.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoomType.Location = new System.Drawing.Point(6, 16);
            this.txtSearchRoomType.Name = "txtSearchRoomType";
            this.txtSearchRoomType.Size = new System.Drawing.Size(251, 40);
            this.txtSearchRoomType.TabIndex = 2;
            // 
            // btnTraCuuRoomType
            // 
            this.btnTraCuuRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuRoomType.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuRoomType.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRoomType.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuRoomType.Name = "btnTraCuuRoomType";
            this.btnTraCuuRoomType.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuRoomType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRoomType.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRoomType.TabIndex = 0;
            this.btnTraCuuRoomType.Text = "Tra cứu";
            this.btnTraCuuRoomType.UseVisualStyleBackColor = false;
            // 
            // cboStateRoomType
            // 
            this.cboStateRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateRoomType.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateRoomType.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateRoomType.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoomType.Location = new System.Drawing.Point(226, 193);
            this.cboStateRoomType.Name = "cboStateRoomType";
            this.cboStateRoomType.Size = new System.Drawing.Size(156, 33);
            this.cboStateRoomType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateRoomType.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoomType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoomType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateRoomType.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoomType.TabIndex = 3;
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
            this.spcQuery.Panel1.Controls.Add(this.lvwRoomType);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortRoomTypeID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortRoomTypeID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortSoLuongRoom);
            this.spcQuery.Panel2.Controls.Add(this.lblSortSoLuongRoom);
            this.spcQuery.Panel2.Controls.Add(this.lblStateRoomType);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchRoomType);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuRoomType);
            this.spcQuery.Panel2.Controls.Add(this.cboStateRoomType);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // lvwRoomType
            // 
            this.lvwRoomType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaRoomType,
            this.colLoaiPhong,
            this.colSoLuongPhong,
            this.colMoTa});
            this.lvwRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwRoomType.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwRoomType.FullRowSelect = true;
            this.lvwRoomType.GridLines = true;
            this.lvwRoomType.HideSelection = false;
            this.lvwRoomType.Location = new System.Drawing.Point(0, 0);
            this.lvwRoomType.MultiSelect = false;
            this.lvwRoomType.Name = "lvwRoomType";
            this.lvwRoomType.Size = new System.Drawing.Size(973, 746);
            this.lvwRoomType.TabIndex = 0;
            this.lvwRoomType.UseCompatibleStateImageBehavior = false;
            this.lvwRoomType.View = System.Windows.Forms.View.Details;
            // 
            // colMaRoomType
            // 
            this.colMaRoomType.Text = "Mã Loại Phòng";
            this.colMaRoomType.Width = 81;
            // 
            // colLoaiPhong
            // 
            this.colLoaiPhong.Text = "Loại Phòng";
            this.colLoaiPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLoaiPhong.Width = 207;
            // 
            // colSoLuongPhong
            // 
            this.colSoLuongPhong.Text = "Số lượng phòng";
            this.colSoLuongPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoLuongPhong.Width = 179;
            // 
            // colMoTa
            // 
            this.colMoTa.Text = "Mô tả";
            this.colMoTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMoTa.Width = 146;
            // 
            // cboSortRoomTypeID
            // 
            this.cboSortRoomTypeID.DelimiterChar = "";
            this.cboSortRoomTypeID.DisplayMember = "";
            this.cboSortRoomTypeID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortRoomTypeID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortRoomTypeID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomTypeID.Location = new System.Drawing.Point(226, 79);
            this.cboSortRoomTypeID.Name = "cboSortRoomTypeID";
            this.cboSortRoomTypeID.Size = new System.Drawing.Size(156, 33);
            this.cboSortRoomTypeID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortRoomTypeID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomTypeID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomTypeID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortRoomTypeID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomTypeID.TabIndex = 29;
            // 
            // lblSortRoomTypeID
            // 
            this.lblSortRoomTypeID.AutoSize = true;
            this.lblSortRoomTypeID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortRoomTypeID.Location = new System.Drawing.Point(2, 86);
            this.lblSortRoomTypeID.Name = "lblSortRoomTypeID";
            this.lblSortRoomTypeID.Size = new System.Drawing.Size(170, 26);
            this.lblSortRoomTypeID.TabIndex = 28;
            this.lblSortRoomTypeID.Text = "Sort theo ID loại";
            this.lblSortRoomTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortSoLuongRoom
            // 
            this.cboSortSoLuongRoom.DelimiterChar = "";
            this.cboSortSoLuongRoom.DisplayMember = "";
            this.cboSortSoLuongRoom.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortSoLuongRoom.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortSoLuongRoom.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongRoom.Location = new System.Drawing.Point(227, 136);
            this.cboSortSoLuongRoom.Name = "cboSortSoLuongRoom";
            this.cboSortSoLuongRoom.Size = new System.Drawing.Size(156, 33);
            this.cboSortSoLuongRoom.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortSoLuongRoom.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongRoom.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongRoom.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortSoLuongRoom.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSoLuongRoom.TabIndex = 23;
            // 
            // lblSortSoLuongRoom
            // 
            this.lblSortSoLuongRoom.AutoSize = true;
            this.lblSortSoLuongRoom.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortSoLuongRoom.Location = new System.Drawing.Point(2, 143);
            this.lblSortSoLuongRoom.Name = "lblSortSoLuongRoom";
            this.lblSortSoLuongRoom.Size = new System.Drawing.Size(191, 26);
            this.lblSortSoLuongRoom.TabIndex = 14;
            this.lblSortSoLuongRoom.Text = "Sort theo số lượng";
            this.lblSortSoLuongRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateRoomType
            // 
            this.lblStateRoomType.AutoSize = true;
            this.lblStateRoomType.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateRoomType.Location = new System.Drawing.Point(2, 200);
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
            this.spcHeader.Panel1.Controls.Add(this.lblRoomType);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucRoomType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucRoomType";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucRoomType_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRoomType)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomTypeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuongRoom)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRoomType;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuRoomType;
        private Syncfusion.WinForms.Controls.SfButton btnAddRoomType;
        private System.Windows.Forms.TextBox txtSearchRoomType;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteRoomType;
        private Syncfusion.WinForms.Controls.SfButton btnEditRoomType;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverRoomType;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateRoomType;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateRoomType;
        private System.Windows.Forms.ListView lvwRoomType;
        private System.Windows.Forms.ColumnHeader colMaRoomType;
        private System.Windows.Forms.ColumnHeader colLoaiPhong;
        private System.Windows.Forms.ColumnHeader colSoLuongPhong;
        private System.Windows.Forms.ColumnHeader colMoTa;
        private System.Windows.Forms.Label lblSortSoLuongRoom;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortSoLuongRoom;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortRoomTypeID;
        private System.Windows.Forms.Label lblSortRoomTypeID;
    }
}
