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
    public partial class ucStaff : UserControl
    {

        public ucStaff()
        {
            InitializeComponent();
        }

        private void ucStaff_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)//  Sửa điều kiện đoạn này
            {
                frmNhanVien frm = new frmNhanVien();
                frm.isAdd = false;
                //Bắt đầu sửa từ đoạn này
               
                frm.anhDaiDien = null;

                //Kết thúc đoạn được sửa
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
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

        private void btnRecoverStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
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
