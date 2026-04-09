using DTO;
using DAL;
using System;

namespace BLL
{
    public class DangNhapBLL
    {
        private readonly DangNhapDAL _dal = new DangNhapDAL();

        public UserDTO Login(string username, string password)
        {
            var user = _dal.Login(username, password);
            return user;
        }
    }
}
