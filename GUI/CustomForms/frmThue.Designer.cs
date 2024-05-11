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
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.lblTenThue = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
            this.lblMucThue = new System.Windows.Forms.Label();
            this.txtMucThue = new System.Windows.Forms.TextBox();
            this.nudMucThue = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudMucThue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(237, 250);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 43);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.btnSubmit, "Gửi");
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(87, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTenThue
            // 
            this.lblTenThue.AutoSize = true;
            this.lblTenThue.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblTenThue.Location = new System.Drawing.Point(16, 18);
            this.lblTenThue.Name = "lblTenThue";
            this.lblTenThue.Size = new System.Drawing.Size(84, 22);
            this.lblTenThue.TabIndex = 1;
            this.lblTenThue.Text = "Tên thuế";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.Location = new System.Drawing.Point(16, 127);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(57, 22);
            this.lblMoTa.TabIndex = 5;
            this.lblMoTa.Text = "Mô tả";
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.rtxtMoTa.Location = new System.Drawing.Point(159, 127);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Size = new System.Drawing.Size(252, 96);
            this.rtxtMoTa.TabIndex = 6;
            this.rtxtMoTa.Text = "";
            // 
            // lblMucThue
            // 
            this.lblMucThue.AutoSize = true;
            this.lblMucThue.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblMucThue.Location = new System.Drawing.Point(16, 73);
            this.lblMucThue.Name = "lblMucThue";
            this.lblMucThue.Size = new System.Drawing.Size(89, 22);
            this.lblMucThue.TabIndex = 3;
            this.lblMucThue.Text = "Mức thuế";
            // 
            // txtMucThue
            // 
            this.txtMucThue.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.txtMucThue.Location = new System.Drawing.Point(159, 13);
            this.txtMucThue.Name = "txtMucThue";
            this.txtMucThue.Size = new System.Drawing.Size(252, 27);
            this.txtMucThue.TabIndex = 2;
            // 
            // nudMucThue
            // 
            this.nudMucThue.DecimalPlaces = 2;
            this.nudMucThue.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.nudMucThue.Location = new System.Drawing.Point(159, 68);
            this.nudMucThue.Name = "nudMucThue";
            this.nudMucThue.Size = new System.Drawing.Size(252, 27);
            this.nudMucThue.TabIndex = 4;
            this.nudMucThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmThue
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(436, 317);
            this.Controls.Add(this.nudMucThue);
            this.Controls.Add(this.txtMucThue);
            this.Controls.Add(this.rtxtMoTa);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblMucThue);
            this.Controls.Add(this.lblTenThue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.ToolTip toolTip1;
    }
}