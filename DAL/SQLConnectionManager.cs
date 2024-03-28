using System;
using System.Collections.Generic;
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
            server = "visualstudiopro.ddns.net";
            database = "demo";
            uid = "visualstudiopro";
            password = "laptrinhwindows";
            

            connectionString = $"Server={server};Port=3306; Database={database};Uid={uid};Pwd={password};";
        }

        public string GetConnectionString()
        {
            return connectionString;
        }

    }
}
