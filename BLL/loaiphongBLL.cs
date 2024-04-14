using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    
    public class LoaiPhongBLL
    {
        LoaiPhongDAL loaiphong = new LoaiPhongDAL();

        public static bool Xoaloaip(int maloaiphong)
        {
            return LoaiPhongDAL.xoaloaiphong(maloaiphong);
        }
        public static bool KhoiPhucloaip(int maloaiphong)
        {
            return LoaiPhongDAL.khoiphucloaiphong(maloaiphong);
        }


        public List<LoaiPhongDTO> laydslphong()
        {
            return loaiphong.laydsloaiphong();
        }

        public bool sualoaiphong(LoaiPhongDTO loaiphongDTO)
        {
            return loaiphong.sualphong(loaiphongDTO);
        }

        public bool themloaiphong(LoaiPhongDTO loaiphongDTO)
        {
            return loaiphong.themlphong(loaiphongDTO);
        }

        public List<LoaiPhongDTO> TraCuuLoaiPhong(List<LoaiPhongDTO> dsloaip, string searchKeyword)
        {
            List<LoaiPhongDTO> searchResults = dsloaip.Where(item =>
             item.TenLoai.Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public List<LoaiPhongDTO> FilterTrangThai(string trangthai)
        {
            if (trangthai == "Đang hoạt động")
            {
                return loaiphong.FilterTrangThai(true);
            }
            else if (trangthai == "Đã xóa")
            {
                return loaiphong.FilterTrangThai(false);
            }
            else
            {
                return loaiphong.laydsloaiphong();
            }
        }
    }
}
