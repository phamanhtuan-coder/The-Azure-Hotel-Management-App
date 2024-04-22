using System;
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

namespace GUI.customForm
{
    public partial class frmNhanVien : Form
    {
        NhanVienBLL  nhanVienBLL= new NhanVienBLL();
        List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();
        public string username { get; set; }
        public string maNhanVien { get; set; }
        public string maTaikhoan { get; set; }
        public string hoTen { get; set; }
        public string CCCD { get; set; }
        public string ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        public string email { get; set; }
        public Image anhDaiDien { get; set; }
        public bool wasAdd { get; set; }
        public bool isAdd { get; set; }

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên
            txtTenTaiKhoan.Text = username;
            picAvatar.Image = anhDaiDien;
            txtTenTaiKhoan.Text = maTaikhoan;
            txtHoTenNV.Text = hoTen;
            txtCCCD.Text = CCCD;
            if (!string.IsNullOrEmpty(ngaySinh))
            {
                dtpNgaySinh.Value = DateTime.Parse(ngaySinh);
            }
            else
            {
              
            }

            if ( gioiTinh == "Nam") {
                radNam.Checked = true; 
            } else
            {
                radNu.Checked = true;
            }

            txtDiaChi.Text = diaChi;
            txtSDT.Text = soDienThoai;
            txtEmail.Text = email;
            loadNQL();
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
            cboMaNQL.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
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
                thongBao = new customMessageBox("Sửa thành công thông tin nhân viên đã chọn!");
                thongBao.ShowDialog();
            }
            this.Close();
            
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
            if (BienTam.username.Equals(user) && BienTam.kiemtraAdd)
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

    }
}
