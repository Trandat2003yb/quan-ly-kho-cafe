using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BLL;
using DTO;
using Sunny.UI;

namespace PresentationLayer
{
    public partial class ucNhaCungCap : UserControl
    {
        private readonly NhaCungCapBLL _bll = new NhaCungCapBLL();
        private bool _isEditing = false;

        public ucNhaCungCap()
        {
            InitializeComponent();

            // Gắn sự kiện LOAD để tự bind dữ liệu khi mở màn hình
            this.Load += ucNhaCungCap_Load;

            // Sự kiện nút
            btnSearch.Click += btnSearch_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnSave.Click += btnSave_Click;

            // Sự kiện lưới
            dgv.CellClick += dgv_CellClick;

            // ====== THÊM SỰ KIỆN SIẾT QUYỀN NHẬP LIỆU ======
            // Số điện thoại: chỉ cho nhập số
            txtDT.KeyPress += txtDT_KeyPress;
            txtDT.Leave += txtDT_Leave;

            // Họ tên / Liên hệ: chỉ chữ + khoảng trắng, tự format hoa chữ đầu
            txtTen.KeyPress += txtName_KeyPress;
            txtTen.Leave += txtTen_Leave;

            txtLienHe.KeyPress += txtName_KeyPress;
            txtLienHe.Leave += txtLienHe_Leave;
            // ===============================================

            // Setup màu sắc / style cho grid
            SetupGridAppearance();
        }

        // ------------ FORMAT GRID -------------
        private void SetupGridAppearance()
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersVisible = false;

            // Màu sắc cho dễ nhìn
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(245, 245, 245);

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(90, 60, 40);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersHeight = 38;
            dgv.RowTemplate.Height = 28;
        }

        // ------------ LOAD -------------
        private void ucNhaCungCap_Load(object sender, EventArgs e)
        {
            BindGrid();
            SetFormState(true);
        }

        private void BindGrid()
        {
            try
            {
                DataTable dt = _bll.LayDanhSach();
                dgv.DataSource = dt;

                if (dgv.Columns.Contains("MaNCC")) dgv.Columns["MaNCC"].HeaderText = "Mã NCC";
                if (dgv.Columns.Contains("TenNCC")) dgv.Columns["TenNCC"].HeaderText = "Tên NCC";
                if (dgv.Columns.Contains("LienHe")) dgv.Columns["LienHe"].HeaderText = "Liên hệ";
                if (dgv.Columns.Contains("DienThoai")) dgv.Columns["DienThoai"].HeaderText = "Điện thoại";
                if (dgv.Columns.Contains("Email")) dgv.Columns["Email"].HeaderText = "Email";
                if (dgv.Columns.Contains("DiaChi")) dgv.Columns["DiaChi"].HeaderText = "Địa chỉ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách nhà cung cấp.\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetFormState(bool readOnly)
        {
            txtMa.ReadOnly = true;
            txtTen.ReadOnly = readOnly;
            txtLienHe.ReadOnly = readOnly;
            txtDT.ReadOnly = readOnly;
            txtEmail.ReadOnly = readOnly;
            txtDC.ReadOnly = readOnly;

            btnSave.Enabled = !readOnly;
        }

        private void ClearForm()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtLienHe.Text = "";
            txtDT.Text = "";
            txtEmail.Text = "";
            txtDC.Text = "";
        }

        private NhaCungCapDTO CollectForm()
        {
            int ma = 0;
            int.TryParse(txtMa.Text, out ma);

            var ncc = new NhaCungCapDTO
            {
                MaNCC = ma,
                TenNCC = (txtTen.Text ?? "").Trim(),
                LienHe = (txtLienHe.Text ?? "").Trim(),
                DienThoai = (txtDT.Text ?? "").Trim(),
                Email = (txtEmail.Text ?? "").Trim(),
                DiaChi = (txtDC.Text ?? "").Trim()
            };
            return ncc;
        }

        // ========== EVENTS BUTTON ==========

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string kw = (txtSearch.Text ?? "").Trim();
                dgv.DataSource = _bll.TimKiem(kw);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();
            BindGrid();
            SetFormState(true);
            _isEditing = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearForm();
            SetFormState(false);
            _isEditing = false;
            txtTen.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Hãy chọn một nhà cung cấp để sửa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SetFormState(false);
            _isEditing = true;
            txtTen.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Hãy chọn một nhà cung cấp để xóa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int ma = int.Parse(txtMa.Text);
                    if (_bll.Xoa(ma))
                    {
                        BindGrid();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công.",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống.",
                    "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }

            try
            {
                NhaCungCapDTO ncc = CollectForm();
                bool ok = _isEditing ? _bll.Sua(ncc) : _bll.Them(ncc);

                if (ok)
                {
                    BindGrid();
                    SetFormState(true);
                    ClearForm();
                    _isEditing = false;
                }
                else
                {
                    MessageBox.Show("Không thể lưu nhà cung cấp.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== EVENTS GRID ==========
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var r = dgv.Rows[e.RowIndex];

            txtMa.Text = r.Cells["MaNCC"]?.Value?.ToString() ?? "";
            txtTen.Text = r.Cells["TenNCC"]?.Value?.ToString() ?? "";
            txtLienHe.Text = r.Cells["LienHe"]?.Value?.ToString() ?? "";
            txtDT.Text = r.Cells["DienThoai"]?.Value?.ToString() ?? "";
            txtEmail.Text = r.Cells["Email"]?.Value?.ToString() ?? "";
            txtDC.Text = r.Cells["DiaChi"]?.Value?.ToString() ?? "";
        }

        // ========== VALIDATION HANDLERS ==========

        // Chỉ cho phép số 0-9 trong txtDT
        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép các phím control (Backspace, Delete, mũi tên...)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Khi rời khỏi ô SĐT, tự loại bỏ ký tự lạ nếu dán/paste
        private void txtDT_Leave(object sender, EventArgs e)
        {
            string digits = new string((txtDT.Text ?? "")
                .Where(char.IsDigit)
                .ToArray());

            if (txtDT.Text != digits)
                txtDT.Text = digits;
        }

        // Chỉ cho phép chữ + khoảng trắng trong tên / liên hệ
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // chặn số và ký tự đặc biệt
            }
        }

        // Hàm chuẩn hóa: bỏ ký tự đặc biệt, gom khoảng trắng, hoa chữ cái đầu
        private void FormatNameTextBox(UITextBox txt)
        {
            string raw = (txt.Text ?? "").Trim();

            string onlyLetterAndSpace = new string(
                raw.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray()
            );

            string norm = Regex.Replace(onlyLetterAndSpace, @"\s+", " ").ToLower();

            var parts = norm.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length > 0)
                {
                    parts[i] = char.ToUpper(parts[i][0]) +
                               (parts[i].Length > 1 ? parts[i].Substring(1) : "");
                }
            }

            txt.Text = string.Join(" ", parts);
        }


        private void txtTen_Leave(object sender, EventArgs e)
        {
            FormatNameTextBox(txtTen);
        }

        private void txtLienHe_Leave(object sender, EventArgs e)
        {
            FormatNameTextBox(txtLienHe);
        }
    }
}
