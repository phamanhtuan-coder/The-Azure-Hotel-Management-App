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
    public partial class ucBill : UserControl
    {

        public ucBill()
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
            cboSortBillID.DataSource = trangThaiSort;

            cboSortBillID.AllowDropDownResize = false;

            cboSortSumBill.DataSource = trangThaiSort;
            cboSortSumBill.AllowDropDownResize = false;

            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateBooking.DataSource = trangThaiXoa;

            cboStateBooking.AllowDropDownResize = false;

            // Clear existing items
            lvwBill.Items.Clear();

            // Add dummy data rows
            for (int i = 0; i < 10; i++)
            {
                // Generate random data
                string maHD = "HD" + (i + 1).ToString("D3");
                string maKhach = "KH" + (i + 1).ToString("D3");
                string maNV = "NV" + (i + 1).ToString("D3");
                string maThue = "TH" + (i + 1).ToString("D3");
                DateTime ngayLapHD = DateTime.Now.AddDays(-i); // Ngày lập hóa đơn từ hôm nay đến 10 ngày trước
                double sum = (i + 1) * 1000000; // Tổng hóa đơn tăng dần từ 1 triệu đến 10 triệu
                double tienNhan = (i + 1) * 500000; // Tiền nhận tăng dần từ 500 nghìn đến 5 triệu
                double tienThoi = tienNhan - sum; // Tiền thối

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maHD);
                item.SubItems.Add(maKhach);
                item.SubItems.Add(maNV);
                item.SubItems.Add(maThue);
                item.SubItems.Add(ngayLapHD.ToShortDateString());
                item.SubItems.Add(sum.ToString("N0")); // Format số nguyên với dấu phẩy ngăn cách hàng nghìn
                item.SubItems.Add(tienNhan.ToString("N0"));
                item.SubItems.Add(tienThoi.ToString("N0"));

                // Add item to ListView
                lvwBill.Items.Add(item);
            }


            if (lvwBill != null && lvwBill.Columns.Count > 6) // Ensure there are enough columns
            {
                // Resize columns based on column content
                lvwBill.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                // Set a minimum width for the column at index 6 ("SoLuongKH")
                int minWidth = TextRenderer.MeasureText(lvwBill.Columns[6].Text, lvwBill.Font).Width;
                lvwBill.Columns[6].Width = Math.Max(minWidth, lvwBill.Columns[6].Width);
            }



        }

        private void ucBill_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
