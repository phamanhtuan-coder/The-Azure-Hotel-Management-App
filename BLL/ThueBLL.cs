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

        public bool AddThue(ThueDTO thueDTO)
        {
            if(!string.IsNullOrWhiteSpace(thueDTO.TenThue.Trim()) && thueDTO.TyLeThue > 0)
            {
                return thueDAL.AddThue(thueDTO);
            }
            else
            {
                return false;   
            }
        }

        public bool EditThue(ThueDTO thueDTO)
        {
            if (thueDTO.MaThue>0 && !string.IsNullOrWhiteSpace(thueDTO.TenThue.Trim()) && thueDTO.TyLeThue > 0)
            {
                return thueDAL.EditThue(thueDTO);
            }
            else
            {
                return false;
            }
        }
        public bool XoaThue(int maThue)
        {
            if (maThue > 0)
            {
                return thueDAL.XoaThue(maThue);
            }
            else
            {
                return false ;
            }
        }
        public bool KhoiPhucThue(int maThue)
        {
            if (maThue > 0)
            {
                return thueDAL.KhoiPhucThue(maThue);
            }
            else
            {
                return false;
            }
        }
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
                                TruyVanDSThue().Where
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

        public List<ThueDTO> TraCuuThue(List<ThueDTO> thueDTOs, string searchKeyword)
        {
            List<ThueDTO> searchResults = thueDTOs.Where(item =>
             item.TenThue.ToLower().Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public int LayKM(int maThue)
        {
            return thueDAL.LayKM(maThue);
        }
    }
}
