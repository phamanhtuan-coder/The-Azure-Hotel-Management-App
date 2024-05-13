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
            if (!string.IsNullOrWhiteSpace(khachHang.HoTenKH.Trim()) && !string.IsNullOrWhiteSpace(khachHang.CCCD.Trim()) && !string.IsNullOrWhiteSpace(khachHang.TenDangNhap.Trim()) && !string.IsNullOrWhiteSpace(khachHang.DiaChi.Trim()) && !string.IsNullOrWhiteSpace(khachHang.GioiTinh.Trim()) && !string.IsNullOrWhiteSpace(khachHang.SDT.Trim()) && khachHang.MaLoaiHangThanhVien>0)
            {
                return khachHangDAL.AddKhachHangDAL(khachHang);
            }
            else
            {
                return false;
            }
        }

        public bool AddKhachHangBLL(TaiKhoanDTO taiKhoanDTO, KhachHangDTO khachHangDTO)
        {
            if (!string.IsNullOrWhiteSpace(khachHangDTO.HoTenKH.Trim()) && !string.IsNullOrWhiteSpace(khachHangDTO.CCCD.Trim()) && !string.IsNullOrWhiteSpace(khachHangDTO.DiaChi.Trim()) && !string.IsNullOrWhiteSpace(khachHangDTO.GioiTinh.Trim()) && !string.IsNullOrWhiteSpace(khachHangDTO.SDT.Trim()) && khachHangDTO.MaLoaiHangThanhVien > 0)
            {
                return khachHangDAL.AddKhachHangDAL(taiKhoanDTO, khachHangDTO);
            }
            else
            {
                return false;
            }
        }

        public bool CapNhatHinhAnh(int maKH, byte[] hinhAnh)
        {
            return khachHangDAL.CapNhatHinhAnh(maKH, hinhAnh);
        }

        public bool EditKhachHang(KhachHangDTO khachHangDTO)
        {
            return khachHangDAL.EditKhachHang(khachHangDTO);
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

        public int LayMaKH(string v)
        {
            return khachHangDAL.LayMaKH(v);
        }

        public List<KhachHangDTO> LoadIDvaNameKH()
        {
            return khachHangDAL.LoadIDvaNameKH();
        }

        public KhachHangDTO TimKH(int maTaiKhoan)
        {
            if (maTaiKhoan > 0)
            {
                return khachHangDAL.TimKH(maTaiKhoan);
            }
            return new KhachHangDTO();
        }

        public List<KhachHangDTO> TraCuuNhanVien(List<KhachHangDTO> khachHangDTOs, string searchKeyword)
        {
            List<KhachHangDTO> searchResults = khachHangDTOs.Where(item =>
             item.HoTenKH.ToLower().Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public string TruyVanUsername(int maKH)
        {
            return TaiKhoanDAL.TruyVanUsername(maKH);
        }

        public string TruyVanUsernameBLL()
        {
            return TaiKhoanDAL.TruyVanUsernameDAL();
        }

        public TaiKhoanDTO XacThuc(KhachHangDTO khachHangDTO)
        {
            if (!string.IsNullOrWhiteSpace(khachHangDTO.Email) && !string.IsNullOrWhiteSpace(khachHangDTO.CCCD))
            {
                return khachHangDAL.XacThuc(khachHangDTO);
            }
            else
            {
                return new TaiKhoanDTO();
            }
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
