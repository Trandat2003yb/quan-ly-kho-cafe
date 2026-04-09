using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class QuenMKDAL
    {
        private readonly string _cs =
            ConfigurationManager.ConnectionStrings["CafeDb"]?.ConnectionString
            ?? ConfigurationManager.ConnectionStrings["cafeDb"]?.ConnectionString;

        public bool VerifyUsername(string username)
        {
            using (var cn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(
                "SELECT 1 FROM TaiKhoan WHERE TenDangNhap = @u", cn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cn.Open();
                return cmd.ExecuteScalar() != null;
            }
        }

        public bool Reset(string username, string newPwdHash)
        {
            using (var cn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(@"
                UPDATE TaiKhoan
                SET MatKhau = @mk
                WHERE TenDangNhap = @u", cn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@mk", newPwdHash);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
