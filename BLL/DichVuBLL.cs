using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class DichVuBLL
    {
        DichVuDAL dichVu = new DichVuDAL();

        public List<DichVuDTO> FilterTrangThai(string trangthai)
        {
            if (trangthai == "Đang hoạt động")
            {
                return dichVu.FilterTrangThai(true);
            }
            else if (trangthai == "Đã xóa")
            {
                return dichVu.FilterTrangThai(false);
            }
            else
            {
                return dichVu.layDSDVu();
            }
        }

        public bool KhoiPhucdvu(int madv)
        {
            return dichVu.khoiphucdvu(madv);
        }

        public List<DichVuDTO> laydsdvu()
        {
            return dichVu.layDSDVu2();
        }

        public bool suadvu(DichVuDTO dv)
        {
            return dichVu.suadvu(dv);
        }

        public bool themdvu(DichVuDTO dv)
        {
            return dichVu.themdvu(dv);
        }

        public List<DichVuDTO> TraCuudvu(List<DichVuDTO> dv, string searchKeyword)
        {
            List<DichVuDTO> searchResults = dv.Where(item =>
             item.TenDV.Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public bool Xoadvu(int madvu)
        {
            return dichVu.Xoadichvu(madvu);
        }
    }
}
