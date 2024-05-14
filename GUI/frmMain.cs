using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using GUI.customForm;
using GUI.UserControls;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Syncfusion.WinForms.Controls;

namespace GUI
{
    public partial class frmMain : Form
    {
        /*-------------------------------------------------------------------------------------------------------------------
                                         BẮT ĐẦU KHAI BÁO CÁC BIẾN TOÀN CỤC
       --------------------------------------------------------------------------------------------------------------------*/
        //Biến xác định User đang login
        public string phanQuyen { get; set; }
        public string hoTen { get; set; } 
        public Image hinhAnh { get; set; }

        public NhanVienDTO user=new NhanVienDTO();
        public KhachHangDTO userKH = new KhachHangDTO();

        //Biến xác định menu đang mở
        private SfButton currentButton;

        //bien de luu sub menu dang mo
        private Panel currentOpenSubmenu = null;

        //Biến cho animation thu/ phóng thanh sideBar
        private bool sideBarExpand = true;
        private int maxSideBarWidth = 220;
        private int minSideBarWidth = 45;
        private const int animationStep = 10;
        private int initialSideBarWidth;
        private int initialMenuWidth;

        //Biến cho animation thu nhỏ subMenu
        private const int MinSubMenuWidth = 220;
        private const int MinSubMenuHeight = 50;

        //Biến Kích thược mặc định của FormMain
        private Size kichThuocMacDinh = new Size(1600, 900);

        //Các biến cho Snap Form
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MOVE = 0xF010;

        //Đọc và nhận dữ liệu chuột tương tác với form để di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(
            System.IntPtr hwnd,
            int wmsg,
            int wparam,
            int lparam
        );

        /*-------------------------------------------------------------------------------------------------------------------
                                         KẾT THÚC KHAI BÁO CÁC BIẾN TOÀN CỤC
       --------------------------------------------------------------------------------------------------------------------*/


        /*-------------------------------------------------------------------------------------------------------------------
                                          BẮT ĐẦU ĐOẠN XỬ LÝ CÁC NÚT CONTROL CHÍNH
        --------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Hàm xử lý sự kiện khi nút Close được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            using (
                customMessageBox messageBox = new customMessageBox(
                    "Bạn có chắc chắn muốn thoát chương trình không?"
                )
            )
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

        /// <summary>
        /// Hàm xử lý sự kiện khi nút LogOut được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            using (
                customMessageBox messageBox = new customMessageBox(
                    "Bạn có chắc chắn muốn đăng xuất tài khoản không?"
                )
            )
            {
                DialogResult dr = messageBox.ShowDialog();
                if (dr == DialogResult.OK)
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

        /*-------------------------------------------------------------------------------------------------------------------
                                        KẾT THÚC ĐOẠN XỬ LÝ CÁC NÚT CONTROL CHÍNH
       --------------------------------------------------------------------------------------------------------------------*/


        /*-------------------------------------------------------------------------------------------------------------------
                                         BẮT ĐẦU ĐOẠN XỬ LÝ AERO SNAP VÀ CONTROL NÂNG CAO
       --------------------------------------------------------------------------------------------------------------------*/

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
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
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

        /*-------------------------------------------------------------------------------------------------------------------
                                     KẾT THÚC ĐOẠN XỬ LÝ AERO SNAP VÀ CONTROL NÂNG CAO
        --------------------------------------------------------------------------------------------------------------------*/

