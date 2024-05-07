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
        public bool Check_in(List<DatPhongDTO> list)
        {
            try
            {              
                foreach (var item in list)
                {
                    SqlConnection conn = DataProvider.KetNoiDuLieu();
                    conn.Open();
                    SqlCommand com = new SqlCommand("spCheckin", conn);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@MaDatPhong", item.MaDatPhong);

                    int count = com.ExecuteNonQuery();
                    conn.Close();
                    if (count > 0)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }                    
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Check_out(int MaKM, int maHoaDon, List<DatPhongDTO> list)
        {
            try
            {
                foreach (var item in list)
                {
                    SqlConnection conn = DataProvider.KetNoiDuLieu();
                    conn.Open();
                    SqlCommand com = new SqlCommand("CheckOut", conn);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    com.Parameters.AddWithValue("@MaDatPhong", item.MaDatPhong);
                    if (MaKM != -1)
                    {
                        com.Parameters.AddWithValue("@MaKhuyenMai", MaKM);
                    }

                    int count = com.ExecuteNonQuery();
                    conn.Close();
                    if (count > 0)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

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
            string strlaydanhsach = "select BangTaiKhoan.TenDangNhap, KhachHang.CCCD, DatPhong.* " +
                " from DatPhong join KhachHang on DatPhong.MaKH = KhachHang.MaKH " +
                " join BangTaiKhoan on KhachHang.MaTaiKhoan = BangTaiKhoan.MaTaiKhoan";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                DatPhongDTO phong = new DatPhongDTO();
                phong.TenTaiKhoan = (string)reader["TenDangNhap"];
                phong.CCCD = (string)reader["CCCD"];
                phong.MaDatPhong = (int)reader["MaDatPhong"];
                phong.MaKH = (int)reader["MaKH"];
                phong.MaPHG = (int)reader["MaPHG"];
                phong.NgayDatPhong =DateTime.Parse( reader["NgayDatPhong"].ToString());
                object ngayNhanPhongObject = reader["NgayNhanPhong"];
                if (ngayNhanPhongObject != DBNull.Value)
                {
                    phong.NgayNhanPhong = DateTime.Parse(ngayNhanPhongObject.ToString());
                }
                else
                {
                    phong.NgayNhanPhong = null;
                }

                object ngayTraPhongObject = reader["NgayTraPhong"];
                if (ngayTraPhongObject != DBNull.Value)
                {
                    phong.NgayTraPhong = DateTime.Parse(ngayTraPhongObject.ToString());
                }
                else
                {
                    phong.NgayTraPhong = null;
                }

                phong.SoLuongKH = (int)reader["SoLuongKH"];
                byte[] trangThaiBytes = (byte[])reader["trangThai"];
                bool trangThai = trangThaiBytes[0] == 1;
                phong.TrangThai = trangThai;
                ds.Add(phong);
            }
            reader.Close();
            conn.Close();
            return ds;
        }
        public List<DatPhongDTO> layds2()
        {
            List<DatPhongDTO> ds = new List<DatPhongDTO>();
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            string strlaydanhsach = "select BangTaiKhoan.TenDangNhap, KhachHang.CCCD, DatPhong.* " +
                                    " from DatPhong join KhachHang on DatPhong.MaKH = KhachHang.MaKH " +
                                    " join BangTaiKhoan on KhachHang.MaTaiKhoan = BangTaiKhoan.MaTaiKhoan " +
                                    " where DatPhong.TrangThai=1 and KhachHang.TrangThai=1";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                DatPhongDTO phong = new DatPhongDTO();
                phong.TenTaiKhoan = (string)reader["TenDangNhap"];
                phong.CCCD = (string)reader["CCCD"];
                phong.MaDatPhong = (int)reader["MaDatPhong"];
                phong.MaKH = (int)reader["MaKH"];
                phong.MaPHG = (int)reader["MaPHG"];
                phong.NgayDatPhong = DateTime.Parse(reader["NgayDatPhong"].ToString());
                object ngayNhanPhongObject = reader["NgayNhanPhong"];
                if (ngayNhanPhongObject != DBNull.Value)
                {
                    phong.NgayNhanPhong = DateTime.Parse(ngayNhanPhongObject.ToString());
                }
                else
                {
                    phong.NgayNhanPhong = null;
                }

                object ngayTraPhongObject = reader["NgayTraPhong"];
                if (ngayTraPhongObject != DBNull.Value)
                {
                    phong.NgayTraPhong = DateTime.Parse(ngayTraPhongObject.ToString());
                }
                else
                {
                    phong.NgayTraPhong = null;
                }
                phong.SoLuongKH = (int)reader["SoLuongKH"];
                phong.TrangThai = true;
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
                "INSERT INTO DatPhong (MaKH, MaPHG,NgayDatPhong,SoLuongKH,TrangThai) VALUES (@MaKH, @MaPHG,@NgayDatPhong,@SoLuongKH, 1)";

            SqlParameter[] pars = new SqlParameter[4];
            pars[0] = new SqlParameter("MaKH", datPhongDTO.MaKH);
            pars[1] = new SqlParameter("MaPHG", datPhongDTO.MaPHG);
            pars[2] = new SqlParameter("NgayDatPhong", datPhongDTO.NgayDatPhong);
            //pars[3] = new SqlParameter("NgayNhanPhong", datPhongDTO.NgayNhanPhong);
            //pars[4] = new SqlParameter("NgayTraPhong", datPhongDTO.NgayTraPhong);
            pars[3] = new SqlParameter("SoLuongKH", datPhongDTO.SoLuongKH);
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
