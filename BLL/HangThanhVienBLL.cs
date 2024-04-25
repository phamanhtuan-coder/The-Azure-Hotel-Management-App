﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HangThanhVienBLL
    {
        HangThanhVienDAL hangThanhVienDAL = new HangThanhVienDAL();

        public bool AddHangThanhVien(HangThanhVienDTO hangThanhVienDTO)
        {
            if(!string.IsNullOrEmpty(hangThanhVienDTO.TenHang.Trim())&& hangThanhVienDTO.MucGiamGia > 0)
            {
                return hangThanhVienDAL.AddHangThanhVien(hangThanhVienDTO);
            }
            return false;
        }

        public List<HangThanhVienDTO> Filer(string trangthai)
        {
            if (trangthai.Length > 0)
            {
                return hangThanhVienDAL.Filer(trangthai);
            }
            return new List<HangThanhVienDTO>();
        }

        public List<HangThanhVienDTO> TraCuuNhanVien(List<HangThanhVienDTO> hangThanhVienDTOs, string searchKeyword)
        {
            List<HangThanhVienDTO> searchResults = hangThanhVienDTOs.Where(item =>
              item.TenHang.ToLower().Contains(searchKeyword)
          ).ToList();
            return searchResults;
        }
    }
}
