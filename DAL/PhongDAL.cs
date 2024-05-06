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
        public List<PhongDTO> FilterRooms (DateTime ngayCheckIn, int soLuongKhach, decimal priceMin, decimal priceMax)
        {
            List<PhongDTO> filteredRooms = new List<PhongDTO>();
            try
            {
                
                string query = "SELECT * FROM Phong WHERE SucChuaToiDa>= @SucChua And GiaPhong >= @priceMin AND GiaPhong <= @priceMax AND MaPHG NOT IN (SELECT MAPHG FROM DatPhong WHERE NgayDatPhong = @ngayCheckIn)"; 
                SqlConnection connection = DataProvider.KetNoiDuLieu();
                connection.Open();
                SqlParameter[] pars = new SqlParameter[4];
                pars[0]= new SqlParameter("@SucChua", soLuongKhach);
                pars[1]= new SqlParameter("@priceMin", priceMin);
                pars[2]= new SqlParameter("@priceMax", priceMax);
                pars[3] = new SqlParameter("@ngayCheckIn", ngayCheckIn);
                SqlDataReader reader = DataProvider.ThucHienTruyVan(query, connection, pars);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PhongDTO room = new PhongDTO();
                        room.MaPHG = Convert.ToInt32(reader["MaPHG"]);
                        room.MoTa = reader["MoTa"].ToString();
                        room.GiaPhong = Convert.ToDecimal(reader["GiaPhong"]);
                        room.MoTa = reader["MoTa"].ToString();

                        if (reader["HinhAnh"] != DBNull.Value)
                        {
                            room.HinhAnh = (byte[])reader["HinhAnh"];
                        }
                        else
                        {

                            room.HinhAnh = null;
                        }

                        filteredRooms.Add(room);
                    }
                }
                return filteredRooms;

            }
            catch (Exception ex)
            {   

                throw ex;
            }
         
        
    }

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
                        
                        room.HinhAnh = null;
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
