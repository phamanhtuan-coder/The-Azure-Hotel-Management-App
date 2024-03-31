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

        public ucRole()
        {
            InitializeComponent();
        }


        private void khoiTaoGiaTrichoForm()
        {

            List<string> trangThaiSort = new List<String>();
            List<string> trangThaiXoa = new List<string>();
          
            trangThaiSort.Add("Tăng dần");
            trangThaiSort.Add("Giảm dần");
            trangThaiSort.Add("Không sắp xếp");

            cboSortSoLuong.DataSource = trangThaiSort;
            cboSortSoLuong.AllowDropDownResize = false;
            cboSortRole.DataSource = trangThaiSort;
            cboSortRole.AllowDropDownResize = false;

            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateRole.DataSource = trangThaiXoa;

            cboStateRole.AllowDropDownResize = false;

            // Random dữ liệu tạm thời cho bảng Role
            Random random = new Random();

            // Clear existing items
            lvwRole.Items.Clear();

            // Add dummy data rows
            for (int i = 0; i < 10; i++)
            {
                // Generate random data
                string maVaiTro = "VT" + (i + 1).ToString("D3");
                string tenVaiTro = "Vai trò " + (i + 1).ToString();
                int soLuongTaiKhoan = random.Next(1, 21); // Số lượng tài khoản từ 1 đến 20
                string moTa = "Mô tả cho vai trò " + tenVaiTro;

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maVaiTro);
                item.SubItems.Add(tenVaiTro);
                item.SubItems.Add(soLuongTaiKhoan.ToString());
                item.SubItems.Add(moTa);

                // Add item to ListView
                lvwRole.Items.Add(item);
            }


            if (lvwRole != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwRole.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwRole.Columns[i].Text, lvwRole.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwRole.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwRole.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwRole.Columns[i].Width = columnWidth;
                }
            }





        }

        
        private void ucRole_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            frmVaiTro frm = new frmVaiTro();
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            

            if (lvwRole.SelectedItems.Count > 0) // sửa dkien
            {
                frmVaiTro frm = new frmVaiTro();
                frm.isAdd = false;
                // Bắt đầu phần có thể chỉnh sửa



                frm.maVaiTro= lvwRole.SelectedItems[0].SubItems[0].Text;
                frm.tenVaiTro = lvwRole.SelectedItems[0].SubItems[1].Text;
                frm.moTa = lvwRole.SelectedItems[0].SubItems[3].Text;



                // kết thúc phần có thể chỉnh sửa
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn dòng thông tin muốn chỉnh sửa");
                thongBao.ShowDialog();

            }
        }
    }
}
