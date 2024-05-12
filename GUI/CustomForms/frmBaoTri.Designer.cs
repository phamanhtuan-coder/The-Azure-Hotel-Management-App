namespace GUI.customForm
{
    partial class frmBaoTri
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
            this.lblMaTB = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgayHuHong = new System.Windows.Forms.Label();
            this.lblNgayBaoTri = new System.Windows.Forms.Label();
            this.cboNVBaoTri = new Syncfusion.WinForms.ListView.SfComboBox();
            this.dtpNgayHuHong = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBaoTri = new System.Windows.Forms.DateTimePicker();
            this.cboThietBi = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cboNVBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(220, 198);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(28, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMaTB
            // 
            this.lblMaTB.AutoSize = true;
            this.lblMaTB.Location = new System.Drawing.Point(13, 22);
            this.lblMaTB.Name = "lblMaTB";
            this.lblMaTB.Size = new System.Drawing.Size(101, 22);
            this.lblMaTB.TabIndex = 6;
            this.lblMaTB.Text = "Mã thiết bị";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(13, 64);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(181, 22);
            this.lblMaNV.TabIndex = 8;
            this.lblMaNV.Text = "Nhân viên thực hiện";
            // 
            // lblNgayHuHong
            // 
            this.lblNgayHuHong.AutoSize = true;
            this.lblNgayHuHong.Location = new System.Drawing.Point(12, 107);
            this.lblNgayHuHong.Name = "lblNgayHuHong";
            this.lblNgayHuHong.Size = new System.Drawing.Size(129, 22);
            this.lblNgayHuHong.TabIndex = 10;
            this.lblNgayHuHong.Text = "Ngày hư hỏng";
            // 
            // lblNgayBaoTri
            // 
            this.lblNgayBaoTri.AutoSize = true;
            this.lblNgayBaoTri.Location = new System.Drawing.Point(12, 150);
            this.lblNgayBaoTri.Name = "lblNgayBaoTri";
            this.lblNgayBaoTri.Size = new System.Drawing.Size(114, 22);
            this.lblNgayBaoTri.TabIndex = 11;
            this.lblNgayBaoTri.Text = "Ngày bảo trì";
            // 
            // cboNVBaoTri
            // 
            this.cboNVBaoTri.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboNVBaoTri.Location = new System.Drawing.Point(205, 59);
            this.cboNVBaoTri.Name = "cboNVBaoTri";
            this.cboNVBaoTri.Size = new System.Drawing.Size(180, 27);
            this.cboNVBaoTri.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboNVBaoTri.TabIndex = 14;
            this.cboNVBaoTri.TabStop = false;
            // 
            // dtpNgayHuHong
            // 
            this.dtpNgayHuHong.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHuHong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHuHong.Location = new System.Drawing.Point(205, 102);
            this.dtpNgayHuHong.Name = "dtpNgayHuHong";
            this.dtpNgayHuHong.Size = new System.Drawing.Size(180, 27);
            this.dtpNgayHuHong.TabIndex = 17;
            // 
            // dtpNgayBaoTri
            // 
            this.dtpNgayBaoTri.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBaoTri.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBaoTri.Location = new System.Drawing.Point(205, 145);
            this.dtpNgayBaoTri.Name = "dtpNgayBaoTri";
            this.dtpNgayBaoTri.Size = new System.Drawing.Size(180, 27);
            this.dtpNgayBaoTri.TabIndex = 18;
            // 
            // cboThietBi
            // 
            this.cboThietBi.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboThietBi.Location = new System.Drawing.Point(205, 17);
            this.cboThietBi.Name = "cboThietBi";
            this.cboThietBi.Size = new System.Drawing.Size(180, 27);
            this.cboThietBi.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboThietBi.TabIndex = 19;
            this.cboThietBi.TabStop = false;
            // 
            // frmBaoTri
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.btnCancel;
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
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBaoTri_Load);
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
    }
}