using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatPhongDTO
    {
        public int MaDatPhong { get; set; }
        public int MaKH { get; set; }
        public int MaPHG { get; set; }
        public DateTime NgayDatPhong { get; set; }
        public DateTime? NgayNhanPhong { get; set; }
        public DateTime? NgayTraPhong { get; set; }
        public int SoLuongKH { get; set; }
        public bool TrangThai { get; set; }
    }
}
