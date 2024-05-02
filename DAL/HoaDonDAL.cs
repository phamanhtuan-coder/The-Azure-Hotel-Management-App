using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        List<HoaDonDTO> hoaDonDTOs = new List<HoaDonDTO>();
        public List<HoaDonDTO> TruyVanDanhSachHoaDon()
        {
            hoaDonDTOs= new List<HoaDonDTO>();
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
              
                SqlCommand com = new SqlCommand("spTruyVanHoaDon",conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    HoaDonDTO hoaDonDTO = new HoaDonDTO();
                    hoaDonDTO.MaHoaDon = (int) reader["MaHoaDon"];
                    hoaDonDTO.MaKH = (int) reader["MaKH"];
                    hoaDonDTO.MaNV = (int) reader["MaNV"];
                    hoaDonDTO.MaThue = (int) reader["MaThue"];
                    hoaDonDTO.NgayLapHoaDon = (DateTime)reader["NgayLapHoaDon"];
                    hoaDonDTO.TongHoaDon = (decimal) reader["TongHoaDon"];
                    hoaDonDTO.TienNhan = (decimal) reader["TienNhan"];
                    hoaDonDTO.TienThoi = (decimal) reader["TienThoi"];
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    hoaDonDTO.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    hoaDonDTOs.Add(hoaDonDTO);
                }

                conn.Close();
                return hoaDonDTOs;
            }
            catch (Exception)
            {
                return new List<HoaDonDTO>();
            }
        }
    }
}
