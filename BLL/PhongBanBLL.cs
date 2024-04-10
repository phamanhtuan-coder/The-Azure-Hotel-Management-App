using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhongBanBLL
    {

        PhongBanDAL phongBanDaL = new PhongBanDAL();

        public static bool KhoiPhucPhongBan(string maPhongBan)
        {
            return PhongBanDAL.KhoiPhucPhongBan(maPhongBan);
        }

        public static bool XoaPhongBan(string maPhongBan)
        {
            return PhongBanDAL.XoaPhongBan(maPhongBan);
        }

        //Hàm dùng để lọc
        public List<PhongBanDTO> FilterTrangThai(string trangThai)
        {
            if (trangThai =="Đang hoạt động")
            {
               return phongBanDaL.FilterTrangThai(true);
            }
            else if (trangThai == "Đã xóa")
            {
                return phongBanDaL.FilterTrangThai(false);
            }
            else
            {
                return phongBanDaL.LayDanhSachPhongBan();
            }
        }

        public List<PhongBanDTO> LayDanhSachPhongBan()
        {
            return phongBanDaL.LayDanhSachPhongBan();
        }

        public bool SuaPhongBan(PhongBanDTO phongBanDTO)
        {
           return phongBanDaL.SuaPhongBan(phongBanDTO);
        }

        public bool ThemPhongBanMoi(PhongBanDTO phongBanDTO)
        {
            return phongBanDaL.ThemPhongBanMoi(phongBanDTO);
        }
        //Hàm dùng để search
        public List<PhongBanDTO> TraCuuPhongBan(List<PhongBanDTO> dsach ,string searchKeyword)
        {
            List<PhongBanDTO> searchResults = dsach.Where(item =>
             item.MaPhongBan.ToLower().Contains(searchKeyword)                                          
         ).ToList();
            return searchResults;
        }
    }
}
