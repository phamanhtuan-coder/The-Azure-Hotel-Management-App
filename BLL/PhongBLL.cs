using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhongBLL
    {
        private PhongDAL phongDAL = new PhongDAL();

        public PhongBLL()
        {
           
        }

        public List<PhongDTO> GetAvailableRooms()
        {
            try
            {
                return phongDAL.GetAvailableRooms();
            }
            catch (Exception ex)
            {
             
                throw ex;
            }
        }
    }
}
