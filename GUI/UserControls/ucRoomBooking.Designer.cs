namespace GUI.UserControls
{
    partial class ucRoomBooking
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
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.panController = new System.Windows.Forms.Panel();
            this.btnTraCuuRoomType = new Syncfusion.WinForms.Controls.SfButton();
            this.nudSucChua = new System.Windows.Forms.NumericUpDown();
            this.nudPriceMax = new System.Windows.Forms.NumericUpDown();
            this.nudPriceMin = new System.Windows.Forms.NumericUpDown();
            this.lblPriceRange = new System.Windows.Forms.Label();
            this.lblSortSucChua = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.dtpCheckInDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.panContent = new System.Windows.Forms.Panel();
            this.panController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMin)).BeginInit();
            this.panContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.AutoSize = true;
            this.flpRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpRoom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flpRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRoom.Location = new System.Drawing.Point(0, 0);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(1370, 771);
            this.flpRoom.TabIndex = 0;
            // 
            // panController
            // 
            this.panController.BackColor = System.Drawing.Color.Lavender;
            this.panController.Controls.Add(this.btnTraCuuRoomType);
            this.panController.Controls.Add(this.nudSucChua);
            this.panController.Controls.Add(this.nudPriceMax);
            this.panController.Controls.Add(this.nudPriceMin);
            this.panController.Controls.Add(this.lblPriceRange);
            this.panController.Controls.Add(this.lblSortSucChua);
            this.panController.Controls.Add(this.lblCheckInDate);
            this.panController.Controls.Add(this.dtpCheckInDate);
            this.panController.Dock = System.Windows.Forms.DockStyle.Top;
            this.panController.Location = new System.Drawing.Point(0, 0);
            this.panController.Name = "panController";
            this.panController.Size = new System.Drawing.Size(1370, 69);
            this.panController.TabIndex = 1;
            // 
            // btnTraCuuRoomType
            // 
            this.btnTraCuuRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuuRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuRoomType.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuRoomType.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRoomType.Location = new System.Drawing.Point(1100, 13);
            this.btnTraCuuRoomType.Name = "btnTraCuuRoomType";
            this.btnTraCuuRoomType.Size = new System.Drawing.Size(244, 40);
            this.btnTraCuuRoomType.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuRoomType.Style.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuRoomType.TabIndex = 38;
            this.btnTraCuuRoomType.Text = "Tra cứu";
            this.btnTraCuuRoomType.UseVisualStyleBackColor = false;
            this.btnTraCuuRoomType.Click += new System.EventHandler(this.btnTraCuuRoomType_Click);
            // 
            // nudSucChua
            // 
            this.nudSucChua.Location = new System.Drawing.Point(549, 21);
            this.nudSucChua.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudSucChua.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSucChua.Name = "nudSucChua";
            this.nudSucChua.Size = new System.Drawing.Size(54, 27);
            this.nudSucChua.TabIndex = 37;
            this.nudSucChua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSucChua.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPriceMax
            // 
            this.nudPriceMax.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudPriceMax.Location = new System.Drawing.Point(944, 21);
            this.nudPriceMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPriceMax.Name = "nudPriceMax";
            this.nudPriceMax.Size = new System.Drawing.Size(118, 27);
            this.nudPriceMax.TabIndex = 36;
            this.nudPriceMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPriceMax.ThousandsSeparator = true;
            this.nudPriceMax.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // nudPriceMin
            // 
            this.nudPriceMin.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudPriceMin.Location = new System.Drawing.Point(818, 21);
            this.nudPriceMin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPriceMin.Name = "nudPriceMin";
            this.nudPriceMin.Size = new System.Drawing.Size(110, 27);
            this.nudPriceMin.TabIndex = 35;
            this.nudPriceMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPriceMin.ThousandsSeparator = true;
            // 
            // lblPriceRange
            // 
            this.lblPriceRange.AutoSize = true;
            this.lblPriceRange.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceRange.Location = new System.Drawing.Point(670, 20);
            this.lblPriceRange.Name = "lblPriceRange";
            this.lblPriceRange.Size = new System.Drawing.Size(125, 26);
            this.lblPriceRange.TabIndex = 34;
            this.lblPriceRange.Text = "Khoảng giá";
            this.lblPriceRange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSortSucChua
            // 
            this.lblSortSucChua.AutoSize = true;
            this.lblSortSucChua.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortSucChua.Location = new System.Drawing.Point(440, 22);
            this.lblSortSucChua.Name = "lblSortSucChua";
            this.lblSortSucChua.Size = new System.Drawing.Size(103, 26);
            this.lblSortSucChua.TabIndex = 33;
            this.lblSortSucChua.Text = "Số người:";
            this.lblSortSucChua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInDate.Location = new System.Drawing.Point(44, 23);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(157, 26);
            this.lblCheckInDate.TabIndex = 15;
            this.lblCheckInDate.Text = "Ngày Check-In";
            this.lblCheckInDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpCheckInDate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckInDate.Location = new System.Drawing.Point(207, 22);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(155, 27);
            this.dtpCheckInDate.TabIndex = 14;
            this.dtpCheckInDate.ToolTipText = "";
            // 
            // panContent
            // 
            this.panContent.Controls.Add(this.flpRoom);
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(0, 69);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(1370, 771);
            this.panContent.TabIndex = 2;
            // 
            // ucRoomBooking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.panController);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucRoomBooking";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucRoomBooking_Load);
            this.panController.ResumeLayout(false);
            this.panController.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMin)).EndInit();
            this.panContent.ResumeLayout(false);
            this.panContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.Panel panController;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.Label lblCheckInDate;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpCheckInDate;
        private System.Windows.Forms.NumericUpDown nudSucChua;
        private System.Windows.Forms.NumericUpDown nudPriceMax;
        private System.Windows.Forms.NumericUpDown nudPriceMin;
        private System.Windows.Forms.Label lblPriceRange;
        private System.Windows.Forms.Label lblSortSucChua;
        private Syncfusion.WinForms.Controls.SfButton btnTraCuuRoomType;
    }
}
