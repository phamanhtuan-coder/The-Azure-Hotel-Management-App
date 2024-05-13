namespace GUI.customForm
{
    partial class frmTinhTrangPhong
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
            this.txtTenLP = new System.Windows.Forms.TextBox();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.lblTenLP = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtTenLP
            // 
            this.txtTenLP.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenLP.Location = new System.Drawing.Point(172, 17);
            this.txtTenLP.Name = "txtTenLP";
            this.txtTenLP.Size = new System.Drawing.Size(306, 27);
            this.txtTenLP.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(269, 191);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.btnSubmit, "Gửi");
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(64, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTenLP
            // 
            this.lblTenLP.AutoSize = true;
            this.lblTenLP.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblTenLP.Location = new System.Drawing.Point(12, 22);
            this.lblTenLP.Name = "lblTenLP";
            this.lblTenLP.Size = new System.Drawing.Size(134, 22);
            this.lblTenLP.TabIndex = 1;
            this.lblTenLP.Text = "Tên loại phòng";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.Location = new System.Drawing.Point(12, 66);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(57, 22);
            this.lblMoTa.TabIndex = 3;
            this.lblMoTa.Text = "Mô tả";
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.rtxtMoTa.Location = new System.Drawing.Point(172, 66);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Size = new System.Drawing.Size(306, 96);
            this.rtxtMoTa.TabIndex = 4;
            this.rtxtMoTa.Text = "";
            // 
            // frmTinhTrangPhong
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(508, 266);
            this.Controls.Add(this.rtxtMoTa);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTenLP);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTenLP);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTinhTrangPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTinhTrangPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenLP;
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblTenLP;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}