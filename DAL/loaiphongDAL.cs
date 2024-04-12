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
    public class LoaiPhongDAL
    {
        public static bool khoiphucloaiphong(int maloai)
        {
            string lenhkploaiphong =
                "UPDATE LoaiPhong SET TrangThai = 1 WHERE MaLoai = @MaLoai";
            SqlParameter par = new SqlParameter("@MaLoai", maloai);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhkploaiphong, conn, par);
            conn.Close();
            return kq > 0;
        }
        public static bool xoaloaiphong(int maloai)
        {
            string lenhXoaloaiphong =
                "UPDATE LoaiPhong SET TrangThai = 0 WHERE MaLoai = @MaLoai";
            SqlParameter par = new SqlParameter("@MaLoai",maloai );
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhXoaloaiphong, conn, par);
            conn.Close();
            return kq > 0;
        }

        public List<LoaiPhongDTO> FilterTrangThai(bool v)
        {
            List<LoaiPhongDTO> dsLoaiPhong = new List<LoaiPhongDTO>();

            // Create the SQL query with a parameterized filter
            string lenhLayDanhSachLoaiPhong = "SELECT * FROM LoaiPhong WHERE TrangThai = @TrangThai";

            // Establish connection
            SqlConnection conn = DataProvider.KetNoiDuLieu();

            conn.Open();

            SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhLayDanhSachLoaiPhong, conn, "@TrangThai", SqlDbType.Binary, v ? (object)1 : (object)0);
            while (reader.Read())
            {
                LoaiPhongDTO LoaiPhongDTO = new LoaiPhongDTO();
                LoaiPhongDTO.MaLoai =(int) reader[0];
                LoaiPhongDTO.TenLoai = reader[1].ToString();
                LoaiPhongDTO.Mota = reader[2].ToString();
                LoaiPhongDTO.TrangThai = v;

                dsLoaiPhong.Add(LoaiPhongDTO);
            }

            return dsLoaiPhong;
        }

        public List<LoaiPhongDTO> laydsloaiphong()
        {
            List<LoaiPhongDTO> dslp=new List<LoaiPhongDTO>();
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            string strlaydanhsach = "select * from LoaiPhong";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                LoaiPhongDTO lphong=new LoaiPhongDTO();
                lphong.MaLoai = (int)reader[0];
                lphong.TenLoai = reader[1].ToString();
                lphong.Mota = reader[2].ToString();
                byte[] trangThaiBytes = (byte[])reader[3];
                bool trangThai = trangThaiBytes[0] == 1;
                lphong.TrangThai = trangThai;
                dslp.Add(lphong);
            }
            reader.Close();
            conn.Close();
            return dslp;
        }

        public bool sualphong(LoaiPhongDTO loaiphongDTO)
        {
            string lenhCapNhatlphong =
                "UPDATE LoaiPhong SET TenLoai = @TenLoai, Mota = @Mota WHERE MaLoai = @MaLoai";
            SqlParameter[] pars = new SqlParameter[3];

            pars[0] = new SqlParameter("TenLoai", loaiphongDTO.TenLoai);
            pars[1] = new SqlParameter("Mota", loaiphongDTO.Mota);
            pars[2] = new SqlParameter("MaLoai", loaiphongDTO.MaLoai);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhCapNhatlphong, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool themlphong(LoaiPhongDTO loaiphongDTO)
        {
            string lenhThemloaiphong =
                "INSERT INTO LoaiPhong (TenLoai, Mota,TrangThai) VALUES (@TenLoai, @Mota, 1)";

            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("TenLoai",loaiphongDTO.TenLoai );
            pars[1] = new SqlParameter("Mota", loaiphongDTO.Mota);

            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhThemloaiphong, conn, pars);
            conn.Close();
            return kq > 0;
        }
    }
}
