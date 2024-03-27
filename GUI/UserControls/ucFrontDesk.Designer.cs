namespace GUI.UserControls
{
    partial class ucFrontDesk
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
            this.lblFrontDesk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFrontDesk
            // 
            this.lblFrontDesk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrontDesk.BackColor = System.Drawing.Color.Transparent;
            this.lblFrontDesk.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFrontDesk.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFrontDesk.Location = new System.Drawing.Point(406, 14);
            this.lblFrontDesk.Name = "lblFrontDesk";
            this.lblFrontDesk.Size = new System.Drawing.Size(570, 88);
            this.lblFrontDesk.TabIndex = 36;
            this.lblFrontDesk.Text = "LỄ TÂN";
            this.lblFrontDesk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucFrontDesk
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblFrontDesk);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucFrontDesk";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucFrontDesk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFrontDesk;
    }
}
