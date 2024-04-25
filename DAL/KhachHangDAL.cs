using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        List<KhachHangDTO> list = new List<KhachHangDTO> ();
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
    }
}
