using System.Security.Cryptography;
using System.Text;
using DAL;

namespace BLL
{
    public class QuenMKBLL
    {
        private readonly QuenMKDAL _dal = new QuenMKDAL();

        public bool ResetPassword(string username, string newPwdPlain, string confirmPlain, out string error)
        {
            error = null;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(newPwdPlain))
            {
                error = "Vui lòng nhập tài khoản và mật khẩu mới.";
                return false;
            }
            if (newPwdPlain != confirmPlain)
            {
                error = "Mật khẩu xác nhận không khớp.";
                return false;
            }

            if (!_dal.VerifyUsername(username))
            {
                error = "Tài khoản không tồn tại.";
                return false;
            }

            var hash = HashSHA256(newPwdPlain);
            bool ok = _dal.Reset(username, hash);
            if (!ok) error = "Không cập nhật được mật khẩu.";
            return ok;
        }

        private static string HashSHA256(string s)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(s ?? ""));
                var sb = new StringBuilder(bytes.Length * 2);
                for (int i = 0; i < bytes.Length; i++) sb.Append(bytes[i].ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
