namespace GUI.UserControls
{
    partial class ucBookingHistory
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
            this.dtpCheckOutDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtpCheckInDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtpBookingDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.spcQuery = new System.Windows.Forms.SplitContainer();
            this.dgvBookingHistory = new System.Windows.Forms.DataGridView();
            this.colMaDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPHG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhanPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSortBookingID = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblSortBookingID = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.panUcHeader = new System.Windows.Forms.Panel();
            this.spcHeader = new System.Windows.Forms.SplitContainer();
            this.lblBooking = new System.Windows.Forms.Label();
            this.btnReturn = new Syncfusion.WinForms.Controls.SfButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).BeginInit();
            this.spcQuery.Panel1.SuspendLayout();
            this.spcQuery.Panel2.SuspendLayout();
            this.spcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBookingID)).BeginInit();
            this.panUcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).BeginInit();
            this.spcHeader.Panel1.SuspendLayout();
            this.spcHeader.Panel2.SuspendLayout();
            this.spcHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCheckOutDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpCheckOutDate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOutDate.Location = new System.Drawing.Point(229, 184);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(156, 34);
            this.dtpCheckOutDate.TabIndex = 11;
            this.toolTip1.SetToolTip(this.dtpCheckOutDate, "Ngày trả phòng");
            this.dtpCheckOutDate.ToolTipText = "";
            this.dtpCheckOutDate.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.dtpCheckOutDate_ValueChanged);
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCheckInDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpCheckInDate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckInDate.Location = new System.Drawing.Point(229, 127);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(156, 34);
            this.dtpCheckInDate.TabIndex = 9;
            this.toolTip1.SetToolTip(this.dtpCheckInDate, "Ngày nhận phòng");
            this.dtpCheckInDate.ToolTipText = "";
            this.dtpCheckInDate.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.dtpCheckInDate_ValueChanged);
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBookingDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpBookingDate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Location = new System.Drawing.Point(229, 70);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(156, 34);
            this.dtpBookingDate.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dtpBookingDate, "Ngày đặt");
            this.dtpBookingDate.ToolTipText = "";
            this.dtpBookingDate.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.dtpBookingDate_ValueChanged);
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
            this.spcQuery.Panel1.Controls.Add(this.dgvBookingHistory);
            // 
            // spcQuery.Panel2
            // 
            this.spcQuery.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.spcQuery.Panel2.Controls.Add(this.cboSortBookingID);
            this.spcQuery.Panel2.Controls.Add(this.lblSortBookingID);
            this.spcQuery.Panel2.Controls.Add(this.lblCheckOutDate);
            this.spcQuery.Panel2.Controls.Add(this.lblCheckInDate);
            this.spcQuery.Panel2.Controls.Add(this.lblBookingDate);
            this.spcQuery.Panel2.Controls.Add(this.dtpBookingDate);
            this.spcQuery.Panel2.Controls.Add(this.dtpCheckInDate);
            this.spcQuery.Panel2.Controls.Add(this.dtpCheckOutDate);
            this.spcQuery.Size = new System.Drawing.Size(1370, 746);
            this.spcQuery.SplitterDistance = 973;
            this.spcQuery.TabIndex = 38;
            // 
            // dgvBookingHistory
            // 
            this.dgvBookingHistory.AllowUserToAddRows = false;
            this.dgvBookingHistory.AllowUserToDeleteRows = false;
            this.dgvBookingHistory.AllowUserToResizeColumns = false;
            this.dgvBookingHistory.AllowUserToResizeRows = false;
            this.dgvBookingHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBookingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDatPhong,
            this.colMaKH,
            this.colMaPHG,
            this.colNgayDat,
            this.colNgayNhanPhong,
            this.colNgayTraPhong,
            this.colSoLuongKH,
            this.colTrangThai});
            this.dgvBookingHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookingHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvBookingHistory.MultiSelect = false;
            this.dgvBookingHistory.Name = "dgvBookingHistory";
            this.dgvBookingHistory.ReadOnly = true;
            this.dgvBookingHistory.RowHeadersVisible = false;
            this.dgvBookingHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookingHistory.Size = new System.Drawing.Size(973, 746);
            this.dgvBookingHistory.TabIndex = 3;
            // 
            // colMaDatPhong
            // 
            this.colMaDatPhong.DataPropertyName = "MaDatPhong";
            this.colMaDatPhong.HeaderText = "Mã đặt phòng";
            this.colMaDatPhong.Name = "colMaDatPhong";
            this.colMaDatPhong.ReadOnly = true;
            this.colMaDatPhong.Width = 134;
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "MaKH";
            this.colMaKH.HeaderText = "Mã KH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.ReadOnly = true;
            this.colMaKH.Visible = false;
            this.colMaKH.Width = 87;
            // 
            // colMaPHG
            // 
            this.colMaPHG.DataPropertyName = "MaPHG";
            this.colMaPHG.HeaderText = "Mã PHG";
            this.colMaPHG.Name = "colMaPHG";
            this.colMaPHG.ReadOnly = true;
            this.colMaPHG.Width = 91;
            // 
            // colNgayDat
            // 
            this.colNgayDat.DataPropertyName = "NgayDatPhong";
            this.colNgayDat.HeaderText = "Ngày đặt";
            this.colNgayDat.Name = "colNgayDat";
            this.colNgayDat.ReadOnly = true;
            this.colNgayDat.Width = 98;
            // 
            // colNgayNhanPhong
            // 
            this.colNgayNhanPhong.DataPropertyName = "NgayNhanPhong";
            this.colNgayNhanPhong.HeaderText = "Ngày nhận phòng";
            this.colNgayNhanPhong.Name = "colNgayNhanPhong";
            this.colNgayNhanPhong.ReadOnly = true;
            this.colNgayNhanPhong.Width = 165;
            // 
            // colNgayTraPhong
            // 
            this.colNgayTraPhong.DataPropertyName = "NgayTraPhong";
            this.colNgayTraPhong.HeaderText = "Ngày trả phòng";
            this.colNgayTraPhong.Name = "colNgayTraPhong";
            this.colNgayTraPhong.ReadOnly = true;
            this.colNgayTraPhong.Width = 145;
            // 
            // colSoLuongKH
            // 
            this.colSoLuongKH.DataPropertyName = "SoLuongKH";
            this.colSoLuongKH.HeaderText = "Số lượng KH";
            this.colSoLuongKH.Name = "colSoLuongKH";
            this.colSoLuongKH.ReadOnly = true;
            this.colSoLuongKH.Width = 123;
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
            // cboSortBookingID
            // 
            this.cboSortBookingID.DelimiterChar = "";
            this.cboSortBookingID.DisplayMember = "";
            this.cboSortBookingID.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboSortBookingID.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboSortBookingID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Location = new System.Drawing.Point(229, 20);
            this.cboSortBookingID.Name = "cboSortBookingID";
            this.cboSortBookingID.Size = new System.Drawing.Size(156, 33);
            this.cboSortBookingID.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cboSortBookingID.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSortBookingID.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortBookingID.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cboSortBookingID, "Sắp xếp theo mã đặt phòng");
            // 
            // lblSortBookingID
            // 
            this.lblSortBookingID.AutoSize = true;
            this.lblSortBookingID.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBookingID.Location = new System.Drawing.Point(8, 20);
            this.lblSortBookingID.Name = "lblSortBookingID";
            this.lblSortBookingID.Size = new System.Drawing.Size(218, 26);
            this.lblSortBookingID.TabIndex = 4;
            this.lblSortBookingID.Text = "Sort theo Booking ID";
            this.lblSortBookingID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutDate.Location = new System.Drawing.Point(8, 192);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(175, 26);
            this.lblCheckOutDate.TabIndex = 10;
            this.lblCheckOutDate.Text = "Ngày Check-Out";
            this.lblCheckOutDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInDate.Location = new System.Drawing.Point(8, 135);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(157, 26);
            this.lblCheckInDate.TabIndex = 8;
            this.lblCheckInDate.Text = "Ngày Check-In";
            this.lblCheckInDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.Location = new System.Drawing.Point(8, 78);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(101, 26);
            this.lblBookingDate.TabIndex = 6;
            this.lblBookingDate.Text = "Ngày đặt";
            this.lblBookingDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.spcHeader.Panel1.Controls.Add(this.lblBooking);
            // 
            // spcHeader.Panel2
            // 
            this.spcHeader.Panel2.Controls.Add(this.btnReturn);
            this.spcHeader.Size = new System.Drawing.Size(1370, 94);
            this.spcHeader.SplitterDistance = 972;
            this.spcHeader.TabIndex = 0;
            // 
            // lblBooking
            // 
            this.lblBooking.BackColor = System.Drawing.Color.Lavender;
            this.lblBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBooking.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBooking.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBooking.Location = new System.Drawing.Point(0, 0);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(972, 94);
            this.lblBooking.TabIndex = 1;
            this.lblBooking.Text = "LỊCH SỬ ĐẶT PHÒNG";
            this.lblBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturn.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReturn.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(132, 19);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(159, 56);
            this.btnReturn.Style.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReturn.Style.ForeColor = System.Drawing.Color.White;
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ucBookingHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.spcQuery);
            this.Controls.Add(this.panUcHeader);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucBookingHistory";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucBooking_Load);
            this.spcQuery.Panel1.ResumeLayout(false);
            this.spcQuery.Panel2.ResumeLayout(false);
            this.spcQuery.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcQuery)).EndInit();
            this.spcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBookingID)).EndInit();
            this.panUcHeader.ResumeLayout(false);
            this.spcHeader.Panel1.ResumeLayout(false);
            this.spcHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHeader)).EndInit();
            this.spcHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpBookingDate;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpCheckInDate;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpCheckOutDate;
        private System.Windows.Forms.SplitContainer spcQuery;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblSortBookingID;
        private System.Windows.Forms.Panel panUcHeader;
        private System.Windows.Forms.SplitContainer spcHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cboSortBookingID;
        private System.Windows.Forms.DataGridView dgvBookingHistory;
        private System.Windows.Forms.Label lblBooking;
        private Syncfusion.WinForms.Controls.SfButton btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPHG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhanPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTraPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
