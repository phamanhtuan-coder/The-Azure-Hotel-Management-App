using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL khachHangDAL = new KhachHangDAL();
        public List<KhachHangDTO> Filer(int maHang, string gioiTinh, string tT)
        {
            return khachHangDAL.Filter(maHang, gioiTinh, tT);
        }

        public List<KhachHangDTO> TraCuuNhanVien(List<KhachHangDTO> khachHangDTOs, string searchKeyword)
        {
            List<KhachHangDTO> searchResults = khachHangDTOs.Where(item =>
             item.HoTenKH.ToLower().Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }
    }
}
