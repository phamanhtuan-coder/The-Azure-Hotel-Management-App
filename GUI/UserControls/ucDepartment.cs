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
using GUI.customForm;

namespace GUI.UserControls
{
    public partial class ucDepartment : UserControl
    {

        public ucDepartment()
        {
            InitializeComponent();
        }


        private void ucDepartment_Load(object sender, EventArgs e)
        {

           
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            frmPhongBan frm = new frmPhongBan();
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            // bổ sung kiểm tra dòng có đang được chọn chưa, nếu có dòng được chọn thì tiến hành xử lý, nếu không thì thông báo lỗi
            if (dgvDepartment.SelectedRows.Count > 0)
            {
                frmPhongBan frm = new frmPhongBan();
                frm.isAdd = false;
                //Bắt đầu sửa từ đoạn này



                //Kết thúc sửa từ đoạn này
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn 1 dòng dữ liệu bạn muốn thay đổi!");
                thongBao.ShowDialog();
            }
           
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.SelectedRows.Count > 0)
            {
                customMessageBox thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    //xóa
                }
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private void btnRecoverDepartment_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.SelectedRows.Count > 0)
            {
                customMessageBox thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    //Khôi phục
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
