using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VaiTroBLL
    {
        VaiTroDAL vaiTroDAL = new VaiTroDAL();

        public List<VaiTroDTO> FilterTrangThai(string text)
        {
            if (text == "Đang hoạt động")
            {
                return vaiTroDAL.LoadDSRoleTTDAL(1);
            }
            else if (text == "Đã xóa")
            {
                return vaiTroDAL.LoadDSRoleTTDAL(0);
            }
            else
            {
                return vaiTroDAL.LoadDSRoleDAL();
            }
        }

        public List<VaiTroDTO> LoadDSRoleBLL()
        {
            return vaiTroDAL.LoadDSRoleDAL();
        }

        public List<VaiTroDTO> LoadDSRoleTTBLL(int i)
        {
            return vaiTroDAL.LoadDSRoleTTDAL(i);
        }
    }
}
