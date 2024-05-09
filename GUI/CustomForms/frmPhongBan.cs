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
using BLL;
using Utilities;
namespace GUI.customForm
{
    public partial class frmPhongBan : Form
    {
        //Khai báo biến cho form phòng ban
        public PhongBanDTO phongBanDTO = new PhongBanDTO();
        PhongBanBLL phongBanBLL = new PhongBanBLL();
        public bool isAdd { get; set; }

        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            //Kiểm tra xem form đang được dùng cho mục đích gì? Nếu là thêm thì các trường dữ liệu phải trống
            if (isAdd)
            {
                txtMaPhongBan.Clear();
                txtMaPhongBan.Enabled = true;
                txtTenPB.Clear();
                txtTruongPhong.Clear();
                chkTruongPhong.Checked = false;
                dtpNgayNhanChuc.Value = DateTime.Now;
            }
            else
            {
                //Nếu là form Edit thì sẽ lấy dữ liệu từ DTO và hiển thị lên form
                txtMaPhongBan.Text = phongBanDTO.MaPhongBan;
                txtMaPhongBan.Enabled = false;
                txtTenPB.Text = phongBanDTO.TenPhong;
                //Kiểm tra xem có trưởng phòng không để tránh lỗi Null
                if (phongBanDTO.TruongPhong != 0 )
                {
                    chkTruongPhong.Checked = true;
                    txtTruongPhong.Text = phongBanDTO.TruongPhong.ToString();
                    dtpNgayNhanChuc.Value = phongBanDTO.NgayNhanChuc; 
                }
                else
                {
                    chkTruongPhong.Checked = false;
                }
               
            }


        }
        //Nếu người dùng tạo phòng ban không có trưởng phòng thì sẽ không cho nhập thông tin trưởng phòng
        private void chkTruongPhong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTruongPhong.Checked == true)
            {
                grpThongTinTruongPhong.Enabled = true;

            }
            else
            {
                grpThongTinTruongPhong.Enabled = false;
            }
        }

        //Sự kiện diễn ra khi bấm nút submit
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;

            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            //Lấy dữ liệu sau khi người dùng đã nhập (dùng chung)
            LayDuLieuTuForm(phongBanDTO);
            bool check;
            if (isAdd)
            {
                //Nếu là form thêm thì gọi hàm thêm
                check = phongBanBLL.ThemPhongBanMoi(phongBanDTO);
                //Báo kết quả xử lý
                if (check)
                {
                    thongBao = new customMessageBox("Đã thêm thành công phòng ban mới!");
                   
                }
                else
                {
                    thongBao = new customMessageBox("Thêm thất bại, vui lòng kiểm tra lại!");
                    
                }
               

            }
            else
            {
                //Nếu là form edit thì gọi hàm edit
                check = phongBanBLL.SuaPhongBan(phongBanDTO);
                //Báo kết quả xử lý
                if (check)
                {
                    thongBao = new customMessageBox("Đã sửa thành công phòng ban mới!");
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thất bại, vui lòng kiểm tra lại!");
                }
               
            }
            //Hiển thị câu thông báo
            thongBao.ShowDialog();
            this.Close();
            
        }

        //Gán dữ liệu từ các textbox v.v vào DTO để xử lý
        private void LayDuLieuTuForm(PhongBanDTO phongBanDTO)
        {
            string tenPhongBan = txtTenPB.Text,maPhongBan = txtMaPhongBan.Text; 
            tenPhongBan = KiemTraInput.ChuanHoaHoTen(tenPhongBan);
            maPhongBan = KiemTraInput.ChuanHoaMaPhongBan(maPhongBan);
            phongBanDTO.MaPhongBan = maPhongBan;
            phongBanDTO.TenPhong = tenPhongBan;
            if (chkTruongPhong.Checked == true)
            {
                phongBanDTO.TruongPhong = int.Parse(txtTruongPhong.Text);
                phongBanDTO.NgayNhanChuc = dtpNgayNhanChuc.Value;

            }
            else
            {
                grpThongTinTruongPhong.Enabled = false;
                phongBanDTO.TruongPhong = null;
                phongBanDTO.NgayNhanChuc = DateTime.Now;
            }
            phongBanDTO.TrangThai = true;
        }

        //Bấm Cancel thì đóng form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Kiểm tra việc nhập mã phòng ban chỉ được phép có 2 ký tự và không được nhập số
        private void txtMaPhongBan_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (txtMaPhongBan.Text.Length >= 2 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtMaPhongBan_Leave(object sender, EventArgs e)
        {
            txtMaPhongBan.Text = KiemTraInput.ChuanHoaMaPhongBan(txtMaPhongBan.Text);
        }
    }
}
