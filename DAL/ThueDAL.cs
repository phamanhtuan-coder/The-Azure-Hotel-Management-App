﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThueDAL
    {
        List<ThueDTO> list = new List<ThueDTO>();

        public bool AddThue(ThueDTO thueDTO)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spThemThe", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TenThue", thueDTO.TenThue);
                com.Parameters.AddWithValue("@TyLeThue", thueDTO.TyLeThue);
                com.Parameters.AddWithValue("@MoTa", thueDTO.MoTa);

                int count = com.ExecuteNonQuery();
                conn.Close();

                return count>0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditThue(ThueDTO thueDTO)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spCapNhatThue", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaThue", thueDTO.MaThue);
                com.Parameters.AddWithValue("@TenThue", thueDTO.TenThue);
                com.Parameters.AddWithValue("@TyLeThue", thueDTO.TyLeThue);
                com.Parameters.AddWithValue("@MoTa", thueDTO.MoTa);

                int count = com.ExecuteNonQuery();
                conn.Close();

                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool XoaThue(int maThue)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTTCapNhatThue", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaThue", maThue);
                com.Parameters.AddWithValue("@TrangThai", 0);

                int count = com.ExecuteNonQuery();
                conn.Close();

                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool KhoiPhucThue(int maThue)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTTCapNhatThue", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaThue", maThue);
                com.Parameters.AddWithValue("@TrangThai", 1);

                int count = com.ExecuteNonQuery();
                conn.Close();

                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<ThueDTO> TruyVanDSThue()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanDSThue", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                list = new List<ThueDTO>();
                while (reader.Read())
                {
                    ThueDTO thueDTO = new ThueDTO();

                    thueDTO.MaThue = (int)reader["MaThue"];
                    thueDTO.TenThue = reader["TenThue"].ToString();
                    thueDTO.TyLeThue = (double) reader["TyLeThue"] ;
                    thueDTO.MoTa = reader["MoTa"].ToString();
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    thueDTO.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);

                    list.Add(thueDTO);
                }

                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<ThueDTO>();
            }
        }

        public List<ThueDTO> TruyVanTenVaMaThue()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanTenVaMaThue", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                list = new List<ThueDTO>();
                while (reader.Read())
                {
                    ThueDTO thueDTO = new ThueDTO();

                    thueDTO.MaThue = (int)reader["MaThue"];
                    thueDTO.TenThue = reader["TenThue"].ToString();

                    list.Add(thueDTO);
                }

                conn.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<ThueDTO>();
            }
        }       
    }
}