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

        public ucAccountType()
        {
            InitializeComponent();
        }

        private void ucAccountType_Load(object sender, EventArgs e)
        {
         
        }

        private void btnAddAccountType_Click(object sender, EventArgs e)
        {
            frmPhanQuyen frm = new frmPhanQuyen();
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditAccountType_Click(object sender, EventArgs e)
        {
            if (dgvAccountType.SelectedRows.Count > 0)
            {
                frmPhanQuyen frm = new frmPhanQuyen();
                frm.isAdd = false;

               

                //kết thúc sửa 
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }

           
        }

        private void btnDeleteAccountType_Click(object sender, EventArgs e)
        {
            if (dgvAccountType.SelectedRows.Count > 0)
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

        private void btnRecoverAccountType_Click(object sender, EventArgs e)
        {
            if (dgvAccountType.SelectedRows.Count > 0)
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
