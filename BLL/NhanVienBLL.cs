﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        public int MaNV { get; set; }
        public int MaNQL { get; set; }
        public int MaTaiKhoan { get; set; }
        public byte[] HinhAnh { get; set; }
        public string HoTenNV { get; set; }
        public string SDT {  get; set; }
        public string Email { get; set; }
        public string CCCD { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public decimal Luong { get; set; }
        public bool TrangThai { get; set; }
    }
}
