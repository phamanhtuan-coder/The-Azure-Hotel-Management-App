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
        public string username { get; set; }
        public int maPhong { get; set; }
        public string ngayDat { get; set; }
        public int soKhach { get; set; }
        public int maKH { get; set; }
        KhachHangBLL khachHangBLL = new KhachHangBLL();

        public frmBookingController()
        {
            InitializeComponent();
        }

       
        private void frmBookingController_Load(object sender, EventArgs e)
        {
            dtpNgayDat.MinDate = DateTime.Now;
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            txtUsername.Enabled = false;
            txtUsername.Text = khachHangBLL.TruyVanUsername(maKH);
            dtpNgayDat.Enabled = false;
            if (DateTime.Parse(ngayDat) < DateTime.Now)
            {
                dtpNgayDat.Value = DateTime.Now;
            }
            else
            {
                dtpNgayDat.Text = ngayDat;
            }
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
            datPhong.MaKH = this.maKH;
            bool check = (new DatPhongBLL()).them(datPhong);
            customMessageBox thongBao;
            if (check)
            {
                thongBao = new customMessageBox("Đã thêm thành công dữ liệu đặt phòng mới!");
                thongBao.ShowDialog();
            }
            else
            {
                thongBao = new customMessageBox("Đã thêm thất bại dữ liệu đặt phòng mới!");
                thongBao.ShowDialog();
            }
            this.Close();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
