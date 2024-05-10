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

        public int AddHoaDon(HoaDonDTO hoaDonDTO)
        {
            if(hoaDonDTO.MaKH>0 && hoaDonDTO.MaNV>0 && hoaDonDTO.MaThue > 0)
            {
                return hoaDonDAL.AddHoaDon(hoaDonDTO);
            }
            return -1;
        }

        public bool EditHoaDon(HoaDonDTO hoaDonDTO)
        {
            if (hoaDonDTO.MaKH > 0 && hoaDonDTO.MaNV > 0 && hoaDonDTO.MaThue > 0 &&  hoaDonDTO.MaHoaDon > 0)
            {
                return hoaDonDAL.EditHoaDon(hoaDonDTO);
            }
            return false;
        }

        public List<HoaDonDTO> Filter(string text1, string text2, DateTime ng)
        {
            text1 = text1.Trim();
            text2 = text2.Trim();
            if (text1.Length > 0)
            {
                List<HoaDonDTO> searchResults = TruyVanDanhSachHoaDon().Where(item =>
                item.CCCD.ToString().Contains(text1) && item.NgayLapHoaDon.Date.ToString("dd/MM/yyyy") == ng.Date.ToString("dd/MM/yyyy") && item.TrangThai == true
                ).ToList();
                return searchResults;
            }
            else
            {
                List<HoaDonDTO> searchResults = TruyVanDanhSachHoaDon().Where(item =>
                item.TenTaiKhoan.ToString().Contains(text2) && item.NgayLapHoaDon.Date.ToString("dd/MM/yyyy") == ng.Date.ToString("dd/MM/yyyy") && item.TrangThai == true
                ).ToList();
                return searchResults;
            }
        }

        public bool KhoiPhucHoaDon(HoaDonDTO hoaDonDTO)
        {
            if (hoaDonDTO.MaHoaDon > 0)
            {
                return hoaDonDAL.XoaHoaDon(hoaDonDTO, 1);
            }
            return false;
        }

        public bool ThanhToan(HoaDonDTO hoaDonDTO)
        {
            return hoaDonDAL.ThanhToan(hoaDonDTO);
        }

        public List<HoaDonDTO> TraCuuHoaDon(List<HoaDonDTO> hoaDonDTOs, string searchKeyword)
        {
            List<HoaDonDTO> searchResults = hoaDonDTOs.Where(item =>
             item.MaHoaDon.ToString() == searchKeyword
         ).ToList();
            return searchResults;
        }

        public List<HoaDonDTO> TraCuuHoaDon(List<HoaDonDTO> hoaDonDTOs, string tT, string ngaytao)
        {
            hoaDonDTOs = TruyVanDanhSachHoaDon();
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

        public bool XoaHoaDon(HoaDonDTO hoaDonDTO)
        {
            if (hoaDonDTO.MaHoaDon > 0)
            {
                return hoaDonDAL.XoaHoaDon(hoaDonDTO, 0);
            }
            return false;
        }
    }
}
