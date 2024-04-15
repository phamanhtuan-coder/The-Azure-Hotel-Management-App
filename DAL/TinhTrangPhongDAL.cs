using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Org.BouncyCastle.Utilities;

namespace DAL
{
    public class TinhTrangPhongDAL
    {
        public bool khoiphucttphong(int mattphong)
        {
            string lenhkhoiphucttphong =
                "UPDATE TinhTrangPhong SET TrangThai = 1 WHERE MaTinhTrangPhong = @MaTinhTrangPhong";
            SqlParameter par = new SqlParameter("@MaTinhTrangPhong", mattphong);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhkhoiphucttphong, conn, par);
            conn.Close();
            return kq > 0;
        }

        public List<TinhTrangPhongDTO> laydsttphong()
        {
            List<TinhTrangPhongDTO> dsttp = new List<TinhTrangPhongDTO>();
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            string strlaydanhsach = "select * from TinhTrangPhong";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                TinhTrangPhongDTO ttphong = new TinhTrangPhongDTO();
                ttphong.MaTinhTrangPhong = (int)reader[0];
                ttphong.TenTinhTrang = reader[1].ToString();
                ttphong.MoTa = reader[2].ToString();
                byte[] trangThaiBytes = (byte[])reader[3];
                bool trangThai = trangThaiBytes[0] == 1;
                ttphong.TrangThai = trangThai;
                dsttp.Add(ttphong);
            }
            reader.Close();
            conn.Close();
            return dsttp;
        }

        public bool suattp(TinhTrangPhongDTO tinhTrang)
        {
            string lenhCapNhatttphong =
                "UPDATE TinhTrangPhong SET TenTinhTrang = @TenTinhTrang, Mota = @Mota WHERE MaTinhTrangPhong = @MaTinhTrangPhong";
            SqlParameter[] pars = new SqlParameter[3];

            pars[0] = new SqlParameter("TenTinhTrang", tinhTrang.TenTinhTrang);
            pars[1] = new SqlParameter("Mota", tinhTrang.MoTa);
            pars[2] = new SqlParameter("MaTinhTrangPhong", tinhTrang.MaTinhTrangPhong);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhCapNhatttphong, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool themttp(TinhTrangPhongDTO tinhTrang)
        {
            string lenhThemttphong =
                "INSERT INTO TinhTrangPhong (TenTinhTrang, MoTa,TrangThai) VALUES (@TenTinhTrang, @MoTa, 1)";

            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("TenTinhTrang", tinhTrang.TenTinhTrang);
            pars[1] = new SqlParameter("MoTa", tinhTrang.MoTa);

            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhThemttphong, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool xoattphong(int mattphong)
        {
            string lenhXoattphong =
                "UPDATE TinhTrangPhong SET TrangThai = 0 WHERE MaTinhTrangPhong = @MaTinhTrangPhong";
            SqlParameter par = new SqlParameter("@MaTinhTrangPhong", mattphong);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhXoattphong, conn, par);
            conn.Close();
            return kq > 0;
        }
    }
}
