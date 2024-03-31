using GUI.customForm;
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
    public partial class ucStaff : UserControl
    {

        public ucStaff()
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


            cboSortStaffID.DataSource = trangThaiSort;
            cboSortStaffID.AllowDropDownResize = false;


            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateAccounts.DataSource = trangThaiXoa;

            cboStateAccounts.AllowDropDownResize = false;


            // Clear existing items
            lvwStaff.Items.Clear();

            // Add dummy data rows
            for (int i = 0; i < 10; i++)
            {
                // Generate random data
                string maNhanVien = "NV" + (i + 1).ToString("D3");
                string maAccount = "TK" + (i + 1).ToString("D3");
                string hoTen = "Nhân viên " + (i + 1).ToString();
                string gioiTinh = (i % 2 == 0) ? "Nam" : "Nữ"; // Giới tính được chọn ngẫu nhiên
                DateTime ngaySinh = new DateTime(1990 + i, i % 12 + 1, i % 28 + 1); // Ngày sinh từ năm 1990 đến năm 1999
                string cccd = "123456789"; // Số CCCD tạm thời
                string diaChi = "Địa chỉ " + (i + 1).ToString();
                string email = "email" + (i + 1).ToString() + "@example.com";
                string sdt = "0987654321"; // Số điện thoại tạm thời
                string maNQL = "NV" + ((i + 1) % 3 + 1).ToString("D3"); // Mã nhân viên quản lý được chọn ngẫu nhiên từ danh sách nhân viên

                // Create ListViewItem
                ListViewItem item = new ListViewItem(maNhanVien);
                item.SubItems.Add(maAccount);
                item.SubItems.Add(hoTen);
                item.SubItems.Add(gioiTinh);
                item.SubItems.Add(ngaySinh.ToShortDateString());
                item.SubItems.Add(cccd);
                item.SubItems.Add(diaChi);
                item.SubItems.Add(email);
                item.SubItems.Add(sdt);
                item.SubItems.Add(maNQL);

                // Add item to ListView
                lvwStaff.Items.Add(item);
            }


            if (lvwStaff != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwStaff.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwStaff.Columns[i].Text, lvwStaff.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwStaff.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwStaff.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwStaff.Columns[i].Width = columnWidth;
                }
            }





        }

      


        private void ucStaff_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (lvwStaff.SelectedItems.Count > 0) //  Sửa điều kiện đoạn này
            {
                frmNhanVien frm = new frmNhanVien();
                frm.isAdd = false;
                //Bắt đầu sửa từ đoạn này
                frm.maNhanVien = lvwStaff.SelectedItems[0].Text;
                frm.maTaikhoan = lvwStaff.SelectedItems[0].SubItems[1].Text;
                frm.hoTen = lvwStaff.SelectedItems[0].SubItems[2].Text;
                frm.gioiTinh= lvwStaff.SelectedItems[0].SubItems[3].Text;
                frm.ngaySinh = lvwStaff.SelectedItems[0].SubItems[4].Text;
                frm.CCCD = lvwStaff.SelectedItems[0].SubItems[5].Text;
                frm.diaChi = lvwStaff.SelectedItems[0].SubItems[6].Text;
                frm.email = lvwStaff.SelectedItems[0].SubItems[7].Text;
                frm.soDienThoai = lvwStaff.SelectedItems[0].SubItems[8].Text;
                frm.anhDaiDien = null;

                //Kết thúc đoạn được sửa
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Vui lòng chọn nhân viên cần sửa!");
                thongBao.ShowDialog();
            }
        }
    }
}
