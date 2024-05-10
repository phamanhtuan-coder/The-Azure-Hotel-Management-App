using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhuyenMaiBLL
    {

        KhuyenMaiDAL khuyenMaiDAL = new KhuyenMaiDAL();

        public List<KhuyenMaiDTO> LoadDSKhuyenMai()
        {
            return khuyenMaiDAL.LoadDSKhuyenMai();
        }

        public List<KhuyenMaiDTO> Filter(string trangthai, int hangthanhvien, int khuyenmai)
        {
            if (!trangthai.Equals("Tất cả"))
            {
                if (hangthanhvien != -1)
                {
                    if (khuyenmai != 0)
                    {
                        bool TT;
                        if (trangthai.Equals("Đang hoạt động"))
                        {
                            TT = true;
                        }
                        else
                        {
                            TT = false;
                        }

                        List<KhuyenMaiDTO> searchResults =
                                        LoadDSKhuyenMai().Where
                                        (item => item.TrangThai == TT && item.KhuyenMai == khuyenmai && item.MaLoaiHangThanhVien == hangthanhvien).ToList();
                        return searchResults;
                    }
                    else
                    {
                        bool TT;
                        if (trangthai.Equals("Đang hoạt động"))
                        {
                            TT = true;
                        }
                        else
                        {
                            TT = false;
                        }

                        List<KhuyenMaiDTO> searchResults =
                                        LoadDSKhuyenMai().Where
                                        (item => item.TrangThai == TT && item.MaLoaiHangThanhVien == hangthanhvien).ToList();
                        return searchResults;
                    }
                }
                else
                {
                    if (khuyenmai != 0)
                    {
                        bool TT;
                        if (trangthai.Equals("Đang hoạt động"))
                        {
                            TT = true;
                        }
                        else
                        {
                            TT = false;
                        }

                        List<KhuyenMaiDTO> searchResults =
                                        LoadDSKhuyenMai().Where
                                        (item => item.TrangThai == TT && item.KhuyenMai == khuyenmai).ToList();
                        return searchResults;
                    }
                    else
                    {
                        bool TT;
                        if (trangthai.Equals("Đang hoạt động"))
                        {
                            TT = true;
                        }
                        else
                        {
                            TT = false;
                        }

                        List<KhuyenMaiDTO> searchResults =
                                        LoadDSKhuyenMai().Where
                                        (item => item.TrangThai == TT).ToList();
                        return searchResults;
                    }
                }
            }
            else
            {
                if (hangthanhvien != -1)
                {
                    if (khuyenmai != 0)
                    {                        
                        List<KhuyenMaiDTO> searchResults =
                                        LoadDSKhuyenMai().Where
                                        (item => item.KhuyenMai == khuyenmai && item.MaLoaiHangThanhVien == hangthanhvien).ToList();
                        return searchResults;
                    }
                    else
                    {
                       
                        List<KhuyenMaiDTO> searchResults =
                                        LoadDSKhuyenMai().Where
                                        (item => item.MaLoaiHangThanhVien == hangthanhvien).ToList();
                        return searchResults;
                    }
                }
                else
                {
                    if (khuyenmai != 0)
                    {

                        List<KhuyenMaiDTO> searchResults =
                                        LoadDSKhuyenMai().Where
                                        (item => item.KhuyenMai == khuyenmai).ToList();
                        return searchResults;
                    }
                    else
                    {

                        List<KhuyenMaiDTO> searchResults = LoadDSKhuyenMai();
                        return searchResults;
                    }
                }
            }
        }

        public List<KhuyenMaiDTO> TraCuuKhuyenMai(List<KhuyenMaiDTO> khuyenMaiDTOs, string searchKeyword)
        {
            List<KhuyenMaiDTO> searchResults = khuyenMaiDTOs.Where(item =>
             item.TenKM.ToLower().Contains(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public List<KhuyenMaiDTO> TruyVanSoKhuyenMai()
        {
            return khuyenMaiDAL.TruyVanSoKhuyenMai();
        }

        public bool AddKhuyenMai(KhuyenMaiDTO khuyenMaiDTO)
        {
            if(!string.IsNullOrWhiteSpace(khuyenMaiDTO.TenKM.Trim())&& khuyenMaiDTO.MaLoaiHangThanhVien>0 && khuyenMaiDTO.KhuyenMai > 0)
            {
                return khuyenMaiDAL.AddKhuyenMai(khuyenMaiDTO);
            }
            else
            {
                return false;
            }
        }

        public bool EditKhuyenMai(KhuyenMaiDTO khuyenMaiDTO)
        {
            if (khuyenMaiDTO.MaKM >0 && !string.IsNullOrWhiteSpace(khuyenMaiDTO.TenKM.Trim()) && khuyenMaiDTO.MaLoaiHangThanhVien > 0 && khuyenMaiDTO.KhuyenMai > 0)
            {
                return khuyenMaiDAL.EditKhuyenMai(khuyenMaiDTO);
            }
            else
            {
                return false;
            }
        }

        public bool XoaKhuyenMai(int maKM)
        {
            if (maKM > 0)
            {
                return khuyenMaiDAL.XoaKhuyenMai(maKM);
            }
            return false;
        }

        public bool KhoiPhucKhuyenMai(int maKM)
        {
            if (maKM > 0)
            {
                return khuyenMaiDAL.KhoiPhucKhuyenMai(maKM);
            }
            return false;
        }

        public List<KhuyenMaiDTO> TruyVanIDAndTenKhuyenMai()
        {
            return khuyenMaiDAL.TruyVanIDAndTenKhuyenMai();
        }
    }
}
