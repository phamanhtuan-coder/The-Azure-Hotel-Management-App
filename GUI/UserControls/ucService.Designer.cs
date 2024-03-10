namespace GUI.UserControls
{
    partial class ucService
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
            this.lblService = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblService
            // 
            this.lblService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblService.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblService.Location = new System.Drawing.Point(415, 15);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(570, 88);
            this.lblService.TabIndex = 37;
            this.lblService.Text = "DỊCH VỤ";
            this.lblService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucService
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblService);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucService";
            this.Size = new System.Drawing.Size(1370, 840);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblService;
    }
}
