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
using Utilities;

namespace GUI.customForm
{
    public partial class frmKhachHang : Form
    {
        public bool isAdd { get; set; }
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        public KhachHangDTO khachHangDTO= new KhachHangDTO();
        List<HangThanhVienDTO> hangThanhVienDTOs = new List<HangThanhVienDTO>();

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.Value = DateTime.Today.AddYears(-18);
            radNam.Checked = true;
            // gán giá trị mặc định bằng các biến trên
            LoadHangTV();

            if (!isAdd)
            {
                LoadBien();
            }
        }

        private void LoadBien()
        {
            if (khachHangDTO.HinhAnh != null)
            {
                picAvatar.Image = ByteArrayToImage(khachHangDTO.HinhAnh);
            }
            txtHoTen.Text = khachHangDTO.HoTenKH;
            txtCCCD.Text = khachHangDTO.CCCD;
            dtpNgaySinh.Value = khachHangDTO.NgaySinh;
            if (khachHangDTO.GioiTinh == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtDiaChi.Text = khachHangDTO.DiaChi;
            txtSDT.Text = khachHangDTO.SDT;
            txtEmail.Text = khachHangDTO.Email;
            cboHangTV.SelectedValue = khachHangDTO.MaLoaiHangThanhVien;
            txtMaTaiKhoan.Text = khachHangDTO.TenDangNhap;
        }

        private void LoadHangTV()
        {
            HangThanhVienBLL hangThanhVienBLL = new HangThanhVienBLL();
            List<HangThanhVienDTO> tam = hangThanhVienBLL.LoadIDAndNameBLL();
            foreach (var item in tam)
            {
                hangThanhVienDTOs.Add(item);
            }
            cboHangTV.DataSource = hangThanhVienDTOs;
            cboHangTV.DisplayMember = "TenHang";
            cboHangTV.ValueMember = "MaLoaiHangThanhVien";
            if (isAdd)
            {
                cboHangTV.SelectedIndex = 0;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            if (!(lblLoiEmail.Text.Length > 0 || lblLoiSDT.Text.Length > 0 || lblLoiCCCD.Text.Length > 0 || lblLoiNS.Text.Length > 0 || lblLoiHoTen.Text.Length > 0 || lblLoiUsername.Text.Length > 0))
            {
                // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa 
                if (isAdd)
                {
                    // Nếu đúng là form Thêm thì chạy lệnh insert

                    if (AddKhachHang())
                    {
                        thongBao = new customMessageBox("Đã thêm thành công dữ liệu khách hàng mới!");
                        thongBao.ShowDialog();
                    }
                    else
                    {
                        thongBao = new customMessageBox("Đã thêm thất bại dữ liệu khách hàng mới!");
                        thongBao.ShowDialog();
                    }


                }
                else
                {
                    // nếu không thì chạy lệnh update
                    if (EditKhachHang())
                    {
                        thongBao = new customMessageBox("Sửa thành công thông tin khách hàng đã chọn!");
                        thongBao.ShowDialog();
                    }
                    else
                    {
                        thongBao = new customMessageBox("Sửa thất bại thông tin khách hàng đã chọn!");
                        thongBao.ShowDialog();
                    }

                }
                this.Close();
            }
            else
            {
                thongBao = new customMessageBox("Vui lòng nhập đúng thông tin!");
                thongBao.ShowDialog();
            }
            
        }

        private bool EditKhachHang()
        {
            KhachHangDTO khachHang = new KhachHangDTO();
            khachHang.MaKH = khachHangDTO.MaKH;
            khachHang.TenDangNhap = txtMaTaiKhoan.Text;
            khachHang.MaLoaiHangThanhVien = (int)cboHangTV.SelectedValue;
            khachHang.HinhAnh = ImageToByteArray(picAvatar.Image);
            khachHang.HoTenKH = txtHoTen.Text;
            khachHang.SDT = txtSDT.Text;
            khachHang.Email = txtEmail.Text;
            khachHang.CCCD = txtCCCD.Text;
            string ns = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            khachHang.NgaySinh = DateTime.Parse(ns);
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
            return khachHangBLL.EditKhachHangBLL(khachHang);
        }

        private bool AddKhachHang()
        {
            KhachHangDTO khachHang = new KhachHangDTO();
            khachHang.TenDangNhap = txtMaTaiKhoan.Text;
            khachHang.MaLoaiHangThanhVien = (int) cboHangTV.SelectedValue;
            khachHang.HinhAnh = ImageToByteArray(picAvatar.Image);
            khachHang.HoTenKH = txtHoTen.Text;
            khachHang.SDT = txtSDT.Text;
            khachHang.Email = txtEmail.Text;
            khachHang.CCCD = txtCCCD.Text;
            string ns = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            khachHang.NgaySinh = DateTime.Parse(ns);
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
            return khachHangBLL.AddKhachHangBLL(khachHang);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            frmTaiKhoan taoTaiKhoan = new frmTaiKhoan();
            taoTaiKhoan.isAdd = true;
            taoTaiKhoan.isKhachHang = true;
            taoTaiKhoan.ShowDialog();
            //Sau đó thực hiện lệnh query để lấy mã tài khoản vừa tạo và gán mã đó vào biến maTaiKhoan
            string user = khachHangBLL.TruyVanUsernameBLL();
            if (BienTam.username.Equals(user) && BienTam.kiemtra)
            {
                txtMaTaiKhoan.Text = user;
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image = Image.FromFile(open.FileName);
            }
        }

        private static byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        Image ByteArrayToImage(byte[] hinh)
        {
            using (MemoryStream m = new MemoryStream(hinh))
            {
                return Image.FromStream(m);
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (KiemTraInput.KiemTraHoTen(txtHoTen.Text))
            {
                lblLoiHoTen.Text = "";
                txtHoTen.Text = KiemTraInput.ChuanHoaHoTen(txtHoTen.Text);
            }
            else
            {
                lblLoiHoTen.Text = "Họ tên không hợp lệ!";
            }
        }

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            if (!KiemTraInput.IsValuesCCCD(txtCCCD.Text))
            {
                lblLoiCCCD.Text = "CCCD Không hợp lệ!";
            }
            else
            {
                lblLoiCCCD.Text = "";
            }
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if (!KiemTraInput.KiemTraNgaySinh(dtpNgaySinh.Value))
            {
                lblLoiNS.Text = "Ngày sinh Không hợp lệ, phải đủ 18 tuổi!";
            }
            else
            {
                lblLoiNS.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!KiemTraInput.IsValidEmail(txtEmail.Text))
            {
                lblLoiEmail.Text = "Email không hợp lệ!";
            }
            else
            {
                lblLoiEmail.Text = "";
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (!KiemTraInput.IsValidPhoneNumber(txtSDT.Text))
            {
                lblLoiSDT.Text = "SDT Không hợp lệ!";
            }
            else
            {
                lblLoiSDT.Text = "";
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
