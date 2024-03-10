namespace GUI.UserControls
{
    partial class ucBill
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
            this.lblBill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBill
            // 
            this.lblBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBill.BackColor = System.Drawing.Color.Transparent;
            this.lblBill.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBill.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBill.Location = new System.Drawing.Point(445, 12);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(570, 88);
            this.lblBill.TabIndex = 38;
            this.lblBill.Text = "HÓA ĐƠN";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucBill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblBill);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucBill";
            this.Size = new System.Drawing.Size(1370, 840);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBill;
    }
}
