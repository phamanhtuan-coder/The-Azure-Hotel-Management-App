using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public byte[] HinhAnh { get; set; }
        public int MaNV { get; set; }
        public int? MaNQL { get; set; }
        public int MaTaiKhoan { get; set; }
        public string TenTaiKhoan { get; set; }       
        public string HoTenNV { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string CCCD { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public decimal Luong { get; set; }
        public bool TrangThai { get; set; }
        public string GioiTinh { get; set; }
    }
}
