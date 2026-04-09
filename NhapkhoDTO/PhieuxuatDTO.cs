using System;

namespace DTO
{
    public class PhieuXuatDTO
    {
        public int MaPX { get; set; }
        public int MaNV { get; set; }
        public DateTime NgayLap { get; set; }
        public string GhiChu { get; set; } = "";
    }

    public class CTPXuatDTO
    {
        public int MaCTPX { get; set; }
        public int MaPX { get; set; }
        public int MaSP { get; set; }
        public int SoLuong { get; set; }      
        public decimal DonGia { get; set; }   
        public string TenSP { get; set; } = "";
        public decimal ThanhTien => SoLuong * DonGia;
    }
}
