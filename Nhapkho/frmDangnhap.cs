using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using BLL;
using DTO;
using Sunny.UI;

namespace QL_CaPhe
{
    public partial class frmDangNhap : UIForm
    {
        private readonly DangNhapBLL _bll = new DangNhapBLL();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            var vi = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = vi;
            Thread.CurrentThread.CurrentUICulture = vi;

            txtUser.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var u = txtUser.Text.Trim();
            var p = txtPass.Text;

            if (string.IsNullOrWhiteSpace(u) || string.IsNullOrWhiteSpace(p))
            {
                MsgBox.Error("Vui lòng nhập tài khoản và mật khẩu.");
                return;
            }

            var user = _bll.Login(u, p);   
            if (user == null)
            {
                MsgBox.Error("Sai tài khoản hoặc mật khẩu.");
                txtPass.SelectAll();
                txtPass.Focus();
                return;
            }
            Program.CurrentUser = user;

            this.DialogResult = DialogResult.OK;  
            this.Close();
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var f = new frmDangKy())
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    MsgBox.Success("Đăng ký thành công. Vui lòng đăng nhập.");
                    if (!string.IsNullOrWhiteSpace(f.NewUsername))
                    {
                        txtUser.Text = f.NewUsername;
                        txtPass.Clear();
                        txtPass.Focus();
                    }
                }
            }
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var f = new frmQuenMK())
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    MsgBox.Success("Đặt lại mật khẩu thành công. Vui lòng đăng nhập.");
                    txtPass.Clear();
                    txtPass.Focus();
                }
            }
        }
    }
}
