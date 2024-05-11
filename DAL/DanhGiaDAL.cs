using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DanhGiaDAL
    {
        List<DanhGiaDTO> dsDanhGia;
        DanhGiaDTO danhGia;

        public List<DanhGiaDTO> FilterTrangThai(bool trangThai)
        {
            try
            {
                List<DanhGiaDTO> dsDanhGia = new List<DanhGiaDTO>();

                string lenhTV = "SELECT * FROM DanhGia WHERE TrangThai = @TrangThai";

                SqlConnection conn = DataProvider.KetNoiDuLieu();

                conn.Open();

                SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhTV, conn, "@TrangThai", SqlDbType.Binary, trangThai ? (object)1 : (object)0);
                while (reader.Read())
                {
                    DanhGiaDTO danhGiaDTO = new DanhGiaDTO();
                    danhGiaDTO.MaDG = (int) reader["MaDG"];
                    danhGiaDTO.MaDP = (int) reader["MaDP"];
                    danhGiaDTO.DiemDanhGia = (int)reader["DiemDanhGia"];
                    danhGiaDTO.NhanXet = reader["NhanXet"].ToString();
                    danhGia.NgayDanhGia = DateTime.Parse(reader["NgayDanhGia"].ToString());
                    danhGiaDTO.TrangThai = trangThai;
                    dsDanhGia.Add(danhGiaDTO);
                }

                return dsDanhGia;
            }
            catch (Exception)
            {

                return new List<DanhGiaDTO>();
            }
        }

        public bool KhoiPhucDanhGia(int maDanhGia)
        {
            try
            {
                string lenhKhoiPhuc =
                  "UPDATE DanhGia SET TrangThai = 1 WHERE MaDG = @MaDanhGia";
                SqlParameter par = new SqlParameter("@MaDanhGia", maDanhGia);
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                int kq = DataProvider.ThucHienCauLenh(lenhKhoiPhuc, conn, par);
                conn.Close();
                return kq > 0;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public List<DanhGiaDTO> LayDanhSachDanhGia()
        {
            try
            {
                dsDanhGia = new List<DanhGiaDTO>();
                string lenhLay = "SELECT * FROM DanhGia Where CAST(TrangThai AS INT) =1";
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhLay, conn);
                while (reader.Read())
                {
                    danhGia = new DanhGiaDTO();
                    danhGia.MaDG = (int) reader["MaDG"];
                    danhGia.MaDP = (int)reader["MaDP"];
                    danhGia.DiemDanhGia = (int)reader["DiemDanhGia"];
                    danhGia.NhanXet = reader["NhanXet"].ToString();
                    danhGia.NgayDanhGia = DateTime.Parse(reader["NgayDanhGia"].ToString());

                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    bool trangThai = trangThaiBytes[0] == 1;
                    danhGia.TrangThai = trangThai;

                    dsDanhGia.Add(danhGia);
                }
                reader.Close();
                conn.Close();
                return dsDanhGia;
            }
            catch (Exception)
            {

                return new List<DanhGiaDTO>();
            }
        }

        public List<DanhGiaDTO> LayDanhSachDanhGiaTheoUser(int maKH)
        {
            try
            {
                dsDanhGia = new List<DanhGiaDTO>();
                string lenhLay = "SELECT DG.* FROM DanhGia DG join DatPhong DP on DG.MaDP = DP.MaDatPhong Where DG.TrangThai =1 And MaKH =@MaKH";
                SqlParameter[] pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@MaKH", maKH);  
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhLay, conn,pars);
                while (reader.Read())
                {
                    danhGia = new DanhGiaDTO();
                    danhGia.MaDG = (int)reader["MaDG"];
                    danhGia.MaDP = (int)reader["MaDP"];
                    danhGia.DiemDanhGia = (int)reader["DiemDanhGia"];
                    danhGia.NhanXet = reader["NhanXet"].ToString();
                    danhGia.NgayDanhGia = DateTime.Parse(reader["NgayDanhGia"].ToString());

                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    bool trangThai = trangThaiBytes[0] == 1;
                    danhGia.TrangThai = trangThai;

                    dsDanhGia.Add(danhGia);
                }
                reader.Close();
                conn.Close();
                return dsDanhGia;
            }
            catch (Exception )
            {

                return new List<DanhGiaDTO>();
            }
        }

        public bool SuaDanhGia(DanhGiaDTO danhGia)
        {
            try
            {
                string lenhXoa =
                  "UPDATE DanhGia SET NhanXet=@NhanXet,DiemDanhGia=@DiemDanhGia,NgayDanhGia=@NgayDanhGia WHERE MaDP= @MaDP";
                SqlParameter[] pars = new SqlParameter[4];
                pars[0] = new SqlParameter("@NhanXet", danhGia.NhanXet);
                pars[1] = new SqlParameter("@DiemDanhGia", danhGia.DiemDanhGia);
                pars[2] = new SqlParameter("@NgayDanhGia", danhGia.NgayDanhGia);
                pars[3] = new SqlParameter("@MaDP", danhGia.MaDP);
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                int kq = DataProvider.ThucHienCauLenh(lenhXoa, conn, pars);
                conn.Close();
                return kq > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool ThemDanhGia(DanhGiaDTO danhGia)
        {
            try
            {
                string lenhAdd =
                  "Insert into DanhGia (MaDP,DiemDanhGia,NhanXet,NgayDanhGia,TrangThai) values(@MaDP,@DiemDanhGia,@NhanXet,@NgayDanhGia,1)";
                SqlParameter[] pars = new SqlParameter[4];
                pars[0] = new SqlParameter("@MaDP", danhGia.MaDP);
                pars[1] = new SqlParameter("@DiemDanhGia", danhGia.DiemDanhGia);
                pars[2] = new SqlParameter("@NhanXet", danhGia.NhanXet);
                pars[3] = new SqlParameter("@NgayDanhGia", danhGia.NgayDanhGia);
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                int kq = DataProvider.ThucHienCauLenh(lenhAdd, conn, pars);
                conn.Close();
                return kq > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaDanhGia(int maDanhGia)
        {
            try
            {
                string lenhXoa =
                  "UPDATE DanhGia SET TrangThai = 0 WHERE MaDG= @MaDanhGia";
                SqlParameter par = new SqlParameter("@MaDanhGia", maDanhGia);
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                int kq = DataProvider.ThucHienCauLenh(lenhXoa, conn, par);
                conn.Close();
                return kq > 0;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
