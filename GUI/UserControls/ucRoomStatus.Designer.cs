namespace GUI.UserControls
{
    partial class ucRoomStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRoomStatus));
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRoomStatus = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditRoomStatus = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteRoomStatus = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverRoomStatus = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchRoomStatus = new System.Windows.Forms.TextBox();
            this.btnTraCuuRoomStatus = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateRoomStatus = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.lvwRoomStatus = new System.Windows.Forms.ListView();
            this.colMaRoomStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuongPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboSortRoomStatusID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortRoomStatusID = new System.Windows.Forms.Label();
            this.cboSortSoLuongRoom = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortSoLuongRoom = new System.Windows.Forms.Label();
            this.lblStateRoomStatus = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRoomStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomStatusID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuongRoom)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.BackColor = System.Drawing.Color.Lavender;
            this.lblRoomStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomStatus.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRoomStatus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRoomStatus.Location = new System.Drawing.Point(0, 0);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(972, 94);
            this.lblRoomStatus.TabIndex = 35;
            this.lblRoomStatus.Text = "ROOM STATUS";
            this.lblRoomStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddRoomStatus, 0, 0);
            this.tlpController.Controls.Add(this.btnEditRoomStatus, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteRoomStatus, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverRoomStatus, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddRoomStatus
            // 
            this.btnAddRoomStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRoomStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRoomStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoomStatus.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoomStatus.ForeColor = System.Drawing.Color.White;
            this.btnAddRoomStatus.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddRoomStatus.Location = new System.Drawing.Point(3, 3);
            this.btnAddRoomStatus.Name = "btnAddRoomStatus";
            this.btnAddRoomStatus.Size = new System.Drawing.Size(191, 41);
            this.btnAddRoomStatus.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRoomStatus.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddRoomStatus.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddRoomStatus.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddRoomStatus.TabIndex = 1;
            this.btnAddRoomStatus.Text = "Thêm";
            this.btnAddRoomStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRoomStatus.UseVisualStyleBackColor = false;
            // 
            // btnEditRoomStatus
            // 
            this.btnEditRoomStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditRoomStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditRoomStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRoomStatus.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRoomStatus.ForeColor = System.Drawing.Color.White;
            this.btnEditRoomStatus.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditRoomStatus.Location = new System.Drawing.Point(3, 50);
            this.btnEditRoomStatus.Name = "btnEditRoomStatus";
            this.btnEditRoomStatus.Size = new System.Drawing.Size(191, 41);
            this.btnEditRoomStatus.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditRoomStatus.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditRoomStatus.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditRoomStatus.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditRoomStatus.TabIndex = 3;
            this.btnEditRoomStatus.Text = "Sửa";
            this.btnEditRoomStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditRoomStatus.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRoomStatus
            // 
            this.btnDeleteRoomStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRoomStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteRoomStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoomStatus.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoomStatus.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoomStatus.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteRoomStatus.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteRoomStatus.Name = "btnDeleteRoomStatus";
            this.btnDeleteRoomStatus.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteRoomStatus.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRoomStatus.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoomStatus.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteRoomStatus.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteRoomStatus.TabIndex = 4;
            this.btnDeleteRoomStatus.Text = "Xóa";
            this.btnDeleteRoomStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteRoomStatus.UseVisualStyleBackColor = false;
            // 
            // btnRecoverRoomStatus
            // 
            this.btnRecoverRoomStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverRoomStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverRoomStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverRoomStatus.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverRoomStatus.ForeColor = System.Drawing.Color.White;
            this.btnRecoverRoomStatus.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverRoomStatus.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverRoomStatus.Name = "btnRecoverRoomStatus";
            this.btnRecoverRoomStatus.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverRoomStatus.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverRoomStatus.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverRoomStatus.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverRoomStatus.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverRoomStatus.TabIndex = 5;
            this.btnRecoverRoomStatus.Text = "Khôi phục";
            this.btnRecoverRoomStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverRoomStatus.UseVisualStyleBackColor = false;
            // 
            // txtSearchRoomStatus
            // 
            this.txtSearchRoomStatus.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoomStatus.Location = new System.Drawing.Point(6, 16);
            this.txtSearchRoomStatus.Name = "txtSearchRoomStatus";
            this.txtSearchRoomStatus.Size = new System.Drawing.Size(251, 40);
            this.txtSearchRoomStatus.TabIndex = 2;
            // 
            // btnTraCuuRoomStatus
            // 
            this.btnTraCuuRoomStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuRoomStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRoomStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuRoomStatus.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuRoomStatus.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRoomStatus.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuRoomStatus.Name = "btnTraCuuRoomStatus";
            this.btnTraCuuRoomStatus.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuRoomStatus.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRoomStatus.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRoomStatus.TabIndex = 0;
            this.btnTraCuuRoomStatus.Text = "Tra cứu";
            this.btnTraCuuRoomStatus.UseVisualStyleBackColor = false;
            // 
            // cboStateRoomStatus
            // 
            this.cboStateRoomStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateRoomStatus.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateRoomStatus.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateRoomStatus.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoomStatus.Location = new System.Drawing.Point(226, 193);
            this.cboStateRoomStatus.Name = "cboStateRoomStatus";
            this.cboStateRoomStatus.Size = new System.Drawing.Size(156, 33);
            this.cboStateRoomStatus.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateRoomStatus.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoomStatus.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoomStatus.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateRoomStatus.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateRoomStatus.TabIndex = 3;
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
            this.spcQuery.Panel1.Controls.Add(this.lvwRoomStatus);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortRoomStatusID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortRoomStatusID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortSoLuongRoom);
            this.spcQuery.Panel2.Controls.Add(this.lblSortSoLuongRoom);
            this.spcQuery.Panel2.Controls.Add(this.lblStateRoomStatus);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchRoomStatus);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuRoomStatus);
            this.spcQuery.Panel2.Controls.Add(this.cboStateRoomStatus);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // lvwRoomStatus
            // 
            this.lvwRoomStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaRoomStatus,
            this.colTenStatus,
            this.colSoLuongPhong,
            this.colMoTa});
            this.lvwRoomStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwRoomStatus.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwRoomStatus.FullRowSelect = true;
            this.lvwRoomStatus.GridLines = true;
            this.lvwRoomStatus.HideSelection = false;
            this.lvwRoomStatus.Location = new System.Drawing.Point(0, 0);
            this.lvwRoomStatus.MultiSelect = false;
            this.lvwRoomStatus.Name = "lvwRoomStatus";
            this.lvwRoomStatus.Size = new System.Drawing.Size(973, 746);
            this.lvwRoomStatus.TabIndex = 0;
            this.lvwRoomStatus.UseCompatibleStateImageBehavior = false;
            this.lvwRoomStatus.View = System.Windows.Forms.View.Details;
            // 
            // colMaRoomStatus
            // 
            this.colMaRoomStatus.Text = "Mã Trạng thái phòng";
            this.colMaRoomStatus.Width = 168;
            // 
            // colTenStatus
            // 
            this.colTenStatus.Text = "Tên trạng thái phòng";
            this.colTenStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenStatus.Width = 207;
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
            // cboSortRoomStatusID
            // 
            this.cboSortRoomStatusID.DelimiterChar = "";
            this.cboSortRoomStatusID.DisplayMember = "";
            this.cboSortRoomStatusID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortRoomStatusID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortRoomStatusID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomStatusID.Location = new System.Drawing.Point(226, 79);
            this.cboSortRoomStatusID.Name = "cboSortRoomStatusID";
            this.cboSortRoomStatusID.Size = new System.Drawing.Size(156, 33);
            this.cboSortRoomStatusID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortRoomStatusID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomStatusID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomStatusID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortRoomStatusID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortRoomStatusID.TabIndex = 29;
            // 
            // lblSortRoomStatusID
            // 
            this.lblSortRoomStatusID.AutoSize = true;
            this.lblSortRoomStatusID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortRoomStatusID.Location = new System.Drawing.Point(2, 86);
            this.lblSortRoomStatusID.Name = "lblSortRoomStatusID";
            this.lblSortRoomStatusID.Size = new System.Drawing.Size(170, 26);
            this.lblSortRoomStatusID.TabIndex = 28;
            this.lblSortRoomStatusID.Text = "Sort theo ID loại";
            this.lblSortRoomStatusID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lblSortSoLuongRoom.Size = new System.Drawing.Size(185, 26);
            this.lblSortSoLuongRoom.TabIndex = 14;
            this.lblSortSoLuongRoom.Text = "Lọc theo số lượng";
            this.lblSortSoLuongRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateRoomStatus
            // 
            this.lblStateRoomStatus.AutoSize = true;
            this.lblStateRoomStatus.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateRoomStatus.Location = new System.Drawing.Point(2, 200);
            this.lblStateRoomStatus.Name = "lblStateRoomStatus";
            this.lblStateRoomStatus.Size = new System.Drawing.Size(186, 26);
            this.lblStateRoomStatus.TabIndex = 9;
            this.lblStateRoomStatus.Text = "Trạng thái dữ liệu";
            this.lblStateRoomStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblRoomStatus);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucRoomStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucRoomStatus";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucRoomStatus_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateRoomStatus)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboSortRoomStatusID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSoLuongRoom)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRoomStatus;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuRoomStatus;
        private Syncfusion.WinForms.Controls.SfButton btnAddRoomStatus;
        private System.Windows.Forms.TextBox txtSearchRoomStatus;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteRoomStatus;
        private Syncfusion.WinForms.Controls.SfButton btnEditRoomStatus;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverRoomStatus;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateRoomStatus;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateRoomStatus;
        private System.Windows.Forms.ListView lvwRoomStatus;
        private System.Windows.Forms.ColumnHeader colMaRoomStatus;
        private System.Windows.Forms.ColumnHeader colTenStatus;
        private System.Windows.Forms.ColumnHeader colSoLuongPhong;
        private System.Windows.Forms.ColumnHeader colMoTa;
        private System.Windows.Forms.Label lblSortSoLuongRoom;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortSoLuongRoom;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortRoomStatusID;
        private System.Windows.Forms.Label lblSortRoomStatusID;
    }
}
