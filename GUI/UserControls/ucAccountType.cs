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
    public partial class ucAccountType : UserControl
    {

        public ucAccountType()
        {
            InitializeComponent();
        }


        private void khoiTaoGiaTrichoForm()
        {
            List<string> loaiAccount = new List<string>();
            List<string> phongBan = new List<string>();


            List<string> trangThaiSort = new List<String>();
            List<string> trangThaiXoa = new List<string>();

            loaiAccount.Add("Khách hàng");
            loaiAccount.Add("Admin");
            loaiAccount.Add("Nhân viên");
            loaiAccount.Add("Trưởng phòng");
            cboSortAccountTypeID.DataSource = loaiAccount; 
            cboSortAccountTypeID.AllowDropDownResize = false;

            phongBan.Add("Khách hàng");
            phongBan.Add("Quản trị");
            phongBan.Add("Kế toán");
            phongBan.Add("Lễ tân");
            phongBan.Add("Bảo trì");
            phongBan.Add("Dịch vụ phòng");
            phongBan.Add("Marketing & Sales");

            cboChucVu.DataSource = phongBan;
            cboChucVu.AllowDropDownResize = false;

            trangThaiSort.Add("Tăng dần");
            trangThaiSort.Add("Giảm dần");
            trangThaiSort.Add("Không sắp xếp");
 
  

            cboSortSoLuongAccount.DataSource = trangThaiSort;
            cboSortSoLuongAccount.AllowDropDownResize = false;

            trangThaiXoa.Add("Đã bị xóa");
            trangThaiXoa.Add("Chưa bị xóa");
            trangThaiXoa.Add("Tất cả");
            cboStateAccountType.DataSource = trangThaiXoa;

            cboStateAccountType.AllowDropDownResize = false;

            // Random dữ liệu tạm thời cho bảng Account Type
            Random random = new Random();

            // Clear existing items
            lvwAccountType.Items.Clear();

            // Dictionary để theo dõi số lượng trưởng phòng đã được thêm cho mỗi phòng ban
            Dictionary<string, bool> truongPhongAdded = new Dictionary<string, bool>();

            // Tạo danh sách mã phân quyền
            Dictionary<string, string> maPhanQuyen = new Dictionary<string, string>();
            maPhanQuyen["Khách hàng"] = "KH-00";
            maPhanQuyen["Quản trị"] = "AD-00";
            maPhanQuyen["Lễ tân"] = "LT-";
            maPhanQuyen["Nhân viên"] = "NV-";
            maPhanQuyen["Kế toán"] = "KT-";
            maPhanQuyen["Bảo trì"] = "BT-";
            maPhanQuyen["Dịch vụ phòng"] = "DV-";
            maPhanQuyen["Marketing & Sales"] = "MS-";

            // Add dummy data rows for each department
            foreach (string department in phongBan)
            {
                // Initialize số lượng trưởng phòng cho phòng ban
                truongPhongAdded[department] = false;

                // Tạo số lượng dòng tùy thuộc vào phòng ban
                int soLuongDong;
                if (department == "Khách hàng")
                    soLuongDong = 1;
                else if (department == "Quản trị")
                    soLuongDong = 1;
                else
                    soLuongDong = 2;

                // Tạo dữ liệu cho mỗi dòng
                for (int i = 0; i < soLuongDong; i++)
                {
                    // Random mã loại tài khoản
                    string maLoai;
                    if (department == "Khách hàng")
                        maLoai = maPhanQuyen[department];
                    else if (department == "Quản trị")
                        maLoai = maPhanQuyen[department];
                    else
                    {
                        if (i == 0)
                            maLoai = maPhanQuyen[department] + "01";
                        else
                            maLoai = maPhanQuyen[department] + (i < 10 ? "0" : "") + (i + 1).ToString();
                    }

                    // Chọn chức vụ dựa trên phòng ban
                    string chucVu;
                    if (department == "Khách hàng")
                        chucVu = "Khách hàng";
                    else if (department == "Quản trị")
                        chucVu = "Admin";
                    else
                        chucVu = (i == 0 && !truongPhongAdded[department]) ? "Trưởng phòng" : "Nhân viên";

                    // Mô tả tạm thời
                    string moTa = "Mô tả cho loại tài khoản " + maLoai;

                    // Số lượng tài khoản
                    int soLuongTaiKhoan = (chucVu == "Trưởng phòng") ? (truongPhongAdded[department] ? 0 : 1) : random.Next(1, 21);

                    // Thêm ListViewItem vào ListView
                    ListViewItem item = new ListViewItem(maLoai);
                    item.SubItems.Add(chucVu);
                    item.SubItems.Add(department);
                    item.SubItems.Add(moTa);
                    item.SubItems.Add(soLuongTaiKhoan.ToString());

                    lvwAccountType.Items.Add(item);

                    // Nếu là trưởng phòng, đánh dấu đã được thêm và không được thêm nữa
                    if (chucVu == "Trưởng phòng")
                        truongPhongAdded[department] = true;
                }
            }







            if (lvwAccountType != null)
            {
                // Resize columns based on column header or content
                for (int i = 0; i < lvwAccountType.Columns.Count; i++)
                {
                    int headerWidth = TextRenderer.MeasureText(lvwAccountType.Columns[i].Text, lvwAccountType.Font).Width;
                    int contentWidth = 0;

                    // Calculate the maximum width of content in the column
                    foreach (ListViewItem item in lvwAccountType.Items)
                    {
                        int itemWidth = TextRenderer.MeasureText(item.SubItems[i].Text, lvwAccountType.Font).Width;
                        contentWidth = Math.Max(contentWidth, itemWidth);
                    }

                    // Determine the width needed for the column
                    int columnWidth = Math.Max(headerWidth, contentWidth);

                    // Set the width of the column
                    lvwAccountType.Columns[i].Width = columnWidth;
                }
            }





        }

        private void ucAccountType_Load(object sender, EventArgs e)
        {
            khoiTaoGiaTrichoForm();
        }


    }
}
