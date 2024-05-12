namespace GUI.customForm
{
    partial class frmDoiMatKhau
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblRePW = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.lblLoiPassword = new System.Windows.Forms.Label();
            this.lblLoiRePassword = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(294, 44);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(278, 27);
            this.txtUsername.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtUsername, "Nhập tên đăng nhập");
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(358, 236);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.btnSubmit, "Gửi");
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(87, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(53, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(192, 22);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username của bạn là:";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblPW.Location = new System.Drawing.Point(52, 114);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(217, 22);
            this.lblPW.TabIndex = 3;
            this.lblPW.Text = "Hãy nhập password mới:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtNewPassword.Location = new System.Drawing.Point(294, 108);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(278, 27);
            this.txtNewPassword.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtNewPassword, "Nhập mật khẩu mới");
            this.txtNewPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblRePW
            // 
            this.lblRePW.AutoSize = true;
            this.lblRePW.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblRePW.Location = new System.Drawing.Point(52, 178);
            this.lblRePW.Name = "lblRePW";
            this.lblRePW.Size = new System.Drawing.Size(205, 22);
            this.lblRePW.TabIndex = 5;
            this.lblRePW.Text = "Hãy nhập lại password:";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtRePassword.Location = new System.Drawing.Point(294, 172);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(278, 27);
            this.txtRePassword.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtRePassword, "Nhập lại mật khẩu mới");
            this.txtRePassword.Leave += new System.EventHandler(this.txtRePw_Leave);
            // 
            // lblLoiPassword
            // 
            this.lblLoiPassword.AutoSize = true;
            this.lblLoiPassword.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoiPassword.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiPassword.Location = new System.Drawing.Point(296, 140);
            this.lblLoiPassword.Name = "lblLoiPassword";
            this.lblLoiPassword.Size = new System.Drawing.Size(0, 16);
            this.lblLoiPassword.TabIndex = 24;
            // 
            // lblLoiRePassword
            // 
            this.lblLoiRePassword.AutoSize = true;
            this.lblLoiRePassword.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoiRePassword.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoiRePassword.Location = new System.Drawing.Point(296, 203);
            this.lblLoiRePassword.Name = "lblLoiRePassword";
            this.lblLoiRePassword.Size = new System.Drawing.Size(0, 16);
            this.lblLoiRePassword.TabIndex = 25;
            // 
            // frmDoiMatKhau
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(600, 311);
            this.Controls.Add(this.lblLoiRePassword);
            this.Controls.Add(this.lblLoiPassword);
            this.Controls.Add(this.lblRePW);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmQuenMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblRePW;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label lblLoiPassword;
        private System.Windows.Forms.Label lblLoiRePassword;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}