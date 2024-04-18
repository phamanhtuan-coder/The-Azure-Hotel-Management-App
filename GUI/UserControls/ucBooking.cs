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
    public partial class ucBooking : UserControl
    {
        public customMessageBox thongBao;
        public frmDatPhong frm = new frmDatPhong();
        DatPhongBLL DatPhongBLL=new DatPhongBLL();
        List<DatPhongDTO> datPhongDTOs = new List<DatPhongDTO>();
        public ucBooking()
        {
            InitializeComponent();
        }

        private void ucBooking_Load(object sender, EventArgs e)
        {
            layds();
            dgvBooking.AutoGenerateColumns = false;
            laycombo();
        }
        private void layds()
        {
            datPhongDTOs = DatPhongBLL.laydsp();
            dgvBooking.DataSource = datPhongDTOs;
        }

        private void laycombo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortRoomID);
            DuLieuChoComboBox.duLieuSort(cboSortBookingID);
            DuLieuChoComboBox.duLieuFilter(cboStateBooking);

        }
        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            
            frm.isAdd = true;
            frm.ShowDialog();
            dgvBooking.ClearSelection();
            layds();
        }
        private void LayDuLieuTuForm(frmDatPhong frm)
        {
            //Gán giá trị như bình thường
            frm.DatPhongDTO.MaDatPhong = (int)dgvBooking.SelectedRows[0].Cells["colMaDatPhong"].Value;
            frm.DatPhongDTO.MaPHG = (int)dgvBooking.SelectedRows[0].Cells["colMaPHG"].Value;
            frm.DatPhongDTO.MaKH = (int)dgvBooking.SelectedRows[0].Cells["colMaKH"].Value;
            frm.DatPhongDTO.NgayDatPhong = (DateTime)dgvBooking.SelectedRows[0].Cells["colNgayDatPhong"].Value;
            frm.DatPhongDTO.NgayNhanPhong = (DateTime)dgvBooking.SelectedRows[0].Cells["colNgayNhanPhong"].Value;
            frm.DatPhongDTO.NgayTraPhong = (DateTime)dgvBooking.SelectedRows[0].Cells["colNgayTraPhong"].Value;
            frm.DatPhongDTO.SoLuongKH =(int)dgvBooking.SelectedRows[0].Cells["colSoLuongKH"].Value;
            frm.DatPhongDTO.TrangThai = Convert.ToBoolean(dgvBooking.SelectedRows[0].Cells["colTrangThai"].Value);
        }
        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count > 0)
            {

                frm.isAdd = false;
                LayDuLieuTuForm(frm);
                frm.ShowDialog();
                dgvBooking.ClearSelection();
                layds();

                frm.ShowDialog();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count > 0)
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

        private void btnRecoverBooking_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count > 0)
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
    }
}
