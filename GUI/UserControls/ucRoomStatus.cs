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
    public partial class ucRoomStatus : UserControl
    {
        string tt;
        public frmTinhTrangPhong frm = new frmTinhTrangPhong();
        public customMessageBox thongBao;
        List<TinhTrangPhongDTO> tinhTrangPhongDTOs = new List<TinhTrangPhongDTO>();
        List<TinhTrangPhongDTO> tinhTrangPhongDTOstk = new List<TinhTrangPhongDTO>();
        TinhTrangPhongBLL TinhTrangPhongBLL =new TinhTrangPhongBLL();
        public string MaPHQ { get; set; }
        public ucRoomStatus()
        {
            InitializeComponent();
        }

        private void ucRoomStatus_Load(object sender, EventArgs e)
        {
            dgvRoomStatus.AutoGenerateColumns = false;
            laydsttphong();
            laycombo();

            KiemTraPQ();
        }
        private void KiemTraPQ()
        {
            if (MaPHQ.Contains("01"))
            {

                btnAddRoomStatus.Enabled = false;
                btnEditRoomStatus.Enabled = false;
                btnDeleteRoomStatus.Enabled = false;
                btnRecoverRoomStatus.Enabled = false;
            }
            else if (MaPHQ.Contains("03"))
            {
                btnAddRoomStatus.Enabled = true;
                btnEditRoomStatus.Enabled = true;
                btnDeleteRoomStatus.Enabled = false;
                btnRecoverRoomStatus.Enabled = false;
            }
            else if (MaPHQ.Contains("04") || (MaPHQ.Contains("02")))
            {
                btnAddRoomStatus.Enabled = true;
                btnEditRoomStatus.Enabled = true;
                btnDeleteRoomStatus.Enabled = true;
                btnRecoverRoomStatus.Enabled = true;
            }


        }

        private void laycombo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortRoomStatusID);
            DuLieuChoComboBox.duLieuFilter(cboStateRoomStatus);
        }

        private void laydsttphong()
        {
            tinhTrangPhongDTOs = TinhTrangPhongBLL.laydsttphong();
            dgvRoomStatus.DataSource=tinhTrangPhongDTOs;
        }

        private void btnAddRoomStatus_Click(object sender, EventArgs e)
        {

            frmTinhTrangPhong frm = new frmTinhTrangPhong();
            frm.isAdd = true;
            frm.ShowDialog();
            dgvRoomStatus.ClearSelection();
            Filter();
        }

        private void btnEditRoomStatus_Click(object sender, EventArgs e)
        {
            if (dgvRoomStatus.SelectedRows.Count > 0)
            {
                frmTinhTrangPhong frm = new frmTinhTrangPhong();
                frm.isAdd = false;
                LayDuLieuTuForm(frm);
                frm.ShowDialog();
                dgvRoomStatus.ClearSelection();
                Filter();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn 1 dòng dữ liệu bạn muốn thay đổi!");
                thongBao.ShowDialog();
            }
        }

        private void LayDuLieuTuForm(frmTinhTrangPhong frm)
        {
            frm.tinhTrang.MaTinhTrangPhong = (int)dgvRoomStatus.SelectedRows[0].Cells["colMaTinhTrangPhong"].Value;
            frm.tinhTrang.TenTinhTrang = dgvRoomStatus
                .SelectedRows[0]
                .Cells["colTenTinhTrang"]
                .Value.ToString();
            frm.tinhTrang.MoTa = dgvRoomStatus.SelectedRows[0].Cells["colMoTa"].Value.ToString();
            frm.tinhTrang.TrangThai = Convert.ToBoolean(dgvRoomStatus.SelectedRows[0].Cells["colTrangThai"].Value);
        }

        private void btnDeleteRoomStatus_Click(object sender, EventArgs e)
        {
            if (dgvRoomStatus.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvRoomStatus.Columns["colTrangThai"].Index;
                if ((bool)dgvRoomStatus.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox(
                    "Bạn có chắc chắn muốn xóa dòng dữ liệu này không?"
                );
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        int mattphong = (int)dgvRoomStatus.SelectedRows[0].Cells["colMaTinhTrangPhong"].Value;
                        bool check = TinhTrangPhongBLL.Xoattp(mattphong);
                        if (check)
                        {

                            dgvRoomStatus.ClearSelection();
                            Filter();
                            thongBao = new customMessageBox(
                                "Xóa thành công dữ liệu có mã là: " + mattphong + "!"
                            );
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox(
                                "Xóa thất bại dữ liệu có mã là: " + mattphong + "!"
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
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
           
        }

        private void btnRecoverRoomStatus_Click(object sender, EventArgs e)
        {
            if (dgvRoomStatus.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvRoomStatus.Columns["colTrangThai"].Index;
                if (!(bool)dgvRoomStatus.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox(
                    "Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?"
                );
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        int mattphong = (int)dgvRoomStatus.SelectedRows[0].Cells["colMaTinhTrangPhong"].Value;
                        bool check = TinhTrangPhongBLL.KhoiPhucttp(mattphong);
                        if (check)
                        {

                            dgvRoomStatus.ClearSelection();
                            Filter();
                            thongBao = new customMessageBox(
                                "Khôi phục thành công dữ liệu có mã là: " + mattphong + "!"
                            );
                        }
                        else
                        {
                            thongBao = new customMessageBox(
                                "Khôi phục thất bại dữ liệu có mã là: " + mattphong + "!"
                            );
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
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
            
        }

        private void btnTraCuuRoomStatus_Click(object sender, EventArgs e)
        {
            tinhTrangPhongDTOs = TinhTrangPhongBLL.laydsttphong();
            dgvRoomStatus.DataSource = tinhTrangPhongDTOs;
            string searchKeyword = txtSearchRoomStatus.Text.Trim();
            if (searchKeyword.Count() > 0)
            {
                tinhTrangPhongDTOstk = TinhTrangPhongBLL.TraCuuttPhong(tinhTrangPhongDTOs, searchKeyword);

                dgvRoomStatus.DataSource = tinhTrangPhongDTOstk;

            }
            else
            {
                laydsttphong();
            }
        }

        private void cboStateRoomStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            tt = cboStateRoomStatus.Text;
            Filter();
        }

        private void Filter()
        {
            if (tt.Length > 0)
            {
                tinhTrangPhongDTOs = TinhTrangPhongBLL.FilterTrangThai(tt);
                dgvRoomStatus.ClearSelection();
                dgvRoomStatus.DataSource = tinhTrangPhongDTOs;
            }
        }

        private void cboSortRoomStatusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortRoomStatusID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    tinhTrangPhongDTOs = tinhTrangPhongDTOs.OrderByDescending(item => item.MaTinhTrangPhong).ToList();
                    break;
                default:
                    tinhTrangPhongDTOs = tinhTrangPhongDTOs.OrderBy(item => item.MaTinhTrangPhong).ToList();
                    break;
            }

            dgvRoomStatus.DataSource = tinhTrangPhongDTOs;
        }
    }
}
