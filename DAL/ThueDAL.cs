using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThueDAL
    {
        List<ThueDTO> list = new List<ThueDTO>();

        public List<ThueDTO> TruyVanDSThue()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanDSThue", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                list = new List<ThueDTO>();
                while (reader.Read())
                {
                    ThueDTO thueDTO = new ThueDTO();

                    thueDTO.MaThue = (int)reader["MaThue"];
                    thueDTO.TenThue = reader["TenThue"].ToString();
                    thueDTO.TyLeThue = (double) reader["TyLeThue"] ;
                    thueDTO.MoTa = reader["MoTa"].ToString();
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    thueDTO.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);

                    list.Add(thueDTO);
                }

                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<ThueDTO>();
            }
        }

        public List<ThueDTO> TruyVanTenVaMaThue()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanTenVaMaThue", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                list = new List<ThueDTO>();
                while (reader.Read())
                {
                    ThueDTO thueDTO = new ThueDTO();

                    thueDTO.MaThue = (int)reader["MaThue"];
                    thueDTO.TenThue = reader["TenThue"].ToString();

                    list.Add(thueDTO);
                }

                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<ThueDTO>();
            }
        }
    }
}
