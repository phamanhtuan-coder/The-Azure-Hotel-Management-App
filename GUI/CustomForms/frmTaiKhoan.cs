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
        public TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        RoleBLL roleBLL = new RoleBLL();
        public string password { get; set; }
        public bool isAdd { get; set; }       
        public bool isNhanVien { get; set; }
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadcboMaPhanQuyen();
            if (!isAdd)
            {
                LoadDuLieu();              
            }                            
        }

        private void LoadDuLieu()
        {
            txtUsername.Text = taiKhoanDTO.TenDangNhap;

            foreach (var item in cboPhanQuyen.Items)
            {
                if (item is RoleDTO role && role.MaPhanQuyen == taiKhoanDTO.MaPQ)
                {
                    cboPhanQuyen.SelectedItem = item;
                    break;
                }
            }
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
            LoadThongTin();
            
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                BienTam.kiemtra= AddTaiKhoan();
                if (BienTam.kiemtra)
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
                BienTam.kiemtra = EditTaiKhoan();
                if (BienTam.kiemtra)
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin tài khoản đã chọn!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thất bại thông tin tài khoản đã chọn!");
                    thongBao.ShowDialog();
                }

            }
            this.Close();
            
        }

        private void LoadThongTin()
        {
            taiKhoanDTO.TenDangNhap = txtUsername.Text;
            taiKhoanDTO.MatKhau = txtPassword.Text;
            password = txtRePw.Text;
            taiKhoanDTO.MaPQ = cboPhanQuyen.Text;
        }

        private bool EditTaiKhoan()
        {
            if (taiKhoanDTO.MatKhau.Equals(password))
            {
                taiKhoanDTO.MatKhau = HashPassword(taiKhoanDTO.MatKhau);
                BienTam.username = taiKhoanBLL.EditTaiKhoanBLL(taiKhoanDTO);
                if (BienTam.username.Equals(""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private bool AddTaiKhoan()
        {
            if (taiKhoanDTO.MatKhau.Equals(password))
            {
                taiKhoanDTO.MatKhau = HashPassword(taiKhoanDTO.MatKhau);
                BienTam.username = taiKhoanBLL.AddTaiKhoanBLL(taiKhoanDTO);
                if (BienTam.username.Equals(""))
                {
                    return false;
                }
                else
                {
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
