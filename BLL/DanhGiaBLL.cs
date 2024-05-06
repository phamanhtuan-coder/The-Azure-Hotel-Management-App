using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DanhGiaBLL
    {
        public DanhGiaDAL danhGiaDAL = new DanhGiaDAL();

        public bool KhoiPhucDanhGia(string maDanhGia)
        {
            return danhGiaDAL.KhoiPhucDanhGia(maDanhGia);
        }

        public  List<DanhGiaDTO> LayDanhSachDanhGia()
        {
            return danhGiaDAL.LayDanhSachDanhGia();
        }

        public bool XoaDanhGia(string maDanhGia)
        {
            return danhGiaDAL.XoaDanhGia(maDanhGia);
        }
    }
}
