using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleDTO
    {
        public string MaPhanQuyen { get; set; }
        public string MaPhongBan { get; set; }
        public int MaVaiTro { get; set; }
        public string TenVaiTro { get; set; }
        public string MoTa { get; set; }
        public int SoLuongTK { get; set; }
        public string TrangThai { get; set; }

    }

    public class TenVT {
        public int MaVaiTro { get; set; }
        public string TenVaiTro { get; set; }
    }

    public class TenPB
    {
        public string MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
    }
}
