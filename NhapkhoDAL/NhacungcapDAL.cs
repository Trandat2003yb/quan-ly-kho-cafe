using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NhaCungCapDAL
    {
        public DataTable LayDanhSach()
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT MaNCC, TenNCC, LienHe, DienThoai, Email, DiaChi FROM NhaCungCap ORDER BY MaNCC DESC", conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable TimKiem(string keyword)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                "SELECT MaNCC, TenNCC, LienHe, DienThoai, Email, DiaChi " +
                "FROM NhaCungCap WHERE TenNCC LIKE @kw OR DienThoai LIKE @kw OR LienHe LIKE @kw OR Email LIKE @kw " +
                "ORDER BY MaNCC DESC", conn))
            {
                cmd.Parameters.Add("@kw", SqlDbType.NVarChar, 255).Value = "%" + keyword + "%";
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public bool Them(string ten, string lienHe, string dienThoai, string email, string diaChi)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO NhaCungCap (TenNCC, LienHe, DienThoai, Email, DiaChi) VALUES (@Ten, @LienHe, @DT, @Email, @DC)", conn))
            {
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = ten;
                cmd.Parameters.Add("@LienHe", SqlDbType.NVarChar, 200).Value =
                    string.IsNullOrEmpty(lienHe) ? (object)DBNull.Value : lienHe;
                cmd.Parameters.Add("@DT", SqlDbType.NVarChar, 50).Value =
                    string.IsNullOrEmpty(dienThoai) ? (object)DBNull.Value : dienThoai;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 150).Value =
                    string.IsNullOrEmpty(email) ? (object)DBNull.Value : email;
                cmd.Parameters.Add("@DC", SqlDbType.NVarChar, 300).Value =
                    string.IsNullOrEmpty(diaChi) ? (object)DBNull.Value : diaChi;

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(int ma, string ten, string lienHe, string dienThoai, string email, string diaChi)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE NhaCungCap SET TenNCC=@Ten, LienHe=@LienHe, DienThoai=@DT, Email=@Email, DiaChi=@DC WHERE MaNCC=@Ma", conn))
            {
                cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = ma;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = ten;
                cmd.Parameters.Add("@LienHe", SqlDbType.NVarChar, 200).Value =
                    string.IsNullOrEmpty(lienHe) ? (object)DBNull.Value : lienHe;
                cmd.Parameters.Add("@DT", SqlDbType.NVarChar, 50).Value =
                    string.IsNullOrEmpty(dienThoai) ? (object)DBNull.Value : dienThoai;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 150).Value =
                    string.IsNullOrEmpty(email) ? (object)DBNull.Value : email;
                cmd.Parameters.Add("@DC", SqlDbType.NVarChar, 300).Value =
                    string.IsNullOrEmpty(diaChi) ? (object)DBNull.Value : diaChi;

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(int ma)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();
                using (var tr = conn.BeginTransaction())
                {
                    try
                    {
                        // 1) Xoá chi tiết PN của NCC này
                        using (var cmd1 = new SqlCommand(@"
                    DELETE ctn
                    FROM ChiTietPhieuNhap ctn
                    WHERE ctn.MaPN IN (SELECT pn.MaPN FROM PhieuNhap pn WHERE pn.MaNCC = @Ma)", conn, tr))
                        {
                            cmd1.Parameters.Add("@Ma", SqlDbType.Int).Value = ma;
                            cmd1.ExecuteNonQuery();
                        }

                        // 2) Xoá phiếu nhập của NCC này
                        using (var cmd2 = new SqlCommand(@"DELETE FROM PhieuNhap WHERE MaNCC = @Ma", conn, tr))
                        {
                            cmd2.Parameters.Add("@Ma", SqlDbType.Int).Value = ma;
                            cmd2.ExecuteNonQuery();
                        }

                        // 3) Xoá NCC
                        int affected;
                        using (var cmd3 = new SqlCommand(@"DELETE FROM NhaCungCap WHERE MaNCC = @Ma", conn, tr))
                        {
                            cmd3.Parameters.Add("@Ma", SqlDbType.Int).Value = ma;
                            affected = cmd3.ExecuteNonQuery();
                        }

                        tr.Commit();
                        return affected > 0;
                    }
                    catch
                    {
                        tr.Rollback();
                        throw;
                    }
                }
            }
        }

    }
}
