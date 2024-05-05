﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DonPhongDAL
    {
        List<DonPhongDTO> list = new List<DonPhongDTO>(); 
        public List<DonPhongDTO> LoadDuLieuDonPhong()
        {
            try
            {
                SqlConnection conn = DataProvider.KetNoiDuLieu();
                conn.Open();

                SqlCommand com = new SqlCommand("spTruyVanDSDonPhong", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;               
                SqlDataReader reader = com.ExecuteReader();
                list = new List<DonPhongDTO>();
                while (reader.Read())
                {
                    DonPhongDTO donPhongDTO = new DonPhongDTO();
                    donPhongDTO.MaDonPhong = (int) reader["MaDonPhong"];
                    donPhongDTO.MaPhong = (int) reader["MaPhong"];
                    donPhongDTO.MaNV = (int)reader["MaNV"];
                    donPhongDTO.NgayNhan = DateTime.Parse(reader["NgayNhan"].ToString());
                    object ngayHoanThanhObject = reader["NgayHoanThanh"];
                    if (ngayHoanThanhObject != DBNull.Value)
                    {
                        donPhongDTO.NgayHoanThanh = DateTime.Parse(ngayHoanThanhObject.ToString());
                    }
                    else
                    {
                        donPhongDTO.NgayHoanThanh = null;
                    }
                    byte[] trangThaiBytes = (byte[])reader["TrangThai"];
                    donPhongDTO.TrangThai = BitConverter.ToBoolean(trangThaiBytes, 0);
                    list.Add(donPhongDTO);
                }
                reader.Close();
                conn.Close();

                return list;
            }
            catch (Exception)
            {
                return new List<DonPhongDTO>();
            }
        }
    }
}
