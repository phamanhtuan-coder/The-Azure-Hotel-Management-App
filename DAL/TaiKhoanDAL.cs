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

        public bool DoiMatKhau(TaiKhoanDTO taiKhoanDTO)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spDoiMatKhau", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaTaiKhoan", taiKhoanDTO.MaTaiKhoan);
                com.Parameters.AddWithValue("@TenDangNhap", taiKhoanDTO.TenDangNhap);
                com.Parameters.AddWithValue("@MatKhau", taiKhoanDTO.MatKhau);
                
                int count = com.ExecuteNonQuery();

                conn.Close();
                if (count > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string EditTaiKhoanDAL(TaiKhoanDTO taiKhoanDTO)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spCapNhatBangTaiKhoan", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaTaiKhoan", taiKhoanDTO.MaTaiKhoan);
                com.Parameters.AddWithValue("@TenDangNhap", taiKhoanDTO.TenDangNhap);
                com.Parameters.AddWithValue("@MatKhau", taiKhoanDTO.MatKhau);
                com.Parameters.AddWithValue("@MaPQ", taiKhoanDTO.MaPQ);


                string user = com.ExecuteScalar().ToString();
                conn.Close();
                return user;
            }
            catch (Exception)
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

        public bool KhoiPhucTaiKhoan(int maTK)
        {
            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            KhachHangDAL KhachHangDAL = new KhachHangDAL();
            try
            {
                int loai=-1;
                int ma=-1;
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spKTKhoiPhucTaiKhoan", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaTaiKhoan", maTK);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    loai = (int) reader["LOAI"];
                    ma = (int)reader["MA"];
                }
                reader.Close();

                com = new SqlCommand("sp_KhoiPhucTaiKhoan", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaTaiKhoan", maTK);               

                int count = com.ExecuteNonQuery();
                conn.Close();
                if (count > 0)
                {
                    if (loai == 1)
                    {
                        nhanVienDAL.KhoiPhucNhanVienDAL(ma);
                    }
                    if (loai == 2)
                    {
                        KhachHangDAL.KhoiPhucNhanVienDAL(ma);
                    }
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
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

        public TaiKhoanDTO XacThuc(TaiKhoanDTO taiKhoanDTO)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spDangNhap", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TenDangNhap", taiKhoanDTO.TenDangNhap);
                com.Parameters.AddWithValue("@MatKhau", taiKhoanDTO.MatKhau);

                SqlDataReader reader= com.ExecuteReader();
                TaiKhoanDTO tai = new TaiKhoanDTO();
                while (reader.Read())
                {
                    tai.MaTaiKhoan = (int) reader["MaTaiKhoan"];
                    tai.TenDangNhap = reader["TenDangNhap"].ToString();
                    tai.MaPQ = reader["MaPQ"].ToString();
                }
                reader.Close();
                conn.Close();

                return tai;
            }
            catch (Exception)
            {
                return new TaiKhoanDTO();
            }
        }

        public bool XoaTaiKhoan(int maTK)
        {
            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            KhachHangDAL KhachHangDAL = new KhachHangDAL();
            try
            {
                int loai = -1;
                int ma = -1;
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spKTTaiKhoanCoThongTin", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaTaiKhoan", maTK);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    loai = (int)reader["LOAI"];
                    ma = (int)reader["MA"];
                }
                reader.Close();
                com = new SqlCommand("sp_XoaTaiKhoan", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaTaiKhoan", maTK);

                int count = com.ExecuteNonQuery();
                conn.Close();
                if (count > 0)
                {
                    if (loai == 1)
                    {
                        nhanVienDAL.XoaNhanVienDAL(ma);
                    }
                    if (loai == 2)
                    {
                        KhachHangDAL.XoaNhanVienDAL(ma);
                    }
                    return true;                    
                }
                return false;
                
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
