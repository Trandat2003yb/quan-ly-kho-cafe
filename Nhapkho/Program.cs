using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
using System.Globalization;
using System.Threading;

namespace QL_CaPhe
{
    internal static class Program
    {
        public static UserDTO CurrentUser;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var frmLogin = new frmDangNhap())
            {
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    if (CurrentUser == null)
                    {
                        MessageBox.Show("Không lấy được thông tin người dùng sau đăng nhập.",
                                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var main = new FrmMain();
                    main.BindUser(CurrentUser.HoTen, CurrentUser.QuyenHan);
                    Application.Run(main);
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
