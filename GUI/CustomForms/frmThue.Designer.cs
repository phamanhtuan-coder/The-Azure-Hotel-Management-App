namespace GUI.customForm
{
    partial class frmThue
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
            this.lblTenThue = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
            this.lblMucThue = new System.Windows.Forms.Label();
            this.txtMucThue = new System.Windows.Forms.TextBox();
            this.nudMucThue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMucThue)).BeginInit();
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
            // lblTenThue
            // 
            this.lblTenThue.AutoSize = true;
            this.lblTenThue.Location = new System.Drawing.Point(58, 29);
            this.lblTenThue.Name = "lblTenThue";
            this.lblTenThue.Size = new System.Drawing.Size(84, 22);
            this.lblTenThue.TabIndex = 6;
            this.lblTenThue.Text = "Tên thuế";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(58, 146);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(57, 22);
            this.lblMoTa.TabIndex = 10;
            this.lblMoTa.Text = "Mô tả";
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.Location = new System.Drawing.Point(276, 143);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Size = new System.Drawing.Size(252, 96);
            this.rtxtMoTa.TabIndex = 11;
            this.rtxtMoTa.Text = "";
            // 
            // lblMucThue
            // 
            this.lblMucThue.AutoSize = true;
            this.lblMucThue.Location = new System.Drawing.Point(58, 83);
            this.lblMucThue.Name = "lblMucThue";
            this.lblMucThue.Size = new System.Drawing.Size(89, 22);
            this.lblMucThue.TabIndex = 8;
            this.lblMucThue.Text = "Mức thuế";
            // 
            // txtMucThue
            // 
            this.txtMucThue.Location = new System.Drawing.Point(276, 29);
            this.txtMucThue.Name = "txtMucThue";
            this.txtMucThue.Size = new System.Drawing.Size(252, 27);
            this.txtMucThue.TabIndex = 12;
            // 
            // nudMucThue
            // 
            this.nudMucThue.DecimalPlaces = 2;
            this.nudMucThue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMucThue.Location = new System.Drawing.Point(276, 84);
            this.nudMucThue.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMucThue.Name = "nudMucThue";
            this.nudMucThue.Size = new System.Drawing.Size(252, 27);
            this.nudMucThue.TabIndex = 13;
            this.nudMucThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmThue
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.nudMucThue);
            this.Controls.Add(this.txtMucThue);
            this.Controls.Add(this.rtxtMoTa);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblMucThue);
            this.Controls.Add(this.lblTenThue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMucThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.Label lblTenThue;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private System.Windows.Forms.Label lblMucThue;
        private System.Windows.Forms.TextBox txtMucThue;
        private System.Windows.Forms.NumericUpDown nudMucThue;
    }
}