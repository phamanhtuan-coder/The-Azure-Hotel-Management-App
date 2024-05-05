using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DonPhongBLL
    {
        DonPhongDAL donPhongDAL = new DonPhongDAL();
        public List<DonPhongDTO> Filter(string tT, string ngayBD, string ngayKT)
        {
            return LoadDuLieuDonPhong();
        }

        public List<DonPhongDTO> LoadDuLieuDonPhong()
        {
            return donPhongDAL.LoadDuLieuDonPhong();
        }

        public List<DonPhongDTO> TraCuuDonPhong(List<DonPhongDTO> donPhongDTOs, string searchKeyword)
        {
            List<DonPhongDTO> searchResults = donPhongDTOs.Where(item =>
             item.MaPhong == int.Parse(searchKeyword)
         ).ToList();
            return searchResults;
        }
    }
}
