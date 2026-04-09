using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NguyenLieuDAL
    {
        // Lấy danh sách nguyên liệu
        public DataTable LayDanhSach()
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT MaSP, TenSP, DonGia, DonViTinh, SoLuong " +
                "FROM NguyenLieu " +
                "ORDER BY MaSP DESC", conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Tìm kiếm nguyên liệu
        public DataTable TimKiem(string keyword)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                "SELECT MaSP, TenSP, DonGia, DonViTinh, SoLuong " +
                "FROM NguyenLieu " +
                "WHERE TenSP LIKE @kw OR CAST(MaSP AS NVARCHAR(20)) LIKE @kw " +
                "ORDER BY MaSP DESC", conn))
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

        // Thêm nguyên liệu
        public bool Them(string ten, decimal donGia, string donViTinh, int soLuong)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO NguyenLieu (TenSP, DonGia, DonViTinh, SoLuong) " +
                "VALUES (@Ten, @Gia, @DVT, @SL)", conn))
            {
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = ten;
                cmd.Parameters.Add("@Gia", SqlDbType.Money).Value = donGia;

                if (string.IsNullOrEmpty(donViTinh))
                    cmd.Parameters.Add("@DVT", SqlDbType.NVarChar, 50).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@DVT", SqlDbType.NVarChar, 50).Value = donViTinh;

                cmd.Parameters.Add("@SL", SqlDbType.Int).Value = soLuong;

                conn.Open();
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
        }

        // Sửa nguyên liệu
        public bool Sua(int maSP, string ten, decimal donGia, string donViTinh, int soLuong)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE NguyenLieu " +
                "SET TenSP = @Ten, DonGia = @Gia, DonViTinh = @DVT, SoLuong = @SL " +
                "WHERE MaSP = @Ma", conn))
            {
                cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = maSP;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = ten;
                cmd.Parameters.Add("@Gia", SqlDbType.Money).Value = donGia;

                if (string.IsNullOrEmpty(donViTinh))
                    cmd.Parameters.Add("@DVT", SqlDbType.NVarChar, 50).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@DVT", SqlDbType.NVarChar, 50).Value = donViTinh;

                cmd.Parameters.Add("@SL", SqlDbType.Int).Value = soLuong;

                conn.Open();
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
        }

        // Xóa nguyên liệu
        public bool Xoa(int maSP)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                "DELETE FROM NguyenLieu WHERE MaSP = @Ma", conn))
            {
                cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = maSP;

                conn.Open();
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
        }
    }
}
