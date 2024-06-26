﻿namespace GUI.customForm
{
    partial class frmPhong
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
            this.btnChonHinh = new Syncfusion.WinForms.Controls.SfButton();
            this.picHinhPhong = new System.Windows.Forms.PictureBox();
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.lblTinhTrangPhong = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboTinhTrangPhong = new Syncfusion.WinForms.ListView.SfComboBox();
            this.nudGiaPhong = new System.Windows.Forms.NumericUpDown();
            this.nudSucChuaToiDa = new System.Windows.Forms.NumericUpDown();
            this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTinhTrangPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChuaToiDa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(568, 377);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.btnSubmit, "Gửi");
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(387, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonHinh.Location = new System.Drawing.Point(88, 312);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(150, 38);
            this.btnChonHinh.TabIndex = 1;
            this.btnChonHinh.Text = "Submit";
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // picHinhPhong
            // 
            this.picHinhPhong.Image = global::GUI.Properties.Resources.no_pictures;
            this.picHinhPhong.Location = new System.Drawing.Point(42, 28);
            this.picHinhPhong.Name = "picHinhPhong";
            this.picHinhPhong.Size = new System.Drawing.Size(248, 270);
            this.picHinhPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhPhong.TabIndex = 17;
            this.picHinhPhong.TabStop = false;
            this.picHinhPhong.Click += new System.EventHandler(this.picHinhPhong_Click);
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.Location = new System.Drawing.Point(328, 24);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(104, 22);
            this.lblMaLoai.TabIndex = 2;
            this.lblMaLoai.Text = "Loại phòng";
            // 
            // lblTinhTrangPhong
            // 
            this.lblTinhTrangPhong.AutoSize = true;
            this.lblTinhTrangPhong.Location = new System.Drawing.Point(328, 85);
            this.lblTinhTrangPhong.Name = "lblTinhTrangPhong";
            this.lblTinhTrangPhong.Size = new System.Drawing.Size(156, 22);
            this.lblTinhTrangPhong.TabIndex = 4;
            this.lblTinhTrangPhong.Text = "Tình trạng phòng";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(328, 143);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(96, 22);
            this.lblGia.TabIndex = 6;
            this.lblGia.Text = "Giá phòng";
            // 
            // lblSucChua
            // 
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Location = new System.Drawing.Point(328, 201);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(139, 22);
            this.lblSucChua.TabIndex = 8;
            this.lblSucChua.Text = "Sức chứa tối đa";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(328, 254);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(116, 22);
            this.lblMoTa.TabIndex = 10;
            this.lblMoTa.Text = "Mô tả phòng";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboLoaiPhong.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboLoaiPhong.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cboLoaiPhong.Location = new System.Drawing.Point(498, 16);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(220, 30);
            this.cboLoaiPhong.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cboLoaiPhong.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cboLoaiPhong.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboLoaiPhong.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cboLoaiPhong.TabIndex = 3;
            // 
            // cboTinhTrangPhong
            // 
            this.cboTinhTrangPhong.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboTinhTrangPhong.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboTinhTrangPhong.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cboTinhTrangPhong.Location = new System.Drawing.Point(498, 77);
            this.cboTinhTrangPhong.Name = "cboTinhTrangPhong";
            this.cboTinhTrangPhong.Size = new System.Drawing.Size(220, 30);
            this.cboTinhTrangPhong.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cboTinhTrangPhong.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cboTinhTrangPhong.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTinhTrangPhong.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cboTinhTrangPhong.TabIndex = 5;
            // 
            // nudGiaPhong
            // 
            this.nudGiaPhong.Font = new System.Drawing.Font("Montserrat", 12F);
            this.nudGiaPhong.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudGiaPhong.Location = new System.Drawing.Point(498, 138);
            this.nudGiaPhong.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.nudGiaPhong.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudGiaPhong.Name = "nudGiaPhong";
            this.nudGiaPhong.Size = new System.Drawing.Size(220, 27);
            this.nudGiaPhong.TabIndex = 7;
            this.nudGiaPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGiaPhong.ThousandsSeparator = true;
            this.nudGiaPhong.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // nudSucChuaToiDa
            // 
            this.nudSucChuaToiDa.Font = new System.Drawing.Font("Montserrat", 12F);
            this.nudSucChuaToiDa.Location = new System.Drawing.Point(498, 196);
            this.nudSucChuaToiDa.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudSucChuaToiDa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSucChuaToiDa.Name = "nudSucChuaToiDa";
            this.nudSucChuaToiDa.Size = new System.Drawing.Size(220, 27);
            this.nudSucChuaToiDa.TabIndex = 9;
            this.nudSucChuaToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSucChuaToiDa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.Font = new System.Drawing.Font("Montserrat", 12F);
            this.rtxtMoTa.Location = new System.Drawing.Point(498, 254);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Size = new System.Drawing.Size(220, 96);
            this.rtxtMoTa.TabIndex = 11;
            this.rtxtMoTa.Text = "";
            // 
            // frmPhong
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.rtxtMoTa);
            this.Controls.Add(this.nudSucChuaToiDa);
            this.Controls.Add(this.nudGiaPhong);
            this.Controls.Add(this.cboTinhTrangPhong);
            this.Controls.Add(this.cboLoaiPhong);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblSucChua);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTinhTrangPhong);
            this.Controls.Add(this.lblMaLoai);
            this.Controls.Add(this.picHinhPhong);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTinhTrangPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChuaToiDa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnChonHinh;
        private System.Windows.Forms.PictureBox picHinhPhong;
        private System.Windows.Forms.Label lblMaLoai;
        private System.Windows.Forms.Label lblTinhTrangPhong;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.Label lblMoTa;
        private Syncfusion.WinForms.ListView.SfComboBox cboLoaiPhong;
        private Syncfusion.WinForms.ListView.SfComboBox cboTinhTrangPhong;
        private System.Windows.Forms.NumericUpDown nudGiaPhong;
        private System.Windows.Forms.NumericUpDown nudSucChuaToiDa;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}