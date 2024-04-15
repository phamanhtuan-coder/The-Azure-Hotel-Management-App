using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TTThietBiDAL
    {
        public static bool khoiphucTTTbi(int maTTTBi)
        {
            string lenhXoaTTTBi =
               "UPDATE TinhTrangThietBi SET TrangThai = 1 WHERE MaTinhTrangThietBi = @MaTinhTrangThietBi";
            SqlParameter par = new SqlParameter("@MaTinhTrangThietBi", maTTTBi);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhXoaTTTBi, conn, par);
            conn.Close();
            return kq > 0;
        }

        public static bool XoaTTTbi(int maTTTBi)
        {
            string lenhXoaTTTBi =
               "UPDATE TinhTrangThietBi SET TrangThai = 0 WHERE MaTinhTrangThietBi = @MaTinhTrangThietBi";
            SqlParameter par = new SqlParameter("@MaTinhTrangThietBi", maTTTBi);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhXoaTTTBi, conn, par);
            conn.Close();
            return kq > 0;
        }

        public List<TTThietBiDTO> FilterTrangThai(bool v)
        {
            List<TTThietBiDTO> dstttbi = new List<TTThietBiDTO>();

            string lenhLayDanhSachtttbi = "SELECT * FROM TinhTrangThietBi WHERE TrangThai = @TrangThai";

            SqlConnection conn = DataProvider.KetNoiDuLieu();

            conn.Open();

            SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhLayDanhSachtttbi, conn, "@TrangThai", SqlDbType.Binary, v ? (object)1 : (object)0);
            while (reader.Read())
            {
                TTThietBiDTO tTThietBi = new TTThietBiDTO();
                tTThietBi.MaTinhTrangThietBi = (int)reader[0];
                tTThietBi.TenTinhTrang = reader[1].ToString();
                tTThietBi.MoTa = reader[2].ToString();
                tTThietBi.TrangThai = v;

                dstttbi.Add(tTThietBi);
            }

            return dstttbi;
        }

        public List<TTThietBiDTO> layDSTBi()
        {

            List<TTThietBiDTO> dslp = new List<TTThietBiDTO>();
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            string strlaydanhsach = "select * from TinhTrangThietBi";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                TTThietBiDTO tTThietBi = new TTThietBiDTO();
                tTThietBi.MaTinhTrangThietBi = (int)reader[0];
                tTThietBi.TenTinhTrang = reader[1].ToString();
                tTThietBi.MoTa = reader[2].ToString();
                byte[] trangThaiBytes = (byte[])reader[3];
                bool trangThai = trangThaiBytes[0] == 1;
                tTThietBi.TrangThai = trangThai;
                dslp.Add(tTThietBi);
            }
            reader.Close();
            conn.Close();
            return dslp;
        }

        public bool suaTTTbi(TTThietBiDTO tTThietBiDTO)
        {
            string lenhCapNhatTTTBi =
                "UPDATE TinhTrangThietBi SET TenTinhTrang = @TenTinhTrang, MoTa = @MoTa WHERE MaTinhTrangThietBi = @MaTinhTrangThietBi";
            SqlParameter[] pars = new SqlParameter[3];

            pars[0] = new SqlParameter("TenTinhTrang", tTThietBiDTO.TenTinhTrang);
            pars[1] = new SqlParameter("MoTa", tTThietBiDTO.MoTa);
            pars[2] = new SqlParameter("MaTinhTrangThietBi", tTThietBiDTO.MaTinhTrangThietBi);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhCapNhatTTTBi, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool themTTTbi(TTThietBiDTO tTThietBiDTO)
        {
            string lenhThemTTTBi =
                "INSERT INTO TinhTrangThietBi (TenTinhTrang, MoTa,TrangThai) VALUES (@TenTinhTrang, @Mota, 1)";

            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("TenTinhTrang", tTThietBiDTO.TenTinhTrang);
            pars[1] = new SqlParameter("MoTa", tTThietBiDTO.MoTa);

            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhThemTTTBi, conn, pars);
            conn.Close();
            return kq > 0;
        
        }
    }
}
