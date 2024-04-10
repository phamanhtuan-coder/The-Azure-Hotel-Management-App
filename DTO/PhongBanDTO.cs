using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBanDTO
    {
        public string MaPhongBan { get; set; }
        public string TenPhong { get; set; }
        public int? TruongPhong { get; set; }
        public DateTime NgayNhanChuc { get; set; }
        public bool TrangThai { get; set; }
    }
}
