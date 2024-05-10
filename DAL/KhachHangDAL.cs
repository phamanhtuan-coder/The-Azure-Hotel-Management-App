using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
        List<KhachHangDTO> list = new List<KhachHangDTO> ();

        public bool AddKhachHangDAL(KhachHangDTO khachHang)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("sp_ThemKhachHang", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@MaLoaiHangThanhVien", khachHang.MaLoaiHangThanhVien);
                com.Parameters.AddWithValue("@TenTaiKhoan", khachHang.TenDangNhap);
                com.Parameters.AddWithValue("@HinhAnh", khachHang.HinhAnh);
                com.Parameters.AddWithValue("@HoTenKH", khachHang.HoTenKH);
                com.Parameters.AddWithValue("@SDT", khachHang.SDT);
                com.Parameters.AddWithValue("@Email", khachHang.Email);
                com.Parameters.AddWithValue("@CCCD", khachHang.CCCD);
                com.Parameters.AddWithValue("@NgaySinh", khachHang.NgaySinh);
                com.Parameters.AddWithValue("@DiaChi", khachHang.DiaChi);
                com.Parameters.AddWithValue("@GioiTinh", khachHang.GioiTinh);

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

        public bool AddKhachHangDAL(TaiKhoanDTO taiKhoanDTO, KhachHangDTO khachHangDTO)
        {
            khachHangDTO.TenDangNhap=taiKhoanDAL.AddTaiKhoanDAL(taiKhoanDTO);
            if (!string.IsNullOrWhiteSpace(khachHangDTO.TenDangNhap.Trim()))
            {
                return AddKhachHangDAL(khachHangDTO);
            }
            else
            {
                return false;
            }
        }

        public bool EditKhachHangDAL(KhachHangDTO khachHang)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("sp_SuaKhachHang", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@MaKH", khachHang.MaKH);
                com.Parameters.AddWithValue("@MaLoaiHangThanhVien", khachHang.MaLoaiHangThanhVien);
                com.Parameters.AddWithValue("@TenTaiKhoan", khachHang.TenDangNhap);
                com.Parameters.AddWithValue("@HinhAnh", khachHang.HinhAnh);
                com.Parameters.AddWithValue("@HoTenKH", khachHang.HoTenKH);
                com.Parameters.AddWithValue("@SDT", khachHang.SDT);
                com.Parameters.AddWithValue("@Email", khachHang.Email);
                com.Parameters.AddWithValue("@CCCD", khachHang.CCCD);
                com.Parameters.AddWithValue("@NgaySinh", khachHang.NgaySinh);
                com.Parameters.AddWithValue("@DiaChi", khachHang.DiaChi);
                com.Parameters.AddWithValue("@GioiTinh", khachHang.GioiTinh);

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

        public List<KhachHangDTO> Filter(int maHang, string gioiTinh, string tT)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spFILTER_KH", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                if (maHang != -1)
                {
                    com.Parameters.AddWithValue("@MaLoaiHangThanhVien", maHang);
                }
                if (gioiTinh == "Nam" || gioiTinh == "Nữ")
                {
                    com.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                }
                if (tT == "Đang hoạt động")
                {
                    com.Parameters.AddWithValue("@TrangThai", 1);
                }
                else if (tT == "Đã xóa")
                {
                    com.Parameters.AddWithValue("@TrangThai", 0);
                }
                SqlDataReader reader = com.ExecuteReader();
                list = new List<KhachHangDTO>();
                while (reader.Read())
                {
                    KhachHangDTO khachHang = new KhachHangDTO();

                    khachHang.MaKH = (int) reader["MaKH"];
                    khachHang.MaTaiKhoan = (int) reader["MaTaiKhoan"];
                    khachHang.TenDangNhap = (string)reader["TenDangNhap"];
                    khachHang.MaLoaiHangThanhVien = (int) reader["MaLoaiHangThanhVien"];
                    khachHang.TenHang= (string)reader["TenHang"];
                    khachHang.HinhAnh = reader["HinhAnh"] as byte[];
                    khachHang.HoTenKH = reader["HoTenKH"].ToString();
                    khachHang.Email = reader["Email"].ToString();
                    khachHang.CCCD = reader["CCCD"].ToString();
                    khachHang.NgaySinh = (DateTime) reader["NgaySinh"];
                    khachHang.DiaChi = reader["DiaChi"].ToString();
                    khachHang.SDT = reader["SDT"].ToString();
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    khachHang.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    khachHang.GioiTinh = reader["GioiTinh"].ToString();

                    list.Add(khachHang);
                }

                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<KhachHangDTO>();
            }
        }

        public bool KhoiPhucNhanVienDAL(int maKH)
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("sp_KhoiPhucTrangThaiKhachHang", conn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaKhachHang", maKH);

                int count = com.ExecuteNonQuery();
                

                if (count > 0)
                {
                    com = new SqlCommand("spLayMaTaiKhoan", conn);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Loai", 2);
                    com.Parameters.AddWithValue("@Ma", maKH);

                    int tam = (int)com.ExecuteScalar();
                    taiKhoanDAL.KhoiPhucTaiKhoan(tam);
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<KhachHangDTO> LoadIDvaNameKH()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanIDVaTenKH", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
               
                SqlDataReader reader = com.ExecuteReader();
                list = new List<KhachHangDTO>();
                while (reader.Read())
                {
                    KhachHangDTO khachHang = new KhachHangDTO();

                    khachHang.MaKH = (int)reader["MaKH"];
                    khachHang.HoTenKH = reader["HoTenKH"].ToString();

                    list.Add(khachHang);
                }

                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<KhachHangDTO>();
            }
        }

        public KhachHangDTO TimKH(int maTaiKhoan)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTimKH", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
              
                com.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);            
                SqlDataReader reader = com.ExecuteReader();
                KhachHangDTO khachHang = new KhachHangDTO();
                while (reader.Read())
                {
                    khachHang.MaKH = (int)reader["MaKH"];
                    khachHang.MaTaiKhoan = (int)reader["MaTaiKhoan"];
                    khachHang.MaLoaiHangThanhVien = (int)reader["MaLoaiHangThanhVien"];
                    khachHang.HinhAnh = reader["HinhAnh"] as byte[];
                    khachHang.HoTenKH = reader["HoTenKH"].ToString();
                    khachHang.Email = reader["Email"].ToString();
                    khachHang.CCCD = reader["CCCD"].ToString();
                    khachHang.NgaySinh = (DateTime)reader["NgaySinh"];
                    khachHang.DiaChi = reader["DiaChi"].ToString();
                    khachHang.SDT = reader["SDT"].ToString();
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    khachHang.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    khachHang.GioiTinh = reader["GioiTinh"].ToString();
                }

                conn.Close();
                return khachHang;
            }
            catch (Exception)
            {
                return new KhachHangDTO();
            }
        }

        public TaiKhoanDTO XacThuc(KhachHangDTO khachHangDTO)
        {
            TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();

            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spXacThuc", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@Email", khachHangDTO.Email);
                com.Parameters.AddWithValue("@CCCD", khachHangDTO.CCCD);

                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    taiKhoanDTO.MaTaiKhoan = (int)reader["MaTaiKhoan"];
                    taiKhoanDTO.TenDangNhap = reader["TenDangNhap"].ToString();
                }

                conn.Close();
                return taiKhoanDTO;
            }
            catch (Exception)
            {
                return new TaiKhoanDTO();
            }
        }


        public bool XoaNhanVienDAL(int maKH)
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("sp_CapNhatTrangThaiKhachHang", conn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaKhachHang", maKH);

                int count = com.ExecuteNonQuery();

                if (count > 0)
                {
                    com = new SqlCommand("spLayMaTaiKhoan", conn);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Loai", 2);
                    com.Parameters.AddWithValue("@Ma", maKH);

                    int tam = (int) com.ExecuteScalar();
                    taiKhoanDAL.XoaTaiKhoan(tam); 
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
