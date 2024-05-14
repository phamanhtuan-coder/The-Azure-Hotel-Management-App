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
    public partial class ucDiscount : UserControl
    {
        public customMessageBox thongBao;
        frmKhuyenMai frm = new frmKhuyenMai();

        public int khuyenmai = 0;
        public int hangthanhvien = -1;
        public string trangthai = "";
        KhuyenMaiBLL khuyenMaiBLL = new KhuyenMaiBLL();
        List<KhuyenMaiDTO> khuyenMaiDTOs = new List<KhuyenMaiDTO>();
        List<KhuyenMaiDTO> dsSearch = new List<KhuyenMaiDTO>();
        public string MaPHQ { get; set; }
        public ucDiscount()
        {
            InitializeComponent();
        }

        private void ucDiscount_Load(object sender, EventArgs e)
        {
            dgvDiscount.AutoGenerateColumns = false;
            colMucKhuyenMai.DefaultCellStyle.Format = "#.##%";
            colMucKhuyenMai.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            colHangTV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            LoadDuLieuHNV();
            LoadDuLieuCombobox();
            Filter();
            KiemTraPQ();
        }
        private void KiemTraPQ()
        {
            if (MaPHQ.Contains("01"))
            {

                btnAddDiscount.Enabled = false;
                btnEditDiscount.Enabled = false;
                btnDeleteDiscount.Enabled = false;
                btnRecoverDiscount.Enabled = false;
            }
            else if (MaPHQ.Contains("03"))
            {
                btnAddDiscount.Enabled = true;
                btnEditDiscount.Enabled = true;
                btnDeleteDiscount.Enabled = false;
                btnRecoverDiscount.Enabled = false;
            }
            else if (MaPHQ.Contains("04") || (MaPHQ.Contains("02")))
            {
                btnAddDiscount.Enabled = true;
                btnEditDiscount.Enabled = true;
                btnDeleteDiscount.Enabled = true;
                btnRecoverDiscount.Enabled = true;
            }


        }


        private void LoadDuLieuHNV()
        {
            HangThanhVienBLL hangThanhVienBLL = new HangThanhVienBLL();
            List<HangThanhVienDTO> list = hangThanhVienBLL.dgvHNV();
            colHangTV.DataSource = list;
            colHangTV.ValueMember = "MaLoaiHangThanhVien";
            colHangTV.DisplayMember = "TenHang";
        }

        private void LoadDSKhuyenMai()
        {
            khuyenMaiDTOs = khuyenMaiBLL.LoadDSKhuyenMai();
            foreach (var item in khuyenMaiDTOs)
            {
                item.KhuyenMai = item.KhuyenMai /100;
            }
            dgvDiscount.DataSource = khuyenMaiDTOs;
        }

        private void LoadDuLieuCombobox()
        {
            DuLieuChoComboBox.duLieuSort(cboSortDiscountID);
            LoadDuLieuHangThanhVien();
            LoadDuLieuMucKhuyenMai();
            DuLieuChoComboBox.duLieuFilter(cboStateDiscount);
        }

        private void LoadDuLieuMucKhuyenMai()
        {
            List<KhuyenMaiDTO> list = new List<KhuyenMaiDTO>();
            KhuyenMaiDTO tatca = new KhuyenMaiDTO();
            tatca.KhuyenMai = 0;
            list.Add(tatca);
            foreach (var item in khuyenMaiBLL.TruyVanSoKhuyenMai())
            {
                list.Add(item);
            }
            cboSortDiscountValue.DataSource = list;
            cboSortDiscountValue.DisplayMember = "KhuyenMai";
            cboSortDiscountValue.ValueMember = "KhuyenMai";
            cboSortDiscountValue.SelectedIndex = 0;
        }

        private void LoadDuLieuHangThanhVien()
        {
            HangThanhVienDTO TatCa = new HangThanhVienDTO();
            TatCa.MaLoaiHangThanhVien = -1;
            TatCa.TenHang = "Tất cả";
            List<HangThanhVienDTO> list = new List<HangThanhVienDTO> { TatCa };
            HangThanhVienBLL hangThanhVienBLL = new HangThanhVienBLL();
            foreach (var item in hangThanhVienBLL.LoadIDAndNameBLL())
            {
                list.Add(item);
            }
            cboLocHangTV.DataSource = list;
            cboLocHangTV.DisplayMember = "TenHang";
            cboLocHangTV.ValueMember = "MaLoaiHangThanhVien";
            cboLocHangTV.SelectedIndex = 0;
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            frm.isAdd = true;
            frm.ShowDialog();
            Filter();
        }

        private void btnEditDiscount_Click(object sender, EventArgs e)
        {
            if (dgvDiscount.SelectedRows.Count > 0)
            {
                frm.isAdd = false;
                frm.khuyenMaiDTO = dgvDiscount.SelectedRows[0].DataBoundItem as KhuyenMaiDTO;
                frm.ShowDialog();
                Filter();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            if (dgvDiscount.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvDiscount.Columns["colTrangThai"].Index;
                if ((bool)dgvDiscount.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        int khuyenMai = dgvDiscount.Columns["colMaKM"].Index;
                        int maKM = (int)dgvDiscount.SelectedRows[0].Cells[khuyenMai].Value;
                        if (XoaKhuyenMai(maKM))
                        {
                            Filter();
                            thongBao = new customMessageBox("Xóa thành công dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Xóa thất bại dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                    }
                }
                else
                {
                    thongBao = new customMessageBox("Bạn không thể xóa khuyến mãi đã xóa!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private bool XoaKhuyenMai(int maKM)
        {
            return khuyenMaiBLL.XoaKhuyenMai(maKM);
        }

        private void btnRecoverDiscount_Click(object sender, EventArgs e)
        {
            if (dgvDiscount.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvDiscount.Columns["colTrangThai"].Index;
                if (!(bool)dgvDiscount.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        int khuyenMai = dgvDiscount.Columns["colMaKM"].Index;
                        int maKM = (int) dgvDiscount.SelectedRows[0].Cells[khuyenMai].Value;
                        if (KhoiPhucKhuyenMai(maKM))
                        {
                            Filter();
                            thongBao = new customMessageBox("Khôi phục thành công dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Khôi phục thất bại dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                    }

                }
                else
                {
                    thongBao = new customMessageBox("Bạn không thể khôi phục khuyến mãi chưa xóa!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private bool KhoiPhucKhuyenMai(int maKM)
        {
            return khuyenMaiBLL.KhoiPhucKhuyenMai(maKM);
        }

        private void cboSortDiscountValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            khuyenmai = int.Parse(cboSortDiscountValue.Text);

            if (khuyenmai >= 0)
            {
                Filter();
            }
        }

        private void cboLocHangTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangthanhvien = (int)cboLocHangTV.SelectedValue;

            if (hangthanhvien >= -1)
            {
                Filter();
            }
        }

        private void cboStateDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            trangthai = cboStateDiscount.Text;

            if (trangthai.Length > 0)
            {
                Filter();
            }
        }

        private void cboSortDiscountID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortDiscountID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    khuyenMaiDTOs = khuyenMaiDTOs.OrderByDescending(item => item.MaKM).ToList();
                    break;
                default:
                    khuyenMaiDTOs = khuyenMaiDTOs.OrderBy(item => item.MaKM).ToList();
                    break;
            }

            dgvDiscount.DataSource = khuyenMaiDTOs;
        }

        private void btnTraCuuDiscount_Click(object sender, EventArgs e)
        {
            dgvDiscount.DataSource = khuyenMaiDTOs;
            string searchKeyword = txtSearchDiscount.Text.Trim().ToLower();
            if (searchKeyword.Count() > 0)
            {
                dsSearch = khuyenMaiBLL.TraCuuKhuyenMai(khuyenMaiBLL.Filter(trangthai, hangthanhvien, khuyenmai), searchKeyword);
                dgvDiscount.DataSource = dsSearch;

            }
            else
            {
                Filter();
            }
        }

        private void Filter()
        {
            dsSearch = khuyenMaiBLL.Filter(trangthai, hangthanhvien, khuyenmai);
            foreach(KhuyenMaiDTO item in dsSearch)
            {
                item.KhuyenMai = item.KhuyenMai / 100;
            }
            dgvDiscount.DataSource = dsSearch;
        }
    }
}