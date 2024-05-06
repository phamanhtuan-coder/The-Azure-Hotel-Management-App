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
using BLL;
using DTO;
namespace GUI.UserControls
{
    public partial class ucServiceType : UserControl
    {
        customMessageBox thongBao;
        frmDichVu frm = new frmDichVu();
        DichVuDTO DichVuDTO = new DichVuDTO();
        DichVuBLL DichVuBLL = new DichVuBLL();
        List<DichVuDTO> dichVuDTOs = new List<DichVuDTO>();
        List<DichVuDTO> dichVuDTOstk = new List<DichVuDTO>();

        public ucServiceType()
        {
            InitializeComponent();
        }

        private void ucServiceType_Load(object sender, EventArgs e)
        {
            dgvServiceType.AutoGenerateColumns = false;
            loadds();
            loadcombo();
           
        }

        private void loadds()
        {
            dichVuDTOs = DichVuBLL.laydsdvu();
            dgvServiceType.DataSource= dichVuDTOs;
        }

        private void loadcombo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortServiceTypeID);
            DuLieuChoComboBox.duLieuSort(cboSortGiaServiceType);
            DuLieuChoComboBox.duLieuFilter(cboStateRoomType);
        }

        private void btnAddServiceType_Click(object sender, EventArgs e)
        {
            frmDichVu frm = new frmDichVu();
            frm.isAdd = true;
            frm.ShowDialog();
            dgvServiceType.ClearSelection();
            loadds();
        }
        public void laydutuform(frmDichVu frm)
        {
            frm.DichVuDTO.MaDV = (int)dgvServiceType.SelectedRows[0].Cells["colMaDV"].Value;
            frm.DichVuDTO.TenDV = dgvServiceType.SelectedRows[0].Cells["colTenDV"].Value.ToString();
            frm.DichVuDTO.GiaDV = (decimal)dgvServiceType.SelectedRows[0].Cells["colGiaDV"].Value;
        }
        private void btnEditServiceType_Click(object sender, EventArgs e)
        {

            if (dgvServiceType.SelectedRows.Count > 0)
            {

                frmDichVu frm = new frmDichVu();
                frm.isAdd = false;
                laydutuform(frm);
                frm.ShowDialog();
                dgvServiceType.ClearSelection();
                loadds();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteServiceType_Click(object sender, EventArgs e)
        {

            if (dgvServiceType.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    int madv = (int)dgvServiceType.SelectedRows[0].Cells["colMaDV"].Value;
                    bool check = DichVuBLL.Xoadvu(madv);
                    if (check)
                    {

                        dgvServiceType.ClearSelection();
                        loadds();
                        thongBao = new customMessageBox(
                            "Xóa thành công dữ liệu có mã là: " + madv + "!"
                        );
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Xóa thất bại dữ liệu có mã là: " + madv + "!"
                        );
                    }
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private void btnRecoverServiceType_Click(object sender, EventArgs e)
        {

            if (dgvServiceType.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    int madv = (int)dgvServiceType.SelectedRows[0].Cells["colMaDV"].Value;
                    bool check = DichVuBLL.KhoiPhucdvu(madv);
                    if (check)
                    {

                        dgvServiceType.ClearSelection();
                        loadds();
                        thongBao = new customMessageBox(
                            "Khôi phục thành công dữ liệu có mã là: " + madv + "!"
                        );
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Khôi phục thất bại dữ liệu có mã là: " + madv + "!"
                        );
                    }
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private void btnTraCuuServiceType_Click(object sender, EventArgs e)
        {
            dichVuDTOs = DichVuBLL.laydsdvu();
            dgvServiceType.DataSource = dichVuDTOs;
            string searchKeyword = txtSearchServiceType.Text.Trim();
            if (searchKeyword.Count() > 0)
            {
                dichVuDTOstk = DichVuBLL.TraCuudvu(dichVuDTOs, searchKeyword);

                dgvServiceType.DataSource = dichVuDTOstk;

            }
            else
            {
                loadds();
            }
        }

        private void cboSortServiceTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortServiceTypeID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    dichVuDTOs = dichVuDTOs.OrderByDescending(item => item.MaDV).ToList();
                    break;
                default:
                    dichVuDTOs = dichVuDTOs.OrderBy(item => item.MaDV).ToList();
                    break;
            }

            dgvServiceType.DataSource = dichVuDTOs;
        }

        private void cboSortGiaServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortServiceTypeID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    dichVuDTOs = dichVuDTOs.OrderByDescending(item => item.GiaDV).ToList();
                    break;
                default:
                    dichVuDTOs = dichVuDTOs.OrderBy(item => item.GiaDV).ToList();
                    break;
            }

            dgvServiceType.DataSource = dichVuDTOs;
        }

        private void cboStateRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dichVuDTOs = DichVuBLL.FilterTrangThai(cboStateRoomType.Text);
            dgvServiceType.ClearSelection();
            dgvServiceType.DataSource = dichVuDTOs;
        }
    }
}
