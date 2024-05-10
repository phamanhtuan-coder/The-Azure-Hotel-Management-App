namespace GUI.customForm
{
    partial class frmHoaDon
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
            this.cboMaNV = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaThue = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.cboMaKM = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaKM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(252, 196);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(206, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(17, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(206, 50);
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
            this.lblMaKH.Size = new System.Drawing.Size(140, 22);
            this.lblMaKH.TabIndex = 8;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // cboMaNV
            // 
            this.cboMaNV.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboMaNV.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaNV.Location = new System.Drawing.Point(278, 54);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(180, 27);
            this.cboMaNV.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaNV.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaNV.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaNV.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaNV.TabIndex = 14;
            this.cboMaNV.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Chọn thuế";
            // 
            // cboMaThue
            // 
            this.cboMaThue.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboMaThue.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaThue.Location = new System.Drawing.Point(278, 101);
            this.cboMaThue.Name = "cboMaThue";
            this.cboMaThue.Size = new System.Drawing.Size(180, 27);
            this.cboMaThue.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaThue.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaThue.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaThue.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaThue.TabIndex = 21;
            this.cboMaThue.TabStop = false;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaNV.Location = new System.Drawing.Point(12, 59);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(143, 22);
            this.lblMaNV.TabIndex = 22;
            this.lblMaNV.Text = "Chọn nhân viên";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaKH.Location = new System.Drawing.Point(278, 12);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(180, 27);
            this.txtMaKH.TabIndex = 23;
            // 
            // cboMaKM
            // 
            this.cboMaKM.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboMaKM.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaKM.Location = new System.Drawing.Point(278, 150);
            this.cboMaKM.Name = "cboMaKM";
            this.cboMaKM.Size = new System.Drawing.Size(180, 27);
            this.cboMaKM.Style.EditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaKM.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaKM.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaKM.Style.TokenStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaKM.TabIndex = 30;
            this.cboMaKM.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Chọn khuyễn mãi";
            // 
            // frmHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(485, 276);
            this.Controls.Add(this.cboMaKM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.cboMaThue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaKM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblMaKH;
        private Syncfusion.WinForms.ListView.SfComboBox cboMaNV;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.ListView.SfComboBox cboMaThue;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private Syncfusion.WinForms.ListView.SfComboBox cboMaKM;
        private System.Windows.Forms.Label label2;
    }
}