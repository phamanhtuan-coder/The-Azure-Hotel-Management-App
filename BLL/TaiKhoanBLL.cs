using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

        public string AddTaiKhoanBLL(TaiKhoanDTO taiKhoanDTO)
        {
            string a= taiKhoanDAL.AddTaiKhoanDAL(taiKhoanDTO);
            return a;
        }

        public List<TaiKhoanDTO> Filter()
        {
            return taiKhoanDAL.Filter();
        }
    }
}
