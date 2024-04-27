using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

        public string AddTaiKhoanBLL(TaiKhoanDTO taiKhoanDTO)
        {
            string a= taiKhoanDAL.AddTaiKhoanDAL(taiKhoanDTO);
            return a;
        }

        public List<TaiKhoanDTO> Filter()
        {
            return taiKhoanDAL.Filter();
        }

        public List<TaiKhoanDTO> TraCuuNhanVien(List<TaiKhoanDTO> taiKhoanDTOs, string MaPQ, string TrangThai, string NgayTao)
        {

            if (!MaPQ.Equals("None"))
            {
                if (!TrangThai.Equals("Tất cả"))
                {
                    if ((NgayTao.Length > 0))
                    {
                        bool tt;
                        if (TrangThai.Equals("Đang hoạt động"))
                        {
                            tt = true;
                        }
                        else
                        {
                            tt = false;
                        }
                        List<TaiKhoanDTO> searchResults =
                                    taiKhoanDTOs.Where
                                    (item => item.MaPQ == MaPQ && item.TrangThai == tt && item.NgayTao == DateTime.Parse(NgayTao)).ToList();
                        return searchResults;
                    }
                    else
                    {
                        bool tt;
                        if (TrangThai.Equals("Đang hoạt động"))
                        {
                            tt = true;
                        }
                        else
                        {
                            tt = false;
                        }
                        List<TaiKhoanDTO> searchResults =
                                    taiKhoanDTOs.Where
                                    (item => item.MaPQ == MaPQ && item.TrangThai == tt).ToList();
                        return searchResults;
                    }
                }
                else
                {
                    if ((NgayTao.Length > 0))
                    {
                        List<TaiKhoanDTO> searchResults =
                                    taiKhoanDTOs.Where
                                    (item => item.MaPQ == MaPQ && item.NgayTao == DateTime.Parse(NgayTao)).ToList();
                        return searchResults;
                    }
                    else
                    {
                        List<TaiKhoanDTO> searchResults =
                                    taiKhoanDTOs.Where
                                    (item => item.MaPQ == MaPQ).ToList();
                        return searchResults;
                    }
                }
            }
            else
            {
                if (!TrangThai.Equals("Tất cả"))
                {
                    if ((NgayTao.Length > 0))
                    {
                        bool tt;
                        if (TrangThai.Equals("Đang hoạt động"))
                        {
                            tt = true;
                        }
                        else
                        {
                            tt = false;
                        }
                        List<TaiKhoanDTO> searchResults =
                                    taiKhoanDTOs.Where
                                    (item => item.TrangThai == tt && item.NgayTao == DateTime.Parse(NgayTao)).ToList();
                        return searchResults;
                    }
                    else
                    {
                        bool tt;
                        if (TrangThai.Equals("Đang hoạt động"))
                        {
                            tt = true;
                        }
                        else
                        {
                            tt = false;
                        }
                        List<TaiKhoanDTO> searchResults =
                                    taiKhoanDTOs.Where
                                    (item => item.TrangThai == tt).ToList();
                        return searchResults;
                    }
                }
                else
                {
                    if ((NgayTao.Length > 0))
                    {
                        List<TaiKhoanDTO> searchResults =
                                    taiKhoanDTOs.Where
                                    (item => item.NgayTao == DateTime.Parse(NgayTao)).ToList();
                        return searchResults;
                    }
                    else
                    {
                        List<TaiKhoanDTO> searchResults = taiKhoanDAL.Filter();
                        return searchResults;
                    }
                }
            }
        }

        public List<TaiKhoanDTO> TraCuuNhanVienTen(List<TaiKhoanDTO> taiKhoanDTOs, string searchKeyword)
        {
            List<TaiKhoanDTO> searchResults = taiKhoanDTOs.Where(item =>
             item.TenDangNhap.ToLower().Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }
    }
}
