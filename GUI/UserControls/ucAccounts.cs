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

namespace GUI.UserControls
{
    public partial class ucAccounts : UserControl
    {
        public string phanquyen { get; set; } = "";
        public string ngaytao { get; set; } = "";
        public string TT { get; set; } = "";
        RoleBLL roleBLL = new RoleBLL();
        List<RoleDTO> roleDTOs= new List<RoleDTO>();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        List<TaiKhoanDTO> taiKhoanDTOs= new List<TaiKhoanDTO>();
        List<TaiKhoanDTO> dsSearch = new List<TaiKhoanDTO>();

        public ucAccounts()
        {
            InitializeComponent();
        }

        private void ucAccounts_Load(object sender, EventArgs e)
        {
            CapNhatDuLieuCBO();
            LoadDSTaiKhoan();
        }
        private void LoadDSTaiKhoan()
        {
            taiKhoanDTOs = new List<TaiKhoanDTO>();
            taiKhoanDTOs = taiKhoanBLL.Filter();
            dgvAccounts.ClearSelection(); 
            dgvAccounts.DataSource = taiKhoanDTOs;
        }
        private void CapNhatDuLieuCBO()
        {
            DuLieuChoComboBox.duLieuSort(cboSortAccountsID);
            DuLieuChoComboBox.duLieuFilter(cboStateAccounts);
            LoadVaiTro();
        }

        private void LoadVaiTro()
        {
            RoleDTO tatca = new RoleDTO();
            tatca.MaPhanQuyen = "None";
            roleDTOs.Add(tatca);
            List<RoleDTO> tam = roleBLL.LoadMaPhanQuyen();
            foreach (RoleDTO item in tam)
            {
                roleDTOs.Add(item);
            }
            cboPhanQuyen.DataSource=roleDTOs;
            cboPhanQuyen.DisplayMember = "MaPhanQuyen";
            cboPhanQuyen.SelectedIndex = 0;
        }

        private void btnAddAccounts_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditAccounts_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                frmTaiKhoan frm = new frmTaiKhoan();
                frm.isAdd = false;

                //Bắt đầu sửa từ đoạn này
                


                //Kết thúc sửa từ đoạn này
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
          
        }

        private void btnDeleteAccounts_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
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

        private void btnRecoverAccounts_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
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

        private void cboPhanQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            phanquyen= cboPhanQuyen.Text;
            if (phanquyen.Length > 0)
            {
                dsSearch = taiKhoanBLL.TraCuuNhanVien(taiKhoanDTOs, phanquyen, TT, ngaytao);
                dgvAccounts.DataSource = dsSearch;
            }         
        }

        private void cboStateAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            TT = cboStateAccounts.Text;
            if (TT.Length > 0)
            {
                dsSearch = taiKhoanBLL.TraCuuNhanVien(taiKhoanDTOs, phanquyen, TT, ngaytao);
                dgvAccounts.DataSource = dsSearch;
            }          
        }

        private void cboSortAccountsID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortAccountsID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    taiKhoanDTOs = taiKhoanDTOs.OrderByDescending(item => item.MaTaiKhoan).ToList();
                    break;
                default:
                    taiKhoanDTOs = taiKhoanDTOs.OrderBy(item => item.MaTaiKhoan).ToList();
                    break;
            }

            dgvAccounts.DataSource = taiKhoanDTOs;
        }

        private void btnTraCuuAccounts_Click(object sender, EventArgs e)
        {
            dgvAccounts.DataSource = taiKhoanDTOs;
            string searchKeyword = txtSearchAccounts.Text.Trim().ToLower();
            if (searchKeyword.Count() > 0)
            {
                dsSearch = taiKhoanBLL.TraCuuNhanVienTen(taiKhoanDTOs, searchKeyword);
                dgvAccounts.DataSource = dsSearch;

            }
            else
            {
                LoadDSTaiKhoan();
            }
        }

        private void btnNgayTao_Click(object sender, EventArgs e)
        {
            ngaytao = dtpNgayTao.Value.ToString("MM/dd/yyyy");

            if (TT.Length > 0 && phanquyen.Length > 0)
            {
                dsSearch = taiKhoanBLL.TraCuuNhanVien(taiKhoanDTOs, phanquyen, TT, ngaytao);
                dgvAccounts.DataSource = dsSearch;
            }
        }
    }
}
