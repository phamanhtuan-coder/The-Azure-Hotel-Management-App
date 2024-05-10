namespace GUI.customForm
{
    partial class frmThanhToan
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
            this.lblMaKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtTongHoaDon = new System.Windows.Forms.TextBox();
            this.nupNhan = new System.Windows.Forms.NumericUpDown();
            this.nupThoi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupThoi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(278, 156);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 45);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(90, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaKH.Location = new System.Drawing.Point(13, 17);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(124, 22);
            this.lblMaKH.TabIndex = 8;
            this.lblMaKH.Text = "Tổng hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Số tiền thối";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaNV.Location = new System.Drawing.Point(13, 64);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(116, 22);
            this.lblMaNV.TabIndex = 22;
            this.lblMaNV.Text = "Số tiền nhân";
            // 
            // txtTongHoaDon
            // 
            this.txtTongHoaDon.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtTongHoaDon.Location = new System.Drawing.Point(278, 12);
            this.txtTongHoaDon.Name = "txtTongHoaDon";
            this.txtTongHoaDon.ReadOnly = true;
            this.txtTongHoaDon.Size = new System.Drawing.Size(180, 27);
            this.txtTongHoaDon.TabIndex = 23;
            // 
            // nupNhan
            // 
            this.nupNhan.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupNhan.Location = new System.Drawing.Point(278, 60);
            this.nupNhan.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nupNhan.Name = "nupNhan";
            this.nupNhan.Size = new System.Drawing.Size(180, 26);
            this.nupNhan.TabIndex = 24;
            this.nupNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupNhan.ThousandsSeparator = true;
            this.nupNhan.ValueChanged += new System.EventHandler(this.nupNhan_ValueChanged);
            // 
            // nupThoi
            // 
            this.nupThoi.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupThoi.Location = new System.Drawing.Point(278, 106);
            this.nupThoi.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nupThoi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nupThoi.Name = "nupThoi";
            this.nupThoi.Size = new System.Drawing.Size(180, 26);
            this.nupThoi.TabIndex = 25;
            this.nupThoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupThoi.ThousandsSeparator = true;
            this.nupThoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // frmThanhToan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(485, 223);
            this.Controls.Add(this.nupThoi);
            this.Controls.Add(this.nupNhan);
            this.Controls.Add(this.txtTongHoaDon);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupThoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtTongHoaDon;
        private System.Windows.Forms.NumericUpDown nupNhan;
        private System.Windows.Forms.NumericUpDown nupThoi;
    }
}