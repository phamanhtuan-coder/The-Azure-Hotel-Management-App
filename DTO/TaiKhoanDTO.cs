using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public int MaTaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public DateTime NgayTao { get; set; }
        public string MatKhau { get; set; }
        public string MaPQ { get; set; }
        public bool TrangThai { get; set; }
    }
}
