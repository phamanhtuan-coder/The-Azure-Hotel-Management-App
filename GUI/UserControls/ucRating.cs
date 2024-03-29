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
    public partial class ucRating : UserControl
    {

        public ucRating()
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

            cboRatingValue.DataSource = trangThaiSort;
            cboRatingValue.AllowDropDownResize = false;
            cboSortRatingID.DataSource = trangThaiSort;
            cboSortRatingID.AllowDropDownResize = false;


            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateRating.DataSource = trangThaiXoa;

            cboStateRating.AllowDropDownResize = false;

            // Tạo dữ liệu giả mạo cho ListView
            Random random = new Random();
            string[] danhGia = { "Rất tốt", "Tốt", "Bình thường", "Kém", "Rất kém" };

            for (int i = 1; i <= 10; i++)
            {
                string maDanhGia = "DG" + i.ToString("000");
                string maDatPhong = "DP" + random.Next(1, 100).ToString("000");
                int diemDanhGia = random.Next(1, 6);
                string noiDungDanhGia = danhGia[random.Next(danhGia.Length)];
                DateTime ngayDanhGia = DateTime.Today.AddDays(-random.Next(1, 30));

                ListViewItem item = new ListViewItem(maDanhGia);
                item.SubItems.Add(maDatPhong);
                item.SubItems.Add(diemDanhGia.ToString());
                item.SubItems.Add(noiDungDanhGia);
                item.SubItems.Add(ngayDanhGia.ToString("dd/MM/yyyy"));

                lvwRating.Items.Add(item);
            }




            if (lvwRating != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwRating.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwRating.Columns[i].Text, lvwRating.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwRating.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwRating.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwRating.Columns[i].Width = columnWidth;
                }
            }





        }

    

        private void ucRating_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
