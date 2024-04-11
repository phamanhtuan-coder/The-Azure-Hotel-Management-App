using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VaiTroDAL
    {
        List<VaiTroDTO> list= new List<VaiTroDTO>();

        public bool AddVaiTroDAL(VaiTroDTO vaiTroDTO)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spThemVaiTro", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TenVaiTro", vaiTroDTO.TenVaiTro);
                com.Parameters.AddWithValue("@MoTa", vaiTroDTO.MoTa);
                int count= com.ExecuteNonQuery();
                conn.Close();

                if (count > 0) return true;
                else return false;
            } catch (Exception) 
            {
                return false;
            }
        }

        public List<VaiTroDTO> LoadDSRoleDAL()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("sp_DSAllVaiTro", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                list = new List<VaiTroDTO>();
                while (reader.Read())
                {
                    VaiTroDTO vaiTroDTO = new VaiTroDTO();
                    vaiTroDTO.MaVaiTro = (int) reader["MaVaiTro"];
                    vaiTroDTO.TenVaiTro = reader["TenVaiTro"].ToString();
                    vaiTroDTO.MoTa = reader["MoTa"].ToString();
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    vaiTroDTO.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    list.Add(vaiTroDTO);
                }

                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<VaiTroDTO> ();
            }
        }

        public List<VaiTroDTO> LoadDSRoleTTDAL(int i)
        {
            list= new List<VaiTroDTO> ();
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("sp_DSAllVaiTroTT", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TrangThai", i);
                SqlDataReader reader = com.ExecuteReader();
                list = new List<VaiTroDTO>();
                while (reader.Read())
                {
                    VaiTroDTO vaiTroDTO = new VaiTroDTO();
                    vaiTroDTO.MaVaiTro = (int)reader["MaVaiTro"];
                    vaiTroDTO.TenVaiTro = reader["TenVaiTro"].ToString();
                    vaiTroDTO.MoTa = reader["MoTa"].ToString();
                    vaiTroDTO.TrangThai = (i==1?true:false);
                    list.Add(vaiTroDTO);
                }

                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<VaiTroDTO>();
            }
        }
    }
}
