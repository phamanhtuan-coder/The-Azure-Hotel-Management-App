using System;
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

        public bool KhoiPhucttp(int mattphong)
        {
            return TinhTrangPhongDAL.khoiphucttphong(mattphong);
        }

        public List<TinhTrangPhongDTO> laydsttphong()
        {
            return TinhTrangPhongDAL.laydsttphong();
        }

        public bool suattphong(TinhTrangPhongDTO tinhTrang)
        {
            return TinhTrangPhongDAL.suattp(tinhTrang);
        }

        public bool themttphong(TinhTrangPhongDTO tinhTrang)
        {
            return TinhTrangPhongDAL.themttp(tinhTrang);
        }

        public bool Xoattp(int mattphong)
        {
            return TinhTrangPhongDAL.xoattphong(mattphong);
        }
    }
}
