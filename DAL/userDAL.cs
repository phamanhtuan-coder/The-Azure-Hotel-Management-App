using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class userDAL
    {
        private string connectionString;

        public userDAL()
        {
            SQLConnectionManager connectionManager= new SQLConnectionManager();
            this.connectionString = connectionManager.GetConnectionString();
        }
        
        
        //public bool XacThucDangNhap(string username, string password)
        //{

            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            //{
            //    try
            //    {
            //        string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            //        MySqlCommand command = new MySqlCommand(query, connection);

            //        command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = username;
            //        command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = password;

            //        connection.Open();
            //        object result = command.ExecuteScalar();
            //        int count = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            //        return count > 0;
            //    }
            //    catch (MySqlException ex)
            //    {
            //        // Log or handle the exception appropriately
            //        Console.WriteLine("MySQL Exception: " + ex.ToString());
            //        return false;
            //    }
                
            //}

        //}
    }
}
