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
    public partial class ucTax : UserControl
    {
        public string tt { get; set; }

        ThueBLL thueBLL = new ThueBLL();
        List<ThueDTO> thueDTOs = new List<ThueDTO>();
        List<ThueDTO> dsSearch = new List<ThueDTO>();

        public customMessageBox thongBao;
        frmThue frm = new frmThue();
        public ucTax()
        {
            InitializeComponent();
        }

        private void ucTax_Load(object sender, EventArgs e)
        {
            LoadDuLieuCombobox();
            LoadDSThue();
        }

        private void LoadDuLieuCombobox()
        {
            DuLieuChoComboBox.duLieuSort(cboSortTaxID);
            DuLieuChoComboBox.duLieuSort(cboSortTaxValue);
            DuLieuChoComboBox.duLieuFilter(cboStateTax);
        }

        private void LoadDSThue()
        {
            thueDTOs = thueBLL.TruyVanDSThue();
            dgvTax.DataSource =thueDTOs;
        }

        private void btnAddTax_Click(object sender, EventArgs e)
        {
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditTax_Click(object sender, EventArgs e)
        {
            if (dgvTax.SelectedRows.Count > 0)
            {

                frm.isAdd = false;




                frm.ShowDialog();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteTax_Click(object sender, EventArgs e)
        {
            if (dgvTax.SelectedRows.Count > 0)
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

        private void btnRecoverTax_Click(object sender, EventArgs e)
        {
            if (dgvTax.SelectedRows.Count > 0)
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

        private void cboSortTaxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortTaxID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    thueDTOs = thueDTOs.OrderByDescending(item => item.MaThue).ToList();
                    break;
                default:
                    thueDTOs = thueDTOs.OrderBy(item => item.MaThue).ToList();
                    break;
            }

            dgvTax.DataSource = thueDTOs;
        }

        private void cboSortTaxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortTaxID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    thueDTOs = thueDTOs.OrderByDescending(item => item.TyLeThue).ToList();
                    break;
                default:
                    thueDTOs = thueDTOs.OrderBy(item => item.TyLeThue).ToList();
                    break;
            }

            dgvTax.DataSource = thueDTOs;
        }

        private void cboStateTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            tt = cboStateTax.Text;

            if (tt.Length > 0)
            {
                dsSearch = thueBLL.TraCuThue(thueDTOs, tt);
                dgvTax.DataSource = dsSearch;
            }
        }
    }
}
