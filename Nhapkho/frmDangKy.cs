using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BLL;
using DTO;
using Sunny.UI;
using QL_CaPhe;

namespace QL_CaPhe
{
    public partial class frmDangKy : UIForm
    {
        private readonly DangKyBLL _bll = new DangKyBLL();

        public frmDangKy()
        {
            InitializeComponent();
        }

        public string NewUsername { get; private set; }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            cboRole.Items.Clear();
            cboRole.Items.Add("NV");
            cboRole.Items.Add("QL");
            cboRole.SelectedIndex = 0; 
            cboRole.SelectedIndexChanged += cboRole_SelectedIndexChanged;
            LoadNhanVien();
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;

            ToggleNhanVienByRole();
        }

        private void LoadNhanVien()
        {
            var cs = ConfigurationManager.ConnectionStrings["CafeDb"] != null
                ? ConfigurationManager.ConnectionStrings["CafeDb"].ConnectionString
                : null;

            using (var cn = new SqlConnection(cs))
            using (var da = new SqlDataAdapter(
                "SELECT MaNV, HoTen FROM NhanVien WHERE TrangThai = 1 ORDER BY HoTen", cn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "MaNV";
                cboNhanVien.DataSource = dt;
                if (dt.Rows.Count > 0) cboNhanVien.SelectedIndex = 0;
            }
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleNhanVienByRole();
        }

        private void ToggleNhanVienByRole()
        {
            var role = (cboRole.SelectedItem != null ? cboRole.SelectedItem.ToString() : "NV").ToUpperInvariant();
            bool needNV = role == "NV";

            cboNhanVien.Enabled = needNV;
            if (!needNV) cboNhanVien.SelectedIndex = -1; 
        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            var u = txtUser.Text.Trim();
            var p = txtPass.Text;
            var c = txtConfirm.Text;
            var role = (cboRole.SelectedItem != null ? cboRole.SelectedItem.ToString() : "NV").ToUpperInvariant();

            if (string.IsNullOrWhiteSpace(u) || string.IsNullOrWhiteSpace(p))
            {
                MsgBox.Error("Vui lòng nhập tài khoản và mật khẩu.");
                return;
            }

            if (p != c)
            {
                MsgBox.Error("Mật khẩu xác nhận không khớp.");
                txtConfirm.Focus();
                return;
            }

            int? maNV = null;
            if (role == "NV")
            {
                if (cboNhanVien.SelectedValue == null)
                {
                    MsgBox.Error("Vui lòng chọn nhân viên.");
                    return;
                }
                maNV = System.Convert.ToInt32(cboNhanVien.SelectedValue);
            }

            var dto = new DTO.DangKyDTO
            {
                TenDangNhap = u,
                MatKhau = p,      
                QuyenHan = role,
                MaNV = maNV
            };

            string msg;
            if (!_bll.TryCreate(dto, c, out msg))
            {
                MsgBox.Error(msg);
                return;
            }

            MsgBox.Success("Đăng ký thành công!");
            this.DialogResult = DialogResult.OK; 
            this.Close();
        }
    }
}
