using BLL;
using DTO;
using GUI.customForm;
using Syncfusion.WinForms.ListView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.UserControls
{
    public partial class ucStaff : UserControl
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();
        public ucStaff()
        {
            InitializeComponent();
            LoadDSNhanVien();
        }

        private void ucStaff_Load(object sender, EventArgs e)
        {
            CapNhatCBBNhanVien();
            LoadVaiTro();
            LoadPhong();
            loadNQL();
        }

        private void LoadDSNhanVien()
        {
            nhanVienDTOs = nhanVienBLL.FilterTrangThai(cboStateAccounts.Text);
            dgvStaff.ClearSelection();
            dgvStaff.DataSource = nhanVienDTOs;
        }

        private void loadNQL()
        {
            nhanVienDTOs = nhanVienBLL.LoadIDAndNameBLL();
            cboNguoiQuanLy.DataSource = nhanVienDTOs;
            cboNguoiQuanLy.DisplayMember = "HoTenNV";
            cboNguoiQuanLy.ValueMember= "MaNV";
            cboNguoiQuanLy.SelectedIndex = 0;
        }

        private void LoadPhong()
        {
            PhongBanBLL phongBanBLL = new PhongBanBLL();
            List<PhongBanDTO> phongBanDTOs = phongBanBLL.LoadIDAndNameBLL();
            cboPhongBan.DataSource = phongBanDTOs;
            cboPhongBan.DisplayMember = "TenPhong";
            cboPhongBan.ValueMember = "MaPhongBan";
        }

        private void LoadVaiTro()
        {
            VaiTroBLL vaiTroBLL = new VaiTroBLL();
            List<VaiTroDTO> vaiTroDTOs = vaiTroBLL.LoadIDAndNameBLL();
            cboPhanQuyen.DataSource = vaiTroDTOs;
            cboPhanQuyen.DisplayMember= "TenVaiTro";
            cboPhanQuyen.ValueMember= "MaVaiTro";
        }

        private void CapNhatCBBNhanVien()
        {
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
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.isAdd = true;
            frm.ShowDialog();
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
            nhanVienDTOs = nhanVienBLL.FilterTrangThai(cboStateAccounts.Text);
            dgvStaff.ClearSelection();
            dgvStaff.DataSource = nhanVienDTOs;
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            nhanVienDTOs = nhanVienBLL.FilterGioiTinh(cboStateAccounts.Text,cboGioiTinh.Text);
            dgvStaff.ClearSelection();
            dgvStaff.DataSource = nhanVienDTOs;
        }

        private void cboNguoiQuanLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int MaNQL = (int)cboNguoiQuanLy.SelectedValue;
            //nhanVienDTOs = nhanVienBLL.FilterNQL(MaNQL);
            //dgvStaff.ClearSelection();
            //dgvStaff.DataSource = nhanVienDTOs;
        }
    }
}
