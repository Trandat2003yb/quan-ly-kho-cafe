using System.Security.Cryptography;
using System.Text;
using DAL;
using DTO;

namespace BLL
{
    public class DangKyBLL
    {
        private readonly DangKyDAL _dal = new DangKyDAL();

        public bool TryCreate(DangKyDTO x, string confirmPwd, out string message)
        {
            message = null;

            if (string.IsNullOrWhiteSpace(x.TenDangNhap))
            { message = "Vui lòng nhập tài khoản."; return false; }

            if (string.IsNullOrWhiteSpace(x.MatKhau))
            { message = "Vui lòng nhập mật khẩu."; return false; }

            if (x.MatKhau != confirmPwd)
            { message = "Xác nhận mật khẩu không khớp."; return false; }

            var role = (x.QuyenHan ?? "NV").ToUpperInvariant();

            if (role == "NV")
            {
                if (!x.MaNV.HasValue || x.MaNV.Value <= 0)
                { message = "Vui lòng chọn nhân viên."; return false; }
            }
            else 
            {
                x.MaNV = null; 
            }

            if (_dal.UsernameExists(x.TenDangNhap))
            { message = "Tên đăng nhập đã tồn tại."; return false; }

            var hash = HashSHA256(x.MatKhau);
            var ok = _dal.Create(x, hash);
            message = ok ? "Tạo tài khoản thành công." : "Không thể tạo tài khoản.";
            return ok;
        }

        private static string HashSHA256(string s)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(s ?? ""));
                var sb = new StringBuilder(bytes.Length * 2);
                for (int i = 0; i < bytes.Length; i++)
                    sb.Append(bytes[i].ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
