using DTO;
using System;
using System.Collections.Generic;
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
                if(gioiTinh=="Nam" || gioiTinh == "Nữ")
                {
                    com.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                }
                if (nguoiQuanLy!=-1)
                {
                    com.Parameters.AddWithValue("@MaNQL", nguoiQuanLy);
                }
                if (trangThai == "Đang hoạt động")
                {
                    com.Parameters.AddWithValue("@TrangThai", 1);
                }
                else if(trangThai == "Đã xóa")
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
    }
}
