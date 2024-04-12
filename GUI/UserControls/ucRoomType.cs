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
    public partial class ucRoomType : UserControl
    {
        public frmLoaiPhong frm = new frmLoaiPhong();
        public customMessageBox thongBao;

        List<LoaiPhongDTO> dslp = new List<LoaiPhongDTO>();
        List<LoaiPhongDTO> dslptk = new List<LoaiPhongDTO>();
        LoaiPhongBLL lpbll = new LoaiPhongBLL();
        public ucRoomType()
        {
            InitializeComponent();
        }
        

        private void ucRoomType_Load(object sender, EventArgs e)
        {
            layds();
            dgvloaiphong.AutoGenerateColumns = false;
            laycombo();
        }

        private void layds()
        {
            dslp = lpbll.laydslphong();
            dgvloaiphong.DataSource = dslp;
        }

        private void laycombo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortRoomTypeID);
            DuLieuChoComboBox.duLieuSort(cboSortSoLuongRoom);
            DuLieuChoComboBox.duLieuFilter(cboStateRoomType);
        }

        private void btnAddRoomType_Click(object sender, EventArgs e)
        {
            frmLoaiPhong frm=new frmLoaiPhong();
            frm.isAdd=true;
            frm.ShowDialog();
            dgvloaiphong.ClearSelection();
            layds();
        }

        private void btnEditRoomType_Click(object sender, EventArgs e)
        {
            if (dgvloaiphong.SelectedRows.Count > 0)
            {
                frmLoaiPhong frm = new frmLoaiPhong();
                frm.isAdd = false;
                LayDuLieuTuForm(frm);
                frm.ShowDialog();
                dgvloaiphong.ClearSelection();
                layds();
            }
            else
            {
                //Thông báo nếu không có dòng được chọn
                thongBao = new customMessageBox("Hãy chọn 1 dòng dữ liệu bạn muốn thay đổi!");
                thongBao.ShowDialog();
            }
        }
        private void LayDuLieuTuForm(frmLoaiPhong frm)
        {
            //Gán giá trị như bình thường
            frm.loaiphong.MaLoai =(int) dgvloaiphong.SelectedRows[0].Cells["colmaloai"].Value;
            frm.loaiphong.TenLoai = dgvloaiphong
                .SelectedRows[0]
                .Cells["coltenloai"]
                .Value.ToString();
            frm.loaiphong.Mota =dgvloaiphong.SelectedRows[0].Cells["colmota"].Value.ToString();
            frm.loaiphong.TrangThai = Convert.ToBoolean(dgvloaiphong.SelectedRows[0].Cells["coltrangthai"].Value);
        }

        private void btnDeleteRoomType_Click(object sender, EventArgs e)
        {
            if (dgvloaiphong.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox(
                    "Bạn có chắc chắn muốn xóa dòng dữ liệu này không?"
                );
                DialogResult dr = thongBao.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    int maloaiphong = (int)dgvloaiphong.SelectedRows[0].Cells["colmaloai"].Value;
                    bool check = LoaiPhongBLL.Xoaloaip(maloaiphong);
                    if (check)
                    {

                        dgvloaiphong.ClearSelection();
                        layds();
                        thongBao = new customMessageBox(
                            "Xóa thành công dữ liệu có mã là: " + maloaiphong + "!"
                        );
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Xóa thất bại dữ liệu có mã là: " + maloaiphong + "!"
                        );
                    }
                }
                else
                {
                    thongBao = new customMessageBox("Hủy xóa!");
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");

            }
            thongBao.ShowDialog();
        }

        private void btnRecoverRoomType_Click(object sender, EventArgs e)
        {
            if (dgvloaiphong.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox(
                    "Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?"
                );
                DialogResult dr = thongBao.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    int maloaiphong = (int)dgvloaiphong.SelectedRows[0].Cells["colmaloai"].Value;
                    bool check = LoaiPhongBLL.KhoiPhucloaip(maloaiphong);
                    if (check)
                    {

                        dgvloaiphong.ClearSelection();
                        layds();
                        thongBao = new customMessageBox(
                            "Khôi phục thành công dữ liệu có mã là: " + maloaiphong + "!"
                        );
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Khôi phục thất bại dữ liệu có mã là: " + maloaiphong + "!"
                        );
                    }
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");

            }
            thongBao.ShowDialog();
        }

        private void btnTraCuuRoomType_Click(object sender, EventArgs e)
        {
            dslp = lpbll.laydslphong();
            dgvloaiphong.DataSource = dslp;
            string searchKeyword = txtSearchRoomType.Text.Trim();
            if (searchKeyword.Count() > 0)
            {
                dslptk = lpbll.TraCuuLoaiPhong(dslp, searchKeyword);

                dgvloaiphong.DataSource = dslptk;

            }
            else
            {
                layds();
            }
        }

        private void cboStateRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dslp = lpbll.FilterTrangThai(cboStateRoomType.Text);
            dgvloaiphong.ClearSelection();
            dgvloaiphong.DataSource = dslp;
        }

        private void cboSortRoomTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortRoomTypeID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    dslp = dslp.OrderByDescending(item => item.MaLoai).ToList();
                    break;
                default:
                    dslp = dslp.OrderBy(item => item.MaLoai).ToList();
                    break;
            }

            dgvloaiphong.DataSource = dslp;
        }
    }
}
