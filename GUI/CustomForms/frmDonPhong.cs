using BLL;
using DTO;
using Syncfusion.Windows.Forms.Maps;
using System;
using System.Collections;
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
                lblNgayBaoTri.Visible = true;
                dtpNgayBaoTri.Visible = true;
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
                lblNgayBaoTri.Visible = false;
                dtpNgayBaoTri.Visible = false;
                cboThietBi.SelectedIndex = 0;
                cboNVBaoTri.SelectedIndex = 0;
                dtpNgayBaoTri.Value = DateTime.Now;
                dtpNgayHuHong.Value = DateTime.Now;
            }
        }

        private void LoadDuLieuMaPhong()
        {
            List<PhongDTO> list = new List<PhongDTO> ();
            if (isAdd)
            {
                cboThietBi.Enabled = true;
                cboNVBaoTri.Enabled = true;
                dtpNgayHuHong.Enabled = true;
                foreach (var item in phongBLL.laydspTT())
                {
                    list.Add(item);
                }
                PhongDTO TatCa = new PhongDTO();
                TatCa.MaPHG = -1;
                list.Add (TatCa);
                cboThietBi.DataSource = null;
                cboThietBi.DataSource = list;
                cboThietBi.DisplayMember = "MaPHG";
                cboThietBi.ValueMember = "MaPHG";
                cboThietBi.SelectedIndex = 0;
            }
            else
            {
                cboThietBi.Enabled = false;
                cboNVBaoTri.Enabled = false;
                dtpNgayHuHong.Enabled = false;
                foreach (var item in phongBLL.laydsp())
                {
                    list.Add(item);
                }
                cboThietBi.DataSource = null;
                cboThietBi.DataSource = list;
                cboThietBi.DisplayMember = "MaPHG";
                cboThietBi.ValueMember = "MaPHG";
                cboThietBi.SelectedIndex = 0;
            }
        }

        private void LoadDuLieuNhanVienDonPhong()
        {            
            List<NhanVienDTO> list = new List<NhanVienDTO> ();
            foreach (var item in nhanVienBLL.LoadIDAndNameBLLDonPhong())
            {
                list.Add(item);
            }
            NhanVienDTO TatCa = new NhanVienDTO();
            TatCa.MaNV = -1;
            TatCa.HoTenNV = "None";
            list.Add(TatCa);
            cboNVBaoTri.DataSource = list;
            cboNVBaoTri.DisplayMember = "HoTenNV";
            cboNVBaoTri.ValueMember = "MaNV";
            cboNVBaoTri.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {        
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                GanDuLieu();
                // Nếu đúng là form Thêm thì chạy lệnh insert
                if (AddDonPhong())
                {
                    DatPhongDTO dphongDTO = new DatPhongDTO();
                    dphongDTO.MaPHG = donPhongDTO.MaPhong;
                    List<DatPhongDTO> ct = new List<DatPhongDTO> { dphongDTO };
                    phongBLL.CapNhatTT(ct, 6);
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu dọn phòng!");
                    thongBao.ShowDialog();
                    this.Close();
                }
                else
                {
                    thongBao = new customMessageBox("Đã thêm thất bại dữ liệu dọn phòng!");
                    thongBao.ShowDialog();
                }                
            }
            else
            {
                GanDuLieu();
                // nếu không thì chạy lệnh update
                if (EditDonPhong())
                {
                    DatPhongDTO dphongDTO = new DatPhongDTO();
                    dphongDTO.MaPHG = donPhongDTO.MaPhong;
                    List<DatPhongDTO> ct = new List<DatPhongDTO> { dphongDTO };
                    phongBLL.CapNhatTT(ct, 1);
                    thongBao = new customMessageBox("Sửa thành công thông tin dọn phòng!");
                    thongBao.ShowDialog();
                    this.Close();
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thất bại thông tin dọn phòng!");
                    thongBao.ShowDialog();
                }             
            }       
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
            if (cboNVBaoTri.SelectedValue != null)
            {
                donPhongDTO.MaNV = (int)cboNVBaoTri.SelectedValue;
            }

            if (cboThietBi.SelectedValue != null)
            {
                donPhongDTO.MaPhong = (int)cboThietBi.SelectedValue;
            }

            donPhongDTO.NgayNhan = dtpNgayHuHong.Value;
            donPhongDTO.NgayHoanThanh = dtpNgayBaoTri.Value;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
