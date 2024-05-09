using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Utilities
{
    public static class KiemTraInput
    {
        public static string ChuanHoaHoTen(string hoTen)
        {
            hoTen = hoTen.Trim();
            while (hoTen.Contains("  "))
            {
                hoTen = hoTen.Replace("  ", " ");
            }

            string[] words = hoTen.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            hoTen = string.Join(" ", words);
            return hoTen;
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Kiểm tra xem chuỗi có chứa ký tự không phải số không
            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            // Kiểm tra độ dài số điện thoại (10 số cho số điện thoại di động)
            if (phoneNumber.Length != 10)
            {
                return false;
            }

            // Kiểm tra số điện thoại có bắt đầu bằng số 0 hay không
            if (phoneNumber[0] != '0')
            {
                return false;
            }

            return true;
        }

        public static bool IsValidUsername(string username)
        {
            // Kiểm tra xem tên người dùng có rỗng không
            if (string.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            // Kiểm tra độ dài tên người dùng (ví dụ: từ 3 đến 20 ký tự)
            if (username.Length < 3 || username.Length > 20)
            {
                return false;
            }

            // Kiểm tra xem tên người dùng chỉ chứa các ký tự chữ cái, số và dấu gạch dưới
            foreach (char c in username)
            {
                if (!char.IsLetterOrDigit(c) && c != '_')
                {
                    return false;
                }
            }

            // Kiểm tra xem tên người dùng không được bắt đầu hoặc kết thúc bằng dấu gạch dưới
            if (username[0] == '_' || username[username.Length - 1] == '_')
            {
                return false;
            }

            return true;
        }


        public static bool IsValuesCCCD(string CCCD)
        {
            if (CCCD.Length != 10) return false;

            foreach (char c in CCCD)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }

        public static bool IsStrongPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            // Kiểm tra độ dài tối thiểu của mật khẩu
            if (password.Length < 8)
            {
                return false;
            }

            // Kiểm tra có ít nhất một chữ cái viết hoa và một chữ cái viết thường
            bool hasUpper = false;
            bool hasLower = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
            }
            if (!hasUpper || !hasLower)
            {
                return false;
            }

            // Kiểm tra có ít nhất một số
            bool hasDigit = password.Any(char.IsDigit);
            if (!hasDigit)
            {
                return false;
            }

            // Kiểm tra có ít nhất một ký tự đặc biệt
            bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));
            if (!hasSpecialChar)
            {
                return false;
            }

            return true;
        }

        public static string ChuanHoaMaPhongBan(string maPhongBan)
        {
            maPhongBan = maPhongBan.ToUpper();
            return maPhongBan;
        }

        public static bool KiemTraNgaySinh(DateTime dt)
        {
            DateTime eighteenYearsAgo = DateTime.Today.AddYears(-18);

            return dt <= eighteenYearsAgo;
        }
        public static bool KiemTraHoTen(string hoTen)
        {
            foreach (char c in hoTen)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
