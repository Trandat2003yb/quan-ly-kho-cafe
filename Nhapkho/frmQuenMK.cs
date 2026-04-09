using System;
using System.Windows.Forms;
using BLL;
using Sunny.UI;
using QL_CaPhe;

namespace QL_CaPhe
{
    public partial class frmQuenMK : UIForm
    {
        private readonly QuenMKBLL _bll = new QuenMKBLL();

        public frmQuenMK()
        {
            InitializeComponent();
        }

        private void frmQuenMK_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var u = txtUser.Text.Trim();
            var p = txtNewPass.Text;
            var c = txtConfirm.Text;

            if (string.IsNullOrWhiteSpace(u) || string.IsNullOrWhiteSpace(p))
            {
                MsgBox.Error("Vui lòng nhập tài khoản và mật khẩu mới.");
                return;
            }

            string message;
            if (!_bll.ResetPassword(u, p, c, out message))
            {
                MsgBox.Error(message);
                return;
            }

            MsgBox.Success("Đặt lại mật khẩu thành công!");
            this.DialogResult = DialogResult.OK; 
            this.Close();
        }
    }
}
