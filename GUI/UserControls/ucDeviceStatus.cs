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
using DTO;
using BLL;

namespace GUI.UserControls
{
    public partial class ucDeviceStatus : UserControl
    {
        string tt;
        public customMessageBox thongBao;
        List<TTThietBiDTO> thietBiDTOs=new List<TTThietBiDTO>();
        List<TTThietBiDTO> thietBiDTOstk = new List<TTThietBiDTO>();
        TTThietBiBLL TTThietBiBLL = new TTThietBiBLL();
        public string MaPHQ { get; set; }

        public ucDeviceStatus()
        {
            InitializeComponent();
        }

        private void ucDeviceStatus_Load(object sender, EventArgs e)
        {
            dgvDeviceStatus.AutoGenerateColumns = false;
            lad_combo();
            KiemTraPQ();
            Filter();
        }
        private void KiemTraPQ()
        {
            if (MaPHQ.Contains("01"))
            {

                btnAddDeviceStatus.Enabled = false;
                btnEditDeviceStatus.Enabled = false;
                btnDeleteDeviceStatus.Enabled = false;
                btnRecoverDeviceStatus.Enabled = false;
            }
            else if (MaPHQ.Contains("03"))
            {
                btnAddDeviceStatus.Enabled = true;
                btnEditDeviceStatus.Enabled = true;
                btnDeleteDeviceStatus.Enabled = false;
                btnRecoverDeviceStatus.Enabled = false;
            }
            else if (MaPHQ.Contains("04") || (MaPHQ.Contains("02")))
            {
                btnAddDeviceStatus.Enabled = true;
                btnEditDeviceStatus.Enabled = true;
                btnDeleteDeviceStatus.Enabled = true;
                btnRecoverDeviceStatus.Enabled = true;
            }


        }


        private void lad_combo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortDeviceStatusID);
            DuLieuChoComboBox.duLieuSort(cboSortSoLuongTB);
            DuLieuChoComboBox.duLieuFilter(cboStateDeviceStatus);
        }

        private void laydstb()
        {
            thietBiDTOs = TTThietBiBLL.laydsTBi();
            dgvDeviceStatus.DataSource = thietBiDTOs;
        }

        private void btnAddDeviceStatus_Click(object sender, EventArgs e)
        {
            frmTinhTrangTB frm = new frmTinhTrangTB();
            frm.isAdd = true;
            frm.ShowDialog();
            dgvDeviceStatus.ClearSelection();
            Filter();
        }

        private void btnEditDeviceStatus_Click(object sender, EventArgs e)
        {
            // bổ sung kiểm tra dòng có đang được chọn chưa, nếu có dòng được chọn thì tiến hành xử lý, nếu không thì thông báo lỗi
            if (dgvDeviceStatus.SelectedRows.Count > 0)
            {
                frmTinhTrangTB frm = new frmTinhTrangTB();
                frm.isAdd = false;
                LayDuLieuTuForm(frm);
                frm.ShowDialog();
                dgvDeviceStatus.ClearSelection();
                Filter();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void LayDuLieuTuForm(frmTinhTrangTB frm)
        {
            frm.tTThietBiDTO.MaTinhTrangThietBi = (int)dgvDeviceStatus.SelectedRows[0].Cells["colMaTinhTrangThietBi"].Value;
            frm.tTThietBiDTO.TenTinhTrang = dgvDeviceStatus
                .SelectedRows[0]
                .Cells["colTenTinhTrang"]
                .Value.ToString();
            frm.tTThietBiDTO.MoTa = dgvDeviceStatus.SelectedRows[0].Cells["colMoTa"].Value.ToString();
            frm.tTThietBiDTO.TrangThai = Convert.ToBoolean(dgvDeviceStatus.SelectedRows[0].Cells["colTrangThai"].Value);
        }

        private void btnDeleteDeviceStatus_Click(object sender, EventArgs e)
        {
            if (dgvDeviceStatus.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvDeviceStatus.Columns["colTrangThai"].Index;
                if ((bool)dgvDeviceStatus.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        int maTTTBi = (int)dgvDeviceStatus.SelectedRows[0].Cells["colMaTinhTrangThietBi"].Value;
                        bool check = TTThietBiBLL.XoaTTTBi(maTTTBi);
                        if (check)
                        {

                            dgvDeviceStatus.ClearSelection();
                            Filter();
                            thongBao = new customMessageBox(
                                "Xóa thành công dữ liệu có mã là: " + maTTTBi + "!"
                            );
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox(
                                "Xóa thất bại dữ liệu có mã là: " + maTTTBi + "!"
                            );
                            thongBao.ShowDialog();
                        }
                    }

                }
                else
                {
                    thongBao = new customMessageBox("Bạn không thể xóa dữ liệu đã xóa!");
                    thongBao.ShowDialog();
                }

            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
            
        }

        private void btnRecoverDeviceStatus_Click(object sender, EventArgs e)
        {
            if (dgvDeviceStatus.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvDeviceStatus.Columns["colTrangThai"].Index;
                if (!(bool)dgvDeviceStatus.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        int maTTTBi = (int)dgvDeviceStatus.SelectedRows[0].Cells["colMaTinhTrangThietBi"].Value;
                        bool check = TTThietBiBLL.KhoiPhucTTTBi(maTTTBi);
                        if (check)
                        {

                            dgvDeviceStatus.ClearSelection();
                            Filter();
                            thongBao = new customMessageBox(
                                "Khôi phục thành công dữ liệu có mã là: " + maTTTBi + "!"
                            );
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox(
                                "Khôi phục thất bại dữ liệu có mã là: " + maTTTBi + "!"
                            );
                            thongBao.ShowDialog();
                        }
                    }
                }
                else
                {
                    thongBao = new customMessageBox("Bạn không thể Khôi phục dữ liệu chưa xóa!");
                    thongBao.ShowDialog();
                }

            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
            
        }

        private void btnTraCuuDeviceStatus_Click(object sender, EventArgs e)
        {

            thietBiDTOs = TTThietBiBLL.laydsTBi();
            dgvDeviceStatus.DataSource = thietBiDTOs;
            string searchKeyword = txtSearchDeviceStatus.Text.Trim();
            if (searchKeyword.Count() > 0)
            {
                thietBiDTOstk = TTThietBiBLL.tracutttb(thietBiDTOs, searchKeyword);

                dgvDeviceStatus.DataSource = thietBiDTOstk;

            }
            else
            {
                laydstb();
            }
        }

        private void cboStateDeviceStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            tt = cboStateDeviceStatus.Text;
            Filter();
        }

        private void Filter()
        {
            if (tt.Length > 0)
            {
                thietBiDTOs = TTThietBiBLL.FilterTrangThai(tt);
                dgvDeviceStatus.ClearSelection();
                dgvDeviceStatus.DataSource = thietBiDTOs;
            }
        }

        private void cboSortDeviceStatusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortDeviceStatusID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    thietBiDTOs = thietBiDTOs.OrderByDescending(item => item.MaTinhTrangThietBi).ToList();
                    break;
                default:
                    thietBiDTOs = thietBiDTOs.OrderBy(item => item.MaTinhTrangThietBi).ToList();
                    break;
            }

            dgvDeviceStatus.DataSource = thietBiDTOs;
        }
    }
}
