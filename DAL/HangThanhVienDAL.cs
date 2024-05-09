using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HangThanhVienDAL
    {
        List<HangThanhVienDTO> list = new List<HangThanhVienDTO>();

        public bool AddHangThanhVien(HangThanhVienDTO hangThanhVienDTO)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spThemHangThanhVien", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TenHang", hangThanhVienDTO.TenHang);
                com.Parameters.AddWithValue("@MucGiamGia", hangThanhVienDTO.MucGiamGia);

                int count = com.ExecuteNonQuery();
                conn.Close();
                if (count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditHangThanhVien(HangThanhVienDTO hangThanhVienDTO)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spCapNhatHangThanhVien", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaLoaiHangThanhVien", hangThanhVienDTO.MaLoaiHangThanhVien);
                com.Parameters.AddWithValue("@TenHang", hangThanhVienDTO.TenHang);
                com.Parameters.AddWithValue("@MucGiamGia", hangThanhVienDTO.MucGiamGia);

                int count = com.ExecuteNonQuery();
                conn.Close();
                if (count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DelHangThanhVien(HangThanhVienDTO hangThanhVienDTO)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spSoLuongKhachHang", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaLoaiHangThanhVien", hangThanhVienDTO.MaLoaiHangThanhVien);

                int dem = (int)com.ExecuteScalar();
                if (dem == 0)
                {
                    com = new SqlCommand("spXoatHangThanhVien", conn);
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@MaLoaiHangThanhVien", hangThanhVienDTO.MaLoaiHangThanhVien);

                    int count = com.ExecuteNonQuery();
                    conn.Close();
                    if (count > 0)
                    {
                        return true;
                    }
                    else return false;
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

        public bool RecoHangThanhVien(HangThanhVienDTO hangThanhVienDTO)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spKhoiPhuctHangThanhVien", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaLoaiHangThanhVien", hangThanhVienDTO.MaLoaiHangThanhVien);

                int count = com.ExecuteNonQuery();
                conn.Close();
                if (count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<HangThanhVienDTO> Filer(string trangthai)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spDSHangThanhVien", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                if (trangthai == "Đang hoạt động")
                {
                    com.Parameters.AddWithValue("@TrangThai", 1);
                }
                else if (trangthai == "Đã xóa")
                {
                    com.Parameters.AddWithValue("@TrangThai", 0);
                }
                
                SqlDataReader reader = com.ExecuteReader();
                list = new List<HangThanhVienDTO>();
                while (reader.Read())
                {
                    HangThanhVienDTO hangThanhVienDTO = new HangThanhVienDTO();
                    hangThanhVienDTO.MaLoaiHangThanhVien = (int) reader["MaLoaiHangThanhVien"];
                    hangThanhVienDTO.TenHang = (string)reader["TenHang"];
                    hangThanhVienDTO.MucGiamGia = (double)reader["MucGiamGia"];
                    hangThanhVienDTO.SoLuong = (int)reader["SoLuong"];
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    hangThanhVienDTO.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    list.Add(hangThanhVienDTO);
                }
                reader.Close();
                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<HangThanhVienDTO>();
            }
        }

        public List<HangThanhVienDTO> LoadIDAndNameBLL()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spIDandNameHangThanhVien", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                list = new List<HangThanhVienDTO>();
                while (reader.Read())
                {
                    HangThanhVienDTO hangThanhVienDTO = new HangThanhVienDTO();

                    hangThanhVienDTO.MaLoaiHangThanhVien = (int)reader["MaLoaiHangThanhVien"];
                    hangThanhVienDTO.TenHang = reader["TenHang"].ToString();

                    list.Add(hangThanhVienDTO);
                }

                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<HangThanhVienDTO>();
            }
        }

        public double LayKM(int maKH)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spLayKhuyenMai", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaKH",maKH);
                double km = (double) com.ExecuteScalar();

                conn.Close();
                return km;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
