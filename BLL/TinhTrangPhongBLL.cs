﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class TinhTrangPhongBLL
    {
        TinhTrangPhongDAL TinhTrangPhongDAL = new TinhTrangPhongDAL();

        public List<TinhTrangPhongDTO> FilterTrangThai(string trangthai)
        {
            if (trangthai == "Đang hoạt động")
            {
                return TinhTrangPhongDAL.FilterTrangThai(true);
            }
            else if (trangthai == "Đã xóa")
            {
                return TinhTrangPhongDAL.FilterTrangThai(false);
            }
            else
            {
                return TinhTrangPhongDAL.laydsttphong();
            }
        }

        public bool KhoiPhucttp(int mattphong)
        {
            return TinhTrangPhongDAL.khoiphucttphong(mattphong);
        }

        public List<TinhTrangPhongDTO> laydsttphong()
        {
            return TinhTrangPhongDAL.laydsttphong();
        }

        public List<TinhTrangPhongDTO> laydsttphong2()
        {
            return TinhTrangPhongDAL.laydsttphong2();
        }

        public List<TinhTrangPhongDTO> laydsttphong3()
        {
            return TinhTrangPhongDAL.laydsttphong3();
        }

        public bool suattphong(TinhTrangPhongDTO tinhTrang)
        {
            if (!string.IsNullOrWhiteSpace(tinhTrang.TenTinhTrang) && tinhTrang.MaTinhTrangPhong > 0)
            {
                return TinhTrangPhongDAL.suattp(tinhTrang);
            }
            return false;
        }

        public bool themttphong(TinhTrangPhongDTO tinhTrang)
        {
            if (!string.IsNullOrWhiteSpace(tinhTrang.TenTinhTrang))
            {
                return TinhTrangPhongDAL.themttp(tinhTrang);
            }
            return false;
        }

        public List<TinhTrangPhongDTO> TraCuuttPhong(List<TinhTrangPhongDTO> tinhTrangPhongDTOs, string searchKeyword)
        {
            List<TinhTrangPhongDTO> searchResults = tinhTrangPhongDTOs.Where(item =>
             item.TenTinhTrang.Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public bool Xoattp(int mattphong)
        {
            return TinhTrangPhongDAL.xoattphong(mattphong);
        }
    }
}
