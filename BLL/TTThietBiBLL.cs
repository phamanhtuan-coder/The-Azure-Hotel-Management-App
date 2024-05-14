using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class TTThietBiBLL
    {
        TTThietBiDAL ThietBiDAL = new TTThietBiDAL();

        public static List<TTThietBiDTO> LayDSTinhTrangThietBi()
        {
            return TTThietBiDAL.LayDSTinhTrangThietBi();
        }

        public List<TTThietBiDTO> FilterTrangThai(string trangthai)
        {
            if (trangthai == "Đang hoạt động")
            {
                return ThietBiDAL.FilterTrangThai(true);
            }
            else if (trangthai == "Đã xóa")
            {
                return ThietBiDAL.FilterTrangThai(false);
            }
            else
            {
                return ThietBiDAL.layDSTBi();
            }
        }

        public bool KhoiPhucTTTBi(int maTTTBi)
        {
            return TTThietBiDAL.khoiphucTTTbi(maTTTBi);
        }

        public List<TTThietBiDTO> laydsTBi()
        {
            return ThietBiDAL.layDSTBi();
        }
        public List<TTThietBiDTO> laydsTBi2()
        {
            return ThietBiDAL.layDSTBi2();
        }
        public bool suaTTTBi(TTThietBiDTO tTThietBiDTO)
        {
            return ThietBiDAL.suaTTTbi(tTThietBiDTO);

        }

        public bool themTTTBi(TTThietBiDTO tTThietBiDTO)
        {
            return ThietBiDAL.themTTTbi(tTThietBiDTO);
        }

        public List<TTThietBiDTO> tracutttb(List<TTThietBiDTO> thietBiDTOs, string searchKeyword)
        {
            List<TTThietBiDTO> searchResults = thietBiDTOs.Where(item =>
             item.TenTinhTrang.Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public bool XoaTTTBi(int maTTTBi)
        {
            return  TTThietBiDAL.XoaTTTbi(maTTTBi);
        }
    }
    
}
