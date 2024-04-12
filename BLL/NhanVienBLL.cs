using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public List<NhanVienDTO> FilterTrangThai(string text)
        {
            if (text == "Đang hoạt động")
            {
                return nhanVienDAL.LoadDSNhanVienTTDAL(1);
            }
            else if (text == "Đã xóa")
            {
                return nhanVienDAL.LoadDSNhanVienTTDAL(0);
            }
            else
            {
                return nhanVienDAL.LoadDSNhanVienDAL();
            }
        }

        public List<NhanVienDTO> LoadIDAndNameBLL()
        {
            return nhanVienDAL.LoadIDAndNameDAL();
        }
    }
}
