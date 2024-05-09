using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public bool AddNhanVienBLL(NhanVienDTO nhanvien)
        {
            if (!string.IsNullOrEmpty(nhanvien.HoTenNV.Trim()) && !string.IsNullOrEmpty(nhanvien.CCCD.Trim()) && !string.IsNullOrEmpty(nhanvien.TenTaiKhoan.Trim()) && nhanvien.Luong>0 && !string.IsNullOrEmpty(nhanvien.DiaChi.Trim()) && !string.IsNullOrEmpty(nhanvien.GioiTinh.Trim())&& !string.IsNullOrEmpty(nhanvien.SDT.Trim()))
            {
                nhanvien.HoTenNV = KiemTraInput.ChuanHoaHoTen(nhanvien.HoTenNV);
                return nhanVienDAL.AddNhanVienDAL(nhanvien);
            }
            else
            {
                return false;
            }
            
        }

        public bool EditNhanVienBLL(NhanVienDTO nhanvien)
        {
            if (!string.IsNullOrEmpty(nhanvien.HoTenNV.Trim()) && !string.IsNullOrEmpty(nhanvien.CCCD.Trim()) && !string.IsNullOrEmpty(nhanvien.TenTaiKhoan.Trim()) && nhanvien.Luong > 0 && !string.IsNullOrEmpty(nhanvien.DiaChi.Trim()) && !string.IsNullOrEmpty(nhanvien.GioiTinh.Trim()) && !string.IsNullOrEmpty(nhanvien.SDT.Trim()))
            {
                nhanvien.HoTenNV = KiemTraInput.ChuanHoaHoTen(nhanvien.HoTenNV);
                return nhanVienDAL.EditNhanVienDAL(nhanvien);
            }
            else
            {
                return false;
            }
        }

        public bool XoaNhanVienBLL(int maNV)
        {
            if (maNV > 0)
            {
                return nhanVienDAL.XoaNhanVienDAL(maNV);
            }
            else
            {
                return false;
            }
        }

        public bool KhoiPhucNhanVienBLL(int maNV)
        {
            if (maNV > 0)
            {
                return nhanVienDAL.KhoiPhucNhanVienDAL(maNV);
            }
            else
            {
                return false;
            }
        }

        public List<NhanVienDTO> Filer(int PhanQuyen, string PhongBan, string GioiTinh, int NguoiQuanLy, string TrangThai)
        {
            return nhanVienDAL.Filter(PhanQuyen, PhongBan, GioiTinh, NguoiQuanLy, TrangThai);
        }    

        public List<NhanVienDTO> LoadIDAndNameBLL()
        {
            return nhanVienDAL.LoadIDAndNameDAL();
        }

        public List<NhanVienDTO> TraCuuNhanVien(List<NhanVienDTO> dsNV, string searchKeyword)
        {
            List<NhanVienDTO> searchResults = dsNV.Where(item =>
             item.HoTenNV.ToLower().Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public string TruyVanUsernameBLL()
        {
            return nhanVienDAL.TruyVanUsernameDAL();
        }

        public List<NhanVienDTO> TruyVanTenVaMaNhanVien()
        {
            return nhanVienDAL.TruyVanTenVaMaNhanVien();
        }

        public List<NhanVienDTO> LoadIDAndNameBLLDonPhong()
        {
            return nhanVienDAL.LoadIDAndNameBLLDonPhong();
        }
    }
}
