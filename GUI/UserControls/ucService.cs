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
    public partial class ucService : UserControl
    {

        public ucService()
        {
            InitializeComponent();
        }


        private void khoiTaoGiaTrichoForm()
        {
         
            List<string> trangThaiSort = new List<String>();
            List<string> trangThaiXoa = new List<string>();
            List<string> loaiDichVu = new List<String>();

            trangThaiSort.Add("Tăng dần");
            trangThaiSort.Add("Giảm dần");
            trangThaiSort.Add("Không sắp xếp");
            cboSortServiceD.DataSource = trangThaiSort;
            cboSortServiceD.AllowDropDownResize = false;

            cboSortBookingID.DataSource = trangThaiSort;
            cboSortBookingID.AllowDropDownResize = false;

            cboSortThanhTien.DataSource = trangThaiSort;
            cboSortThanhTien.AllowDropDownResize = false;


            loaiDichVu.Add("Dọn phòng");
            loaiDichVu.Add("Giặt ủi");
            loaiDichVu.Add("Nước ngọt");
            loaiDichVu.Add("Ăn sáng");
            loaiDichVu.Add("Bia");
            loaiDichVu.Add("Ăn trưa");
            loaiDichVu.Add("Ăn tối");


            cboSortServiceType.DataSource = loaiDichVu;
            cboSortServiceType.AllowDropDownResize = false;

            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateService.DataSource = trangThaiXoa;

            cboStateService.AllowDropDownResize = false;

            // Random dữ liệu tạm thời cho bảng Service
            Random random = new Random();

            // Clear existing items
            lvwService.Items.Clear();

            // Add 10 dummy data rows
            for (int i = 0; i < 10; i++)
            {
                // Generate random data
                string maDatDV = "DVDV" + (i + 1).ToString("D3");
                string maDatPhong = "DP" + (i + 1).ToString("D3");
                string maPHG = "PHG" + (i + 1).ToString("D3");
                string ngayDat = DateTime.Now.AddDays(-i).ToString("dd/MM/yyyy");
                int soLuong = random.Next(1, 5); // Số lượng từ 1 đến 4
                int donGia = random.Next(10000, 500000); // Giá từ 10,000 VND đến 500,000 VND
                int thanhTien = soLuong * donGia;

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maDatDV);
                item.SubItems.Add(maDatPhong);
                item.SubItems.Add(maPHG);
                item.SubItems.Add(ngayDat);
                item.SubItems.Add(soLuong.ToString());
                item.SubItems.Add(donGia.ToString());
                item.SubItems.Add(thanhTien.ToString());

                // Add item to ListView
                lvwService.Items.Add(item);
            }




            if (lvwService != null && lvwService.Columns.Count > 6) // Ensure there are enough columns
            {
                // Resize columns based on column content
                lvwService.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                // Set a minimum width for the column at index 6 ("SoLuongKH")
                int minWidth = TextRenderer.MeasureText(lvwService.Columns[6].Text, lvwService.Font).Width;
                lvwService.Columns[6].Width = Math.Max(minWidth, lvwService.Columns[6].Width);
            }



        }

        private void ucService_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }

        private void btnServiceType_Click(object sender, EventArgs e)
        {

        }
    }
}
