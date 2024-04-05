namespace GUI.customForm
{
    partial class frmPhanQuyen
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
            this.lblTenVaiTro = new System.Windows.Forms.Label();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.cboTenPhongBan = new System.Windows.Forms.ComboBox();
            this.lblTenPhongBan = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(378, 271);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(62, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTenVaiTro
            // 
            this.lblTenVaiTro.AutoSize = true;
            this.lblTenVaiTro.Location = new System.Drawing.Point(58, 29);
            this.lblTenVaiTro.Name = "lblTenVaiTro";
            this.lblTenVaiTro.Size = new System.Drawing.Size(99, 22);
            this.lblTenVaiTro.TabIndex = 6;
            this.lblTenVaiTro.Text = "Tên vai trò";
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Location = new System.Drawing.Point(276, 21);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(252, 30);
            this.cboVaiTro.TabIndex = 7;
            // 
            // cboTenPhongBan
            // 
            this.cboTenPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenPhongBan.FormattingEnabled = true;
            this.cboTenPhongBan.Location = new System.Drawing.Point(276, 82);
            this.cboTenPhongBan.Name = "cboTenPhongBan";
            this.cboTenPhongBan.Size = new System.Drawing.Size(252, 30);
            this.cboTenPhongBan.TabIndex = 9;
            // 
            // lblTenPhongBan
            // 
            this.lblTenPhongBan.AutoSize = true;
            this.lblTenPhongBan.Location = new System.Drawing.Point(58, 90);
            this.lblTenPhongBan.Name = "lblTenPhongBan";
            this.lblTenPhongBan.Size = new System.Drawing.Size(136, 22);
            this.lblTenPhongBan.TabIndex = 8;
            this.lblTenPhongBan.Text = "Tên phòng ban";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(58, 143);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(57, 22);
            this.lblMoTa.TabIndex = 10;
            this.lblMoTa.Text = "Mô tả";
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.Location = new System.Drawing.Point(276, 143);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Size = new System.Drawing.Size(252, 96);
            this.rtxtMoTa.TabIndex = 11;
            this.rtxtMoTa.Text = "";
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.rtxtMoTa);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.cboTenPhongBan);
            this.Controls.Add(this.lblTenPhongBan);
            this.Controls.Add(this.cboVaiTro);
            this.Controls.Add(this.lblTenVaiTro);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblTenVaiTro;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.ComboBox cboTenPhongBan;
        private System.Windows.Forms.Label lblTenPhongBan;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
    }
}