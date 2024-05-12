using BLL;
using DTO;
using GUI.customForm;
using Syncfusion.WinForms.ListView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ucHousekeeping : UserControl
    {
        customMessageBox thongBao;
        frmDonPhong frm = new frmDonPhong();

        DateTime ngayBD;
        string TT = "";
        DonPhongBLL donPhongBLL = new DonPhongBLL();
        List<DonPhongDTO> donPhongDTOs = new List<DonPhongDTO>();
        List<DonPhongDTO> dsSearch = new List<DonPhongDTO>();
        public string MaPHQ { get; set; }

        public ucHousekeeping()
        {
            InitializeComponent();
        }

        private void ucHousekeeping_Load(object sender, EventArgs e)
        {
            dgvHousekeeping.AutoGenerateColumns = false;
            LoadDuLieuNhanVien();
            LoadDuLieuCombobox();
            LoadDuLieuDonPhong();
            KiemTraPQ();
        }
        private void KiemTraPQ()
        {
            if (MaPHQ.Contains("01"))
            {

                btnAddHousekeeping.Enabled = false;
                btnEditHousekeeping.Enabled = false;
                btnDeleteHousekeeping.Enabled = false;
                btnRecoverHousekeeping.Enabled = false;
            }
            else if (MaPHQ.Contains("03"))
            {
                btnAddHousekeeping.Enabled = true;
                btnEditHousekeeping.Enabled = true;
                btnDeleteHousekeeping.Enabled = false;
                btnRecoverHousekeeping.Enabled = false;
            }
            else if (MaPHQ.Contains("04") || (MaPHQ.Contains("02")))
            {
                btnAddHousekeeping.Enabled = true;
                btnEditHousekeeping.Enabled = true;
                btnDeleteHousekeeping.Enabled = true;
                btnRecoverHousekeeping.Enabled = true;
            }


        }
        private void LoadDuLieuNhanVien()
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            List<NhanVienDTO> nhanVienDTO = nhanVienBLL.LoadIDAndNameBLLDonPhong();
            colMaNV.DataSource = nhanVienDTO;
            colMaNV.ValueMember = "MaNV";
            colMaNV.DisplayMember = "HoTenNV";
        }

        private void LoadDuLieuDonPhong()
        {
            donPhongDTOs = donPhongBLL.LoadDuLieuDonPhong();
            dgvHousekeeping.DataSource = donPhongDTOs;
        }

        private void LoadDuLieuCombobox()
        {
            DuLieuChoComboBox.duLieuSort(cboSortHousekeeping);
            DuLieuChoComboBox.duLieuFilter(cboStateHousekeeping);
        }

        private void btnAddHousekeeping_Click(object sender, EventArgs e)
        {
            frm.isAdd = true;
            frm.ShowDialog();
            Filter();
        }

        private void btnEditHousekeeping_Click(object sender, EventArgs e)
        {
            if (dgvHousekeeping.SelectedRows.Count > 0)
            {

                frm.isAdd = false;

                frm.donPhongDTO = dgvHousekeeping.SelectedRows[0].DataBoundItem as DonPhongDTO;

                frm.ShowDialog();
                Filter();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteHousekeeping_Click(object sender, EventArgs e)
        {
            if (dgvHousekeeping.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvHousekeeping.Columns["colTrangThai"].Index;
                if ((bool)dgvHousekeeping.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        int donPhong = dgvHousekeeping.Columns["colMaDP"].Index;
                        int maDP = (int)dgvHousekeeping.SelectedRows[0].Cells[donPhong].Value;
                        if (XoaDonPhong(maDP))
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
                    thongBao = new customMessageBox("Bạn không thể xóa dọn phòng đã xóa!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private bool XoaDonPhong(int maDP)
        {
            return donPhongBLL.XoaDonPhong(maDP);
        }

        private void btnRecoverHousekeeping_Click(object sender, EventArgs e)
        {
            if (dgvHousekeeping.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvHousekeeping.Columns["colTrangThai"].Index;
                if (!(bool)dgvHousekeeping.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        int donPhong = dgvHousekeeping.Columns["colMaDP"].Index;
                        int maDP = (int)dgvHousekeeping.SelectedRows[0].Cells[donPhong].Value;
                        if (KhoiPhucDonPhong(maDP))
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
                    thongBao = new customMessageBox("Bạn không thể khôi phục dọn phòng chưa xóa!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private bool KhoiPhucDonPhong(int maDP)
        {
            return donPhongBLL.KhoiPhucDonPhong(maDP);
        }

        private void cboStateHousekeeping_SelectedIndexChanged(object sender, EventArgs e)
        {
            TT= cboStateHousekeeping.Text;
            ngayBD = DateTime.Parse("1/1/1900");

            if (TT.Length > 0)
            {
                Filter();
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime.TryParseExact(dtpNgayNhan.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayBD);
            Filter();        
        }
        private void cboSortHousekeeping_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortHousekeeping.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    donPhongDTOs = donPhongDTOs.OrderByDescending(item => item.MaDonPhong).ToList();
                    break;
                default:
                    donPhongDTOs = donPhongDTOs.OrderBy(item => item.MaDonPhong).ToList();
                    break;
            }

            dgvHousekeeping.DataSource = donPhongDTOs;
        }

        private void btnTraCuuHousekeeping_Click(object sender, EventArgs e)
        {
            dgvHousekeeping.DataSource = donPhongDTOs;
            string searchKeyword = txtSearchHousekeeping.Text.Trim().ToLower();
            if (searchKeyword.Count() > 0)
            {
                dsSearch = donPhongBLL.TraCuuDonPhong(donPhongDTOs, searchKeyword);
                dgvHousekeeping.DataSource = dsSearch;
            }
            else
            {
                Filter();
            }
        }

        private void Filter()
        {
            dsSearch = donPhongBLL.Filter(TT, ngayBD);
            dgvHousekeeping.DataSource = dsSearch;
        }       
    }
}
