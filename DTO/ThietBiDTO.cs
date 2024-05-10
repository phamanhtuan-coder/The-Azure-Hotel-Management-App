using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThietBiDTO
    {
        public int MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public int MaPHG { get; set; }
        public string HinhAnh { get; set; }
        public int MaTinhTrangThietBi { get; set; }
        public bool TrangThai { get; set; }
    }
}
