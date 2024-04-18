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

namespace GUI.UserControls
{
    public partial class ucRoom : UserControl
    {
        public customMessageBox thongBao;
        frmPhong frm = new frmPhong();
        PhongBLL PhongBLL=new PhongBLL();
        List<PhongDTO> phongDTOs = new List<PhongDTO>();
        List<PhongDTO> phongDTOstk = new List<PhongDTO>();
        List<LoaiPhongDTO> loaiPhongDTOs = new List<LoaiPhongDTO>();
        LoaiPhongBLL loaiPhongBLL = new LoaiPhongBLL();
        List<TinhTrangPhongDTO> tinhTrangPhongDTOs = new List<TinhTrangPhongDTO>();
        TinhTrangPhongBLL TinhTrangPhongBLL = new TinhTrangPhongBLL();

        public ucRoom()
        {
            InitializeComponent();
        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
            layds();
            dgvRoom.AutoGenerateColumns = false;
            laycombo();

        }

        private void layds()
        {
            phongDTOs = PhongBLL.laydsp();
            dgvRoom.DataSource = phongDTOs;
        }

        private void laycombo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortRoomID);
            DuLieuChoComboBox.duLieuSort(cboSortPrice);
            DuLieuChoComboBox.duLieuFilter(cboStateRoom);

            tinhTrangPhongDTOs = TinhTrangPhongBLL.laydsttphong();
            cboRoomStatus.DataSource = tinhTrangPhongDTOs;
            cboRoomStatus.DisplayMember = "TenTinhTrang";
            cboRoomStatus.ValueMember = "MaTinhTrangPhong";
            loaiPhongDTOs = loaiPhongBLL.laydslphong();
            cboSortRoomType.DataSource = loaiPhongDTOs;
            cboSortRoomType.DisplayMember = "TenLoai";
            cboSortRoomType.ValueMember = "MaLoai";
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frmPhong frm = new frmPhong();
            frm.isAdd = true;
            frm.ShowDialog();
            dgvRoom.ClearSelection();
            layds();
        }
        private void LayDuLieuTuForm(frmPhong frm)
        {
            //Gán giá trị như bình thường
            frm.PhongDTO.MaPHG=(int)dgvRoom.SelectedRows[0].Cells["colMaPHG"].Value;
            frm.PhongDTO.MaLoai = (int)dgvRoom.SelectedRows[0].Cells["colMaLoai"].Value;
            frm.PhongDTO.MaTinhTrangPhong = (int)dgvRoom.SelectedRows[0].Cells["colMaTinhTrangPhong"].Value;
            frm.PhongDTO.GiaPhong = (decimal)dgvRoom.SelectedRows[0].Cells["colGiaPhong"].Value;
            frm.PhongDTO.SucChuaToiDa = (int)dgvRoom.SelectedRows[0].Cells["colSucChuaToiDa"].Value;
            frm.PhongDTO.MoTa = dgvRoom.SelectedRows[0].Cells["colMoTa"].Value.ToString();
            frm.PhongDTO.TrangThai = Convert.ToBoolean(dgvRoom.SelectedRows[0].Cells["colTrangThai"].Value);
        }
        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count > 0)
            {


                frmPhong frm = new frmPhong();
                frm.isAdd = false;
                LayDuLieuTuForm(frm);
                frm.ShowDialog();
                dgvRoom.ClearSelection();
                layds();


                frm.ShowDialog();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox(
                    "Bạn có chắc chắn muốn xóa dòng dữ liệu này không?"
                );
                DialogResult dr = thongBao.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    int maphong = (int)dgvRoom.SelectedRows[0].Cells["colMaPHG"].Value;
                    bool check = PhongBLL.Xoap(maphong);
                    if (check)
                    {

                        dgvRoom.ClearSelection();
                        layds();
                        thongBao = new customMessageBox(
                            "Xóa thành công dữ liệu có mã là: " + maphong + "!"
                        );
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Xóa thất bại dữ liệu có mã là: " + maphong + "!"
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

        private void btnRecoverRoom_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox(
                    "Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?"
                );
                DialogResult dr = thongBao.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    int maphong = (int)dgvRoom.SelectedRows[0].Cells["colMaPHG"].Value;
                    bool check = PhongBLL.kpp(maphong);
                    if (check)
                    {

                        dgvRoom.ClearSelection();
                        layds();
                        thongBao = new customMessageBox(
                            "Khôi phục thành công dữ liệu có mã là: " + maphong + "!"
                        );
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Khôi phục thất bại dữ liệu có mã là: " + maphong + "!"
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

        private void btnTraCuuRoom_Click(object sender, EventArgs e)
        {
            phongDTOs = PhongBLL.laydsp();
            dgvRoom.DataSource = phongDTOs;
            string searchKeyword = txtSearchRoom.Text.Trim();
            if (searchKeyword.Count() > 0)
            {
                phongDTOstk = PhongBLL.TraCuuPhong(phongDTOs, searchKeyword);

                dgvRoom.DataSource = phongDTOstk;

            }
            else
            {
                layds();
            }
        }

        private void cboStateRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            phongDTOs = PhongBLL.FilterTrangThai(cboStateRoom.Text);
            dgvRoom.ClearSelection();
            dgvRoom.DataSource = phongDTOs;
        }

        private void cboSortPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortPrice.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    phongDTOs = phongDTOs.OrderByDescending(item => item.GiaPhong).ToList();
                    break;
                default:
                    phongDTOs = phongDTOs.OrderBy(item => item.GiaPhong).ToList();
                    break;
            }

            dgvRoom.DataSource = phongDTOs;
        }

        private void cboSortRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortRoomID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    phongDTOs = phongDTOs.OrderByDescending(item => item.MaPHG).ToList();
                    break;
                default:
                    phongDTOs = phongDTOs.OrderBy(item => item.MaPHG).ToList();
                    break;
            }

            dgvRoom.DataSource = phongDTOs;
        }
    }
}
