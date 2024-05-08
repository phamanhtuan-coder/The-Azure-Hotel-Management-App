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
using System.Windows.Forms.VisualStyles;

namespace GUI.UserControls
{
    public partial class ucBill : UserControl
    {
        public string ngaytao { get; set; } = "";
        public string TT { get; set; } = "";

        ChiTietHoaDonBLL chiTietHoaDonBLL = new ChiTietHoaDonBLL();

        HoaDonBLL hoaDonBLL= new HoaDonBLL();
        List<HoaDonDTO> hoaDonDTOs = new List<HoaDonDTO>();
        List<HoaDonDTO> dsSearch = new List<HoaDonDTO>();

        frmHoaDon frm = new frmHoaDon();
        customMessageBox thongBao;

        bool KT = false;
        public ucBill()
        {
            InitializeComponent();
        }

        private void ucBill_Load(object sender, EventArgs e)
        {
            
            LoadDuLieuCombobox();
            TruyVanDanhSachHoaDon();
        }

        private void TruyVanDanhSachHoaDon()
        {
            hoaDonDTOs = new List<HoaDonDTO>();
            hoaDonDTOs = hoaDonBLL.TruyVanDanhSachHoaDon();
            dgvBill.ClearSelection();
            dgvBill.DataSource = hoaDonDTOs;
        }

        private void LoadDuLieuCombobox()
        {
            DuLieuChoComboBox.duLieuSort(cboSortBillID);
            DuLieuChoComboBox.duLieuSort(cboSortSumBill);
            DuLieuChoComboBox.duLieuFilter(cboStateBooking);
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            frm.isAdd = true;
            frm.ShowDialog();
            Filter();
        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count > 0)
            {
                frm.isAdd = false;
                int index1 = dgvBill.Columns["colMaHD"].Index;
                int index2 = dgvBill.Columns["colMaKH"].Index;
                int index3 = dgvBill.Columns["colMaNV"].Index;
                int index4 = dgvBill.Columns["colMaThue"].Index;
                int index5 = dgvBill.Columns["colNgayLapHoaDon"].Index;
                int index6 = dgvBill.Columns["colTongHD"].Index;
                int index7 = dgvBill.Columns["colTienNhan"].Index;
                int index8 = dgvBill.Columns["colTienThoi"].Index;

                frm.hoaDonDTO.MaHoaDon  = (int) dgvBill.SelectedRows[0].Cells[index1].Value;
                frm.hoaDonDTO.MaKH  = (int) dgvBill.SelectedRows[0].Cells[index2].Value;
                frm.hoaDonDTO.MaNV  = (int) dgvBill.SelectedRows[0].Cells[index3].Value;
                frm.hoaDonDTO.MaThue  = (int) dgvBill.SelectedRows[0].Cells[index4].Value;
                frm.hoaDonDTO.NgayLapHoaDon  = (DateTime) dgvBill.SelectedRows[0].Cells[index5].Value;
                frm.hoaDonDTO.TongHoaDon  = (decimal) dgvBill.SelectedRows[0].Cells[index6].Value;
                frm.hoaDonDTO.TienNhan  = (decimal) dgvBill.SelectedRows[0].Cells[index7].Value;
                frm.hoaDonDTO.TienThoi  = (decimal) dgvBill.SelectedRows[0].Cells[index8].Value;

                frm.ShowDialog();
                Filter();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvBill.Columns["colTrangThai"].Index;
                if ((bool)dgvBill.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        if (XoaHoaDon())
                        {
                            Filter();
                            thongBao = new customMessageBox("Xóa thành công!");
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Xóa thất bại!");
                            thongBao.ShowDialog();
                        }
                    }
                }
                else
                {
                    thongBao = new customMessageBox("Bạn không thể xóa hóa đơn đã xóa!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private bool XoaHoaDon()
        {
            int indexMaTaiKhoan = dgvBill.Columns["colMaHD"].Index;
            int MaHoaDon = (int)dgvBill.SelectedRows[0].Cells[indexMaTaiKhoan].Value;
            return hoaDonBLL.XoaHoaDon(MaHoaDon);
        }

        private void btnRecoverBill_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvBill.Columns["colTrangThai"].Index;
                if (!(bool)dgvBill.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        if (KhoiPhucHoaDon())
                        {
                            Filter();
                            thongBao = new customMessageBox("Khôi phục thành công!");
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Khôi phục thất bại!");
                            thongBao.ShowDialog();
                        }
                    }
                }
                else
                {
                    thongBao = new customMessageBox("Bạn không thể khôi phục hóa đơn khi chưa xóa!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private bool KhoiPhucHoaDon()
        {
            int indexMaTaiKhoan = dgvBill.Columns["colMaHD"].Index;
            int MaHoaDon = (int)dgvBill.SelectedRows[0].Cells[indexMaTaiKhoan].Value;
            return hoaDonBLL.KhoiPhucHoaDon(MaHoaDon);
        }

        private void cboSortBillID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortBillID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    hoaDonDTOs = hoaDonDTOs.OrderByDescending(item => item.MaHoaDon).ToList();
                    break;
                default:
                    hoaDonDTOs = hoaDonDTOs.OrderBy(item => item.MaHoaDon).ToList();
                    break;
            }

            dgvBill.DataSource = hoaDonDTOs;
        }

        private void cboSortSumBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortSumBill.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    hoaDonDTOs = hoaDonDTOs.OrderByDescending(item => item.TongHoaDon).ToList();
                    break;
                default:
                    hoaDonDTOs = hoaDonDTOs.OrderBy(item => item.TongHoaDon).ToList();
                    break;
            }

