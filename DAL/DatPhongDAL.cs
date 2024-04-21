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
    public class DatPhongDAL
    {
        public List<DatPhongDTO> FilterTrangThai(bool v)
        {
            List<DatPhongDTO> ds = new List<DatPhongDTO>();

            string lenhLayDanhSach = "SELECT * FROM DatPhong WHERE TrangThai = @TrangThai";

            SqlConnection conn = DataProvider.KetNoiDuLieu();

            conn.Open();

            SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhLayDanhSach, conn, "@TrangThai", SqlDbType.Binary, v ? (object)1 : (object)0);
            while (reader.Read())
            {
                DatPhongDTO phong = new DatPhongDTO();
                phong.MaDatPhong = (int)reader[0];
                phong.MaKH = (int)reader[1];
                phong.MaPHG = (int)reader[2];
                phong.NgayDatPhong = DateTime.Parse(reader[3].ToString());
                phong.NgayNhanPhong = DateTime.Parse(reader[4].ToString());
                phong.NgayTraPhong = DateTime.Parse(reader[5].ToString());
                phong.SoLuongKH = (int)reader[6];
                phong.TrangThai = v;

                ds.Add(phong);
            }

            return ds;
        }
        public bool kpd(int madatphong)
        {
            string lenhkp =
                "UPDATE DatPhong SET TrangThai = 1 WHERE MaDatPhong = @MaDatPhong";
            SqlParameter par = new SqlParameter("@MaDatPhong", madatphong);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhkp, conn, par);
            conn.Close();
            return kq > 0;
        }

        public List<DatPhongDTO> layds()
        {
            List<DatPhongDTO> ds = new List<DatPhongDTO>();
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            string strlaydanhsach = "select * from DatPhong";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                DatPhongDTO phong = new DatPhongDTO();
                phong.MaDatPhong = (int)reader[0];
                phong.MaKH = (int)reader[1];
                phong.MaPHG = (int)reader[2];
                phong.NgayDatPhong =DateTime.Parse( reader[3].ToString());
                phong.NgayNhanPhong = DateTime.Parse(reader[4].ToString());
                phong.NgayTraPhong = DateTime.Parse(reader[5].ToString());
                phong.SoLuongKH = (int)reader[6];
                byte[] trangThaiBytes = (byte[])reader[7];
                bool trangThai = trangThaiBytes[0] == 1;
                phong.TrangThai = trangThai;
                ds.Add(phong);
            }
            reader.Close();
            conn.Close();
            return ds;
        }

        public bool suad(DatPhongDTO datPhongDTO)
        {
            string lenhCapNhatphong =
                "UPDATE DatPhong SET MaKH = @MaKH, MaPHG = @MaPHG,NgayDatPhong=@NgayDatPhong,NgayNhanPhong=@NgayNhanPhong,NgayTraPhong=@NgayTraPhong,SoLuongKH=@SoLuongKH WHERE MaDatPhong = @MaDatPhong";
            SqlParameter[] pars = new SqlParameter[7];

            pars[0] = new SqlParameter("MaKH", datPhongDTO.MaKH);
            pars[1] = new SqlParameter("MaPHG", datPhongDTO.MaPHG);
            pars[2] = new SqlParameter("NgayDatPhong", datPhongDTO.NgayDatPhong);
            pars[3] = new SqlParameter("NgayNhanPhong", datPhongDTO.NgayNhanPhong);
            pars[4] = new SqlParameter("NgayTraPhong", datPhongDTO.NgayTraPhong);
            pars[5] = new SqlParameter("SoLuongKH", datPhongDTO.SoLuongKH);
            pars[6] = new SqlParameter("MaDatPhong", datPhongDTO.MaDatPhong);

            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhCapNhatphong, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool themd(DatPhongDTO datPhongDTO)
        {
            string lenhThem =
                "INSERT INTO DatPhong (MaKH, MaPHG,NgayDatPhong,NgayNhanPhong,NgayTraPhong,SoLuongKH,TrangThai) VALUES (@MaKH, @MaPHG,@NgayDatPhong,@NgayNhanPhong,@NgayTraPhong,@SoLuongKH, 1)";

            SqlParameter[] pars = new SqlParameter[6];
            pars[0] = new SqlParameter("MaKH", datPhongDTO.MaKH);
            pars[1] = new SqlParameter("MaPHG", datPhongDTO.MaPHG);
            pars[2] = new SqlParameter("NgayDatPhong", datPhongDTO.NgayDatPhong);
            pars[3] = new SqlParameter("NgayNhanPhong", datPhongDTO.NgayNhanPhong);
            pars[4] = new SqlParameter("NgayTraPhong", datPhongDTO.NgayTraPhong);
            pars[5] = new SqlParameter("SoLuongKH", datPhongDTO.SoLuongKH);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhThem, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool xoa(int madatphong)
        {
            string lenhXoa =
                "UPDATE DatPhong SET TrangThai = 0 WHERE MaDatPhong = @MaDatPhong";
            SqlParameter par = new SqlParameter("@MaDatPhong", madatphong);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhXoa, conn, par);
            conn.Close();
            return kq > 0;
        }
    }
}
