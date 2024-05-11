namespace GUI.customForm
{
    partial class frmVaiTro
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
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.lblTenVT = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtTenVT
            // 
            this.txtTenVT.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenVT.Location = new System.Drawing.Point(266, 44);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(306, 27);
            this.txtTenVT.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtTenVT, "Nhập tên vai trò");
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(361, 271);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.btnSubmit, "Gửi");
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(94, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Quay lại";
            this.toolTip1.SetToolTip(this.btnCancel, "Quai lại vai trò");
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTenVT
            // 
            this.lblTenVT.AutoSize = true;
            this.lblTenVT.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblTenVT.Location = new System.Drawing.Point(52, 49);
            this.lblTenVT.Name = "lblTenVT";
            this.lblTenVT.Size = new System.Drawing.Size(99, 22);
            this.lblTenVT.TabIndex = 6;
            this.lblTenVT.Text = "Tên vai trò";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.Location = new System.Drawing.Point(52, 117);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(57, 22);
            this.lblMoTa.TabIndex = 7;
            this.lblMoTa.Text = "Mô tả";
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.rtxtMoTa.Location = new System.Drawing.Point(266, 117);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Size = new System.Drawing.Size(306, 96);
            this.rtxtMoTa.TabIndex = 2;
            this.rtxtMoTa.Text = "";
            this.toolTip1.SetToolTip(this.rtxtMoTa, "Nhập mô tả");
            // 
            // frmVaiTro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.rtxtMoTa);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTenVT);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTenVT);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVaiTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmVaiTro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenVT;
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblTenVT;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}