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
    public partial class ucCustomer : UserControl
    {

        public ucCustomer()
        {
            InitializeComponent();
        }

        private void ucCustomer_Load(object sender, EventArgs e)
        {
         
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                frmKhachHang frm = new frmKhachHang();
                frm.isAdd = false;
                //Bắt đầu đoạn có thể chỉnh sửa


                //Kết thúc đoạn có thể chỉnh sửa
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
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

        private void btnRecoverCustomer_Click(object sender, EventArgs e)
        {

            if (dgvCustomer.SelectedRows.Count > 0)
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
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }
    }
}
