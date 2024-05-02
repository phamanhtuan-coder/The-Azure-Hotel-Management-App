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
    public partial class ucBillDetails : UserControl
    {
        frmCTHD frm = new frmCTHD();
        customMessageBox thongBao;
        public ucBillDetails()
        {
            InitializeComponent();
        }

        private void ucBillDetails_Load(object sender, EventArgs e)
        {
            LoadDuLieuCombobox();
        }

        private void LoadDuLieuCombobox()
        {
            DuLieuChoComboBox.duLieuSort(cboSortBillID);
            DuLieuChoComboBox.duLieuSort(cboSortSumBill);
            DuLieuChoComboBox.duLieuFilter(cboStateBooking);
        }

        private void btnAddBillDetails_Click(object sender, EventArgs e)
        {
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditBillDetails_Click(object sender, EventArgs e)
        {

            if (dgvBillDetails.SelectedRows.Count > 0)
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

        private void btnDeleteBillDetails_Click(object sender, EventArgs e)
        {
            if (dgvBillDetails.SelectedRows.Count > 0)
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

        private void btnRecoverBillDetails_Click(object sender, EventArgs e)
        {

            if (dgvBillDetails.SelectedRows.Count > 0)
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
