using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonPhongDTO
    {
      public int MaDonPhong {get; set;}
      public int MaPhong {get; set;}
      public int MaNV {get; set;}
      public DateTime NgayNhan {get; set;}
      public DateTime? NgayHoanThanh {get; set;}
      public bool TrangThai {get; set;}
    }
}
