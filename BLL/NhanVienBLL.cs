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

        public List<NhanVienDTO> Filer(int PhanQuyen, string PhongBan, string GioiTinh, int NguoiQuanLy, string TrangThai)
        {
            return nhanVienDAL.Filter(PhanQuyen, PhongBan, GioiTinh, NguoiQuanLy, TrangThai);
        }

        public List<NhanVienDTO> LoadIDAndNameBLL()
        {
            return nhanVienDAL.LoadIDAndNameDAL();
        }
    }
}
