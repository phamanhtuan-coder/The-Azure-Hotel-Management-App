using GUI.UserControls;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MOVE = 0xF010;


        //Doc va nhan du lieu tu chuot va form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        //Bien xac dinh menu dang mo
        private SfButton currentButton;


        //Bien cho animation sideBar va panMenu
        private bool sideBarExpand=true;
        private int maxSideBarWidth = 220;
        private int minSideBarWidth = 45;
        private const int animationStep = 10; 
        private int initialSideBarWidth; 
        private int initialMenuWidth; 

        public frmMain()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.MaximizedBounds= Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void frmDemo_Load(object sender, EventArgs e)
        {
            
        }


        private void openForm(UserControl frm)
        {
            panDesktop.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            panDesktop.Controls.Add(frm);
            panDesktop.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void menuActivated(object sender)
        {
            if (sideBarExpand)
            {


                if (currentButton != null && currentButton != sender)
                {
                    menuDeActivated(currentButton);
                }

                currentButton = (SfButton)sender;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                currentButton.ImageMargin = new Padding(3, 3, 15, 3);
                currentButton.TextAlign = ContentAlignment.BottomRight;
            }
        }

        private void menuDeActivated(object sender)
        {
            SfButton currentMenu = (SfButton)sender;
            currentMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            currentButton.ImageMargin = new Padding(3);
            currentButton.TextAlign = ContentAlignment.BottomCenter;
            currentButton = null;
        }

        private void tmrSideBar_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                if (currentButton != null)
                {
                    menuDeActivated(currentButton);
                }
                int newWidth = Math.Max(flpanSideBar.Width - animationStep, minSideBarWidth);
                flpanSideBar.Width = newWidth;
                panMenu.Width = newWidth;

                if (flpanSideBar.Width <= minSideBarWidth)
                {
                    sideBarExpand = false;
                    tmrSideBar.Stop();
                }
            }
            else
            {
                int newWidth = Math.Min(flpanSideBar.Width + animationStep, maxSideBarWidth);
                flpanSideBar.Width = newWidth;
                panMenu.Width = newWidth;

                if (flpanSideBar.Width >= maxSideBarWidth)
                {
                    sideBarExpand = true;
                    tmrSideBar.Stop();
                }
            }
        
        }

        private void btnMenu_Activate(object sender, EventArgs e)
        {
            initialSideBarWidth = flpanSideBar.Width;
            initialMenuWidth = panMenu.Width;
            if (!tmrSideBar.Enabled)
                tmrSideBar.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
                this.FormClosing-= frmMain_FormClosing;
                this.Close();
                this.FormClosing += frmMain_FormClosing;

            }
            
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucSetup frm = new ucSetup();
            openForm(frm);
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucDashboard frm = new ucDashboard();
            openForm(frm);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucBooking frm = new ucBooking();
            openForm(frm);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucRoom frm = new ucRoom();
            openForm(frm);
        }

        private void btnFrontDesk_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucFrontDesk frm = new ucFrontDesk();
            openForm(frm);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucCustomer frm = new ucCustomer();
            openForm(frm);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucService frm = new ucService();
            openForm(frm);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucBill frm = new ucBill();
            openForm(frm);
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucAccounting frm = new ucAccounting();
            openForm(frm);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucStaff frm = new ucStaff();
            openForm(frm);
        }


        //Di chuyen form
        private void panHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        //Aero snap
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg==WM_NCCALCSIZE && m.WParam.ToInt32()==1)
            {
                return;
            }
            base.WndProc(ref m);

        }

        //Thay doi kich thuoc form main
        private void frmMain_Resize(object sender, EventArgs e)
        {
            thayDoiKichThuoc();
        }

        private void thayDoiKichThuoc()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    {
                        this.Padding = new Padding(2, 8, 8, 2);
                    }
                    break;
                  
                case FormWindowState.Normal:
                    if (this.Padding.Top!=2)
                    {
                        this.Padding = new Padding(2);
                    }
                    break;
                default:
                    break;
            }
        }

        //Nut control form
        //Nut Fullscreen
        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        //Nut Minimize
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

       
    }

    //Custom round button
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(gp);

            base.OnPaint(e);
        }
    }
    //Custom round picture box
    public class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            using (var path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
                Region = new Region(path);
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pe.Graphics.DrawEllipse(new Pen(Color.Black, 1), 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            }
        }


    }
}