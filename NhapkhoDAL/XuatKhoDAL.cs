using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class XuatKhoDAL
    {
        public DataTable GetNhanVien()
        {
            const string sql = "SELECT MaNV, HoTen FROM NhanVien WHERE TrangThai = 1 ORDER BY HoTen;";
            using (var cn = Db.GetConnection())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetSanPham()
        {
            const string sql = "SELECT MaSP, TenSP, DonGia FROM NguyenLieu ORDER BY MaSP ASC;";
            using (var cn = Db.GetConnection())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable SearchSanPham(string keyword)
        {
            string sql = @"
                SELECT MaSP, TenSP, DonGia
                FROM SanPham
                WHERE TenSP LIKE @k OR CAST(MaSP AS NVARCHAR(20)) LIKE @k
                ORDER BY TenSP;";
            using (var cn = Db.GetConnection())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                da.SelectCommand.Parameters.AddWithValue("@k", "%" + keyword + "%");
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Tồn kho
        public int GetTon(int maSp)
        {
            const string sql = @"SELECT ISNULL(SoLuong, 0) 
                         FROM dbo.vTonKho 
                         WHERE MaSP = @MaSP;";

            using (var cn = Db.GetConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = maSp;
                cn.Open();
                var v = cmd.ExecuteScalar();
                return (v == null || v == DBNull.Value) ? 0 : Convert.ToInt32(v);
            }
        }

        private int GetTon(SqlConnection cn, SqlTransaction tr, int maSp)
        {
            const string sql = @"SELECT ISNULL(SoLuong, 0) 
                         FROM dbo.vTonKho 
                         WHERE MaSP = @MaSP;";

            using (var cmd = new SqlCommand(sql, cn, tr))
            {
                cmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = maSp;
                var v = cmd.ExecuteScalar();
                return (v == null || v == DBNull.Value) ? 0 : Convert.ToInt32(v);
            }
        }

        //Danh sách phiếu
        public DataTable List(string keyword = null)
        {
            string sql = @"
                SELECT px.MaPX, px.NgayLap, nv.HoTen, px.GhiChu
                FROM PhieuXuat px
                JOIN NhanVien nv ON px.MaNV = nv.MaNV";
            if (!string.IsNullOrWhiteSpace(keyword))
                sql += " WHERE nv.HoTen LIKE @kw OR px.GhiChu LIKE @kw";

            using (var cn = Db.GetConnection())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                if (!string.IsNullOrWhiteSpace(keyword))
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Thêm phiếu
        public int InsertPhieuXuat(DTO.PhieuXuatDTO phieu, List<DTO.CTPXuatDTO> ct)
        {
            using (var cn = Db.GetConnection())
            {
                cn.Open();
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {
                        const string sqlPX = @"
INSERT INTO PhieuXuat(MaNV, NgayLap, GhiChu)
VALUES (@MaNV, @NgayLap, @GhiChu);
SELECT CAST(SCOPE_IDENTITY() AS INT);";
                        int newMaPX;
                        using (var cmd = new SqlCommand(sqlPX, cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@MaNV", phieu.MaNV);
                            cmd.Parameters.AddWithValue("@NgayLap", phieu.NgayLap);
                            cmd.Parameters.AddWithValue("@GhiChu", (object)phieu.GhiChu ?? DBNull.Value);
                            newMaPX = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        const string sqlCT = @"
INSERT INTO ChiTietPhieuXuat(MaPX, MaSP, SoLuong, DonGia)
VALUES (@MaPX, @MaSP, @SoLuong, @DonGia);";
                        using (var cmdCT = new SqlCommand(sqlCT, cn, tr))
                        {
                            cmdCT.Parameters.Add("@MaPX", SqlDbType.Int);
                            cmdCT.Parameters.Add("@MaSP", SqlDbType.Int);
                            cmdCT.Parameters.Add("@SoLuong", SqlDbType.Int);
                            var pDG = cmdCT.Parameters.Add("@DonGia", SqlDbType.Decimal);
                            pDG.Precision = 18; pDG.Scale = 2;

                            foreach (var d in ct)
                            {
                                var ton = GetTon(cn, tr, d.MaSP);
                                if (ton < d.SoLuong)
                                    throw new InvalidOperationException(
                                        $"Không đủ hàng trong kho. Mã SP {d.MaSP}: tồn {ton}, yêu cầu {d.SoLuong}.");

                                cmdCT.Parameters["@MaPX"].Value = newMaPX;
                                cmdCT.Parameters["@MaSP"].Value = d.MaSP;
                                cmdCT.Parameters["@SoLuong"].Value = d.SoLuong;
                                cmdCT.Parameters["@DonGia"].Value = d.DonGia; 
                                cmdCT.ExecuteNonQuery();
                            }
                        }

                        tr.Commit();
                        return newMaPX;
                    }
                    catch
                    {
                        tr.Rollback();
                        throw;
                    }
                }
            }
        }

        //Xóa phiếu
        public bool Delete(int maPX)
        {
            using (var cn = Db.GetConnection())
            {
                cn.Open();
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {
                        using (var cmd1 = new SqlCommand("DELETE FROM ChiTietPhieuXuat WHERE MaPX=@id", cn, tr))
                        {
                            cmd1.Parameters.Add("@id", SqlDbType.Int).Value = maPX;
                            cmd1.ExecuteNonQuery();
                        }
                        int n;
                        using (var cmd2 = new SqlCommand("DELETE FROM PhieuXuat WHERE MaPX=@id", cn, tr))
                        {
                            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = maPX;
                            n = cmd2.ExecuteNonQuery();
                        }
                        tr.Commit();
                        return n > 0;
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
