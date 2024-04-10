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
    public partial class ucRole : UserControl
    {
        frmPhanQuyen frm = new frmPhanQuyen();
        customMessageBox thongBao;
        public ucRole()
        {
            InitializeComponent();
        }


        private void ucRole_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
           
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {


            if (dgvRole.SelectedRows.Count > 0)
            {
                
                frm.isAdd = false;
                // Bắt đầu phần có thể chỉnh sửa




                // kết thúc phần có thể chỉnh sửa
                frm.ShowDialog();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();

            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            if (dgvRole.SelectedRows.Count > 0)
            {

                thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    //xóa
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private void btnRecoverRole_Click(object sender, EventArgs e)
        {
            if (dgvRole.SelectedRows.Count > 0)
            {

                thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    //Khôi phục
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phúc!");
                thongBao.ShowDialog();
            }
        }
    }
}
