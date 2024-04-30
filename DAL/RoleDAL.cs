using DTO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoleDAL
    {
        public bool ADDRoleDAL(RoleDTO role)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();

                conn.Open();

                SqlCommand com = new SqlCommand("sp_ThemPhanQuyen", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaPhanQuyen", role.MaPhanQuyen);
                com.Parameters.AddWithValue("@MaVaiTro", role.MaVaiTro);
                com.Parameters.AddWithValue("@MaPhongBan", role.MaPhongBan);

                int count = com.ExecuteNonQuery();

                conn.Close();

                if (count > 0) return true;
                else return false;


            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditRoleDAL(RoleDTO role)
        {
            //try
            //{
            //    SqlConnection conn = DataProvider.KetNoiDuLieu();

            //    conn.Open();

            //    SqlCommand com = new SqlCommand("sp_CapNhatPhanQuyen", conn);
            //    com.CommandType = System.Data.CommandType.StoredProcedure;
            //    com.Parameters.AddWithValue("@MaPhanQuyen", role.MaPhanQuyen);
            //    com.Parameters.AddWithValue("@MaVaiTro", role.MaVaiTro);
            //    com.Parameters.AddWithValue("@MaPhongBan", role.MaPhongBan);

            //    int count = com.ExecuteNonQuery();

            //    conn.Close();

            //    if (count > 0) return true;
            //    else return false;
            //}
            //catch (Exception)
            //{
                  return false;
            //}
        }

        public List<RoleDTO> FilterTrangThai(bool v)
        {
            if (v)
            {
                List<RoleDTO> ls = new List<RoleDTO>();
                try
                {
                    SqlConnection conn = DataProvider.KetNoiDuLieu();
                    conn.Open();

                    string strTV = "Select MaPhanQuyen, TenVaiTro, PhanQuyen.MaPhongBan, COUNT(MaTaiKhoan) as SoLuongTK, PhanQuyen.TrangThai, PhongBan.TenPhong " +
                                "From PhanQuyen join VaiTro on PhanQuyen.MaVaiTro=VaiTro.MaVaiTro left join BangTaiKhoan on BangTaiKhoan.MaPQ=PhanQuyen.MaPhanQuyen and BangTaiKhoan.TrangThai =1 " +
                                "join PhongBan on PhanQuyen.MaPhongBan=PhongBan.MaPhongBan " +
                                "Where PhanQuyen.TrangThai = 1 " +
                                "Group by MaPhanQuyen, TenVaiTro, PhanQuyen.MaPhongBan, PhanQuyen.TrangThai, PhongBan.TenPhong";

                    SqlDataReader reader = DataProvider.ThucHienTruyVan(strTV, conn);
                    while (reader.Read())
                    {
                        RoleDTO roleDTO = new RoleDTO();

                        roleDTO.MaPhanQuyen = reader["MaPhanQuyen"].ToString();
                        roleDTO.TenVaiTro = reader["TenVaiTro"].ToString();
                        roleDTO.MaPhongBan = reader["MaPhongBan"].ToString();
                        roleDTO.SoLuongTK = (int)reader["SoLuongTK"];
                        roleDTO.TrangThai = true;
                        roleDTO.TenPhong = reader["TenPhong"].ToString();

                        ls.Add(roleDTO);
                    }
                    reader.Close();
                    conn.Close();
                    return ls;
                }
                catch (Exception)
                {
                    return ls;
                }
            }
            else
            {
                List<RoleDTO> ls = new List<RoleDTO>();
                try
                {
                    SqlConnection conn = DataProvider.KetNoiDuLieu();
                    conn.Open();

                    string strTV = "Select MaPhanQuyen, TenVaiTro, PhanQuyen.MaPhongBan, COUNT(MaTaiKhoan) as SoLuongTK, PhanQuyen.TrangThai, PhongBan.TenPhong " +
                                "From PhanQuyen join VaiTro on PhanQuyen.MaVaiTro=VaiTro.MaVaiTro left join BangTaiKhoan on BangTaiKhoan.MaPQ=PhanQuyen.MaPhanQuyen and BangTaiKhoan.TrangThai =1 " +
                                "join PhongBan on PhanQuyen.MaPhongBan=PhongBan.MaPhongBan " +
                                "Where PhanQuyen.TrangThai = 0 " +
                                "Group by MaPhanQuyen, TenVaiTro, PhanQuyen.MaPhongBan, PhanQuyen.TrangThai, PhongBan.TenPhong";

                    SqlDataReader reader = DataProvider.ThucHienTruyVan(strTV, conn);
                    while (reader.Read())
                    {
                        RoleDTO roleDTO = new RoleDTO();

                        roleDTO.MaPhanQuyen = reader["MaPhanQuyen"].ToString();
                        roleDTO.TenVaiTro = reader["TenVaiTro"].ToString();
                        roleDTO.MaPhongBan = reader["MaPhongBan"].ToString();
                        roleDTO.SoLuongTK = (int)reader["SoLuongTK"];
                        roleDTO.TrangThai = false;
                        roleDTO.TenPhong = reader["TenPhong"].ToString();

                        ls.Add(roleDTO);
                    }
                    reader.Close();
                    conn.Close();
                    return ls;
                }
                catch (Exception)
                {
                    return ls;
                }
            }
        }

        public List<RoleDTO> loadRoleDAL()
        {
            List<RoleDTO> ls = new List<RoleDTO>();
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                string strTV = "Select MaPhanQuyen, TenVaiTro, PhanQuyen.MaPhongBan, COUNT(MaTaiKhoan) as SoLuongTK, PhanQuyen.TrangThai, PhongBan.TenPhong " +
                            "From PhanQuyen join VaiTro on PhanQuyen.MaVaiTro=VaiTro.MaVaiTro left join BangTaiKhoan on BangTaiKhoan.MaPQ=PhanQuyen.MaPhanQuyen and BangTaiKhoan.TrangThai =1 " +
                            "join PhongBan on PhanQuyen.MaPhongBan=PhongBan.MaPhongBan " +
                            "Group by MaPhanQuyen, TenVaiTro, PhanQuyen.MaPhongBan, PhanQuyen.TrangThai, PhongBan.TenPhong";

                SqlDataReader reader = DataProvider.ThucHienTruyVan(strTV, conn);
                while (reader.Read())
                {
                    RoleDTO roleDTO = new RoleDTO();
                    roleDTO.MaPhanQuyen = reader["MaPhanQuyen"].ToString();
                    roleDTO.TenVaiTro = reader["TenVaiTro"].ToString();
                    roleDTO.MaPhongBan = reader["MaPhongBan"].ToString();
                    roleDTO.SoLuongTK = (int)reader["SoLuongTK"];
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    roleDTO.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    roleDTO.TenPhong= reader["TenPhong"].ToString() ;
                    
                    ls.Add(roleDTO);
                }
                reader.Close();
                conn.Close();
                return ls;
            }catch (Exception) {
                return ls;
            }
        }

        public List<PhongBanDTO> LoadPBDAL()
        {
            List<PhongBanDTO> ls = new List<PhongBanDTO>();
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                string sql = "Select MaPhongBan, TenPhong From PhongBan";
                SqlDataReader reader = DataProvider.ThucHienTruyVan(sql, conn);

                while (reader.Read())
                {
                    PhongBanDTO tenPB = new PhongBanDTO();
                    tenPB.MaPhongBan = reader["MaPhongBan"].ToString();
                    tenPB.TenPhong = reader["TenPhong"].ToString();
                    ls.Add(tenPB);
                }

                conn.Close();

                return ls;
            }
            catch (Exception)
            {
                return ls;
            }
        }

        public List<TenVT> LoadVTDAL()
        {
            List<TenVT> ls = new List<TenVT>();
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                string sql = "Select MaVaiTro, TenVaiTro From VaiTro";
                SqlDataReader reader = DataProvider.ThucHienTruyVan(sql, conn);

                while (reader.Read())
                {
                    TenVT tenVT = new TenVT();
                    tenVT.MaVaiTro = (int) reader["MaVaiTro"];
                    tenVT.TenVaiTro = reader["TenVaiTro"].ToString();
                    ls.Add(tenVT);
                }

                conn.Close();

                return ls;
            }
            catch (Exception)
            {
                return ls;
            }
        }

        public bool DeleteRoleDAL(string pq)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlCommand com = new SqlCommand("spKiemTraSLTaiKhoan", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaPQ", pq);

                int dem= (int)com.ExecuteScalar();
                if (dem == 0)
                {
                    com = new SqlCommand("sp_CapNhatTrangThaiPhanQuyen", conn);
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@MaPhanQuyen", pq);
                    com.Parameters.AddWithValue("@TrangThai", 0);
                    int count = com.ExecuteNonQuery();
                    conn.Close();

                    if (count > 0) return true;
                    else return false;
                }
                else
                {
                    return false;
                }

                         
            }catch (Exception)
            {
                return false;
            }
        }

        public bool RestoreRoleDAL(string mPQ)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlCommand com = new SqlCommand("sp_CapNhatTrangThaiPhanQuyen", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaPhanQuyen", mPQ);
                com.Parameters.AddWithValue("@TrangThai", 1);
                int count = com.ExecuteNonQuery();
                conn.Close();

                if (count > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<RoleDTO> LoadMaPhanQuyen()
        {
            List<RoleDTO> ls = new List<RoleDTO>();
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();
                SqlCommand com = new SqlCommand("sp_MaPhanQuyen", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure ;
                
                SqlDataReader reader= com.ExecuteReader();
                while (reader.Read())
                {
                    RoleDTO role = new RoleDTO();
                    role.MaPhanQuyen= reader["MaPhanQuyen"].ToString();
                    ls.Add(role);
                }
                reader.Close();
                conn.Close() ;
                return ls;
            }catch (Exception)
            {
                return new List<RoleDTO>();
            }
        }

    }
}
