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
using DTO;
using BLL;
namespace GUI.UserControls
{
    public partial class ucRoomStatus : UserControl
    {
        public frmTinhTrangPhong frm = new frmTinhTrangPhong();
        public customMessageBox thongBao;
        List<TinhTrangPhongDTO> tinhTrangPhongDTOs = new List<TinhTrangPhongDTO>();
        TinhTrangPhongBLL TinhTrangPhongBLL=new TinhTrangPhongBLL();
        public ucRoomStatus()
        {
            InitializeComponent();
        }

        private void ucRoomStatus_Load(object sender, EventArgs e)
        {
            dgvRoomStatus.AutoGenerateColumns = false;
            laydsttphong();
            laycombo();
           
        }

        private void laycombo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortRoomStatusID);
            DuLieuChoComboBox.duLieuSort(cboSortSoLuongRoom);
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
            laydsttphong();
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
                laydsttphong();
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
                        laydsttphong();
                        thongBao = new customMessageBox(
                            "Xóa thành công dữ liệu có mã là: " + mattphong + "!"
                        );
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Xóa thất bại dữ liệu có mã là: " + mattphong + "!"
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

        private void btnRecoverRoomStatus_Click(object sender, EventArgs e)
        {
            if (dgvRoomStatus.SelectedRows.Count > 0)
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
                        laydsttphong();
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
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");

            }
            thongBao.ShowDialog();
        }
    }
}
