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
    public partial class frmBaoTri : Form
    {

        public bool isAdd { get; set; }
        public BaoTriDTO BaoTriDTO = new BaoTriDTO();
        BaoTriBLL BaoTriBLL= new BaoTriBLL();
        NhanVienBLL NhanVienBLL = new NhanVienBLL();
        ThietBiBLL ThietBiBLL = new ThietBiBLL();
        List<NhanVienDTO> nhanVienDTOs= new List<NhanVienDTO>();
        List<ThietBiDTO> thietBiDTOs= new List<ThietBiDTO>();
        public frmBaoTri()
        {
            InitializeComponent();
        }

        private void frmBaoTri_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên, néu là edit có giá trị truyền vào thì kiểm tra và chọn giá trị
            dtpNgayHuHong.MaxDate = DateTime.Now;
            dtpNgayBaoTri.MaxDate = DateTime.Now;
            if (isAdd)
            {
                
                nhanVienDTOs = NhanVienBLL.LoadIDAndNameBLLBaoTri();
                cboNVBaoTri.DataSource = nhanVienDTOs;
                cboNVBaoTri.DisplayMember = "HoTenNV";
                cboNVBaoTri.ValueMember = "MaNV";
                thietBiDTOs = ThietBiBLL.laydstbi();
                cboThietBi.DataSource=thietBiDTOs;
                cboThietBi.DisplayMember = "TenThietBi";
                cboThietBi.ValueMember = "MaThietBi";
                dtpNgayHuHong.Value = dtpNgayHuHong.MaxDate;
                dtpNgayBaoTri.Value = dtpNgayBaoTri.MaxDate;
            }
            else
            {

                cboNVBaoTri.DataSource = nhanVienDTOs;
                cboNVBaoTri.DisplayMember = "HoTenNV";
                cboNVBaoTri.ValueMember = "MaNV";
                foreach(var item in cboNVBaoTri.DataSource as List<NhanVienDTO>)
                {
                    if(item.MaNV == BaoTriDTO.MaNV)
                    {
                        cboNVBaoTri.SelectedItem = item;
                    }
                }
                thietBiDTOs = ThietBiBLL.laydstbi();
                cboThietBi.DataSource = thietBiDTOs;
                cboThietBi.DisplayMember = "TenThietBi";
                cboThietBi.ValueMember = "MaThietBi";
                foreach (var item in cboThietBi.DataSource as List<ThietBiDTO>)
                {
                    if (item.MaThietBi == BaoTriDTO.MaThietBi)
                    {
                        cboThietBi.SelectedItem = item;
                    }
                }
                dtpNgayHuHong.Value = BaoTriDTO.NgayHuHong;
                dtpNgayBaoTri.Value = BaoTriDTO.NgayBaoTri;
            }
        }


        private void laydltuform(BaoTriDTO p)
        {

            if (cboThietBi.SelectedIndex >= 0)
            {
                p.MaThietBi = cboThietBi.SelectedIndex + 1;
            }

            if (cboNVBaoTri.SelectedIndex >= 0)
            {
                p.MaNV = cboNVBaoTri.SelectedIndex + 1;
            }

            p.NgayHuHong = dtpNgayHuHong.Value;
            p.NgayBaoTri = dtpNgayBaoTri.Value;


        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            laydltuform(BaoTriDTO);
            bool check;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                check = BaoTriBLL.them(BaoTriDTO);
                if (check)
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu bảo trì");
                }
                else
                {
                    thongBao = new customMessageBox("Đã thêm thất bại dữ liệu bảo trì");
                }
                thongBao.ShowDialog();

            }
            else
            {
                // nếu không thì chạy lệnh update
                check = BaoTriBLL.sua(BaoTriDTO);
                if (check)
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin bảo trì!");
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thất bại thông tin bảo trì!");
                }
                
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