        /*-------------------------------------------------------------------------------------------------------------------
                                         BẮT ĐẦU ĐOẠN XỬ LÝ MỞ MENU
        --------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Hàm để mở form con
        /// </summary>
        /// <param name="frm">Form con muốn mở (UserControl)</param>
        ///
        private void openForm(UserControl frm)
        {
            panDesktop.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            panDesktop.Controls.Add(frm);
            panDesktop.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        //Thay đổi User Control khi bấm button trong User Control
        public void SwitchUserControl(UserControl newControl)
        {
            panDesktop.Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            panDesktop.Controls.Add(newControl);
            panDesktop.Tag = newControl;
            newControl.BringToFront();
            newControl.Show();
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
            frm.MaPHQ = this.phanQuyen;
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
            frm.MaPHQ = this.phanQuyen;
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
            frm.MaPHQ = this.phanQuyen;
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
            frm.MaPHQ = this.phanQuyen;
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
            frm.MaPHQ = this.phanQuyen;
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
            frm.MaPHQ = this.phanQuyen;
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
            frm.MaPHQ = this.phanQuyen;
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
            frm.MaPHQ = this.phanQuyen;
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
            frm.MaPHQ = this.phanQuyen;
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
            frm.MaPHQ = this.phanQuyen;
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
            frm.MaPHQ = this.phanQuyen;
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
            frm.MaPHQ = this.phanQuyen;
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
            frm.MaPHQ = this.phanQuyen;
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
            frm.MaPHQ = this.phanQuyen;
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút hang Thanh vien được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomerRanking_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucCustomerRanking frm = new ucCustomerRanking();
            frm.MaPHQ = this.phanQuyen;
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút khuyen mai  được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucDiscount frm = new ucDiscount();
            frm.MaPHQ = this.phanQuyen;
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút chi tiet hoa don được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBillDetails_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucBillDetails frm = new ucBillDetails();
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút tinh trang thiet bi được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeviceStatus_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucDeviceStatus frm = new ucDeviceStatus();
            frm.MaPHQ = this.phanQuyen;
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút thiet bi được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThietBi_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucDevice frm = new ucDevice();
            frm.MaPHQ = this.phanQuyen;
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút don phong được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHousekeeping_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucHousekeeping frm = new ucHousekeeping();
            frm.MaPHQ = this.phanQuyen;
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút bao tri được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaintance_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucMaintentance frm = new ucMaintentance();
            frm.MaPHQ = this.phanQuyen;
            openForm(frm);
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nút đánh giá được bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRating_Click(object sender, EventArgs e)
        {
            menuActivated(sender);
            ucRating frm = new ucRating();
            frm.MaPHQ = this.phanQuyen;
            openForm(frm);
        }

        private void cpicProfile_Click(object sender, EventArgs e)
        {
            ucPersonal personal = new ucPersonal();
            if (user!=null)
            {
                personal.user = user;
                personal.userKH = null;
            }
            else
            {
                personal.userKH = userKH;
                personal.user = null;
            }
            openForm(personal);
        }

        private void btnRoomBooking_Click(object sender, EventArgs e)
        {
            ucRoomBooking datPhong = new ucRoomBooking();
            openForm(datPhong);
        }

        /*-------------------------------------------------------------------------------------------------------------------
                                                  KẾT THÚC ĐOẠN XỬ LÝ MỞ MENU
        --------------------------------------------------------------------------------------------------------------------*/

        /*-------------------------------------------------------------------------------------------------------------------
                                   BẮT ĐẦU ĐOẠN XỬ LÝ ANIMATION CHO SIDEBAR
       --------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Khi bấm vào nút Menu thì kiểm tra trạng thái sidebar, sau đó tiến hành mở rộng hoặc thu nhỏ sidebar,
        /// nếu có menu đang được mở thì đổi trạng thái để đưa icon về bên trái button trước khi thu nhỏ
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
        /// Hàm xử lý sự kiện khi người dùng chọn Menu khác thì sẽ hủy kích hoạt menu đang chọn
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
        /// Khi menu được chọn thì tiến hành chạy hiệu ứng mở rộng/ thu nhỏ sidebar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///
        private void btnMenu_Activate(object sender, EventArgs e)
        {
            initialSideBarWidth = flpanSideBar.Width;
            initialMenuWidth = panMenu.Width;
            if (!tmrSideBar.Enabled)
                tmrSideBar.Start();
        }

        /*-------------------------------------------------------------------------------------------------------------------
                           KẾT THÚC ĐOẠN XỬ LÝ ANIMATION CHO SIDEBAR
          --------------------------------------------------------------------------------------------------------------------*/

