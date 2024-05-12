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
        public string MaPHQ { get; set; }
        public string trangthai { get; set; } = "";
        HangThanhVienBLL hangThanhVienBLL = new HangThanhVienBLL();
        HangThanhVienDTO hangThanhVienDTO = new HangThanhVienDTO();
        List<HangThanhVienDTO> hangThanhVienDTOs = new List<HangThanhVienDTO>();
        List<HangThanhVienDTO> dsSearch = new List<HangThanhVienDTO>();
        public ucCustomerRanking()
        {
            InitializeComponent();
        }

        private void ucCustomerRanking_Load(object sender, EventArgs e)
        {
            dgvCustomerRank.AutoGenerateColumns = false;
            CapNhatCBBHangThanhVien();
            KiemTraPQ();
        }
        private void KiemTraPQ()
        {
            if (MaPHQ.Contains("01"))
            {

                btnAddCustomerRanking.Enabled = false;
                btnEditCustomerRanking.Enabled = false;
                btnDeleteCustomerRanking.Enabled = false;
                btnRecoverCustomerRanking.Enabled = false;
            }
            else if (MaPHQ.Contains("03"))
            {
                btnAddCustomerRanking.Enabled = true;
                btnEditCustomerRanking.Enabled = true;
                btnDeleteCustomerRanking.Enabled = false;
                btnRecoverCustomerRanking.Enabled = false;
            }
            else if (MaPHQ.Contains("04") || (MaPHQ.Contains("02")))
            {
                btnAddCustomerRanking.Enabled = true;
                btnEditCustomerRanking.Enabled = true;
                btnDeleteCustomerRanking.Enabled = true;
                btnRecoverCustomerRanking.Enabled = true;
            }


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
            LoadDSHangThanhVien();
        }

        private void btnEditCustomerRanking_Click(object sender, EventArgs e)
        {
            if (dgvCustomerRank.SelectedRows.Count > 0)
            {
                frmHangThanhVien frm = new frmHangThanhVien();
                frm.isAdd = false;
                //Batdau doan co the chinh sua
                int indexMHTV = dgvCustomerRank.Columns["ID"].Index;
                int indexTenHang = dgvCustomerRank.Columns["TenHang"].Index;
                int indexMucGiamGia = dgvCustomerRank.Columns["MucGiamGia"].Index;
                frm.hangThanhVienDTO.MaLoaiHangThanhVien = (int) dgvCustomerRank.SelectedRows[0].Cells[indexMHTV].Value;
                frm.hangThanhVienDTO.TenHang = dgvCustomerRank.SelectedRows[0].Cells[indexTenHang].Value.ToString();
                frm.hangThanhVienDTO.MucGiamGia = (double)dgvCustomerRank.SelectedRows[0].Cells[indexMucGiamGia].Value;
                //ket thuc doan co the chinh sua
                frm.ShowDialog();
                LoadDSHangThanhVien();
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
                    hangThanhVienDTO = new HangThanhVienDTO();
                    int indexMHTV = dgvCustomerRank.Columns["ID"].Index;
                    hangThanhVienDTO.MaLoaiHangThanhVien = (int)dgvCustomerRank.SelectedRows[0].Cells[indexMHTV].Value;
                    int indexTT = dgvCustomerRank.Columns["TrangThai"].Index;
                    hangThanhVienDTO.TrangThai = (bool)dgvCustomerRank.SelectedRows[0].Cells[indexTT].Value;

                    if (hangThanhVienDTO.TrangThai)
                    {
                        if (DelHangThanhVien(hangThanhVienDTO))
                        {
                            LoadDSHangThanhVien();
                            thongBao = new customMessageBox("Bạn đã xóa thành công dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Bạn đã xóa thất bại dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                    }
                    else
                    {
                        thongBao = new customMessageBox("Hạng thành viên này đã xóa bạn không thể xóa nữa!");
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

        private bool DelHangThanhVien(HangThanhVienDTO hangThanhVienDTO)
        {
            return hangThanhVienBLL.DelHangThanhVien(hangThanhVienDTO);
        }

        private void btnRecoverCustomerRanking_Click(object sender, EventArgs e)
        {

            if (dgvCustomerRank.SelectedRows.Count > 0)
            {
                customMessageBox thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    hangThanhVienDTO = new HangThanhVienDTO();
                    int indexMHTV = dgvCustomerRank.Columns["ID"].Index;
                    hangThanhVienDTO.MaLoaiHangThanhVien = (int)dgvCustomerRank.SelectedRows[0].Cells[indexMHTV].Value;
                    int indexTT = dgvCustomerRank.Columns["TrangThai"].Index;
                    hangThanhVienDTO.TrangThai = (bool)dgvCustomerRank.SelectedRows[0].Cells[indexTT].Value;

                    if (!hangThanhVienDTO.TrangThai)
                    {
                        if (RecoHangThanhVien(hangThanhVienDTO))
                        {
                            LoadDSHangThanhVien();
                            thongBao = new customMessageBox("Bạn đã khôi phục thành công dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Bạn đã khôi phục thất bại dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                    }
                    else
                    {
                        thongBao = new customMessageBox("Hạng thành viên này chưa xóa bạn không thể khôi phục!");
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

        private bool RecoHangThanhVien(HangThanhVienDTO hangThanhVienDTO)
        {
            return hangThanhVienBLL.RecoHangThanhVien(hangThanhVienDTO);
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
            string sortOption = cboSortSoLuongKH.SelectedItem.ToString();
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
