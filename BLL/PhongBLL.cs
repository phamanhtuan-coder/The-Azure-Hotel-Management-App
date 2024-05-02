﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class PhongBLL
    {
        PhongDAL PhongDAL=new PhongDAL();

        public List<PhongDTO> FilterTrangThai(string trangthai)
        {
            if (trangthai == "Đang hoạt động")
            {
                return PhongDAL.FilterTrangThai(true);
            }
            else if (trangthai == "Đã xóa")
            {
                return PhongDAL.FilterTrangThai(false);
            }
            else
            {
                return PhongDAL.laydsphong();
            }
        }

        public bool kpp(int maphong)
        {
            return PhongDAL.kqphong(maphong);
        }

        public List<PhongDTO> laydsp()
        {
            return PhongDAL.laydsphong();
        }

        public bool suap(PhongDTO phongDTO)
        {
            return PhongDAL.suaphong(phongDTO);
        }

        public bool themp(PhongDTO phongDTO)
        {
            return PhongDAL.themphong(phongDTO);
        }

        public List<PhongDTO> TraCuuPhong(List<PhongDTO> phongDTOs, string searchKeyword)
        {
            List<PhongDTO> searchResults = phongDTOs.Where(item =>
             item.MaPHG.ToString().Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public bool Xoap(int maphong)
        {
            return PhongDAL.xoaphong(maphong);
        }
    }
}
