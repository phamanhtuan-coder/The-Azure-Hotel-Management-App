namespace GUI.customForm
{
    partial class frmKhuyenMai
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
            this.lblTenKM = new System.Windows.Forms.Label();
            this.lblHangTV = new System.Windows.Forms.Label();
            this.lblMucKM = new System.Windows.Forms.Label();
            this.txtMucKM = new System.Windows.Forms.TextBox();
            this.nudMucKM = new System.Windows.Forms.NumericUpDown();
            this.cboHangTV = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMucKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHangTV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(327, 207);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(76, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTenKM
            // 
            this.lblTenKM.AutoSize = true;
            this.lblTenKM.Location = new System.Drawing.Point(46, 28);
            this.lblTenKM.Name = "lblTenKM";
            this.lblTenKM.Size = new System.Drawing.Size(146, 22);
            this.lblTenKM.TabIndex = 6;
            this.lblTenKM.Text = "Tên khuyến mãi";
            // 
            // lblHangTV
            // 
            this.lblHangTV.AutoSize = true;
            this.lblHangTV.Location = new System.Drawing.Point(46, 140);
            this.lblHangTV.Name = "lblHangTV";
            this.lblHangTV.Size = new System.Drawing.Size(234, 22);
            this.lblHangTV.TabIndex = 10;
            this.lblHangTV.Text = "Dành cho hạng thành viên";
            // 
            // lblMucKM
            // 
            this.lblMucKM.AutoSize = true;
            this.lblMucKM.Location = new System.Drawing.Point(46, 82);
            this.lblMucKM.Name = "lblMucKM";
            this.lblMucKM.Size = new System.Drawing.Size(151, 22);
            this.lblMucKM.TabIndex = 8;
            this.lblMucKM.Text = "Mức khuyến mãi";
            // 
            // txtMucKM
            // 
            this.txtMucKM.Location = new System.Drawing.Point(264, 28);
            this.txtMucKM.Name = "txtMucKM";
            this.txtMucKM.Size = new System.Drawing.Size(252, 27);
            this.txtMucKM.TabIndex = 12;
            // 
            // nudMucKM
            // 
            this.nudMucKM.DecimalPlaces = 2;
            this.nudMucKM.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMucKM.Location = new System.Drawing.Point(264, 83);
            this.nudMucKM.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMucKM.Name = "nudMucKM";
            this.nudMucKM.Size = new System.Drawing.Size(252, 27);
            this.nudMucKM.TabIndex = 13;
            this.nudMucKM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboHangTV
            // 
            this.cboHangTV.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboHangTV.Location = new System.Drawing.Point(303, 135);
            this.cboHangTV.Name = "cboHangTV";
            this.cboHangTV.Size = new System.Drawing.Size(213, 27);
            this.cboHangTV.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboHangTV.TabIndex = 14;
            this.cboHangTV.TabStop = false;
            // 
            // frmKhuyenMai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(562, 282);
            this.Controls.Add(this.cboHangTV);
            this.Controls.Add(this.nudMucKM);
            this.Controls.Add(this.txtMucKM);
            this.Controls.Add(this.lblHangTV);
            this.Controls.Add(this.lblMucKM);
            this.Controls.Add(this.lblTenKM);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMucKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHangTV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblTenKM;
        private System.Windows.Forms.Label lblHangTV;
        private System.Windows.Forms.Label lblMucKM;
        private System.Windows.Forms.TextBox txtMucKM;
        private System.Windows.Forms.NumericUpDown nudMucKM;
        private Syncfusion.WinForms.ListView.SfComboBox cboHangTV;
    }
}