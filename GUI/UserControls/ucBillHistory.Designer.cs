namespace GUI.UserControls
{
    partial class ucBillHistory
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
            this.components = new System.ComponentModel.Container();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtSearchBill = new System.Windows.Forms.TextBox();
            this.btnTraCuuBill = new Syncfusion.WinForms.Controls.SfButton();
            this.dtpBillDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLapHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienThoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSortSumBill = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboSortBillID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortSumBill = new System.Windows.Forms.Label();
            this.lblSortBillID = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.btnReturn = new Syncfusion.WinForms.Controls.SfButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortSumBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBillID)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBill
            // 
            this.lblBill.BackColor = System.Drawing.Color.Lavender;
            this.lblBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBill.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBill.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBill.Location = new System.Drawing.Point(0, 0);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(972, 94);
            this.lblBill.TabIndex = 1;
            this.lblBill.Text = "LỊCH SỬ HÓA ĐƠN";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchBill
            // 
            this.txtSearchBill.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBill.Location = new System.Drawing.Point(6, 16);
            this.txtSearchBill.Name = "txtSearchBill";
            this.txtSearchBill.Size = new System.Drawing.Size(251, 40);
            this.txtSearchBill.TabIndex = 4;
            // 
            // btnTraCuuBill
            // 
            this.btnTraCuuBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuBill.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuBill.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuBill.Location = new System.Drawing.Point(263, 16);
            this.btnTraCuuBill.Name = "btnTraCuuBill";
            this.btnTraCuuBill.Size = new System.Drawing.Size(118, 40);
            this.btnTraCuuBill.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuBill.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuBill.TabIndex = 5;
            this.btnTraCuuBill.Text = "Tra cứu";
            this.toolTip1.SetToolTip(this.btnTraCuuBill, "Tìm kiếm");
            this.btnTraCuuBill.UseVisualStyleBackColor = false;
            this.btnTraCuuBill.Click += new System.EventHandler(this.btnTraCuuBill_Click);
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBillDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpBillDate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Location = new System.Drawing.Point(225, 177);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(156, 34);
            this.dtpBillDate.TabIndex = 11;
            this.toolTip1.SetToolTip(this.dtpBillDate, "Ngày lập hóa đơn");
            this.dtpBillDate.ToolTipText = "";
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
            this.spcQuery.Panel1.Controls.Add(this.dgvBill);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortSumBill);
            this.spcQuery.Panel2.Controls.Add(this.cboSortBillID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortSumBill);
            this.spcQuery.Panel2.Controls.Add(this.lblSortBillID);
            this.spcQuery.Panel2.Controls.Add(this.lblBillDate);
            this.spcQuery.Panel2.Controls.Add(this.dtpBillDate);
            this.spcQuery.Panel2.Controls.Add(this.txtSearchBill);
            this.spcQuery.Panel2.Controls.Add(this.btnTraCuuBill);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colMaKH,
            this.colMaNV,
            this.colMaThue,
            this.colNgayLapHoaDon,
            this.colTongHD,
            this.colTienNhan,
            this.colTienThoi,
            this.colTrangThai});
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.Location = new System.Drawing.Point(0, 0);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(973, 746);
            this.dgvBill.TabIndex = 3;
            // 
            // colMaHD
            // 
            this.colMaHD.HeaderText = "Mã hóa đơn";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.ReadOnly = true;
            this.colMaHD.Width = 118;
            // 
            // colMaKH
            // 
            this.colMaKH.HeaderText = "Mã khách hàng";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.ReadOnly = true;
            this.colMaKH.Width = 145;
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            this.colMaNV.Width = 131;
            // 
            // colMaThue
            // 
            this.colMaThue.HeaderText = "Mã thuế";
            this.colMaThue.Name = "colMaThue";
            this.colMaThue.ReadOnly = true;
            this.colMaThue.Width = 93;
            // 
            // colNgayLapHoaDon
            // 
            this.colNgayLapHoaDon.HeaderText = "Ngày lập hóa đơn";
            this.colNgayLapHoaDon.Name = "colNgayLapHoaDon";
            this.colNgayLapHoaDon.ReadOnly = true;
            this.colNgayLapHoaDon.Width = 131;
            // 
            // colTongHD
            // 
            this.colTongHD.HeaderText = "Tổng hóa đơn";
            this.colTongHD.Name = "colTongHD";
            this.colTongHD.ReadOnly = true;
            this.colTongHD.Width = 104;
            // 
            // colTienNhan
            // 
            this.colTienNhan.HeaderText = "Tiền nhận";
            this.colTienNhan.Name = "colTienNhan";
            this.colTienNhan.ReadOnly = true;
            this.colTienNhan.Width = 106;
            // 
            // colTienThoi
            // 
            this.colTienThoi.HeaderText = "Tiền thối";
            this.colTienThoi.Name = "colTienThoi";
            this.colTienThoi.ReadOnly = true;
            this.colTienThoi.Width = 96;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Visible = false;
            this.colTrangThai.Width = 105;
            // 
            // cboSortSumBill
            // 
            this.cboSortSumBill.DelimiterChar = "";
            this.cboSortSumBill.DisplayMember = "";
            this.cboSortSumBill.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortSumBill.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortSumBill.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSumBill.Location = new System.Drawing.Point(225, 121);
            this.cboSortSumBill.Name = "cboSortSumBill";
            this.cboSortSumBill.Size = new System.Drawing.Size(156, 33);
            this.cboSortSumBill.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortSumBill.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSumBill.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSumBill.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortSumBill.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortSumBill.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cboSortSumBill, "Sắp xếp theo tổng tiền");
            // 
            // cboSortBillID
            // 
            this.cboSortBillID.DelimiterChar = "";
            this.cboSortBillID.DisplayMember = "";
            this.cboSortBillID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortBillID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortBillID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBillID.Location = new System.Drawing.Point(225, 72);
            this.cboSortBillID.Name = "cboSortBillID";
            this.cboSortBillID.Size = new System.Drawing.Size(156, 33);
            this.cboSortBillID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortBillID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBillID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBillID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortBillID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBillID.TabIndex = 7;
            this.toolTip1.SetToolTip(this.cboSortBillID, "Sắp xếp theo mã hóa đơn");
            // 
            // lblSortSumBill
            // 
            this.lblSortSumBill.AutoSize = true;
            this.lblSortSumBill.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortSumBill.Location = new System.Drawing.Point(4, 128);
            this.lblSortSumBill.Name = "lblSortSumBill";
            this.lblSortSumBill.Size = new System.Drawing.Size(197, 26);
            this.lblSortSumBill.TabIndex = 8;
            this.lblSortSumBill.Text = "Sort theo tổng tiền";
            this.lblSortSumBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSortBillID
            // 
            this.lblSortBillID.AutoSize = true;
            this.lblSortBillID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBillID.Location = new System.Drawing.Point(4, 72);
            this.lblSortBillID.Name = "lblSortBillID";
            this.lblSortBillID.Size = new System.Drawing.Size(167, 26);
            this.lblSortBillID.TabIndex = 6;
            this.lblSortBillID.Text = "Sort theo Bill ID";
            this.lblSortBillID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.Location = new System.Drawing.Point(4, 185);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(184, 26);
            this.lblBillDate.TabIndex = 10;
            this.lblBillDate.Text = "Ngày lập hóa đơn";
            this.lblBillDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblBill);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.btnReturn);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReturn.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(116, 24);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(191, 41);
            this.btnReturn.Style.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReturn.Style.ForeColor = System.Drawing.Color.White;
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Quay lại";
            this.toolTip1.SetToolTip(this.btnReturn, "Quay lại");
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ucBillHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucBillHistory";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucBill_Load);
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
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

        private System.Windows.Forms.Label lblBill;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuBill;
        private System.Windows.Forms.TextBox txtSearchBill;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpBillDate;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblSortSumBill;
        private System.Windows.Forms.Label lblSortBillID;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortSumBill;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortBillID;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLapHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienThoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private Syncfusion.WinForms.Controls.SfButton btnReturn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
