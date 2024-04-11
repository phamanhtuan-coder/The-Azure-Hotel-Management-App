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

                    string strTV = "Select MaPhanQuyen, TenVaiTro, MaPhongBan, COUNT(MaTaiKhoan) as SoLuongTK, PhanQuyen.TrangThai " +
                                "From PhanQuyen join VaiTro on PhanQuyen.MaVaiTro=VaiTro.MaVaiTro left join BangTaiKhoan on BangTaiKhoan.MaPQ=PhanQuyen.MaPhanQuyen " +
                                "Where PhanQuyen.TrangThai=1 " +
                                "Group by MaPhanQuyen, TenVaiTro, MaPhongBan, PhanQuyen.TrangThai";

                    SqlDataReader reader = DataProvider.ThucHienTruyVan(strTV, conn);
                    while (reader.Read())
                    {
                        RoleDTO roleDTO = new RoleDTO();

                        roleDTO.MaPhanQuyen = reader["MaPhanQuyen"].ToString();
                        roleDTO.TenVaiTro = reader["TenVaiTro"].ToString();
                        roleDTO.MaPhongBan = reader["MaPhongBan"].ToString();
                        roleDTO.SoLuongTK = (int)reader["SoLuongTK"];
                        roleDTO.TrangThai = reader["TrangThai"].ToString();

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

                    string strTV = "Select MaPhanQuyen, TenVaiTro, MaPhongBan, COUNT(MaTaiKhoan) as SoLuongTK, PhanQuyen.TrangThai " +
                                "From PhanQuyen join VaiTro on PhanQuyen.MaVaiTro=VaiTro.MaVaiTro left join BangTaiKhoan on BangTaiKhoan.MaPQ=PhanQuyen.MaPhanQuyen " +
                                "Where PhanQuyen.TrangThai=0 " +
                                "Group by MaPhanQuyen, TenVaiTro, MaPhongBan, PhanQuyen.TrangThai";

                    SqlDataReader reader = DataProvider.ThucHienTruyVan(strTV, conn);
                    while (reader.Read())
                    {
                        RoleDTO roleDTO = new RoleDTO();

                        roleDTO.MaPhanQuyen = reader["MaPhanQuyen"].ToString();
                        roleDTO.TenVaiTro = reader["TenVaiTro"].ToString();
                        roleDTO.MaPhongBan = reader["MaPhongBan"].ToString();
                        roleDTO.SoLuongTK = (int)reader["SoLuongTK"];
                        roleDTO.TrangThai = reader["TrangThai"].ToString();

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

                string strTV = "Select MaPhanQuyen, TenVaiTro, MaPhongBan, COUNT(MaTaiKhoan) as SoLuongTK, PhanQuyen.TrangThai " +
                                "From PhanQuyen join VaiTro on PhanQuyen.MaVaiTro=VaiTro.MaVaiTro left join BangTaiKhoan on BangTaiKhoan.MaPQ=PhanQuyen.MaPhanQuyen " +
                                "Group by MaPhanQuyen, TenVaiTro, MaPhongBan, PhanQuyen.TrangThai";

                SqlDataReader reader = DataProvider.ThucHienTruyVan(strTV, conn);
                while (reader.Read())
                {
                    RoleDTO roleDTO = new RoleDTO();
                    roleDTO.MaPhanQuyen = reader["MaPhanQuyen"].ToString();
                    roleDTO.TenVaiTro = reader["TenVaiTro"].ToString();
                    roleDTO.MaPhongBan = reader["MaPhongBan"].ToString();
                    roleDTO.SoLuongTK = (int)reader["SoLuongTK"];
                    roleDTO.TrangThai = reader["TrangThai"].ToString() ;

                    ls.Add(roleDTO);
                }
                reader.Close();
                conn.Close();
                return ls;
            }catch (Exception) {
                return ls;
            }
        }

        public List<TenPB> LoadPBDAL()
        {
            List<TenPB> ls = new List<TenPB>();
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                string sql = "Select MaPhongBan, TenPhong From PhongBan";
                SqlDataReader reader = DataProvider.ThucHienTruyVan(sql, conn);

                while (reader.Read())
                {
                    TenPB tenPB = new TenPB();
                    tenPB.MaPhongBan = reader["MaPhongBan"].ToString();
                    tenPB.TenPhongBan = reader["TenPhong"].ToString();
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
                SqlCommand com = new SqlCommand("sp_CapNhatTrangThaiPhanQuyen", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaPhanQuyen", pq);
                com.Parameters.AddWithValue("@TrangThai", 0);
                int count = com.ExecuteNonQuery();  
                conn.Close();

                if (count > 0) return true;
                else return false;         
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

        //public static string maPBDAL(string v)
        //{
        //    string kq = "";
        //    try
        //    {
        //        SqlConnection conn = DataProvider.KetNoiDuLieu();
        //        conn.Open();

        //        string sql = $"Select MaPhongBan From PhongBan where PhongBan.TenPhong like N'@MaPhongBan' And TrangThai=1";
        //        SqlParameter parMaPhongBan = new SqlParameter("@MaPhongBan", v);

        //        SqlDataReader com = DataProvider.ThucHienTruyVan(sql, conn);
        //        while (com.Read())
        //        {
        //            kq= com["MaPhongBan"].ToString() ;
        //        }
        //        com.Close();
        //        conn.Close();
        //        return kq;
        //    }
        //    catch (Exception)
        //    {
        //        return kq;
        //    }
        //}
    }
}
