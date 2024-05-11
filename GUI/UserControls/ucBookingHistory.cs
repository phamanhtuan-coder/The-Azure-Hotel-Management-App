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
    public partial class ucBookingHistory : UserControl
    {
        public customMessageBox thongBao;
        public frmDatPhong frm = new frmDatPhong();

        public ucBookingHistory()
        {
            InitializeComponent();
        }

        private frmMain _parentForm;

        public ucBookingHistory(frmMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }


        private void ucBooking_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookingHistory.SelectedRows.Count > 0)
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

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookingHistory.SelectedRows.Count > 0)
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

        private void btnRecoverBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookingHistory.SelectedRows.Count > 0)
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain parentForm = this.ParentForm as frmMain;
            ucPersonal ucPersonal = new ucPersonal(parentForm);
            ucPersonal.user = parentForm.user;
            ucPersonal.userKH = parentForm.userKH;
            parentForm.SwitchUserControl(ucPersonal);
            this.Dispose();
        }
    }
}
