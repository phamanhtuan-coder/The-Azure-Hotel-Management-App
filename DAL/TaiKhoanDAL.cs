using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DAL
{
    public class TaiKhoanDAL
    {
        List<TaiKhoanDTO> list;
        public string AddTaiKhoanDAL(TaiKhoanDTO taiKhoanDTO)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("sp_AddTaiKhoan", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TenDangNhap", taiKhoanDTO.TenDangNhap);
                com.Parameters.AddWithValue("@MatKhau", taiKhoanDTO.MatKhau);
                com.Parameters.AddWithValue("@MaPQ", taiKhoanDTO.MaPQ);

                
                string user= com.ExecuteScalar().ToString();
                conn.Close();
                return user;
            }catch (Exception)
            {
                return "";
            }
        }

        public List<TaiKhoanDTO> Filter()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlCommand com = new SqlCommand("spTruyVanBangTaiKhoan", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;                           
                SqlDataReader reader = com.ExecuteReader();
                list = new List<TaiKhoanDTO>();

                while (reader.Read())
                {
                    TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();

                    taiKhoanDTO.MaTaiKhoan = (int) reader["MaTaiKhoan"];
                    taiKhoanDTO.TenDangNhap = reader["TenDangNhap"].ToString();
                    taiKhoanDTO.MatKhau = reader["MatKhau"].ToString();
                    taiKhoanDTO.NgayTao = (DateTime) reader["NgayTao"];
                    taiKhoanDTO.MaPQ = reader["MaPQ"].ToString();
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    taiKhoanDTO.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);

                    list.Add(taiKhoanDTO);
                }

                reader.Close();
                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<TaiKhoanDTO>();
            }
        }

        public string TruyVanUsernameDAL()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("sp_TruyVanUsername", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                string user = (string)com.ExecuteScalar();
                conn.Close();
                return user;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
