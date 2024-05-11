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
using System.Windows.Forms.VisualStyles;

namespace GUI.UserControls
{
    public partial class ucRatingHistory : UserControl
    {

        frmDanhGia frm = new frmDanhGia();
        private frmMain _parentForm;
        customMessageBox thongBao;
        DanhGiaBLL danhGiaBLL;
        List<DanhGiaDTO> dsDanhGia;
        public int maKH { set; get; }
        public ucRatingHistory()
        {
            InitializeComponent();
        }

        public ucRatingHistory(frmMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void ucRating_Load(object sender, EventArgs e)
        {
            dgvRating.AutoGenerateColumns = false;
            LayDanhSachDanhGia();
            CapDuLieuChoController();
        }

        private void CapDuLieuChoController()
        {
            //Gọi tới hàm cấp dữ liệu chung vì dữ liệu đa số giống nhau
            DuLieuChoComboBox.duLieuFilter(cboStateRating);
            List<string> rating = new List<string>();
            rating.Add("Tất cả");
            rating.Add("0");
            rating.Add("1");
            rating.Add("2");
            rating.Add("3");
            rating.Add("4");
            rating.Add("5");
            cboRatingValue.DataSource = rating;
            cboRatingValue.SelectedIndex = 0;
        }

        private void btnEditRating_Click(object sender, EventArgs e)
        {
            if (dgvRating.SelectedRows.Count > 0)
            {

                frm.isAdd = false;
                frm.maKH = this.maKH;
                frm.danhGia.MaDG = (int)dgvRating
                    .SelectedRows[0]
                    .Cells["colMaDG"]
                    .Value;
                frm.danhGia.MaDP = (int)dgvRating
                    .SelectedRows[0]
                    .Cells["colMaDP"]
                    .Value;
                frm.danhGia.NhanXet = dgvRating
                    .SelectedRows[0]
                    .Cells["colNhanXet"]
                    .Value.ToString();
                frm.danhGia.NgayDanhGia = (DateTime)dgvRating
                    .SelectedRows[0]
                    .Cells["colNgayDG"]
                    .Value;
                frm.danhGia.DiemDanhGia = (int)dgvRating
                    .SelectedRows[0]
                    .Cells["colDiemDG"]
                    .Value;
                frm.ShowDialog();
                LayDanhSachDanhGia();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteRating_Click(object sender, EventArgs e)
        {

            if (dgvRating.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    int maDanhGia = (int) dgvRating
                           .SelectedRows[0]
                           .Cells["colMaDG"]
                           .Value;
                    danhGiaBLL = new DanhGiaBLL();
                    bool check = danhGiaBLL.XoaDanhGia(maDanhGia);
                    if (check)
                    {

                        dgvRating.ClearSelection();
                        LayDanhSachDanhGia();
                        thongBao = new customMessageBox(
                            "Xóa thành công dữ liệu có mã là: " + maDanhGia + "!"
                        );
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Xóa thất bại dữ liệu có mã là: " + maDanhGia + "!"
                        );
                    }
                }
                else
                {
                    thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                    thongBao.ShowDialog();
                }
            }
        }
        private void LayDanhSachDanhGia()
        {
            danhGiaBLL = new DanhGiaBLL();
            dsDanhGia = danhGiaBLL.LayDanhSachDanhGiaTheoUser(maKH);
            dgvRating.DataSource = dsDanhGia;
        }

        private void btnRecoverRating_Click(object sender, EventArgs e)
        {
            if (dgvRating.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {

                    int maDanhGia = (int) dgvRating
                        .SelectedRows[0]
                        .Cells["colMaDG"]
                        .Value;
                    danhGiaBLL = new DanhGiaBLL();
                    bool check = danhGiaBLL.KhoiPhucDanhGia(maDanhGia);
                    if (check)
                    {

                        dgvRating.ClearSelection();
                        LayDanhSachDanhGia();
                        thongBao = new customMessageBox(
                            "Khôi phục thành công dữ liệu có mã là: " + maDanhGia + "!"
                        );
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Khôi phục thất bại dữ liệu có mã là: " + maDanhGia + "!"
                        );
                    }

                }
                else
                {
                    thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                    thongBao.ShowDialog();
                }
            }
        }

            private void btnReturn_Click(object sender, EventArgs e)
            {
                frmMain parentForm = this.ParentForm as frmMain;
                ucPersonal ucPersonal = new ucPersonal(parentForm);
            ucPersonal.user = parentForm.user;
            ucPersonal.userKH = parentForm.userKH;
                parentForm.SwitchUserControl(ucPersonal);
                this.Dispose();
            }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            frm.isAdd = true;
            frm.maKH = this.maKH;
            frm.ShowDialog();
            LayDanhSachDanhGia();
        }

        private void cboRatingValue_SelectedIndexChanged(object sender, EventArgs e)
        {
             List<DanhGiaDTO>  dsLoc = new List<DanhGiaDTO>();
            if (cboRatingValue.SelectedItem.ToString()!="Tất cả")
            {
                dsLoc = dsDanhGia.Where(x => x.DiemDanhGia == int.Parse(cboRatingValue.SelectedValue.ToString())).ToList();
            }
            else
            {
                dsLoc = dsDanhGia;
            }
           
            dgvRating.DataSource = dsLoc;
        }

        private void cboStateRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsDanhGia = danhGiaBLL.FilterTrangThai(cboStateRating.Text);
            dgvRating.ClearSelection();
            dgvRating.DataSource = dsDanhGia;
        }

        private void dtpNgayDanhGia_ValueChanged(object sender, EventArgs e)
        {
            List<DanhGiaDTO> dsLoc = new List<DanhGiaDTO>();
            foreach (DanhGiaDTO dg in dsDanhGia)
            {
                if (dg.NgayDanhGia.Date == dtpNgayDanhGia.Value.Date)
                {
                    dsLoc.Add(dg);
                }
            }
            dgvRating.DataSource = dsLoc;
        }
    }
}