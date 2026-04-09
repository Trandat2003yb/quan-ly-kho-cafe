using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TonKhoDAL
    {
        private const string VIEW_NAME = "dbo.vTonKho";

        public DataTable List(string keyword = null)
        {
            string sql = $"SELECT MaSP, TenSP, SoLuong FROM {VIEW_NAME}";
            if (!string.IsNullOrWhiteSpace(keyword))
                sql += " WHERE MaSP LIKE @k OR TenSP LIKE @k";

            using (var cn = Db.GetConnection())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                if (!string.IsNullOrWhiteSpace(keyword))
                    da.SelectCommand.Parameters.Add("@k", SqlDbType.NVarChar, 100).Value = "%" + keyword + "%";

                var dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.IndexOf("Invalid object name", StringComparison.OrdinalIgnoreCase) >= 0)
                        return CreateEmptySchema();

                    throw;
                }

                return dt;
            }
        }

        private DataTable CreateEmptySchema()
        {
            var dt = new DataTable();
            dt.Columns.Add("MaSP", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            return dt;
        }

        public bool Upsert(DTO.TonKhoDTO x)
        {
            throw new NotSupportedException(
                "Tồn kho được tính từ Phiếu nhập/xuất. Không thể sửa trực tiếp.");
        }

        public bool Delete(string maSP)
        {
            throw new NotSupportedException(
                "Tồn kho được tính từ Phiếu nhập/xuất. Không thể xóa trực tiếp.");
        }
    }
}
