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
    public partial class ucCustomerRanking : UserControl
    {

        public ucCustomerRanking()
        {
            InitializeComponent();
        }

        private void ucCustomerRanking_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddCustomerRanking_Click(object sender, EventArgs e)
        {
            frmHangThanhVien frm = new frmHangThanhVien();
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditCustomerRanking_Click(object sender, EventArgs e)
        {
            if (dgvCustomerRank.SelectedRows.Count > 0)
            {
                frmHangThanhVien frm = new frmHangThanhVien();
                frm.isAdd = false;
                //Batdau doan co the chinh sua
               

                //ket thuc doan co the chinh sua
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
           
        }

        private void btnDeleteCustomerRanking_Click(object sender, EventArgs e)
        {
            if (dgvCustomerRank.SelectedRows.Count > 0)
            {
                customMessageBox thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    // Xóa 
                }
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private void btnRecoverCustomerRanking_Click(object sender, EventArgs e)
        {

            if (dgvCustomerRank.SelectedRows.Count > 0)
            {
                customMessageBox thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    // Khôi phục
                }
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phúc!");
                thongBao.ShowDialog();
            }
        }
    }
}
