using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hoaDonDAL = new HoaDonDAL();

        public List<HoaDonDTO> TraCuuHoaDon(List<HoaDonDTO> hoaDonDTOs, string searchKeyword)
        {
            List<HoaDonDTO> searchResults = hoaDonDTOs.Where(item =>
             item.MaHoaDon.ToString() == searchKeyword
         ).ToList();
            return searchResults;
        }

        public List<HoaDonDTO> TraCuuHoaDon(List<HoaDonDTO> hoaDonDTOs, string tT, string ngaytao)
        {
            if (!tT.Equals("Tất cả"))
            {
                if (ngaytao.Length>0)
                {
                    bool tt;
                    if (tT.Equals("Đang hoạt động"))
                    {
                        tt = true;
                    }
                    else
                    {
                        tt = false;
                    }

                    List<HoaDonDTO> searchResults =
                                    hoaDonDTOs.Where
                                    (item => item.TrangThai == tt && item.NgayLapHoaDon.Date == DateTime.Parse(ngaytao)).ToList();
                    return searchResults;
                }
                else
                {
                    bool tt;
                    if (tT.Equals("Đang hoạt động"))
                    {
                        tt = true;
                    }
                    else
                    {
                        tt = false;
                    }
                    List<HoaDonDTO> searchResults =
                                    hoaDonDTOs.Where
                                    (item => item.TrangThai == tt).ToList();
                    return searchResults;
                }
            }
            else
            {
                if (ngaytao.Length > 0)
                {
                    List<HoaDonDTO> searchResults =
                                    hoaDonDTOs.Where
                                    (item => item.NgayLapHoaDon.Date == DateTime.Parse(ngaytao)).ToList();
                    return searchResults;
                }
                else
                {                                
                    return hoaDonDAL.TruyVanDanhSachHoaDon();
                }
            }
        }

        public List<HoaDonDTO> TruyVanDanhSachHoaDon()
        {
            return hoaDonDAL.TruyVanDanhSachHoaDon();
        }
    }
}
