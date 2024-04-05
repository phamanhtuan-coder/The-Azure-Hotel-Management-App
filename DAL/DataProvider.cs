﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DataProvider
    {
        private static string server = ".";
        private static string database = "UngDungQuanLyKhachSan";
        private static string uid = "trumServer";
        private static string password = "@dminVisual2022";
        private static string connectionString =
            $"Data Source={server};Initial Catalog={database};Integrated Security=true;";

        public static SqlConnection KetNoiDuLieu()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }

        public static SqlDataReader ThucHienTruyVan(string query, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            return cmd.ExecuteReader();
        }

        public static SqlDataReader ThucHienTruyVan(
            string query,
            SqlConnection conn,
            SqlParameter[] parameters
        )
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(parameters);
            return cmd.ExecuteReader();
        }

        public static int ThucHienCapNhat(string query, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            return cmd.ExecuteNonQuery();
        }

        public static int ThucHienCapNhat(string query, SqlConnection conn, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(parameters);
            return cmd.ExecuteNonQuery();
        }
    }
}