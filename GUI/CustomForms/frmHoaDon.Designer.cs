namespace GUI.customForm
{
    partial class frmHoaDon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.cboMaNV = new Syncfusion.WinForms.ListView.SfComboBox();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaThue = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblTienNhan = new System.Windows.Forms.Label();
            this.lblTienThua = new System.Windows.Forms.Label();
            this.nudTongTien = new System.Windows.Forms.NumericUpDown();
            this.nudTienNhan = new System.Windows.Forms.NumericUpDown();
            this.nudTienThua = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienThua)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(308, 311);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(31, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(13, 17);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(131, 20);
            this.lblMaKH.TabIndex = 8;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.AutoSize = true;
            this.lblNgayLapHD.Location = new System.Drawing.Point(13, 101);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.Size = new System.Drawing.Size(148, 20);
            this.lblNgayLapHD.TabIndex = 10;
            this.lblNgayLapHD.Text = "Ngày lập hóa đơn";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(13, 185);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(84, 20);
            this.lblTongTien.TabIndex = 13;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // cboMaNV
            // 
            this.cboMaNV.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboMaNV.Location = new System.Drawing.Point(278, 54);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(180, 27);
            this.cboMaNV.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaNV.TabIndex = 14;
            this.cboMaNV.TabStop = false;
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDat.Location = new System.Drawing.Point(278, 97);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(180, 26);
            this.dtpNgayDat.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã thuế";
            // 
            // cboMaThue
            // 
            this.cboMaThue.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboMaThue.Location = new System.Drawing.Point(278, 142);
            this.cboMaThue.Name = "cboMaThue";
            this.cboMaThue.Size = new System.Drawing.Size(180, 27);
            this.cboMaThue.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaThue.TabIndex = 21;
            this.cboMaThue.TabStop = false;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(12, 59);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(115, 20);
            this.lblMaNV.TabIndex = 22;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(278, 12);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(180, 26);
            this.txtMaKH.TabIndex = 23;
            // 
            // lblTienNhan
            // 
            this.lblTienNhan.AutoSize = true;
            this.lblTienNhan.Location = new System.Drawing.Point(13, 227);
            this.lblTienNhan.Name = "lblTienNhan";
            this.lblTienNhan.Size = new System.Drawing.Size(88, 20);
            this.lblTienNhan.TabIndex = 24;
            this.lblTienNhan.Text = "Tiền nhận";
            // 
            // lblTienThua
            // 
            this.lblTienThua.AutoSize = true;
            this.lblTienThua.Location = new System.Drawing.Point(13, 269);
            this.lblTienThua.Name = "lblTienThua";
            this.lblTienThua.Size = new System.Drawing.Size(84, 20);
            this.lblTienThua.TabIndex = 25;
            this.lblTienThua.Text = "Tiền thừa";
            // 
            // nudTongTien
            // 
            this.nudTongTien.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTongTien.Location = new System.Drawing.Point(278, 186);
            this.nudTongTien.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudTongTien.Name = "nudTongTien";
            this.nudTongTien.Size = new System.Drawing.Size(180, 26);
            this.nudTongTien.TabIndex = 26;
            this.nudTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTongTien.ThousandsSeparator = true;
            this.nudTongTien.ValueChanged += new System.EventHandler(this.nudTongTien_ValueChanged);
            // 
            // nudTienNhan
            // 
            this.nudTienNhan.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTienNhan.Location = new System.Drawing.Point(278, 225);
            this.nudTienNhan.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudTienNhan.Name = "nudTienNhan";
            this.nudTienNhan.Size = new System.Drawing.Size(180, 26);
            this.nudTienNhan.TabIndex = 27;
            this.nudTienNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTienNhan.ThousandsSeparator = true;
            this.nudTienNhan.ValueChanged += new System.EventHandler(this.nudTienNhan_ValueChanged);
            // 
            // nudTienThua
            // 
            this.nudTienThua.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTienThua.Location = new System.Drawing.Point(278, 267);
            this.nudTienThua.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudTienThua.Name = "nudTienThua";
            this.nudTienThua.Size = new System.Drawing.Size(180, 26);
            this.nudTienThua.TabIndex = 28;
            this.nudTienThua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTienThua.ThousandsSeparator = true;
            // 
            // frmHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(485, 376);
            this.Controls.Add(this.nudTienThua);
            this.Controls.Add(this.nudTienNhan);
            this.Controls.Add(this.nudTongTien);
            this.Controls.Add(this.lblTienThua);
            this.Controls.Add(this.lblTienNhan);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.cboMaThue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayDat);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblNgayLapHD);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienThua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblNgayLapHD;
        private System.Windows.Forms.Label lblTongTien;
        private Syncfusion.WinForms.ListView.SfComboBox cboMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.ListView.SfComboBox cboMaThue;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblTienNhan;
        private System.Windows.Forms.Label lblTienThua;
        private System.Windows.Forms.NumericUpDown nudTongTien;
        private System.Windows.Forms.NumericUpDown nudTienNhan;
        private System.Windows.Forms.NumericUpDown nudTienThua;
    }
}