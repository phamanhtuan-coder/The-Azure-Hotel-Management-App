namespace GUI.customForm
{
    partial class frmDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVu));
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.btnChonHinh = new Syncfusion.WinForms.Controls.SfButton();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new Syncfusion.WinForms.ListView.SfComboBox();
            this.nudGia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(505, 161);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(332, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonHinh.Location = new System.Drawing.Point(84, 181);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(150, 38);
            this.btnChonHinh.TabIndex = 16;
            this.btnChonHinh.Text = "Submit";
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Image = ((System.Drawing.Image)(resources.GetObject("picHinhAnh.Image")));
            this.picHinhAnh.Location = new System.Drawing.Point(42, 28);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(236, 133);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 17;
            this.picHinhAnh.TabStop = false;
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Location = new System.Drawing.Point(318, 36);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(107, 22);
            this.lblTenDV.TabIndex = 19;
            this.lblTenDV.Text = "Tên dịch vụ";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(318, 93);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(104, 22);
            this.lblGia.TabIndex = 23;
            this.lblGia.Text = "Giá dịch vụ";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboLoaiPhong.Location = new System.Drawing.Point(505, 28);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(150, 30);
            this.cboLoaiPhong.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboLoaiPhong.TabIndex = 26;
            this.cboLoaiPhong.TabStop = false;
            // 
            // nudGia
            // 
            this.nudGia.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudGia.Location = new System.Drawing.Point(505, 88);
            this.nudGia.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.nudGia.Name = "nudGia";
            this.nudGia.Size = new System.Drawing.Size(150, 27);
            this.nudGia.TabIndex = 28;
            this.nudGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGia.ThousandsSeparator = true;
            // 
            // frmDichVu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(691, 236);
            this.Controls.Add(this.nudGia);
            this.Controls.Add(this.cboLoaiPhong);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTenDV);
            this.Controls.Add(this.picHinhAnh);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnChonHinh;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.Label lblGia;
        private Syncfusion.WinForms.ListView.SfComboBox cboLoaiPhong;
        private System.Windows.Forms.NumericUpDown nudGia;
    }
}