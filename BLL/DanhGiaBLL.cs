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

        public List<DanhGiaDTO> FilterTrangThai(string trangThai)
        {
            if (trangThai == "Đang hoạt động")
            {
                return danhGiaDAL.FilterTrangThai(true);
            }
            else if (trangThai == "Đã xóa")
            {
                return danhGiaDAL.FilterTrangThai(false);
            }
            else
            {
                return danhGiaDAL.LayDanhSachDanhGia();
            }
        }

        public bool KhoiPhucDanhGia(int maDanhGia)
        {
            return danhGiaDAL.KhoiPhucDanhGia(maDanhGia);
        }

        public  List<DanhGiaDTO> LayDanhSachDanhGia()
        {
            return danhGiaDAL.LayDanhSachDanhGia();
        }

        public List<DanhGiaDTO> LayDanhSachDanhGiaTheoUser(int maKH)
        {
            return danhGiaDAL.LayDanhSachDanhGiaTheoUser(maKH);
        }

        public bool SuaDanhGia(DanhGiaDTO danhGia)
        {
            if (danhGia.MaDG > 0 && danhGia.MaDP > 0 && danhGia.DiemDanhGia > 0)
            {
                return danhGiaDAL.SuaDanhGia(danhGia);
            }
            return false;
        }

        public bool ThemDanhGia(DanhGiaDTO danhGia)
        {
            if (danhGia.MaDP>0 && danhGia.DiemDanhGia>0)
            {
                return danhGiaDAL.ThemDanhGia(danhGia);
            }
            return false;
        }

        public bool XoaDanhGia(int maDanhGia)
        {
            return danhGiaDAL.XoaDanhGia(maDanhGia);
        }
    }
}
