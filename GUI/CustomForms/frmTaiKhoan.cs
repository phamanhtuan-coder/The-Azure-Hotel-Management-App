using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace GUI.customForm
{
    public partial class frmTaiKhoan : Form
    {
        TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        RoleBLL roleBLL = new RoleBLL();
        public string password { get; set; }
        public bool isAdd { get; set; }        
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên, néu là edit có giá trị truyền vào thì kiểm tra và chọn giá trị
            txtUsername.Text = taiKhoanDTO.TenDangNhap;
            txtPassword.Text = taiKhoanDTO.MatKhau;
            txtRePw.Text = password;
            cboPhanQuyen.Text = taiKhoanDTO.MaPQ;
            LoadcboMaPhanQuyen();         
        }

        private void LoadcboMaPhanQuyen()
        {
            List<RoleDTO> roles = roleBLL.LoadMaPhanQuyen();
            cboPhanQuyen.DataSource = roles;
            cboPhanQuyen.DisplayMember = "MaPhanQuyen";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            taiKhoanDTO.TenDangNhap= txtUsername.Text;
            taiKhoanDTO.MatKhau=txtPassword.Text;
            password=txtRePw.Text;
            taiKhoanDTO.MaPQ = cboPhanQuyen.Text;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                if (AddTaiKhoan())
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu tài khoản mới!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Đã thêm thất bại dữ liệu tài khoản mới!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                // nếu không thì chạy lệnh update
                thongBao = new customMessageBox("Sửa thành công thông tin tài khoản đã chọn!");
                thongBao.ShowDialog();
            }
            this.Close();
            
        }

        private bool AddTaiKhoan()
        {
            if (taiKhoanDTO.MatKhau.Equals(password))
            {
                taiKhoanDTO.MatKhau = HashPassword(taiKhoanDTO.MatKhau);
                string a = taiKhoanBLL.AddTaiKhoanBLL(taiKhoanDTO);
                if (a.Equals(""))
                {
                    return false;
                }
                else
                {
                    Program.username = a;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder chuoiMatKhau = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    chuoiMatKhau.Append(bytes[i].ToString("x2"));
                }
                return chuoiMatKhau.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
