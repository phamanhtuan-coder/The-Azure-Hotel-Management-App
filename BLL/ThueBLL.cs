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
        public List<ThueDTO> TruyVanTenVaMaThue()
        {
            return thueDAL.TruyVanTenVaMaThue();
        }
    }
}
