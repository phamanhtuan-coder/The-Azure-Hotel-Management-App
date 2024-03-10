namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            Syncfusion.Windows.Forms.Tools.DigitalClockRenderer digitalClockRenderer1 = new Syncfusion.Windows.Forms.Tools.DigitalClockRenderer();
            Syncfusion.Windows.Forms.Tools.ClockRenderer clockRenderer1 = new Syncfusion.Windows.Forms.Tools.ClockRenderer();
            this.panHeader = new System.Windows.Forms.Panel();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new Syncfusion.WinForms.Controls.SfButton();
            this.panWelcome = new System.Windows.Forms.Panel();
            this.lblHiUser = new System.Windows.Forms.Label();
            this.btnMinimize = new Syncfusion.WinForms.Controls.SfButton();
            this.realTimeClock = new Syncfusion.Windows.Forms.Tools.Clock();
            this.btnFullScreen = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.flpanSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panDashBoard = new System.Windows.Forms.Panel();
            this.btnDashBoard = new Syncfusion.WinForms.Controls.SfButton();
            this.panBooking = new System.Windows.Forms.Panel();
            this.btnBooking = new Syncfusion.WinForms.Controls.SfButton();
            this.panRoom = new System.Windows.Forms.Panel();
            this.btnRoom = new Syncfusion.WinForms.Controls.SfButton();
            this.panFrontDesk = new System.Windows.Forms.Panel();
            this.btnFrontDesk = new Syncfusion.WinForms.Controls.SfButton();
            this.panCustomer = new System.Windows.Forms.Panel();
            this.btnCustomer = new Syncfusion.WinForms.Controls.SfButton();
            this.panSetup = new System.Windows.Forms.Panel();
            this.btnSetup = new Syncfusion.WinForms.Controls.SfButton();
            this.panService = new System.Windows.Forms.Panel();
            this.btnService = new Syncfusion.WinForms.Controls.SfButton();
            this.panBill = new System.Windows.Forms.Panel();
            this.btnHoaDon = new Syncfusion.WinForms.Controls.SfButton();
            this.panAccounting = new System.Windows.Forms.Panel();
            this.btnAccounting = new Syncfusion.WinForms.Controls.SfButton();
            this.panStaff = new System.Windows.Forms.Panel();
            this.btnStaff = new Syncfusion.WinForms.Controls.SfButton();
            this.panLogOut = new System.Windows.Forms.Panel();
            this.btnLogOut = new Syncfusion.WinForms.Controls.SfButton();
            this.panDesktop = new System.Windows.Forms.Panel();
            this.tmrSideBar = new System.Windows.Forms.Timer(this.components);
            this.cpicProfile = new GUI.CircularPictureBox();
            this.panHeader.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.panWelcome.SuspendLayout();
            this.flpanSideBar.SuspendLayout();
            this.panDashBoard.SuspendLayout();
            this.panBooking.SuspendLayout();
            this.panRoom.SuspendLayout();
            this.panFrontDesk.SuspendLayout();
            this.panCustomer.SuspendLayout();
            this.panSetup.SuspendLayout();
            this.panService.SuspendLayout();
            this.panBill.SuspendLayout();
            this.panAccounting.SuspendLayout();
            this.panStaff.SuspendLayout();
            this.panLogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpicProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panHeader.Controls.Add(this.panMenu);
            this.panHeader.Controls.Add(this.panWelcome);
            this.panHeader.Controls.Add(this.btnMinimize);
            this.panHeader.Controls.Add(this.realTimeClock);
            this.panHeader.Controls.Add(this.btnFullScreen);
            this.panHeader.Controls.Add(this.btnClose);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(2, 2);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1596, 50);
            this.panHeader.TabIndex = 0;
            this.panHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panHeader_MouseDown);
            // 
            // panMenu
            // 
            this.panMenu.Controls.Add(this.btnMenu);
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.MaximumSize = new System.Drawing.Size(220, 50);
            this.panMenu.MinimumSize = new System.Drawing.Size(45, 50);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(220, 50);
            this.panMenu.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.AccessibleName = "Button";
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenu.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.ImageSize = new System.Drawing.Size(32, 32);
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(220, 50);
            this.btnMenu.Style.BackColor = System.Drawing.Color.Teal;
            this.btnMenu.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnMenu.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnMenu.Style.FocusedImageForeColor = System.Drawing.Color.White;
            this.btnMenu.Style.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Style.HoverBackColor = System.Drawing.Color.White;
            this.btnMenu.Style.HoverForeColor = System.Drawing.Color.Teal;
            this.btnMenu.Style.HoverImageForeColor = System.Drawing.Color.Teal;
            this.btnMenu.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnMenu.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnMenu.Style.PressedBackColor = System.Drawing.Color.DarkCyan;
            this.btnMenu.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Activate);
            // 
            // panWelcome
            // 
            this.panWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panWelcome.Controls.Add(this.lblHiUser);
            this.panWelcome.Controls.Add(this.cpicProfile);
            this.panWelcome.Location = new System.Drawing.Point(947, 3);
            this.panWelcome.Name = "panWelcome";
            this.panWelcome.Size = new System.Drawing.Size(393, 47);
            this.panWelcome.TabIndex = 0;
            // 
            // lblHiUser
            // 
            this.lblHiUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHiUser.ForeColor = System.Drawing.Color.White;
            this.lblHiUser.Location = new System.Drawing.Point(0, 0);
            this.lblHiUser.Name = "lblHiUser";
            this.lblHiUser.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblHiUser.Size = new System.Drawing.Size(337, 50);
            this.lblHiUser.TabIndex = 1;
            this.lblHiUser.Text = "Xin chào User,\r\nChúc bạn một ngày làm việc vui vẻ!\r\n";
            this.lblHiUser.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AccessibleName = "Button";
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Yellow;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnMinimize.ImageSize = new System.Drawing.Size(32, 32);
            this.btnMinimize.Location = new System.Drawing.Point(1446, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.Style.BackColor = System.Drawing.Color.Yellow;
            this.btnMinimize.Style.DisabledBackColor = System.Drawing.Color.White;
            this.btnMinimize.Style.DisabledForeColor = System.Drawing.Color.White;
            this.btnMinimize.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnMinimize.Style.FocusedForeColor = System.Drawing.Color.Yellow;
            this.btnMinimize.Style.FocusedImageForeColor = System.Drawing.Color.Yellow;
            this.btnMinimize.Style.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Style.HoverBackColor = System.Drawing.Color.DarkCyan;
            this.btnMinimize.Style.HoverForeColor = System.Drawing.Color.Yellow;
            this.btnMinimize.Style.HoverImageForeColor = System.Drawing.Color.Yellow;
            this.btnMinimize.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnMinimize.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnMinimize.Style.PressedBackColor = System.Drawing.Color.Yellow;
            this.btnMinimize.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnMinimize.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnMinimize.TabIndex = 32;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // realTimeClock
            // 
            this.realTimeClock.AlignAMorPM = Syncfusion.Windows.Forms.Tools.Align.Bottom;
            this.realTimeClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.realTimeClock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.realTimeClock.BeforeTouchSize = new System.Drawing.Size(100, 50);
            this.realTimeClock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(119)))));
            this.realTimeClock.ClockFormat = "HH:mm:ss";
            this.realTimeClock.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.SquareFrame;
            this.realTimeClock.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.RoundedRectangle;
            this.realTimeClock.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Digital;
            this.realTimeClock.CurrentDateTime = new System.DateTime(2024, 3, 9, 23, 55, 38, 42);
            this.realTimeClock.CustomTime = new System.DateTime(2024, 3, 10, 16, 16, 24, 573);
            this.realTimeClock.DigitalRenderer = digitalClockRenderer1;
            this.realTimeClock.DisplayDates = false;
            this.realTimeClock.Location = new System.Drawing.Point(1343, 0);
            this.realTimeClock.Margin = new System.Windows.Forms.Padding(0);
            this.realTimeClock.MaximumSize = new System.Drawing.Size(100, 50);
            this.realTimeClock.MinimumSize = new System.Drawing.Size(50, 50);
            this.realTimeClock.MinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(119)))));
            this.realTimeClock.Name = "realTimeClock";
            this.realTimeClock.Now = new System.DateTime(((long)(0)));
            this.realTimeClock.Remainder = new System.DateTime(2024, 3, 9, 23, 55, 38, 34);
            this.realTimeClock.Renderer = clockRenderer1;
            this.realTimeClock.ShowClockFrame = false;
            this.realTimeClock.ShowCustomTimeClock = true;
            this.realTimeClock.ShowHourDesignator = false;
            this.realTimeClock.Size = new System.Drawing.Size(100, 50);
            this.realTimeClock.StopTimer = false;
            this.realTimeClock.TabIndex = 0;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.AccessibleName = "Button";
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreen.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnFullScreen.ImageSize = new System.Drawing.Size(32, 32);
            this.btnFullScreen.Location = new System.Drawing.Point(1496, 0);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(50, 50);
            this.btnFullScreen.Style.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFullScreen.Style.DisabledBackColor = System.Drawing.Color.White;
            this.btnFullScreen.Style.DisabledForeColor = System.Drawing.Color.White;
            this.btnFullScreen.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnFullScreen.Style.FocusedForeColor = System.Drawing.Color.LimeGreen;
            this.btnFullScreen.Style.FocusedImageForeColor = System.Drawing.Color.LimeGreen;
            this.btnFullScreen.Style.ForeColor = System.Drawing.Color.White;
            this.btnFullScreen.Style.HoverBackColor = System.Drawing.Color.DarkCyan;
            this.btnFullScreen.Style.HoverForeColor = System.Drawing.Color.LimeGreen;
            this.btnFullScreen.Style.HoverImageForeColor = System.Drawing.Color.LimeGreen;
            this.btnFullScreen.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnFullScreen.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnFullScreen.Style.PressedBackColor = System.Drawing.Color.LimeGreen;
            this.btnFullScreen.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnFullScreen.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnFullScreen.TabIndex = 31;
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.Location = new System.Drawing.Point(1546, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.Style.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Style.DisabledBackColor = System.Drawing.Color.White;
            this.btnClose.Style.DisabledForeColor = System.Drawing.Color.White;
            this.btnClose.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.Style.FocusedForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Style.FocusedImageForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Style.ForeColor = System.Drawing.Color.White;
            this.btnClose.Style.HoverBackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.Style.HoverForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Style.HoverImageForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnClose.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnClose.Style.PressedBackColor = System.Drawing.Color.Maroon;
            this.btnClose.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnClose.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnClose.TabIndex = 30;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // flpanSideBar
            // 
            this.flpanSideBar.BackColor = System.Drawing.Color.Teal;
            this.flpanSideBar.Controls.Add(this.panDashBoard);
            this.flpanSideBar.Controls.Add(this.panBooking);
            this.flpanSideBar.Controls.Add(this.panRoom);
            this.flpanSideBar.Controls.Add(this.panFrontDesk);
            this.flpanSideBar.Controls.Add(this.panCustomer);
            this.flpanSideBar.Controls.Add(this.panSetup);
            this.flpanSideBar.Controls.Add(this.panService);
            this.flpanSideBar.Controls.Add(this.panBill);
            this.flpanSideBar.Controls.Add(this.panAccounting);
            this.flpanSideBar.Controls.Add(this.panStaff);
            this.flpanSideBar.Controls.Add(this.panLogOut);
            this.flpanSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpanSideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpanSideBar.Location = new System.Drawing.Point(2, 52);
            this.flpanSideBar.Name = "flpanSideBar";
            this.flpanSideBar.Size = new System.Drawing.Size(220, 846);
            this.flpanSideBar.TabIndex = 1;
            // 
            // panDashBoard
            // 
            this.panDashBoard.Controls.Add(this.btnDashBoard);
            this.panDashBoard.Location = new System.Drawing.Point(0, 0);
            this.panDashBoard.Margin = new System.Windows.Forms.Padding(0);
            this.panDashBoard.Name = "panDashBoard";
            this.panDashBoard.Size = new System.Drawing.Size(220, 50);
            this.panDashBoard.TabIndex = 1;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.AccessibleName = "Button";
            this.btnDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDashBoard.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDashBoard.Location = new System.Drawing.Point(0, 0);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(220, 50);
            this.btnDashBoard.Style.BackColor = System.Drawing.Color.Teal;
            this.btnDashBoard.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnDashBoard.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Style.FocusedImageForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Style.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Style.HoverBackColor = System.Drawing.Color.White;
            this.btnDashBoard.Style.HoverForeColor = System.Drawing.Color.Teal;
            this.btnDashBoard.Style.HoverImageForeColor = System.Drawing.Color.Teal;
            this.btnDashBoard.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnDashBoard.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Style.PressedBackColor = System.Drawing.Color.DarkCyan;
            this.btnDashBoard.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnDashBoard.TabIndex = 1;
            this.btnDashBoard.Text = "Dashboard";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // panBooking
            // 
            this.panBooking.Controls.Add(this.btnBooking);
            this.panBooking.Location = new System.Drawing.Point(0, 50);
            this.panBooking.Margin = new System.Windows.Forms.Padding(0);
            this.panBooking.Name = "panBooking";
            this.panBooking.Size = new System.Drawing.Size(220, 50);
            this.panBooking.TabIndex = 2;
            // 
            // btnBooking
            // 
            this.btnBooking.AccessibleName = "Button";
            this.btnBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBooking.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnBooking.Location = new System.Drawing.Point(0, 0);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(220, 50);
            this.btnBooking.Style.BackColor = System.Drawing.Color.Teal;
            this.btnBooking.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnBooking.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnBooking.Style.FocusedImageForeColor = System.Drawing.Color.White;
            this.btnBooking.Style.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Style.HoverBackColor = System.Drawing.Color.White;
            this.btnBooking.Style.HoverForeColor = System.Drawing.Color.Teal;
            this.btnBooking.Style.HoverImageForeColor = System.Drawing.Color.Teal;
            this.btnBooking.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnBooking.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnBooking.Style.PressedBackColor = System.Drawing.Color.DarkCyan;
            this.btnBooking.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnBooking.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "Booking";
            this.btnBooking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // panRoom
            // 
            this.panRoom.Controls.Add(this.btnRoom);
            this.panRoom.Location = new System.Drawing.Point(0, 100);
            this.panRoom.Margin = new System.Windows.Forms.Padding(0);
            this.panRoom.Name = "panRoom";
            this.panRoom.Size = new System.Drawing.Size(220, 50);
            this.panRoom.TabIndex = 4;
            // 
            // btnRoom
            // 
            this.btnRoom.AccessibleName = "Button";
            this.btnRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRoom.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRoom.Location = new System.Drawing.Point(0, 0);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(220, 50);
            this.btnRoom.Style.BackColor = System.Drawing.Color.Teal;
            this.btnRoom.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnRoom.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnRoom.Style.FocusedImageForeColor = System.Drawing.Color.White;
            this.btnRoom.Style.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Style.HoverBackColor = System.Drawing.Color.White;
            this.btnRoom.Style.HoverForeColor = System.Drawing.Color.Teal;
            this.btnRoom.Style.HoverImageForeColor = System.Drawing.Color.Teal;
            this.btnRoom.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.btnRoom.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnRoom.Style.PressedBackColor = System.Drawing.Color.DarkCyan;
            this.btnRoom.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnRoom.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnRoom.TabIndex = 4;
            this.btnRoom.Text = "Phòng";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // panFrontDesk
            // 
            this.panFrontDesk.Controls.Add(this.btnFrontDesk);
            this.panFrontDesk.Location = new System.Drawing.Point(0, 150);
            this.panFrontDesk.Margin = new System.Windows.Forms.Padding(0);
            this.panFrontDesk.Name = "panFrontDesk";
            this.panFrontDesk.Size = new System.Drawing.Size(220, 50);
            this.panFrontDesk.TabIndex = 3;
            // 
            // btnFrontDesk
            // 
            this.btnFrontDesk.AccessibleName = "Button";
            this.btnFrontDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFrontDesk.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrontDesk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrontDesk.ImageSize = new System.Drawing.Size(32, 32);
            this.btnFrontDesk.Location = new System.Drawing.Point(0, 0);
            this.btnFrontDesk.Name = "btnFrontDesk";
            this.btnFrontDesk.Size = new System.Drawing.Size(220, 50);
            this.btnFrontDesk.Style.BackColor = System.Drawing.Color.Teal;
            this.btnFrontDesk.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnFrontDesk.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnFrontDesk.Style.FocusedImageForeColor = System.Drawing.Color.White;
            this.btnFrontDesk.Style.ForeColor = System.Drawing.Color.White;
            this.btnFrontDesk.Style.HoverBackColor = System.Drawing.Color.White;
            this.btnFrontDesk.Style.HoverForeColor = System.Drawing.Color.Teal;
            this.btnFrontDesk.Style.HoverImageForeColor = System.Drawing.Color.Teal;
            this.btnFrontDesk.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.btnFrontDesk.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnFrontDesk.Style.PressedBackColor = System.Drawing.Color.DarkCyan;
            this.btnFrontDesk.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnFrontDesk.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnFrontDesk.TabIndex = 3;
            this.btnFrontDesk.Text = "Lễ tân";
            this.btnFrontDesk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFrontDesk.Click += new System.EventHandler(this.btnFrontDesk_Click);
            // 
            // panCustomer
            // 
            this.panCustomer.Controls.Add(this.btnCustomer);
            this.panCustomer.Location = new System.Drawing.Point(0, 200);
            this.panCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.panCustomer.Name = "panCustomer";
            this.panCustomer.Size = new System.Drawing.Size(220, 50);
            this.panCustomer.TabIndex = 5;
            // 
            // btnCustomer
            // 
            this.btnCustomer.AccessibleName = "Button";
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomer.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(220, 50);
            this.btnCustomer.Style.BackColor = System.Drawing.Color.Teal;
            this.btnCustomer.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnCustomer.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnCustomer.Style.FocusedImageForeColor = System.Drawing.Color.White;
            this.btnCustomer.Style.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Style.HoverBackColor = System.Drawing.Color.White;
            this.btnCustomer.Style.HoverForeColor = System.Drawing.Color.Teal;
            this.btnCustomer.Style.HoverImageForeColor = System.Drawing.Color.Teal;
            this.btnCustomer.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            this.btnCustomer.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnCustomer.Style.PressedBackColor = System.Drawing.Color.DarkCyan;
            this.btnCustomer.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnCustomer.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panSetup
            // 
            this.panSetup.Controls.Add(this.btnSetup);
            this.panSetup.Location = new System.Drawing.Point(0, 250);
            this.panSetup.Margin = new System.Windows.Forms.Padding(0);
            this.panSetup.Name = "panSetup";
            this.panSetup.Size = new System.Drawing.Size(220, 50);
            this.panSetup.TabIndex = 6;
            // 
            // btnSetup
            // 
            this.btnSetup.AccessibleName = "Button";
            this.btnSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetup.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetup.ImageSize = new System.Drawing.Size(32, 32);
            this.btnSetup.Location = new System.Drawing.Point(0, 0);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(220, 50);
            this.btnSetup.Style.BackColor = System.Drawing.Color.Teal;
            this.btnSetup.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnSetup.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnSetup.Style.FocusedImageForeColor = System.Drawing.Color.White;
            this.btnSetup.Style.ForeColor = System.Drawing.Color.White;
            this.btnSetup.Style.HoverBackColor = System.Drawing.Color.White;
            this.btnSetup.Style.HoverForeColor = System.Drawing.Color.Teal;
            this.btnSetup.Style.HoverImageForeColor = System.Drawing.Color.Teal;
            this.btnSetup.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image9")));
            this.btnSetup.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnSetup.Style.PressedBackColor = System.Drawing.Color.DarkCyan;
            this.btnSetup.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnSetup.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnSetup.TabIndex = 6;
            this.btnSetup.Text = "Thiết lập";
            this.btnSetup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // panService
            // 
            this.panService.Controls.Add(this.btnService);
            this.panService.Location = new System.Drawing.Point(0, 300);
            this.panService.Margin = new System.Windows.Forms.Padding(0);
            this.panService.Name = "panService";
            this.panService.Size = new System.Drawing.Size(220, 50);
            this.panService.TabIndex = 7;
            // 
            // btnService
            // 
            this.btnService.AccessibleName = "Button";
            this.btnService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnService.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.ImageSize = new System.Drawing.Size(32, 32);
            this.btnService.Location = new System.Drawing.Point(0, 0);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(220, 50);
            this.btnService.Style.BackColor = System.Drawing.Color.Teal;
            this.btnService.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnService.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnService.Style.FocusedImageForeColor = System.Drawing.Color.White;
            this.btnService.Style.ForeColor = System.Drawing.Color.White;
            this.btnService.Style.HoverBackColor = System.Drawing.Color.White;
            this.btnService.Style.HoverForeColor = System.Drawing.Color.Teal;
            this.btnService.Style.HoverImageForeColor = System.Drawing.Color.Teal;
            this.btnService.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image10")));
            this.btnService.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnService.Style.PressedBackColor = System.Drawing.Color.DarkCyan;
            this.btnService.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnService.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnService.TabIndex = 7;
            this.btnService.Text = "Dịch vụ";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // panBill
            // 
            this.panBill.Controls.Add(this.btnHoaDon);
            this.panBill.Location = new System.Drawing.Point(0, 350);
            this.panBill.Margin = new System.Windows.Forms.Padding(0);
            this.panBill.Name = "panBill";
            this.panBill.Size = new System.Drawing.Size(220, 50);
            this.panBill.TabIndex = 8;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.AccessibleName = "Button";
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHoaDon.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.ImageSize = new System.Drawing.Size(32, 32);
            this.btnHoaDon.Location = new System.Drawing.Point(0, 0);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(220, 50);
            this.btnHoaDon.Style.BackColor = System.Drawing.Color.Teal;
            this.btnHoaDon.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnHoaDon.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Style.FocusedImageForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Style.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Style.HoverBackColor = System.Drawing.Color.White;
            this.btnHoaDon.Style.HoverForeColor = System.Drawing.Color.Teal;
            this.btnHoaDon.Style.HoverImageForeColor = System.Drawing.Color.Teal;
            this.btnHoaDon.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image11")));
            this.btnHoaDon.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Style.PressedBackColor = System.Drawing.Color.DarkCyan;
            this.btnHoaDon.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnHoaDon.TabIndex = 8;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // panAccounting
            // 
            this.panAccounting.Controls.Add(this.btnAccounting);
            this.panAccounting.Location = new System.Drawing.Point(0, 400);
            this.panAccounting.Margin = new System.Windows.Forms.Padding(0);
            this.panAccounting.Name = "panAccounting";
            this.panAccounting.Size = new System.Drawing.Size(220, 50);
            this.panAccounting.TabIndex = 9;
            // 
            // btnAccounting
            // 
            this.btnAccounting.AccessibleName = "Button";
            this.btnAccounting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccounting.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounting.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAccounting.Location = new System.Drawing.Point(0, 0);
            this.btnAccounting.Name = "btnAccounting";
            this.btnAccounting.Size = new System.Drawing.Size(220, 50);
            this.btnAccounting.Style.BackColor = System.Drawing.Color.Teal;
            this.btnAccounting.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnAccounting.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnAccounting.Style.FocusedImageForeColor = System.Drawing.Color.White;
            this.btnAccounting.Style.ForeColor = System.Drawing.Color.White;
            this.btnAccounting.Style.HoverBackColor = System.Drawing.Color.White;
            this.btnAccounting.Style.HoverForeColor = System.Drawing.Color.Teal;
            this.btnAccounting.Style.HoverImageForeColor = System.Drawing.Color.Teal;
            this.btnAccounting.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image12")));
            this.btnAccounting.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnAccounting.Style.PressedBackColor = System.Drawing.Color.DarkCyan;
            this.btnAccounting.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnAccounting.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnAccounting.TabIndex = 9;
            this.btnAccounting.Text = "Kế toán";
            this.btnAccounting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccounting.Click += new System.EventHandler(this.btnAccounting_Click);
            // 
            // panStaff
            // 
            this.panStaff.Controls.Add(this.btnStaff);
            this.panStaff.Location = new System.Drawing.Point(0, 450);
            this.panStaff.Margin = new System.Windows.Forms.Padding(0);
            this.panStaff.Name = "panStaff";
            this.panStaff.Size = new System.Drawing.Size(220, 50);
            this.panStaff.TabIndex = 10;
            // 
            // btnStaff
            // 
            this.btnStaff.AccessibleName = "Button";
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStaff.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.ImageSize = new System.Drawing.Size(32, 32);
            this.btnStaff.Location = new System.Drawing.Point(0, 0);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(220, 50);
            this.btnStaff.Style.BackColor = System.Drawing.Color.Teal;
            this.btnStaff.Style.FocusedBackColor = System.Drawing.Color.DarkCyan;
            this.btnStaff.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnStaff.Style.FocusedImageForeColor = System.Drawing.Color.White;
            this.btnStaff.Style.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Style.HoverBackColor = System.Drawing.Color.White;
            this.btnStaff.Style.HoverForeColor = System.Drawing.Color.Teal;
            this.btnStaff.Style.HoverImageForeColor = System.Drawing.Color.Teal;
            this.btnStaff.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image13")));
            this.btnStaff.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnStaff.Style.PressedBackColor = System.Drawing.Color.DarkCyan;
            this.btnStaff.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnStaff.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnStaff.TabIndex = 10;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // panLogOut
            // 
            this.panLogOut.Controls.Add(this.btnLogOut);
            this.panLogOut.Location = new System.Drawing.Point(0, 500);
            this.panLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.panLogOut.Name = "panLogOut";
            this.panLogOut.Size = new System.Drawing.Size(220, 50);
            this.panLogOut.TabIndex = 11;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AccessibleName = "Button";
            this.btnLogOut.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogOut.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.ImageSize = new System.Drawing.Size(32, 32);
            this.btnLogOut.Location = new System.Drawing.Point(0, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(220, 50);
            this.btnLogOut.Style.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogOut.Style.FocusedBackColor = System.Drawing.Color.Maroon;
            this.btnLogOut.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnLogOut.Style.FocusedImageForeColor = System.Drawing.Color.White;
            this.btnLogOut.Style.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Style.HoverBackColor = System.Drawing.Color.White;
            this.btnLogOut.Style.HoverForeColor = System.Drawing.Color.DarkRed;
            this.btnLogOut.Style.HoverImageForeColor = System.Drawing.Color.DarkRed;
            this.btnLogOut.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image14")));
            this.btnLogOut.Style.ImageForeColor = System.Drawing.Color.White;
            this.btnLogOut.Style.PressedBackColor = System.Drawing.Color.DarkRed;
            this.btnLogOut.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnLogOut.Style.PressedImageForeColor = System.Drawing.Color.White;
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panDesktop
            // 
            this.panDesktop.BackColor = System.Drawing.Color.White;
            this.panDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDesktop.Location = new System.Drawing.Point(222, 52);
            this.panDesktop.Name = "panDesktop";
            this.panDesktop.Size = new System.Drawing.Size(1376, 846);
            this.panDesktop.TabIndex = 12;
            // 
            // tmrSideBar
            // 
            this.tmrSideBar.Interval = 10;
            this.tmrSideBar.Tick += new System.EventHandler(this.tmrSideBar_Tick);
            // 
            // cpicProfile
            // 
            this.cpicProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpicProfile.Image = ((System.Drawing.Image)(resources.GetObject("cpicProfile.Image")));
            this.cpicProfile.Location = new System.Drawing.Point(343, 0);
            this.cpicProfile.MaximumSize = new System.Drawing.Size(50, 50);
            this.cpicProfile.Name = "cpicProfile";
            this.cpicProfile.Size = new System.Drawing.Size(50, 50);
            this.cpicProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpicProfile.TabIndex = 0;
            this.cpicProfile.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.ControlBox = false;
            this.Controls.Add(this.panDesktop);
            this.Controls.Add(this.flpanSideBar);
            this.Controls.Add(this.panHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmDemo_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panHeader.ResumeLayout(false);
            this.panMenu.ResumeLayout(false);
            this.panWelcome.ResumeLayout(false);
            this.flpanSideBar.ResumeLayout(false);
            this.panDashBoard.ResumeLayout(false);
            this.panBooking.ResumeLayout(false);
            this.panRoom.ResumeLayout(false);
            this.panFrontDesk.ResumeLayout(false);
            this.panCustomer.ResumeLayout(false);
            this.panSetup.ResumeLayout(false);
            this.panService.ResumeLayout(false);
            this.panBill.ResumeLayout(false);
            this.panAccounting.ResumeLayout(false);
            this.panStaff.ResumeLayout(false);
            this.panLogOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpicProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.FlowLayoutPanel flpanSideBar;
        private System.Windows.Forms.Panel panDashBoard;
        private Syncfusion.WinForms.Controls.SfButton btnDashBoard;
        private System.Windows.Forms.Panel panMenu;
        private Syncfusion.WinForms.Controls.SfButton btnMenu;
        private System.Windows.Forms.Panel panSetup;
        private Syncfusion.WinForms.Controls.SfButton btnSetup;
        private System.Windows.Forms.Panel panRoom;
        private Syncfusion.WinForms.Controls.SfButton btnRoom;
        private System.Windows.Forms.Panel panFrontDesk;
        private Syncfusion.WinForms.Controls.SfButton btnFrontDesk;
        private System.Windows.Forms.Panel panBooking;
        private Syncfusion.WinForms.Controls.SfButton btnBooking;
        private System.Windows.Forms.Panel panCustomer;
        private Syncfusion.WinForms.Controls.SfButton btnCustomer;
        private System.Windows.Forms.Panel panService;
        private Syncfusion.WinForms.Controls.SfButton btnService;
        private System.Windows.Forms.Panel panBill;
        private Syncfusion.WinForms.Controls.SfButton btnHoaDon;
        private System.Windows.Forms.Panel panAccounting;
        private Syncfusion.WinForms.Controls.SfButton btnAccounting;
        private System.Windows.Forms.Panel panStaff;
        private Syncfusion.WinForms.Controls.SfButton btnStaff;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private System.Windows.Forms.Panel panDesktop;
        private Syncfusion.WinForms.Controls.SfButton btnFullScreen;
        private Syncfusion.WinForms.Controls.SfButton btnMinimize;
        private System.Windows.Forms.Panel panLogOut;
        private Syncfusion.WinForms.Controls.SfButton btnLogOut;
        private System.Windows.Forms.Timer tmrSideBar;
        private System.Windows.Forms.Panel panWelcome;
        private System.Windows.Forms.Label lblHiUser;
        private CircularPictureBox cpicProfile;
        private Syncfusion.Windows.Forms.Tools.Clock realTimeClock;
    }
}