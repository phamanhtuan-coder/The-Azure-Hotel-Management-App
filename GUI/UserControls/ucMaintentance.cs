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
    public partial class ucMaintentance : UserControl
    {
        frmBaoTri frm = new frmBaoTri();
        customMessageBox thongBao;
        List<BaoTriDTO> baoTriDTOs = new List<BaoTriDTO>();
        List<BaoTriDTO> baoTriDTOstk = new List<BaoTriDTO>();
        BaoTriBLL baoTriBLL = new BaoTriBLL();
        public string MaPHQ { get; set; }
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        public ucMaintentance()
        {
            InitializeComponent();
        }

        private void ucMaintance_Load(object sender, EventArgs e)
        {
            LoadDSNV();
            LoadDSTB();
            Loadds();
            dgvMaintenance.AutoGenerateColumns = false;
            Loadcombo();
            KiemTraPQ();
        }
        private void KiemTraPQ()
        {
            if (MaPHQ.Contains("01"))
            {

                btnAddMaintentance.Enabled = false;
                btnEditMaintentance.Enabled = false;
                btnDeleteMaintentance.Enabled = false;
                btnRecoverMaintentance.Enabled = false;
            }
            else if (MaPHQ.Contains("03"))
            {
                btnAddMaintentance.Enabled = true;
                btnEditMaintentance.Enabled = true;
                btnDeleteMaintentance.Enabled = false;
                btnRecoverMaintentance.Enabled = false;
            }
            else if (MaPHQ.Contains("04") || (MaPHQ.Contains("02")))
            {
                btnAddMaintentance.Enabled = true;
                btnEditMaintentance.Enabled = true;
                btnDeleteMaintentance.Enabled = true;
                btnRecoverMaintentance.Enabled = true;
            }


        }

        private void LoadDSTB()
        {
            ThietBiBLL thietBiBLL = new ThietBiBLL();
            List<ThietBiDTO> thietBiDTOs = thietBiBLL.laydstbi();
            colMaThietBi.DataSource = thietBiDTOs;
            colMaThietBi.DisplayMember = "TenThietBi";
            colMaThietBi.ValueMember = "MaThietBi";
        }

        private void LoadDSNV()
        {
            List<NhanVienDTO> list = nhanVienBLL.LoadIDAndNameBLLBaoTri();
            colMaNV.DataSource = list;
            colMaNV.DisplayMember = "HoTenNV";
            colMaNV.ValueMember = "MaNV";
        }

        private void Loadds()
        {
            baoTriDTOs = baoTriBLL.laydsp2();
            dgvMaintenance.DataSource = baoTriDTOs;
        }

        private void Loadcombo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortMaintentanceD);
            DuLieuChoComboBox.duLieuFilter(cboStateMaintentance);
        }

        private void btnAddMaintentance_Click(object sender, EventArgs e)
        {
            frm.isAdd = true;
            frm.ShowDialog();
            dgvMaintenance.ClearSelection();
            Loadds();
        }
        private void LayDuLieuTuForm(frmBaoTri frm)
        {
            //Gán giá trị như bình thường
            frm.BaoTriDTO.MaBaoTri = (int)dgvMaintenance.SelectedRows[0].Cells["colMaBaoTri"].Value;
            frm.BaoTriDTO.MaThietBi = (int)dgvMaintenance.SelectedRows[0].Cells["colMaThietBi"].Value;
            frm.BaoTriDTO.MaNV = (int)dgvMaintenance.SelectedRows[0].Cells["colMaNV"].Value;
            frm.BaoTriDTO.NgayHuHong = (DateTime)dgvMaintenance.SelectedRows[0].Cells["colNgayHuHong"].Value;
            frm.BaoTriDTO.NgayBaoTri = (DateTime)dgvMaintenance.SelectedRows[0].Cells["colNgayBaoTri"].Value;
            frm.BaoTriDTO.TrangThai = Convert.ToBoolean(dgvMaintenance.SelectedRows[0].Cells["colTrangThai"].Value);
        }
        private void btnEditMaintentance_Click(object sender, EventArgs e)
        {
            if (dgvMaintenance.SelectedRows.Count > 0)
            {

                frm.isAdd = false;

                LayDuLieuTuForm(frm);


                frm.ShowDialog();
                dgvMaintenance.ClearSelection();
                Loadds();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteMaintentance_Click(object sender, EventArgs e)
        {
            if (dgvMaintenance.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    int mabtri = (int)dgvMaintenance.SelectedRows[0].Cells["colMaBaoTri"].Value;
                    bool check = baoTriBLL.Xoabt(mabtri);
                    if (check)
                    {

                        dgvMaintenance.ClearSelection();
                        Loadds();
                        thongBao = new customMessageBox(
                            "Xóa thành công dữ liệu có mã là: " + mabtri + "!"
                        );
                        thongBao.ShowDialog();
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Xóa thất bại dữ liệu có mã là: " + mabtri + "!"
                        );
                        thongBao.ShowDialog();
                    }
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private void btnRecoverMaintentance_Click(object sender, EventArgs e)
        {
            if (dgvMaintenance.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    int mabtri = (int)dgvMaintenance.SelectedRows[0].Cells["colMaBaoTri"].Value;
                    bool check = baoTriBLL.khoiphucbt(mabtri);
                    if (check)
                    {

                        dgvMaintenance.ClearSelection();
                        Loadds();
                        thongBao = new customMessageBox(
                            "Khôi phục thành công dữ liệu có mã là: " + mabtri + "!"
                        );
                        thongBao.ShowDialog();
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Khôi phục thất bại dữ liệu có mã là: " + mabtri + "!"
                        );
                        thongBao.ShowDialog();
                    }
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private void cboSortMaintentanceD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortMaintentanceD.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    baoTriDTOs = baoTriDTOs.OrderByDescending(item => item.MaBaoTri).ToList();
                    break;
                default:
                    baoTriDTOs = baoTriDTOs.OrderBy(item => item.MaBaoTri).ToList();
                    break;
            }

            dgvMaintenance.DataSource = baoTriDTOs;
        }

        private void cboStateMaintentance_SelectedIndexChanged(object sender, EventArgs e)
        {
            baoTriDTOs = baoTriBLL.FilterTrangThai(cboStateMaintentance.Text);
            dgvMaintenance.ClearSelection();
            dgvMaintenance.DataSource = baoTriDTOs;
        }

        private void btnTraCuuMaintentance_Click(object sender, EventArgs e)
        {
            baoTriDTOs = baoTriBLL.laydsp();
            dgvMaintenance.DataSource = baoTriDTOs;
            string searchKeyword = txtSearchMaintentance.Text.Trim();
            if (searchKeyword.Count() > 0)
            {
                baoTriDTOstk = baoTriBLL.TraCuubt(baoTriDTOs, searchKeyword);

                dgvMaintenance.DataSource = baoTriDTOstk;

            }
            else
            {
                Loadds();
            }
        }
    }
}
