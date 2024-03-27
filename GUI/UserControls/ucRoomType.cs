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
    public partial class ucRoomType : UserControl
    {

        public ucRoomType()
        {
            InitializeComponent();
        }


        private void khoiTaoGiaTrichoForm()
        {
            List<string> loaiPhong = new List<string>();
            List<string> trangThaiSort = new List<String>();
            List<string> trangThaiXoa = new List<string>();
          

            loaiPhong.Add("Phòng đơn");
            loaiPhong.Add("Phòng hai");
            loaiPhong.Add("Phòng ba");
            loaiPhong.Add("Couple");
            loaiPhong.Add("Hai Couple");
            loaiPhong.Add("Gia đình");
            loaiPhong.Add("Đại gia dình");
            loaiPhong.Add("Suite");
            loaiPhong.Add("Deluxe");
            loaiPhong.Add("Luxury");
            loaiPhong.Add("President");
            loaiPhong.Add("VIP");

            cboSortRoomTypeID.DataSource = loaiPhong;
            cboSortRoomTypeID.AllowDropDownResize = false;

            trangThaiSort.Add("Tăng dần");
            trangThaiSort.Add("Giảm dần");
            trangThaiSort.Add("Không sắp xếp");

            cboSortSoLuongRoom.DataSource = trangThaiSort;
            cboSortSoLuongRoom.AllowDropDownResize = false;

            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateRoomType.DataSource = trangThaiXoa;

            cboStateRoomType.AllowDropDownResize = false;


            // Random dữ liệu tạm thời cho ListView Room Type
            Random random = new Random();

            // Clear existing items
            lvwRoomType.Items.Clear();

            // Add 10 dummy data rows
            for (int i = 0; i < 10; i++)
            {
                // Generate random data
                string maLoaiPhong = "LP" + (i + 1).ToString("D3");
                string tenLoaiPhong = loaiPhong[random.Next(loaiPhong.Count)];
                int soLuongPhong = random.Next(1, 11); // Số lượng phòng từ 1 đến 10
                string moTaPhong = "Mô tả loại phòng " + maLoaiPhong;

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maLoaiPhong);
                item.SubItems.Add(tenLoaiPhong);
                item.SubItems.Add(soLuongPhong.ToString());
                item.SubItems.Add(moTaPhong);

                // Add item to ListView
                lvwRoomType.Items.Add(item);
            }


            if (lvwRoomType != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwRoomType.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwRoomType.Columns[i].Text, lvwRoomType.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwRoomType.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwRoomType.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwRoomType.Columns[i].Width = columnWidth;
                }
            }





        }

        private void ucRoomType_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
