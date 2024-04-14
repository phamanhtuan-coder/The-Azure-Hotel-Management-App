using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class TTThietBiBLL
    {
        TTThietBiDAL ThietBiDAL = new TTThietBiDAL();

        public bool KhoiPhucTTTBi(int maTTTBi)
        {
            return TTThietBiDAL.khoiphucTTTbi(maTTTBi);
        }

        public List<TTThietBiDTO> laydsTBi()
        {
            return ThietBiDAL.layDSTBi();
        }

        public bool suaTTTBi(TTThietBiDTO tTThietBiDTO)
        {
            return ThietBiDAL.suaTTTbi(tTThietBiDTO);

        }

        public bool themTTTBi(TTThietBiDTO tTThietBiDTO)
        {
            return ThietBiDAL.themTTTbi(tTThietBiDTO);
        }

        public bool XoaTTTBi(int maTTTBi)
        {
            return  TTThietBiDAL.XoaTTTbi(maTTTBi);
        }
    }
    
}
