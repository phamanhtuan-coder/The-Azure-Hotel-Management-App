using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class loaiphongDAL
    {
        public List<loaiphongDTO> laydsloaiphong()
        {
            List<loaiphongDTO> dslp=new List<loaiphongDTO>();
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            string strlaydanhsach = "select * from LoaiPhong";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                loaiphongDTO lphong=new loaiphongDTO();
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
    }
}
