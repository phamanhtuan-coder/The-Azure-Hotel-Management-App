namespace GUI.customForm
{
    partial class frmPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.btnChonHinh = new Syncfusion.WinForms.Controls.SfButton();
            this.picHinhPhong = new System.Windows.Forms.PictureBox();
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.lblTinhTrangPhong = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboTinhTrangPhong = new Syncfusion.WinForms.ListView.SfComboBox();
            this.nudGiaPhong = new System.Windows.Forms.NumericUpDown();
            this.nudSucChuaToiDa = new System.Windows.Forms.NumericUpDown();
            this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTinhTrangPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChuaToiDa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(568, 377);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(395, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonHinh.Location = new System.Drawing.Point(88, 312);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(150, 38);
            this.btnChonHinh.TabIndex = 16;
            this.btnChonHinh.Text = "Submit";
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // picHinhPhong
            // 
            this.picHinhPhong.Image = ((System.Drawing.Image)(resources.GetObject("picHinhPhong.Image")));
            this.picHinhPhong.Location = new System.Drawing.Point(42, 28);
            this.picHinhPhong.Name = "picHinhPhong";
            this.picHinhPhong.Size = new System.Drawing.Size(248, 270);
            this.picHinhPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhPhong.TabIndex = 17;
            this.picHinhPhong.TabStop = false;
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.Location = new System.Drawing.Point(381, 20);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(130, 27);
            this.lblMaLoai.TabIndex = 19;
            this.lblMaLoai.Text = "Loại phòng";
            // 
            // lblTinhTrangPhong
            // 
            this.lblTinhTrangPhong.AutoSize = true;
            this.lblTinhTrangPhong.Location = new System.Drawing.Point(381, 81);
            this.lblTinhTrangPhong.Name = "lblTinhTrangPhong";
            this.lblTinhTrangPhong.Size = new System.Drawing.Size(197, 27);
            this.lblTinhTrangPhong.TabIndex = 20;
            this.lblTinhTrangPhong.Text = "Tình trạng phòng";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(381, 139);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(120, 27);
            this.lblGia.TabIndex = 23;
            this.lblGia.Text = "Giá phòng";
            // 
            // lblSucChua
            // 
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Location = new System.Drawing.Point(381, 197);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(175, 27);
            this.lblSucChua.TabIndex = 24;
            this.lblSucChua.Text = "Sức chứa tối đa";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(381, 250);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(146, 27);
            this.lblMoTa.TabIndex = 25;
            this.lblMoTa.Text = "Mô tả phòng";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboLoaiPhong.Location = new System.Drawing.Point(568, 12);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(150, 30);
            this.cboLoaiPhong.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboLoaiPhong.TabIndex = 26;
            this.cboLoaiPhong.TabStop = false;
            // 
            // cboTinhTrangPhong
            // 
            this.cboTinhTrangPhong.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboTinhTrangPhong.Location = new System.Drawing.Point(568, 73);
            this.cboTinhTrangPhong.Name = "cboTinhTrangPhong";
            this.cboTinhTrangPhong.Size = new System.Drawing.Size(150, 30);
            this.cboTinhTrangPhong.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTinhTrangPhong.TabIndex = 27;
            this.cboTinhTrangPhong.TabStop = false;
            // 
            // nudGiaPhong
            // 
            this.nudGiaPhong.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudGiaPhong.Location = new System.Drawing.Point(568, 134);
            this.nudGiaPhong.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.nudGiaPhong.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudGiaPhong.Name = "nudGiaPhong";
            this.nudGiaPhong.Size = new System.Drawing.Size(150, 32);
            this.nudGiaPhong.TabIndex = 28;
            this.nudGiaPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGiaPhong.ThousandsSeparator = true;
            this.nudGiaPhong.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // nudSucChuaToiDa
            // 
            this.nudSucChuaToiDa.Location = new System.Drawing.Point(568, 192);
            this.nudSucChuaToiDa.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudSucChuaToiDa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSucChuaToiDa.Name = "nudSucChuaToiDa";
            this.nudSucChuaToiDa.Size = new System.Drawing.Size(150, 32);
            this.nudSucChuaToiDa.TabIndex = 29;
            this.nudSucChuaToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSucChuaToiDa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.Location = new System.Drawing.Point(568, 250);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Size = new System.Drawing.Size(150, 96);
            this.rtxtMoTa.TabIndex = 30;
            this.rtxtMoTa.Text = "";
            // 
            // frmPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtMoTa);
            this.Controls.Add(this.nudSucChuaToiDa);
            this.Controls.Add(this.nudGiaPhong);
            this.Controls.Add(this.cboTinhTrangPhong);
            this.Controls.Add(this.cboLoaiPhong);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblSucChua);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTinhTrangPhong);
            this.Controls.Add(this.lblMaLoai);
            this.Controls.Add(this.picHinhPhong);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTinhTrangPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChuaToiDa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnChonHinh;
        private System.Windows.Forms.PictureBox picHinhPhong;
        private System.Windows.Forms.Label lblMaLoai;
        private System.Windows.Forms.Label lblTinhTrangPhong;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.Label lblMoTa;
        private Syncfusion.WinForms.ListView.SfComboBox cboLoaiPhong;
        private Syncfusion.WinForms.ListView.SfComboBox cboTinhTrangPhong;
        private System.Windows.Forms.NumericUpDown nudGiaPhong;
        private System.Windows.Forms.NumericUpDown nudSucChuaToiDa;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
    }
}