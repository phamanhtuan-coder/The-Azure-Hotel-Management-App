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
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ucCustomerRanking : UserControl
    {
        public string trangthai { get; set; } = "";
        HangThanhVienBLL hangThanhVienBLL = new HangThanhVienBLL();
        List<HangThanhVienDTO> hangThanhVienDTOs = new List<HangThanhVienDTO>();
        List<HangThanhVienDTO> dsSearch = new List<HangThanhVienDTO>();
        public ucCustomerRanking()
        {
            InitializeComponent();
        }

        private void ucCustomerRanking_Load(object sender, EventArgs e)
        {
            CapNhatCBBHangThanhVien();           
        }
        private void LoadDSHangThanhVien()
        {
            trangthai = cboStateCustomerRanking.Text;
            hangThanhVienDTOs = new List<HangThanhVienDTO>();
            hangThanhVienDTOs = hangThanhVienBLL.Filer(trangthai);
            dgvCustomerRank.ClearSelection();
            dgvCustomerRank.DataSource = hangThanhVienDTOs;
        }
        private void CapNhatCBBHangThanhVien()
        {
            DuLieuChoComboBox.duLieuSort(cboSortCustomerRankingID);
            DuLieuChoComboBox.duLieuSort(cboSortSoLuongKH);
            DuLieuChoComboBox.duLieuFilter(cboStateCustomerRanking);
        }

        private void btnAddCustomerRanking_Click(object sender, EventArgs e)
        {
            frmHangThanhVien frm = new frmHangThanhVien();
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditCustomerRanking_Click(object sender, EventArgs e)
        {
            if (dgvCustomerRank.SelectedRows.Count > 0)
            {
                frmHangThanhVien frm = new frmHangThanhVien();
                frm.isAdd = false;
                //Batdau doan co the chinh sua
               

                //ket thuc doan co the chinh sua
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
           
        }

        private void btnDeleteCustomerRanking_Click(object sender, EventArgs e)
        {
            if (dgvCustomerRank.SelectedRows.Count > 0)
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

        private void btnRecoverCustomerRanking_Click(object sender, EventArgs e)
        {

            if (dgvCustomerRank.SelectedRows.Count > 0)
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

        private void cboStateCustomerRanking_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSHangThanhVien();
        }

        private void cboSortCustomerRankingID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortCustomerRankingID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    hangThanhVienDTOs = hangThanhVienDTOs.OrderByDescending(item => item.MaLoaiHangThanhVien).ToList();
                    break;
                default:
                    hangThanhVienDTOs = hangThanhVienDTOs.OrderBy(item => item.MaLoaiHangThanhVien).ToList();
                    break;
            }

            dgvCustomerRank.DataSource = hangThanhVienDTOs;
        }

        private void cboSortSoLuongKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortCustomerRankingID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    hangThanhVienDTOs = hangThanhVienDTOs.OrderByDescending(item => item.SoLuong).ToList();
                    break;
                default:
                    hangThanhVienDTOs = hangThanhVienDTOs.OrderBy(item => item.SoLuong).ToList();
                    break;
            }

            dgvCustomerRank.DataSource = hangThanhVienDTOs;
        }

        private void btnTraCuuCustomerRanking_Click(object sender, EventArgs e)
        {
            dgvCustomerRank.DataSource = hangThanhVienDTOs;
            string searchKeyword = txtSearchCustomerRanking.Text.Trim().ToLower();
            if (searchKeyword.Count() > 0)
            {
                dsSearch = hangThanhVienBLL.TraCuuNhanVien(hangThanhVienDTOs, searchKeyword);
                dgvCustomerRank.DataSource = dsSearch;

            }
            else
            {
                LoadDSHangThanhVien();
            }
        }
    }
}
