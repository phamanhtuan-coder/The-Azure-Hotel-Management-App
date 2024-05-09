using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongDTO
    {
        public int MaPHG { get; set; }
        public int MaLoai { get; set; }
        public int MaTinhTrangPhong { get; set; }
        public byte[] HinhAnh { get; set; }
        public string MoTa { get; set; }
        public decimal GiaPhong { get; set; }
        public int SucChuaToiDa { get; set; }
        public bool TrangThai { get; set; }
    }
}
