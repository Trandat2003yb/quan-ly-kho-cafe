using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class TonKhoBLL
    {
        private readonly TonKhoDAL _dal = new TonKhoDAL();

        public DataTable List(string keyword = null) => _dal.List(keyword);

        public bool Upsert(TonKhoDTO x)
        {
            if (x == null) throw new ArgumentNullException(nameof(x));
            if (string.IsNullOrWhiteSpace(x.MaSP))
                throw new ArgumentException("Mã sản phẩm bắt buộc.", nameof(x.MaSP));
            if (x.SoLuong < 0)
                throw new ArgumentException("Số lượng tồn phải >= 0.", nameof(x.SoLuong));

            return _dal.Upsert(x);
        }

        public bool Delete(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP)) return false;
            return _dal.Delete(maSP.Trim());
        }
    }
}
