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
    public partial class ucAccounts : UserControl
    {

        public ucAccounts()
        {
            InitializeComponent();
        }


        private void khoiTaoGiaTrichoForm()
        {
            List<string> phanQuyen = new List<string>();


            List<string> trangThaiSort = new List<String>();
            List<string> trangThaiXoa = new List<string>();

            phanQuyen.Add("KH-00");
            phanQuyen.Add("AD-00");
            phanQuyen.Add("LT-01");
            phanQuyen.Add("LT-02");
            cboPhanQuyen.DataSource = phanQuyen;
            cboPhanQuyen.AllowDropDownResize = false;


            trangThaiSort.Add("Tăng dần");
            trangThaiSort.Add("Giảm dần");
            trangThaiSort.Add("Không sắp xếp");


            cboSortAccountsID.DataSource = trangThaiSort;
            cboSortAccountsID.AllowDropDownResize = false;


            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateAccounts.DataSource = trangThaiXoa;

            cboStateAccounts.AllowDropDownResize = false;


            // Random dữ liệu tạm thời cho bảng Accounts
            Random random = new Random();

            // Clear existing items
            lvwAccounts.Items.Clear();

            // Add dummy data rows
            for (int i = 0; i < 10; i++)
            {
                // Generate random data
                string maTaiKhoan = "TK" + (i + 1).ToString("D3");
                string username = "User" + (i + 1).ToString();
                string maPhanQuyen = phanQuyen[random.Next(phanQuyen.Count)]; // Chọn ngẫu nhiên một mã phân quyền từ danh sách

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maTaiKhoan);
                item.SubItems.Add(username);
                item.SubItems.Add(maPhanQuyen);

                // Add item to ListView
                lvwAccounts.Items.Add(item);
            }






            if (lvwAccounts != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwAccounts.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwAccounts.Columns[i].Text, lvwAccounts.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwAccounts.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwAccounts.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwAccounts.Columns[i].Width = columnWidth;
                }
            }





        }

      

        private void ucAccounts_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
