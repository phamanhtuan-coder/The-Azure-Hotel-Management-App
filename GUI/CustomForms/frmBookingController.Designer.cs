namespace GUI.customForm
{
    partial class frmBookingController
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
            this.nudSoLuongKhach = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.lblMaPHG = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPHG = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSoLuongKhach
            // 
            this.nudSoLuongKhach.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuongKhach.Location = new System.Drawing.Point(228, 223);
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
            this.nudSoLuongKhach.Size = new System.Drawing.Size(180, 27);
            this.nudSoLuongKhach.TabIndex = 34;
            this.nudSoLuongKhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSoLuongKhach.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDat.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNgayDat.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDat.Location = new System.Drawing.Point(228, 179);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(180, 27);
            this.dtpNgayDat.TabIndex = 31;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(228, 93);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 27);
            this.txtUsername.TabIndex = 29;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(36, 228);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(140, 22);
            this.lblSoLuong.TabIndex = 27;
            this.lblSoLuong.Text = "Số lượng khách";
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDat.Location = new System.Drawing.Point(35, 184);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(87, 22);
            this.lblNgayDat.TabIndex = 24;
            this.lblNgayDat.Text = "Ngày đặt";
            // 
            // lblMaPHG
            // 
            this.lblMaPHG.AutoSize = true;
            this.lblMaPHG.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPHG.Location = new System.Drawing.Point(36, 141);
            this.lblMaPHG.Name = "lblMaPHG";
            this.lblMaPHG.Size = new System.Drawing.Size(94, 22);
            this.lblMaPHG.TabIndex = 23;
            this.lblMaPHG.Text = "Mã phòng";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(36, 99);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(96, 22);
            this.lblMaKH.TabIndex = 22;
            this.lblMaKH.Text = "Username";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(46, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(238, 287);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 44);
            this.label1.TabIndex = 35;
            this.label1.Text = "Hãy kiểm tra các thông tin bên dưới!\r\nNếu đúng hãy bấm xác nhận để đặt phòng!";
            // 
            // txtMaPHG
            // 
            this.txtMaPHG.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPHG.Location = new System.Drawing.Point(228, 136);
            this.txtMaPHG.Name = "txtMaPHG";
            this.txtMaPHG.Size = new System.Drawing.Size(180, 27);
            this.txtMaPHG.TabIndex = 36;
            // 
            // frmBookingController
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(436, 360);
            this.Controls.Add(this.txtMaPHG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSoLuongKhach);
            this.Controls.Add(this.dtpNgayDat);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblNgayDat);
            this.Controls.Add(this.lblMaPHG);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookingController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookingController";
            this.Load += new System.EventHandler(this.frmBookingController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSoLuongKhach;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.Label lblMaPHG;
        private System.Windows.Forms.Label lblMaKH;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPHG;
    }
}