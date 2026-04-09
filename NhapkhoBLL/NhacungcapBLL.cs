using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class NhaCungCapBLL
    {
        private readonly NhaCungCapDAL _dal = new NhaCungCapDAL();

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

        public bool Them(NhaCungCapDTO ncc)
        {
            return _dal.Them(ncc.TenNCC, ncc.LienHe, ncc.DienThoai, ncc.Email, ncc.DiaChi);
        }

        public bool Sua(NhaCungCapDTO ncc)
        {
            return _dal.Sua(ncc.MaNCC, ncc.TenNCC, ncc.LienHe, ncc.DienThoai, ncc.Email, ncc.DiaChi);
        }

        public bool Xoa(int ma)
        {
            return _dal.Xoa(ma);
        }
    }
}
