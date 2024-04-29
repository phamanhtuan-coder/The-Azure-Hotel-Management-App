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
using DTO;
using BLL;

namespace GUI
{


    public partial class frmLogin : Form
    {
        /*-------------------------------------------------------------------------------------------------------------------
                                BẮT ĐẦU ĐOẠN KHAI BÁO CÁC BIẾN TOÀN CỤC
       --------------------------------------------------------------------------------------------------------------------*/

        private Timer timerLoop;
        private int gifDuration = 18000;
        private int elapsed = 0;
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();    
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        KhachHangDTO khachHangDTO = new KhachHangDTO();
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
                btnSubmit.Text = "LOGIN";
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



        private void btnSubmit_Click(object sender, EventArgs e)
        {          
            if (btnSubmit.Text.Equals("Xác thực"))
            {
                khachHangDTO.Email = txtUsername.Text;
                khachHangDTO.CCCD= txtPassword.Text;
                if (XacThuc())
                {
                    //customMessageBox thongBao = new customMessageBox("Xác thực thành công!");
                    //thongBao.ShowDialog();
                    frmDoiMatKhau DoiMatKhau = new frmDoiMatKhau();
                    DoiMatKhau.taiKhoanDTO= taiKhoanDTO;
                    this.Hide();
                    DoiMatKhau.Show();
                    this.Close();
                }
                else
                {
                    customMessageBox thongBao = new customMessageBox("Xác thực thất bại!");
                    thongBao.ShowDialog();
                }
            }
            else if (btnSubmit.Text.Equals("LOGIN"))
            {
                taiKhoanDTO.TenDangNhap = txtUsername.Text;
                taiKhoanDTO.MatKhau = Utilities.HashMatKhau.HashPassword(txtPassword.Text);
                if (DangNhap())
                {
                    customMessageBox thongBao = new customMessageBox("Đăng nhập thành công!");
                    thongBao.ShowDialog();
                    frmMain mainForm = new frmMain();
                    this.Hide();
                    mainForm.Show();
                    this.Close();
                }
                else
                {
                    customMessageBox thongBao = new customMessageBox("Đăng nhập thất bại!");
                    thongBao.ShowDialog();
                }
            }
            //string username = txtUsername.Text.Trim();
            //string password = txtPassword.Text.Trim();

            //bool isValidLogin = userBLL.KiemTraDangNhap(username, password);

            //if (isValidLogin)
            //{
            //    //MessageBox.Show("Đăng nhập thành công!");
            //    // Thực hiện các hành động sau khi đăng nhập thành công
            //    frmMain mainForm = new frmMain();
            //    mainForm.Show();
            //    this.Hide();
            //    this.FormClosing -= frmLogin_FormClosing;
            //    this.Close();
            //    this.FormClosing += frmLogin_FormClosing;
            //}
            //else
            //{
            //    // Đăng nhập thất bại
            //    //MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng!");
            //}

        }

        private bool XacThuc()
        {
            taiKhoanDTO = khachHangBLL.XacThuc(khachHangDTO);
            if (taiKhoanDTO.MaTaiKhoan>0 && !string.IsNullOrWhiteSpace(taiKhoanDTO.TenDangNhap))
            {             
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool DangNhap()
        {          
            return taiKhoanBLL.XacThuc(taiKhoanDTO);
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
