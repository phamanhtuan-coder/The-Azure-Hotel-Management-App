﻿using BLL;
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
    public partial class ucAccountType : UserControl
    {
        public string MaPHQ { get; set; }
        VaiTroBLL vaiTroBLL= new VaiTroBLL();
        List<VaiTroDTO> vaiTroDTOs = new List<VaiTroDTO>();
        List<VaiTroDTO> dsSearch = new List<VaiTroDTO>();
        frmVaiTro frm = new frmVaiTro();
        customMessageBox thongBao;
        public ucAccountType()
        {
            InitializeComponent();
        }

        private void ucAccountType_Load(object sender, EventArgs e)
        {
            dgvAccountType.AutoGenerateColumns = false; 
            LoadCBBVaiTro();
            KiemTraPQ();
        }
        private void KiemTraPQ()
        {
            if (MaPHQ.Contains("01"))
            {

                btnAddAccountType.Enabled = false;
                btnEditAccountType.Enabled = false;
                btnDeleteAccountType.Enabled = false;
                btnRecoverAccountType.Enabled = false;
            }
            else if (MaPHQ.Contains("03"))
            {
                btnAddAccountType.Enabled = true;
                btnEditAccountType.Enabled = true;
                btnDeleteAccountType.Enabled = false;
                btnRecoverAccountType.Enabled = false;
            }
            else if (MaPHQ.Contains("04") || (MaPHQ.Contains("02")))
            {
                btnAddAccountType.Enabled = true;
                btnEditAccountType.Enabled = true;
                btnDeleteAccountType.Enabled = true;
                btnRecoverAccountType.Enabled = true;
            }


        }


        private void LoadCBBVaiTro()
        {
            DuLieuChoComboBox.duLieuSort(cboSortAccountTypeID);
            DuLieuChoComboBox.duLieuFilter(cboStateAccountType);
        }

        private void loadDSRole()
        {
            vaiTroDTOs = vaiTroBLL.FilterTrangThai(cboStateAccountType.Text);
            dgvAccountType.ClearSelection();
            dgvAccountType.DataSource = vaiTroDTOs;
        }

        //private void loadDSRoleTT(int i)
        //{
        //    vaiTroDTOs = vaiTroBLL.LoadDSRoleTTBLL(i);
        //    dgvAccountType.ClearSelection();
        //    dgvAccountType.DataSource = vaiTroDTOs;
        //}

        private void btnAddAccountType_Click(object sender, EventArgs e)
        {
            frm.isAdd = true;
            frm.ShowDialog();
            loadDSRole();
        }

        private void btnEditAccountType_Click(object sender, EventArgs e)
        {
            if (dgvAccountType.SelectedRows.Count > 0)
            {
                frm.isAdd = false;
                frm.MaVaiTroID = (int)dgvAccountType.SelectedCells[0].Value;
                frm.TenVaiTro= (string)dgvAccountType.SelectedCells[1].Value;
                frm.MoTa= (string)dgvAccountType.SelectedCells[2].Value;
                //kết thúc sửa 
                frm.ShowDialog();
                loadDSRole();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }

           
        }

        private void btnDeleteAccountType_Click(object sender, EventArgs e)
        {
            if (dgvAccountType.SelectedRows.Count > 0)
            {
                bool result = (bool)dgvAccountType.SelectedCells[3].Value;
                if (result)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        int ID = frm.MaVaiTroID = (int)dgvAccountType.SelectedCells[0].Value;
                        // Xóa
                        if (DelVaiTro(ID))
                        {
                            thongBao = new customMessageBox("Xóa thành công dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                            loadDSRole();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Xóa thất bại dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                    }
                }
                else
                {
                    thongBao = new customMessageBox("Các giá trị bạn chọn đã xóa, nên không thể xóa!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }

            
        }

        private bool DelVaiTro(int iD)
        {
            return vaiTroBLL.DelVaiTroBLL(iD);
        }

        private void btnRecoverAccountType_Click(object sender, EventArgs e)
        {
            if (dgvAccountType.SelectedRows.Count > 0)
            {
                bool result = (bool) dgvAccountType.SelectedCells[3].Value;
                if (!result) {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        // Khôi phục
                        int ID = frm.MaVaiTroID = (int)dgvAccountType.SelectedCells[0].Value;
                        // Xóa
                        if (RestoreVaiTro(ID))
                        {
                            thongBao = new customMessageBox("Khôi phục thành công dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                            loadDSRole();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Khôi phục thất bại dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                    } 
                }
                else
                {
                    thongBao = new customMessageBox("Các giá trị bạn chọn chưa xóa, nên không thể khôi phục!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private bool RestoreVaiTro(int iD)
        {
            return vaiTroBLL.RestoreVaiTroBLL(iD);
        }

        private void cboSortAccountTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortAccountTypeID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    vaiTroDTOs = vaiTroDTOs.OrderByDescending(item => item.MaVaiTro).ToList();
                    break;
                default:
                    vaiTroDTOs = vaiTroDTOs.OrderBy(item => item.MaVaiTro).ToList();
                    break;
            }

            dgvAccountType.DataSource = vaiTroDTOs;
        }

        private void cboStateAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            vaiTroDTOs = vaiTroBLL.FilterTrangThai(cboStateAccountType.Text);
            dgvAccountType.ClearSelection();
            dgvAccountType.DataSource= vaiTroDTOs;
        }

        private void btnTraCuuAccountType_Click(object sender, EventArgs e)
        {
            dgvAccountType.DataSource = vaiTroDTOs;
            string searchKeyword = txtSearchAccountType.Text.Trim().ToLower();
            if (searchKeyword.Count() > 0)
            {
                dsSearch = vaiTroBLL.TraCuuVaiTro(vaiTroDTOs, searchKeyword);

                dgvAccountType.DataSource = dsSearch;
            }
            else
            {
                loadDSRole();
            }
        }

        private void tlpController_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
