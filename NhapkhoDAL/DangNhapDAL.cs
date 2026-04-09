using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DangNhapDAL
    {
        private const string SqlLogin = @"
SELECT TOP 1 tk.MaTK, tk.MaNV, tk.TenDangNhap, tk.QuyenHan, ISNULL(nv.HoTen,N'')
FROM TaiKhoan tk
LEFT JOIN NhanVien nv ON nv.MaNV = tk.MaNV
WHERE tk.TenDangNhap = @u AND tk.MatKhau = @p";

        public UserDTO Login(string username, string password)
        {
            using (var cn = Db.GetConnection())
            using (var cmd = new SqlCommand(SqlLogin, cn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                cn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    if (!rd.Read()) return null;

                    var u = new UserDTO();
                    u.MaTK = rd.GetInt32(0);
                    u.MaNV = rd.IsDBNull(1) ? 0 : rd.GetInt32(1);
                    u.TenDangNhap = rd.GetString(2);
                    u.QuyenHan = rd.IsDBNull(3) ? "" : rd.GetString(3);
                    u.HoTen = rd.IsDBNull(4) ? "" : rd.GetString(4);
                    return u;
                }
            }
        }
    }
}

