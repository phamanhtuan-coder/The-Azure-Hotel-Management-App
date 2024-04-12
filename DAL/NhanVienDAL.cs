using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        List<NhanVienDTO> list = new List<NhanVienDTO>();
        public List<NhanVienDTO> LoadIDAndNameDAL()
        {
            
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanNhanVienQuanLy", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                list = new List<NhanVienDTO>();
                while (reader.Read())
                {
                    NhanVienDTO nhanVien = new NhanVienDTO();

                    nhanVien.MaNV = (int) reader["MaNV"];
                    nhanVien.HoTenNV = reader["HoTenNV"].ToString();

                    list.Add(nhanVien);
                }

                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<NhanVienDTO>();
            }
        }
    }
}
