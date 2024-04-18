using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhongDAL
    {
        public List<PhongDTO> GetAvailableRooms()
        {
            List<PhongDTO> rooms = new List<PhongDTO>();

            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                string lenhTVPhongTrong = "SELECT * FROM Phong WHERE TrangThai = 0x01";

                SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhTVPhongTrong, conn);

                while (reader.Read())
                {
                    PhongDTO room = new PhongDTO();
                    room.MaPHG = Convert.ToInt32(reader["MaPHG"]);
                    room.MoTa = reader["MoTa"].ToString();
                    room.GiaPhong = Convert.ToDecimal(reader["GiaPhong"]);
                    room.MoTa = reader["MoTa"].ToString();

                    // Check for DBNull before casting to byte[]
                    if (reader["HinhAnh"] != DBNull.Value)
                    {
                        room.HinhAnh = (byte[])reader["HinhAnh"];
                    }
                    else
                    {
                        // Handle DBNull case, maybe assign a default image or null to the HinhAnh property
                        room.HinhAnh = null; // or assign a default byte array
                    }

                    rooms.Add(room);
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return rooms;
        }

    }
}
