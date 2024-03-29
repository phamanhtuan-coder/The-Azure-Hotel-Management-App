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
    public partial class ucDeviceStatus : UserControl
    {

        public ucDeviceStatus()
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

            cboSortDeviceStatusID.DataSource = trangThaiSort;
            cboSortDeviceStatusID.AllowDropDownResize = false;
            cboSortSoLuongTB.DataSource = trangThaiSort;
            cboSortSoLuongTB.AllowDropDownResize = false;

            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateDeviceStatus.DataSource = trangThaiXoa;

            cboStateDeviceStatus.AllowDropDownResize = false;


            // Tạo dữ liệu giả mạo cho ListView
            string[] deviceStatusIds = { "TS001", "TS002", "TS003" };
            string[] statusNames = { "Good", "Fair", "Poor" };
            int[] numberOfDevices = { 10, 5, 3 };
            string[] descriptions = { "All devices are functioning well.", "Some devices need maintenance.", "Several devices are not working properly." };

            for (int i = 0; i < deviceStatusIds.Length; i++)
            {
                ListViewItem item = new ListViewItem(deviceStatusIds[i]);
                item.SubItems.Add(statusNames[i]);
                item.SubItems.Add(numberOfDevices[i].ToString());
                item.SubItems.Add(descriptions[i]);
                lvwDeviceStatus.Items.Add(item);
            }





            if (lvwDeviceStatus != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwDeviceStatus.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwDeviceStatus.Columns[i].Text, lvwDeviceStatus.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwDeviceStatus.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwDeviceStatus.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwDeviceStatus.Columns[i].Width = columnWidth;
                }
            }





        }


        private void ucDeviceStatus_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
