using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using static System.Net.Mime.MediaTypeNames;
namespace BLL
{
    public class DatPhongBLL
    {
        DatPhongDAL DatPhongDAL = new DatPhongDAL();

        public bool Check_in(List<DatPhongDTO> list)
        {
            return DatPhongDAL.Check_in(list);
        }

        public bool Check_out(int MaKM, int MaHoaDon, List<DatPhongDTO> list)
        {
            return DatPhongDAL.Check_out(MaKM, MaHoaDon,list);
        }

        public List<DatPhongDTO> Filter(string text1, string text2, DateTime value)
        {
            text1 = text1.Trim();
            text2 = text2.Trim();
            if (text1.Length > 0)
            {
                List<DatPhongDTO> searchResults = laydsp2().Where(item =>
                item.CCCD.ToString().Contains(text1) && item.NgayDatPhong.ToString("MM/dd/yyyy").Equals(value.ToString("MM/dd/yyyy"))
                ).ToList();
                return searchResults;
            }
            else
            {
                List<DatPhongDTO> searchResults = laydsp2().Where(item =>
                item.TenTaiKhoan.ToString().Contains(text2) && item.NgayDatPhong.ToString("MM/dd/yyyy").Equals(value.ToString("MM/dd/yyyy"))
                ).ToList();
                return searchResults;
            }
        }

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
