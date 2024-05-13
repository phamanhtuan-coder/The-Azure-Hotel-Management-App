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
    public partial class frmDanhGia : Form
    {
      customMessageBox thongBao;
        public bool isAdd { get; set; }
        public DanhGiaDTO danhGia = new DanhGiaDTO();
        DanhGiaBLL danhGiaBLL = new DanhGiaBLL();
        List<DatPhongDTO> lichSuDat= new List<DatPhongDTO>();
        public int maKH { set; get; }
        public frmDanhGia()
        {
            InitializeComponent();
        }

        private void frmDanhGia_Load(object sender, EventArgs e)
        {
            
            LoadDuLieuMaDP();
            LoadDuLieuChoForm();
            dtpNgayDG.MaxDate = DateTime.Now;

        }

        private void LoadDuLieuMaDP()
        {
            DatPhongBLL timPhong= new DatPhongBLL();
            if (isAdd)
            {
                lichSuDat = timPhong.LayDanhSachDatPhongChuaDanhGia(maKH);
            }
            else
            {
                lichSuDat = timPhong.LayDanhSachDatPhongDaDanhGia(maKH);
            }
            cboMaDP.DataSource = lichSuDat;
            cboMaDP.DisplayMember = "MaDatPhong";
            cboMaDP.ValueMember = "MaDatPhong";
        }

        private void LoadDuLieuChoForm()
        {
            if (isAdd)
            {
                if (lichSuDat == null)
                {
                    thongBao = new customMessageBox("Bạn không có lịch sử đặt phòng chưa được đánh giá!");
                    return;
                }
                cboMaDP.SelectedIndex = 0;
                cboMaDP.Enabled = true;
                
                dtpNgayDG.Value = dtpNgayDG.MaxDate;
                rtxtNhanXet.Clear();
                rcDiemDG.Value = 0;
            }
            else
            {
                cboMaDP.SelectedValue=danhGia.MaDP;
                cboMaDP.Enabled = false;
                dtpNgayDG.Value = danhGia.NgayDanhGia;

                rtxtNhanXet.Text = danhGia.NhanXet;
                rcDiemDG.Value = danhGia.DiemDanhGia;
            }
            

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa 
            if (isAdd)
            {
                if ( string.IsNullOrWhiteSpace( rtxtNhanXet.Text.Trim()))
                {
                    thongBao = new customMessageBox("Nhận xét không được phép bỏ trống!");
                    thongBao.ShowDialog();
                    return; 
                }
                // Nếu đúng là form Thêm thì chạy lệnh insert
                if (ThemDanhGia())
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu đánh giá mới!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Thêm thất bại dữ liệu đánh giá mới!");
                    thongBao.ShowDialog();
                }

            }
            else
            {
                if (SuaDanhGia())
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin đánh giá đã chọn!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thất bại thông tin đánh giá đã chọn!");
                    thongBao.ShowDialog();
                }
               
            }
            this.Close();
            
        }

        private bool SuaDanhGia()
        {
            ganGiaTriChoBien();
            bool check = danhGiaBLL.SuaDanhGia(danhGia);
            return check;
        }

        private bool ThemDanhGia()
        {
            ganGiaTriChoBien();
            bool check = danhGiaBLL.ThemDanhGia(danhGia);
            return check;
        }

        private void ganGiaTriChoBien()
        {
            danhGia.MaDP = int.TryParse(cboMaDP.Text, out int maDP) ? maDP : 0;

            danhGia.NgayDanhGia = dtpNgayDG.Value;

            danhGia.NhanXet = rtxtNhanXet.Text;

            if (rcDiemDG.Value > 0 && rcDiemDG.Value < 6)
            {
                danhGia.DiemDanhGia = (int)rcDiemDG.Value;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
