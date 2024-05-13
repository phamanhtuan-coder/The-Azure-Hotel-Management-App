using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Net.NetworkInformation;

namespace BLL
{
    public class DatDichVuBLL
    {
        DatDichVuDAL datDichVuDAL = new DatDichVuDAL();

        public List<DatDichVuDTO> FilterTrangThai(string trangthai)
        {
            if (trangthai == "Đang hoạt động")
            {
                return datDichVuDAL.FilterTrangThai(true);
            }
            else if (trangthai == "Đã xóa")
            {
                return datDichVuDAL.FilterTrangThai(false);
            }
            else
            {
                return datDichVuDAL.layds();
            }
        }

        public bool khoiphucddv(int MaDatDichVu)
        {
            return datDichVuDAL.khoiphuc(MaDatDichVu);
        }
        public void thanhtien(int MaDatDichVu)
        {
            datDichVuDAL.thanhtien(MaDatDichVu);
        }
        public List<DatDichVuDTO> laydsddv()
        {
            return datDichVuDAL.layds();
        }
        public DatDichVuDTO mamoi()
        {
            return datDichVuDAL.mamoi();
        }
        public bool sua(DatDichVuDTO datDichVuDTO)
        {
            if (datDichVuDTO.MaDatDichVu > 0 && datDichVuDTO.MaDV > 0 && datDichVuDTO.SoLuong > 0)
            {
                return datDichVuDAL.suaddv(datDichVuDTO);
            }
            return false;
        }

        public bool them(DatDichVuDTO datDichVuDTO)
        {
            if (datDichVuDTO.MaDV>0 && datDichVuDTO.SoLuong>0)
            {
                return datDichVuDAL.themddv(datDichVuDTO);
            }
            return false;
        }

        public List<DatDichVuDTO> TraCuudv(List<DatDichVuDTO> datDichVuDTOs, string searchKeyword)
        {
            List<DatDichVuDTO> searchResults = datDichVuDTOs.Where(item =>
             item.MaDatDichVu.ToString().Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public bool Xoaddv(int MaDatDichVu)
        {
            return datDichVuDAL.xoa(MaDatDichVu);
        }

        public List<DatDichVuDTO> TraCuungay(List<DatDichVuDTO> datDichVuDTOs, DateTime searchKeyword)
        {
            List<DatDichVuDTO> searchResults =
                datDichVuDTOs.Where
                (item =>  item.NgayDat.Date ==searchKeyword).ToList();
            return searchResults;
        }
    }
}
