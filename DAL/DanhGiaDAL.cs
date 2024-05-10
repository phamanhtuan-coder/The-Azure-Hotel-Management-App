using DTO;
using System;
using System.Collections.Generic;
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

        public bool KhoiPhucDanhGia(string maDanhGia)
        {
            try
            {
                string lenhKhoiPhuc =
                  "UPDATE DanhGia SET TrangThai = 1 WHERE MaDanhGia = @MaDanhGia";
                SqlParameter par = new SqlParameter("@MaDanhGia", maDanhGia);
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                int kq = DataProvider.ThucHienCauLenh(lenhKhoiPhuc, conn, par);
                conn.Close();
                return kq > 0;
            }
            catch (Exception ex)
            {

                throw ex;
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
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool XoaDanhGia(string maDanhGia)
        {
            try
            {
                string lenhXoa =
                  "UPDATE DanhGia SET TrangThai = 0 WHERE MaDanhGia = @MaDanhGia";
                SqlParameter par = new SqlParameter("@MaDanhGia", maDanhGia);
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                int kq = DataProvider.ThucHienCauLenh(lenhXoa, conn, par);
                conn.Close();
                return kq > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
