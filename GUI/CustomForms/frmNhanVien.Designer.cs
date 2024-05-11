namespace GUI.customForm
{
    partial class frmNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.btnTaoTK = new Syncfusion.WinForms.Controls.SfButton();
            this.btnChonHinh = new Syncfusion.WinForms.Controls.SfButton();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblMaTaiKhoan = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.cboMaNQL = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nupLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoiEmail = new System.Windows.Forms.Label();
            this.lblLoiSDT = new System.Windows.Forms.Label();
            this.lblLoiCCCD = new System.Windows.Forms.Label();
            this.lblLoiNS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoiLuong = new System.Windows.Forms.Label();
            this.lblLoiHoTen = new System.Windows.Forms.Label();
            this.lblLoiUsername = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(582, 400);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.btnSubmit, "Gửi");
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(387, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtHoTenNV.Location = new System.Drawing.Point(538, 12);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(194, 27);
            this.txtHoTenNV.TabIndex = 2;
            this.txtHoTenNV.Leave += new System.EventHandler(this.txtHoTenNV_Leave);
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(12, 270);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(175, 27);
            this.txtTenTaiKhoan.TabIndex = 17;
            this.txtTenTaiKhoan.Leave += new System.EventHandler(this.txtTenTaiKhoan_Leave);
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtCCCD.Location = new System.Drawing.Point(538, 64);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(194, 27);
            this.txtCCCD.TabIndex = 4;
            this.txtCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCCD_KeyPress);
            this.txtCCCD.Leave += new System.EventHandler(this.txtCCCD_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(538, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 27);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtSDT.Location = new System.Drawing.Point(538, 271);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(194, 27);
            this.txtSDT.TabIndex = 13;
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtDiaChi.Location = new System.Drawing.Point(538, 323);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(194, 27);
            this.txtDiaChi.TabIndex = 15;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(538, 167);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(194, 27);
            this.dtpNgaySinh.TabIndex = 9;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.radNam.Location = new System.Drawing.Point(538, 117);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(68, 26);
            this.radNam.TabIndex = 6;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.radNu.Location = new System.Drawing.Point(648, 117);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(52, 26);
            this.radNu.TabIndex = 7;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnTaoTK.Location = new System.Drawing.Point(193, 270);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(169, 27);
            this.btnTaoTK.TabIndex = 18;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.toolTip1.SetToolTip(this.btnTaoTK, "Tạo tài khoản nhân viên");
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnChonHinh.Location = new System.Drawing.Point(90, 208);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(150, 38);
            this.btnChonHinh.TabIndex = 16;
            this.btnChonHinh.Text = "Submit";
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(74, 12);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(180, 180);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 17;
            this.picAvatar.TabStop = false;
            // 
            // lblMaTaiKhoan
            // 
            this.lblMaTaiKhoan.AutoSize = true;
            this.lblMaTaiKhoan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaTaiKhoan.Location = new System.Drawing.Point(12, 248);
            this.lblMaTaiKhoan.Name = "lblMaTaiKhoan";
            this.lblMaTaiKhoan.Size = new System.Drawing.Size(96, 22);
            this.lblMaTaiKhoan.TabIndex = 16;
            this.lblMaTaiKhoan.Text = "Username";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.Location = new System.Drawing.Point(381, 17);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(91, 22);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblCCCD.Location = new System.Drawing.Point(381, 69);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(59, 22);
            this.lblCCCD.TabIndex = 3;
            this.lblCCCD.Text = "CCCD";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinh.Location = new System.Drawing.Point(381, 117);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(81, 22);
            this.lblGioiTinh.TabIndex = 5;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblNgaySinh.Location = new System.Drawing.Point(381, 172);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(94, 22);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(383, 224);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 22);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblSDT.Location = new System.Drawing.Point(381, 274);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(43, 22);
            this.lblSDT.TabIndex = 12;
            this.lblSDT.Text = "SĐT";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblDiaChi.Location = new System.Drawing.Point(383, 328);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(68, 22);
            this.lblDiaChi.TabIndex = 14;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // cboMaNQL
            // 
            this.cboMaNQL.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaNQL.FormattingEnabled = true;
            this.cboMaNQL.Location = new System.Drawing.Point(193, 316);
            this.cboMaNQL.Name = "cboMaNQL";
            this.cboMaNQL.Size = new System.Drawing.Size(169, 30);
            this.cboMaNQL.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã người quản lý";
            // 
            // nupLuong
            // 
            this.nupLuong.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.nupLuong.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupLuong.Location = new System.Drawing.Point(193, 350);
            this.nupLuong.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.nupLuong.Name = "nupLuong";
            this.nupLuong.Size = new System.Drawing.Size(169, 27);
            this.nupLuong.TabIndex = 22;
            this.nupLuong.ValueChanged += new System.EventHandler(this.nupLuong_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lương";
            // 
            // lblLoiEmail
            // 
            this.lblLoiEmail.AutoSize = true;
            this.lblLoiEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiEmail.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiEmail.Location = new System.Drawing.Point(540, 246);
            this.lblLoiEmail.Name = "lblLoiEmail";
            this.lblLoiEmail.Size = new System.Drawing.Size(0, 15);
            this.lblLoiEmail.TabIndex = 31;
            // 
            // lblLoiSDT
            // 
            this.lblLoiSDT.AutoSize = true;
            this.lblLoiSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiSDT.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiSDT.Location = new System.Drawing.Point(540, 301);
            this.lblLoiSDT.Name = "lblLoiSDT";
            this.lblLoiSDT.Size = new System.Drawing.Size(0, 15);
            this.lblLoiSDT.TabIndex = 33;
            // 
            // lblLoiCCCD
            // 
            this.lblLoiCCCD.AutoSize = true;
            this.lblLoiCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiCCCD.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiCCCD.Location = new System.Drawing.Point(538, 90);
            this.lblLoiCCCD.Name = "lblLoiCCCD";
            this.lblLoiCCCD.Size = new System.Drawing.Size(0, 15);
            this.lblLoiCCCD.TabIndex = 34;
            // 
            // lblLoiNS
            // 
            this.lblLoiNS.AutoSize = true;
            this.lblLoiNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiNS.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiNS.Location = new System.Drawing.Point(540, 196);
            this.lblLoiNS.Name = "lblLoiNS";
            this.lblLoiNS.Size = new System.Drawing.Size(0, 15);
            this.lblLoiNS.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(400, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 36;
            // 
            // lblLoiLuong
            // 
            this.lblLoiLuong.AutoSize = true;
            this.lblLoiLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiLuong.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiLuong.Location = new System.Drawing.Point(193, 371);
            this.lblLoiLuong.Name = "lblLoiLuong";
            this.lblLoiLuong.Size = new System.Drawing.Size(0, 15);
            this.lblLoiLuong.TabIndex = 37;
            // 
            // lblLoiHoTen
            // 
            this.lblLoiHoTen.AutoSize = true;
            this.lblLoiHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiHoTen.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiHoTen.Location = new System.Drawing.Point(539, 42);
            this.lblLoiHoTen.Name = "lblLoiHoTen";
            this.lblLoiHoTen.Size = new System.Drawing.Size(0, 15);
            this.lblLoiHoTen.TabIndex = 38;
            // 
            // lblLoiUsername
            // 
            this.lblLoiUsername.AutoSize = true;
            this.lblLoiUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiUsername.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiUsername.Location = new System.Drawing.Point(12, 300);
            this.lblLoiUsername.Name = "lblLoiUsername";
            this.lblLoiUsername.Size = new System.Drawing.Size(0, 15);
            this.lblLoiUsername.TabIndex = 39;
            // 
            // frmNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.lblLoiUsername);
            this.Controls.Add(this.lblLoiHoTen);
            this.Controls.Add(this.lblLoiLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLoiNS);
            this.Controls.Add(this.lblLoiCCCD);
            this.Controls.Add(this.lblLoiSDT);
            this.Controls.Add(this.lblLoiEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMaNQL);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaTaiKhoan);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.txtHoTenNV);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private Syncfusion.WinForms.Controls.SfButton btnTaoTK;
        private Syncfusion.WinForms.Controls.SfButton btnChonHinh;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblMaTaiKhoan;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.ComboBox cboMaNQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoiEmail;
        private System.Windows.Forms.Label lblLoiSDT;
        private System.Windows.Forms.Label lblLoiCCCD;
        private System.Windows.Forms.Label lblLoiNS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLoiLuong;
        private System.Windows.Forms.Label lblLoiHoTen;
        private System.Windows.Forms.Label lblLoiUsername;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}