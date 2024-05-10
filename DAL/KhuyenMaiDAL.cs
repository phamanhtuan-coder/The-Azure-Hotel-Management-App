using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class KhuyenMaiDAL
    {
        List<KhuyenMaiDTO> list = new List<KhuyenMaiDTO>();

        public bool AddKhuyenMai(KhuyenMaiDTO khuyenMaiDTO)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlCommand com = new SqlCommand("spThemKhuyenMai", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TenKM", khuyenMaiDTO.TenKM);
                com.Parameters.AddWithValue("@KhuyenMai", khuyenMaiDTO.KhuyenMai);
                com.Parameters.AddWithValue("@MaLoaiHangThanhVien", khuyenMaiDTO.MaLoaiHangThanhVien);

                int count = com.ExecuteNonQuery();
                conn.Close();

                return count>0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditKhuyenMai(KhuyenMaiDTO khuyenMaiDTO)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlCommand com = new SqlCommand("spCapNhatKhuyenMai", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaKM", khuyenMaiDTO.MaKM);
                com.Parameters.AddWithValue("@TenKM", khuyenMaiDTO.TenKM);
                com.Parameters.AddWithValue("@KhuyenMai", khuyenMaiDTO.KhuyenMai);
                com.Parameters.AddWithValue("@MaLoaiHangThanhVien", khuyenMaiDTO.MaLoaiHangThanhVien);

                int count = com.ExecuteNonQuery();
                conn.Close();

                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }      
        public List<KhuyenMaiDTO> LoadDSKhuyenMai()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlCommand com = new SqlCommand("spTruyVanDSKhuyenMai", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                list = new List<KhuyenMaiDTO>();
                while (reader.Read())
                {
                    KhuyenMaiDTO khuyenMaiDTO = new KhuyenMaiDTO();
                    khuyenMaiDTO.MaKM = (int) reader["MaKM"];
                    khuyenMaiDTO.TenKM = reader["TenKM"].ToString();
                    khuyenMaiDTO.KhuyenMai = (decimal)reader["KhuyenMai"];
                    khuyenMaiDTO.MaLoaiHangThanhVien = (int)reader["MaLoaiHangThanhVien"];
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    khuyenMaiDTO.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    list.Add(khuyenMaiDTO);
                }            
                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<KhuyenMaiDTO> ();
            }
        }

        public List<KhuyenMaiDTO> TruyVanSoKhuyenMai()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlCommand com = new SqlCommand("spTruyVanMucKhuyenMai", conn);

                SqlDataReader reader = com.ExecuteReader();
                list = new List<KhuyenMaiDTO>();
                while (reader.Read())
                {
                    KhuyenMaiDTO khuyenMaiDTO = new KhuyenMaiDTO();
                   
                    khuyenMaiDTO.KhuyenMai = (decimal)reader["KhuyenMai"];

                    list.Add(khuyenMaiDTO);
                }
                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<KhuyenMaiDTO>();
            }
        }

        public bool XoaKhuyenMai(int maKM)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlCommand com = new SqlCommand("spCapNhatTTKhuyenMai", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaKM", maKM);
                com.Parameters.AddWithValue("@TrangThai", 0);

                int count = com.ExecuteNonQuery();
                conn.Close();

                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool KhoiPhucKhuyenMai(int maKM)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlCommand com = new SqlCommand("spCapNhatTTKhuyenMai", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaKM", maKM);
                com.Parameters.AddWithValue("@TrangThai", 1);

                int count = com.ExecuteNonQuery();
                conn.Close();

                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<KhuyenMaiDTO> TruyVanIDAndTenKhuyenMai()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlCommand com = new SqlCommand("spMaVaTenKM", conn);

                SqlDataReader reader = com.ExecuteReader();
                list = new List<KhuyenMaiDTO>();
                while (reader.Read())
                {
                    KhuyenMaiDTO khuyenMaiDTO = new KhuyenMaiDTO();

                    khuyenMaiDTO.MaKM = (int) reader["MaKM"];
                    khuyenMaiDTO.TenKM = reader["TenKM"].ToString();

                    list.Add(khuyenMaiDTO);
                }
                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<KhuyenMaiDTO>();
            }
        }
    }
}
