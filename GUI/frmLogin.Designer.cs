using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.picLoginBG = new System.Windows.Forms.PictureBox();
            this.panLogin = new GUI.SemiTransparentPanel();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.linkForget = new System.Windows.Forms.LinkLabel();
            this.lblLOGO = new System.Windows.Forms.Label();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.panUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.panPassword = new System.Windows.Forms.Panel();
            this.btnShowHidePassword = new Syncfusion.WinForms.Controls.SfButton();
            this.txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.lblPassword = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblUsername = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginBG)).BeginInit();
            this.panLogin.SuspendLayout();
            this.panUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            this.panPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(900, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 48);
            this.btnClose.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnClose.Style.FocusedForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Style.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnClose.Style.HoverBackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnClose.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnClose.Style.ImageForeColor = System.Drawing.Color.DarkCyan;
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picLoginBG
            // 
            this.picLoginBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLoginBG.Image = global::GUI.Properties.Resources.backgroundLogin_LowRes;
            this.picLoginBG.InitialImage = null;
            this.picLoginBG.Location = new System.Drawing.Point(0, 0);
            this.picLoginBG.Name = "picLoginBG";
            this.picLoginBG.Size = new System.Drawing.Size(960, 540);
            this.picLoginBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoginBG.TabIndex = 5;
            this.picLoginBG.TabStop = false;
            // 
            // panLogin
            // 
            this.panLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panLogin.BackColor = System.Drawing.Color.Transparent;
            this.panLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panLogin.BackgroundImage")));
            this.panLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panLogin.Controls.Add(this.chkRemember);
            this.panLogin.Controls.Add(this.linkForget);
            this.panLogin.Controls.Add(this.lblLOGO);
            this.panLogin.Controls.Add(this.btnSubmit);
            this.panLogin.Controls.Add(this.panUsername);
            this.panLogin.Controls.Add(this.panPassword);
            this.panLogin.Controls.Add(this.picPassword);
            this.panLogin.Controls.Add(this.picUsername);
            this.panLogin.Controls.Add(this.lblPassword);
            this.panLogin.Controls.Add(this.lblUsername);
            this.panLogin.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panLogin.Location = new System.Drawing.Point(60, 50);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(360, 440);
            this.panLogin.TabIndex = 0;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemember.Location = new System.Drawing.Point(146, 319);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(173, 26);
            this.chkRemember.TabIndex = 7;
            this.chkRemember.Text = "Ghi nhớ mật khẩu";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // linkForget
            // 
            this.linkForget.ActiveLinkColor = System.Drawing.Color.Teal;
            this.linkForget.AutoSize = true;
            this.linkForget.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForget.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkForget.Location = new System.Drawing.Point(62, 279);
            this.linkForget.Name = "linkForget";
            this.linkForget.Size = new System.Drawing.Size(152, 22);
            this.linkForget.TabIndex = 6;
            this.linkForget.TabStop = true;
            this.linkForget.Text = "Quên mật khẩu";
            // 
            // lblLOGO
            // 
            this.lblLOGO.AutoSize = true;
            this.lblLOGO.BackColor = System.Drawing.Color.Transparent;
            this.lblLOGO.Font = new System.Drawing.Font("Montserrat ExtraBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLOGO.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLOGO.Location = new System.Drawing.Point(32, 30);
            this.lblLOGO.Name = "lblLOGO";
            this.lblLOGO.Size = new System.Drawing.Size(298, 74);
            this.lblLOGO.TabIndex = 1;
            this.lblLOGO.Text = "THE AZURE HOTEL\r\nMANAGEMENT APP";
            this.lblLOGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleName = "Button";
            this.btnSubmit.BackColor = System.Drawing.Color.Teal;
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(24, 362);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(306, 47);
            this.btnSubmit.Style.BackColor = System.Drawing.Color.Teal;
            this.btnSubmit.Style.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "LOGIN";
            this.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panUsername
            // 
            this.panUsername.BackColor = System.Drawing.Color.White;
            this.panUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panUsername.Controls.Add(this.txtUsername);
            this.panUsername.Location = new System.Drawing.Point(65, 153);
            this.panUsername.Name = "panUsername";
            this.panUsername.Size = new System.Drawing.Size(251, 33);
            this.panUsername.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BeforeTouchSize = new System.Drawing.Size(238, 24);
            this.txtUsername.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.FocusBorderColor = System.Drawing.Color.Black;
            this.txtUsername.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(9, 3);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(241, 24);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.ThemeStyle.CornerRadius = 10;
            this.txtUsername.WordWrap = false;
            // 
            // panPassword
            // 
            this.panPassword.BackColor = System.Drawing.Color.White;
            this.panPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPassword.Controls.Add(this.btnShowHidePassword);
            this.panPassword.Controls.Add(this.txtPassword);
            this.panPassword.Location = new System.Drawing.Point(66, 237);
            this.panPassword.Name = "panPassword";
            this.panPassword.Size = new System.Drawing.Size(250, 30);
            this.panPassword.TabIndex = 5;
            // 
            // btnShowHidePassword
            // 
            this.btnShowHidePassword.AccessibleName = "Button";
            this.btnShowHidePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowHidePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnShowHidePassword.Location = new System.Drawing.Point(217, -1);
            this.btnShowHidePassword.Name = "btnShowHidePassword";
            this.btnShowHidePassword.Size = new System.Drawing.Size(32, 32);
            this.btnShowHidePassword.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnShowHidePassword.TabIndex = 9;
            this.btnShowHidePassword.TextMargin = new System.Windows.Forms.Padding(0);
            this.btnShowHidePassword.Click += new System.EventHandler(this.btnShowHidePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BeforeTouchSize = new System.Drawing.Size(238, 24);
            this.txtPassword.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.FocusBorderColor = System.Drawing.Color.Black;
            this.txtPassword.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(11, 3);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(238, 24);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.ThemeStyle.CornerRadius = 0;
            this.txtPassword.WordWrap = false;
            // 
            // picPassword
            // 
            this.picPassword.Image = ((System.Drawing.Image)(resources.GetObject("picPassword.Image")));
            this.picPassword.Location = new System.Drawing.Point(24, 237);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(34, 30);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 6;
            this.picPassword.TabStop = false;
            // 
            // picUsername
            // 
            this.picUsername.Image = ((System.Drawing.Image)(resources.GetObject("picUsername.Image")));
            this.picUsername.Location = new System.Drawing.Point(24, 156);
            this.picUsername.Name = "picUsername";
            this.picUsername.Size = new System.Drawing.Size(34, 30);
            this.picUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsername.TabIndex = 5;
            this.picUsername.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.lblPassword.BeforeTouchSize = new System.Drawing.Size(115, 33);
            this.lblPassword.BorderAppearance = System.Windows.Forms.BorderStyle.None;
            this.lblPassword.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblPassword.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Teal;
            this.lblPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassword.Location = new System.Drawing.Point(64, 198);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(115, 33);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.lblUsername.BeforeTouchSize = new System.Drawing.Size(115, 33);
            this.lblUsername.BorderAppearance = System.Windows.Forms.BorderStyle.None;
            this.lblUsername.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblUsername.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Teal;
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Location = new System.Drawing.Point(64, 117);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(115, 33);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.picLoginBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picLoginBG)).EndInit();
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.panUsername.ResumeLayout(false);
            this.panUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            this.panPassword.ResumeLayout(false);
            this.panPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picLoginBG;
        private SemiTransparentPanel panLogin;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblUsername;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        private System.Windows.Forms.PictureBox picUsername;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblPassword;
        private System.Windows.Forms.PictureBox picPassword;
        private Panel panPassword;
        private Panel panUsername;
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Label lblLOGO;
        private CheckBox chkRemember;
        private LinkLabel linkForget;
        private Syncfusion.WinForms.Controls.SfButton btnShowHidePassword;
    }
}

