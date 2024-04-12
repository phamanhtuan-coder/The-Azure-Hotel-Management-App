﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class NhanVienDAL
    {
        List<NhanVienDTO> list = new List<NhanVienDTO>();

        public List<NhanVienDTO> LoadDSNhanVienDAL()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanNhanVien", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                list = new List<NhanVienDTO>();
                while (reader.Read())
                {
                    NhanVienDTO nhanVien = new NhanVienDTO();
                    
                    nhanVien.MaNV = (int)(reader["MaNV"]);
                    nhanVien.MaNQL = reader["MaNQL"] as int?;
                    nhanVien.MaTaiKhoan = (int)(reader["MaTaiKhoan"]);
                    nhanVien.HinhAnh = reader["HinhAnh"] as byte[];
                    nhanVien.HoTenNV = reader["HoTenNV"] as string;
                    nhanVien.SDT = reader["SDT"] as string;
                    nhanVien.Email = reader["Email"] as string;
                    nhanVien.CCCD = reader["CCCD"] as string;
                    nhanVien.NgaySinh = (DateTime)reader["NgaySinh"];
                    nhanVien.DiaChi = reader["DiaChi"] as string;
                    nhanVien.Luong = (decimal)reader["Luong"];
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    nhanVien.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    nhanVien.GioiTinh = reader["GioiTinh"].ToString();

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

        public List<NhanVienDTO> LoadDSNhanVienGTDAL(string text)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanNhanVienGT", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@GioiTinh", text);
                SqlDataReader reader = com.ExecuteReader();
                list = new List<NhanVienDTO>();
                while (reader.Read())
                {
                    NhanVienDTO nhanVien = new NhanVienDTO();

                    nhanVien.MaNV = (int)(reader["MaNV"]);
                    nhanVien.MaNQL = reader["MaNQL"] as int?;
                    nhanVien.MaTaiKhoan = (int)(reader["MaTaiKhoan"]);
                    nhanVien.HinhAnh = reader["HinhAnh"] as byte[];
                    nhanVien.HoTenNV = reader["HoTenNV"] as string;
                    nhanVien.SDT = reader["SDT"] as string;
                    nhanVien.Email = reader["Email"] as string;
                    nhanVien.CCCD = reader["CCCD"] as string;
                    nhanVien.NgaySinh = (DateTime)reader["NgaySinh"];
                    nhanVien.DiaChi = reader["DiaChi"] as string;
                    nhanVien.Luong = (decimal)reader["Luong"];
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    nhanVien.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    nhanVien.GioiTinh = reader["GioiTinh"].ToString();

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

        public List<NhanVienDTO> LoadDSNhanVienGTTTDAL(string text, int v)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanNhanVienGTTT", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TrangThai", v);
                com.Parameters.AddWithValue("@GioiTinh", text);
                SqlDataReader reader = com.ExecuteReader();
                list = new List<NhanVienDTO>();
                while (reader.Read())
                {
                    NhanVienDTO nhanVien = new NhanVienDTO();

                    nhanVien.MaNV = (int)(reader["MaNV"]);
                    nhanVien.MaNQL = reader["MaNQL"] as int?;
                    nhanVien.MaTaiKhoan = (int)(reader["MaTaiKhoan"]);
                    nhanVien.HinhAnh = reader["HinhAnh"] as byte[];
                    nhanVien.HoTenNV = reader["HoTenNV"] as string;
                    nhanVien.SDT = reader["SDT"] as string;
                    nhanVien.Email = reader["Email"] as string;
                    nhanVien.CCCD = reader["CCCD"] as string;
                    nhanVien.NgaySinh = (DateTime)reader["NgaySinh"];
                    nhanVien.DiaChi = reader["DiaChi"] as string;
                    nhanVien.Luong = (decimal)reader["Luong"];
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    nhanVien.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    nhanVien.GioiTinh = reader["GioiTinh"].ToString();

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

        public List<NhanVienDTO> LoadDSNhanVienTTDAL(int v)
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanNhanVienTT", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TrangThai", v);
                SqlDataReader reader = com.ExecuteReader();
                list = new List<NhanVienDTO>();
                while (reader.Read())
                {
                    NhanVienDTO nhanVien = new NhanVienDTO();

                    nhanVien.MaNV = (int)(reader["MaNV"]);
                    nhanVien.MaNQL = reader["MaNQL"] as int?;
                    nhanVien.MaTaiKhoan = (int)(reader["MaTaiKhoan"]);
                    nhanVien.HinhAnh = reader["HinhAnh"] as byte[];
                    nhanVien.HoTenNV = reader["HoTenNV"] as string;
                    nhanVien.SDT = reader["SDT"] as string;
                    nhanVien.Email = reader["Email"] as string;
                    nhanVien.CCCD = reader["CCCD"] as string;
                    nhanVien.NgaySinh = (DateTime)reader["NgaySinh"];
                    nhanVien.DiaChi = reader["DiaChi"] as string;
                    nhanVien.Luong = (decimal)reader["Luong"];
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    nhanVien.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    nhanVien.GioiTinh = reader["GioiTinh"].ToString();

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
