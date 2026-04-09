using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DangKyDAL
    {
        public bool UsernameExists(string username)
        {
            using (var cn = Db.GetConnection())
            using (var cmd = cn.CreateCommand())
            {
                cmd.CommandText = "SELECT 1 FROM TaiKhoan WHERE TenDangNhap = @u";
                cmd.Parameters.AddWithValue("@u", username);
                cn.Open();
                var o = cmd.ExecuteScalar();
                return o != null;
            }
        }

        public bool Create(DangKyDTO x, string pwdHash)
        {
            using (var cn = Db.GetConnection())
            using (var cmd = cn.CreateCommand())
            {
                cmd.CommandText = @"
INSERT INTO TaiKhoan(TenDangNhap, MatKhauHash, MaNV, QuyenHan)
VALUES(@u, @h, @manv, @role)";

                cmd.Parameters.AddWithValue("@u", x.TenDangNhap);
                cmd.Parameters.AddWithValue("@h", pwdHash);

                var pMaNV = cmd.Parameters.Add("@manv", SqlDbType.Int);
                if (x.MaNV.HasValue && x.MaNV.Value > 0)
                    pMaNV.Value = x.MaNV.Value;
                else
                    pMaNV.Value = DBNull.Value;      

                cmd.Parameters.AddWithValue("@role", x.QuyenHan ?? "NV");

                cn.Open();
                return cmd.ExecuteNonQuery() == 1;
            }
        }
    }
}
