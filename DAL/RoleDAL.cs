using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoleDAL
    {
        public bool ADDRoleDAL(RoleDTO role)
        {
            //try
            //{
            //    SqlConnection conn = DataProvider.KetNoiDuLieu();

            //    conn.Open();

            //    SqlCommand com = new SqlCommand("sp_ThemVaiTro", conn);
            //    com.CommandType = System.Data.CommandType.StoredProcedure;
            //    com.Parameters.AddWithValue("@TenVaiTro", role.TenVaiTro);
            //    com.Parameters.AddWithValue("@MoTa", role.MoTa);

            //    int count = com.ExecuteNonQuery();

            //    conn.Close();

            //    if (count > 0) return true;
            //    else return false;

                
            //}
            //catch (Exception)
            //{
                 return false;
            //}
        }

        public bool EditRoleDAL(RoleDTO role)
        {
            //try
            //{
            //    SqlConnection conn = DataProvider.KetNoiDuLieu();

            //    conn.Open();

            //    SqlCommand com = new SqlCommand("sp_CapNhatVaiTro", conn);
            //    com.CommandType = System.Data.CommandType.StoredProcedure;
            //    com.Parameters.AddWithValue("@MaVaiTro", role.MaVaiTro);
            //    com.Parameters.AddWithValue("@TenVaiTro", role.TenVaiTro);
            //    com.Parameters.AddWithValue("@MoTa", role.MoTa);

            //    int count = com.ExecuteNonQuery();

            //    conn.Close();

            //    if (count > 0) return true;
            //    else return false;
            //}
            //catch (Exception)
            //{
                   return false;
            //}
        }

        public List<RoleDTO> loadRoleDAL()
        {
            List<RoleDTO> ls = new List<RoleDTO>();
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                string strTV = "Select MaPhanQuyen, TenVaiTro, MaPhongBan, COUNT(MaTaiKhoan) as SoLuongTK, PhanQuyen.TrangThai " +
                    "From PhanQuyen join VaiTro on PhanQuyen.MaVaiTro=VaiTro.MaVaiTro join BangTaiKhoan on BangTaiKhoan.MaPQ=PhanQuyen.MaPhanQuyen " +
                    "Where PhanQuyen.TrangThai=1 AND VaiTro.TrangThai=1 AND BangTaiKhoan.TrangThai=1 " +
                    "Group by MaPhanQuyen, TenVaiTro, MaPhongBan, PhanQuyen.TrangThai";

                SqlDataReader reader = DataProvider.ThucHienTruyVan(strTV, conn);
                while (reader.Read())
                {
                    RoleDTO roleDTO = new RoleDTO();

                    roleDTO.MaPhanQuyen = reader["MaPhanQuyen"].ToString();
                    roleDTO.TenVaiTro = reader["TenVaiTro"].ToString();
                    roleDTO.MaPhongBan = reader["MaPhongBan"].ToString();
                    roleDTO.SoLuongTK = (int)reader["SoLuongTK"];
                    roleDTO.TrangThai = reader["TrangThai"].ToString() ;

                    ls.Add(roleDTO);
                }
                reader.Close();
                conn.Close();
                return ls;
            }catch (Exception) {
                return ls;
            }
        }
    }
}
