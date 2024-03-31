namespace GUI.customForm
{
    partial class frmPhongBan
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
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.txtTruongPhong = new System.Windows.Forms.TextBox();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.dtpNgayNhanChuc = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.lblTenPB = new System.Windows.Forms.Label();
            this.lblTruongPhong = new System.Windows.Forms.Label();
            this.lblNgayNhanChuc = new System.Windows.Forms.Label();
            this.chkTruongPhong = new System.Windows.Forms.CheckBox();
            this.grpThongTinTruongPhong = new System.Windows.Forms.GroupBox();
            this.grpThongTinTruongPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(272, 19);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(306, 27);
            this.txtTenPB.TabIndex = 0;
            // 
            // txtTruongPhong
            // 
            this.txtTruongPhong.Location = new System.Drawing.Point(210, 41);
            this.txtTruongPhong.Name = "txtTruongPhong";
            this.txtTruongPhong.Size = new System.Drawing.Size(318, 27);
            this.txtTruongPhong.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(361, 271);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtpNgayNhanChuc
            // 
            this.dtpNgayNhanChuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhanChuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhanChuc.Location = new System.Drawing.Point(210, 91);
            this.dtpNgayNhanChuc.Name = "dtpNgayNhanChuc";
            this.dtpNgayNhanChuc.Size = new System.Drawing.Size(318, 27);
            this.dtpNgayNhanChuc.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(94, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTenPB
            // 
            this.lblTenPB.AutoSize = true;
            this.lblTenPB.Location = new System.Drawing.Point(58, 24);
            this.lblTenPB.Name = "lblTenPB";
            this.lblTenPB.Size = new System.Drawing.Size(136, 22);
            this.lblTenPB.TabIndex = 6;
            this.lblTenPB.Text = "Tên phòng ban";
            // 
            // lblTruongPhong
            // 
            this.lblTruongPhong.AutoSize = true;
            this.lblTruongPhong.Location = new System.Drawing.Point(8, 46);
            this.lblTruongPhong.Name = "lblTruongPhong";
            this.lblTruongPhong.Size = new System.Drawing.Size(136, 22);
            this.lblTruongPhong.TabIndex = 7;
            this.lblTruongPhong.Text = "Tên phòng ban";
            // 
            // lblNgayNhanChuc
            // 
            this.lblNgayNhanChuc.AutoSize = true;
            this.lblNgayNhanChuc.Location = new System.Drawing.Point(8, 95);
            this.lblNgayNhanChuc.Name = "lblNgayNhanChuc";
            this.lblNgayNhanChuc.Size = new System.Drawing.Size(147, 22);
            this.lblNgayNhanChuc.TabIndex = 8;
            this.lblNgayNhanChuc.Text = "Ngày nhận chức";
            // 
            // chkTruongPhong
            // 
            this.chkTruongPhong.AutoSize = true;
            this.chkTruongPhong.Location = new System.Drawing.Point(272, 59);
            this.chkTruongPhong.Name = "chkTruongPhong";
            this.chkTruongPhong.Size = new System.Drawing.Size(186, 26);
            this.chkTruongPhong.TabIndex = 9;
            this.chkTruongPhong.Text = "Có trưởng phòng ?";
            this.chkTruongPhong.UseVisualStyleBackColor = true;
            this.chkTruongPhong.CheckedChanged += new System.EventHandler(this.chkTruongPhong_CheckedChanged);
            // 
            // grpThongTinTruongPhong
            // 
            this.grpThongTinTruongPhong.Controls.Add(this.lblTruongPhong);
            this.grpThongTinTruongPhong.Controls.Add(this.txtTruongPhong);
            this.grpThongTinTruongPhong.Controls.Add(this.lblNgayNhanChuc);
            this.grpThongTinTruongPhong.Controls.Add(this.dtpNgayNhanChuc);
            this.grpThongTinTruongPhong.Location = new System.Drawing.Point(50, 98);
            this.grpThongTinTruongPhong.Name = "grpThongTinTruongPhong";
            this.grpThongTinTruongPhong.Size = new System.Drawing.Size(538, 145);
            this.grpThongTinTruongPhong.TabIndex = 10;
            this.grpThongTinTruongPhong.TabStop = false;
            this.grpThongTinTruongPhong.Text = "Thông tin trưởng phòng";
            // 
            // frmPhongBan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.grpThongTinTruongPhong);
            this.Controls.Add(this.chkTruongPhong);
            this.Controls.Add(this.lblTenPB);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTenPB);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.grpThongTinTruongPhong.ResumeLayout(false);
            this.grpThongTinTruongPhong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.TextBox txtTruongPhong;
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpNgayNhanChuc;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblTenPB;
        private System.Windows.Forms.Label lblTruongPhong;
        private System.Windows.Forms.Label lblNgayNhanChuc;
        private System.Windows.Forms.CheckBox chkTruongPhong;
        private System.Windows.Forms.GroupBox grpThongTinTruongPhong;
    }
}