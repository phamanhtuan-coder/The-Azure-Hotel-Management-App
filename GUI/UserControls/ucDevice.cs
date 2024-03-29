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
    public partial class ucDevice : UserControl
    {

        public ucDevice()
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

            cboSortDeviceID.DataSource = trangThaiSort;
            cboSortDeviceID.AllowDropDownResize = false;
       
            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateDeviceStatus.DataSource = trangThaiXoa;

            cboStateDeviceStatus.AllowDropDownResize = false;

            // Tạo dữ liệu giả mạo cho ListView
            string[] deviceIds = { "DV001", "DV002", "DV003", "DV004", "DV005", "DV006", "DV007", "DV008", "DV009", "DV010" };
            string[] deviceNames = { "Laptop", "Printer", "Projector", "Scanner", "Monitor", "Keyboard", "Mouse", "Speaker", "Microphone", "Router" };
            string[] deviceStatuses = { "Working", "Maintenance Required", "Out of Order", "Working", "Working", "Working", "Maintenance Required", "Working", "Out of Order", "Working" };
            string[] deviceDescriptions = { "Fully functional laptop.", "Printer needs maintenance.", "Projector is not working.", "Scanner is operational.", "Monitor is in good condition.", "Keyboard is functional.", "Mouse needs maintenance.", "Speakers are working.", "Microphone is out of order.", "Router is operational." };

            for (int i = 0; i < deviceIds.Length; i++)
            {
                ListViewItem item = new ListViewItem(deviceIds[i]);
                item.SubItems.Add(deviceNames[i]);
                item.SubItems.Add(deviceStatuses[i]);
                item.SubItems.Add(deviceDescriptions[i]);
                lvwDevice.Items.Add(item);
            }



            if (lvwDevice != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwDevice.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwDevice.Columns[i].Text, lvwDevice.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwDevice.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwDevice.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwDevice.Columns[i].Width = columnWidth;
                }
            }





        }


  

        private void ucDevice_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