        /*-------------------------------------------------------------------------------------------------------------------
                                     BẮT ĐẦU ĐOẠN XỬ LÝ ANIMATION CHO SUB-MENU
         --------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Khi bấm vào các nút Menu mẹ có chứa sub menu thì sẽ kiểm tra trạng thía hiện tại của nó đóng hay mở, sau đó tiến hành mở hoặc đóng submenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        /// Khi bấm vào các nút Menu mẹ có chứa sub menu thì sẽ kiểm tra trạng thía hiện tại của nó đóng hay mở, sau đó tiến hành mở hoặc đóng submenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Click(object sender, EventArgs e)
        {
            SfButton menuHolderButton = sender as SfButton;
            if (menuHolderButton != null)
            {
                // Lấy panel chứa submenu
                Panel submenuContainerPanel = menuHolderButton.Parent.Parent as Panel;
                if (submenuContainerPanel != null)
                {
                    // Kiểm tra xem submenu khác có đang mở không, nếu có thì đóng lại
                    if (currentOpenSubmenu != null && currentOpenSubmenu != submenuContainerPanel)
                    {
                        CollapseSubmenu(currentOpenSubmenu);
                    }

                    // Lấy panel submenu
                    Panel clickedSubmenuPanel = menuHolderButton.Parent.Parent as Panel;
                    if (clickedSubmenuPanel != null)
                    {
                        // Mở hoặc thu nhỏ submenu
                        if (clickedSubmenuPanel.Height < clickedSubmenuPanel.MaximumSize.Height)
                        {
                            ExpandSubmenu(clickedSubmenuPanel);
                            currentOpenSubmenu = submenuContainerPanel;
                        }
                        else
                        {
                            CollapseSubmenu(clickedSubmenuPanel);
                            currentOpenSubmenu = null;

                        }
                       
                    }
                }
            }
        }

        /// <summary>
        /// Hàm xử lý sự kiện mở rộng sub menu
        /// </summary>
        /// <param name="submenuPanel"></param>
        private void ExpandSubmenu(Panel submenuPanel)
        {
            Timer expandTimer = new Timer();
            expandTimer.Interval = 25; // Thời gian cho mỗi bước animation
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

        /// <summary>
        /// Hàm xử lý sự kiện cho việc đóng submenu
        /// </summary>
        /// <param name="submenuPanel"></param>
        private void CollapseSubmenu(Panel submenuPanel)
        {
            Timer collapseTimer = new Timer();
            collapseTimer.Interval = 25; // Thời gian cho mỗi bước animation
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

        /*-------------------------------------------------------------------------------------------------------------------
                                   KẾT THÚC ĐOẠN XỬ LÝ ANIMATION CHO SUB-MENU
       --------------------------------------------------------------------------------------------------------------------*/












