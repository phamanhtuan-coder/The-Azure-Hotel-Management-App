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
    public class DichVuDAL
    {
        public bool khoiphucdvu(int madvu)
        {
            string lenhkhoiphucdvu =
               "UPDATE DichVu SET TrangThai = 1 WHERE MaDV = @MaDV";
            SqlParameter par = new SqlParameter("@MaDV", madvu);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhkhoiphucdvu, conn, par);
            conn.Close();
            return kq > 0;
        }

        public bool Xoadichvu(int madvu)
        {
            string lenhXoadvu =
               "UPDATE DichVu SET TrangThai = 0 WHERE MaDV = @MaDV";
            SqlParameter par = new SqlParameter("@MaDV", madvu);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhXoadvu, conn, par);
            conn.Close();
            return kq > 0;
        }

        public List<DichVuDTO> FilterTrangThai(bool v)
        {
            List<DichVuDTO> dsdvu = new List<DichVuDTO>();

            string lenhLayDanhSachvu = "SELECT * FROM DichVu WHERE TrangThai = @TrangThai";

            SqlConnection conn = DataProvider.KetNoiDuLieu();

            conn.Open();

            SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhLayDanhSachvu, conn, "@TrangThai", SqlDbType.Binary, v ? (object)1 : (object)0);
            while (reader.Read())
            {
                DichVuDTO dichVu = new DichVuDTO();
                dichVu.MaDV = (int)reader[0];
                dichVu.TenDV = reader[1].ToString();
                dichVu.GiaDV =decimal.Parse(reader[2].ToString());
                dichVu.TrangThai = v;

                dsdvu.Add(dichVu);
            }

            return dsdvu;
        }

        public List<DichVuDTO> layDSDVu()
        {

            List<DichVuDTO> dsdvu = new List<DichVuDTO>();
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            string strlaydanhsach = "select * from DichVu ";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                DichVuDTO dv = new DichVuDTO();
                dv.MaDV = (int)reader["MaDV"];
                dv.TenDV = reader["TenDV"].ToString();
                dv.GiaDV = (decimal)reader["GiaDV"];
                byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                bool trangThai = trangThaiBytes[0] == 1;
                dv.TrangThai = trangThai;
                dsdvu.Add(dv);
            }
            reader.Close();
            conn.Close();
            return dsdvu;
        }
        public List<DichVuDTO> layDSDVu2()
        {

            List<DichVuDTO> dsdvu = new List<DichVuDTO>();
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            string strlaydanhsach = "select * from DichVu where TrangThai = 1";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                DichVuDTO dv = new DichVuDTO();
                dv.MaDV = (int)reader["MaDV"];
                dv.TenDV = reader["TenDV"].ToString();
                dv.GiaDV = (decimal)reader["GiaDV"];
                byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                bool trangThai = trangThaiBytes[0] == 1;
                dv.TrangThai = trangThai;
                dsdvu.Add(dv);
            }
            reader.Close();
            conn.Close();
            return dsdvu;
        }

        public bool suadvu(DichVuDTO dichVu)
        {
            string lenhCapNhatdvu =
                "UPDATE DichVu SET TenDV = @TenDV, GiaDV = @GiaDV WHERE MaDV = @MaDV";
            SqlParameter[] pars = new SqlParameter[3];

            pars[0] = new SqlParameter("MaDV", dichVu.MaDV);
            pars[1] = new SqlParameter("TenDV", dichVu.TenDV);
            pars[2] = new SqlParameter("GiaDV", dichVu.GiaDV);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhCapNhatdvu, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool themdvu(DichVuDTO dichVu)
        {
            string lenhThemdichvu =
                "INSERT INTO DichVu (TenDV, GiaDV,TrangThai) VALUES (@TenDV, @GiaDV, 1)";

            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("TenDV", dichVu.TenDV);
            pars[1] = new SqlParameter("GiaDV", dichVu.GiaDV);

            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhThemdichvu, conn, pars);
            conn.Close();
            return kq > 0;

        }
    }
}
