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
    public partial class ucRoomStatus : UserControl
    {

        public ucRoomStatus()
        {
            InitializeComponent();
        }


        private void khoiTaoGiaTrichoForm()
        {
            List<string> tinhTrangPhong = new List<string>();
            List<string> trangThaiSort = new List<String>();
            List<string> trangThaiXoa = new List<string>();


            tinhTrangPhong.Add("Trống");
            tinhTrangPhong.Add("Đã đặt");
            tinhTrangPhong.Add("Đang ở");
            tinhTrangPhong.Add("Đang dọn dẹp");
            tinhTrangPhong.Add("Bảo trì");
            tinhTrangPhong.Add("Khóa");
            



            trangThaiSort.Add("Tăng dần");
            trangThaiSort.Add("Giảm dần");
            trangThaiSort.Add("Không sắp xếp");

            cboSortRoomStatusID.DataSource = trangThaiSort;
            cboSortRoomStatusID.AllowDropDownResize = false;

            cboSortSoLuongRoom.DataSource = trangThaiSort;
            cboSortSoLuongRoom.AllowDropDownResize = false;


            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateRoomStatus.DataSource = trangThaiXoa;

            cboStateRoomStatus.AllowDropDownResize = false;


            // Random dữ liệu tạm thời cho bảng Room Status
            Random random = new Random();

            // Clear existing items
            lvwRoomStatus.Items.Clear();

            // Add dummy data rows
            for (int i = 0; i < tinhTrangPhong.Count; i++)
            {
                // Generate random data
                string maTrangThai = "RT" + (i + 1).ToString("D3");
                string tenTrangThai = tinhTrangPhong[i];
                int soLuongPhong = random.Next(0, 21); // Số lượng phòng từ 0 đến 20
                string moTa = "Mô tả cho trạng thái " + tenTrangThai;

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maTrangThai);
                item.SubItems.Add(tenTrangThai);
                item.SubItems.Add(soLuongPhong.ToString());
                item.SubItems.Add(moTa);

                // Add item to ListView
                lvwRoomStatus.Items.Add(item);
            }



            if (lvwRoomStatus != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwRoomStatus.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwRoomStatus.Columns[i].Text, lvwRoomStatus.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwRoomStatus.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwRoomStatus.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwRoomStatus.Columns[i].Width = columnWidth;
                }
            }





        }

        private void ucRoomStatus_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
