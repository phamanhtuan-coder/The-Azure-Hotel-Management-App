using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
      public int MaHoaDon {get; set;}
      public int MaKH {get; set;}
      public int MaNV {get; set;}
      public int MaThue {get; set;}
      public DateTime NgayLapHoaDon {get; set;}
      public decimal TongHoaDon {get; set;}
      public decimal TienNhan {get; set;}
      public decimal TienThoi {get; set;}
      public bool TrangThai {get; set;}
    }
}
