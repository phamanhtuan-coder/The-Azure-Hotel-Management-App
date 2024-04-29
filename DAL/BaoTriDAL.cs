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
    public class BaoTriDAL
    {
        public List<BaoTriDTO> FilterTrangThai(bool v)
        {
            List<BaoTriDTO> ds = new List<BaoTriDTO>();

            string lenhLayDanhSach = "SELECT * FROM BaoTri WHERE TrangThai = @TrangThai";

            SqlConnection conn = DataProvider.KetNoiDuLieu();

            conn.Open();

            SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhLayDanhSach, conn, "@TrangThai", SqlDbType.Binary, v ? (object)1 : (object)0);
            while (reader.Read())
            {
                BaoTriDTO bt = new BaoTriDTO();
                bt.MaBaoTri = (int)reader[0];
                bt.MaThietBi = (int)reader[1];
                bt.MaNV = (int)reader[2];
                bt.NgayHuHong = DateTime.Parse(reader[3].ToString());
                bt.NgayBaoTri = DateTime.Parse(reader[4].ToString());
                bt.TrangThai = v;

                ds.Add(bt);
            }

            return ds;
        }
        public bool khoiphuc(int mabtri)
        {
            string lenhkp =
                "UPDATE BaoTri SET TrangThai = 1 WHERE MaBaoTri = @MaBaoTri";
            SqlParameter par = new SqlParameter("@MaBaoTri", mabtri);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhkp, conn, par);
            conn.Close();
            return kq > 0;
        }

        public List<BaoTriDTO> layds()
        {
            List<BaoTriDTO> ds = new List<BaoTriDTO>();
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            string strlaydanhsach = "select * from BaoTri";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                BaoTriDTO bt = new BaoTriDTO();
                bt.MaBaoTri = (int)reader[0];
                bt.MaThietBi = (int)reader[1];
                bt.MaNV = (int)reader[2];
                bt.NgayHuHong = DateTime.Parse(reader[3].ToString());
                bt.NgayBaoTri = DateTime.Parse(reader[4].ToString());
                byte[] trangThaiBytes = (byte[])reader[5];
                bool trangThai = trangThaiBytes[0] == 1;
                bt.TrangThai = trangThai;
                ds.Add(bt);
            }
            reader.Close();
            conn.Close();
            return ds;
        }
        public List<BaoTriDTO> layds2()
        {
            List<BaoTriDTO> ds = new List<BaoTriDTO>();
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            string strlaydanhsach = "select * from BaoTri where TrangThai=1";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                BaoTriDTO bt = new BaoTriDTO();
                bt.MaBaoTri = (int)reader[0];
                bt.MaThietBi = (int)reader[1];
                bt.MaNV = (int)reader[2];
                bt.NgayHuHong = DateTime.Parse(reader[3].ToString());
                bt.NgayBaoTri = DateTime.Parse(reader[4].ToString());
                byte[] trangThaiBytes = (byte[])reader[5];
                bool trangThai = trangThaiBytes[0] == 1;
                bt.TrangThai = trangThai;
                ds.Add(bt);
            }
            reader.Close();
            conn.Close();
            return ds;
           
        }

        public bool suabt(BaoTriDTO baoTriDTO)
        {
            string lenhCapNhatbt =
                "UPDATE BaoTri SET MaThietBi = @MaThietBi, MaNV = @MaNV,NgayHuHong=@NgayHuHong,NgayBaoTri=@NgayBaoTri WHERE MaBaoTri = @MaBaoTri";
            SqlParameter[] pars = new SqlParameter[5];

            pars[0] = new SqlParameter("MaBaoTri", baoTriDTO.MaBaoTri);
            pars[1] = new SqlParameter("MaThietBi", baoTriDTO.MaThietBi);
            pars[2] = new SqlParameter("MaNV", baoTriDTO.MaNV);
            pars[3] = new SqlParameter("NgayHuHong", baoTriDTO.NgayHuHong);
            pars[4] = new SqlParameter("NgayBaoTri", baoTriDTO.NgayBaoTri);

            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhCapNhatbt, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool thembt(BaoTriDTO baoTriDTO)
        {
            string lenhThem =
                "INSERT INTO BaoTri (MaThietBi, MaNV,NgayHuHong,NgayBaoTri,TrangThai) VALUES (@MaThietBi, @MaNV,@NgayHuHong,@NgayBaoTri, 1)";

            SqlParameter[] pars = new SqlParameter[4];
            pars[0] = new SqlParameter("MaThietBi", baoTriDTO.MaThietBi);
            pars[1] = new SqlParameter("MaNV", baoTriDTO.MaNV);
            pars[2] = new SqlParameter("NgayHuHong", baoTriDTO.NgayHuHong);
            pars[3] = new SqlParameter("NgayBaoTri", baoTriDTO.NgayBaoTri);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhThem, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool xoa(int mabtri)
        {
            string lenhXoa =
                "UPDATE BaoTri SET TrangThai = 0 WHERE MaBaoTri = @MaBaoTri";
            SqlParameter par = new SqlParameter("@MaBaoTri", mabtri);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhXoa, conn, par);
            conn.Close();
            return kq > 0;
        }
    }
}
