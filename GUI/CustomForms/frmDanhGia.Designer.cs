namespace GUI.customForm
{
    partial class frmDanhGia
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
            Syncfusion.Windows.Forms.Tools.CustomImageCollection customImageCollection1 = new Syncfusion.Windows.Forms.Tools.CustomImageCollection();
            Syncfusion.Windows.Forms.Tools.ResetButton resetButton1 = new Syncfusion.Windows.Forms.Tools.ResetButton();
            this.txtMaDP = new System.Windows.Forms.TextBox();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.lbMaDP = new System.Windows.Forms.Label();
            this.lblNhanXet = new System.Windows.Forms.Label();
            this.rtxtNhanXet = new System.Windows.Forms.RichTextBox();
            this.lblDiemDanhGia = new System.Windows.Forms.Label();
            this.lblNgayDanhGia = new System.Windows.Forms.Label();
            this.rcDiemDG = new Syncfusion.Windows.Forms.Tools.RatingControl();
            this.dtpNgayDG = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtMaDP
            // 
            this.txtMaDP.Location = new System.Drawing.Point(266, 12);
            this.txtMaDP.Name = "txtMaDP";
            this.txtMaDP.Size = new System.Drawing.Size(306, 27);
            this.txtMaDP.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(362, 273);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(95, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbMaDP
            // 
            this.lbMaDP.AutoSize = true;
            this.lbMaDP.Location = new System.Drawing.Point(52, 17);
            this.lbMaDP.Name = "lbMaDP";
            this.lbMaDP.Size = new System.Drawing.Size(127, 22);
            this.lbMaDP.TabIndex = 6;
            this.lbMaDP.Text = "Mã đặt phòng";
            // 
            // lblNhanXet
            // 
            this.lblNhanXet.AutoSize = true;
            this.lblNhanXet.Location = new System.Drawing.Point(52, 156);
            this.lblNhanXet.Name = "lblNhanXet";
            this.lblNhanXet.Size = new System.Drawing.Size(87, 22);
            this.lblNhanXet.TabIndex = 7;
            this.lblNhanXet.Text = "Nhận xét";
            // 
            // rtxtNhanXet
            // 
            this.rtxtNhanXet.Location = new System.Drawing.Point(266, 156);
            this.rtxtNhanXet.Name = "rtxtNhanXet";
            this.rtxtNhanXet.Size = new System.Drawing.Size(306, 96);
            this.rtxtNhanXet.TabIndex = 8;
            this.rtxtNhanXet.Text = "";
            // 
            // lblDiemDanhGia
            // 
            this.lblDiemDanhGia.AutoSize = true;
            this.lblDiemDanhGia.Location = new System.Drawing.Point(52, 60);
            this.lblDiemDanhGia.Name = "lblDiemDanhGia";
            this.lblDiemDanhGia.Size = new System.Drawing.Size(134, 22);
            this.lblDiemDanhGia.TabIndex = 9;
            this.lblDiemDanhGia.Text = "Điểm đánh giá";
            // 
            // lblNgayDanhGia
            // 
            this.lblNgayDanhGia.AutoSize = true;
            this.lblNgayDanhGia.Location = new System.Drawing.Point(52, 112);
            this.lblNgayDanhGia.Name = "lblNgayDanhGia";
            this.lblNgayDanhGia.Size = new System.Drawing.Size(133, 22);
            this.lblNgayDanhGia.TabIndex = 10;
            this.lblNgayDanhGia.Text = "Ngày đánh giá";
            // 
            // rcDiemDG
            // 
            this.rcDiemDG.ApplyGradientColors = false;
            this.rcDiemDG.Images = customImageCollection1;
            this.rcDiemDG.Location = new System.Drawing.Point(266, 60);
            this.rcDiemDG.Name = "rcDiemDG";
            this.rcDiemDG.ResetButton = resetButton1;
            this.rcDiemDG.Size = new System.Drawing.Size(151, 27);
            this.rcDiemDG.TabIndex = 11;
            this.rcDiemDG.Text = "ratingControl1";
            this.rcDiemDG.ThemeName = "Default";
            // 
            // dtpNgayDG
            // 
            this.dtpNgayDG.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDG.Location = new System.Drawing.Point(266, 108);
            this.dtpNgayDG.Name = "dtpNgayDG";
            this.dtpNgayDG.Size = new System.Drawing.Size(306, 27);
            this.dtpNgayDG.TabIndex = 12;
            // 
            // frmDanhGia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.dtpNgayDG);
            this.Controls.Add(this.rcDiemDG);
            this.Controls.Add(this.lblNgayDanhGia);
            this.Controls.Add(this.lblDiemDanhGia);
            this.Controls.Add(this.rtxtNhanXet);
            this.Controls.Add(this.lblNhanXet);
            this.Controls.Add(this.lbMaDP);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMaDP);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDanhGia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaDP;
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lbMaDP;
        private System.Windows.Forms.Label lblNhanXet;
        private System.Windows.Forms.RichTextBox rtxtNhanXet;
        private System.Windows.Forms.Label lblDiemDanhGia;
        private System.Windows.Forms.Label lblNgayDanhGia;
        private Syncfusion.Windows.Forms.Tools.RatingControl rcDiemDG;
        private System.Windows.Forms.DateTimePicker dtpNgayDG;
    }
}