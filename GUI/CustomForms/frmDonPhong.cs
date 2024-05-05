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
    public partial class frmDonPhong : Form
    {

        public bool isAdd { get; set; }

        public DonPhongDTO donPhongDTO = new DonPhongDTO();
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        PhongBLL phongBLL = new PhongBLL();
        DonPhongBLL donPhongBLL = new DonPhongBLL();

        public frmDonPhong()
        {
            InitializeComponent();
        }

        private void frmDonPhong_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên, néu là edit có giá trị truyền vào thì kiểm tra và chọn giá trị
            LoadDuLieuNhanVienDonPhong();
            LoadDuLieuMaPhong();

            if (!isAdd)
            {
                foreach (PhongDTO item in cboThietBi.DataSource as List<PhongDTO>)
                {
                    if (item.MaPHG == donPhongDTO.MaPhong)
                    {
                        cboThietBi.SelectedItem = item;
                    }
                }
                foreach (NhanVienDTO item in cboNVBaoTri.DataSource as List<NhanVienDTO>)
                {
                    if (item.MaNV == donPhongDTO.MaNV)
                    {
                        cboNVBaoTri.SelectedItem = item;
                    }
                }

                dtpNgayHuHong.Value = donPhongDTO.NgayNhan;

                if (donPhongDTO.NgayHoanThanh.HasValue)
                {
                    dtpNgayBaoTri.Value = donPhongDTO.NgayHoanThanh.Value;
                }
                else
                {
                    dtpNgayBaoTri.Value = DateTime.Now;
                }

            }
            else
            {
                cboThietBi.SelectedIndex = 0;
                cboNVBaoTri.SelectedIndex = 0;
                dtpNgayBaoTri.Value = DateTime.Now;
                dtpNgayHuHong.Value = DateTime.Now;
            }
        }

        private void LoadDuLieuMaPhong()
        {
            PhongDTO TatCa = new PhongDTO();
            TatCa.MaPHG = -1;
            List<PhongDTO> list = new List<PhongDTO> { TatCa };
            foreach (var item in phongBLL.laydsp())
            {
                list.Add(item);
            }
            cboThietBi.DataSource = list;
            cboThietBi.DisplayMember = "MaPHG";
            cboThietBi.ValueMember = "MaPHG";
            cboThietBi.SelectedIndex = 0;
        }

        private void LoadDuLieuNhanVienDonPhong()
        {
            NhanVienDTO TatCa = new NhanVienDTO();
            TatCa.MaNV = -1;
            TatCa.HoTenNV = "None";
            List<NhanVienDTO> list = new List<NhanVienDTO> { TatCa };
            foreach (var item in nhanVienBLL.LoadIDAndNameBLLDonPhong())
            {
                list.Add(item);
            }
            cboNVBaoTri.DataSource = list;
            cboNVBaoTri.DisplayMember = "HoTenNV";
            cboNVBaoTri.ValueMember = "MaNV";
            cboNVBaoTri.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            GanDuLieu();
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                
                // Nếu đúng là form Thêm thì chạy lệnh insert
                if (AddDonPhong())
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu dọn phòng!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu dọn phòng!");
                    thongBao.ShowDialog();
                }                
            }
            else
            {
                // nếu không thì chạy lệnh update
                if (EditDonPhong())
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin dọn phòng!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin dọn phòng!");
                    thongBao.ShowDialog();
                }
                
            }
            this.Close();
            
        }

        private bool EditDonPhong()
        {
            return donPhongBLL.EditDonPhong(donPhongDTO);
        }

        private bool AddDonPhong()
        {
            return donPhongBLL.AddDonPhong(donPhongDTO);
        }

        private void GanDuLieu()
        {
            donPhongDTO.MaNV = (int) cboNVBaoTri.SelectedValue;
            donPhongDTO.MaPhong = (int)cboThietBi.SelectedValue;
            donPhongDTO.NgayNhan = dtpNgayHuHong.Value;
            donPhongDTO.NgayHoanThanh = dtpNgayBaoTri.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
