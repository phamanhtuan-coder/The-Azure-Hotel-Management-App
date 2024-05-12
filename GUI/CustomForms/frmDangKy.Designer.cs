
namespace GUI.customForm
{
    partial class frmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.spcInput = new System.Windows.Forms.SplitContainer();
            this.lblLoiRePassword = new System.Windows.Forms.Label();
            this.lblLoiPassword = new System.Windows.Forms.Label();
            this.lblLoiUsername = new System.Windows.Forms.Label();
            this.lblRePw = new System.Windows.Forms.Label();
            this.lblPw = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnUpload = new Syncfusion.WinForms.Controls.SfButton();
            this.cpicAvatar = new GUI.CircularPictureBox();
            this.lblLoiNS = new System.Windows.Forms.Label();
            this.lblLoiSDT = new System.Windows.Forms.Label();
            this.lblLoiEmail = new System.Windows.Forms.Label();
            this.lblLoiCCCD = new System.Windows.Forms.Label();
            this.lblLoiHoTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgSinh = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.btnSignUp = new Syncfusion.WinForms.Controls.SfButton();
            this.btnQuayLai = new Syncfusion.WinForms.Controls.SfButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spcInput)).BeginInit();
            this.spcInput.Panel1.SuspendLayout();
            this.spcInput.Panel2.SuspendLayout();
            this.spcInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpicAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(749, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(202, 28);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(246, 27);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.Leave += new System.EventHandler(this.txtHoTen_Leave);
            // 
            // spcInput
            // 
            this.spcInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.spcInput.Location = new System.Drawing.Point(0, 60);
            this.spcInput.Name = "spcInput";
            // 
            // spcInput.Panel1
            // 
            this.spcInput.Panel1.Controls.Add(this.lblLoiRePassword);
            this.spcInput.Panel1.Controls.Add(this.lblLoiPassword);
            this.spcInput.Panel1.Controls.Add(this.lblLoiUsername);
            this.spcInput.Panel1.Controls.Add(this.lblRePw);
            this.spcInput.Panel1.Controls.Add(this.lblPw);
            this.spcInput.Panel1.Controls.Add(this.lblUsername);
            this.spcInput.Panel1.Controls.Add(this.txtRePassword);
            this.spcInput.Panel1.Controls.Add(this.txtPassword);
            this.spcInput.Panel1.Controls.Add(this.txtUsername);
            this.spcInput.Panel1.Controls.Add(this.btnUpload);
            this.spcInput.Panel1.Controls.Add(this.cpicAvatar);
            this.spcInput.Panel1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.spcInput.Panel1.ForeColor = System.Drawing.Color.White;
            // 
            // spcInput.Panel2
            // 
            this.spcInput.Panel2.Controls.Add(this.lblLoiNS);
            this.spcInput.Panel2.Controls.Add(this.lblLoiSDT);
            this.spcInput.Panel2.Controls.Add(this.lblLoiEmail);
            this.spcInput.Panel2.Controls.Add(this.lblLoiCCCD);
            this.spcInput.Panel2.Controls.Add(this.lblLoiHoTen);
            this.spcInput.Panel2.Controls.Add(this.label1);
            this.spcInput.Panel2.Controls.Add(this.txtPhone);
            this.spcInput.Panel2.Controls.Add(this.lblDiaChi);
            this.spcInput.Panel2.Controls.Add(this.lblNgSinh);
            this.spcInput.Panel2.Controls.Add(this.lblEmail);
            this.spcInput.Panel2.Controls.Add(this.lblGioiTinh);
            this.spcInput.Panel2.Controls.Add(this.lblCCCD);
            this.spcInput.Panel2.Controls.Add(this.lblHoTen);
            this.spcInput.Panel2.Controls.Add(this.radNu);
            this.spcInput.Panel2.Controls.Add(this.radNam);
            this.spcInput.Panel2.Controls.Add(this.txtDiaChi);
            this.spcInput.Panel2.Controls.Add(this.dtpNgaySinh);
            this.spcInput.Panel2.Controls.Add(this.txtEmail);
            this.spcInput.Panel2.Controls.Add(this.txtCCCD);
            this.spcInput.Panel2.Controls.Add(this.txtHoTen);
            this.spcInput.Panel2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.spcInput.Panel2.ForeColor = System.Drawing.Color.White;
            this.spcInput.Size = new System.Drawing.Size(749, 375);
            this.spcInput.SplitterDistance = 285;
            this.spcInput.TabIndex = 4;
            // 
            // lblLoiRePassword
            // 
            this.lblLoiRePassword.AutoSize = true;
            this.lblLoiRePassword.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoiRePassword.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiRePassword.Location = new System.Drawing.Point(21, 353);
            this.lblLoiRePassword.Name = "lblLoiRePassword";
            this.lblLoiRePassword.Size = new System.Drawing.Size(0, 16);
            this.lblLoiRePassword.TabIndex = 24;
            // 
            // lblLoiPassword
            // 
            this.lblLoiPassword.AutoSize = true;
            this.lblLoiPassword.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoiPassword.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiPassword.Location = new System.Drawing.Point(21, 286);
            this.lblLoiPassword.Name = "lblLoiPassword";
            this.lblLoiPassword.Size = new System.Drawing.Size(0, 16);
            this.lblLoiPassword.TabIndex = 23;
            // 
            // lblLoiUsername
            // 
            this.lblLoiUsername.AutoSize = true;
            this.lblLoiUsername.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoiUsername.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiUsername.Location = new System.Drawing.Point(21, 218);
            this.lblLoiUsername.Name = "lblLoiUsername";
            this.lblLoiUsername.Size = new System.Drawing.Size(0, 16);
            this.lblLoiUsername.TabIndex = 22;
            // 
            // lblRePw
            // 
            this.lblRePw.AutoSize = true;
            this.lblRePw.Location = new System.Drawing.Point(21, 303);
            this.lblRePw.Name = "lblRePw";
            this.lblRePw.Size = new System.Drawing.Size(123, 22);
            this.lblRePw.TabIndex = 19;
            this.lblRePw.Text = "Re-Password:";
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Location = new System.Drawing.Point(21, 235);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(95, 22);
            this.lblPw.TabIndex = 12;
            this.lblPw.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(21, 167);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 22);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username:";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(25, 328);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(246, 27);
            this.txtRePassword.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txtRePassword, "Nhập lại mật khẩu");
            this.txtRePassword.Leave += new System.EventHandler(this.txtRePw_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(25, 260);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(246, 27);
            this.txtPassword.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtPassword, "Nhập mật khẩu");
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(25, 192);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(246, 27);
            this.txtUsername.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtUsername, "Nhập tên đăng nhập");
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpload.Location = new System.Drawing.Point(155, 78);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(116, 27);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Tải lên";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // cpicAvatar
            // 
            this.cpicAvatar.BackColor = System.Drawing.Color.White;
            this.cpicAvatar.Image = ((System.Drawing.Image)(resources.GetObject("cpicAvatar.Image")));
            this.cpicAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("cpicAvatar.InitialImage")));
            this.cpicAvatar.Location = new System.Drawing.Point(9, 19);
            this.cpicAvatar.Name = "cpicAvatar";
            this.cpicAvatar.Size = new System.Drawing.Size(128, 128);
            this.cpicAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpicAvatar.TabIndex = 0;
            this.cpicAvatar.TabStop = false;
            // 
            // lblLoiNS
            // 
            this.lblLoiNS.AutoSize = true;
            this.lblLoiNS.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoiNS.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiNS.Location = new System.Drawing.Point(199, 302);
            this.lblLoiNS.Name = "lblLoiNS";
            this.lblLoiNS.Size = new System.Drawing.Size(0, 16);
            this.lblLoiNS.TabIndex = 21;
            // 
            // lblLoiSDT
            // 
            this.lblLoiSDT.AutoSize = true;
            this.lblLoiSDT.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoiSDT.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiSDT.Location = new System.Drawing.Point(199, 206);
            this.lblLoiSDT.Name = "lblLoiSDT";
            this.lblLoiSDT.Size = new System.Drawing.Size(0, 16);
            this.lblLoiSDT.TabIndex = 20;
            // 
            // lblLoiEmail
            // 
            this.lblLoiEmail.AutoSize = true;
            this.lblLoiEmail.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoiEmail.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiEmail.Location = new System.Drawing.Point(198, 156);
            this.lblLoiEmail.Name = "lblLoiEmail";
            this.lblLoiEmail.Size = new System.Drawing.Size(0, 16);
            this.lblLoiEmail.TabIndex = 19;
            // 
            // lblLoiCCCD
            // 
            this.lblLoiCCCD.AutoSize = true;
            this.lblLoiCCCD.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoiCCCD.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiCCCD.Location = new System.Drawing.Point(198, 105);
            this.lblLoiCCCD.Name = "lblLoiCCCD";
            this.lblLoiCCCD.Size = new System.Drawing.Size(0, 16);
            this.lblLoiCCCD.TabIndex = 18;
            // 
            // lblLoiHoTen
            // 
            this.lblLoiHoTen.AutoSize = true;
            this.lblLoiHoTen.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoiHoTen.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiHoTen.Location = new System.Drawing.Point(198, 53);
            this.lblLoiHoTen.Name = "lblLoiHoTen";
            this.lblLoiHoTen.Size = new System.Drawing.Size(0, 16);
            this.lblLoiHoTen.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(202, 180);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(246, 27);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(18, 328);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(72, 22);
            this.lblDiaChi.TabIndex = 15;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblNgSinh
            // 
            this.lblNgSinh.AutoSize = true;
            this.lblNgSinh.Location = new System.Drawing.Point(18, 278);
            this.lblNgSinh.Name = "lblNgSinh";
            this.lblNgSinh.Size = new System.Drawing.Size(98, 22);
            this.lblNgSinh.TabIndex = 17;
            this.lblNgSinh.Text = "Ngày sinh:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 22);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(18, 235);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(85, 22);
            this.lblGioiTinh.TabIndex = 14;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(18, 84);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(167, 22);
            this.lblCCCD.TabIndex = 4;
            this.lblCCCD.Text = "CCCD/Paasport ID:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(18, 33);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(93, 22);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ và Tên";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Checked = true;
            this.radNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(302, 233);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(49, 24);
            this.radNu.TabIndex = 16;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(202, 233);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(63, 24);
            this.radNam.TabIndex = 15;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(202, 328);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(246, 27);
            this.txtDiaChi.TabIndex = 21;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(202, 274);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(246, 27);
            this.dtpNgaySinh.TabIndex = 18;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(202, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 27);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(202, 78);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(246, 27);
            this.txtCCCD.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtCCCD, "Nhập căn cước công dân");
            this.txtCCCD.Leave += new System.EventHandler(this.txtCCCD_Leave);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUp.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.Location = new System.Drawing.Point(388, 493);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(166, 40);
            this.btnSignUp.TabIndex = 23;
            this.btnSignUp.Text = "Đăng ký";
            this.toolTip1.SetToolTip(this.btnSignUp, "Đăng ký");
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuayLai.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.Location = new System.Drawing.Point(165, 493);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(166, 40);
            this.btnQuayLai.TabIndex = 22;
            this.btnQuayLai.Text = "Quay lại login";
            this.toolTip1.SetToolTip(this.btnQuayLai, "Quây lại");
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // frmDangKy
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.btnQuayLai;
            this.ClientSize = new System.Drawing.Size(749, 574);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.spcInput);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangKy";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDangKy";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.spcInput.Panel1.ResumeLayout(false);
            this.spcInput.Panel1.PerformLayout();
            this.spcInput.Panel2.ResumeLayout(false);
            this.spcInput.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcInput)).EndInit();
            this.spcInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpicAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.SplitContainer spcInput;
        private CircularPictureBox cpicAvatar;
        private Syncfusion.WinForms.Controls.SfButton btnUpload;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label lblRePw;
        private System.Windows.Forms.Label lblPw;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgSinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblHoTen;
        private Syncfusion.WinForms.Controls.SfButton btnSignUp;
        private Syncfusion.WinForms.Controls.SfButton btnQuayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblLoiPassword;
        private System.Windows.Forms.Label lblLoiUsername;
        private System.Windows.Forms.Label lblLoiNS;
        private System.Windows.Forms.Label lblLoiSDT;
        private System.Windows.Forms.Label lblLoiEmail;
        private System.Windows.Forms.Label lblLoiCCCD;
        private System.Windows.Forms.Label lblLoiHoTen;
        private System.Windows.Forms.Label lblLoiRePassword;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}