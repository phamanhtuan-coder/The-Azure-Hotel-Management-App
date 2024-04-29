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
    }
}
