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
    public partial class frmThanhToan : Form
    {
        public bool isAdd { get; set; }

        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        public HoaDonDTO hoaDonDTO = new HoaDonDTO();

        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();

        ThueBLL thueBLL = new ThueBLL();
        List<ThueDTO> thueDTOs = new List<ThueDTO>();

        KhuyenMaiBLL khuyenMaiBLL = new KhuyenMaiBLL();
        List<KhuyenMaiDTO> khuyenMaiDTOs = new List<KhuyenMaiDTO>();

        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            txtTongHoaDon.Text = hoaDonDTO.TongHoaDon.ToString("#,##0");
        }       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            CapNhatGiaTri();
            if (hoaDonDTO.TienThoi > -1)
            {
                if (ThanhToan())
                {
                    thongBao = new customMessageBox("Thanh toán thành công!");
                    thongBao.ShowDialog();
                }
                else
                {
                    // nếu không thì chạy lệnh update
                    thongBao = new customMessageBox("Thanh toán thất bại!");
                    thongBao.ShowDialog();
                }
                this.Close();
            }
            else
            {
                thongBao = new customMessageBox("Số tiền nhận chưa đủ!");
                thongBao.ShowDialog();
            }
        }

        private bool ThanhToan()
        {
            return hoaDonBLL.ThanhToan(hoaDonDTO);
        }

        private void CapNhatGiaTri()
        {
            hoaDonDTO.TongHoaDon = decimal.Parse(txtTongHoaDon.Text);
            hoaDonDTO.TienNhan = (decimal) nupNhan.Value;
            hoaDonDTO.TienThoi = (decimal) nupThoi.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nupNhan_ValueChanged(object sender, EventArgs e)
        {
            if (nupNhan.Value >= decimal.Parse(txtTongHoaDon.Text))
            {
                nupThoi.Value = nupNhan.Value - decimal.Parse(txtTongHoaDon.Text);
            }
            else
            {
                nupThoi.Value = -1;
            }
        }
    }
}
