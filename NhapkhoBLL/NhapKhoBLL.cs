using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class NhapKhoBLL
    {
        private readonly NhapKhoDAL _dal = new NhapKhoDAL();
        public DataTable GetNhaCungCap() => _dal.GetNhaCungCap();
        public DataTable GetNhanVien() => _dal.GetNhanVien();
        public DataTable GetSanPham() => _dal.GetSanPham();

        // Danh sách phiếu nhập
        public DataTable GetDanhSach(string keyword = null) => _dal.List(keyword);

        // Thêm phiếu + nhiều chi tiết
        public int ThemPhieuNhap(PhieuNhapDTO phieu, List<CTPNhapDTO> chiTiet)
        {
            if (phieu == null) throw new ArgumentNullException(nameof(phieu));
            if (chiTiet == null || chiTiet.Count == 0)
                throw new ArgumentException("Chưa có chi tiết phiếu nhập.");

            return _dal.InsertPhieuNhap(phieu, chiTiet);
        }

        // Xóa phiếu
        public bool XoaPhieuNhap(int maPN)
        {
            if (maPN <= 0) throw new ArgumentException("Mã phiếu nhập không hợp lệ.");
            return _dal.Delete(maPN);
        }
    }
}
