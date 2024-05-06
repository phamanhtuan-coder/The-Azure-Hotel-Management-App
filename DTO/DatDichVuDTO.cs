using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatDichVuDTO
    {
        public int MaDatDichVu { get; set; }
        public int MaDatPhong { get; set; }
        public int MaDV { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }
        public DateTime NgayDat { get; set; }
        public bool TrangThai { get; set; }
    }
}
