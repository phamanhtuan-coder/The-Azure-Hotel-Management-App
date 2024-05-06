using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BaoTriBLL
    {
        BaoTriDAL baoTriDAL = new BaoTriDAL();

        public List<BaoTriDTO> FilterTrangThai(string trangthai)
        {
            if (trangthai == "Đang hoạt động")
            {
                return baoTriDAL.FilterTrangThai(true);
            }
            else if (trangthai == "Đã xóa")
            {
                return baoTriDAL.FilterTrangThai(false);
            }
            else
            {
                return baoTriDAL.layds();
            }
        }

        public bool khoiphucbt(int mabtri)
        {
            return baoTriDAL.khoiphuc(mabtri);
        }

        public List<BaoTriDTO> laydsp()
        {
            return baoTriDAL.layds();
        }
        public List<BaoTriDTO> laydsp2()
        {
            return baoTriDAL.layds2();
        }

        public bool sua(BaoTriDTO baoTriDTO)
        {
            return baoTriDAL.suabt(baoTriDTO);
        }

        public bool them(BaoTriDTO baoTriDTO)
        {
            return baoTriDAL.thembt(baoTriDTO);
        }

        public List<BaoTriDTO> TraCuubt(List<BaoTriDTO> baoTriDTOs, string searchKeyword)
        {
            List<BaoTriDTO> searchResults = baoTriDTOs.Where(item =>
             item.MaBaoTri.ToString().Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public bool Xoabt(int mabtri)
        {
            return baoTriDAL.xoa(mabtri);
        }
    }
}
