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
            if(baoTriDTO.MaBaoTri>0 && baoTriDTO.MaThietBi > 0)
            {
                return baoTriDAL.suabt(baoTriDTO);
            }
            return false;
        }

        public bool them(BaoTriDTO baoTriDTO)
        {
            if (baoTriDTO.MaThietBi > 0)
            {
                return baoTriDAL.thembt(baoTriDTO);
            }
            return false;          
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
