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
    public partial class ucRating : UserControl
    {

        frmDanhGia frm = new frmDanhGia();
        customMessageBox thongBao;
        List<DanhGiaDTO> dsDanhGia;
        DanhGiaBLL danhGiaBLL;

        public ucRating()
        {
            InitializeComponent();
        }

        private void ucRating_Load(object sender, EventArgs e)
        {
            
            dgvRating.AutoGenerateColumns = false;
            LayDanhSachDanhGia();
            CapDuLieuChoController();
        }

        //Cáp dữ liệu cho các combo box
        private void CapDuLieuChoController()
        {
            //Gọi tới hàm cấp dữ liệu chung vì dữ liệu đa số giống nhau
            DuLieuChoComboBox.duLieuSort(cboRatingValue);
            DuLieuChoComboBox.duLieuFilter(cboStateRating);
        }



        private void btnDeleteRating_Click(object sender, EventArgs e)
        {

            if (dgvRating.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox(
                     "Bạn có chắc chắn muốn xóa dòng dữ liệu này không?"
                 );
                DialogResult dr = thongBao.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    String maDanhGia = dgvRating
                        .SelectedRows[0]
                        .Cells["MaDanhGia"]
                        .Value.ToString();
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
            dsDanhGia = danhGiaBLL.LayDanhSachDanhGia();
            dgvRating.DataSource = dsDanhGia;
        }

        private void btnRecoverRating_Click(object sender, EventArgs e)
        {
            if (dgvRating.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox(
                    "Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?"
                );
                DialogResult dr = thongBao.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    String maDanhGia = dgvRating
                        .SelectedRows[0]
                        .Cells["MaDanhGia"]
                        .Value.ToString();
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
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }
    }
}
