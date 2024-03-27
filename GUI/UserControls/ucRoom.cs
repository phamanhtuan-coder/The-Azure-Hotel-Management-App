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
    public partial class ucRoom : UserControl
    {

        public ucRoom()
        {
            InitializeComponent();
        }


        private void khoiTaoGiaTrichoForm()
        {
            List<string> trangThaiPhong= new List<string>();
            List<string> loaiPhong = new List<string>();
            List<string> trangThaiSort = new List<String>();
            List<string> trangThaiXoa = new List<string>();
           

            trangThaiPhong.Add("Occupied");
            trangThaiPhong.Add("Trống");
            trangThaiPhong.Add("Reserved");
            trangThaiPhong.Add("DV Dọn phòng");
            trangThaiPhong.Add("Check-out");
            trangThaiPhong.Add("Đang sửa chữa");
            trangThaiPhong.Add("Đang vệ sinh");

            cboRoomStatus.DataSource = trangThaiPhong;
            cboRoomStatus.AllowDropDownResize = false;

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

            cboSortRoomType.DataSource = loaiPhong;
            cboSortRoomType.AllowDropDownResize = false;

            trangThaiSort.Add("Tăng dần");
            trangThaiSort.Add("Giảm dần");
            trangThaiSort.Add("Không sắp xếp");
 
            cboSortPrice.DataSource = trangThaiSort;
            cboSortPrice.AllowDropDownResize = false;

            cboSortRoomID.DataSource = trangThaiSort;
            cboSortRoomID.AllowDropDownResize = false;

            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateRoom.DataSource = trangThaiXoa;

            cboStateRoom.AllowDropDownResize = false;


            // Random du liệu tạm thời cho Listview Room
            Random random = new Random();

            // Clear existing items
            lvwRoom.Items.Clear();

            // Add 10 dummy data rows
            for (int i = 0; i < 10; i++)
            {
                // Generate random data
                string maPhong = "PH" + (i + 1).ToString("D3");
                string loai = loaiPhong[random.Next(loaiPhong.Count)];
                int sucChuaToiDa = random.Next(1, 13); // Số người tối đa từ 1 đến 12
                int gia = (random.Next(19) + 1) * 500000; // Giá từ 500,000 VND đến 10,000,000 VND (tăng theo khoảng cách 500,000 VND)
                string maDSTB = "DSTB" + (i + 1).ToString("D3");
                string moTa = "Mô tả phòng " + maPhong;
                string tinhTrangPhong = trangThaiPhong[random.Next(trangThaiPhong.Count)];

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maPhong);
                item.SubItems.Add(loai);
                item.SubItems.Add(sucChuaToiDa.ToString());
                item.SubItems.Add(gia.ToString("C0")); // Format gia as currency
                item.SubItems.Add(maDSTB);
                item.SubItems.Add(moTa);
                item.SubItems.Add(tinhTrangPhong);

                // Add item to ListView
                lvwRoom.Items.Add(item);
            }

            if (lvwRoom != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwRoom.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwRoom.Columns[i].Text, lvwRoom.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwRoom.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwRoom.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwRoom.Columns[i].Width = columnWidth;
                }
            }





        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
