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
    public partial class ucDiscount : UserControl
    {

        public ucDiscount()
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

            cboSortDiscountValue.DataSource = trangThaiSort;
            cboSortDiscountValue.AllowDropDownResize = false;
            cboSortDiscountID.DataSource = trangThaiSort;
            cboSortDiscountID.AllowDropDownResize = false;


            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateDiscount.DataSource = trangThaiXoa;

            cboStateDiscount.AllowDropDownResize = false;

            // Clear existing items
            lvwDiscount.Items.Clear();

            // Add dummy data rows
            for (int i = 0; i < 10; i++)
            {
                // Generate random data
                string maKM = "KM" + (i + 1).ToString("D3");
                string tenKM = "Khuyến mãi " + (i + 1).ToString();
                double mucKM = (i + 1) * 5.0; // Mức giảm giá tăng dần từ 5 đến 50%
                string moTa = "Mô tả khuyến mãi " + (i + 1).ToString();
                string hangTV = "Hạng thành viên " + (i + 1).ToString();

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maKM);
                item.SubItems.Add(tenKM);
                item.SubItems.Add(mucKM.ToString() + "%");
                item.SubItems.Add(moTa);
                item.SubItems.Add(hangTV);

                // Add item to ListView
                lvwDiscount.Items.Add(item);
            }


            if (lvwDiscount != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwDiscount.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwDiscount.Columns[i].Text, lvwDiscount.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwDiscount.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwDiscount.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwDiscount.Columns[i].Width = columnWidth;
                }
            }





        }

        private void ucDiscount_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
