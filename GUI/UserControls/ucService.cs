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
    public partial class ucService : UserControl
    {
        string tt;
        customMessageBox thongBao;
        frmDatDichVu frm = new frmDatDichVu();
        DatDichVuBLL datDichVuBLL = new DatDichVuBLL();
        List<DatDichVuDTO> datDichVuDTOs = new List<DatDichVuDTO>();
        List<DatDichVuDTO> datDichVuDTOstk = new List<DatDichVuDTO>();
        DatPhongBLL datPhongBLL = new DatPhongBLL();
        List<DatPhongDTO> datPhongDTOs = new List<DatPhongDTO>();
        DichVuBLL DichVuBLL = new DichVuBLL();
        List<DichVuDTO> dichVuDTOs = new List<DichVuDTO>();
        public string MaPHQ { get; set; }
        public ucService()
        {
            InitializeComponent();
        }

        private void ucService_Load(object sender, EventArgs e)
        {
            LoadDULieuDV();
            dgvServices.AutoGenerateColumns = false;
            colNgayDat.DefaultCellStyle.Format= "dd/MM/yyyy";
            Loadcombo();
            KiemTraPQ();
        }
        private void KiemTraPQ()
        {
            if (MaPHQ.Contains("01"))
            {

                btnAddlService.Enabled = false;
                btnEditlService.Enabled = false;
                btnDeletelService.Enabled = false;
                btnRecoverlService.Enabled = false;
            }
            else if (MaPHQ.Contains("03"))
            {
                btnAddlService.Enabled = true;
                btnEditlService.Enabled = true;
                btnDeletelService.Enabled = false;
                btnRecoverlService.Enabled = false;
            }
            else if (MaPHQ.Contains("04") || (MaPHQ.Contains("02")))
            {
                btnAddlService.Enabled = true;
                btnEditlService.Enabled = true;
                btnDeletelService.Enabled = true;
                btnRecoverlService.Enabled = true;
            }


        }

        private void LoadDULieuDV()
        {
            List<DichVuDTO> list = DichVuBLL.loadIdandName();
            colMaDV.DataSource = list;
            colMaDV.ValueMember = "MaDV";
            colMaDV.DisplayMember = "TenDV";
        }

        private void Loadds()
        {
            datDichVuDTOs = datDichVuBLL.laydsddv();
            dgvServices.DataSource = datDichVuDTOs;
        }

        private void Loadcombo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortBookingID);
            DuLieuChoComboBox.duLieuSort(cboSortServiceD);
            DuLieuChoComboBox.duLieuFilter(cboStateService);
            //datPhongDTOs = datPhongBLL.laydsp2();
            //colMaDatPhong.DataSource = datPhongDTOs;
            //colMaDatPhong.ValueMember = "MaDatPhong";
            //dichVuDTOs = DichVuBLL.laydsdvu();
            //colMaDV.DataSource = dichVuDTOs;
            //colMaDV.DisplayMember = "TenDV";
            //colMaDV.ValueMember = "MaDV";
        }

        private void btnAddlService_Click(object sender, EventArgs e)
        {
            frm.isAdd = true;
            frm.ShowDialog();
            dgvServices.ClearSelection();
            Filter();
        }
        private void LayDuLieuTuForm(frmDatDichVu frm)
        {
            //Gán giá trị như bình thường
            frm.DatDichVuDTO.MaDatDichVu = (int)dgvServices.SelectedRows[0].Cells["colMaDatDichVu"].Value;
            frm.DatDichVuDTO.MaDatPhong = (int)dgvServices.SelectedRows[0].Cells["colMaDatPhong"].Value;
            frm.DatDichVuDTO.MaDV = (int)dgvServices.SelectedRows[0].Cells["colMaDV"].Value;
            frm.DatDichVuDTO.SoLuong = (int)dgvServices.SelectedRows[0].Cells["colSoLuong"].Value;
            frm.DatDichVuDTO.NgayDat = (DateTime)dgvServices.SelectedRows[0].Cells["colNgayDat"].Value;
            frm.DatDichVuDTO.TrangThai = Convert.ToBoolean(dgvServices.SelectedRows[0].Cells["colTrangThai"].Value);
        }
        private void btnEditlService_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {

                frm.isAdd = false;
                LayDuLieuTuForm(frm);
                frm.ShowDialog();
                dgvServices.ClearSelection();
                Filter();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeletelService_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvServices.Columns["colTrangThai"].Index;
                if ((bool)dgvServices.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        int MaDatDichVu = (int)dgvServices.SelectedRows[0].Cells["colMaDatDichVu"].Value;
                        bool check = datDichVuBLL.Xoaddv(MaDatDichVu);
                        if (check)
                        {

                            dgvServices.ClearSelection();
                            Filter();
                            thongBao = new customMessageBox(
                                "Xóa thành công dữ liệu có mã là: " + MaDatDichVu + "!"
                            );
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox(
                                "Xóa thất bại dữ liệu có mã là: " + MaDatDichVu + "!"
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

        private void btnRecoverlService_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvServices.Columns["colTrangThai"].Index;
                if (!(bool)dgvServices.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        int MaDatDichVu = (int)dgvServices.SelectedRows[0].Cells["colMaDatDichVu"].Value;
                        bool check = datDichVuBLL.khoiphucddv(MaDatDichVu);
                        if (check)
                        {

                            dgvServices.ClearSelection();
                            Filter();
                            thongBao = new customMessageBox(
                                "Khôi phục thành công dữ liệu có mã là: " + MaDatDichVu + "!"
                            );
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox(
                                "Khôi phục thất bại dữ liệu có mã là: " + MaDatDichVu + "!"
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
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private void cboSortBookingID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortBookingID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    datDichVuDTOs = datDichVuDTOs.OrderByDescending(item => item.MaDatPhong).ToList();
                    break;
                default:
                    datDichVuDTOs = datDichVuDTOs.OrderBy(item => item.MaDatPhong).ToList();
                    break;
            }

            dgvServices.DataSource = datDichVuDTOs;
        }

        private void cboSortServiceD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortServiceD.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    datDichVuDTOs = datDichVuDTOs.OrderByDescending(item => item.MaDatDichVu).ToList();
                    break;
                default:
                    datDichVuDTOs = datDichVuDTOs.OrderBy(item => item.MaDatDichVu).ToList();
                    break;
            }

            dgvServices.DataSource = datDichVuDTOs;
        }

        private void cboSortThanhTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortBookingID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    datDichVuDTOs = datDichVuDTOs.OrderByDescending(item => item.MaDatDichVu).ToList();
                    break;
                default:
                    datDichVuDTOs = datDichVuDTOs.OrderBy(item => item.MaDatDichVu).ToList();
                    break;
            }

            dgvServices.DataSource = datDichVuDTOs;
        }

        private void cboStateService_SelectedIndexChanged(object sender, EventArgs e)
        {
            tt = cboStateService.Text;
            Filter();
        }

        private void Filter()
        {
            if (tt.Length > 0)
            {
                datDichVuDTOs = datDichVuBLL.FilterTrangThai(tt);
                dgvServices.ClearSelection();
                dgvServices.DataSource = datDichVuDTOs;
            }        
        }

        private void btnTraCuulService_Click(object sender, EventArgs e)
        {
            datDichVuDTOs = datDichVuBLL.laydsddv();
            dgvServices.DataSource = datDichVuDTOs;
            string searchKeyword = txtSearchlService.Text.Trim();
            if (searchKeyword.Count() > 0)
            {
                datDichVuDTOstk = datDichVuBLL.TraCuudv(datDichVuDTOs, searchKeyword);

                dgvServices.DataSource = datDichVuDTOstk;

            }
            else
            {
                Loadds();
            }
        }


        private void dtpServiceDate_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            datDichVuDTOs = datDichVuBLL.laydsddv();
            dgvServices.DataSource = datDichVuDTOs;
            DateTime searchKeyword = (DateTime)dtpServiceDate.Value;
            if (searchKeyword != null)
            {
                datDichVuDTOstk = datDichVuBLL.TraCuungay(datDichVuDTOs, searchKeyword);

                dgvServices.DataSource = datDichVuDTOstk;

            }
            else
            {
                Loadds();
            }
        }

      
    }
}
