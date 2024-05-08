using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHoaDonDAL
    {
        List<ChiTietHoaDonDTO> list = new List<ChiTietHoaDonDTO>();

        public bool ThayDoiTrangThai(int maDP, int v)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();

                conn.Open();

                SqlCommand com = new SqlCommand("spThayDoiTTChiTiet", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaCTHD", maDP);
                com.Parameters.AddWithValue("@TrangThai", v);
                
                int count = com.ExecuteNonQuery();
                conn.Close();
                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ChiTietHoaDonDTO> TruyVanChiTiet(int maHoaDon)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();

                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanChiTiet", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaHD",maHoaDon);
                SqlDataReader reader = com.ExecuteReader();
                list = new List<ChiTietHoaDonDTO>();
                while (reader.Read())
                {
                    ChiTietHoaDonDTO chiTiet = new ChiTietHoaDonDTO();
                    chiTiet.MaCTHD = (int)reader["MaCTHD"];
                    chiTiet.MaHD = (int)reader["MaHD"];
                    chiTiet.MaDatPhong = (int)reader["MaDatPhong"];
                    chiTiet.MaKhuyenMai = (int)reader["MaKhuyenMai"];
                    chiTiet.ThanhTien = (decimal)reader["ThanhTien"];
                    chiTiet.TrangThai = true;
                    list.Add(chiTiet);
                }
                reader.Close();
                conn.Close();     
                return list;
            }
            catch (Exception)
            {
                return new List<ChiTietHoaDonDTO>();
            }
        }

        public List<ChiTietHoaDonDTO> TruyVanChiTietDaXoa(int maHoaDon)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();

                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanChiTietDaXoa", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaHD", maHoaDon);
                SqlDataReader reader = com.ExecuteReader();
                list = new List<ChiTietHoaDonDTO>();
                while (reader.Read())
                {
                    ChiTietHoaDonDTO chiTiet = new ChiTietHoaDonDTO();
                    chiTiet.MaCTHD = (int)reader["MaCTHD"];
                    chiTiet.MaHD = (int)reader["MaHD"];
                    chiTiet.MaDatPhong = (int)reader["MaDatPhong"];
                    chiTiet.MaKhuyenMai = (int)reader["MaKhuyenMai"];
                    chiTiet.ThanhTien = (decimal)reader["ThanhTien"];
                    chiTiet.TrangThai = true;
                    list.Add(chiTiet);
                }
                reader.Close();
                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<ChiTietHoaDonDTO>();
            }
        }

        public List<ChiTietHoaDonDTO> TruyVanDSChiTiet()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();

                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanDSChiTiet", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                list = new List<ChiTietHoaDonDTO>();
                while (reader.Read())
                {
                    ChiTietHoaDonDTO chiTiet = new ChiTietHoaDonDTO();
                    chiTiet.MaCTHD = (int)reader["MaCTHD"];
                    chiTiet.MaHD = (int)reader["MaHD"];
                    chiTiet.MaDatPhong = (int)reader["MaDatPhong"];
                    chiTiet.MaKhuyenMai = (int)reader["MaKhuyenMai"];
                    chiTiet.ThanhTien = (decimal)reader["ThanhTien"];
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    chiTiet.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    list.Add(chiTiet);
                }
                reader.Close();
                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<ChiTietHoaDonDTO>();
            }
        }
    }
}
