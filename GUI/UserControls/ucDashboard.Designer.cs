namespace GUI.UserControls
{
    partial class ucDashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panDuKienCount = new System.Windows.Forms.Panel();
            this.lblDuKienCount = new System.Windows.Forms.Label();
            this.panCheckOutCount = new System.Windows.Forms.Panel();
            this.lblCountCheckOut = new System.Windows.Forms.Label();
            this.panTotalCount = new System.Windows.Forms.Panel();
            this.lblCountTotal = new System.Windows.Forms.Label();
            this.panCheckInCount = new System.Windows.Forms.Panel();
            this.lblCountCheckIn = new System.Windows.Forms.Label();
            this.lblDashBoard = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panDuKienCount.SuspendLayout();
            this.panCheckOutCount.SuspendLayout();
            this.panTotalCount.SuspendLayout();
            this.panCheckInCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panDuKienCount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panCheckOutCount, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panTotalCount, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panCheckInCount, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 117);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 132);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // panDuKienCount
            // 
            this.panDuKienCount.BackColor = System.Drawing.Color.LightBlue;
            this.panDuKienCount.Controls.Add(this.lblDuKienCount);
            this.panDuKienCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDuKienCount.Location = new System.Drawing.Point(3, 3);
            this.panDuKienCount.Name = "panDuKienCount";
            this.panDuKienCount.Size = new System.Drawing.Size(336, 126);
            this.panDuKienCount.TabIndex = 27;
            // 
            // lblDuKienCount
            // 
            this.lblDuKienCount.BackColor = System.Drawing.Color.LightBlue;
            this.lblDuKienCount.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuKienCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDuKienCount.Location = new System.Drawing.Point(0, 33);
            this.lblDuKienCount.Name = "lblDuKienCount";
            this.lblDuKienCount.Size = new System.Drawing.Size(77, 75);
            this.lblDuKienCount.TabIndex = 1;
            this.lblDuKienCount.Text = "15";
            // 
            // panCheckOutCount
            // 
            this.panCheckOutCount.BackColor = System.Drawing.Color.LightBlue;
            this.panCheckOutCount.Controls.Add(this.lblCountCheckOut);
            this.panCheckOutCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCheckOutCount.Location = new System.Drawing.Point(687, 3);
            this.panCheckOutCount.Name = "panCheckOutCount";
            this.panCheckOutCount.Size = new System.Drawing.Size(336, 126);
            this.panCheckOutCount.TabIndex = 29;
            // 
            // lblCountCheckOut
            // 
            this.lblCountCheckOut.BackColor = System.Drawing.Color.LightBlue;
            this.lblCountCheckOut.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCheckOut.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCountCheckOut.Location = new System.Drawing.Point(-1, 33);
            this.lblCountCheckOut.Name = "lblCountCheckOut";
            this.lblCountCheckOut.Size = new System.Drawing.Size(91, 66);
            this.lblCountCheckOut.TabIndex = 1;
            this.lblCountCheckOut.Text = "05";
            // 
            // panTotalCount
            // 
            this.panTotalCount.BackColor = System.Drawing.Color.LightBlue;
            this.panTotalCount.Controls.Add(this.lblCountTotal);
            this.panTotalCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTotalCount.Location = new System.Drawing.Point(1029, 3);
            this.panTotalCount.Name = "panTotalCount";
            this.panTotalCount.Size = new System.Drawing.Size(338, 126);
            this.panTotalCount.TabIndex = 28;
            // 
            // lblCountTotal
            // 
            this.lblCountTotal.BackColor = System.Drawing.Color.LightBlue;
            this.lblCountTotal.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCountTotal.Location = new System.Drawing.Point(3, 33);
            this.lblCountTotal.Name = "lblCountTotal";
            this.lblCountTotal.Size = new System.Drawing.Size(90, 66);
            this.lblCountTotal.TabIndex = 1;
            this.lblCountTotal.Text = "20";
            // 
            // panCheckInCount
            // 
            this.panCheckInCount.BackColor = System.Drawing.Color.LightBlue;
            this.panCheckInCount.Controls.Add(this.lblCountCheckIn);
            this.panCheckInCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCheckInCount.Location = new System.Drawing.Point(345, 3);
            this.panCheckInCount.Name = "panCheckInCount";
            this.panCheckInCount.Size = new System.Drawing.Size(336, 126);
            this.panCheckInCount.TabIndex = 26;
            // 
            // lblCountCheckIn
            // 
            this.lblCountCheckIn.BackColor = System.Drawing.Color.LightBlue;
            this.lblCountCheckIn.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCheckIn.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCountCheckIn.Location = new System.Drawing.Point(3, 33);
            this.lblCountCheckIn.Name = "lblCountCheckIn";
            this.lblCountCheckIn.Size = new System.Drawing.Size(79, 66);
            this.lblCountCheckIn.TabIndex = 1;
            this.lblCountCheckIn.Text = "15";
            // 
            // lblDashBoard
            // 
            this.lblDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashBoard.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDashBoard.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDashBoard.Location = new System.Drawing.Point(400, 13);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(570, 88);
            this.lblDashBoard.TabIndex = 34;
            this.lblDashBoard.Text = "DASHBOARD";
            this.lblDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblDashBoard);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panDuKienCount.ResumeLayout(false);
            this.panCheckOutCount.ResumeLayout(false);
            this.panTotalCount.ResumeLayout(false);
            this.panCheckInCount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panDuKienCount;
        private System.Windows.Forms.Label lblDuKienCount;
        private System.Windows.Forms.Panel panCheckOutCount;
        private System.Windows.Forms.Label lblCountCheckOut;
        private System.Windows.Forms.Panel panTotalCount;
        private System.Windows.Forms.Label lblCountTotal;
        private System.Windows.Forms.Panel panCheckInCount;
        private System.Windows.Forms.Label lblCountCheckIn;
        private System.Windows.Forms.Label lblDashBoard;
    }
}
