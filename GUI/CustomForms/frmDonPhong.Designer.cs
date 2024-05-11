namespace GUI.customForm
{
    partial class frmDonPhong
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
            this.lblMaTB = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgayHuHong = new System.Windows.Forms.Label();
            this.lblNgayBaoTri = new System.Windows.Forms.Label();
            this.cboNVBaoTri = new Syncfusion.WinForms.ListView.SfComboBox();
            this.dtpNgayHuHong = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBaoTri = new System.Windows.Forms.DateTimePicker();
            this.cboThietBi = new Syncfusion.WinForms.ListView.SfComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cboNVBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(220, 198);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.btnSubmit, "Gửi");
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(28, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMaTB
            // 
            this.lblMaTB.AutoSize = true;
            this.lblMaTB.Location = new System.Drawing.Point(13, 22);
            this.lblMaTB.Name = "lblMaTB";
            this.lblMaTB.Size = new System.Drawing.Size(88, 20);
            this.lblMaTB.TabIndex = 1;
            this.lblMaTB.Text = "Mã phòng";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(13, 64);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(167, 20);
            this.lblMaNV.TabIndex = 3;
            this.lblMaNV.Text = "Nhân viên thực hiện";
            // 
            // lblNgayHuHong
            // 
            this.lblNgayHuHong.AutoSize = true;
            this.lblNgayHuHong.Location = new System.Drawing.Point(12, 107);
            this.lblNgayHuHong.Name = "lblNgayHuHong";
            this.lblNgayHuHong.Size = new System.Drawing.Size(119, 20);
            this.lblNgayHuHong.TabIndex = 5;
            this.lblNgayHuHong.Text = "Ngày hư hỏng";
            // 
            // lblNgayBaoTri
            // 
            this.lblNgayBaoTri.AutoSize = true;
            this.lblNgayBaoTri.Location = new System.Drawing.Point(12, 150);
            this.lblNgayBaoTri.Name = "lblNgayBaoTri";
            this.lblNgayBaoTri.Size = new System.Drawing.Size(105, 20);
            this.lblNgayBaoTri.TabIndex = 7;
            this.lblNgayBaoTri.Text = "Ngày bảo trì";
            // 
            // cboNVBaoTri
            // 
            this.cboNVBaoTri.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboNVBaoTri.Location = new System.Drawing.Point(205, 59);
            this.cboNVBaoTri.Name = "cboNVBaoTri";
            this.cboNVBaoTri.Size = new System.Drawing.Size(180, 27);
            this.cboNVBaoTri.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboNVBaoTri.TabIndex = 4;
            this.cboNVBaoTri.TabStop = false;
            // 
            // dtpNgayHuHong
            // 
            this.dtpNgayHuHong.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHuHong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHuHong.Location = new System.Drawing.Point(205, 102);
            this.dtpNgayHuHong.Name = "dtpNgayHuHong";
            this.dtpNgayHuHong.Size = new System.Drawing.Size(180, 26);
            this.dtpNgayHuHong.TabIndex = 6;
            // 
            // dtpNgayBaoTri
            // 
            this.dtpNgayBaoTri.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBaoTri.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBaoTri.Location = new System.Drawing.Point(205, 145);
            this.dtpNgayBaoTri.Name = "dtpNgayBaoTri";
            this.dtpNgayBaoTri.Size = new System.Drawing.Size(180, 26);
            this.dtpNgayBaoTri.TabIndex = 8;
            // 
            // cboThietBi
            // 
            this.cboThietBi.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboThietBi.Location = new System.Drawing.Point(205, 17);
            this.cboThietBi.Name = "cboThietBi";
            this.cboThietBi.Size = new System.Drawing.Size(180, 27);
            this.cboThietBi.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboThietBi.TabIndex = 2;
            this.cboThietBi.TabStop = false;
            // 
            // frmDonPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(397, 270);
            this.Controls.Add(this.cboThietBi);
            this.Controls.Add(this.dtpNgayBaoTri);
            this.Controls.Add(this.dtpNgayHuHong);
            this.Controls.Add(this.cboNVBaoTri);
            this.Controls.Add(this.lblNgayBaoTri);
            this.Controls.Add(this.lblNgayHuHong);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblMaTB);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDonPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDonPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboNVBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblMaTB;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNgayHuHong;
        private System.Windows.Forms.Label lblNgayBaoTri;
        private Syncfusion.WinForms.ListView.SfComboBox cboNVBaoTri;
        private System.Windows.Forms.DateTimePicker dtpNgayHuHong;
        private System.Windows.Forms.DateTimePicker dtpNgayBaoTri;
        private Syncfusion.WinForms.ListView.SfComboBox cboThietBi;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}