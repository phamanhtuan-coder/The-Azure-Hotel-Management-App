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
    public partial class frmHoaDon : Form
    {

        public bool isAdd { get; set; }

        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        public HoaDonDTO hoaDonDTO = new HoaDonDTO();

        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();

        ThueBLL thueBLL = new ThueBLL();
        List<ThueDTO> thueDTOs = new List<ThueDTO>();

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên, néu là edit có giá trị truyền vào thì kiểm tra và chọn giá trị
            LoadDuLieuCombobox();
            if (!isAdd)
            {
                txtMaKH.Text = hoaDonDTO.MaKH.ToString();
                foreach (var item in cboMaNV.DataSource as List<NhanVienDTO>)
                {
                    if(item.MaNV == hoaDonDTO.MaNV)
                    {
                        cboMaNV.SelectedItem = item;
                    }
                }
                foreach (var item in cboMaThue.DataSource as List<ThueDTO>)
                {
                    if (item.MaThue == hoaDonDTO.MaNV)
                    {
                        cboMaThue.SelectedItem = item;
                    }
                }
                dtpNgayDat.Value = hoaDonDTO.NgayLapHoaDon;
                nudTienNhan.Value = hoaDonDTO.TienNhan;
                nudTienThua.Value = hoaDonDTO.TienThoi;
                nudTongTien.Value = hoaDonDTO.TongHoaDon;
            }
        }

        private void LoadDuLieuCombobox()
        {
            LoadTenVaMaNhanVien();
            LoadTenVaMaThue();
        }

        private void LoadTenVaMaThue()
        {
            ThueDTO khong = new ThueDTO();
            khong.TenThue = "None";
            khong.MaThue = -1;
            thueDTOs.Add(khong);
            foreach (ThueDTO item in thueBLL.TruyVanTenVaMaThue())
            {
                thueDTOs.Add(item);
            }
            cboMaThue.DataSource = thueDTOs;
            cboMaThue.DisplayMember = "TenThue";
            cboMaThue.ValueMember = "MaThue";
            cboMaThue.SelectedIndex = 0;
        }

        private void LoadTenVaMaNhanVien()
        {
            NhanVienDTO Khong= new NhanVienDTO();
            Khong.HoTenNV = "None";
            Khong.MaNV = -1;
            nhanVienDTOs.Add(Khong);          
            foreach(NhanVienDTO item in nhanVienBLL.TruyVanTenVaMaNhanVien())
            {
                nhanVienDTOs.Add(item);
            }
            cboMaNV.DataSource = nhanVienDTOs;
            cboMaNV.DisplayMember = "HoTenNV";
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert
                if (AddHoaDon())
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu hóa đơn!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Đã thêm thất bại dữ liệu hóa đơn!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                // nếu không thì chạy lệnh update
                if (EditHoaDon())
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin hóa đơn!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thất bại thông tin hóa đơn!");
                    thongBao.ShowDialog();
                }
            }
            this.Close();
            
        }

        private bool EditHoaDon()
        {
            CapNhatGiaTri();
            return hoaDonBLL.EditHoaDon(hoaDonDTO);
        }

        private bool AddHoaDon()
        {
            CapNhatGiaTri();          
            return hoaDonBLL.AddHoaDon(hoaDonDTO);
        }

        private void CapNhatGiaTri()
        {
            hoaDonDTO.NgayLapHoaDon = DateTime.Parse(dtpNgayDat.Value.ToString("MM/dd/yyyy"));
            hoaDonDTO.MaKH = int.Parse(txtMaKH.Text);
            hoaDonDTO.MaNV = (int)cboMaNV.SelectedValue;
            hoaDonDTO.MaThue = (int)cboMaThue.SelectedValue;
            hoaDonDTO.TongHoaDon = (decimal)nudTongTien.Value;
            hoaDonDTO.TienNhan = (decimal)nudTienNhan.Value;
            hoaDonDTO.TienThoi = (decimal)nudTienThua.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudTongTien_ValueChanged(object sender, EventArgs e)
        {
            if (nudTienNhan.Value > nudTongTien.Value)
            {
                nudTienThua.Value = nudTienNhan.Value - nudTongTien.Value;
            }
            else
            {
                nudTienThua.Value = 0;
            }
        }

        private void nudTienNhan_ValueChanged(object sender, EventArgs e)
        {
            if (nudTienNhan.Value > nudTongTien.Value)
            {
                nudTienThua.Value = nudTienNhan.Value - nudTongTien.Value;
            }
            else
            {
                nudTienThua.Value = 0;
            }
        }
    }
}
