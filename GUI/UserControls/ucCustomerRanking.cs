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
    public partial class ucCustomerRanking : UserControl
    {

        public ucCustomerRanking()
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
            cboSortCustomerRankingID.DataSource = trangThaiSort;
            cboSortCustomerRankingID.AllowDropDownResize = false;
            cboSortSoLuongKH.DataSource = trangThaiSort;
            cboSortSoLuongKH.AllowDropDownResize = false;

            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateCustomerRanking.DataSource = trangThaiXoa;

            cboStateCustomerRanking.AllowDropDownResize = false;


            // Clear existing items
            lvwCustomerRanking.Items.Clear();

            // Add dummy data rows
            for (int i = 0; i < 10; i++)
            {
                // Generate random data
                string maRank = "HR" + (i + 1).ToString("D3");
                string tenRank = "Rank " + (i + 1).ToString();
                int soLuongTV = (i + 1) * 10; // Số lượng thành viên tăng dần từ 10 đến 50
                double mucGiam = (i + 1) * 0.5; // Mức giảm tăng dần từ 0.5 đến 2.5

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maRank);
                item.SubItems.Add(tenRank);
                item.SubItems.Add(soLuongTV.ToString());
                item.SubItems.Add(mucGiam.ToString("0.00") + "%");

                // Add item to ListView
                lvwCustomerRanking.Items.Add(item);
            }



            if (lvwCustomerRanking != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwCustomerRanking.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwCustomerRanking.Columns[i].Text, lvwCustomerRanking.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwCustomerRanking.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwCustomerRanking.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwCustomerRanking.Columns[i].Width = columnWidth;
                }
            }





        }

        private void ucCustomerRanking_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
