using BLL;
using DTO;
using GUI.customForm;
using Syncfusion.WinForms.ListView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.UserControls
{
    public partial class ucStaff : UserControl
    {
        int PhanQuyen;
        string PhongBan;
        string GioiTinh;
        int NguoiQuanLy;
        string tt;
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();
        List<PhongBanDTO> phongBanDTOs = new List<PhongBanDTO>();
        List<NhanVienDTO> dsNV = new List<NhanVienDTO>();
        List<NhanVienDTO> dsSearch = new List<NhanVienDTO>();
        List<VaiTroDTO> vaiTroDTOs = new List<VaiTroDTO>();
        public ucStaff()
        {
            InitializeComponent();
        }

        private void ucStaff_Load(object sender, EventArgs e)
        {
            CapNhatCBBNhanVien();
        }

        private void LoadDSNhanVien()
        {
            nhanVienDTOs = nhanVienBLL.Filer(PhanQuyen, PhongBan, GioiTinh, NguoiQuanLy, tt);
            dgvStaff.ClearSelection();
            dgvStaff.DataSource = nhanVienDTOs;
        }

        private void loadNQL()
        {
            NhanVienDTO TatCa= new NhanVienDTO();
            TatCa.MaNV = -1;
            TatCa.HoTenNV = "Tất cả";
            nhanVienDTOs.Add(TatCa);
            List<NhanVienDTO> tam= nhanVienBLL.LoadIDAndNameBLL();
            foreach (var item in tam)
            {
                nhanVienDTOs.Add(item);
            }
            cboNguoiQuanLy.DataSource = nhanVienDTOs;
            cboNguoiQuanLy.DisplayMember = "HoTenNV";
            cboNguoiQuanLy.ValueMember= "MaNV";
            cboNguoiQuanLy.SelectedIndex = 0;
        }

        private void LoadPhong()
        {
            PhongBanBLL phongBanBLL = new PhongBanBLL();
            PhongBanDTO TatCa= new PhongBanDTO();
            TatCa.MaPhongBan = "00";
            TatCa.TenPhong = "Tất cả";
            phongBanDTOs.Add(TatCa);
            List<PhongBanDTO> tam= phongBanBLL.LoadIDAndNameBLL();
            foreach (var item in tam)
            {
                phongBanDTOs.Add(item);
            }
            cboPhongBan.DataSource = phongBanDTOs;
            cboPhongBan.DisplayMember = "TenPhong";
            cboPhongBan.ValueMember = "MaPhongBan";
        }

        private void LoadVaiTro()
        {
            VaiTroBLL vaiTroBLL = new VaiTroBLL();
            VaiTroDTO TatCa = new VaiTroDTO();
            TatCa.MaVaiTro = -1;
            TatCa.TenVaiTro = "Tất cả";
            vaiTroDTOs.Add(TatCa);
            List<VaiTroDTO> tam= vaiTroBLL.LoadIDAndNameBLL();
            foreach (var item in tam)
            {
                vaiTroDTOs.Add(item);
            }
            cboPhanQuyen.DataSource = vaiTroDTOs;
            cboPhanQuyen.DisplayMember= "TenVaiTro";
            cboPhanQuyen.ValueMember= "MaVaiTro";
        }

        private void CapNhatCBBNhanVien()
        {
            LoadVaiTro();
            LoadPhong();
            loadNQL();
            DuLieuChoComboBox.duLieuSort(cboSortStaffID);
            DuLieuChoComboBox.duLieuFilter(cboStateAccounts);
            List<string> sortOptions = new List<string>
            {
                "Tất cả",
                "Nam",
                "Nữ"
            };
            cboGioiTinh.DataSource = sortOptions;
            cboGioiTinh.SelectedIndex = 0;
            if (cboPhongBan.SelectedIndex != 0 && cboPhanQuyen.SelectedIndex != 0)
            {
                cboPhongBan.SelectedIndex = 0;
                cboPhanQuyen.SelectedIndex = 0;
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.isAdd = true;
            frm.ShowDialog();
            LoadDSNhanVien();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)//  Sửa điều kiện đoạn này
            {
                frmNhanVien frm = new frmNhanVien();
                frm.isAdd = false;
                //Bắt đầu sửa từ đoạn này
               
                frm.anhDaiDien = null;

                //Kết thúc đoạn được sửa
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                customMessageBox thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    // Xóa 
                }
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private void btnRecoverStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                customMessageBox thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    // Khôi phục
                }
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private void cboStateAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAvata.Image = null;
            tt =cboStateAccounts.SelectedValue.ToString();
            LoadDSNhanVien();
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAvata.Image = null;
            GioiTinh = cboGioiTinh.Text;
            LoadDSNhanVien();
        }

        private void cboNguoiQuanLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAvata.Image = null;
            NguoiQuanLy = (int) cboNguoiQuanLy.SelectedValue;
            LoadDSNhanVien();
        }

        private void cboPhanQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAvata.Image = null;
            PhanQuyen = (int)cboPhanQuyen.SelectedValue;
            LoadDSNhanVien();
        }

        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAvata.Image = null;
            PhongBan = cboPhongBan.SelectedValue.ToString();
            LoadDSNhanVien();
        }

        private void cboSortAccountTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortStaffID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    nhanVienDTOs = nhanVienDTOs.OrderByDescending(item => item.MaTaiKhoan).ToList();
                    break;
                default:
                    nhanVienDTOs = nhanVienDTOs.OrderBy(item => item.MaTaiKhoan).ToList();
                    break;
            }

            dgvStaff.DataSource = nhanVienDTOs;
        }

        private void dgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                string columnName = "HinhAnh";

                int columnIndex = dgvStaff.Columns[columnName].Index;
                object cellValue = dgvStaff.SelectedRows[0].Cells[columnIndex].Value;

                if (cellValue != null)
                {
                    byte[] hinh = (byte[])cellValue;
                    picAvata.Image = ByteArrayToImage(hinh);
                }
                else
                {
                    picAvata.Image = null;
                }
            }
        }

        Image ByteArrayToImage(byte[] hinh)
        {
            using (MemoryStream m = new MemoryStream(hinh))
            {
                return Image.FromStream(m);
            }
        }

        private void btnTraCuuStaff_Click(object sender, EventArgs e)
        {
            dgvStaff.DataSource = nhanVienDTOs;
            string searchKeyword = txtSearchStaff.Text.Trim().ToLower();
            if (searchKeyword.Count() > 0)
            {
                dsSearch = nhanVienBLL.TraCuuNhanVien(nhanVienDTOs, searchKeyword);
                dgvStaff.DataSource = dsSearch;

            }
            else
            {
                LoadDSNhanVien();
            }
        }
    }
}
