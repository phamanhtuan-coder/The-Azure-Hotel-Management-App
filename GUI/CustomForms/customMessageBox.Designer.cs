namespace GUI.customForm
{
    partial class customMessageBox
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
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnOK = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(63, 29);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(556, 33);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "Bạn có muốn thoát chương trình này không?";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(448, 87);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(200, 40);
            this.btnOK.Style.BackColor = System.Drawing.Color.Green;
            this.btnOK.Style.FocusedBackColor = System.Drawing.Color.Green;
            this.btnOK.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnOK.Style.ForeColor = System.Drawing.Color.White;
            this.btnOK.Style.HoverForeColor = System.Drawing.Color.Green;
            this.btnOK.Style.PressedBackColor = System.Drawing.Color.DarkGreen;
            this.btnOK.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(129, 87);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 40);
            this.btnCancel.Style.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCancel.Style.FocusedBackColor = System.Drawing.Color.Goldenrod;
            this.btnCancel.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnCancel.Style.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Style.HoverBackColor = System.Drawing.Color.White;
            this.btnCancel.Style.HoverForeColor = System.Drawing.Color.Goldenrod;
            this.btnCancel.Style.PressedBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCancel.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // customMessageBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 150);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblThongBao);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "customMessageBox";
            this.Text = "customMessageBox";
            this.Load += new System.EventHandler(this.customMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongBao;
        private Syncfusion.WinForms.Controls.SfButton btnOK;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
    }
}