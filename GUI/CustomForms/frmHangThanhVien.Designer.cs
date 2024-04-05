﻿namespace GUI.customForm
{
    partial class frmHangThanhVien
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
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblChietKhau = new System.Windows.Forms.Label();
            this.nudChietKhau = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudChietKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(266, 44);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(306, 27);
            this.txtTenHang.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(358, 236);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(87, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Location = new System.Drawing.Point(52, 49);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(99, 22);
            this.lblTenHang.TabIndex = 6;
            this.lblTenHang.Text = "Tên vai trò";
            // 
            // lblChietKhau
            // 
            this.lblChietKhau.AutoSize = true;
            this.lblChietKhau.Location = new System.Drawing.Point(52, 142);
            this.lblChietKhau.Name = "lblChietKhau";
            this.lblChietKhau.Size = new System.Drawing.Size(140, 22);
            this.lblChietKhau.TabIndex = 7;
            this.lblChietKhau.Text = "Mức chiết khấu";
            // 
            // nudChietKhau
            // 
            this.nudChietKhau.DecimalPlaces = 2;
            this.nudChietKhau.Location = new System.Drawing.Point(266, 140);
            this.nudChietKhau.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudChietKhau.Name = "nudChietKhau";
            this.nudChietKhau.Size = new System.Drawing.Size(306, 27);
            this.nudChietKhau.TabIndex = 8;
            // 
            // frmHangThanhVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.nudChietKhau);
            this.Controls.Add(this.lblChietKhau);
            this.Controls.Add(this.lblTenHang);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTenHang);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHangThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudChietKhau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenHang;
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblChietKhau;
        private System.Windows.Forms.NumericUpDown nudChietKhau;
    }
}