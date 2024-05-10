using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace GUI.customForm
{
    public partial class frmDoiMatKhau : Form
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
        public bool isAdd { get; set; }

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        private void frmQuenMatKhau_Load(object sender, EventArgs e)
        {
            txtUsername.Text = taiKhoanDTO.TenDangNhap;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            if (!(lblLoiPassword.Text.Length > 0 || lblLoiRePassword.Text.Length > 0))
            {
                if (DoiMatKhau())
                {

                    //thongBao = new customMessageBox("Đổi mật khẩu thành công!");
                    //thongBao.ShowDialog();
                    frmLogin login = new frmLogin();
                    this.Hide();
                    login.Show();
                    this.Close();
                }
                else
                {
                    thongBao = new customMessageBox("Đổi mật khẩu thất bại!");
                    thongBao.ShowDialog();
                }

                this.Close();
            }
            else
            {
                thongBao = new customMessageBox("Vui lòng nhập đủ thông tin!");
                thongBao.ShowDialog();
            }      
        }

        private bool DoiMatKhau()
        {
            if (txtNewPassword.Text.Equals(txtRePassword.Text))
            {
                taiKhoanDTO.TenDangNhap = txtUsername.Text;
                taiKhoanDTO.MatKhau= Utilities.HashMatKhau.HashPassword(txtNewPassword.Text);

                return taiKhoanBLL.DoiMatKhau(taiKhoanDTO);
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (KiemTraInput.IsStrongPassword(txtNewPassword.Text))
            {
                lblLoiPassword.Text = "";
            }
            else
            {
                lblLoiPassword.Text = "Độ dài tối thiểu 8 ký tự, có một chữ số\nchữ hoa, thường và ký tự đặc biệt";
            }
        }

        private void txtRePw_Leave(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Equals(txtRePassword.Text))
            {
                lblLoiRePassword.Text = "";
            }
            else
            {
                lblLoiRePassword.Text = "Nhập lại mật khẩu không đúng!";
            }
        }
    }
}
