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
    public partial class ucTax : UserControl
    {

        public ucTax()
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

            cboSortTaxValue.DataSource = trangThaiSort;
            cboSortTaxValue.AllowDropDownResize = false;
            cboSortTaxID.DataSource = trangThaiSort;
            cboSortTaxID.AllowDropDownResize = false;


            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateTax.DataSource = trangThaiXoa;

            cboStateTax.AllowDropDownResize = false;

            // Random dữ liệu tạm thời cho bảng Tax
            Random random = new Random();

            // Clear existing items
            lvwTax.Items.Clear();

            // Add dummy data rows
            for (int i = 0; i < 10; i++)
            {
                // Generate random data
                string maThue = "T" + (i + 1).ToString("D3");
                string tenThue = "Thuế " + (i + 1).ToString();
                double mucThue = random.NextDouble() * 10; // Mức thuế từ 0 đến 10%
                string moTa = "Mô tả cho thuế " + tenThue;

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maThue);
                item.SubItems.Add(tenThue);
                item.SubItems.Add(mucThue.ToString("0.##") + "%"); // Format mức thuế thành phần trăm
                item.SubItems.Add(moTa);

                // Add item to ListView
                lvwTax.Items.Add(item);
            }



            if (lvwTax != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwTax.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwTax.Columns[i].Text, lvwTax.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwTax.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwTax.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwTax.Columns[i].Width = columnWidth;
                }
            }





        }

     
        private void ucTax_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
