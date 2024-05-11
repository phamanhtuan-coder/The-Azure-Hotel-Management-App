using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
      public int MaCTHD {get; set;}
      public int MaHD {get; set;}
      public int MaDatPhong {get; set;}
      public int MaKhuyenMai {get; set;}
      public decimal KhuyenMai { get; set; }
      public decimal? ThanhTien {get; set;}
      public bool TrangThai {get; set;}
    }
}
