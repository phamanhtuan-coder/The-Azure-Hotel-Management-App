using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class DatPhongBLL
    {
        DatPhongDAL DatPhongDAL = new DatPhongDAL();

        public List<DatPhongDTO> FilterTrangThai(string trangthai)
        {
            if (trangthai == "Đang hoạt động")
            {
                return DatPhongDAL.FilterTrangThai(true);
            }
            else if (trangthai == "Đã xóa")
            {
                return DatPhongDAL.FilterTrangThai(false);
            }
            else
            {
                return DatPhongDAL.layds();
            }
        }

        public bool khoiphucd(int madatphong)
        {
            return DatPhongDAL.kpd(madatphong);
        }
        public bool checkout(int madatphong, DatPhongDTO datPhongDTO)
        {
            return DatPhongDAL.checkout(madatphong,datPhongDTO);
        }
        public bool checkin(int madatphong, DatPhongDTO datPhongDTO)
        {
            return DatPhongDAL.checkin(madatphong, datPhongDTO);
        }

        public List<DatPhongDTO> laydsp()
        {
            return DatPhongDAL.layds();
        }
        public List<DatPhongDTO> laydsp2()
        {
            return DatPhongDAL.layds2();
        }

        public bool sua(DatPhongDTO datPhongDTO)
        {
            return DatPhongDAL.suad(datPhongDTO);
        }

        public bool them(DatPhongDTO datPhongDTO)
        {
            return DatPhongDAL.themd(datPhongDTO);
        }

        public List<DatPhongDTO> TraCuuPhong(List<DatPhongDTO> datPhongDTOs, string searchKeyword)
        {
            List<DatPhongDTO> searchResults = datPhongDTOs.Where(item =>
             item.MaDatPhong.ToString().Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public bool Xoad(int madatphong)
        {
            return DatPhongDAL.xoa(madatphong);
        }
    }
}
