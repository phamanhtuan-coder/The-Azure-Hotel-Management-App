namespace GUI.UserControls
{
    partial class ucAccounting
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
            this.lbAccouting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAccouting
            // 
            this.lbAccouting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAccouting.BackColor = System.Drawing.Color.Transparent;
            this.lbAccouting.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAccouting.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbAccouting.Location = new System.Drawing.Point(428, 22);
            this.lbAccouting.Name = "lbAccouting";
            this.lbAccouting.Size = new System.Drawing.Size(570, 88);
            this.lbAccouting.TabIndex = 40;
            this.lbAccouting.Text = "KẾ TOÁN";
            this.lbAccouting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucAccounting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lbAccouting);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucAccounting";
            this.Size = new System.Drawing.Size(1370, 840);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbAccouting;
    }
}
