using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.WinForms.ListView;

namespace GUI
{
    public class DuLieuChoComboBox
    {
        public static void duLieuSort(SfComboBox comboBox)
        {
            List<string> sortOptions = new List<string>
        {
            "Không sắp xếp",
            "Tăng dần",
            "Giảm dần"
        };
            comboBox.DataSource = sortOptions;
            comboBox.SelectedIndex = 0;
        }

        public static void duLieuFilter(SfComboBox comboBox)
        {
            List<string> filterOptions = new List<string>
        {
            "Tất cả",
            "Đang hoạt động",
            "Đã xóa"     
        };
            comboBox.DataSource = filterOptions;
            comboBox.SelectedIndex = 0;
        }
    }
}
