namespace GUI.UserControls
{
    partial class ucTax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTax));
            this.lblTax = new System.Windows.Forms.Label();
            this.tlpController = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddTax = new Syncfusion.WinForms.Controls.SfButton();
            this.btnEditTax = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeleteTax = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRecoverTax = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearchTax = new System.Windows.Forms.TextBox();
            this.btnTraCuuTax = new Syncfusion.WinForms.Controls.SfButton();
            this.cboStateTax = new Syncfusion.WinForms.ListView.SfComboBox();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.lvwTax = new System.Windows.Forms.ListView();
            this.colMaTax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenTax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMucThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboSortTaxID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortTaxID = new System.Windows.Forms.Label();
            this.cboSortTaxValue = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortTaxValue = new System.Windows.Forms.Label();
            this.lblStateTax = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.tlpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStateTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortTaxID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortTaxValue)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.Color.Lavender;
            this.lblTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTax.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTax.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTax.Location = new System.Drawing.Point(0, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(972, 94);
            this.lblTax.TabIndex = 35;
            this.lblTax.Text = "TAX";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpController
            // 
            this.tlpController.ColumnCount = 2;
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpController.Controls.Add(this.btnAddTax, 0, 0);
            this.tlpController.Controls.Add(this.btnEditTax, 0, 1);
            this.tlpController.Controls.Add(this.btnDeleteTax, 1, 0);
            this.tlpController.Controls.Add(this.btnRecoverTax, 1, 1);
            this.tlpController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpController.Location = new System.Drawing.Point(0, 0);
            this.tlpController.Name = "tlpController";
            this.tlpController.RowCount = 2;
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpController.Size = new System.Drawing.Size(394, 94);
            this.tlpController.TabIndex = 6;
            // 
            // btnAddTax
            // 
            this.btnAddTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTax.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTax.ForeColor = System.Drawing.Color.White;
            this.btnAddTax.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddTax.Location = new System.Drawing.Point(3, 3);
            this.btnAddTax.Name = "btnAddTax";
            this.btnAddTax.Size = new System.Drawing.Size(191, 41);
            this.btnAddTax.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddTax.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddTax.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddTax.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAddTax.TabIndex = 1;
            this.btnAddTax.Text = "Thêm";
            this.btnAddTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTax.UseVisualStyleBackColor = false;
            // 
            // btnEditTax
            // 
            this.btnEditTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTax.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTax.ForeColor = System.Drawing.Color.White;
            this.btnEditTax.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditTax.Location = new System.Drawing.Point(3, 50);
            this.btnEditTax.Name = "btnEditTax";
            this.btnEditTax.Size = new System.Drawing.Size(191, 41);
            this.btnEditTax.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditTax.Style.ForeColor = System.Drawing.Color.White;
            this.btnEditTax.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnEditTax.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnEditTax.TabIndex = 3;
            this.btnEditTax.Text = "Sửa";
            this.btnEditTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditTax.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTax
            // 
            this.btnDeleteTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTax.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTax.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTax.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDeleteTax.Location = new System.Drawing.Point(200, 3);
            this.btnDeleteTax.Name = "btnDeleteTax";
            this.btnDeleteTax.Size = new System.Drawing.Size(191, 41);
            this.btnDeleteTax.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteTax.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTax.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDeleteTax.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDeleteTax.TabIndex = 4;
            this.btnDeleteTax.Text = "Xóa";
            this.btnDeleteTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteTax.UseVisualStyleBackColor = false;
            // 
            // btnRecoverTax
            // 
            this.btnRecoverTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecoverTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverTax.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverTax.ForeColor = System.Drawing.Color.White;
            this.btnRecoverTax.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecoverTax.Location = new System.Drawing.Point(200, 50);
            this.btnRecoverTax.Name = "btnRecoverTax";
            this.btnRecoverTax.Size = new System.Drawing.Size(191, 41);
            this.btnRecoverTax.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRecoverTax.Style.ForeColor = System.Drawing.Color.White;
            this.btnRecoverTax.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnRecoverTax.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRecoverTax.TabIndex = 5;
            this.btnRecoverTax.Text = "Khôi phục";
            this.btnRecoverTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverTax.UseVisualStyleBackColor = false;
            // 
            // txtSearchTax
            // 
            this.txtSearchTax.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTax.Location = new System.Drawing.Point(6, 16);
            this.txtSearchTax.Name = "txtSearchTax";
            this.txtSearchTax.Size = new System.Drawing.Size(251, 40);
            this.txtSearchTax.TabIndex = 2;
            // 
            // btnTraCuuTax
            // 
            this.btnTraCuuTax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuTax.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuTax.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuTax.Location = new System.Drawing.Point(264, 16);
            this.btnTraCuuTax.Name = "btnTraCuuTax";
            this.btnTraCuuTax.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuTax.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuTax.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuTax.TabIndex = 0;
            this.btnTraCuuTax.Text = "Tra cứu";
            this.btnTraCuuTax.UseVisualStyleBackColor = false;
            // 
            // cboStateTax
            // 
            this.cboStateTax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStateTax.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStateTax.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboStateTax.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateTax.Location = new System.Drawing.Point(226, 193);
            this.cboStateTax.Name = "cboStateTax";
            this.cboStateTax.Size = new System.Drawing.Size(156, 33);
            this.cboStateTax.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboStateTax.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateTax.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateTax.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStateTax.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateTax.TabIndex = 3;
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
            this.spcQuery.Panel1.Controls.Add(this.lvwTax);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortTaxID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortTaxID);
            this.spcQuery.Panel2.Controls.Add(this.cboSortTaxValue);
            this.spcQuery.Panel2.Controls.Add(this.lblSortTaxValue);
            this.spcQuery.Panel2.Controls.Add(this.lblStateTax);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchTax);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuTax);
            this.spcQuery.Panel2.Controls.Add(this.cboStateTax);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // lvwTax
            // 
            this.lvwTax.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaTax,
            this.colTenTax,
            this.colMucThue,
            this.colMoTa});
            this.lvwTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTax.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTax.FullRowSelect = true;
            this.lvwTax.GridLines = true;
            this.lvwTax.HideSelection = false;
            this.lvwTax.Location = new System.Drawing.Point(0, 0);
            this.lvwTax.MultiSelect = false;
            this.lvwTax.Name = "lvwTax";
            this.lvwTax.Size = new System.Drawing.Size(973, 746);
            this.lvwTax.TabIndex = 0;
            this.lvwTax.UseCompatibleStateImageBehavior = false;
            this.lvwTax.View = System.Windows.Forms.View.Details;
            // 
            // colMaTax
            // 
            this.colMaTax.Text = "Mã Tax";
            this.colMaTax.Width = 81;
            // 
            // colTenTax
            // 
            this.colTenTax.Text = "Tên thuế";
            this.colTenTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenTax.Width = 207;
            // 
            // colMucThue
            // 
            this.colMucThue.Text = "Mức thuế";
            this.colMucThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMucThue.Width = 179;
            // 
            // colMoTa
            // 
            this.colMoTa.Text = "Mô tả";
            this.colMoTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMoTa.Width = 146;
            // 
            // cboSortTaxID
            // 
            this.cboSortTaxID.DelimiterChar = "";
            this.cboSortTaxID.DisplayMember = "";
            this.cboSortTaxID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortTaxID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortTaxID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortTaxID.Location = new System.Drawing.Point(226, 79);
            this.cboSortTaxID.Name = "cboSortTaxID";
            this.cboSortTaxID.Size = new System.Drawing.Size(156, 33);
            this.cboSortTaxID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortTaxID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortTaxID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortTaxID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortTaxID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortTaxID.TabIndex = 29;
            // 
            // lblSortTaxID
            // 
            this.lblSortTaxID.AutoSize = true;
            this.lblSortTaxID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortTaxID.Location = new System.Drawing.Point(2, 86);
            this.lblSortTaxID.Name = "lblSortTaxID";
            this.lblSortTaxID.Size = new System.Drawing.Size(170, 26);
            this.lblSortTaxID.TabIndex = 28;
            this.lblSortTaxID.Text = "Sort theo ID loại";
            this.lblSortTaxID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSortTaxValue
            // 
            this.cboSortTaxValue.DelimiterChar = "";
            this.cboSortTaxValue.DisplayMember = "";
            this.cboSortTaxValue.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortTaxValue.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortTaxValue.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortTaxValue.Location = new System.Drawing.Point(227, 136);
            this.cboSortTaxValue.Name = "cboSortTaxValue";
            this.cboSortTaxValue.Size = new System.Drawing.Size(156, 33);
            this.cboSortTaxValue.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortTaxValue.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortTaxValue.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortTaxValue.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortTaxValue.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortTaxValue.TabIndex = 23;
            // 
            // lblSortTaxValue
            // 
            this.lblSortTaxValue.AutoSize = true;
            this.lblSortTaxValue.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortTaxValue.Location = new System.Drawing.Point(2, 143);
            this.lblSortTaxValue.Name = "lblSortTaxValue";
            this.lblSortTaxValue.Size = new System.Drawing.Size(185, 26);
            this.lblSortTaxValue.TabIndex = 14;
            this.lblSortTaxValue.Text = "Lọc theo số lượng";
            this.lblSortTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateTax
            // 
            this.lblStateTax.AutoSize = true;
            this.lblStateTax.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateTax.Location = new System.Drawing.Point(2, 200);
            this.lblStateTax.Name = "lblStateTax";
            this.lblStateTax.Size = new System.Drawing.Size(186, 26);
            this.lblStateTax.TabIndex = 9;
            this.lblStateTax.Text = "Trạng thái dữ liệu";
            this.lblStateTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblTax);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.tlpController);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // ucTax
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucTax";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucTax_Load);
            this.tlpController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboStateTax)).EndInit();
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboSortTaxID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortTaxValue)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTax;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuTax;
        private Syncfusion.WinForms.Controls.SfButton btnAddTax;
        private System.Windows.Forms.TextBox txtSearchTax;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteTax;
        private Syncfusion.WinForms.Controls.SfButton btnEditTax;
        private Syncfusion.WinForms.Controls.SfButton btnRecoverTax;
        private Syncfusion.WinForms.ListView.SfComboBox cboStateTax;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.TableLayoutPanel tlpController;
        private System.Windows.Forms.Label lblStateTax;
        private System.Windows.Forms.ListView lvwTax;
        private System.Windows.Forms.ColumnHeader colMaTax;
        private System.Windows.Forms.ColumnHeader colTenTax;
        private System.Windows.Forms.ColumnHeader colMucThue;
        private System.Windows.Forms.ColumnHeader colMoTa;
        private System.Windows.Forms.Label lblSortTaxValue;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortTaxValue;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortTaxID;
        private System.Windows.Forms.Label lblSortTaxID;
    }
}
