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
            if (!(lblLoiEmail.Text.Length > 0 || lblLoiSDT.Text.Length > 0 || lblLoiCCCD.Text.Length > 0 || lblLoiNS.Text.Length > 0 || lblLoiHoTen.Text.Length > 0 || lblLoiUsername.Text.Length > 0 || lblLoiPassword.Text.Length > 0 || lblLoiRePassword.Text.Length > 0))
            {
                if (txtPassword.Text == txtRePassword.Text)
                {
                    taiKhoanDTO.TenDangNhap = txtUsername.Text;
                    taiKhoanDTO.MatKhau = Utilities.HashMatKhau.HashPassword(txtPassword.Text);
                    taiKhoanDTO.MaPQ = "KH-01";

                    khachHangDTO.HoTenKH = txtHoTen.Text;
                    khachHangDTO.HinhAnh = ImageToByteArray(cpicAvatar.Image);
                    khachHangDTO.SDT = txtPhone.Text;
                    khachHangDTO.MaLoaiHangThanhVien = 1;
                    khachHangDTO.CCCD = txtCCCD.Text;
                    khachHangDTO.Email = txtEmail.Text;
                    khachHangDTO.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
                    khachHangDTO.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString("MM/dd/yyyy"));
                    khachHangDTO.DiaChi = txtDiaChi.Text;

                    if (AddKhachHang(taiKhoanDTO, khachHangDTO))
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
            else
            {
                thongBao = new customMessageBox("Vui lòng nhập đủ thông tin!");
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
            if (!KiemTraInput.IsValidPhoneNumber(txtPhone.Text))
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
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (KiemTraInput.IsValidUsername(txtUsername.Text))
            {
                lblLoiUsername.Text = "";
            }
            else
            {
                lblLoiUsername.Text = "Username không hợp lệ!";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (KiemTraInput.IsStrongPassword(txtPassword.Text))
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
            if (txtPassword.Text.Equals(txtRePassword.Text))
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
