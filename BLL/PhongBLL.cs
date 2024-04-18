using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class PhongBLL
    {
        PhongDAL PhongDAL=new PhongDAL();

        public bool kpp(int maphong)
        {
            return PhongDAL.kqphong(maphong);
        }

        public List<PhongDTO> laydsp()
        {
            return PhongDAL.laydsphong();
        }

        public bool suap(PhongDTO phongDTO)
        {
            return PhongDAL.suaphong(phongDTO);
        }

        public bool themp(PhongDTO phongDTO)
        {
            return PhongDAL.themphong(phongDTO);
        }

        public bool Xoap(int maphong)
        {
            return PhongDAL.xoaphong(maphong);
        }
    }
}
