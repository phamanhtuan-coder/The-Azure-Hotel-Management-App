namespace GUI.UserControls
{
    partial class ucStaff
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
            this.lblStaff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStaff
            // 
            this.lblStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaff.BackColor = System.Drawing.Color.Transparent;
            this.lblStaff.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaff.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblStaff.Location = new System.Drawing.Point(454, 17);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(570, 88);
            this.lblStaff.TabIndex = 39;
            this.lblStaff.Text = "NHÂN VIÊN";
            this.lblStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblStaff);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucStaff";
            this.Size = new System.Drawing.Size(1370, 840);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStaff;
    }
}
