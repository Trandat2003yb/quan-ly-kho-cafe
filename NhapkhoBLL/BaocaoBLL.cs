using System;
using System.Data;
using DAL;

namespace BLL
{
    public class BaoCaoBLL
    {
        private readonly BaoCaoDAL _dal = new BaoCaoDAL();

        public DataTable LayBaoCaoNhap(DateTime tu, DateTime den)
        {
            return _dal.BaoCaoNhap(tu, den);
        }

        public DataTable LayBaoCaoXuat(DateTime tu, DateTime den)
        {
            return _dal.BaoCaoXuat(tu, den);
        }

        public DataTable LayBaoCaoTonKho(DateTime denNgay)
        {
            return _dal.BaoCaoTonKho(denNgay);
        }

        public DataTable LayDanhSachSanPham()
        {
            return _dal.DanhSachSanPham();
        }
    }
}