        /*-------------------------------------------------------------------------------------------------------------------
                                                HÀM MAIN VÀ HÀM KHỞI TẠO
        --------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Hàm main của form
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        public void frmMain_Load(object sender, EventArgs e)
        {
            LoadHinhAnhUser();
            LoadTenUser();
            KiemTraPhanQuyen();
            
           
        }

        private void KiemTraPhanQuyen()
        {
            panRoomBooking.Visible = true;
            flpAccount.Visible = true;
            panDashBoard.Visible = true;
            flpBookingManagement.Visible = true;
            flpCustomerManagement.Visible = true;
            flpRoomManagement.Visible = true;
            flpDeviceMangement.Visible = true;
            flpStaffManagement.Visible = true;
            flpFinanceManagement.Visible = true;
            flpMaintanceManagement.Visible = true;
            flpHousekeepingManagement.Visible = true;
            switch (phanQuyen)
            {
                case "KH-01":
                    {
                        flpAccount.Visible = false;
                        flpBookingManagement.Visible = false;
                        panDashBoard.Visible = false;
                        flpBookingManagement.Visible = false;
                        flpCustomerManagement.Visible = false;
                        flpDeviceMangement.Visible = false;
                        flpStaffManagement.Visible = false; 
                        flpFinanceManagement.Visible = false;
                        flpMaintanceManagement.Visible = false;
                        flpRoomManagement.Visible = false;
                        flpHousekeepingManagement.Visible = false;
                        menuActivated(btnRoomBooking);
                        ucRoomBooking Home = new ucRoomBooking();
                        Home.maKH = this.userKH.MaKH;
                        openForm(Home);
                    }
                    break;
                case "AD-02":
                    {
                        panRoomBooking.Visible = false;
                        menuActivated(btnDashBoard);
                        ucDashboard Home = new ucDashboard();
                        openForm(Home);
                    }
                    break;
                case "BT-03":
                case "BT-04":
                    {
                        panRoomBooking.Visible = false;
                        flpAccount.Visible = false;
                        flpBookingManagement.Visible = false;
                        panDashBoard.Visible = false;
                        flpCustomerManagement.Visible = false;
                        flpStaffManagement.Visible = false;
                        flpFinanceManagement.Visible = false;
                        flpRoomManagement.Visible = false;
                        flpHousekeepingManagement.Visible = false;
                        menuActivated(btnMaintance);
                        ucMaintentance Home = new ucMaintentance();
                        Home.MaPHQ = this.phanQuyen;
                        openForm(Home);
                    }
                    break;
                case "DP-03":
                case "DP-04":
                    {
                        panRoomBooking.Visible = false;
                        flpAccount.Visible = false;
                        flpBookingManagement.Visible = false;
                        panDashBoard.Visible = false;
                        flpCustomerManagement.Visible = false;
                        flpDeviceMangement.Visible = false;
                        flpStaffManagement.Visible = false;
                        flpFinanceManagement.Visible = false;
                        flpMaintanceManagement.Visible = false;
                        menuActivated(btnHousekeeping);
                        ucHousekeeping Home = new ucHousekeeping();
                        Home.MaPHQ = this.phanQuyen;
                        openForm(Home);
                    }
                    break;
                case "KT-03":
                case "KT-04":
                    {
                        panRoomBooking.Visible = false;
                        flpAccount.Visible = false;
                        flpBookingManagement.Visible = false;
                        flpCustomerManagement.Visible = false;
                        flpRoomManagement.Visible = false;
                        flpDeviceMangement.Visible = false;
                        flpStaffManagement.Visible = false;
                        flpMaintanceManagement.Visible = false;
                        flpRoomManagement.Visible = false;
                        flpHousekeepingManagement.Visible = false;
                        menuActivated(btnDashBoard);
                        ucDashboard Home = new ucDashboard();
                        openForm(Home);
                    }
                    break;
                case "LT-03":
                case "LT-04":
                    {
                        panRoomBooking.Visible = false;
                        flpStaffManagement.Visible = false;
                        flpMaintanceManagement.Visible = false;
                        flpHousekeepingManagement.Visible = false;
                        flpAccount.Visible = false;
                        flpFinanceManagement.Visible = false;
                        menuActivated(btnDashBoard);
                        ucDashboard Home = new ucDashboard();
                        openForm(Home);
                    }
                    break;
                case "MK-03":
                case "MK-04":
                    {
                        panRoomBooking.Visible = false;
                        flpAccount.Visible = false;
                        flpDeviceMangement.Visible = false;
                        flpStaffManagement.Visible = false;
                        flpFinanceManagement.Visible = false;
                        flpMaintanceManagement.Visible = false;
                        flpRoomManagement.Visible = false;
                        flpHousekeepingManagement.Visible = false;
                        menuActivated(btnDashBoard);
                        ucDashboard Home = new ucDashboard();
                        openForm(Home);
                    }
                    break;
                default:
                    {
                        flpAccount.Visible = false;
                        flpBookingManagement.Visible = false;
                        panDashBoard.Visible = false;
                        flpBookingManagement.Visible = false;
                        flpCustomerManagement.Visible = false;
                        flpDeviceMangement.Visible = false;
                        flpStaffManagement.Visible = false;
                        flpFinanceManagement.Visible = false;
                        flpMaintanceManagement.Visible = false;
                        flpRoomManagement.Visible = false;
                        flpHousekeepingManagement.Visible = false;
                        panRoomBooking.Visible = false;
                        uc404 error = new uc404();
                        openForm(error);
                    }
                    break;
            }
        }

        public void LoadTenUser()
        {
            if (this.user != null)
            {
                if (user.HoTenNV != null)
                {
                    lblHiUser.Text = $"Xin chào {user.HoTenNV},\r\nChúc bạn một ngày làm việc vui vẻ!\r\n";
                }
                else
                {
                    lblHiUser.Text = $"Xin chào bạn,\r\nChúc bạn một ngày làm việc vui vẻ!\r\n";
                }
            }
            else
            {
                if (userKH.HoTenKH != null)
                {

                    lblHiUser.Text = $"Xin chào {userKH.HoTenKH},\r\nChúc bạn có một kỳ nghỉ tuyệt vời!\r\n";
                }
                else
                {
                    lblHiUser.Text = $"Xin chào bạn,\r\nChúc bạn có một kỳ nghỉ tuyệt vời!\r\n";
                }

            }
        }

        public void LoadHinhAnhUser()
        {
            if (this.user != null)
            {
                if (user.HinhAnh != null)
                {
                    byte[] hinh = (byte[])user.HinhAnh;
                    cpicProfile.Image = ByteArrayToImage(hinh);
                }
                else
                {
                    Image profile = Properties.Resources.Profile.ToBitmap();
                    cpicProfile.Image = profile;
                }
            }
            else
            {
                if (userKH.HinhAnh != null)
                {

                    byte[] hinh = (byte[])userKH.HinhAnh;
                    cpicProfile.Image = ByteArrayToImage(hinh);
                }
                else
                {
                    Image profile = Properties.Resources.Profile.ToBitmap();
                    cpicProfile.Image = profile;
                }

            }
        }

        Image ByteArrayToImage(byte[] hinh)
        {
            using (MemoryStream m = new MemoryStream(hinh))
            {
                return Image.FromStream(m);
            }
        }





        /*-------------------------------------------------------------------------------------------------------------------
                                    KẾT THÚC  HÀM MAIN VÀ HÀM KHỞI TẠO
        --------------------------------------------------------------------------------------------------------------------*/

        /*-------------------------------------------------------------------------------------------------------------------
                                                CÓ THỂ THÊM CÁC HÀM XỬ LÝ KHÁC Ở ĐÂY
         --------------------------------------------------------------------------------------------------------------------*/


    }
}
