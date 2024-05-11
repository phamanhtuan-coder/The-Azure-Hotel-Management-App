namespace GUI.UserControls
{
    partial class uc404
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(187, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1079, 132);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÂN QUYỀN CỦA BẠN MỚI ĐƯỢC TẠO HOẶC KHÔNG HỢP LỆ!\r\nVUI LÒNG LIÊN HỆ QUẢN TRỊ VIÊ" +
    "N/ QUẢN LÝ CỦA BẠN HOẶC\r\nĐĂNG NHẬP VÀO HỆ THỐNG LẠI BẰNG MỘT TÀI KHOẢN KHÁC!";
            // 
            // uc404
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "uc404";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.uc404_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}
