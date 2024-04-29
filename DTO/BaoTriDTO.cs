using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoTriDTO
    {
        public int MaBaoTri { get; set; }
        public int MaThietBi { get; set; }
        public int MaNV { get; set; }
        public DateTime NgayHuHong { get; set; }
        public DateTime NgayBaoTri { get; set; }
        public bool TrangThai { get; set; }
    }
}
