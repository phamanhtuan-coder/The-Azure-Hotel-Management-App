using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HangThanhVienBLL
    {
        HangThanhVienDAL hangThanhVienDAL = new HangThanhVienDAL();
        public List<HangThanhVienDTO> Filer(string trangthai)
        {
            if (trangthai.Length > 0)
            {
                return hangThanhVienDAL.Filer(trangthai);
            }
            return new List<HangThanhVienDTO>();
        }
    }
}
