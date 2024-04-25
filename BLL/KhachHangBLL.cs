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
    }
}
