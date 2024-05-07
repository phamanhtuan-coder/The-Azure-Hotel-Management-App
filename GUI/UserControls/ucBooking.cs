﻿using GUI.customForm;
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
using System.Net.NetworkInformation;
namespace GUI.UserControls
{
    public partial class ucBooking : UserControl
    {
        public customMessageBox thongBao;
        public frmDatPhong frm = new frmDatPhong();
        DatPhongBLL DatPhongBLL=new DatPhongBLL();
        List<DatPhongDTO> list = new List<DatPhongDTO>();
        List<DatPhongDTO> datPhongDTOs = new List<DatPhongDTO>();
        List<DatPhongDTO> datPhongDTOstk = new List<DatPhongDTO>();
        List<PhongDTO> PhongDTOs = new List<PhongDTO>();
        PhongBLL PhongBLL = new PhongBLL();
        bool KT = false;
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
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dgvBooking.SelectedRows)
                {
                    DatPhongDTO datPhongDTO = item.DataBoundItem as DatPhongDTO;
                    if (datPhongDTO.NgayNhanPhong.ToString().Length == 0)
                    {
                        if(datPhongDTO.NgayDatPhong.ToString("dd/MM/yyyy").Equals(DateTime.Now.ToString("dd/MM/yyyy")))
                        {
                            list.Add(datPhongDTO);
                        }
                        else
                        {
                            thongBao = new customMessageBox("Thông tin ngày đặt phòng của mã " + datPhongDTO.MaDatPhong + " không khớp, vui lòng kiểm tra lại!");
                            thongBao.ShowDialog();
                        }       
                    }
                    else
                    {
                        thongBao = new customMessageBox("Đặt phòng với mã " + datPhongDTO.MaDatPhong + " đã được check-in, bạn không thể check-in nữa!");
                        thongBao.ShowDialog();
                    }
                }

                if (list.Count > 0)
                {
                    if (DatPhongBLL.Check_in(list))
                    {
                        layds();
                    }
                    else
                    {
                        thongBao = new customMessageBox("Bạn đã Check-in thất bại!");
                        thongBao.ShowDialog();
                    }
                }              
            }
            else
            {
                thongBao = new customMessageBox("Bạn vui lòng chọn đặt phòng để check-in!");
                thongBao.ShowDialog();
            }
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (KT)
            {
                if (dgvBooking.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow item in dgvBooking.SelectedRows)
                    {
                        DatPhongDTO datPhongDTO = item.DataBoundItem as DatPhongDTO;
                        if (datPhongDTO.NgayTraPhong.ToString().Length == 0)
                        {
                            list.Add(datPhongDTO);
                        }
                        else
                        {
                            thongBao = new customMessageBox("Đặt phòng với mã " + datPhongDTO.MaDatPhong + " đã được check-out, bạn không thể check-out nữa!");
                            thongBao.ShowDialog();
                        }
                    }

                    if (list.Count > 0)
                    {
                        frmHoaDon frmHoaDon = new frmHoaDon();
                        frmHoaDon.isAdd = true;
                        frmHoaDon.hoaDonDTO.MaKH = (int) dgvBooking.SelectedRows[0].Cells["colMaKH"].Value;
                        frmHoaDon.ShowDialog();
                        if (BienTam.KTThemHoaDon != -1) 
                        {
                            if (DatPhongBLL.Check_out(BienTam.MaKM, BienTam.KTThemHoaDon, list))
                            {
                                layds();
                            }
                            else
                            {
                                thongBao = new customMessageBox("Bạn đã Check-out thất bại!");
                                thongBao.ShowDialog();
                            } 
                        }
                    }
                }
                else
                {
                    thongBao = new customMessageBox("Bạn vui lòng chọn đặt phòng để check-out!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Bạn vui lòng tìm thông tin khách hàng!");
                thongBao.ShowDialog();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            KT = false;
            layds();
            txtCCCD.Text = "";
            txtTraCuuUser.Text = "";
            dtpNgayDat.Value = DateTime.Now;
        }

        private void btnTraCuuDP_Click(object sender, EventArgs e)
        {
            object ngayNhanPhongObject = dtpNgayDat.Value;
            DateTime ng;
            if (ngayNhanPhongObject != DBNull.Value)
            {
                ng = DateTime.Parse(ngayNhanPhongObject.ToString());
            }
            else
            {
                ng = DateTime.Now;
            }
            datPhongDTOs = DatPhongBLL.Filter(txtCCCD.Text,txtTraCuuUser.Text, ng);
            dgvBooking.ClearSelection();
            dgvBooking.DataSource = datPhongDTOs;

            KT = true;
        }
    }
}
