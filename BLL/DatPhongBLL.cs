using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class DatPhongBLL
    {
        DatPhongDAL DatPhongDAL = new DatPhongDAL();
        public List<DatPhongDTO> laydsp()
        {
            return DatPhongDAL.layds();
        }

        public bool sua(DatPhongDTO datPhongDTO)
        {
            return DatPhongDAL.suad(datPhongDTO);
        }

        public bool them(DatPhongDTO datPhongDTO)
        {
            return DatPhongDAL.themd(datPhongDTO);
        }
    }
}
