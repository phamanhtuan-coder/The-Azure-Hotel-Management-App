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
    public partial class ucServiceType : UserControl
    {

        public ucServiceType()
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

            cboSortGiaServiceType.DataSource = trangThaiSort;
            cboSortGiaServiceType.AllowDropDownResize = false;
            cboSortServiceTypeID.DataSource = trangThaiSort;
            cboSortServiceTypeID.AllowDropDownResize = false;

            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateRoomType.DataSource = trangThaiXoa;

            cboStateRoomType.AllowDropDownResize = false;

            // Random dữ liệu tạm thời cho bảng Service Type
            Random random = new Random();

            // Clear existing items
            lvwServiceType.Items.Clear();

            // Add 10 dummy data rows
            for (int i = 0; i < 10; i++)
            {
                // Generate random data
                string maLoaiDV = "DV" + (i + 1).ToString("D3");
                string tenDV = "Dịch vụ " + (i + 1);
                int gia = random.Next(50000, 1000000); // Giá từ 50,000 VND đến 1,000,000 VND
                string moTa = "Mô tả cho dịch vụ " + maLoaiDV;

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maLoaiDV);
                item.SubItems.Add(tenDV);
                item.SubItems.Add(gia.ToString());
                item.SubItems.Add(moTa);

                // Add item to ListView
                lvwServiceType.Items.Add(item);
            }


            if (lvwServiceType != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwServiceType.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwServiceType.Columns[i].Text, lvwServiceType.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwServiceType.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwServiceType.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwServiceType.Columns[i].Width = columnWidth;
                }
            }





        }

        private void ucServiceType_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
