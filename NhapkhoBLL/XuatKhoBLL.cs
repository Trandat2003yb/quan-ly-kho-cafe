using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class XuatKhoBLL
    {
        private readonly XuatKhoDAL _dal = new XuatKhoDAL();
        public DataTable GetNhanVien() => _dal.GetNhanVien();
        public DataTable GetSanPham() => _dal.GetSanPham();
        public DataTable SearchSanPham(string k)
            => string.IsNullOrWhiteSpace(k) ? _dal.GetSanPham() : _dal.SearchSanPham(k);
        public DataTable GetDanhSach(string keyword = null) => _dal.List(keyword);

        //Thêm phiếu + chi tiết
        public int ThemPhieuXuat(PhieuXuatDTO px, List<CTPXuatDTO> ct)
        {
            if (px == null) throw new ArgumentNullException(nameof(px));
            if (ct == null || ct.Count == 0) throw new ArgumentException("Chưa có chi tiết phiếu xuất.");
            foreach (var d in ct)
            {
                if (d.SoLuong <= 0)
                    throw new ArgumentException("Số lượng xuất phải > 0.");
                if (d.DonGia < 0)
                    throw new ArgumentException("Đơn giá không hợp lệ.");
            }
            return _dal.InsertPhieuXuat(px, ct);
        }

        // ===== Xóa phiếu =====
        public bool XoaPhieuXuat(int maPX) => _dal.Delete(maPX);
    }
}
