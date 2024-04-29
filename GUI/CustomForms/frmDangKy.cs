using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI.customForm
{
    public partial class frmDangKy : Form
    {      
        TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        KhachHangDTO khachHangDTO = new KhachHangDTO();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                cpicAvatar.Image = Image.FromFile(open.FileName);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            if (txtPassword.Text == txtRePassword.Text)
            {
                taiKhoanDTO.TenDangNhap= txtUsername.Text;
                taiKhoanDTO.MatKhau = txtPassword.Text;
                taiKhoanDTO.MaPQ = "KH-01";
                            
                khachHangDTO.HoTenKH = txtHoTen.Text;
                khachHangDTO.HinhAnh = ImageToByteArray(cpicAvatar.Image);
                khachHangDTO.SDT= txtPhone.Text;
                khachHangDTO.MaLoaiHangThanhVien = 1;
                khachHangDTO.CCCD = txtCCCD.Text;
                khachHangDTO.Email = txtEmail.Text;
                khachHangDTO.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
                khachHangDTO.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString("MM/dd/yyyy"));
                khachHangDTO.DiaChi = txtDiaChi.Text;

                if(AddKhachHang(taiKhoanDTO, khachHangDTO))
                {
                    thongBao = new customMessageBox("Đăng ký thành công!");
                    thongBao.ShowDialog();
                    this.Close();
                }
                else
                {
                    thongBao = new customMessageBox("Đăng ký thất bại!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Mật khẩu không trùng khớp!");
                thongBao.ShowDialog();
            }
        }

        private bool AddKhachHang(TaiKhoanDTO taiKhoanDTO, KhachHangDTO khachHangDTO)
        {
            return khachHangBLL.AddKhachHangBLL(taiKhoanDTO, khachHangDTO);
        }

        private static byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
    }
}
