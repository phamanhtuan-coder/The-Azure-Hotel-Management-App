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

        HoaDonBLL hoaDonBLL= new HoaDonBLL();
        List<HoaDonDTO> hoaDonDTOs = new List<HoaDonDTO>();
        List<HoaDonDTO> dsSearch = new List<HoaDonDTO>();

        frmHoaDon frm = new frmHoaDon();
        customMessageBox thongBao;
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
        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count > 0)
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

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    // Xóa 
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private void btnRecoverBill_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    // Khôi phục
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
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

            if (TT.Length > 0 && TT.Length > 0)
            {
                dsSearch = hoaDonBLL.TraCuuHoaDon(hoaDonDTOs, TT, ngaytao);
                dgvBill.DataSource = dsSearch;
            }
        }

        private void btnNgayTao_Click(object sender, EventArgs e)
        {
            ngaytao = dtpBillDate.Value.ToString();

            if (TT.Length > 0 && TT.Length > 0)
            {
                dsSearch = hoaDonBLL.TraCuuHoaDon(hoaDonDTOs, TT, ngaytao);
                dgvBill.DataSource = dsSearch;
            }
        }

        private void btnTraCuuBill_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearchBill.Text.Trim().ToLower();
            if (searchKeyword.Count() > 0)
            {
                dsSearch = hoaDonBLL.TraCuuHoaDon(hoaDonDTOs, searchKeyword);
                dgvBill.DataSource = dsSearch;

            }
            else
            {
                TruyVanDanhSachHoaDon();
            }
        }
    }
}
