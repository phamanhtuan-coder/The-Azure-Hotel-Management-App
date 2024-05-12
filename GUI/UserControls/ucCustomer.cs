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
        public string MaPHQ { get; set; }
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
            dgvCustomer.AutoGenerateColumns = false;
            CapNhatCBBNhanVien();
            KiemTraPQ();
        }
        private void KiemTraPQ()
        {
            if (MaPHQ.Contains("01"))
            {

                btnAddCustomer.Enabled = false;
                btnEditCustomer.Enabled = false;
                btnDeleteCustomer.Enabled = false;
                btnRecoverCustomer.Enabled = false;
            }
            else if (MaPHQ.Contains("03"))
            {
                btnAddCustomer.Enabled = true;
                btnEditCustomer.Enabled = true;
                btnDeleteCustomer.Enabled = false;
                btnRecoverCustomer.Enabled = false;
            }
            else if (MaPHQ.Contains("04") || (MaPHQ.Contains("02")))
            {
                btnAddCustomer.Enabled = true;
                btnEditCustomer.Enabled = true;
                btnDeleteCustomer.Enabled = true;
                btnRecoverCustomer.Enabled = true;
            }


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
                int MaKH = dgvCustomer.Columns["ID"].Index;
                int TenDangNhap = dgvCustomer.Columns["colTenTaiKhoan"].Index;
                int MaLoaiHangThanhVien = dgvCustomer.Columns["MaLoaiHangTV"].Index;
                int HinhAnh = dgvCustomer.Columns["HinhAnh"].Index;
                int HoTenKH = dgvCustomer.Columns["HoTen"].Index;
                int SDT = dgvCustomer.Columns["SDT"].Index;
                int Email = dgvCustomer.Columns["Email"].Index;
                int CCCD = dgvCustomer.Columns["CCCD"].Index;
                int NgaySinh = dgvCustomer.Columns["NgaySinh"].Index;
                int DiaChi = dgvCustomer.Columns["DiaChi"].Index;
                int GioiTinh = dgvCustomer.Columns["colGioiTinh"].Index;

                frm.khachHangDTO.MaKH = (int)dgvCustomer.SelectedRows[0].Cells[MaKH].Value;
                frm.khachHangDTO.TenDangNhap = (string)dgvCustomer.SelectedRows[0].Cells[TenDangNhap].Value;
                frm.khachHangDTO.MaLoaiHangThanhVien=(int)dgvCustomer.SelectedRows[0].Cells[MaLoaiHangThanhVien].Value;
                object cellValue = dgvCustomer.SelectedRows[0].Cells[HinhAnh].Value;
                if (cellValue != null)
                {
                    frm.khachHangDTO.HinhAnh = (byte[])dgvCustomer.SelectedRows[0].Cells[HinhAnh].Value;
                }
                frm.khachHangDTO.HoTenKH = (string)dgvCustomer.SelectedRows[0].Cells[HoTenKH].Value;
                frm.khachHangDTO.SDT = (string)dgvCustomer.SelectedRows[0].Cells[SDT].Value;
                frm.khachHangDTO.Email = (string)dgvCustomer.SelectedRows[0].Cells[Email].Value;
                frm.khachHangDTO.CCCD = (string)dgvCustomer.SelectedRows[0].Cells[CCCD].Value;
                frm.khachHangDTO.NgaySinh = (DateTime)dgvCustomer.SelectedRows[0].Cells[NgaySinh].Value;
                frm.khachHangDTO.DiaChi = (string)dgvCustomer.SelectedRows[0].Cells[DiaChi].Value;
                frm.khachHangDTO.GioiTinh = (string)dgvCustomer.SelectedRows[0].Cells[GioiTinh].Value;

                //Kết thúc đoạn có thể chỉnh sửa
                frm.ShowDialog();
                LoadDSKhachHang();
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
                    int TrangThai = dgvCustomer.Columns["TrangThai"].Index;
                    if ((bool)dgvCustomer.SelectedRows[0].Cells[TrangThai].Value)
                    {
                        if (XoaKhachHang())
                        {
                            LoadDSKhachHang();
                            thongBao = new customMessageBox("Xóa thành công dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Xóa thất bại dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }                        
                    }
                    else
                    {
                        thongBao = new customMessageBox("Bạn không thể xóa khách hàng đã xóa!");
                        thongBao.ShowDialog();
                    }
                }
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private bool XoaKhachHang()
        {
            if (dgvCustomer.SelectedRows.Count > 0)//  Sửa điều kiện đoạn này
            {
                frmNhanVien frm = new frmNhanVien();
                int vitriMaKH = dgvCustomer.Columns["ID"].Index;
                int MaKH = (int)dgvCustomer.SelectedRows[0].Cells[vitriMaKH].Value;
                return khachHangBLL.XoaNhanVienBLL(MaKH);
            }
            else
            {
                return false;
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
                    int TrangThai = dgvCustomer.Columns["TrangThai"].Index;
                    if (!(bool)dgvCustomer.SelectedRows[0].Cells[TrangThai].Value)
                    {
                       
                        if (KhoiPhuckhachHang())
                        {
                            LoadDSKhachHang();
                            thongBao = new customMessageBox("Khôi phục thành công!");
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Khôi phục thất bại!");
                            thongBao.ShowDialog();
                        }
                        
                    }
                    else
                    {
                        thongBao = new customMessageBox("Bạn không thể khôi phục khách hàng khi chưa xóa!");
                        thongBao.ShowDialog();
                    }
                }
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private bool KhoiPhuckhachHang()
        {
            if (dgvCustomer.SelectedRows.Count > 0)//  Sửa điều kiện đoạn này
            {
                frmNhanVien frm = new frmNhanVien();
                int vitriMaKH = dgvCustomer.Columns["ID"].Index;
                int MaKH = (int)dgvCustomer.SelectedRows[0].Cells[vitriMaKH].Value;
                return khachHangBLL.KhoiPhucKhachHangBLL(MaKH);
            }
            else
            {
                return false;
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
