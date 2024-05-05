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

        public ucDiscount()
        {
            InitializeComponent();
        }

        private void ucDiscount_Load(object sender, EventArgs e)
        {
            LoadDuLieuCombobox();
            LoadDSKhuyenMai();
        }

        private void LoadDSKhuyenMai()
        {
            khuyenMaiDTOs = khuyenMaiBLL.LoadDSKhuyenMai();
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
            foreach(var item in khuyenMaiBLL.TruyVanSoKhuyenMai())
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
                frm.khuyenMaiDTO= dgvDiscount.SelectedRows[0].DataBoundItem as KhuyenMaiDTO;
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

        private void btnRecoverDiscount_Click(object sender, EventArgs e)
        {
            if (dgvDiscount.SelectedRows.Count > 0)
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

        private void cboSortDiscountValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            khuyenmai = int.Parse(cboSortDiscountValue.Text);
            
            if(khuyenmai >= 0)
            {
                Filter();
            }
        }

        private void cboLocHangTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangthanhvien= (int) cboLocHangTV.SelectedValue;
            
            if(hangthanhvien >= -1)
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
            dgvDiscount.DataSource = dsSearch;
        }
    }
}
