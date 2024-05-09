﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhongDAL
    {
        public List<PhongDTO> FilterTrangThai(bool v)
        {
            List<PhongDTO> dsPhong = new List<PhongDTO>();

            string lenhLayDanhSachPhong = "SELECT * FROM Phong WHERE TrangThai = @TrangThai";

            SqlConnection conn = DataProvider.KetNoiDuLieu();

            conn.Open();

            SqlDataReader reader = DataProvider.ThucHienTruyVan(lenhLayDanhSachPhong, conn, "@TrangThai", SqlDbType.Binary, v ? (object)1 : (object)0);
            while (reader.Read())
            {
                PhongDTO PhongDTO = new PhongDTO();
                PhongDTO.MaPHG = (int)reader[0];
                PhongDTO.MaLoai = (int)reader[1];
                PhongDTO.MaTinhTrangPhong = (int)reader[2];
                PhongDTO.HinhAnh = reader["HinhAnh"] as byte[];
                PhongDTO.MoTa = reader[4].ToString();
                PhongDTO.GiaPhong = (decimal)reader[5];
                PhongDTO.SucChuaToiDa = (int)reader[6];
                PhongDTO.TrangThai = v;

                dsPhong.Add(PhongDTO);
            }

            return dsPhong;
        }

        public bool kqphong(int maphong)
        {
            string lenhkpphong =
                "UPDATE Phong SET TrangThai = 1 WHERE MaPHG = @MaPHG";
            SqlParameter par = new SqlParameter("@MaPHG", maphong);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhkpphong, conn, par);
            conn.Close();
            return kq > 0;
        }

        public List<PhongDTO> laydsphong()
        {
            List<PhongDTO> dsp = new List<PhongDTO>();
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            string strlaydanhsach = "select * from Phong";
            conn.Open();
            SqlDataReader reader = DataProvider.ThucHienTruyVan(strlaydanhsach, conn);
            while (reader.Read())
            {
                PhongDTO phong = new PhongDTO();
                phong.MaPHG = (int)reader[0];
                phong.MaLoai =(int) reader[1];
                phong.MaTinhTrangPhong = (int)reader[2];
                phong.HinhAnh = reader["HinhAnh"] as byte[];
                phong.MoTa = reader[4].ToString();
                phong.GiaPhong = (decimal)reader[5];
                phong.SucChuaToiDa = (int)reader[6];
                byte[] trangThaiBytes = (byte[])reader[7];
                bool trangThai = trangThaiBytes[0] == 1;
                phong.TrangThai = trangThai;
                dsp.Add(phong);
            }
            reader.Close();
            conn.Close();
            return dsp;
        }

        public bool suaphong(PhongDTO phongDTO)
        {
            string lenhCapNhatphong =
                "UPDATE Phong SET MaLoai = @MaLoai, MaTinhTrangPhong = @MaTinhTrangPhong,MoTa=@MoTa,GiaPhong=@GiaPhong,SucChuaToiDa=@SucChuaToiDa,HinhAnh=@HinhAnh WHERE MaPHG = @MaPHG";
            SqlParameter[] pars = new SqlParameter[7];

            pars[0] = new SqlParameter("MaPHG", phongDTO.MaPHG);
            pars[1] = new SqlParameter("MaTinhTrangPhong", phongDTO.MaTinhTrangPhong);
            pars[2] = new SqlParameter("MaLoai", phongDTO.MaLoai);
            pars[3] = new SqlParameter("MoTa", phongDTO.MoTa);
            pars[4] = new SqlParameter("GiaPhong", phongDTO.GiaPhong);
            pars[5] = new SqlParameter("SucChuaToiDa", phongDTO.SucChuaToiDa);
            pars[6] = new SqlParameter("HinhAnh", phongDTO.HinhAnh);


            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhCapNhatphong, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool themphong(PhongDTO phongDTO)
        {
            string lenhThemphong =
                "INSERT INTO Phong (MaLoai, MaTinhTrangPhong,HinhAnh,MoTa,GiaPhong,SucChuaToiDa,TrangThai) VALUES (@MaLoai, @MaTinhTrangPhong,@HinhAnh,@MoTa,@GiaPhong,@SucChuaToiDa, 1)";

            SqlParameter[] pars = new SqlParameter[6];
            pars[0] = new SqlParameter("MaLoai", phongDTO.MaLoai);
            pars[1] = new SqlParameter("MaTinhTrangPhong", phongDTO.MaTinhTrangPhong);
            pars[2] = new SqlParameter("MoTa",phongDTO.MoTa);
            pars[3] = new SqlParameter("GiaPhong", phongDTO.GiaPhong);
            pars[4] = new SqlParameter("SucChuaToiDa", phongDTO.SucChuaToiDa);
            pars[5] = new SqlParameter("HinhAnh", phongDTO.HinhAnh);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhThemphong, conn, pars);
            conn.Close();
            return kq > 0;
        }

        public bool xoaphong(int maphong)
        {
            string lenhXoaphong =
                "UPDATE Phong SET TrangThai = 0 WHERE MaPHG = @MaPHG";
            SqlParameter par = new SqlParameter("@MaPHG", maphong);
            SqlConnection conn = DataProvider.KetNoiDuLieu();
            conn.Open();
            int kq = DataProvider.ThucHienCauLenh(lenhXoaphong, conn, par);
            conn.Close();
            return kq > 0;
        }
    }
}
