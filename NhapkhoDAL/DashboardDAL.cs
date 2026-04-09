using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DashboardDAL
    {
        // ĐẾM tổng số thực thể cơ bản
        public DataTable GetCounts()
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT 
                    (SELECT COUNT(*) FROM NguyenLieu)  AS SanPham,      
                    (SELECT COUNT(*) FROM NhaCungCap) AS NhaCungCap
            ", conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Tổng nhập & xuất theo THÁNG
        public DataTable GetMonthlyTotals(int year, int month)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                -- Nhập
                WITH N AS (
                    SELECT SUM(ctn.SoLuong * ctn.DonGia) AS TongNhap
                    FROM PhieuNhap pn
                    JOIN ChiTietPhieuNhap ctn ON pn.MaPN = ctn.MaPN
                    WHERE YEAR(pn.NgayLap) = @Y AND MONTH(pn.NgayLap) = @M
                ),
                X AS (
                    SELECT SUM(ctx.SoLuong * ctx.DonGia) AS TongXuat
                    FROM PhieuXuat px
                    JOIN ChiTietPhieuXuat ctx ON px.MaPX = ctx.MaPX
                    WHERE YEAR(px.NgayLap) = @Y AND MONTH(px.NgayLap) = @M
                )
                SELECT ISNULL(N.TongNhap,0) AS TongNhap, ISNULL(X.TongXuat,0) AS TongXuat
                FROM N CROSS JOIN X
            ", conn))
            {
                cmd.Parameters.Add("@Y", SqlDbType.Int).Value = year;
                cmd.Parameters.Add("@M", SqlDbType.Int).Value = month;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // Hàng tồn thấp
        public DataTable GetLowStock(int topN, int threshold)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                WITH N AS (
                    SELECT ctn.MaSP, SUM(ctn.SoLuong) AS SLN
                    FROM PhieuNhap pn
                    JOIN ChiTietPhieuNhap ctn ON pn.MaPN = ctn.MaPN
                    GROUP BY ctn.MaSP
                ),
                X AS (
                    SELECT ctx.MaSP, SUM(ctx.SoLuong) AS SLX
                    FROM PhieuXuat px
                    JOIN ChiTietPhieuXuat ctx ON px.MaPX = ctx.MaPX
                    GROUP BY ctx.MaSP
                )
                SELECT TOP (@TopN)
                    nl.MaSP, nl.TenSP, nl.DonGia,
                    (ISNULL(N.SLN,0) - ISNULL(X.SLX,0)) AS Ton
                FROM NguyenLieu nl
                LEFT JOIN N ON nl.MaSP = N.MaSP
                LEFT JOIN X ON nl.MaSP = X.MaSP
                WHERE (ISNULL(N.SLN,0) - ISNULL(X.SLX,0)) <= @Threshold
                ORDER BY Ton ASC, nl.MaSP ASC;
            ", conn))
            {
                cmd.Parameters.Add("@TopN", SqlDbType.Int).Value = topN;
                cmd.Parameters.Add("@Threshold", SqlDbType.Int).Value = threshold;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // Phiếu nhập gần đây
        public DataTable GetRecentNhap(int topN)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT TOP (@TopN)
                    pn.MaPN  AS MaPhieu,
                    pn.NgayLap,
                    nv.HoTen AS NhanVien,
                    ISNULL(SUM(ctn.SoLuong * ctn.DonGia),0) AS TongTien,
                    N'Nhập' AS Loai
                FROM PhieuNhap pn
                LEFT JOIN NhanVien nv          ON pn.MaNV = nv.MaNV
                LEFT JOIN ChiTietPhieuNhap ctn ON pn.MaPN = ctn.MaPN
                GROUP BY pn.MaPN, pn.NgayLap, nv.HoTen
                ORDER BY pn.NgayLap DESC, pn.MaPN DESC
            ", conn))
            {
                cmd.Parameters.Add("@TopN", SqlDbType.Int).Value = topN;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // Phiếu xuất gần đây
        public DataTable GetRecentXuat(int topN)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT TOP (@TopN)
                    px.MaPX  AS MaPhieu,
                    px.NgayLap,
                    nv.HoTen AS NhanVien,
                    ISNULL(SUM(ctx.SoLuong * ctx.DonGia),0) AS TongTien,
                    N'Xuất' AS Loai
                FROM PhieuXuat px
                LEFT JOIN NhanVien nv          ON px.MaNV = nv.MaNV
                LEFT JOIN ChiTietPhieuXuat ctx ON px.MaPX = ctx.MaPX
                GROUP BY px.MaPX, px.NgayLap, nv.HoTen
                ORDER BY px.NgayLap DESC, px.MaPX DESC
            ", conn))
            {
                cmd.Parameters.Add("@TopN", SqlDbType.Int).Value = topN;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // Hợp nhất nhập & xuất gần đây 
        public DataTable GetRecentActivities(int topEach)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                WITH A AS (
                    SELECT TOP (@Top) pn.MaPN AS MaPhieu, pn.NgayLap, nv.HoTen AS NhanVien,
                           ISNULL(SUM(ctn.SoLuong * ctn.DonGia),0) AS TongTien, N'Nhập' AS Loai
                    FROM PhieuNhap pn
                    LEFT JOIN NhanVien nv          ON pn.MaNV = nv.MaNV
                    LEFT JOIN ChiTietPhieuNhap ctn ON pn.MaPN = ctn.MaPN
                    GROUP BY pn.MaPN, pn.NgayLap, nv.HoTen
                    ORDER BY pn.NgayLap DESC, pn.MaPN DESC
                ),
                B AS (
                    SELECT TOP (@Top) px.MaPX AS MaPhieu, px.NgayLap, nv.HoTen AS NhanVien,
                           ISNULL(SUM(ctx.SoLuong * ctx.DonGia),0) AS TongTien, N'Xuất' AS Loai
                    FROM PhieuXuat px
                    LEFT JOIN NhanVien nv          ON px.MaNV = nv.MaNV
                    LEFT JOIN ChiTietPhieuXuat ctx ON px.MaPX = ctx.MaPX
                    GROUP BY px.MaPX, px.NgayLap, nv.HoTen
                    ORDER BY px.NgayLap DESC, px.MaPX DESC
                )
                SELECT * FROM A
                UNION ALL
                SELECT * FROM B
                ORDER BY NgayLap DESC, MaPhieu DESC
            ", conn))
            {
                cmd.Parameters.Add("@Top", SqlDbType.Int).Value = topEach;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
