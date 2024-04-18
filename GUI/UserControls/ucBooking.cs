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
        List<DatPhongDTO> datPhongDTOstk = new List<DatPhongDTO>();

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
                if (dr == DialogResult.OK)
                {
                    int madatphong = (int)dgvBooking.SelectedRows[0].Cells["colMaDatPhong"].Value;
                    bool check = DatPhongBLL.Xoad(madatphong);
                    if (check)
                    {

                        dgvBooking.ClearSelection();
                        layds();
                        thongBao = new customMessageBox(
                            "Xóa thành công dữ liệu có mã là: " + madatphong + "!"
                        );
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Xóa thất bại dữ liệu có mã là: " + madatphong + "!"
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

        private void btnRecoverBooking_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    int madatphong = (int)dgvBooking.SelectedRows[0].Cells["colMaDatPhong"].Value;
                    bool check = DatPhongBLL.khoiphucd(madatphong);
                    if (check)
                    {

                        dgvBooking.ClearSelection();
                        layds();
                        thongBao = new customMessageBox(
                            "Khôi phục thành công dữ liệu có mã là: " + madatphong + "!"
                        );
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Khôi phục thất bại dữ liệu có mã là: " + madatphong + "!"
                        );
                    }
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
            thongBao.ShowDialog();

        }

        private void cboSortBookingID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortRoomID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    datPhongDTOs = datPhongDTOs.OrderByDescending(item => item.MaDatPhong).ToList();
                    break;
                default:
                    datPhongDTOs = datPhongDTOs.OrderBy(item => item.MaDatPhong).ToList();
                    break;
            }

            dgvBooking.DataSource = datPhongDTOs;
        }

        private void cboSortRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortRoomID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    datPhongDTOs = datPhongDTOs.OrderByDescending(item => item.MaPHG).ToList();
                    break;
                default:
                    datPhongDTOs = datPhongDTOs.OrderBy(item => item.MaPHG).ToList();
                    break;
            }

            dgvBooking.DataSource = datPhongDTOs;
        }

        private void cboStateBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            datPhongDTOs = DatPhongBLL.FilterTrangThai(cboStateBooking.Text);
            dgvBooking.ClearSelection();
            dgvBooking.DataSource = datPhongDTOs;
        }

        private void btnTraCuuBooking_Click(object sender, EventArgs e)
        {
            datPhongDTOs = DatPhongBLL.laydsp();
            dgvBooking.DataSource = datPhongDTOs;
            string searchKeyword = txtSearchBooking.Text.Trim();
            if (searchKeyword.Count() > 0)
            {
                datPhongDTOstk = DatPhongBLL.TraCuuPhong(datPhongDTOs, searchKeyword);

                dgvBooking.DataSource = datPhongDTOstk;

            }
            else
            {
                layds();
            }
        }
    }
}
