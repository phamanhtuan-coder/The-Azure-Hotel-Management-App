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
    public partial class ucBooking : UserControl
    {

        public ucBooking()
        {
            InitializeComponent();
        }

        private void ucBooking_Load(object sender, EventArgs e)
        {
           
            
            khoiTaoGiaTrichoForm();
        }

        private void khoiTaoGiaTrichoForm()
        {
            List<string> trangThaiDatPhong= new List<string>();
            List<string> trangThaiSort = new List<String>();
            List<string> trangThaiXoa = new List<string>();

            trangThaiDatPhong.Add("Đã đặt");
            trangThaiDatPhong.Add("Check-in");
            trangThaiDatPhong.Add("Check-out");
            trangThaiDatPhong.Add("Hủy");
            cboStatusBooking.DataSource = trangThaiDatPhong;

            cboStatusBooking.AllowDropDownResize = false;

            trangThaiSort.Add("Tăng dần");
            trangThaiSort.Add("Giảm dần");
            trangThaiSort.Add("Không sắp xếp");
            cboSortBookingID.DataSource = trangThaiSort;

            cboSortBookingID.AllowDropDownResize = false;

            cboSortRoomID.DataSource = trangThaiSort;
            cboSortRoomID.AllowDropDownResize = false;

            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateBooking.DataSource = trangThaiXoa;

            cboStateBooking.AllowDropDownResize = false;


            // Random du liệu tạm thời cho Listview Booking
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                ListViewItem item = new ListViewItem("DP" + random.Next(1000, 9999)); // Random MaDatPhong
                item.SubItems.Add("KH" + random.Next(100, 999)); // Random MaKH
                item.SubItems.Add("PHG" + random.Next(1, 20)); // Random MaPHG
                DateTime startDate = DateTime.Today.AddDays(random.Next(-30, 30)); // Random start date within the last 30 days
                item.SubItems.Add(startDate.ToString("yyyy-MM-dd")); // Random NgayDat
                DateTime checkInDate = startDate.AddDays(random.Next(1, 5)); // Check-in date within 1 to 5 days after NgayDat
                item.SubItems.Add(checkInDate.ToString("yyyy-MM-dd")); // Random CheckIn
                DateTime checkOutDate = checkInDate.AddDays(random.Next(1, 10)); // Check-out date within 1 to 10 days after CheckIn
                item.SubItems.Add(checkOutDate.ToString("yyyy-MM-dd")); // Random CheckOut
                item.SubItems.Add(random.Next(1, 5).ToString()); // Random SoLuongKH
                string[] tinhTrangOptions = { "Đã xác nhận", "Chưa xác nhận", "Đã hủy" };
                item.SubItems.Add(tinhTrangOptions[random.Next(0, tinhTrangOptions.Length)]); // Random TinhTrangDat

                lvwBooking.Items.Add(item); 
            }
            if (lvwBooking != null && lvwBooking.Columns.Count > 6) // Ensure there are enough columns
            {
                // Resize columns based on column content
                lvwBooking.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                // Set a minimum width for the column at index 6 ("SoLuongKH")
                int minWidth = TextRenderer.MeasureText(lvwBooking.Columns[6].Text, lvwBooking.Font).Width;
                lvwBooking.Columns[6].Width = Math.Max(minWidth, lvwBooking.Columns[6].Width);
            }



        }

    }
}
