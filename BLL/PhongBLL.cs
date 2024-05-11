using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PhongBLL
    {
        PhongDAL PhongDAL = new PhongDAL();

        public List<PhongDTO> FilterTrangThai(string trangthai)
        {
            if (trangthai == "Đang hoạt động")
            {
                return PhongDAL.FilterTrangThai(true);
            }
            else if (trangthai == "Đã xóa")
            {
                return PhongDAL.FilterTrangThai(false);
            }
            else
            {
                return PhongDAL.laydsphong();
            }
        }

        public bool kpp(int maphong)
        {
            return PhongDAL.kqphong(maphong);
        }

        public List<PhongDTO> laydsp()
        {
            return PhongDAL.laydsphong();
        }

        public bool suap(PhongDTO phongDTO)
        {
            return PhongDAL.suaphong(phongDTO);
        }

        public bool themp(PhongDTO phongDTO)
        {
            return PhongDAL.themphong(phongDTO);
        }

        public List<PhongDTO> TraCuuPhong(List<PhongDTO> phongDTOs, string searchKeyword)
        {
            List<PhongDTO> searchResults = phongDTOs
                .Where(item => item.MaPHG.ToString().Contains(searchKeyword))
                .ToList();
            return searchResults;
        }

        public List<PhongDTO> trloaiphong(List<PhongDTO> phongDTOs, string searchKeyword)
        {
            List<PhongDTO> searchResults = phongDTOs
                .Where(item => item.MaTinhTrangPhong.ToString().Contains(searchKeyword))
                .ToList();
            return searchResults;
        }

        public List<PhongDTO> trttphong(List<PhongDTO> phongDTOs, string searchKeyword)
        {
            List<PhongDTO> searchResults = phongDTOs
                .Where(item => item.MaPHG.ToString().Contains(searchKeyword))
                .ToList();
            return searchResults;
        }

        public bool Xoap(int maphong)
        {
            return PhongDAL.xoaphong(maphong);
        }

        private PhongDAL phongDAL = new PhongDAL();

        public List<PhongDTO> FilterRooms(
            DateTime ngayCheckIn,
            int soLuongKhach,
            decimal priceMin,
            decimal priceMax
        )
        {
            return phongDAL.FilterRooms(ngayCheckIn, soLuongKhach, priceMin, priceMax);
        }

        public List<PhongDTO> GetAvailableRooms()
        {
            try
            {
                return phongDAL.GetAvailableRooms();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PhongDTO> LayDsPhongDaSanSang(DateTime ngayDat)
        {
            return PhongDAL.LayDsPhongDaSanSang(ngayDat);
        }
    }
}
