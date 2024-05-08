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
    public partial class ucBillDetails : UserControl
    {
        frmCTHD frm = new frmCTHD();
        customMessageBox thongBao;

        string TT = "";

        ChiTietHoaDonBLL chiTietHoaDonBLL = new ChiTietHoaDonBLL();
        List<ChiTietHoaDonDTO> chiTietHoaDonDTOs = new List<ChiTietHoaDonDTO>();
        List<ChiTietHoaDonDTO> dsSearch = new List<ChiTietHoaDonDTO>();

        public ucBillDetails()
        {
            InitializeComponent();
        }

        private void ucBillDetails_Load(object sender, EventArgs e)
        {
            LoadDuLieuCombobox();
            LoadDSChiTietHoaDon();
        }

        private void LoadDSChiTietHoaDon()
        {
            chiTietHoaDonDTOs = chiTietHoaDonBLL.TruyVanDSChiTiet();
            dgvBillDetails.DataSource = chiTietHoaDonDTOs;
        }

        private void LoadDuLieuCombobox()
        {
            DuLieuChoComboBox.duLieuSort(cboSortBillID);
            DuLieuChoComboBox.duLieuSort(cboSortSumBill);
            DuLieuChoComboBox.duLieuFilter(cboStateBooking);
        }

        private void btnAddBillDetails_Click(object sender, EventArgs e)
        {
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditBillDetails_Click(object sender, EventArgs e)
        {

            if (dgvBillDetails.SelectedRows.Count > 0)
            {

                frm.isAdd = false;




                frm.ShowDialog();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteBillDetails_Click(object sender, EventArgs e)
        {
            if (dgvBillDetails.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvBillDetails.Columns["colTrangThai"].Index;
                if ((bool)dgvBillDetails.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        int maDP = (int)dgvBillDetails.SelectedRows[0].Cells["colMaCTHD"].Value;
                        if (XoaChiTiet(maDP))
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
                    thongBao = new customMessageBox("Bạn không thể xóa chi tiết hóa đơn đã xóa!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }

        }

        private bool XoaChiTiet(int maDP)
        {
            return chiTietHoaDonBLL.XoaChiTiet(maDP);
        }

        private void btnRecoverBillDetails_Click(object sender, EventArgs e)
        {

            if (dgvBillDetails.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvBillDetails.Columns["colTrangThai"].Index;
                if (!(bool)dgvBillDetails.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        int donPhong = dgvBillDetails.Columns["colMaCTHD"].Index;
                        int maDP = (int)dgvBillDetails.SelectedRows[0].Cells[donPhong].Value;
                        if (KhoiPhucChiTiet(maDP))
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
                    thongBao = new customMessageBox("Bạn không thể khôi phục chi tiết hóa đơn chưa xóa!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private bool KhoiPhucChiTiet(int maDP)
        {
            return chiTietHoaDonBLL.KhoiPhucChiTiet(maDP);
        }

        private void btnTraCuuBillDetails_Click(object sender, EventArgs e)
        {
            dgvBillDetails.DataSource = chiTietHoaDonDTOs;
            string searchKeyword = txtSearchBillDetails.Text.Trim().ToLower();
            if (searchKeyword.Count() > 0)
            {
                dsSearch = chiTietHoaDonBLL.TraCuuDonPhong(chiTietHoaDonDTOs, searchKeyword);
                dgvBillDetails.DataSource = dsSearch;
            }
            else
            {
                Filter();
            }
        }

        private void cboSortBillID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortBillID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    chiTietHoaDonDTOs = chiTietHoaDonDTOs.OrderByDescending(item => item.MaCTHD).ToList();
                    break;
                default:
                    chiTietHoaDonDTOs = chiTietHoaDonDTOs.OrderBy(item => item.MaCTHD).ToList();
                    break;
            }

            dgvBillDetails.DataSource = chiTietHoaDonDTOs;
        }

        private void cboSortSumBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortSumBill.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    chiTietHoaDonDTOs = chiTietHoaDonDTOs.OrderByDescending(item => item.ThanhTien).ToList();
                    break;
                default:
                    chiTietHoaDonDTOs = chiTietHoaDonDTOs.OrderBy(item => item.ThanhTien).ToList();
                    break;
            }

            dgvBillDetails.DataSource = chiTietHoaDonDTOs;
        }

        private void cboStateBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            TT = cboStateBooking.Text;

            if (TT.Length > 0)
            {
                Filter();
            }            
        }

        private void Filter()
        {
            dsSearch = chiTietHoaDonBLL.Filter(TT);
            dgvBillDetails.DataSource = dsSearch;
        }
    }
}
