using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SQLConnectionManager
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;

        public SQLConnectionManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = ".";
            database = "UngDungQuanLyKhachSan";
            uid = "visualstudiopro";
            password = "laptrinhwindows";

            connectionString =
                $"Data Source={server};Initial Catalog={database};Integrated Security=true;";
        }

        public string GetConnectionString()
        {
            return connectionString;
        }

        public SqlConnection openConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public void closeConnection(SqlConnection connection)
        {
            connection.Close();
        }

    }
}
