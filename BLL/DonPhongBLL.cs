using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DonPhongBLL
    {
        DonPhongDAL donPhongDAL = new DonPhongDAL();
        public List<DonPhongDTO> Filter(string tT, DateTime ngayBD)
        {
            if (!tT.Equals("Tất cả"))
            {
                if (!(ngayBD == DateTime.Parse("1/1/1900")))
                {
                    bool TT;
                    if (tT.Equals("Đang hoạt động"))
                    {
                        TT = true;
                    }
                    else
                    {
                        TT = false;
                    }
                    List<DonPhongDTO> searchResults = LoadDuLieuDonPhong()
                    .Where(item => {
                        DateTime ngayNhan;
                        return item.TrangThai == TT && DateTime.TryParseExact(item.NgayNhan.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayNhan) && ngayNhan == ngayBD;
                    })
                    .ToList();
                    return searchResults;
                }
                else
                {
                    bool TT;
                    if (tT.Equals("Đang hoạt động"))
                    {
                        TT = true;
                    }
                    else
                    {
                        TT = false;
                    }
                    List<DonPhongDTO> searchResults =
                                        LoadDuLieuDonPhong().Where
                                        (item => item.TrangThai == TT).ToList();
                    return searchResults;
                }
            }
            else
            {
                if (!(ngayBD == DateTime.Parse("1/1/1900")))
                {
                    List<DonPhongDTO> searchResults = LoadDuLieuDonPhong()
                    .Where(item => {
                        DateTime ngayNhan;
                        return DateTime.TryParseExact(item.NgayNhan.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayNhan) && ngayNhan == ngayBD;
                    })
                    .ToList();

                    return searchResults;
                }
                else
                {
                   
                    List<DonPhongDTO> searchResults =LoadDuLieuDonPhong();
                    return searchResults;
                }
            }
        }      

        public List<DonPhongDTO> LoadDuLieuDonPhong()
        {
            return donPhongDAL.LoadDuLieuDonPhong();
        }

        public List<DonPhongDTO> TraCuuDonPhong(List<DonPhongDTO> donPhongDTOs, string searchKeyword)
        {
            List<DonPhongDTO> searchResults = donPhongDTOs.Where(item =>
             item.MaDonPhong == int.Parse(searchKeyword)
         ).ToList();
            return searchResults;
        }

        public bool XoaDonPhong(int maDP)
        {
            return donPhongDAL.XoaDonPhong(maDP);
        }
        public bool KhoiPhucDonPhong(int maDP)
        {
            return donPhongDAL.KhoiPhucDonPhong(maDP);
        }
        public bool AddDonPhong(DonPhongDTO donPhongDTO)
        {
            if (donPhongDTO.MaNV > 0 && donPhongDTO.MaPhong > 0)
            {
                return donPhongDAL.AddDonPhong(donPhongDTO);
            }
            else return false;
        }
        public bool EditDonPhong(DonPhongDTO donPhongDTO)
        {
            if (donPhongDTO.MaDonPhong>0 && donPhongDTO.MaNV > 0 && donPhongDTO.MaPhong > 0)
            {
                return donPhongDAL.EditDonPhong(donPhongDTO);
            }
            else return false;
        }       
    }
}
