using System;

namespace DTO
{
    public class PhieuNhapDTO
    {
        public int MaPN { get; set; }          
        public int MaNCC { get; set; }         
        public int MaNV { get; set; }          
        public DateTime NgayLap { get; set; }
        public string GhiChu { get; set; } = "";
    }

    public class CTPNhapDTO
    {
        public int MaCTPN { get; set; }       
        public int MaPN { get; set; }          
        public int MaSP { get; set; }         
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}
