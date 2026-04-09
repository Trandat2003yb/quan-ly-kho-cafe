using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class NguyenLieuBLL  
    {
        private readonly NguyenLieuDAL _dal = new NguyenLieuDAL();

        public DataTable LayDanhSach()
        {
            return _dal.LayDanhSach();
        }

        public DataTable TimKiem(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return _dal.LayDanhSach();
            return _dal.TimKiem(keyword);
        }

        public bool Them(NguyenLieuDTO nl)
        {
            return _dal.Them(nl.TenSP, nl.DonGia, nl.DonViTinh, nl.SoLuong);
        }

        public bool Sua(NguyenLieuDTO nl)
        {
            return _dal.Sua(nl.MaSP, nl.TenSP, nl.DonGia, nl.DonViTinh, nl.SoLuong);
        }

        public bool Xoa(int maSP)
        {
            return _dal.Xoa(maSP);
        }
    }
}
