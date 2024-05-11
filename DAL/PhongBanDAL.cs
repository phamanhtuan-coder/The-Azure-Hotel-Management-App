using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhongBanDAL
    {
        //Hàm khôi phục 
        public bool KhoiPhucPhongBan(string maPhongBan)
        {
            string lenhXoaPhongBan =
                "UPDATE PhongBan SET TrangThai = 1 WHERE MaPhongBan = @MaPhongBan";
            SqlParameter parMaPhongBan = new SqlParameter("@MaPhongBan", maPhongBan);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhXoaPhongBan, conn, parMaPhongBan);
            conn.Close();
            return kq > 0;
        }
        //Hàm xóa
        public bool XoaPhongBan(string maPhongBan)
        {
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            SqlCommand com = new SqlCommand("spKiemTraPhanQuyenPB", conn);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@MaPhongBan", maPhongBan);

            int dem = (int)com.ExecuteScalar();
            if (dem == 0)
            {
                string lenhXoaPhongBan =
                "UPDATE PhongBan SET TrangThai = 0 WHERE MaPhongBan = @MaPhongBan";
                SqlParameter parMaPhongBan = new SqlParameter("@MaPhongBan", maPhongBan);
                conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                int kq = DataProvider.ThucHienCauLenh(lenhXoaPhongBan, conn, parMaPhongBan);
                conn.Close();
                return kq > 0;
            }
            else
            {
                return false;
            }
        }
        //Hàm lọc
        public List<PhongBanDTO> FilterTrangThai(bool trangThai)
        {
            List<PhongBanDTO> dsPhongBan = new List<PhongBanDTO>();

            // Create the SQL query with a parameterized filter
            string lenhLayDanhSachPhongBan = "SELECT * FROM PhongBan WHERE TrangThai = @TrangThai";

            // Establish connection
            SqlConnection conn = DataProvider.KetNoiDuLieu();

            conn.Open();

            SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhLayDanhSachPhongBan, conn, "@TrangThai", SqlDbType.Binary, trangThai ? (object)1 : (object)0);
            while (reader.Read())
            {
                PhongBanDTO phongBanDTO = new PhongBanDTO();
                phongBanDTO.MaPhongBan = reader["MaPhongBan"].ToString();
                phongBanDTO.TenPhong = reader["TenPhong"].ToString();
                if (reader["TruongPhong"] == DBNull.Value)
                {
                    phongBanDTO.TruongPhong = 0;
                    phongBanDTO.NgayNhanChuc = DateTime.Now;
                }
                else
                {
                    phongBanDTO.TruongPhong = (int)reader["TruongPhong"];
                    phongBanDTO.NgayNhanChuc = DateTime.Parse(reader["NgayNhanChuc"].ToString());
                }
                phongBanDTO.TrangThai = trangThai;

                dsPhongBan.Add(phongBanDTO);
            }

            return dsPhongBan;
        }

        public List<PhongBanDTO> LayDanhSachPhongBan()
        {
            List<PhongBanDTO> dsPhongBan = new List<PhongBanDTO>();
            string lenhLayDanhSachPhongBan = "SELECT * FROM PhongBan Where TrangThai=1";
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhLayDanhSachPhongBan, conn);
            while (reader.Read())
            {
                PhongBanDTO phongBanDTO = new PhongBanDTO();
                phongBanDTO.MaPhongBan = reader["MaPhongBan"].ToString();
                phongBanDTO.TenPhong = reader["TenPhong"].ToString();
                if (reader["TruongPhong"] == DBNull.Value)
                {
                    phongBanDTO.TruongPhong = 0;
                    phongBanDTO.NgayNhanChuc = DateTime.Now;
                }
                else
                {
                    phongBanDTO.TruongPhong = (int)reader["TruongPhong"];
                    phongBanDTO.NgayNhanChuc = DateTime.Parse(reader["NgayNhanChuc"].ToString());
                }
                byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                bool trangThai = trangThaiBytes[0] == 1;
                phongBanDTO.TrangThai = trangThai;

                dsPhongBan.Add(phongBanDTO);
            }
            reader.Close();
            conn.Close();
            return dsPhongBan;
        }

        public List<PhongBanDTO> LoadIDAndNameDAL()
        {
            List<PhongBanDTO> list = new List<PhongBanDTO>();
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spIDandNamePB", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    PhongBanDTO phongBan = new PhongBanDTO();

                    phongBan.MaPhongBan = reader["MaPhongBan"].ToString();
                    phongBan.TenPhong = reader["TenPhong"].ToString();

                    list.Add(phongBan);
                }

                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<PhongBanDTO>();
            }
        }

        public bool SuaPhongBan(PhongBanDTO phongBanDTO)
        {
            string lenhCapNhatPhongBan =
                "UPDATE PhongBan SET TenPhong = @TenPhong, TruongPhong = @TruongPhong, NgayNhanChuc = @NgayNhanChuc WHERE MaPhongBan = @MaPhongBan";
            SqlParameter[] pars = new SqlParameter[4];

            pars[0] = new SqlParameter("@TenPhong", phongBanDTO.TenPhong);

            if (phongBanDTO.TruongPhong == null)
            {
                pars[1] = new SqlParameter("@TruongPhong", DBNull.Value);
            }
            else
            {
                pars[1] = new SqlParameter("@TruongPhong", phongBanDTO.TruongPhong);
            }

            pars[2] = new SqlParameter("@NgayNhanChuc", phongBanDTO.NgayNhanChuc);
            pars[3] = new SqlParameter("@MaPhongBan", phongBanDTO.MaPhongBan);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhCapNhatPhongBan, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool ThemPhongBanMoi(PhongBanDTO phongBanDTO)
        {
            string lenhThemPhongBan =
                "INSERT INTO PhongBan (MaPhongBan, TenPhong, TruongPhong, NgayNhanChuc, TrangThai) VALUES (@MaPhongBan, @TenPhong, @TruongPhong, @NgayNhanChuc, 1)";

            SqlParameter[] pars = new SqlParameter[4];
            pars[0] = new SqlParameter("MaPhongBan", phongBanDTO.MaPhongBan);
            pars[1] = new SqlParameter("TenPhong", phongBanDTO.TenPhong);
            if (phongBanDTO.TruongPhong == null)
            {
                pars[2] = new SqlParameter("TruongPhong", DBNull.Value);
            }
            else
            {
                pars[2] = new SqlParameter("TruongPhong", phongBanDTO.TruongPhong);
            }
            pars[3] = new SqlParameter("NgayNhanChuc", phongBanDTO.NgayNhanChuc);

            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhThemPhongBan, conn, pars);

            conn.Close();

            return kq > 0;
        }
    }
}
