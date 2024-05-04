using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThueBLL
    {
        ThueDAL thueDAL = new ThueDAL();

        public List<ThueDTO> TraCuThue(List<ThueDTO> thueDTOs, string tt)
        {
            if (!tt.Equals("Tất cả"))
            {
                bool TT;
                if (tt.Equals("Đang hoạt động"))
                {
                    TT = true;
                }
                else
                {
                    TT = false;
                }

                List<ThueDTO> searchResults =
                                thueDTOs.Where
                                (item => item.TrangThai == TT).ToList();
                return searchResults;
            }
            else
            {
                return TruyVanDSThue();
            }
        }

        public List<ThueDTO> TruyVanDSThue()
        {
            return thueDAL.TruyVanDSThue();
        }

        public List<ThueDTO> TruyVanTenVaMaThue()
        {
            return thueDAL.TruyVanTenVaMaThue();
        }
    }
}
