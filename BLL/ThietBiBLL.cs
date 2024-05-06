using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class ThietBiBLL
    {
        ThietBiDAL thietBi = new ThietBiDAL();

        public List<ThietBiDTO> FilterTrangThai(string trangthai)
        {
            if (trangthai == "Đang hoạt động")
            {
                return thietBi.FilterTrangThai(true);
            }
            else if (trangthai == "Đã xóa")
            {
                return thietBi.FilterTrangThai(false);
            }
            else
            {
                return thietBi.laydstbi();
            }
        }

        public bool KhoiPhucttp(int matbi)
        {
            return thietBi.khoiphuctbi(matbi);
        }

        public List<ThietBiDTO> laydstbi()
        {
            return thietBi.laydstbi();
        }

        public bool suatbi(ThietBiDTO thietbi)
        {
            return thietBi.suatbi(thietbi);
        }

        public bool themtbi(ThietBiDTO thietbi)
        {
            return thietBi.themtbi(thietbi);
        }

        public List<ThietBiDTO> TraCuutbi(List<ThietBiDTO> tbi, string searchKeyword)
        {
            List<ThietBiDTO> searchResults = tbi.Where(item =>
             item.TenThietBi.Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public bool Xoatbi(int matbi)
        {
            return thietBi.xoatbi(matbi);
        }
    }
}
