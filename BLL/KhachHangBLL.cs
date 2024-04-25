using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL khachHangDAL = new KhachHangDAL();
        TaiKhoanDAL TaiKhoanDAL = new TaiKhoanDAL();

        public bool AddKhachHangBLL(KhachHangDTO khachHang)
        {
            if (!string.IsNullOrEmpty(khachHang.HoTenKH.Trim()) && !string.IsNullOrEmpty(khachHang.CCCD.Trim()) && !string.IsNullOrEmpty(khachHang.TenDangNhap.Trim()) && !string.IsNullOrEmpty(khachHang.DiaChi.Trim()) && !string.IsNullOrEmpty(khachHang.GioiTinh.Trim()) && !string.IsNullOrEmpty(khachHang.SDT.Trim()) && khachHang.MaLoaiHangThanhVien>0)
            {
                return khachHangDAL.AddKhachHangDAL(khachHang);
            }
            else
            {
                return false;
            }
        }

        public bool EditKhachHangBLL(KhachHangDTO khachHang)
        {
            if (khachHang.MaKH>0&&!string.IsNullOrEmpty(khachHang.HoTenKH.Trim()) && !string.IsNullOrEmpty(khachHang.CCCD.Trim()) && !string.IsNullOrEmpty(khachHang.TenDangNhap.Trim()) && !string.IsNullOrEmpty(khachHang.DiaChi.Trim()) && !string.IsNullOrEmpty(khachHang.GioiTinh.Trim()) && !string.IsNullOrEmpty(khachHang.SDT.Trim()) && khachHang.MaLoaiHangThanhVien > 0)
            {
                return khachHangDAL.EditKhachHangDAL(khachHang);
            }
            else
            {
                return false;
            }
        }

        public List<KhachHangDTO> Filer(int maHang, string gioiTinh, string tT)
        {
            return khachHangDAL.Filter(maHang, gioiTinh, tT);
        }

        public bool KhoiPhucKhachHangBLL(int maKH)
        {
            if (maKH > 0)
            {
                return khachHangDAL.KhoiPhucNhanVienDAL(maKH);
            }
            else
            {
                return false;
            }
        }

        public List<KhachHangDTO> TraCuuNhanVien(List<KhachHangDTO> khachHangDTOs, string searchKeyword)
        {
            List<KhachHangDTO> searchResults = khachHangDTOs.Where(item =>
             item.HoTenKH.ToLower().Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public string TruyVanUsernameBLL()
        {
            return TaiKhoanDAL.TruyVanUsernameDAL();
        }

        public bool XoaNhanVienBLL(int maKH)
        {
            if (maKH > 0)
            {
                return khachHangDAL.XoaNhanVienDAL(maKH);
            }
            else
            {
                return false;
            }
        }
    }
}
