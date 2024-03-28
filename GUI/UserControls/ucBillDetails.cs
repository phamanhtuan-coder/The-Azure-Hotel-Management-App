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
    public partial class ucBillDetails : UserControl
    {

        public ucBillDetails()
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

            // Số lượng dòng dữ liệu bạn muốn tạo
            int numberOfRows = 10;

            // Thêm dữ liệu vào ListView
            for (int i = 1; i <= numberOfRows; i++)
            {
                string maCTHD = "CTHD00" + i;
                string maHD = "HD00" + i;
                string maDP = "DP00" + i;
                string maKM = "KM00" + i;
                string tongTienDV = (100 * i).ToString();
                string tongTienDP = (500 * i).ToString();
                string thanhTien = (600 * i).ToString();
                string trangThai = (i % 2 == 0) ? "Đã thanh toán" : "Chưa thanh toán";

                string[] rowData = { maCTHD, maHD, maDP, maKM, tongTienDV, tongTienDP, thanhTien, trangThai };

                lvwBillDetails.Items.Add(new ListViewItem(rowData));
            }


            if (lvwBillDetails != null && lvwBillDetails.Columns.Count > 6) // Ensure there are enough columns
            {
                // Resize columns based on column content
                lvwBillDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                // Set a minimum width for the column at index 6 ("SoLuongKH")
                int minWidth = TextRenderer.MeasureText(lvwBillDetails.Columns[6].Text, lvwBillDetails.Font).Width;
                lvwBillDetails.Columns[6].Width = Math.Max(minWidth, lvwBillDetails.Columns[6].Width);
            }



        }

        private void ucBillDetails_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
