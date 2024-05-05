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
    public partial class ucHousekeeping : UserControl
    {
        customMessageBox thongBao;
        frmDonPhong frm = new frmDonPhong();

        string ngayBD = "";
        string ngayKT = "";
        string TT = "";
        DonPhongBLL donPhongBLL = new DonPhongBLL();
        List<DonPhongDTO> donPhongDTOs = new List<DonPhongDTO>();
        List<DonPhongDTO> dsSearch = new List<DonPhongDTO>();

        public ucHousekeeping()
        {
            InitializeComponent();
        }

        private void ucHousekeeping_Load(object sender, EventArgs e)
        {
            LoadDuLieuCombobox();
            LoadDuLieuDonPhong();
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
        }

        private void btnEditHousekeeping_Click(object sender, EventArgs e)
        {
            if (dgvHousekeeping.SelectedRows.Count > 0)
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

        private void btnDeleteHousekeeping_Click(object sender, EventArgs e)
        {
            if (dgvHousekeeping.SelectedRows.Count > 0)
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

        private void btnRecoverHousekeeping_Click(object sender, EventArgs e)
        {
            if (dgvHousekeeping.SelectedRows.Count > 0)
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

        private void cboStateHousekeeping_SelectedIndexChanged(object sender, EventArgs e)
        {
            TT= cboSortHousekeeping.Text;

            if (TT.Length > 0)
            {
                Filter();
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ngayBD = dtpNgayNhan.Value.ToString();
            ngayKT = dtpNgayHoanThanh.Value.ToString();

            if(ngayBD.Length>0 && ngayKT.Length > 0)
            {
                Filter();
            }          
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
            dsSearch = donPhongBLL.Filter(TT, ngayBD, ngayKT);
            dgvHousekeeping.DataSource = dsSearch;
        }
    }
}
