using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class NhapKhoDAL
    {
        public DataTable GetNhaCungCap()
        {
            const string sql = "SELECT MaNCC, TenNCC FROM NhaCungCap ORDER BY TenNCC";
            using (var cn = Db.GetConnection())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetNhanVien()
        {
            const string sql = "SELECT MaNV, HoTen FROM NhanVien WHERE TrangThai = 1 ORDER BY HoTen";
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

        // Lấy danh sách phiếu
        public DataTable List(string keyword = null)
        {
            string sql = @"SELECT pn.MaPN, pn.NgayLap, ncc.TenNCC, nv.HoTen, pn.GhiChu
                           FROM PhieuNhap pn
                           JOIN NhaCungCap ncc ON pn.MaNCC = ncc.MaNCC
                           JOIN NhanVien nv ON pn.MaNV = nv.MaNV";

            if (!string.IsNullOrWhiteSpace(keyword))
                sql += " WHERE ncc.TenNCC LIKE @kw OR pn.GhiChu LIKE @kw OR nv.HoTen LIKE @kw";

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

        // Thêm phiếu + chi tiết
        public int InsertPhieuNhap(PhieuNhapDTO phieu, List<CTPNhapDTO> chitiet)
        {
            using (var cn = Db.GetConnection())
            {
                cn.Open();
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {
                        const string sqlPhieu = @"INSERT INTO PhieuNhap(MaNCC, MaNV, NgayLap, GhiChu)
                                                  VALUES (@MaNCC, @MaNV, @NgayLap, @GhiChu);
                                                  SELECT CAST(SCOPE_IDENTITY() AS INT)";
                        int newMaPN;
                        using (var cmd = new SqlCommand(sqlPhieu, cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@MaNCC", phieu.MaNCC);
                            cmd.Parameters.AddWithValue("@MaNV", phieu.MaNV);
                            cmd.Parameters.AddWithValue("@NgayLap", phieu.NgayLap);
                            cmd.Parameters.AddWithValue("@GhiChu", (object)phieu.GhiChu ?? DBNull.Value);
                            newMaPN = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        const string sqlCT = @"INSERT INTO ChiTietPhieuNhap(MaPN, MaSP, SoLuong, DonGia)
                                               VALUES (@MaPN, @MaSP, @SoLuong, @DonGia)";
                        using (var cmdCT = new SqlCommand(sqlCT, cn, tr))
                        {
                            cmdCT.Parameters.Add("@MaPN", SqlDbType.Int);
                            cmdCT.Parameters.Add("@MaSP", SqlDbType.Int);
                            cmdCT.Parameters.Add("@SoLuong", SqlDbType.Int);
                            var pDonGia = cmdCT.Parameters.Add("@DonGia", SqlDbType.Decimal);
                            pDonGia.Precision = 18; pDonGia.Scale = 2;

                            foreach (var ct in chitiet)
                            {
                                cmdCT.Parameters["@MaPN"].Value = newMaPN;
                                cmdCT.Parameters["@MaSP"].Value = ct.MaSP;
                                cmdCT.Parameters["@SoLuong"].Value = ct.SoLuong;
                                cmdCT.Parameters["@DonGia"].Value = ct.DonGia;
                                cmdCT.ExecuteNonQuery();
                            }
                        }

                        tr.Commit();
                        return newMaPN;
                    }
                    catch
                    {
                        tr.Rollback();
                        throw;
                    }
                }
            }
        }

        // Xóa phiếu
        public bool Delete(int maPN)
        {
            using (var cn = Db.GetConnection())
            {
                cn.Open();
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {
                        new SqlCommand("DELETE FROM ChiTietPhieuNhap WHERE MaPN=" + maPN, cn, tr).ExecuteNonQuery();
                        int n = new SqlCommand("DELETE FROM PhieuNhap WHERE MaPN=" + maPN, cn, tr).ExecuteNonQuery();
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
