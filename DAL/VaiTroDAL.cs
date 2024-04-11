using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VaiTroDAL
    {
        List<VaiTroDTO> list= new List<VaiTroDTO>();
        public List<VaiTroDTO> LoadDSRoleDAL()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("sp_DSAllVaiTro", conn);
                SqlDataReader reader = com.ExecuteReader();
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
    }
}
