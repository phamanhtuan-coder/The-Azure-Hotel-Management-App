using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class NhanVienDAL
    {
        List<NhanVienDTO> list = new List<NhanVienDTO>();

        public bool AddNhanVienDAL(NhanVienDTO nhanvien)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("sp_ThemNhanVien", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                if (nhanvien.MaNQL!= -1)
                {
                    com.Parameters.AddWithValue("@MaNQL", nhanvien.MaNQL);
                }             
                com.Parameters.AddWithValue("@TenTaiKhoan", nhanvien.TenTaiKhoan);
                com.Parameters.AddWithValue("@HinhAnh", nhanvien.HinhAnh);
                com.Parameters.AddWithValue("@HoTenNV", nhanvien.HoTenNV);
                com.Parameters.AddWithValue("@SDT", nhanvien.SDT);
                com.Parameters.AddWithValue("@Email", nhanvien.Email);
                com.Parameters.AddWithValue("@CCCD", nhanvien.CCCD);
                com.Parameters.AddWithValue("@NgaySinh", nhanvien.NgaySinh);
                com.Parameters.AddWithValue("@DiaChi", nhanvien.DiaChi);
                com.Parameters.AddWithValue("@Luong", nhanvien.Luong);
                com.Parameters.AddWithValue("@GioiTinh", nhanvien.GioiTinh);
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

        public bool EditNhanVienDAL(NhanVienDTO nhanvien)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("sp_CapNhatNhanVien", conn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaNhanVien", nhanvien.MaNV);
                com.Parameters.AddWithValue("@MaNQL", nhanvien.MaNQL);
                com.Parameters.AddWithValue("@TenTaiKhoan", nhanvien.TenTaiKhoan);
                com.Parameters.AddWithValue("@HinhAnh", nhanvien.HinhAnh);
                com.Parameters.AddWithValue("@HoTenNV", nhanvien.HoTenNV);
                com.Parameters.AddWithValue("@SDT", nhanvien.SDT);
                com.Parameters.AddWithValue("@Email", nhanvien.Email);
                com.Parameters.AddWithValue("@CCCD", nhanvien.CCCD);
                com.Parameters.AddWithValue("@NgaySinh", nhanvien.NgaySinh);
                com.Parameters.AddWithValue("@DiaChi", nhanvien.DiaChi);
                com.Parameters.AddWithValue("@Luong", nhanvien.Luong);
                com.Parameters.AddWithValue("@GioiTinh", nhanvien.GioiTinh);

                int count = com.ExecuteNonQuery();
                conn.Close();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaNhanVienDAL(int maNV)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("sp_CapNhatTrangThaiNhanVien", conn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaNhanVien", maNV);
                
                int count = com.ExecuteNonQuery();
                conn.Close();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool KhoiPhucNhanVienDAL(int maNV)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("sp_KhoiPhucTrangThaiNhanVien", conn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaNhanVien", maNV);

                int count = com.ExecuteNonQuery();
                conn.Close();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<NhanVienDTO> Filter(int phanQuyen, string phongBan, string gioiTinh, int nguoiQuanLy, string trangThai)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spFILTER", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                if (phanQuyen != -1)
                {
                    com.Parameters.AddWithValue("@MaVaiTro", phanQuyen);
                }
                if (phongBan != "00")
                {
                    com.Parameters.AddWithValue("@MaPhongBan", phongBan);
                }
                if (gioiTinh == "Nam" || gioiTinh == "Nữ")
                {
                    com.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                }
                if (nguoiQuanLy != -1)
                {
                    com.Parameters.AddWithValue("@MaNQL", nguoiQuanLy);
                }
                if (trangThai == "Đang hoạt động")
                {
                    com.Parameters.AddWithValue("@TrangThai", 1);
                }
                else if (trangThai == "Đã xóa")
                {
                    com.Parameters.AddWithValue("@TrangThai", 0);
                }
                SqlDataReader reader = com.ExecuteReader();
                list = new List<NhanVienDTO>();
                while (reader.Read())
                {
                    NhanVienDTO nhanVien = new NhanVienDTO();

                    nhanVien.MaNV = (int)(reader["MaNV"]);
                    nhanVien.MaNQL = reader["MaNQL"] as int?;
                    nhanVien.MaTaiKhoan = (int)(reader["MaTaiKhoan"]);
                    nhanVien.TenTaiKhoan = (string)(reader["TenDangNhap"]);
                    nhanVien.HinhAnh = reader["HinhAnh"] as byte[];
                    nhanVien.HoTenNV = reader["HoTenNV"] as string;
                    nhanVien.SDT = reader["SDT"] as string;
                    nhanVien.Email = reader["Email"] as string;
                    nhanVien.CCCD = reader["CCCD"] as string;
                    nhanVien.NgaySinh = (DateTime)reader["NgaySinh"];
                    nhanVien.DiaChi = reader["DiaChi"] as string;
                    nhanVien.Luong = (decimal)reader["Luong"];
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    nhanVien.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    nhanVien.GioiTinh = reader["GioiTinh"].ToString();

                    list.Add(nhanVien);
                }

                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<NhanVienDTO>();
            }
        }

        public List<NhanVienDTO> LoadIDAndNameDAL()
        {            
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanNhanVienQuanLy", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                list = new List<NhanVienDTO>();
                while (reader.Read())
                {
                    NhanVienDTO nhanVien = new NhanVienDTO();

                    nhanVien.MaNV = (int) reader["MaNV"];
                    nhanVien.HoTenNV = reader["HoTenNV"].ToString();

                    list.Add(nhanVien);
                }

                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<NhanVienDTO>();
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
                string user = (string) com.ExecuteScalar();                
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
