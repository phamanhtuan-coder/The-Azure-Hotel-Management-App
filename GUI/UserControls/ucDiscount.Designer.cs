namespace GUI.UserControls
{
    partial class ucDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDiscount));
            this.lblDiscount = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddDiscount = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditDiscount = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteDiscount = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverDiscount = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchDiscount = new System.Windows.Forms.TextBox();
            this.btnTraCuuDiscount = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateDiscount = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvDiscount = new System.Windows.Forms.DataGridView();
            this.lblLocTheoHangTV = new System.Windows.Forms.Label();
            this.cboLocHangTV = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboSortDiscountID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortDiscountID = new System.Windows.Forms.Label();
            this.cboSortDiscountValue = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortMucGiam = new System.Windows.Forms.Label();
            this.lblStateDiscount = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.colMaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMucKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHangTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLocHangTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortDiscountID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortDiscountValue)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.Lavender;
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiscount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDiscount.Location = new System.Drawing.Point(0, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(972, 94);
            this.lblDiscount.TabIndex = 35;
            this.lblDiscount.Text = "DISCOUNTS";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddDiscount, 0, 0);
            this.tlpController.Controls.Add(this.btnEditDiscount, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteDiscount, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverDiscount, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiscount.ForeColor = System.Drawing.Color.White;
            this.btnAddDiscount.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddDiscount.Location = new System.Drawing.Point(3, 3);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(191, 41);
            this.btnAddDiscount.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddDiscount.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddDiscount.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddDiscount.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddDiscount.TabIndex = 1;
            this.btnAddDiscount.Text = "Thêm";
            this.btnAddDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDiscount.UseVisualStyleBackColor = false;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnEditDiscount
            // 
            this.btnEditDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDiscount.ForeColor = System.Drawing.Color.White;
            this.btnEditDiscount.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditDiscount.Location = new System.Drawing.Point(3, 50);
            this.btnEditDiscount.Name = "btnEditDiscount";
            this.btnEditDiscount.Size = new System.Drawing.Size(191, 41);
            this.btnEditDiscount.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditDiscount.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditDiscount.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditDiscount.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditDiscount.TabIndex = 3;
            this.btnEditDiscount.Text = "Sửa";
            this.btnEditDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditDiscount.UseVisualStyleBackColor = false;
            this.btnEditDiscount.Click += new System.EventHandler(this.btnEditDiscount_Click);
            // 
            // btnDeleteDiscount
            // 
            this.btnDeleteDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDiscount.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteDiscount.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteDiscount.Name = "btnDeleteDiscount";
            this.btnDeleteDiscount.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteDiscount.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteDiscount.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDiscount.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteDiscount.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteDiscount.TabIndex = 4;
            this.btnDeleteDiscount.Text = "Xóa";
            this.btnDeleteDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteDiscount.UseVisualStyleBackColor = false;
            this.btnDeleteDiscount.Click += new System.EventHandler(this.btnDeleteDiscount_Click);
            // 
            // btnRecoverDiscount
            // 
            this.btnRecoverDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverDiscount.ForeColor = System.Drawing.Color.White;
            this.btnRecoverDiscount.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverDiscount.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverDiscount.Name = "btnRecoverDiscount";
            this.btnRecoverDiscount.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverDiscount.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverDiscount.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverDiscount.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverDiscount.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverDiscount.TabIndex = 5;
            this.btnRecoverDiscount.Text = "Khôi phục";
            this.btnRecoverDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverDiscount.UseVisualStyleBackColor = false;
            this.btnRecoverDiscount.Click += new System.EventHandler(this.btnRecoverDiscount_Click);
            // 
            // txtSearchDiscount
            // 
            this.txtSearchDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDiscount.Location = new System.Drawing.Point(6, 16);
            this.txtSearchDiscount.Name = "txtSearchDiscount";
            this.txtSearchDiscount.Size = new System.Drawing.Size(251, 38);
            this.txtSearchDiscount.TabIndex = 2;
            // 
            // btnTraCuuDiscount
            // 
            this.btnTraCuuDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuDiscount.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuDiscount.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuDiscount.Name = "btnTraCuuDiscount";
            this.btnTraCuuDiscount.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuDiscount.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuDiscount.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuDiscount.TabIndex = 0;
            this.btnTraCuuDiscount.Text = "Tra cứu";
            this.btnTraCuuDiscount.UseVisualStyleBackColor = false;
            this.btnTraCuuDiscount.Click += new System.EventHandler(this.btnTraCuuDiscount_Click);
            // 
            // cboStateDiscount
            // 
            this.cboStateDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateDiscount.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateDiscount.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateDiscount.Location = new System.Drawing.Point(226, 251);
            this.cboStateDiscount.Name = "cboStateDiscount";
            this.cboStateDiscount.Size = new System.Drawing.Size(156, 33);
            this.cboStateDiscount.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateDiscount.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateDiscount.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateDiscount.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateDiscount.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateDiscount.TabIndex = 3;
            this.cboStateDiscount.SelectedIndexChanged += new System.EventHandler(this.cboStateDiscount_SelectedIndexChanged);
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
            this.spcQuery.Panel1.Controls.Add(this.dgvDiscount);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.lblLocTheoHangTV);
            this.spcQuery.Panel2.Controls.Add(this.cboLocHangTV);
            this.spcQuery.Panel2.Controls.Add(this.cboSortDiscountID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortDiscountID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortDiscountValue);
            this.spcQuery.Panel2.Controls.Add(this.lblSortMucGiam);
            this.spcQuery.Panel2.Controls.Add(this.lblStateDiscount);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchDiscount);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuDiscount);
            this.spcQuery.Panel2.Controls.Add(this.cboStateDiscount);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.AllowUserToAddRows = false;
            this.dgvDiscount.AllowUserToDeleteRows = false;
            this.dgvDiscount.AllowUserToResizeColumns = false;
            this.dgvDiscount.AllowUserToResizeRows = false;
            this.dgvDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKM,
            this.colTenKM,
            this.colMucKhuyenMai,
            this.colHangTV,
            this.colTrangThai});
            this.dgvDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiscount.Location = new System.Drawing.Point(0, 0);
            this.dgvDiscount.MultiSelect = false;
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.ReadOnly = true;
            this.dgvDiscount.RowHeadersVisible = false;
            this.dgvDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscount.Size = new System.Drawing.Size(973, 746);
            this.dgvDiscount.TabIndex = 0;
            // 
            // lblLocTheoHangTV
            // 
            this.lblLocTheoHangTV.AutoSize = true;
            this.lblLocTheoHangTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocTheoHangTV.Location = new System.Drawing.Point(3, 199);
            this.lblLocTheoHangTV.Name = "lblLocTheoHangTV";
            this.lblLocTheoHangTV.Size = new System.Drawing.Size(177, 24);
            this.lblLocTheoHangTV.TabIndex = 31;
            this.lblLocTheoHangTV.Text = "Lọc theo hạng TV";
            this.lblLocTheoHangTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboLocHangTV
            // 
            this.cboLocHangTV.DelimiterChar = "";
            this.cboLocHangTV.DisplayMember = "";
            this.cboLocHangTV.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboLocHangTV.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboLocHangTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocHangTV.Location = new System.Drawing.Point(226, 192);
            this.cboLocHangTV.Name = "cboLocHangTV";
            this.cboLocHangTV.Size = new System.Drawing.Size(156, 33);
            this.cboLocHangTV.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboLocHangTV.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocHangTV.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocHangTV.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboLocHangTV.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocHangTV.TabIndex = 30;
            this.cboLocHangTV.SelectedIndexChanged += new System.EventHandler(this.cboLocHangTV_SelectedIndexChanged);
            // 
            // cboSortDiscountID
            // 
            this.cboSortDiscountID.DelimiterChar = "";
            this.cboSortDiscountID.DisplayMember = "";
            this.cboSortDiscountID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortDiscountID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortDiscountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDiscountID.Location = new System.Drawing.Point(226, 79);
            this.cboSortDiscountID.Name = "cboSortDiscountID";
            this.cboSortDiscountID.Size = new System.Drawing.Size(156, 33);
            this.cboSortDiscountID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortDiscountID.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDiscountID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDiscountID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortDiscountID.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDiscountID.TabIndex = 29;
            this.cboSortDiscountID.SelectedIndexChanged += new System.EventHandler(this.cboSortDiscountID_SelectedIndexChanged);
            // 
            // lblSortDiscountID
            // 
            this.lblSortDiscountID.AutoSize = true;
            this.lblSortDiscountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortDiscountID.Location = new System.Drawing.Point(2, 86);
            this.lblSortDiscountID.Name = "lblSortDiscountID";
            this.lblSortDiscountID.Size = new System.Drawing.Size(164, 24);
            this.lblSortDiscountID.TabIndex = 28;
            this.lblSortDiscountID.Text = "Sort theo mã KM";
            this.lblSortDiscountID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortDiscountValue
            // 
            this.cboSortDiscountValue.DelimiterChar = "";
            this.cboSortDiscountValue.DisplayMember = "";
            this.cboSortDiscountValue.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortDiscountValue.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortDiscountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDiscountValue.Location = new System.Drawing.Point(227, 136);
            this.cboSortDiscountValue.Name = "cboSortDiscountValue";
            this.cboSortDiscountValue.Size = new System.Drawing.Size(156, 33);
            this.cboSortDiscountValue.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortDiscountValue.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDiscountValue.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDiscountValue.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortDiscountValue.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortDiscountValue.TabIndex = 23;
            this.cboSortDiscountValue.SelectedIndexChanged += new System.EventHandler(this.cboSortDiscountValue_SelectedIndexChanged);
            // 
            // lblSortMucGiam
            // 
            this.lblSortMucGiam.AutoSize = true;
            this.lblSortMucGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortMucGiam.Location = new System.Drawing.Point(2, 143);
            this.lblSortMucGiam.Name = "lblSortMucGiam";
            this.lblSortMucGiam.Size = new System.Drawing.Size(188, 24);
            this.lblSortMucGiam.TabIndex = 14;
            this.lblSortMucGiam.Text = "Lọc theo mức giảm";
            this.lblSortMucGiam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateDiscount
            // 
            this.lblStateDiscount.AutoSize = true;
            this.lblStateDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateDiscount.Location = new System.Drawing.Point(2, 258);
            this.lblStateDiscount.Name = "lblStateDiscount";
            this.lblStateDiscount.Size = new System.Drawing.Size(174, 24);
            this.lblStateDiscount.TabIndex = 9;
            this.lblStateDiscount.Text = "Trạng thái dữ liệu";
            this.lblStateDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblDiscount);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // colMaKM
            // 
            this.colMaKM.DataPropertyName = "MaKM";
            this.colMaKM.HeaderText = "Mã khuyến mãi";
            this.colMaKM.Name = "colMaKM";
            this.colMaKM.ReadOnly = true;
            // 
            // colTenKM
            // 
            this.colTenKM.DataPropertyName = "TenKM";
            this.colTenKM.HeaderText = "Tên khuyến mãi";
            this.colTenKM.Name = "colTenKM";
            this.colTenKM.ReadOnly = true;
            // 
            // colMucKhuyenMai
            // 
            this.colMucKhuyenMai.DataPropertyName = "KhuyenMai";
            this.colMucKhuyenMai.HeaderText = "Mức khuyến mãi";
            this.colMucKhuyenMai.Name = "colMucKhuyenMai";
            this.colMucKhuyenMai.ReadOnly = true;
            // 
            // colHangTV
            // 
            this.colHangTV.DataPropertyName = "MaLoaiHangThanhVien";
            this.colHangTV.HeaderText = "Hạng thành viên";
            this.colHangTV.Name = "colHangTV";
            this.colHangTV.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Visible = false;
            // 
            // ucDiscount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucDiscount";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucDiscount_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateDiscount)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLocHangTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortDiscountID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortDiscountValue)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDiscount;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuDiscount;
        private Syncfusion.WinForms.Controls.SfButton btnAddDiscount;
        private System.Windows.Forms.TextBox txtSearchDiscount;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteDiscount;
        private Syncfusion.WinForms.Controls.SfButton btnEditDiscount;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverDiscount;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateDiscount;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateDiscount;
        private System.Windows.Forms.Label lblSortMucGiam;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortDiscountValue;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortDiscountID;
        private System.Windows.Forms.Label lblSortDiscountID;
        private System.Windows.Forms.DataGridView dgvDiscount;
        private System.Windows.Forms.Label lblLocTheoHangTV;
        private Syncfusion.WinForms.ListView.SfComboBox cboLocHangTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMucKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHangTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
