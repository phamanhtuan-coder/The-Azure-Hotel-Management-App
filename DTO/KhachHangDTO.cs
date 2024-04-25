using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
      public int MaKH {get; set;}
      public int MaTaiKhoan {get; set;}
      public string TenDangNhap { get; set; }
      public int MaLoaiHangThanhVien {get; set;}
      public string TenHang { get; set; }
      public byte[] HinhAnh {get; set;}
      public string HoTenKH {get; set;}
      public string Email {get; set;}
      public string CCCD {get; set;}
      public DateTime NgaySinh {get; set;}
      public string SDT { get; set;}
      public string GioiTinh { get; set;}
      public string DiaChi {get; set;}
      public bool TrangThai {get; set;}
    }
}
