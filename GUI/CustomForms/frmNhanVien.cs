﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Utilities;
using BLL;
using DTO;
using Syncfusion.XlsIO.Implementation.XmlReaders;

namespace GUI.customForm
{
    public partial class frmNhanVien : Form
    {
        NhanVienBLL  nhanVienBLL= new NhanVienBLL();
        List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();
        public NhanVienDTO nv = new NhanVienDTO();       
        public bool isAdd { get; set; }
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.MaxDate = DateTime.Today.AddYears(-18);
            dtpNgaySinh.Value = dtpNgaySinh.MaxDate;
            radNam.Checked = true;
            loadNQL();
            if (!isAdd)
            {
                LoadBien();
            }
        }

        private void LoadBien()
        {
            if (nv.HinhAnh != null)
            {
                picAvatar.Image = ByteArrayToImage(nv.HinhAnh);
            }
            txtTenTaiKhoan.Text = nv.TenTaiKhoan;
            txtHoTenNV.Text = nv.HoTenNV;
            txtCCCD.Text = nv.CCCD;
            dtpNgaySinh.Value = nv.NgaySinh;
            if (nv.GioiTinh == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtDiaChi.Text = nv.DiaChi;
            txtSDT.Text = nv.SDT;
            txtEmail.Text = nv.Email;
            nupLuong.Value = nv.Luong;
            foreach (var item in cboMaNQL.Items)
            {
                int value = (int)item.GetType().GetProperty(cboMaNQL.ValueMember).GetValue(item);
                if (value == nv.MaNQL)
                {
                    cboMaNQL.SelectedItem = item;
                    break;
                }
            }
        }

        private void loadNQL()
        {
            NhanVienDTO TatCa = new NhanVienDTO();
            TatCa.MaNV = -1;
            TatCa.HoTenNV = "Không có";
            nhanVienDTOs.Add(TatCa);
            List<NhanVienDTO> tam = nhanVienBLL.LoadIDAndNameBLL();
            foreach (var item in tam)
            {
                nhanVienDTOs.Add(item);
            }
            cboMaNQL.DataSource = nhanVienDTOs;
            cboMaNQL.DisplayMember = "HoTenNV";
            cboMaNQL.ValueMember = "MaNV";          
            if (isAdd)
            {
                cboMaNQL.SelectedIndex = 0;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (!(lblLoiEmail.Text.Length>0 || lblLoiSDT.Text.Length>0 || lblLoiCCCD.Text.Length>0 || lblLoiNS.Text.Length > 0 ||lblLoiHoTen.Text.Length>0 || lblLoiLuong.Text.Length>0 || lblLoiUsername.Text.Length>0))
            {
                if (isAdd)
                {
                    if (AddTaiKhoan())
                    {
                        thongBao = new customMessageBox("Đã thêm thành công dữ liệu nhân viên mới!");
                        thongBao.ShowDialog();
                    }
                    else
                    {
                        thongBao = new customMessageBox("Đã thêm thất bại dữ liệu nhân viên mới!");
                        thongBao.ShowDialog();
                    }
                }
                else
                {
                    // nếu không thì chạy lệnh update
                    if (EditNhanVien())
                    {
                        thongBao = new customMessageBox("Sửa thành công thông tin nhân viên đã chọn!");
                        thongBao.ShowDialog();
                    }
                    else
                    {
                        thongBao = new customMessageBox("Sửa thất bại thông tin nhân viên đã chọn!");
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

        private bool AddTaiKhoan()
        {        
            NhanVienDTO nhanvien= new NhanVienDTO();
            nhanvien.HinhAnh = ImageToByteArray(picAvatar.Image);
            nhanvien.HoTenNV=txtHoTenNV.Text;
            nhanvien.CCCD=txtCCCD.Text;
            nhanvien.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string ns = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            nhanvien.NgaySinh = DateTime.Parse(ns);
            nhanvien.Email= txtEmail.Text;
            nhanvien.SDT=txtSDT.Text;
            nhanvien.DiaChi=txtDiaChi.Text;
            nhanvien.TenTaiKhoan = txtTenTaiKhoan.Text;
            nhanvien.MaNQL=(int)cboMaNQL.SelectedValue;
            nhanvien.Luong=nupLuong.Value;
            return nhanVienBLL.AddNhanVienBLL(nhanvien);
        }

        private bool EditNhanVien()
        {
            NhanVienDTO nhanvien = new NhanVienDTO();
            if (nv != null)
            {
                nhanvien.MaNV = nv.MaNV; 

                if (picAvatar.Image != null)
                {
                    nhanvien.HinhAnh = ImageToByteArray(picAvatar.Image);
                }

                if (!string.IsNullOrEmpty(txtHoTenNV.Text)) 
                {
                    nhanvien.HoTenNV = txtHoTenNV.Text;
                }

                if (!string.IsNullOrEmpty(txtCCCD.Text))
                {
                    nhanvien.CCCD = txtCCCD.Text;
                }

                nhanvien.GioiTinh = radNam.Checked ? "Nam" : "Nữ";

                string ns = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                nhanvien.NgaySinh = DateTime.Parse(ns);

                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    nhanvien.Email = txtEmail.Text;
                }

                if (!string.IsNullOrEmpty(txtSDT.Text))
                {
                    nhanvien.SDT = txtSDT.Text;
                }

                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    nhanvien.DiaChi = txtDiaChi.Text;
                }

                if (!string.IsNullOrEmpty(txtTenTaiKhoan.Text))
                {
                    nhanvien.TenTaiKhoan = txtTenTaiKhoan.Text;
                }

                if (cboMaNQL.SelectedValue != null)
                {
                    nhanvien.MaNQL = (int)cboMaNQL.SelectedValue;
                }

                nhanvien.Luong = nupLuong.Value;
            }
            return nhanVienBLL.EditNhanVienBLL(nhanvien);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            frmTaiKhoan taoTaiKhoan = new frmTaiKhoan();
            taoTaiKhoan.isAdd = true;
            taoTaiKhoan.isNhanVien = true;
            taoTaiKhoan.ShowDialog();
            //Sau đó thực hiện lệnh query để lấy mã tài khoản vừa tạo và gán mã đó vào biến maTaiKhoan
            
            string user= nhanVienBLL.TruyVanUsernameBLL();
            if (BienTam.username.Equals(user) && BienTam.kiemtra)
            {
                txtTenTaiKhoan.Text =user;
            }            
        }
        
        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image= Image.FromFile(open.FileName);
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

        private void txtHoTenNV_Leave(object sender, EventArgs e)
        {
            if (KiemTraInput.KiemTraHoTen(txtHoTenNV.Text))
            {
                lblLoiHoTen.Text = "";
                txtHoTenNV.Text = KiemTraInput.ChuanHoaHoTen(txtHoTenNV.Text);
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

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nupLuong_ValueChanged(object sender, EventArgs e)
        {
            decimal luong = nupLuong.Value;

            if (luong <= 0)
            {
                lblLoiLuong.Text = "Lương không hợp lệ!";
            }
            else
            {
                lblLoiLuong.Text = "";
            }
        }

        private void txtTenTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (!KiemTraInput.IsValidUsername(txtTenTaiKhoan.Text))
            {
                lblLoiUsername.Text = "Username Không hợp lệ!";
            }
            else
            {
                lblLoiUsername.Text = "";
            }
        }
    }
}
