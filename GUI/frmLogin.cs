using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.customForm;

namespace GUI
{


    public partial class frmLogin : Form
    {
        /*-------------------------------------------------------------------------------------------------------------------
                                BẮT ĐẦU ĐOẠN KHAI BÁO CÁC BIẾN TOÀN CỤC
       --------------------------------------------------------------------------------------------------------------------*/
        public string phanQuyen { get; set; }
        public string hoTen { get; set; }
        public Image hinhAnh { get; set; }

        private Timer timerLoop;
        private int gifDuration = 18000;
        private int elapsed = 0;

        customMessageBox thongBao;

        /*-------------------------------------------------------------------------------------------------------------------
                                    KẾT THÚC ĐOẠN KHAI BÁO CÁC BIẾN TOÀN CỤC
       --------------------------------------------------------------------------------------------------------------------*/



        /*-------------------------------------------------------------------------------------------------------------------
                                 BẮT ĐẦU ĐOẠN XỬ LÝ ANIMATION CHO BACKGROUND
        --------------------------------------------------------------------------------------------------------------------*/
        private void InitializeTimer()
        {
            timerLoop = new Timer();
            timerLoop.Interval = 50;
            timerLoop.Tick += Timer_Tick;
            timerLoop.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsed += timerLoop.Interval;

            if (elapsed >= gifDuration)
            {
                this.picLoginBG.Image = global::GUI.Properties.Resources.backgroundLogin_LowRes;
                elapsed %= gifDuration;
            }
        }
        /*-------------------------------------------------------------------------------------------------------------------
                         KẾT THÚC ĐOẠN XỬ LÝ ANIMATION CHO BACKGROUND
        --------------------------------------------------------------------------------------------------------------------*/


        /*-------------------------------------------------------------------------------------------------------------------
                         BẮT ĐẦU ĐOẠN XỬ LÝ ANIMATION CHO PANEL LOGIN/QUÊN MẬT KHẨU
        --------------------------------------------------------------------------------------------------------------------*/
        private void linkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int viTriX = (panLogin.Location.X == 520) ? 60 : 520;
            tmrTransistion.Tag = viTriX;
            tmrTransistion.Start();

            if (viTriX == 520)
            {
                Image backgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("backgroundLoginPanel_2");
                panLogin.BackgroundImage = backgroundImage;
                lblLOGO.Text = "XÁC THỰC \r\nTÀI KHOẢN";
                Icon icon1 = new Icon(Resources.Email, 48, 48);
                Bitmap bitmap1 = icon1.ToBitmap();
                picUsername.Image = bitmap1;
                lblUsername.Text = "Email";
                txtUsername.Clear();
                Icon icon2 = new Icon(Resources.Passport, 48, 48);
                Bitmap bitmap2 = icon2.ToBitmap();
                picPassword.Image = bitmap2;
                lblPassword.Text = "ID/Passport";
                txtPassword.Clear();
                txtPassword.PasswordChar = '\0';
                btnShowHidePassword.Hide();
                tbtnRemember.Hide();
                btnAdmin.Show();
                linkForget.Text = "Quay lại đăng nhập";
                btnSubmit.Text = "Xác thực";
            }
            else if (viTriX == 60)
            {
                Image backgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("backgroundLoginPanel");
                panLogin.BackgroundImage = backgroundImage;
                lblLOGO.Text = "THE AZURE HOTEL\r\nMANAGEMENT APP";
                Icon icon1 = new Icon(Resources.UserName, 48, 48);
                Bitmap bitmap1 = icon1.ToBitmap();
                picUsername.Image = bitmap1;
                lblUsername.Text = "Tên người dùng";
                txtUsername.Clear();
                Icon icon2 = new Icon(Resources.Password, 48, 48);
                Bitmap bitmap2 = icon2.ToBitmap();
                picPassword.Image = bitmap2;
                lblPassword.Text = "Mật khẩu";
                txtPassword.Clear();
                txtPassword.PasswordChar = '•';
                btnShowHidePassword.Show();
                tbtnRemember.Show();
                btnAdmin.Hide();
                linkForget.Text = "Quên mật khẩu?";
                btnSubmit.Text = "Đăng nhập";
            }
        }

        private void tmrTransistion_Tick(object sender, EventArgs e)
        {
            int viTriX = (int)tmrTransistion.Tag;
            int speed = 40;

            if (panLogin.Location.X != viTriX)
            {
                int viTriDich = panLogin.Location.X + (panLogin.Location.X < viTriX ? speed : -speed);
                if ((panLogin.Location.X < viTriX && viTriDich > viTriX) || (panLogin.Location.X > viTriX && viTriDich < viTriX))
                    viTriDich = viTriX;

                panLogin.Location = new Point(viTriDich, panLogin.Location.Y);
            }
            else
            {
                tmrTransistion.Stop();
            }
        }
        /*-------------------------------------------------------------------------------------------------------------------
                KẾT THÚC ĐOẠN XỬ LÝ ANIMATION CHO PANEL LOGIN/QUÊN MẬT KHẨU
        --------------------------------------------------------------------------------------------------------------------*/

        /*-------------------------------------------------------------------------------------------------------------------
                 BẮT ĐẦU ĐOẠN XỬ LÝ CHO CÁC BUTTON
        --------------------------------------------------------------------------------------------------------------------*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            using (customMessageBox messageBox = new customMessageBox("Bạn có chắc chắn muốn thoát chương trình không?"))
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



        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (KiemTraDangNhap())
            {
                frmMain mainForm = new frmMain();
                mainForm.hoTen = hoTen;
                mainForm.hinhAnh = hinhAnh;
                mainForm.phanQuyen = phanQuyen;
                this.Hide();
                mainForm.Show();
                this.Close();
            }
            else
            {
                thongBao = new customMessageBox("Đăng nhập thất bại, hãy kiểm tra lại thông tin!");
                thongBao.ShowDialog();
            }
           


        }

        private bool KiemTraDangNhap()
        {
            return true;
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {


        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.ShowDialog();
        }


        /*-------------------------------------------------------------------------------------------------------------------
                     KẾT THÚC ĐOẠN XỬ LÝ CHO CÁC BUTTON
         --------------------------------------------------------------------------------------------------------------------*/
        /*-------------------------------------------------------------------------------------------------------------------
                    HÀM KHỞI TẠO FORM LOGIN, CÓ THỂ THÊM CÁC HÀM KHÁC VÀO ĐÂY
           --------------------------------------------------------------------------------------------------------------------*/
        /// <summary>
        /// Khởi tạo form login và các phần tử controller cùng với các timer để chạy hiệu ứng
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
            InitializeTimer();
            this.DoubleBuffered = true;

        }

    }
}
