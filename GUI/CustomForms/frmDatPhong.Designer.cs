namespace GUI.customForm
{
    partial class frmDatPhong
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
            this.lblMaPHG = new System.Windows.Forms.Label();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cboMaPHG = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnTaoKH = new Syncfusion.WinForms.Controls.SfButton();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.nudSoLuongKhach = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaPHG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(427, 274);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(235, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(13, 22);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(174, 27);
            this.lblMaKH.TabIndex = 6;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // lblMaPHG
            // 
            this.lblMaPHG.AutoSize = true;
            this.lblMaPHG.Location = new System.Drawing.Point(13, 64);
            this.lblMaPHG.Name = "lblMaPHG";
            this.lblMaPHG.Size = new System.Drawing.Size(118, 27);
            this.lblMaPHG.TabIndex = 8;
            this.lblMaPHG.Text = "Mã phòng";
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Location = new System.Drawing.Point(12, 107);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(107, 27);
            this.lblNgayDat.TabIndex = 10;
            this.lblNgayDat.Text = "Ngày đặt";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(11, 162);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(176, 27);
            this.lblSoLuong.TabIndex = 13;
            this.lblSoLuong.Text = "Số lượng khách";
            // 
            // cboMaPHG
            // 
            this.cboMaPHG.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboMaPHG.Location = new System.Drawing.Point(205, 59);
            this.cboMaPHG.Name = "cboMaPHG";
            this.cboMaPHG.Size = new System.Drawing.Size(180, 27);
            this.cboMaPHG.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaPHG.TabIndex = 14;
            this.cboMaPHG.TabStop = false;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(205, 16);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(180, 32);
            this.txtMaKH.TabIndex = 15;
            // 
            // btnTaoKH
            // 
            this.btnTaoKH.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnTaoKH.Location = new System.Drawing.Point(427, 16);
            this.btnTaoKH.Name = "btnTaoKH";
            this.btnTaoKH.Size = new System.Drawing.Size(150, 28);
            this.btnTaoKH.TabIndex = 16;
            this.btnTaoKH.Text = "Tạo khách hàng mới";
            this.btnTaoKH.Click += new System.EventHandler(this.btnTaoKH_Click);
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDat.Location = new System.Drawing.Point(205, 102);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(180, 32);
            this.dtpNgayDat.TabIndex = 17;
            // 
            // nudSoLuongKhach
            // 
            this.nudSoLuongKhach.Location = new System.Drawing.Point(203, 157);
            this.nudSoLuongKhach.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudSoLuongKhach.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuongKhach.Name = "nudSoLuongKhach";
            this.nudSoLuongKhach.Size = new System.Drawing.Size(180, 32);
            this.nudSoLuongKhach.TabIndex = 19;
            this.nudSoLuongKhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSoLuongKhach.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmDatPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.nudSoLuongKhach);
            this.Controls.Add(this.dtpNgayDat);
            this.Controls.Add(this.btnTaoKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.cboMaPHG);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblNgayDat);
            this.Controls.Add(this.lblMaPHG);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboMaPHG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblMaPHG;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.Label lblSoLuong;
        private Syncfusion.WinForms.ListView.SfComboBox cboMaPHG;
        private System.Windows.Forms.TextBox txtMaKH;
        private Syncfusion.WinForms.Controls.SfButton btnTaoKH;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.NumericUpDown nudSoLuongKhach;
    }
}