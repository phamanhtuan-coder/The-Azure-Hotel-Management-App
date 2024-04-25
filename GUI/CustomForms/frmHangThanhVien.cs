using BLL;
using DTO;
using System;
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
    public partial class frmHangThanhVien : Form
    {
        HangThanhVienBLL hangThanhVienBLL = new HangThanhVienBLL();
        HangThanhVienDTO hangThanhVienDTO = new HangThanhVienDTO();
        public string maHang { get; set; }
        public string tenhang { get; set; }
        public double mucChietKhau { get; set; }
        public bool isAdd { get; set; }

        public frmHangThanhVien()
        {
            InitializeComponent();
        }
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTenHang.Text = tenhang;
            nudChietKhau.Value = (Decimal)mucChietKhau;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa 
            if (isAdd)
            {
                LoadDuLieu();
                // Nếu đúng là form Thêm thì chạy lệnh insert
                if (AddHangThanhVien())
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu hạng thành viên mới!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Đã thêm thất bại dữ liệu hạng thành viên mới!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                // nếu không thì chạy lệnh update
                thongBao = new customMessageBox("Sửa thành công thông tin hạng thành viên đã chọn!");
                thongBao.ShowDialog();
            }
            this.Close();         
        }
        private void LoadDuLieu()
        {
            hangThanhVienDTO.TenHang = txtTenHang.Text;
            hangThanhVienDTO.MucGiamGia = (double) nudChietKhau.Value;
        }
        private bool AddHangThanhVien()
        {
            return hangThanhVienBLL.AddHangThanhVien(hangThanhVienDTO);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
