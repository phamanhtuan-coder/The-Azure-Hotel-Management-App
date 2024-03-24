using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class userBLL
    {
        private userDAL userDAL;

        public userBLL()
        {
            userDAL = new userDAL();
        }

        public bool KiemTraDangNhap(string username, string password)
        {
            
            return userDAL.XacThucDangNhap(username, password);
        }
    }
}
