using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietHoaDonBLL
    {
        ChiTietHoaDonDAL chiTietHoaDonDAL = new ChiTietHoaDonDAL();
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
    }
}
