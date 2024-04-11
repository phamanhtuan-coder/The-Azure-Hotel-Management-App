using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    
    public class loaiphongBLL
    {
        loaiphongDAL loaiphong = new loaiphongDAL();

        public static bool Xoaloaip(int maloaiphong)
        {
            return loaiphongDAL.xoaloaiphong(maloaiphong);
        }
        public static bool KhoiPhucloaip(int maloaiphong)
        {
            return loaiphongDAL.khoiphucloaiphong(maloaiphong);
        }


        public List<loaiphongDTO> laydslphong()
        {
            return loaiphong.laydsloaiphong();
        }

        public bool sualoaiphong(loaiphongDTO loaiphongDTO)
        {
            return loaiphong.sualphong(loaiphongDTO);
        }

        public bool themloaiphong(loaiphongDTO loaiphongDTO)
        {
            return loaiphong.themlphong(loaiphongDTO);
        }
    }
}
