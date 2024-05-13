using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhGiaDTO
    {
        public int MaDG { get; set; }
        public int MaDP { get; set; }
        public int DiemDanhGia { get; set; }
        public string NhanXet { get; set; }
        public DateTime NgayDanhGia { get; set; }
        public bool TrangThai { get; set; }
        public string HoTenKH { get; set; }
        public string TenDangNhap { get; set; }
    }
}
