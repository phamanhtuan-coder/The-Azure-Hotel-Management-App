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


        private void khoiTaoGiaTrichoForm()
        {
          


            List<string> trangThaiSort = new List<String>();
            List<string> trangThaiXoa = new List<string>();


            trangThaiSort.Add("Tăng dần");
            trangThaiSort.Add("Giảm dần");
            trangThaiSort.Add("Không sắp xếp");
            

            cboSortCustomerID.DataSource = trangThaiSort;
            cboSortCustomerID.AllowDropDownResize = false;


            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateAccounts.DataSource = trangThaiXoa;

            cboStateAccounts.AllowDropDownResize = false;

            // Clear existing items
            lvwCustomer.Items.Clear();

            // Add dummy data rows
            for (int i = 0; i < 10; i++)
            {
                // Generate random data
                string maNV = "NV" + (i + 1).ToString("D3");
                string maAccount = "AC" + (i + 1).ToString("D3");
                string hoTen = "Người dùng " + (i + 1).ToString();
                string gioiTinh = (i % 2 == 0) ? "Nam" : "Nữ";
                DateTime ngaySinh = DateTime.Now.AddYears(-25).AddDays(i); // Random ngày sinh trong khoảng 25 năm trước
                string cccd = "CCCD " + (i + 1).ToString("D8");
                string diaChi = "Địa chỉ " + (i + 1).ToString();
                string email = "email" + (i + 1).ToString() + "@example.com";
                string sdt = "012345678" + (i + 1).ToString(); // Số điện thoại tăng dần từ 0123456781 đến 0123456780

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maNV);
                item.SubItems.Add(maAccount);
                item.SubItems.Add(hoTen);
                item.SubItems.Add(gioiTinh);
                item.SubItems.Add(ngaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(cccd);
                item.SubItems.Add(diaChi);
                item.SubItems.Add(email);
                item.SubItems.Add(sdt);

                // Add item to ListView
                lvwCustomer.Items.Add(item);
            }


            if (lvwCustomer != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwCustomer.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwCustomer.Columns[i].Text, lvwCustomer.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwCustomer.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwCustomer.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwCustomer.Columns[i].Width = columnWidth;
                }
            }





        }

      

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (lvwCustomer.SelectedItems.Count > 0)
            {
                frmKhachHang frm = new frmKhachHang();
                frm.isAdd = false;
                //Bắt đầu đoạn có thể chỉnh sửa


                //Kết thúc đoạn có thể chỉnh sửa
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Vui lòng chọn một dòng dữ liệu để chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }
    }
}
