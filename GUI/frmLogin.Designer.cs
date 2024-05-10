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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection2 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection2 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection2 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.picLoginBG = new System.Windows.Forms.PictureBox();
            this.tmrTransistion = new System.Windows.Forms.Timer(this.components);
            this.panLogin = new GUI.SemiTransparentPanel();
            this.btnSignUp = new Syncfusion.WinForms.Controls.SfButton();
            this.tbtnRemember = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.btnAdmin = new Syncfusion.WinForms.Controls.SfButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.tbtnRemember)).BeginInit();
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
            this.picLoginBG.Click += new System.EventHandler(this.picLoginBG_Click);
            // 
            // tmrTransistion
            // 
            this.tmrTransistion.Interval = 25;
            this.tmrTransistion.Tick += new System.EventHandler(this.tmrTransistion_Tick);
            // 
            // panLogin
            // 
            this.panLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panLogin.BackColor = System.Drawing.Color.Transparent;
            this.panLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panLogin.BackgroundImage")));
            this.panLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panLogin.Controls.Add(this.btnSignUp);
            this.panLogin.Controls.Add(this.tbtnRemember);
            this.panLogin.Controls.Add(this.btnAdmin);
            this.panLogin.Controls.Add(this.linkForget);
            this.panLogin.Controls.Add(this.lblLOGO);
            this.panLogin.Controls.Add(this.btnSubmit);
            this.panLogin.Controls.Add(this.panUsername);
            this.panLogin.Controls.Add(this.panPassword);
            this.panLogin.Controls.Add(this.picPassword);
            this.panLogin.Controls.Add(this.picUsername);
            this.panLogin.Controls.Add(this.lblPassword);
            this.panLogin.Controls.Add(this.lblUsername);
            this.panLogin.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panLogin.Location = new System.Drawing.Point(60, 50);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(360, 440);
            this.panLogin.TabIndex = 0;
            this.panLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panLogin_Paint);
            // 
            // btnSignUp
            // 
            this.btnSignUp.AccessibleName = "Button";
            this.btnSignUp.BackColor = System.Drawing.Color.Teal;
            this.btnSignUp.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(8, 362);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(170, 47);
            this.btnSignUp.Style.BackColor = System.Drawing.Color.Teal;
            this.btnSignUp.Style.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.TabIndex = 11;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // tbtnRemember
            // 
            activeStateCollection2.Text = "Không ghi nhớ";
            this.tbtnRemember.ActiveState = activeStateCollection2;
            this.tbtnRemember.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnRemember.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection2.Text = "Ghi nhớ mật khẩu";
            this.tbtnRemember.InactiveState = inactiveStateCollection2;
            this.tbtnRemember.Location = new System.Drawing.Point(160, 309);
            this.tbtnRemember.MinimumSize = new System.Drawing.Size(52, 20);
            this.tbtnRemember.Name = "tbtnRemember";
            this.tbtnRemember.Size = new System.Drawing.Size(180, 40);
            this.tbtnRemember.Slider = sliderCollection2;
            this.tbtnRemember.TabIndex = 9;
            this.tbtnRemember.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(160, 312);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(170, 37);
            this.btnAdmin.Style.HoverBackColor = System.Drawing.Color.Teal;
            this.btnAdmin.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnAdmin.Style.HoverImageForeColor = System.Drawing.Color.White;
            this.btnAdmin.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnAdmin.Style.PressedBackColor = System.Drawing.Color.DarkCyan;
            this.btnAdmin.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnAdmin.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "Liên hệ Admin";
            this.btnAdmin.Visible = false;
            // 
            // linkForget
            // 
            this.linkForget.ActiveLinkColor = System.Drawing.Color.Teal;
            this.linkForget.AutoSize = true;
            this.linkForget.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForget.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkForget.Location = new System.Drawing.Point(62, 279);
            this.linkForget.Name = "linkForget";
            this.linkForget.Size = new System.Drawing.Size(167, 26);
            this.linkForget.TabIndex = 6;
            this.linkForget.TabStop = true;
            this.linkForget.Text = "Quên mật khẩu";
            this.linkForget.VisitedLinkColor = System.Drawing.Color.Purple;
            this.linkForget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForget_LinkClicked);
            // 
            // lblLOGO
            // 
            this.lblLOGO.BackColor = System.Drawing.Color.Transparent;
            this.lblLOGO.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOGO.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLOGO.Location = new System.Drawing.Point(32, 20);
            this.lblLOGO.Name = "lblLOGO";
            this.lblLOGO.Size = new System.Drawing.Size(298, 97);
            this.lblLOGO.TabIndex = 1;
            this.lblLOGO.Text = "THE AZURE HOTEL\r\nMANAGEMENT APP";
            this.lblLOGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleName = "Button";
            this.btnSubmit.BackColor = System.Drawing.Color.Teal;
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(184, 362);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(170, 47);
            this.btnSubmit.Style.BackColor = System.Drawing.Color.Teal;
            this.btnSubmit.Style.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.TabIndex = 10;
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
            this.txtUsername.BeforeTouchSize = new System.Drawing.Size(238, 22);
            this.txtUsername.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.FocusBorderColor = System.Drawing.Color.Black;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(9, 3);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(241, 22);
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
            this.btnShowHidePassword.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnShowHidePassword.TabIndex = 9;
            this.btnShowHidePassword.TextMargin = new System.Windows.Forms.Padding(0);
            this.btnShowHidePassword.Click += new System.EventHandler(this.btnShowHidePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BeforeTouchSize = new System.Drawing.Size(238, 22);
            this.txtPassword.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.FocusBorderColor = System.Drawing.Color.Black;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(11, 3);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(238, 22);
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
            this.lblPassword.BeforeTouchSize = new System.Drawing.Size(252, 33);
            this.lblPassword.BorderAppearance = System.Windows.Forms.BorderStyle.None;
            this.lblPassword.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblPassword.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Teal;
            this.lblPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassword.Location = new System.Drawing.Point(64, 198);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(252, 33);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.lblUsername.BeforeTouchSize = new System.Drawing.Size(252, 33);
            this.lblUsername.BorderAppearance = System.Windows.Forms.BorderStyle.None;
            this.lblUsername.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblUsername.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Teal;
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Location = new System.Drawing.Point(64, 117);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(252, 33);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.picLoginBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picLoginBG)).EndInit();
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtnRemember)).EndInit();
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
        private LinkLabel linkForget;
        private Syncfusion.WinForms.Controls.SfButton btnShowHidePassword;
        private Timer tmrTransistion;
        private Syncfusion.WinForms.Controls.SfButton btnAdmin;
        private Syncfusion.Windows.Forms.Tools.ToggleButton tbtnRemember;
        private Syncfusion.WinForms.Controls.SfButton btnSignUp;
    }
}

