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
    public partial class ucCustomer : UserControl
    {
        public int MaHang { get; set; }
        public string GioiTinh { get; set; }
        public string TT { get; set; }
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        List<HangThanhVienDTO> hangThanhVienDTOs= new List<HangThanhVienDTO> ();
        List<KhachHangDTO> khachHangDTOs= new List<KhachHangDTO> ();
        List<KhachHangDTO> dsSearch = new List<KhachHangDTO>();
        public ucCustomer()
        {
            InitializeComponent();
        }

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            CapNhatCBBNhanVien();
        }
        private void LoadDSKhachHang()
        {
            khachHangDTOs = new List<KhachHangDTO>();
            khachHangDTOs = khachHangBLL.Filer(MaHang, GioiTinh, TT);
            dgvCustomer.ClearSelection();
            dgvCustomer.DataSource = khachHangDTOs;
        }

        private void CapNhatCBBNhanVien()
        {
            LoadCboHangThanhVien();
            DuLieuChoComboBox.duLieuSort(cboSortCustomerID);
            DuLieuChoComboBox.duLieuFilter(cboStateAccounts);
            List<string> sortOptions = new List<string>
            {
                "Tất cả",
                "Nam",
                "Nữ"
            };
            cboGioiTinh.DataSource = sortOptions;
            cboGioiTinh.SelectedIndex = 0;
            if (cboHangTV.SelectedIndex != 0)
            {
                cboHangTV.SelectedIndex = 0;
                cboHangTV.SelectedIndex = 0;
            }
        }

        private void LoadCboHangThanhVien()
        {
            HangThanhVienBLL hangThanhVienBLL = new HangThanhVienBLL();
            HangThanhVienDTO TatCa = new HangThanhVienDTO();
            TatCa.MaLoaiHangThanhVien = -1;
            TatCa.TenHang = "Tất cả";
            hangThanhVienDTOs.Add(TatCa);
            List<HangThanhVienDTO> tam = hangThanhVienBLL.LoadIDAndNameBLL();
            foreach (var item in tam)
            {
                hangThanhVienDTOs.Add(item);
            }
            cboHangTV.DataSource = hangThanhVienDTOs;
            cboHangTV.DisplayMember = "TenHang";
            cboHangTV.ValueMember = "MaLoaiHangThanhVien";

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.isAdd = true;
            frm.ShowDialog();
            LoadDSKhachHang();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                frmKhachHang frm = new frmKhachHang();
                frm.isAdd = false;
                //Bắt đầu đoạn có thể chỉnh sửa


                //Kết thúc đoạn có thể chỉnh sửa
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
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

        private void btnRecoverCustomer_Click(object sender, EventArgs e)
        {

            if (dgvCustomer.SelectedRows.Count > 0)
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

        private void cboHangTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaHang = (int) cboHangTV.SelectedValue;
            LoadDSKhachHang();
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            GioiTinh = (string)cboGioiTinh.SelectedValue;
            LoadDSKhachHang();
        }

        private void cboStateAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            TT = (string)cboStateAccounts.SelectedValue;
            LoadDSKhachHang();
        }

        private void cboSortCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortCustomerID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    khachHangDTOs = khachHangDTOs.OrderByDescending(item => item.MaTaiKhoan).ToList();
                    break;
                default:
                    khachHangDTOs = khachHangDTOs.OrderBy(item => item.MaTaiKhoan).ToList();
                    break;
            }

            dgvCustomer.DataSource = khachHangDTOs;
        }

        private void btnTraCuuCustomer_Click(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = khachHangDTOs;
            string searchKeyword = txtSearchCustomer.Text.Trim().ToLower();
            if (searchKeyword.Count() > 0)
            {
                dsSearch = khachHangBLL.TraCuuNhanVien(khachHangDTOs, searchKeyword);
                dgvCustomer.DataSource = dsSearch;

            }
            else
            {
                LoadDSKhachHang();
            }
        }
    }
}
