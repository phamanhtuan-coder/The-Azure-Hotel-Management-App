namespace GUI.UserControls
{
    partial class ucBillDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBillDetails));
            this.lblBillDetails = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddBillDetails = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditBillDetails = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteBillDetails = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverBillDetails = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchBillDetails = new System.Windows.Forms.TextBox();
            this.btnTraCuuBillDetails = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateBooking = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            this.cboSortSumBill = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboSortBillID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortSumBill = new System.Windows.Forms.Label();
            this.lblSortBillID = new System.Windows.Forms.Label();
            this.lblStateBooking = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.colMaCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSumBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBillID)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBillDetails
            // 
            this.lblBillDetails.BackColor = System.Drawing.Color.Lavender;
            this.lblBillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBillDetails.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBillDetails.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBillDetails.Location = new System.Drawing.Point(0, 0);
            this.lblBillDetails.Name = "lblBillDetails";
            this.lblBillDetails.Size = new System.Drawing.Size(972, 94);
            this.lblBillDetails.TabIndex = 35;
            this.lblBillDetails.Text = "BILL\'S DETAILS";
            this.lblBillDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddBillDetails, 0, 0);
            this.tlpController.Controls.Add(this.btnEditBillDetails, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteBillDetails, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverBillDetails, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddBillDetails
            // 
            this.btnAddBillDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddBillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddBillDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBillDetails.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBillDetails.ForeColor = System.Drawing.Color.White;
            this.btnAddBillDetails.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddBillDetails.Location = new System.Drawing.Point(3, 3);
            this.btnAddBillDetails.Name = "btnAddBillDetails";
            this.btnAddBillDetails.Size = new System.Drawing.Size(191, 41);
            this.btnAddBillDetails.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddBillDetails.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddBillDetails.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddBillDetails.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddBillDetails.TabIndex = 1;
            this.btnAddBillDetails.Text = "Thêm";
            this.btnAddBillDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBillDetails.UseVisualStyleBackColor = false;
            this.btnAddBillDetails.Click += new System.EventHandler(this.btnAddBillDetails_Click);
            // 
            // btnEditBillDetails
            // 
            this.btnEditBillDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditBillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditBillDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBillDetails.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBillDetails.ForeColor = System.Drawing.Color.White;
            this.btnEditBillDetails.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditBillDetails.Location = new System.Drawing.Point(3, 50);
            this.btnEditBillDetails.Name = "btnEditBillDetails";
            this.btnEditBillDetails.Size = new System.Drawing.Size(191, 41);
            this.btnEditBillDetails.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditBillDetails.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditBillDetails.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditBillDetails.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditBillDetails.TabIndex = 3;
            this.btnEditBillDetails.Text = "Sửa";
            this.btnEditBillDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditBillDetails.UseVisualStyleBackColor = false;
            this.btnEditBillDetails.Click += new System.EventHandler(this.btnEditBillDetails_Click);
            // 
            // btnDeleteBillDetails
            // 
            this.btnDeleteBillDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteBillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteBillDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBillDetails.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBillDetails.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBillDetails.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteBillDetails.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteBillDetails.Name = "btnDeleteBillDetails";
            this.btnDeleteBillDetails.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteBillDetails.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteBillDetails.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBillDetails.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteBillDetails.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteBillDetails.TabIndex = 4;
            this.btnDeleteBillDetails.Text = "Xóa";
            this.btnDeleteBillDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteBillDetails.UseVisualStyleBackColor = false;
            this.btnDeleteBillDetails.Click += new System.EventHandler(this.btnDeleteBillDetails_Click);
            // 
            // btnRecoverBillDetails
            // 
            this.btnRecoverBillDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverBillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverBillDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverBillDetails.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverBillDetails.ForeColor = System.Drawing.Color.White;
            this.btnRecoverBillDetails.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverBillDetails.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverBillDetails.Name = "btnRecoverBillDetails";
            this.btnRecoverBillDetails.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverBillDetails.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverBillDetails.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverBillDetails.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverBillDetails.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverBillDetails.TabIndex = 5;
            this.btnRecoverBillDetails.Text = "Khôi phục";
            this.btnRecoverBillDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverBillDetails.UseVisualStyleBackColor = false;
            this.btnRecoverBillDetails.Click += new System.EventHandler(this.btnRecoverBillDetails_Click);
            // 
            // txtSearchBillDetails
            // 
            this.txtSearchBillDetails.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBillDetails.Location = new System.Drawing.Point(6, 16);
            this.txtSearchBillDetails.Name = "txtSearchBillDetails";
            this.txtSearchBillDetails.Size = new System.Drawing.Size(251, 40);
            this.txtSearchBillDetails.TabIndex = 2;
            // 
            // btnTraCuuBillDetails
            // 
            this.btnTraCuuBillDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuBillDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuBillDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuBillDetails.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuBillDetails.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuBillDetails.Location = new System.Drawing.Point(263, 16);
            this.btnTraCuuBillDetails.Name = "btnTraCuuBillDetails";
            this.btnTraCuuBillDetails.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuBillDetails.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuBillDetails.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuBillDetails.TabIndex = 0;
            this.btnTraCuuBillDetails.Text = "Tra cứu";
            this.btnTraCuuBillDetails.UseVisualStyleBackColor = false;
            this.btnTraCuuBillDetails.Click += new System.EventHandler(this.btnTraCuuBillDetails_Click);
            // 
            // cboStateBooking
            // 
            this.cboStateBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateBooking.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateBooking.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateBooking.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Location = new System.Drawing.Point(234, 178);
            this.cboStateBooking.Name = "cboStateBooking";
            this.cboStateBooking.Size = new System.Drawing.Size(156, 33);
            this.cboStateBooking.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateBooking.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateBooking.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateBooking.TabIndex = 3;
            this.cboStateBooking.SelectedIndexChanged += new System.EventHandler(this.cboStateBooking_SelectedIndexChanged);
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
            this.spcQuery.Panel1.Controls.Add(this.dgvBillDetails);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortSumBill);
            this.spcQuery.Panel2.Controls.Add(this.cboSortBillID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortSumBill);
            this.spcQuery.Panel2.Controls.Add(this.lblSortBillID);
            this.spcQuery.Panel2.Controls.Add(this.lblStateBooking);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchBillDetails);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuBillDetails);
            this.spcQuery.Panel2.Controls.Add(this.cboStateBooking);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvBillDetails
            // 
            this.dgvBillDetails.AllowUserToAddRows = false;
            this.dgvBillDetails.AllowUserToDeleteRows = false;
            this.dgvBillDetails.AllowUserToResizeColumns = false;
            this.dgvBillDetails.AllowUserToResizeRows = false;
            this.dgvBillDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaCTHD,
            this.colMaHD,
            this.colMaDP,
            this.colMaKM,
            this.colThanhTien,
            this.colTrangThai});
            this.dgvBillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvBillDetails.MultiSelect = false;
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.ReadOnly = true;
            this.dgvBillDetails.RowHeadersVisible = false;
            this.dgvBillDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillDetails.Size = new System.Drawing.Size(973, 746);
            this.dgvBillDetails.TabIndex = 0;
            // 
            // cboSortSumBill
            // 
            this.cboSortSumBill.DelimiterChar = "";
            this.cboSortSumBill.DisplayMember = "";
            this.cboSortSumBill.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortSumBill.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortSumBill.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSumBill.Location = new System.Drawing.Point(234, 127);
            this.cboSortSumBill.Name = "cboSortSumBill";
            this.cboSortSumBill.Size = new System.Drawing.Size(156, 33);
            this.cboSortSumBill.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortSumBill.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSumBill.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSumBill.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortSumBill.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSumBill.TabIndex = 24;
            this.cboSortSumBill.SelectedIndexChanged += new System.EventHandler(this.cboSortSumBill_SelectedIndexChanged);
            // 
            // cboSortBillID
            // 
            this.cboSortBillID.DelimiterChar = "";
            this.cboSortBillID.DisplayMember = "";
            this.cboSortBillID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortBillID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortBillID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBillID.Location = new System.Drawing.Point(234, 78);
            this.cboSortBillID.Name = "cboSortBillID";
            this.cboSortBillID.Size = new System.Drawing.Size(156, 33);
            this.cboSortBillID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortBillID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBillID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBillID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortBillID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBillID.TabIndex = 23;
            this.cboSortBillID.SelectedIndexChanged += new System.EventHandler(this.cboSortBillID_SelectedIndexChanged);
            // 
            // lblSortSumBill
            // 
            this.lblSortSumBill.AutoSize = true;
            this.lblSortSumBill.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortSumBill.Location = new System.Drawing.Point(13, 134);
            this.lblSortSumBill.Name = "lblSortSumBill";
            this.lblSortSumBill.Size = new System.Drawing.Size(197, 26);
            this.lblSortSumBill.TabIndex = 16;
            this.lblSortSumBill.Text = "Sort theo tổng tiền";
            this.lblSortSumBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSortBillID
            // 
            this.lblSortBillID.AutoSize = true;
            this.lblSortBillID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBillID.Location = new System.Drawing.Point(13, 78);
            this.lblSortBillID.Name = "lblSortBillID";
            this.lblSortBillID.Size = new System.Drawing.Size(167, 26);
            this.lblSortBillID.TabIndex = 14;
            this.lblSortBillID.Text = "Sort theo Bill ID";
            this.lblSortBillID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateBooking
            // 
            this.lblStateBooking.AutoSize = true;
            this.lblStateBooking.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateBooking.Location = new System.Drawing.Point(13, 185);
            this.lblStateBooking.Name = "lblStateBooking";
            this.lblStateBooking.Size = new System.Drawing.Size(186, 26);
            this.lblStateBooking.TabIndex = 9;
            this.lblStateBooking.Text = "Trạng thái dữ liệu";
            this.lblStateBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblBillDetails);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // colMaCTHD
            // 
            this.colMaCTHD.DataPropertyName = "MaCTHD";
            this.colMaCTHD.HeaderText = "Mã CTHD";
            this.colMaCTHD.Name = "colMaCTHD";
            this.colMaCTHD.ReadOnly = true;
            this.colMaCTHD.Width = 110;
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHD";
            this.colMaHD.HeaderText = "Mã hóa đơn";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.ReadOnly = true;
            this.colMaHD.Width = 129;
            // 
            // colMaDP
            // 
            this.colMaDP.DataPropertyName = "MaDatPhong";
            this.colMaDP.HeaderText = "Mã đặt phòng";
            this.colMaDP.Name = "colMaDP";
            this.colMaDP.ReadOnly = true;
            this.colMaDP.Width = 147;
            // 
            // colMaKM
            // 
            this.colMaKM.DataPropertyName = "MaKhuyenMai";
            this.colMaKM.HeaderText = "Mã khuyến mãi";
            this.colMaKM.Name = "colMaKM";
            this.colMaKM.ReadOnly = true;
            this.colMaKM.Width = 145;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 111;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Visible = false;
            this.colTrangThai.Width = 105;
            // 
            // ucBillDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucBillDetails";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucBillDetails_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateBooking)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSumBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBillID)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBillDetails;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuBillDetails;
        private Syncfusion.WinForms.Controls.SfButton btnAddBillDetails;
        private System.Windows.Forms.TextBox txtSearchBillDetails;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteBillDetails;
        private Syncfusion.WinForms.Controls.SfButton btnEditBillDetails;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverBillDetails;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateBooking;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateBooking;
        private System.Windows.Forms.Label lblSortSumBill;
        private System.Windows.Forms.Label lblSortBillID;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortSumBill;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortBillID;
        private System.Windows.Forms.DataGridView dgvBillDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
