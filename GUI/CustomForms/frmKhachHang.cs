﻿using BLL;
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
    public partial class frmKhachHang : Form
    {
        public string maKhachHang { get; set; }
        public string maTaikhoan { get; set; }
        public string hoTen { get; set; }
        public string CCCD { get; set; }
        public string ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        public string email { get; set; }
        public Image anhDaiDien { get; set; }

        public string hangThanhVien { get; set; }

        public bool isAdd { get; set; }
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        List<HangThanhVienDTO> hangThanhVienDTOs = new List<HangThanhVienDTO>();

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên
            LoadHangTV();          
            picAvatar.Image = anhDaiDien;
            txtMaTaiKhoan.Text = maTaikhoan;
            txtHoTen.Text = hoTen;
            txtCCCD.Text = CCCD;
            if (!string.IsNullOrEmpty(ngaySinh))
            {
                dtpNgaySinh.Value = DateTime.Parse(ngaySinh);
            }
            else
            {
                
            }

            cboHangTV.Text = hangThanhVien;
            if( gioiTinh == "Nam") {
                radNam.Checked = true; 
            } else
            {
                radNu.Checked = true;
            }

            txtDiaChi.Text = diaChi;
            txtSDT.Text = soDienThoai;
            txtEmail.Text = email;
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
                thongBao = new customMessageBox("Sửa thành công thông tin khách hàng đã chọn!");
                thongBao.ShowDialog();
            }
            this.Close();
            
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
            taoTaiKhoan.ShowDialog();
            //Sau đó thực hiện lệnh query để lấy mã tài khoản vừa tạo và gán mã đó vào biến maTaiKhoan
            string user = khachHangBLL.TruyVanUsernameBLL();
            if (BienTam.username.Equals(user) && BienTam.kiemtraAdd)
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
    }
}
