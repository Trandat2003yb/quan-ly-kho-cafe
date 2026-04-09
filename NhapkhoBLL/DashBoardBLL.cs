using System;
using System.Data;
using DAL;

namespace BLL
{
    public class DashboardBLL
    {
        private readonly DashboardDAL _dal = new DashboardDAL();

        public (int SanPham, int NhaCungCap) LayDemCoBan()
        {
            DataTable dt = _dal.GetCounts();
            if (dt.Rows.Count == 0) return (0, 0);
            DataRow r = dt.Rows[0];
            int sp = r["SanPham"] == DBNull.Value ? 0 : Convert.ToInt32(r["SanPham"]);
            int ncc = r["NhaCungCap"] == DBNull.Value ? 0 : Convert.ToInt32(r["NhaCungCap"]);
            return (sp, ncc);
        }

        public (decimal TongNhap, decimal TongXuat) LayTongThang(int year, int month)
        {
            DataTable dt = _dal.GetMonthlyTotals(year, month);
            if (dt.Rows.Count == 0) return (0m, 0m);
            DataRow r = dt.Rows[0];
            decimal nhap = r["TongNhap"] == DBNull.Value ? 0m : Convert.ToDecimal(r["TongNhap"]);
            decimal xuat = r["TongXuat"] == DBNull.Value ? 0m : Convert.ToDecimal(r["TongXuat"]);
            return (nhap, xuat);
        }

        public DataTable LayTonThap(int topN, int threshold)
        {
            return _dal.GetLowStock(topN, threshold);
        }

        public DataTable LayHoatDongGanDay(int topEach)
        {
            return _dal.GetRecentActivities(topEach);
        }
    }
}