            dgvBill.DataSource = hoaDonDTOs;
        }

        private void cboStateBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            TT= cboStateBooking.Text;
            ngaytao = "";

            Filter();
        }

        private void btnNgayTao_Click(object sender, EventArgs e)
        {
            ngaytao = dtpBillDate.Value.ToString();
         
            Filter();
        }

        private void Filter()
        {
            if (TT.Length > 0)
            {
                dsSearch = hoaDonBLL.TraCuuHoaDon(hoaDonDTOs, TT, ngaytao);
                dgvBill.DataSource = dsSearch;
            }
        }

        //private void btnTraCuuBill_Click(object sender, EventArgs e)
        //{
        //    string searchKeyword = txtSearchBill.Text.Trim().ToLower();
        //    if (searchKeyword.Count() > 0)
        //    {
        //        dsSearch = hoaDonBLL.TraCuuHoaDon(hoaDonDTOs, searchKeyword);
        //        dgvBill.DataSource = dsSearch;

        //    }
        //    else
        //    {
        //        TruyVanDanhSachHoaDon();
        //    }
        //}

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count > 0)
            {

            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private void btnTraCuuDP_Click(object sender, EventArgs e)
        {
            object ngayNhanPhongObject = dtpNgayDat.Value;
            DateTime ng;
            if (ngayNhanPhongObject != DBNull.Value)
            {
                ng = DateTime.Parse(ngayNhanPhongObject.ToString());
            }
            else
            {
                ng = DateTime.Now;
            }
            hoaDonDTOs = hoaDonBLL.Filter(txtCCCD.Text, txtTraCuuUser.Text, ng);
            dgvBill.ClearSelection();
            dgvBill.DataSource = hoaDonDTOs;

            KT = true;
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count > 0)
            {
                HoaDonDTO hoaDonDTO = new HoaDonDTO();
                hoaDonDTO = dgvBill.SelectedRows[0].DataBoundItem as HoaDonDTO;
                decimal TongTien = 0;
                hoaDonDTO.TongHoaDon = 0;

                if (hoaDonDTO.MaHoaDon > 0)
                {
                    hoaDonDTO.chiTietHoaDonDTOs = new List<ChiTietHoaDonDTO>();
                    hoaDonDTO.chiTietHoaDonDTOs = chiTietHoaDonBLL.TruyVanChiTiet(hoaDonDTO.MaHoaDon);

                    foreach (ChiTietHoaDonDTO item in hoaDonDTO.chiTietHoaDonDTOs)
                    {
                        TongTien += item.ThanhTien;
                    }
                    hoaDonDTO.TongHoaDon = TongTien;
                    frmThanhToan frm = new frmThanhToan();
                    frm.hoaDonDTO = hoaDonDTO;
                    frm.ShowDialog();
                    Filter();
                }
                else
                {
                    thongBao = new customMessageBox("Vui lòng chọn hóa đơn!");
                    thongBao.ShowDialog();
                }
            }
        }
    }
}
