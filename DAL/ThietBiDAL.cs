using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThietBiDAL
    {
        public List<ThietBiDTO> FilterTrangThai(bool v)
        {
            List<ThietBiDTO> dstb = new List<ThietBiDTO>();

            string lenhLayDanhSachThietBi = "SELECT * FROM ThietBi WHERE TrangThai = @TrangThai";

            SqlConnection conn = DataProvider.KetNoiDuLieu();

            conn.Open();

            SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhLayDanhSachThietBi, conn, "@TrangThai", SqlDbType.Binary, v ? (object)1 : (object)0);
            while (reader.Read())
            {
                ThietBiDTO tb = new ThietBiDTO();
                tb.MaThietBi = (int)reader["MaThietBi"];
                tb.TenThietBi = reader["TenThietBi"].ToString();
                tb.MaTinhTrangThietBi = (int)reader["MaTinhTrangThietBi"];
                tb.TrangThai = v;

                dstb.Add(tb);
            }

            return dstb;
        }

        public bool khoiphuctbi(int matbi)
        {
           
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            string lenhkhoiphuctbi =
               "UPDATE ThietBi SET TrangThai = 1 WHERE MaThietBi = @MaThietBi";
            SqlParameter par = new SqlParameter("@MaThietBi", matbi);
            int kq = DataProvider.ThucHienCauLenh(lenhkhoiphuctbi, conn, par);
            conn.Close();
            return kq > 0;
        }

        public List<ThietBiDTO> laydstbi()
        {
            List<ThietBiDTO> dstbi = new List<ThietBiDTO>();
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            string strlaydanhsach = "select * from ThietBi where TrangThai = 1";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                ThietBiDTO tb = new ThietBiDTO();
                tb.MaThietBi = (int)reader["MaThietBi"];
                tb.TenThietBi = reader["TenThietBi"].ToString();
                tb.MaTinhTrangThietBi = (int)reader["MaTinhTrangThietBi"];
                byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                bool trangThai = trangThaiBytes[0] == 1;
                tb.TrangThai = trangThai;
                dstbi.Add(tb);
            }
            reader.Close();
            conn.Close();
            return dstbi;
        }


        public bool suatbi(ThietBiDTO thietbi)
        {
            string lenhCapNhattbi =
                "UPDATE ThietBi SET TenThietBi = @TenThietBi,MaTinhTrangThietBi=@MaTinhTrangThietBi WHERE MaThietBi = @MaThietBi";
            SqlParameter[] pars = new SqlParameter[3];

            pars[0] = new SqlParameter("TenThietBi", thietbi.TenThietBi);
            pars[1] = new SqlParameter("MaTinhTrangThietBi", thietbi.MaTinhTrangThietBi);
            pars[2] = new SqlParameter("MaThietBi", thietbi.MaThietBi);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhCapNhattbi, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool ThayDoiTrangThaiThietBiBaoTri(int maThietBi, int maTinhTrangThietBi)
        {
            try
            {
                string strUpdate= " Update ThietBi set MaTinhTrangThietBi = @MaTinhTrangThietBi where MaThietBi = @MaThietBi";
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlCommand comm = new SqlCommand(strUpdate, conn);
                comm.Parameters.AddWithValue("@MaTinhTrangThietBi", maTinhTrangThietBi);
                comm.Parameters.AddWithValue("@MaThietBi", maThietBi);
                int kq = comm.ExecuteNonQuery();
                conn.Close();
                return kq > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool themtbi(ThietBiDTO thietbi)
        {
            string lenhThemtbi=
                "INSERT INTO ThietBi (TenThietBi,MaTinhTrangThietBi,TrangThai) VALUES (@TenThietBi,@MaTinhTrangThietBi, 1)";

            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("TenThietBi", thietbi.TenThietBi);
            pars[1] = new SqlParameter("MaTinhTrangThietBi", thietbi.MaTinhTrangThietBi);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhThemtbi, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool xoatbi(int matbi)
        {
            
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            string lenhXoatbi =
                "UPDATE ThietBi SET TrangThai = 0 WHERE MaThietBi = @MaThietBi";
            SqlParameter par = new SqlParameter("@MaThietBi", matbi);
            int kq = DataProvider.ThucHienCauLenh(lenhXoatbi, conn, par);
            conn.Close();
            return kq > 0;
        }
    }
}
