using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BaoCaoDAL
    {
        // NHẬP 
        public DataTable BaoCaoNhap(DateTime tuNgay, DateTime denNgay)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT pn.MaPN   AS MaPhieu,
                       pn.NgayLap,
                       pn.MaNV,
                       nv.HoTen AS TenNV,
                       SUM(ctn.SoLuong)                     AS TongSL,
                       SUM(ctn.SoLuong * nl.DonGia)         AS TongTien
                FROM PhieuNhap pn
                JOIN ChiTietPhieuNhap ctn ON pn.MaPN = ctn.MaPN
                JOIN NguyenLieu nl        ON ctn.MaSP = nl.MaSP      -- nguyên liệu
                LEFT JOIN NhanVien nv     ON pn.MaNV = nv.MaNV
                WHERE CONVERT(date, pn.NgayLap) BETWEEN @F AND @T
                GROUP BY pn.MaPN, pn.NgayLap, pn.MaNV, nv.HoTen
                ORDER BY pn.NgayLap DESC, pn.MaPN DESC", conn))
            {
                cmd.Parameters.Add("@F", SqlDbType.Date).Value = tuNgay.Date;
                cmd.Parameters.Add("@T", SqlDbType.Date).Value = denNgay.Date;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // XUẤT 
        public DataTable BaoCaoXuat(DateTime tuNgay, DateTime denNgay)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT px.MaPX   AS MaPhieu,
                       px.NgayLap,
                       px.MaNV,
                       nv.HoTen AS TenNV,
                       SUM(ctx.SoLuong)                     AS TongSL,
                       SUM(ctx.SoLuong * nl.DonGia)         AS TongTien
                FROM PhieuXuat px
                JOIN ChiTietPhieuXuat ctx ON px.MaPX = ctx.MaPX
                JOIN NguyenLieu nl        ON ctx.MaSP = nl.MaSP      -- nguyên liệu
                LEFT JOIN NhanVien nv     ON px.MaNV = nv.MaNV
                WHERE CONVERT(date, px.NgayLap) BETWEEN @F AND @T
                GROUP BY px.MaPX, px.NgayLap, px.MaNV, nv.HoTen
                ORDER BY px.NgayLap DESC, px.MaPX DESC", conn))
            {
                cmd.Parameters.Add("@F", SqlDbType.Date).Value = tuNgay.Date;
                cmd.Parameters.Add("@T", SqlDbType.Date).Value = denNgay.Date;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // TỒN kho 
        public DataTable BaoCaoTonKho(DateTime denNgay)
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                WITH N AS (
                    SELECT ctn.MaSP, SUM(ctn.SoLuong) SLN
                    FROM PhieuNhap pn
                    JOIN ChiTietPhieuNhap ctn ON pn.MaPN = ctn.MaPN
                    WHERE CONVERT(date, pn.NgayLap) <= @To
                    GROUP BY ctn.MaSP
                ),
                X AS (
                    SELECT ctx.MaSP, SUM(ctx.SoLuong) SLX
                    FROM PhieuXuat px
                    JOIN ChiTietPhieuXuat ctx ON px.MaPX = ctx.MaPX
                    WHERE CONVERT(date, px.NgayLap) <= @To
                    GROUP BY ctx.MaSP
                )
                SELECT nl.MaSP, nl.TenSP, nl.DonGia,
                       ISNULL(N.SLN,0) - ISNULL(X.SLX,0) AS Ton
                FROM NguyenLieu nl                          -- nguyên liệu
                LEFT JOIN N ON nl.MaSP = N.MaSP
                LEFT JOIN X ON nl.MaSP = X.MaSP
                ORDER BY nl.MaSP", conn))
            {
                cmd.Parameters.Add("@To", SqlDbType.Date).Value = denNgay.Date;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // Danh sách NGUYÊN LIỆU 
        public DataTable DanhSachSanPham()
        {
            using (SqlConnection conn = Db.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT MaSP, TenSP, DonGia FROM NguyenLieu ORDER BY MaSP DESC",
                conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
