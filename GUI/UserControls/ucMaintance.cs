﻿using Syncfusion.WinForms.ListView;
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
    public partial class ucMaintance : UserControl
    {

        public ucMaintance()
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
 
            cboSortMaintanceID.DataSource = trangThaiSort;
            cboSortMaintanceID.AllowDropDownResize = false;

            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateMaintance.DataSource = trangThaiXoa;

            cboStateMaintance.AllowDropDownResize = false;


            // Tạo dữ liệu giả mạo cho ListView
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                string maDonPhong = "DP" + i.ToString("000");
                string maPhong = "PH" + random.Next(1, 100).ToString("000");
                string maNhanVien = "NV" + random.Next(1, 50).ToString("000");
                DateTime ngayNhan = DateTime.Today.AddDays(-random.Next(1, 30));
                DateTime ngayHoanThanh = ngayNhan.AddDays(random.Next(1, 10));

                ListViewItem item = new ListViewItem(maDonPhong);
                item.SubItems.Add(maPhong);
                item.SubItems.Add(maNhanVien);
                item.SubItems.Add(ngayNhan.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ngayHoanThanh.ToString("dd/MM/yyyy"));

                lvwMaintance.Items.Add(item);
            }





            if (lvwMaintance != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwMaintance.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwMaintance.Columns[i].Text, lvwMaintance.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwMaintance.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwMaintance.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwMaintance.Columns[i].Width = columnWidth;
                }
            }





        }

        private void ucMaintance_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }
    }
}
