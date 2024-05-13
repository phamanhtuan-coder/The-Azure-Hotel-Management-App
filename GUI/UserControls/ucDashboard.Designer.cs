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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tlpThongKe = new System.Windows.Forms.TableLayoutPanel();
            this.panDuKienCount = new System.Windows.Forms.Panel();
            this.btnBooked = new Syncfusion.WinForms.Controls.SfButton();
            this.lblDuKienCount = new System.Windows.Forms.Label();
            this.panCheckOutCount = new System.Windows.Forms.Panel();
            this.btnOuted = new Syncfusion.WinForms.Controls.SfButton();
            this.lblCountCheckOut = new System.Windows.Forms.Label();
            this.panTotalCount = new System.Windows.Forms.Panel();
            this.btnCanceled = new Syncfusion.WinForms.Controls.SfButton();
            this.lblCountTotal = new System.Windows.Forms.Label();
            this.panCheckInCount = new System.Windows.Forms.Panel();
            this.btnChecked = new Syncfusion.WinForms.Controls.SfButton();
            this.lblCountCheckIn = new System.Windows.Forms.Label();
            this.lblDashBoard = new System.Windows.Forms.Label();
            this.spcThongKe = new System.Windows.Forms.SplitContainer();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flpRatings = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tlpThongKe.SuspendLayout();
            this.panDuKienCount.SuspendLayout();
            this.panCheckOutCount.SuspendLayout();
            this.panTotalCount.SuspendLayout();
            this.panCheckInCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcThongKe)).BeginInit();
            this.spcThongKe.Panel1.SuspendLayout();
            this.spcThongKe.Panel2.SuspendLayout();
            this.spcThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.flpRatings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpThongKe
            // 
            this.tlpThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpThongKe.ColumnCount = 4;
            this.tlpThongKe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThongKe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThongKe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThongKe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThongKe.Controls.Add(this.panDuKienCount, 0, 0);
            this.tlpThongKe.Controls.Add(this.panCheckOutCount, 2, 0);
            this.tlpThongKe.Controls.Add(this.panTotalCount, 3, 0);
            this.tlpThongKe.Controls.Add(this.panCheckInCount, 1, 0);
            this.tlpThongKe.Location = new System.Drawing.Point(0, 117);
            this.tlpThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.tlpThongKe.Name = "tlpThongKe";
            this.tlpThongKe.RowCount = 1;
            this.tlpThongKe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpThongKe.Size = new System.Drawing.Size(1370, 132);
            this.tlpThongKe.TabIndex = 33;
            // 
            // panDuKienCount
            // 
            this.panDuKienCount.BackColor = System.Drawing.Color.LightBlue;
            this.panDuKienCount.Controls.Add(this.btnBooked);
            this.panDuKienCount.Controls.Add(this.lblDuKienCount);
            this.panDuKienCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDuKienCount.Location = new System.Drawing.Point(3, 3);
            this.panDuKienCount.Name = "panDuKienCount";
            this.panDuKienCount.Size = new System.Drawing.Size(336, 126);
            this.panDuKienCount.TabIndex = 27;
            // 
            // btnBooked
            // 
            this.btnBooked.BackColor = System.Drawing.Color.LightBlue;
            this.btnBooked.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBooked.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBooked.Enabled = false;
            this.btnBooked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooked.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooked.ForeColor = System.Drawing.Color.Black;
            this.btnBooked.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBooked.Location = new System.Drawing.Point(0, 0);
            this.btnBooked.Name = "btnBooked";
            this.btnBooked.Size = new System.Drawing.Size(198, 126);
            this.btnBooked.Style.BackColor = System.Drawing.Color.LightBlue;
            this.btnBooked.Style.DisabledBackColor = System.Drawing.Color.LightBlue;
            this.btnBooked.Style.DisabledForeColor = System.Drawing.Color.Black;
            this.btnBooked.Style.DisabledImageForeColor = System.Drawing.Color.DarkOrange;
            this.btnBooked.Style.ForeColor = System.Drawing.Color.Black;
            this.btnBooked.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnBooked.Style.ImageForeColor = System.Drawing.Color.DarkOrange;
            this.btnBooked.TabIndex = 2;
            this.btnBooked.Text = "Số lượng đặt trước";
            this.btnBooked.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBooked.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBooked.UseVisualStyleBackColor = false;
            // 
            // lblDuKienCount
            // 
            this.lblDuKienCount.BackColor = System.Drawing.Color.LightBlue;
            this.lblDuKienCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDuKienCount.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuKienCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDuKienCount.Location = new System.Drawing.Point(204, 0);
            this.lblDuKienCount.Name = "lblDuKienCount";
            this.lblDuKienCount.Size = new System.Drawing.Size(132, 126);
            this.lblDuKienCount.TabIndex = 1;
            this.lblDuKienCount.Text = "15";
            this.lblDuKienCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblDuKienCount, "Số lượng đặt phòng có ngày đặt là hôm nay");
            // 
            // panCheckOutCount
            // 
            this.panCheckOutCount.BackColor = System.Drawing.Color.LightBlue;
            this.panCheckOutCount.Controls.Add(this.btnOuted);
            this.panCheckOutCount.Controls.Add(this.lblCountCheckOut);
            this.panCheckOutCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCheckOutCount.Location = new System.Drawing.Point(687, 3);
            this.panCheckOutCount.Name = "panCheckOutCount";
            this.panCheckOutCount.Size = new System.Drawing.Size(336, 126);
            this.panCheckOutCount.TabIndex = 29;
            // 
            // btnOuted
            // 
            this.btnOuted.BackColor = System.Drawing.Color.LightBlue;
            this.btnOuted.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOuted.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOuted.Enabled = false;
            this.btnOuted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOuted.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuted.ForeColor = System.Drawing.Color.Black;
            this.btnOuted.ImageSize = new System.Drawing.Size(64, 64);
            this.btnOuted.Location = new System.Drawing.Point(0, 0);
            this.btnOuted.Name = "btnOuted";
            this.btnOuted.Size = new System.Drawing.Size(208, 126);
            this.btnOuted.Style.BackColor = System.Drawing.Color.LightBlue;
            this.btnOuted.Style.DisabledBackColor = System.Drawing.Color.LightBlue;
            this.btnOuted.Style.DisabledForeColor = System.Drawing.Color.Black;
            this.btnOuted.Style.DisabledImageForeColor = System.Drawing.Color.DarkRed;
            this.btnOuted.Style.ForeColor = System.Drawing.Color.Black;
            this.btnOuted.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnOuted.Style.ImageForeColor = System.Drawing.Color.DarkRed;
            this.btnOuted.TabIndex = 4;
            this.btnOuted.Text = "Số lượng check-out";
            this.btnOuted.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOuted.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOuted.UseVisualStyleBackColor = false;
            // 
            // lblCountCheckOut
            // 
            this.lblCountCheckOut.BackColor = System.Drawing.Color.LightBlue;
            this.lblCountCheckOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCountCheckOut.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCheckOut.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCountCheckOut.Location = new System.Drawing.Point(214, 0);
            this.lblCountCheckOut.Name = "lblCountCheckOut";
            this.lblCountCheckOut.Size = new System.Drawing.Size(122, 126);
            this.lblCountCheckOut.TabIndex = 1;
            this.lblCountCheckOut.Text = "05";
            this.lblCountCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCountCheckOut, "Số lượng khách hàng đã check-out trong ngày");
            // 
            // panTotalCount
            // 
            this.panTotalCount.BackColor = System.Drawing.Color.LightBlue;
            this.panTotalCount.Controls.Add(this.btnCanceled);
            this.panTotalCount.Controls.Add(this.lblCountTotal);
            this.panTotalCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTotalCount.Location = new System.Drawing.Point(1029, 3);
            this.panTotalCount.Name = "panTotalCount";
            this.panTotalCount.Size = new System.Drawing.Size(338, 126);
            this.panTotalCount.TabIndex = 28;
            // 
            // btnCanceled
            // 
            this.btnCanceled.BackColor = System.Drawing.Color.LightBlue;
            this.btnCanceled.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCanceled.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCanceled.Enabled = false;
            this.btnCanceled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanceled.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanceled.ForeColor = System.Drawing.Color.Black;
            this.btnCanceled.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCanceled.Location = new System.Drawing.Point(0, 0);
            this.btnCanceled.Name = "btnCanceled";
            this.btnCanceled.Size = new System.Drawing.Size(190, 126);
            this.btnCanceled.Style.BackColor = System.Drawing.Color.LightBlue;
            this.btnCanceled.Style.DisabledBackColor = System.Drawing.Color.LightBlue;
            this.btnCanceled.Style.DisabledForeColor = System.Drawing.Color.Black;
            this.btnCanceled.Style.DisabledImageForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCanceled.Style.ForeColor = System.Drawing.Color.Black;
            this.btnCanceled.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnCanceled.Style.ImageForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCanceled.TabIndex = 5;
            this.btnCanceled.Text = "Số lượng đã hủy";
            this.btnCanceled.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCanceled.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCanceled.UseVisualStyleBackColor = false;
            // 
            // lblCountTotal
            // 
            this.lblCountTotal.BackColor = System.Drawing.Color.LightBlue;
            this.lblCountTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCountTotal.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCountTotal.Location = new System.Drawing.Point(196, 0);
            this.lblCountTotal.Name = "lblCountTotal";
            this.lblCountTotal.Size = new System.Drawing.Size(142, 126);
            this.lblCountTotal.TabIndex = 1;
            this.lblCountTotal.Text = "20";
            this.lblCountTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCountTotal, "Số lượng lịch đặt phòng đã hủy trong ngày hôm qua");
            // 
            // panCheckInCount
            // 
            this.panCheckInCount.BackColor = System.Drawing.Color.LightBlue;
            this.panCheckInCount.Controls.Add(this.btnChecked);
            this.panCheckInCount.Controls.Add(this.lblCountCheckIn);
            this.panCheckInCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCheckInCount.Location = new System.Drawing.Point(345, 3);
            this.panCheckInCount.Name = "panCheckInCount";
            this.panCheckInCount.Size = new System.Drawing.Size(336, 126);
            this.panCheckInCount.TabIndex = 26;
            // 
            // btnChecked
            // 
            this.btnChecked.BackColor = System.Drawing.Color.LightBlue;
            this.btnChecked.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChecked.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChecked.Enabled = false;
            this.btnChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChecked.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChecked.ForeColor = System.Drawing.Color.Black;
            this.btnChecked.ImageSize = new System.Drawing.Size(64, 64);
            this.btnChecked.Location = new System.Drawing.Point(0, 0);
            this.btnChecked.Name = "btnChecked";
            this.btnChecked.Size = new System.Drawing.Size(207, 126);
            this.btnChecked.Style.BackColor = System.Drawing.Color.LightBlue;
            this.btnChecked.Style.DisabledBackColor = System.Drawing.Color.LightBlue;
            this.btnChecked.Style.DisabledForeColor = System.Drawing.Color.Black;
            this.btnChecked.Style.DisabledImageForeColor = System.Drawing.Color.DarkGreen;
            this.btnChecked.Style.ForeColor = System.Drawing.Color.Black;
            this.btnChecked.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnChecked.Style.ImageForeColor = System.Drawing.Color.DarkGreen;
            this.btnChecked.TabIndex = 3;
            this.btnChecked.Text = "Số lượng check-in";
            this.btnChecked.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChecked.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChecked.UseVisualStyleBackColor = false;
            // 
            // lblCountCheckIn
            // 
            this.lblCountCheckIn.BackColor = System.Drawing.Color.LightBlue;
            this.lblCountCheckIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCountCheckIn.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCheckIn.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCountCheckIn.Location = new System.Drawing.Point(213, 0);
            this.lblCountCheckIn.Name = "lblCountCheckIn";
            this.lblCountCheckIn.Size = new System.Drawing.Size(123, 126);
            this.lblCountCheckIn.TabIndex = 1;
            this.lblCountCheckIn.Text = "15";
            this.lblCountCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCountCheckIn, "Số lượng khách hàng đã check-in trong ngày");
            // 
            // lblDashBoard
            // 
            this.lblDashBoard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashBoard.Font = new System.Drawing.Font("Montserrat ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDashBoard.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDashBoard.Location = new System.Drawing.Point(400, 13);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(570, 88);
            this.lblDashBoard.TabIndex = 1;
            this.lblDashBoard.Text = "DASHBOARD";
            this.lblDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spcThongKe
            // 
            this.spcThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spcThongKe.IsSplitterFixed = true;
            this.spcThongKe.Location = new System.Drawing.Point(0, 252);
            this.spcThongKe.Name = "spcThongKe";
            // 
            // spcThongKe.Panel1
            // 
            this.spcThongKe.Panel1.Controls.Add(this.chartThongKe);
            // 
            // spcThongKe.Panel2
            // 
            this.spcThongKe.Panel2.Controls.Add(this.flpRatings);
            this.spcThongKe.Size = new System.Drawing.Size(1370, 588);
            this.spcThongKe.SplitterDistance = 1021;
            this.spcThongKe.TabIndex = 37;
            // 
            // chartThongKe
            // 
            chartArea2.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea2);
            this.chartThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend2);
            this.chartThongKe.Location = new System.Drawing.Point(0, 0);
            this.chartThongKe.Name = "chartThongKe";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Tiền đặt phòng";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Tiền đặt dịch vụ";
            this.chartThongKe.Series.Add(series3);
            this.chartThongKe.Series.Add(series4);
            this.chartThongKe.Size = new System.Drawing.Size(1021, 588);
            this.chartThongKe.TabIndex = 1;
            this.toolTip1.SetToolTip(this.chartThongKe, "Thống kê thu nhập theo ngày");
            // 
            // flpRatings
            // 
            this.flpRatings.AutoScroll = true;
            this.flpRatings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpRatings.Controls.Add(this.panel1);
            this.flpRatings.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpRatings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRatings.Location = new System.Drawing.Point(7, 0);
            this.flpRatings.Margin = new System.Windows.Forms.Padding(0);
            this.flpRatings.Name = "flpRatings";
            this.flpRatings.Size = new System.Drawing.Size(338, 588);
            this.flpRatings.TabIndex = 37;
            this.toolTip1.SetToolTip(this.flpRatings, "HIển thi Top 15 đánh giá mới nhất");
            this.flpRatings.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 48);
            this.panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đánh giá của khách hàng";
            // 
            // ucDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.spcThongKe);
            this.Controls.Add(this.tlpThongKe);
            this.Controls.Add(this.lblDashBoard);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1370, 840);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            this.tlpThongKe.ResumeLayout(false);
            this.panDuKienCount.ResumeLayout(false);
            this.panCheckOutCount.ResumeLayout(false);
            this.panTotalCount.ResumeLayout(false);
            this.panCheckInCount.ResumeLayout(false);
            this.spcThongKe.Panel1.ResumeLayout(false);
            this.spcThongKe.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcThongKe)).EndInit();
            this.spcThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.flpRatings.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpThongKe;
        private System.Windows.Forms.Panel panDuKienCount;
        private System.Windows.Forms.Label lblDuKienCount;
        private System.Windows.Forms.Panel panCheckOutCount;
        private System.Windows.Forms.Label lblCountCheckOut;
        private System.Windows.Forms.Panel panTotalCount;
        private System.Windows.Forms.Label lblCountTotal;
        private System.Windows.Forms.Panel panCheckInCount;
        private System.Windows.Forms.Label lblCountCheckIn;
        private System.Windows.Forms.Label lblDashBoard;
        private Syncfusion.WinForms.Controls.SfButton btnBooked;
        private Syncfusion.WinForms.Controls.SfButton btnOuted;
        private Syncfusion.WinForms.Controls.SfButton btnCanceled;
        private Syncfusion.WinForms.Controls.SfButton btnChecked;
        private System.Windows.Forms.SplitContainer spcThongKe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.FlowLayoutPanel flpRatings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}