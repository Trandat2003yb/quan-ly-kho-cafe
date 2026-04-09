using System.Windows.Forms;

namespace QL_CaPhe
{
    public static class MsgBox
    {
        public static void Error(string text)
            => MessageBox.Show(text, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void Info(string text)
            => MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void Success(string text)
            => MessageBox.Show(text, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void Warning(string text)
            => MessageBox.Show(text, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public static bool Ask(string text)
            => MessageBox.Show(text, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;

        public static bool YesNo(string text)
            => MessageBox.Show(text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }
}

