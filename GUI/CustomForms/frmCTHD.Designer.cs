namespace GUI.customForm
{
    partial class frmCTHD
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
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.cboMaNV = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblMaKM = new System.Windows.Forms.Label();
            this.cboMaKM = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblMaDP = new System.Windows.Forms.Label();
            this.nudTongTien = new System.Windows.Forms.NumericUpDown();
            this.cboMaHD = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaHD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(294, 185);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(30, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(13, 22);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(108, 22);
            this.lblMaHD.TabIndex = 8;
            this.lblMaHD.Text = "Mã hóa đơn";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(13, 148);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(89, 22);
            this.lblTongTien.TabIndex = 13;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // cboMaNV
            // 
            this.cboMaNV.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboMaNV.Location = new System.Drawing.Point(278, 59);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(180, 27);
            this.cboMaNV.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaNV.TabIndex = 14;
            this.cboMaNV.TabStop = false;
            // 
            // lblMaKM
            // 
            this.lblMaKM.AutoSize = true;
            this.lblMaKM.Location = new System.Drawing.Point(13, 106);
            this.lblMaKM.Name = "lblMaKM";
            this.lblMaKM.Size = new System.Drawing.Size(141, 22);
            this.lblMaKM.TabIndex = 20;
            this.lblMaKM.Text = "Mã khuyến mãi";
            // 
            // cboMaKM
            // 
            this.cboMaKM.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboMaKM.Location = new System.Drawing.Point(278, 101);
            this.cboMaKM.Name = "cboMaKM";
            this.cboMaKM.Size = new System.Drawing.Size(180, 27);
            this.cboMaKM.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaKM.TabIndex = 21;
            this.cboMaKM.TabStop = false;
            // 
            // lblMaDP
            // 
            this.lblMaDP.AutoSize = true;
            this.lblMaDP.Location = new System.Drawing.Point(13, 64);
            this.lblMaDP.Name = "lblMaDP";
            this.lblMaDP.Size = new System.Drawing.Size(127, 22);
            this.lblMaDP.TabIndex = 22;
            this.lblMaDP.Text = "Mã đặt phòng";
            // 
            // nudTongTien
            // 
            this.nudTongTien.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTongTien.Location = new System.Drawing.Point(278, 143);
            this.nudTongTien.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudTongTien.Name = "nudTongTien";
            this.nudTongTien.Size = new System.Drawing.Size(180, 27);
            this.nudTongTien.TabIndex = 26;
            this.nudTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTongTien.ThousandsSeparator = true;
            // 
            // cboMaHD
            // 
            this.cboMaHD.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboMaHD.Location = new System.Drawing.Point(278, 17);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(180, 27);
            this.cboMaHD.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaHD.TabIndex = 27;
            this.cboMaHD.TabStop = false;
            // 
            // frmCTHD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(485, 257);
            this.Controls.Add(this.cboMaHD);
            this.Controls.Add(this.nudTongTien);
            this.Controls.Add(this.lblMaDP);
            this.Controls.Add(this.cboMaKM);
            this.Controls.Add(this.lblMaKM);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblTongTien;
        private Syncfusion.WinForms.ListView.SfComboBox cboMaNV;
        private System.Windows.Forms.Label lblMaKM;
        private Syncfusion.WinForms.ListView.SfComboBox cboMaKM;
        private System.Windows.Forms.Label lblMaDP;
        private System.Windows.Forms.NumericUpDown nudTongTien;
        private Syncfusion.WinForms.ListView.SfComboBox cboMaHD;
    }
}