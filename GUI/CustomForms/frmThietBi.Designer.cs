namespace GUI.customForm
{
    partial class frmThietBi
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
            this.lblTenThietBi = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTenTrangThaiBi = new System.Windows.Forms.Label();
            this.txttenthietbi = new System.Windows.Forms.TextBox();
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
            // lblTenThietBi
            // 
            this.lblTenThietBi.AutoSize = true;
            this.lblTenThietBi.Location = new System.Drawing.Point(99, 80);
            this.lblTenThietBi.Name = "lblTenThietBi";
            this.lblTenThietBi.Size = new System.Drawing.Size(133, 27);
            this.lblTenThietBi.TabIndex = 6;
            this.lblTenThietBi.Text = "Tên thiết bị";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(257, 129);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(252, 35);
            this.cboTrangThai.TabIndex = 9;
            // 
            // lblTenTrangThaiBi
            // 
            this.lblTenTrangThaiBi.AutoSize = true;
            this.lblTenTrangThaiBi.Location = new System.Drawing.Point(99, 141);
            this.lblTenTrangThaiBi.Name = "lblTenTrangThaiBi";
            this.lblTenTrangThaiBi.Size = new System.Drawing.Size(119, 27);
            this.lblTenTrangThaiBi.TabIndex = 8;
            this.lblTenTrangThaiBi.Text = "Trạng thái";
            // 
            // txttenthietbi
            // 
            this.txttenthietbi.Location = new System.Drawing.Point(257, 80);
            this.txttenthietbi.Name = "txttenthietbi";
            this.txttenthietbi.Size = new System.Drawing.Size(252, 32);
            this.txttenthietbi.TabIndex = 12;
            // 
            // frmThietBi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(612, 350);
            this.Controls.Add(this.txttenthietbi);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.lblTenTrangThaiBi);
            this.Controls.Add(this.lblTenThietBi);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblTenThietBi;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblTenTrangThaiBi;
        private System.Windows.Forms.TextBox txttenthietbi;
    }
}