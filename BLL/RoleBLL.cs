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
        RoleDAL roleDAL = new RoleDAL(); 
        public bool AddRoleBLL(RoleDTO role)
        {
            return roleDAL.ADDRoleDAL(role);

        }

        public bool EditRoleBLL(RoleDTO role)
        {
            if (role.MaPhanQuyen.Length > 0)
            {
                return roleDAL.EditRoleDAL(role);
            }
            return false;
        }

        public List<RoleDTO> FilterTrangThai(string text)
        {
            if (text == "Đang hoạt động")
            {
                return roleDAL.FilterTrangThai(true);
            }
            else if (text == "Đã xóa")
            {
                return roleDAL.FilterTrangThai(false);
            }
            else
            {
                return roleDAL.loadRoleDAL();
            }
        }

        public List<RoleDTO> LoadRoleBLL()
        {
            return roleDAL.loadRoleDAL();
        }

        public List<TenPB> LoadPBBLL()
        {
            return roleDAL.LoadPBDAL();
        }

        public List<TenVT> LoadVTBLL()
        {
            return roleDAL.LoadVTDAL();
        }

        public List<RoleDTO> TraCuuPhongBan(List<RoleDTO> dsRole, string searchKeyword)
        {
            List<RoleDTO> searchResults = dsRole.Where(item =>
             item.MaPhanQuyen.ToLower().Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public bool DeleteRoleBLL(string pq)
        {
            if (pq.Length >0)
            {
                return roleDAL.DeleteRoleDAL(pq);
            }
            return false;
        }

        public bool RestoreRoleBLL(string mPQ)
        {
            if (mPQ.Length > 0)
            {
                return roleDAL.RestoreRoleDAL(mPQ);
            }
            return false;
        }

        //public string maPBBLL(string v)
        //{
        //    return RoleDAL.maPBDAL(v);
        //}
    }
}
  