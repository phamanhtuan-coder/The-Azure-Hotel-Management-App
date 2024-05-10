using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietHoaDonBLL
    {
        ChiTietHoaDonDAL chiTietHoaDonDAL = new ChiTietHoaDonDAL();

        public List<ChiTietHoaDonDTO> Filter(string tT)
        {
            if(!tT.Equals("Tất cả"))
            {
                bool TT;
                if (tT.Equals("Đang hoạt động"))
                {
                    TT = true;
                }
                else
                {
                    TT = false;
                }
                List<ChiTietHoaDonDTO> searchResults = TruyVanDSChiTiet().Where(item => item.TrangThai == TT).ToList();
                return searchResults;
            }
            return TruyVanDSChiTiet();
        }
        public bool XoaChiTiet(int maDP)
        {
            return chiTietHoaDonDAL.ThayDoiTrangThai(maDP, 0);
        }
        public bool KhoiPhucChiTiet(int maDP)
        {
            return chiTietHoaDonDAL.ThayDoiTrangThai(maDP, 1);
        }

        public List<ChiTietHoaDonDTO> TraCuuDonPhong(List<ChiTietHoaDonDTO> chiTietHoaDonDTOs, string searchKeyword)
        {
            List<ChiTietHoaDonDTO> searchResults = chiTietHoaDonDTOs.Where(item =>
             item.MaCTHD == int.Parse(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public List<ChiTietHoaDonDTO> TruyVanChiTiet(int maHoaDon)
        {
            if (maHoaDon > 0)
            {
                return chiTietHoaDonDAL.TruyVanChiTiet(maHoaDon);
            }
            else
            {
                return new List<ChiTietHoaDonDTO>();
            }
        }

        public List<ChiTietHoaDonDTO> TruyVanDSChiTiet()
        {
            return chiTietHoaDonDAL.TruyVanDSChiTiet();
        }

        public List<ChiTietHoaDonDTO> TruyVanChiTietDaXoa(int maHoaDon)
        {
            if (maHoaDon > 0)
            {
                return chiTietHoaDonDAL.TruyVanChiTietDaXoa(maHoaDon);
            }
            else
            {
                return new List<ChiTietHoaDonDTO>();
            }
        }
    }
}
