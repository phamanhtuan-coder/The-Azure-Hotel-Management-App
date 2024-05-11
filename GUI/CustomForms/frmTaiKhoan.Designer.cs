namespace GUI.customForm
{
    partial class frmTaiKhoan
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
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.lblTenPhanQuyen = new System.Windows.Forms.Label();
            this.cboPhanQuyen = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRePw = new System.Windows.Forms.TextBox();
            this.lblLoiUsername = new System.Windows.Forms.Label();
            this.lblLoiPassword = new System.Windows.Forms.Label();
            this.lblLoiRePassword = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(378, 269);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.btnSubmit, "Gửi");
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(62, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Quay lại";
            this.toolTip1.SetToolTip(this.btnCancel, "Quay lại tài khoản");
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTenPhanQuyen
            // 
            this.lblTenPhanQuyen.AutoSize = true;
            this.lblTenPhanQuyen.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblTenPhanQuyen.Location = new System.Drawing.Point(66, 215);
            this.lblTenPhanQuyen.Name = "lblTenPhanQuyen";
            this.lblTenPhanQuyen.Size = new System.Drawing.Size(146, 22);
            this.lblTenPhanQuyen.TabIndex = 7;
            this.lblTenPhanQuyen.Text = "Tên phân quyền";
            // 
            // cboPhanQuyen
            // 
            this.cboPhanQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhanQuyen.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboPhanQuyen.FormattingEnabled = true;
            this.cboPhanQuyen.Location = new System.Drawing.Point(276, 207);
            this.cboPhanQuyen.Name = "cboPhanQuyen";
            this.cboPhanQuyen.Size = new System.Drawing.Size(252, 30);
            this.cboPhanQuyen.TabIndex = 8;
            this.toolTip1.SetToolTip(this.cboPhanQuyen, "Chọn phân quyền");
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(276, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(252, 27);
            this.txtUsername.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtUsername, "Nhập tên đăng nhập");
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(276, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(252, 27);
            this.txtPassword.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtPassword, "Nhập mật khẩu");
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(66, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(66, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 22);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(66, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập lại password";
            // 
            // txtRePw
            // 
            this.txtRePw.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtRePw.Location = new System.Drawing.Point(276, 148);
            this.txtRePw.Name = "txtRePw";
            this.txtRePw.PasswordChar = '*';
            this.txtRePw.Size = new System.Drawing.Size(252, 27);
            this.txtRePw.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtRePw, "Nhập lại mật khẩu");
            this.txtRePw.Leave += new System.EventHandler(this.txtRePw_Leave);
            // 
            // lblLoiUsername
            // 
            this.lblLoiUsername.AutoSize = true;
            this.lblLoiUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiUsername.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiUsername.Location = new System.Drawing.Point(278, 60);
            this.lblLoiUsername.Name = "lblLoiUsername";
            this.lblLoiUsername.Size = new System.Drawing.Size(0, 15);
            this.lblLoiUsername.TabIndex = 14;
            // 
            // lblLoiPassword
            // 
            this.lblLoiPassword.AutoSize = true;
            this.lblLoiPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiPassword.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiPassword.Location = new System.Drawing.Point(278, 119);
            this.lblLoiPassword.Name = "lblLoiPassword";
            this.lblLoiPassword.Size = new System.Drawing.Size(0, 15);
            this.lblLoiPassword.TabIndex = 15;
            // 
            // lblLoiRePassword
            // 
            this.lblLoiRePassword.AutoSize = true;
            this.lblLoiRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiRePassword.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiRePassword.Location = new System.Drawing.Point(278, 178);
            this.lblLoiRePassword.Name = "lblLoiRePassword";
            this.lblLoiRePassword.Size = new System.Drawing.Size(0, 15);
            this.lblLoiRePassword.TabIndex = 16;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(600, 351);
            this.Controls.Add(this.lblLoiRePassword);
            this.Controls.Add(this.lblLoiPassword);
            this.Controls.Add(this.lblLoiUsername);
            this.Controls.Add(this.txtRePw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.cboPhanQuyen);
            this.Controls.Add(this.lblTenPhanQuyen);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblTenPhanQuyen;
        private System.Windows.Forms.ComboBox cboPhanQuyen;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRePw;
        private System.Windows.Forms.Label lblLoiUsername;
        private System.Windows.Forms.Label lblLoiPassword;
        private System.Windows.Forms.Label lblLoiRePassword;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}