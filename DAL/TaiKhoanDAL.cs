using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL
    {
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
