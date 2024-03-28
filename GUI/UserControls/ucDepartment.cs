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
    public partial class ucDepartment : UserControl
    {

        public ucDepartment()
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

            cboSortSoLuongNV.DataSource = trangThaiSort;
            cboSortSoLuongNV.AllowDropDownResize = false;
            cboSortDepartment.DataSource = trangThaiSort;
            cboSortDepartment.AllowDropDownResize = false;

            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateDepartment.DataSource = trangThaiXoa;

            cboStateDepartment.AllowDropDownResize = false;

            // Random dữ liệu tạm thời cho bảng Department
            Random random = new Random();

            // Clear existing items
            lvwDepartment.Items.Clear();

            // Add dummy data rows
            for (int i = 0; i < 10; i++)
            {
                // Generate random data
                string maPhongBan = "PB" + (i + 1).ToString("D3");
                string tenPhongBan = "Phòng ban " + (i + 1).ToString();
                int soLuongNhanVien = random.Next(1, 51); // Số lượng nhân viên từ 1 đến 50
                string moTa = "Mô tả cho phòng ban " + tenPhongBan;
                string truongPhong = "Người đứng đầu " + tenPhongBan;
                DateTime ngayNhanChuc = DateTime.Now.Date.AddDays(-random.Next(365)); // Ngẫu nhiên từ hôm nay trở về 1 năm trước

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maPhongBan);
                item.SubItems.Add(tenPhongBan);
                item.SubItems.Add(soLuongNhanVien.ToString());
                item.SubItems.Add(moTa);
                item.SubItems.Add(truongPhong);
                item.SubItems.Add(ngayNhanChuc.ToString("dd/MM/yyyy"));

                // Add item to ListView
                lvwDepartment.Items.Add(item);
            }


            if (lvwDepartment != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwDepartment.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwDepartment.Columns[i].Text, lvwDepartment.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwDepartment.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwDepartment.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwDepartment.Columns[i].Width = columnWidth;
                }
            }





        }

        


        private void ucDepartment_Load(object sender, EventArgs e)
        {

            khoiTaoGiaTrichoForm();
        }
    }
}
