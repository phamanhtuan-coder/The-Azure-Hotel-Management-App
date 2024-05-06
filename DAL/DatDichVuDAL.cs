using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DatDichVuDAL
    {
        public List<DatDichVuDTO> FilterTrangThai(bool v)
        {
            List<DatDichVuDTO> ds = new List<DatDichVuDTO>();

            string lenhLayDanhSach = "SELECT * FROM DatDichVu WHERE TrangThai = @TrangThai";

            SqlConnection conn = DataProvider.KetNoiDuLieu();

            conn.Open();

            SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhLayDanhSach, conn, "@TrangThai", SqlDbType.Binary, v ? (object)1 : (object)0);
            while (reader.Read())
            {
                DatDichVuDTO dv = new DatDichVuDTO();
                dv.MaDatDichVu = (int)reader[0];
                dv.MaDatPhong = (int)reader[1];
                dv.MaDV = (int)reader[2];
                dv.SoLuong = int.Parse(reader[3].ToString());
                dv.NgayDat = DateTime.Parse(reader[5].ToString());
                dv.TrangThai = v;

                ds.Add(dv);
            }

            return ds;
        }
        public bool khoiphuc(int MaDatDichVu)
        {
            string lenhkp =
                "UPDATE DatDichVu SET TrangThai = 1 WHERE MaDatDichVu = @MaDatDichVu";
            SqlParameter par = new SqlParameter("@MaDatDichVu", MaDatDichVu);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhkp, conn, par);
            conn.Close();
            return kq > 0;
        }

        public List<DatDichVuDTO> layds()
        {
            List<DatDichVuDTO> ds = new List<DatDichVuDTO>();
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            string strlaydanhsach = "select * from DatDichVu";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                DatDichVuDTO dv = new DatDichVuDTO();
                dv.MaDatDichVu = (int)reader[0];
                dv.MaDatPhong = (int)reader[1];
                dv.MaDV = (int)reader[2];
                dv.SoLuong = int.Parse(reader[3].ToString());
                dv.NgayDat = DateTime.Parse(reader[5].ToString());
                byte[] trangThaiBytes = (byte[])reader[6];
                bool trangThai = trangThaiBytes[0] == 1;
                dv.TrangThai = trangThai;
                ds.Add(dv);
            }
            reader.Close();
            conn.Close();
            return ds;
        }

        public bool suaddv(DatDichVuDTO datDichVuDTO)
        {
            string lenhCapNhatdv =
                "UPDATE DatDichVu SET MaDatPhong = @MaDatPhong, MaDV = @MaDV,SoLuong=@SoLuong,NgayDat=@NgayDat WHERE MaDatDichVu = @MaDatDichVu";
            SqlParameter[] pars = new SqlParameter[5];

            pars[0] = new SqlParameter("MaDatDichVu", datDichVuDTO.MaDatDichVu);
            pars[1] = new SqlParameter("MaDatPhong", datDichVuDTO.MaDatPhong);
            pars[2] = new SqlParameter("MaDV", datDichVuDTO.MaDV);
            pars[3] = new SqlParameter("SoLuong", datDichVuDTO.SoLuong);
            pars[4] = new SqlParameter("NgayDat", datDichVuDTO.NgayDat);

            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhCapNhatdv, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool themddv(DatDichVuDTO datDichVuDTO)
        {
            string lenhThem =
                "INSERT INTO DatDichVu (MaDatPhong, MaDV,SoLuong,NgayDat,TrangThai) VALUES (@MaDatPhong, @MaDV,@SoLuong,@NgayDat, 1)";

            SqlParameter[] pars = new SqlParameter[4];
            pars[0] = new SqlParameter("MaDatPhong", datDichVuDTO.MaDatPhong);
            pars[1] = new SqlParameter("MaDV", datDichVuDTO.MaDV);
            pars[2] = new SqlParameter("SoLuong", datDichVuDTO.SoLuong);
            pars[3] = new SqlParameter("NgayDat", datDichVuDTO.NgayDat);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhThem, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool xoa(int MaDatDichVu)
        {
            string lenhXoa =
                "UPDATE DatDichVu SET TrangThai = 0 WHERE MaDatDichVu = @MaDatDichVu";
            SqlParameter par = new SqlParameter("@MaDatDichVu", MaDatDichVu);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhXoa, conn, par);
            conn.Close();
            return kq > 0;
        }
    }
}
