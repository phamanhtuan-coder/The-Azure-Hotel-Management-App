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
    public partial class ucDeviceStatus : UserControl
    {

        public ucDeviceStatus()
        {
            InitializeComponent();
        }

        private void ucDeviceStatus_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAddDeviceStatus_Click(object sender, EventArgs e)
        {
            frmTinhTrangTB frm = new frmTinhTrangTB();
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditDeviceStatus_Click(object sender, EventArgs e)
        {
            // bổ sung kiểm tra dòng có đang được chọn chưa, nếu có dòng được chọn thì tiến hành xử lý, nếu không thì thông báo lỗi
            if (dgvDeviceStatus.SelectedRows.Count > 0)
            {
                frmTinhTrangTB frm = new frmTinhTrangTB();
                frm.isAdd = false;
                //Bắt đầu sửa từ đoạn này

               


                //Kết thúc sửa từ đoạn này
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteDeviceStatus_Click(object sender, EventArgs e)
        {
            if (dgvDeviceStatus.SelectedRows.Count > 0)
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

        private void btnRecoverDeviceStatus_Click(object sender, EventArgs e)
        {
            if (dgvDeviceStatus.SelectedRows.Count > 0)
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
