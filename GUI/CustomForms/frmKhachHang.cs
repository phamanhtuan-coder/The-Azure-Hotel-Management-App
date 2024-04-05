﻿using System;
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

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên
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

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa 
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert

                thongBao = new customMessageBox("Đã thêm thành công dữ liệu khách hàng mới!");
                thongBao.ShowDialog();

            }
            else
            {
                // nếu không thì chạy lệnh update
                thongBao = new customMessageBox("Sửa thành công thông tin khách hàng đã chọn!");
                thongBao.ShowDialog();
            }
            this.Close();
            
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
            maTaikhoan = "mã vừa tạo";
            txtMaTaiKhoan.Text = maTaikhoan;
        }
    }
}