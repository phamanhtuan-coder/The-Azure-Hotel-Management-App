using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoleBLL
    {
        public bool AddRoleBLL(RoleDTO role)
        {
            RoleDAL roleDAL = new RoleDAL();
            if (role.TenVaiTro.Length > 0)
            {
                return roleDAL.ADDRoleDAL(role);
            }
            return false;
        }

        public bool EditRoleBLL(RoleDTO role)
        {
            RoleDAL roleDAL = new RoleDAL();
            if (role.TenVaiTro.Length > 0)
            {
                return roleDAL.EditRoleDAL(role);
            }
            return false;
        }

        public List<RoleDTO> LoadRoleBLL()
        {
            RoleDAL roleDAL = new RoleDAL();
            return roleDAL.loadRoleDAL();
        }
    }
}
  