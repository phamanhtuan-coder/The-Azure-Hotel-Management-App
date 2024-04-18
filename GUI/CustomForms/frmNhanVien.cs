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

namespace GUI.customForm
{
    public partial class frmNhanVien : Form
    {
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
        public bool isAdd { get; set; }

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên
            txtMaTaiKhoan.Text = username;
            picAvatar.Image = anhDaiDien;
            txtMaTaiKhoan.Text = maTaikhoan;
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
            return false;
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
            txtMaTaiKhoan.Text = Program.username;
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image= Image.FromFile(open.FileName);
                this.Text = open.FileName;
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
