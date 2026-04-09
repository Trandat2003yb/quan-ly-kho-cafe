namespace DTO
{
    public class UserDTO
    {
        public int MaTK { get; set; }
        public int MaNV { get; set; }
        public string TenDangNhap { get; set; }
        public string QuyenHan { get; set; }
        public string HoTen { get; set; }

        public UserDTO()
        {
            TenDangNhap = "";
            QuyenHan = "";
            HoTen = "";
        }
    }
}
