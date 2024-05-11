using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVuDTO
    {
        public int MaDV { get; set; }
        public string TenDV { get; set; }
        public decimal GiaDV { get; set; }
        public byte[] HinhAnh { get; set; }
        public bool TrangThai { get; set; }
    }
}
