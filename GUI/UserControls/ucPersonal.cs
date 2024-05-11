using BLL;
using DTO;
using GUI.customForm;
using Syncfusion.MIME;
using Syncfusion.WinForms.ListView;
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

namespace GUI.UserControls
{
    public partial class ucPersonal : UserControl
    {

        public ucPersonal()
        {
            InitializeComponent();
        }

        private frmMain _parentForm;
        public NhanVienDTO user = new NhanVienDTO();
        public KhachHangDTO userKH = new KhachHangDTO();


        public ucPersonal(frmMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void ucPersonal_Load(object sender, EventArgs e)
        {
            picAva.SizeMode = PictureBoxSizeMode.Zoom;
            dtpNgaySinh.MaxDate = DateTime.Now.AddYears(-18);
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            if (user != null)
            {
                panCustomerController.Enabled = false;
                panCustomerController.Visible = false;
                txtHoTen.Text = user.HoTenNV;
                txtCCCD.Text = user.CCCD;
                txtEmail.Text = user.Email;
                txtSDT.Text = user.SDT;
                rtxtDiaChi.Text = user.DiaChi;
                if (user.HinhAnh != null)
                {
                    Image hinhAnh = ByteArrayToImage(user.HinhAnh);
                    picAva.Image = hinhAnh;
                }
                else
                {
                    Image profile = Properties.Resources.Profile.ToBitmap();
                    picAva.Image = profile;
                }
                dtpNgaySinh.Value = user.NgaySinh;
                if (user.GioiTinh == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
            }
            else
            {
                panCustomerController.Enabled = true;
                panCustomerController.Visible = true;
                txtHoTen.Text = userKH.HoTenKH;
                txtCCCD.Text = userKH.CCCD;
                txtEmail.Text = userKH.Email;
                txtSDT.Text = userKH.SDT;
                rtxtDiaChi.Text = userKH.DiaChi;
                if (userKH.HinhAnh != null)
                {
                    Image hinhAnh = ByteArrayToImage(userKH.HinhAnh);
                    picAva.Image = hinhAnh;
                }
                else
                {
                    Image profile = Properties.Resources.Profile.ToBitmap();
                    picAva.Image = profile;
                }
                dtpNgaySinh.Value = userKH.NgaySinh;
                HangThanhVienBLL hangThanhVien = new HangThanhVienBLL();
                List<HangThanhVienDTO> dsHang = hangThanhVien.dgvHNV();
                cboHangTV.DataSource = dsHang;
                cboHangTV.DisplayMember = "TenHang";
                cboHangTV.ValueMember = "MaLoaiHangThanhVien";
                cboHangTV.SelectedValue = userKH.MaLoaiHangThanhVien;
                if (userKH.GioiTinh == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
            }
        }

        private void btnLichSuDP_Click(object sender, EventArgs e)
        {
            frmMain parentForm = this.ParentForm as frmMain;
            ucBookingHistory ucBookingHistory = new ucBookingHistory(parentForm);
            ucBookingHistory.maKH= this.userKH.MaKH;
            parentForm.SwitchUserControl(ucBookingHistory);
            this.Dispose();
        }

        private void btnTraCuuDanhGia_Click(object sender, EventArgs e)
        {
            frmMain parentForm = this.ParentForm as frmMain;
            ucRatingHistory ucRatingHistory = new ucRatingHistory(parentForm);
            ucRatingHistory.maKH = this.userKH.MaKH;
            parentForm.SwitchUserControl(ucRatingHistory);
            this.Dispose();
        }

        private void btnTraCuuHD_Click(object sender, EventArgs e)
        {
            frmMain parentForm = this.ParentForm as frmMain;
            ucBillHistory ucBillHistory = new ucBillHistory(parentForm);
            ucBillHistory.maKH = this.userKH.MaKH;
            parentForm.SwitchUserControl(ucBillHistory);
            this.Dispose();
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

        private void picAva_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                picAva.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao = new customMessageBox("Bạn có chắc chắn muốn cập nhật hình ảnh?");
            DialogResult dr = thongBao.ShowDialog();
            if (dr==DialogResult.OK)
            {
                byte[] Image = ImageToByteArray(picAva.Image);
                if (user != null)
                {
                    NhanVienBLL nhanVienBLL = new NhanVienBLL();
                    
                    if (nhanVienBLL.CapNhatHinhAnh(user.MaNV, Image))
                    {
                        thongBao = new customMessageBox("Cập nhật hình ảnh cho nhân viên thành công!");
                        user.HinhAnh = Image;
                        frmMain parentForm = this.ParentForm as frmMain;
                        parentForm.user.HinhAnh = user.HinhAnh;
                    }
                    else
                    {
                        thongBao = new customMessageBox("Cập nhật hình ảnh cho nhân viên thất bại!");
                    }
                }
                else
                {
                    KhachHangBLL khachHangBLL = new KhachHangBLL();
                    if (khachHangBLL.CapNhatHinhAnh(userKH.MaKH, Image))
                    {
                      thongBao = new customMessageBox("Cập nhật hình ảnh cho khách hàng thành công!");
                      userKH.HinhAnh = Image;
                      frmMain parentForm = this.ParentForm as frmMain;
                      parentForm.userKH.HinhAnh = userKH.HinhAnh;
                    }
                    else
                    {
                       thongBao = new customMessageBox("Cập nhật hình ảnh cho khách hàng thất bại!");
                    }
                }
                thongBao.ShowDialog();
               
            }
            
            
          
        }

        private void btnResetThongTin_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                panCustomerController.Enabled = false;
                panCustomerController.Visible = false;
                txtHoTen.Text = user.HoTenNV;
                txtCCCD.Text = user.CCCD;
                txtEmail.Text = user.Email;
                txtSDT.Text = user.SDT;
                rtxtDiaChi.Text = user.DiaChi;
                if (user.HinhAnh != null)
                {
                    Image hinhAnh = ByteArrayToImage(user.HinhAnh);
                    picAva.Image = hinhAnh;
                }
                else
                {
                    Image profile = Properties.Resources.Profile.ToBitmap();
                    picAva.Image = profile;
                }
                dtpNgaySinh.Value = user.NgaySinh;
                if (user.GioiTinh == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
            }
            else
            {
                panCustomerController.Enabled = true;
                panCustomerController.Visible = true;
                txtHoTen.Text = userKH.HoTenKH;
                txtCCCD.Text = userKH.CCCD;
                txtEmail.Text = userKH.Email;
                txtSDT.Text = userKH.SDT;
                rtxtDiaChi.Text = userKH.DiaChi;
                if (userKH.HinhAnh != null)
                {
                    Image hinhAnh = ByteArrayToImage(userKH.HinhAnh);
                    picAva.Image = hinhAnh;
                }
                else
                {
                    Image profile = Properties.Resources.Profile.ToBitmap();
                    picAva.Image = profile;
                }
                dtpNgaySinh.Value = userKH.NgaySinh;
                HangThanhVienBLL hangThanhVien = new HangThanhVienBLL();
                List<HangThanhVienDTO> dsHang = hangThanhVien.dgvHNV();
                cboHangTV.DataSource = dsHang;
                cboHangTV.DisplayMember = "TenHang";
                cboHangTV.ValueMember = "MaLoaiHangThanhVien";
                cboHangTV.SelectedValue = userKH.MaLoaiHangThanhVien;
                if (userKH.GioiTinh == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            if (string.IsNullOrWhiteSpace(txtHoTen.Text.Trim()) || string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) || string.IsNullOrWhiteSpace(txtSDT.Text.Trim()) || string.IsNullOrWhiteSpace(rtxtDiaChi.Text.Trim()))
            {
                thongBao = new customMessageBox("Không được bỏ trống các trường dữ liệu!");
                return;
            }
            if (user != null)
            {
                if (CapNhatNhanVien())
                {
                    NhanVienBLL nhanVienBLL = new NhanVienBLL();
                    thongBao = new customMessageBox("Cập nhật thông tin nhân viên thành công!");
                    thongBao.ShowDialog();
                    frmMain parentForm = this.ParentForm as frmMain;
                    parentForm.user = nhanVienBLL.TimNV(user.MaTaiKhoan);
                    user = parentForm.user;
                    parentForm.LoadTenUser();
                    parentForm.LoadHinhAnhUser();
                    LoadDuLieu();
                }
                else
                {
                    thongBao = new customMessageBox("Cập nhật thông tin nhân viên thất bại!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                if (CapNhatKhachHang())
                {
                    KhachHangBLL khachHangBLL = new KhachHangBLL();
                    thongBao = new customMessageBox("Cập nhật thông tin khách hàng thành công!");
                    thongBao.ShowDialog();
                    frmMain parentForm = this.ParentForm as frmMain;
                    parentForm.userKH = khachHangBLL.TimKH(userKH.MaTaiKhoan);
                    userKH = parentForm.userKH;
                    parentForm.LoadTenUser();
                    parentForm.LoadHinhAnhUser();
                    LoadDuLieu();
                }
                else
                {
                    thongBao = new customMessageBox("Cập nhật thông tin khách hàng thất bại!");
                    thongBao.ShowDialog();
                }
            }   
        }

        private bool CapNhatKhachHang()
        {
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            KhachHangDTO khachHangDTO = new KhachHangDTO();
            khachHangDTO.MaKH = userKH.MaKH;
            khachHangDTO.HoTenKH = KiemTraInput.ChuanHoaHoTen(txtHoTen.Text.Trim());
            khachHangDTO.Email = txtEmail.Text.Trim();
            khachHangDTO.SDT = txtSDT.Text.Trim();
            khachHangDTO.DiaChi = rtxtDiaChi.Text.Trim();
            Byte[] hinhAnh = ImageToByteArray(picAva.Image);
            khachHangDTO.HinhAnh = hinhAnh;
            khachHangDTO.NgaySinh = dtpNgaySinh.Value;
            if (radNam.Checked)
            {
                khachHangDTO.GioiTinh = "Nam";
            }
            else
            {
                khachHangDTO.GioiTinh = "Nữ";
            }
            return khachHangBLL.EditKhachHang(khachHangDTO);

        }

        private bool CapNhatNhanVien()
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            NhanVienDTO nhanVienDTO = new NhanVienDTO();
            nhanVienDTO.MaNV = user.MaNV;
            nhanVienDTO.HoTenNV = KiemTraInput.ChuanHoaHoTen( txtHoTen.Text.Trim());
            nhanVienDTO.Email = txtEmail.Text.Trim();
            nhanVienDTO.SDT = txtSDT.Text.Trim();
            nhanVienDTO.DiaChi = rtxtDiaChi.Text.Trim();
            Byte[] hinhAnh= ImageToByteArray(picAva.Image);
            nhanVienDTO.HinhAnh = hinhAnh;
            nhanVienDTO.NgaySinh = dtpNgaySinh.Value;
            if (radNam.Checked)
            {
                nhanVienDTO.GioiTinh = "Nam";
            }
            else
            {
                nhanVienDTO.GioiTinh = "Nữ";
            }

            return nhanVienBLL.EditNhanVien(nhanVienDTO);

        }

        private void btnResetPW_Click(object sender, EventArgs e)
        {
            txtPW.Clear();
            txtPWNew.Clear();
            txtRePw.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            if ( string.IsNullOrWhiteSpace( txtPW.Text.Trim()) || string.IsNullOrWhiteSpace(txtRePw.Text.Trim()) || string.IsNullOrWhiteSpace(txtPWNew.Text.Trim())) 
            {
                thongBao = new customMessageBox("Không được bỏ trống các trường dữ liệu!");
                return;
            }
            if (DoiMatKhau())
            {

                thongBao = new customMessageBox("Đổi mật khẩu thành công!");
                thongBao.ShowDialog();
                
            }
            else
            {
                thongBao = new customMessageBox("Đổi mật khẩu thất bại!");
                thongBao.ShowDialog();
            }
        }

        private bool DoiMatKhau()
        {
            TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
            TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO(); 
            if (txtPWNew.Text.Equals(txtRePw.Text))
            {
                if (( user !=null))
                {
                    taiKhoanDTO.MaTaiKhoan= user.MaTaiKhoan;
                }
                else
                {
                    taiKhoanDTO.MaTaiKhoan= userKH.MaTaiKhoan;
                }
                taiKhoanDTO.MatKhau = Utilities.HashMatKhau.HashPassword(txtPWNew.Text);

                return taiKhoanBLL.DoiMatKhauMa(taiKhoanDTO);
            }
            return false;
        }

    }
}
