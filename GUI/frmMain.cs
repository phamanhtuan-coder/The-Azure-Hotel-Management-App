using GUI.customForm;
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

        //Các biến cho Snap Form
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MOVE = 0xF010;


        //Đọc và nhận dữ liệu chuột tương tác với form để di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        //Biến xác định menu đang mở
        private SfButton currentButton;


        //Biến cho animation thu/ phóng thanh sideBar
        private bool sideBarExpand=true;
        private int maxSideBarWidth = 220;
        private int minSideBarWidth = 45;
        private const int animationStep = 10; 
        private int initialSideBarWidth; 
        private int initialMenuWidth;


        //bien de luu sub menu dang mo
        private Panel currentSubmenu = null;


        //Biến Kích thược mặc định của FormMain
        private Size kichThuocMacDinh = new Size(1600, 900);

        /// <summary>
        /// Hàm main của form
        /// </summary>
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

        /// <summary>
        /// Hàm để mở form con
        /// </summary>
        /// <param name="frm">Form con muốn mở (UserControl)</param>
        private void openForm(UserControl frm)
        {
            panDesktop.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            panDesktop.Controls.Add(frm);
            panDesktop.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi menu được chọn
        /// </summary>
        /// <param name="sender">Nút đang chọn</param>
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
                currentButton.ImageMargin = new Padding(3);
                currentButton.TextAlign = ContentAlignment.BottomRight;
            }
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi menu thay đổi chọn
        /// </summary>
        /// <param name="sender">Nút đang chọn</param>
        private void menuDeActivated(object sender)
        {
            SfButton currentMenu = (SfButton)sender;
            currentMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            currentButton.ImageMargin = new Padding(3);
            currentButton.TextAlign = ContentAlignment.BottomLeft;
            currentButton = null;
        }


        /// <summary>
        /// Hàm xử lý animation cho SideBar thu nhỏ/ mở rộng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Hàm xử lý sự kiện khi nút Menu được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenu_Activate(object sender, EventArgs e)
        {
            initialSideBarWidth = flpanSideBar.Width;
            initialMenuWidth = panMenu.Width;
            if (!tmrSideBar.Enabled)
                tmrSideBar.Start();
        }



        /// <summary>
        /// Hàm xử lý sự kiện khi nút Close được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            using (customMessageBox messageBox = new customMessageBox("Bạn có muốn thoát chương trình không?"))
            {
                DialogResult dr = messageBox.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    messageBox.Close();
                    return;
                }
                else if (dr == DialogResult.OK)
                {
                    this.Close();
                    messageBox.Close();
                }
            }
            Application.Exit();
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút LogOut được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            using (customMessageBox messageBox = new customMessageBox("Bạn có muốn đăng xuất tài khoản không?"))
            {
                DialogResult dr = messageBox.ShowDialog();
                if ( dr == DialogResult.OK)
                {
                    frmLogin login = new frmLogin();
                    this.Hide();
                    login.Show();
                    this.Close();

                }
                else
                {
                    messageBox.Close();
                    return;
                }
            }
               
            
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút Loai TK được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccountType_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucAccountType frm = new ucAccountType();
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút DashBoard được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucDashboard frm = new ucDashboard();
            openForm(frm);
        }


        /// <summary>
        /// Hàm xử lý sự kiện khi nút Booking được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBooking_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucBooking frm = new ucBooking();
            openForm(frm);
        }


        /// <summary>
        /// Hàm xử lý sự kiện khi nút Room được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoom_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucRoom frm = new ucRoom();
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút Loai Phong được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    
        private void btnRoomType_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucRoomType frm = new ucRoomType();
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút Trang thai phong được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoomStatus_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucRoomStatus frm = new ucRoomStatus();
            openForm(frm);
        }


        /// <summary>
        /// Hàm xử lý sự kiện khi nút Customer được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucCustomer frm = new ucCustomer();
            openForm(frm);
        }


        /// <summary>
        /// Hàm xử lý sự kiện khi nút Service được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnService_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucService frm = new ucService();
            openForm(frm);
        }


        /// <summary>
        /// Hàm xử lý sự kiện khi nút HoaDon được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucBill frm = new ucBill();
            openForm(frm);
        }


        /// <summary>
        /// Hàm xử lý sự kiện khi nút Accounting được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccounting_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucAccounting frm = new ucAccounting();
            openForm(frm);
        }


        /// <summary>
        /// Hàm xử lý sự kiện khi nút Staff được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStaff_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucStaff frm = new ucStaff();
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút Loai DV được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnServiceType_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucServiceType frm = new ucServiceType();
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút Thue được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTax_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucTax frm = new ucTax();
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút Tai Khoan được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccount_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucAccounts frm = new ucAccounts();
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi Phong Ban được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDepartment_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucDepartment frm = new ucDepartment();
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút Vai Tro được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRole_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucRole frm = new ucRole();
            openForm(frm);
        }



        /// <summary>
        /// Di chuyển form tự do nếu bấm giữ chuột trái vào header panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        /// <summary>
        /// Hàm xử lý tính năng Aero Snap của form
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg==WM_NCCALCSIZE && m.WParam.ToInt32()==1)
            {
                return;
            }
            base.WndProc(ref m);

        }

        /// <summary>
        /// Thay đổi kích thước form Main
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Resize(object sender, EventArgs e)
        {
            const int paddingMaximized = 10;
            const int paddingNormal = 2;

            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(paddingMaximized);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != paddingNormal)
                    {
                        this.Padding = new Padding(paddingNormal);
                    }
                    break;
                default:
                    break;
            }
        }

     

        /// <summary>
        /// Hàm xử lý sự kiện khi bấm nút FullScreen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || this.Size != kichThuocMacDinh)
            {
                this.Size = kichThuocMacDinh;
                this.WindowState = FormWindowState.Normal;

            }
            else
            {

                this.WindowState = FormWindowState.Maximized;
            }
        }


        /// <summary>
        /// Hàm xử lý sự kiện khi bấm nút Minimize
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        private void Menu_Click(object sender, EventArgs e)
        {
            Button menuHolderButton = sender as Button;
            if (menuHolderButton != null)
            {
                // Lấy panel chứa submenu
                Panel submenuContainerPanel = menuHolderButton.Parent.Parent as Panel;
                if (submenuContainerPanel != null)
                {
                    // Kiểm tra xem submenu khác có đang mở không, nếu có thì đóng lại
                    foreach (Control control in submenuContainerPanel.Controls)
                    {
                        if (control is Panel subPanel && subPanel != sender)
                        {
                            CollapseSubmenu(subPanel);
                        }
                    }

                    // Lấy panel submenu
                    Panel clickedSubmenuPanel = menuHolderButton.Parent.Parent as Panel;
                    if (clickedSubmenuPanel != null)
                    {
                        // Mở hoặc thu nhỏ submenu
                        if (clickedSubmenuPanel.Height < clickedSubmenuPanel.MaximumSize.Height)
                        {
                            ExpandSubmenu(clickedSubmenuPanel);
                        }
                        else
                        {
                            CollapseSubmenu(clickedSubmenuPanel);
                        }
                        currentSubmenu = clickedSubmenuPanel;
                    }
                }
            }
        }


        private void ExpandSubmenu(Panel submenuPanel)
        {
            Timer expandTimer = new Timer();
            expandTimer.Interval = 20; // Thời gian cho mỗi bước animation
            expandTimer.Tick += (sender, e) =>
            {
                if (submenuPanel.Height < submenuPanel.MaximumSize.Height)
                {
                    submenuPanel.Height += 25; // Điều chỉnh khoảng cách mỗi bước animation
                }
                else
                {
                    expandTimer.Stop();
                }
            };
            expandTimer.Start();
        }

        private const int MinSubMenuWidth = 220;
        private const int MinSubMenuHeight = 50;

        private void CollapseSubmenu(Panel submenuPanel)
        {
            Timer collapseTimer = new Timer();
            collapseTimer.Interval = 20; // Thời gian cho mỗi bước animation
            collapseTimer.Tick += (sender, e) =>
            {
                int newHeight = Math.Max(submenuPanel.Height - 25, MinSubMenuHeight);
                int newWidth = Math.Max(submenuPanel.Width - 25, MinSubMenuWidth);

                if (submenuPanel.Height > newHeight || submenuPanel.Width > newWidth)
                {
                    submenuPanel.Size = new Size(newWidth, newHeight);
                }
                else
                {
                    collapseTimer.Stop();
                }
            };
            collapseTimer.Start();
        }

       
    }

    /// <summary>
    /// Custom button để làm nút tròn
    /// </summary>
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
    
    /// <summary>
    /// Custom Picture box khung tròn
    /// </summary>
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