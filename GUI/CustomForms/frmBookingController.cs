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
    public partial class frmBookingController : Form
    {
        private string username;
        private int maPhong;
        private string ngayDat;
        private int soKhach;

        public frmBookingController()
        {
            InitializeComponent();
        }

        public frmBookingController(string username, int maPhong, string ngayDat, int soKhach)
        {
            InitializeComponent();
            this.username = username;
            this.maPhong = maPhong;
            this.ngayDat = ngayDat;
            this.soKhach = soKhach;
        }

        private void frmBookingController_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            txtUsername.Enabled = false;
            txtUsername.Text = username;
            dtpNgayDat.Enabled = false;
            dtpNgayDat.Text = ngayDat;
            txtMaPHG.Enabled = false;
            txtMaPHG.Text = maPhong.ToString();
            nudSoLuongKhach.Enabled = false;
            nudSoLuongKhach.Value = (decimal) soKhach;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DatPhongDTO datPhong = new DatPhongDTO();
            datPhong.MaPHG = int.Parse(txtMaPHG.Text) ;
            datPhong.SoLuongKH = (int) nudSoLuongKhach.Value;
            datPhong.NgayDatPhong = dtpNgayDat.Value;
            int maKH= (new KhachHangBLL()).LayMaKH(txtUsername.Text.Trim());
            datPhong.MaKH = maKH;
            bool check = (new DatPhongBLL()).them(datPhong);
            customMessageBox thongBao;
            if (check)
            {
                thongBao = new customMessageBox("Đã thêm thành công dữ liệu đặt phòng mới!");
            }
            else
            {
                thongBao = new customMessageBox("Đã thêm thất bại dữ liệu đặt phòng mới!");
            }

            thongBao.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
