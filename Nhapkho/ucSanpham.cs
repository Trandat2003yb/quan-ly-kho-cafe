using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using BLL;
using DTO;

namespace PresentationLayer
{
    public partial class ucSanPham : UserControl
    {
        private readonly NguyenLieuBLL _bll = new NguyenLieuBLL();
        private bool _isEditing = false;

        public ucSanPham()
        {
            InitializeComponent();
            this.Load += ucSanPham_Load;

            btnSearch.Click += btnSearch_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnSave.Click += btnSave_Click;

            dgv.CellClick += dgv_CellClick;
            dgv.CellFormatting += dgv_CellFormatting;
        }

        // Load
        private void ucSanPham_Load(object sender, EventArgs e)
        {
            BindGrid();
            SetFormState(viewOnly: true);
        }

        // BindGrid
        private void BindGrid()
        {
            try
            {
                DataTable dt = _bll.LayDanhSach();

                dgv.Enabled = true;             
                dgv.ReadOnly = true;             
                dgv.AutoGenerateColumns = true;
                dgv.DataSource = dt;

                if (dgv.Columns.Contains("MaSP")) dgv.Columns["MaSP"].HeaderText = "Mã SP";
                if (dgv.Columns.Contains("TenSP")) dgv.Columns["TenSP"].HeaderText = "Tên nguyên liệu";
                if (dgv.Columns.Contains("DonGia")) dgv.Columns["DonGia"].HeaderText = "Đơn giá";
                if (dgv.Columns.Contains("DonViTinh")) dgv.Columns["DonViTinh"].HeaderText = "ĐVT";
                if (dgv.Columns.Contains("SoLuong")) dgv.Columns["SoLuong"].HeaderText = "Số lượng";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu.\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Set form
        private void SetFormState(bool viewOnly)
        {
            txtMaSP.ReadOnly = true;
            txtTenSP.ReadOnly = viewOnly;
            txtDonGia.ReadOnly = viewOnly;
            txtDonViTinh.ReadOnly = viewOnly;
            txtSoLuong.ReadOnly = viewOnly;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            btnSave.Enabled = !viewOnly;
        }

        private void ClearForm()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            txtDonViTinh.Text = "";
            txtSoLuong.Text = "";
        }

        private NguyenLieuDTO CollectForm()
        {
            int ma;
            int.TryParse(txtMaSP.Text.Trim(), out ma);

            decimal gia;
            decimal.TryParse(txtDonGia.Text.Trim(),
                NumberStyles.Any, CultureInfo.InvariantCulture, out gia);

            int sl;
            int.TryParse(txtSoLuong.Text.Trim(), out sl);

            var nl = new NguyenLieuDTO
            {
                MaSP = ma,
                TenSP = (txtTenSP.Text ?? string.Empty).Trim(),
                DonGia = gia,
                DonViTinh = (txtDonViTinh.Text ?? string.Empty).Trim(),
                SoLuong = sl
            };
            return nl;
        }

        private bool ValidateForm(bool isEdit)
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên nguyên liệu.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return false;
            }

            decimal gia;
            if (!decimal.TryParse(txtDonGia.Text.Trim(),
                    NumberStyles.Any, CultureInfo.InvariantCulture, out gia) || gia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Sai dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return false;
            }

            int sl;
            if (!int.TryParse(txtSoLuong.Text.Trim(), out sl) || sl < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.", "Sai dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return false;
            }

            if (isEdit && string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Thiếu Mã SP để sửa.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        // sự kiện

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string kw = (txtSearch.Text ?? "").Trim();
                DataTable dt = kw.Length == 0
                    ? _bll.LayDanhSach()
                    : _bll.TimKiem(kw);

                dgv.DataSource = dt;
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
            _isEditing = false;
            SetFormState(true);
            BindGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearForm();
            _isEditing = false;
            SetFormState(false);
            txtTenSP.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Hãy chọn một nguyên liệu để sửa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _isEditing = true;
            SetFormState(false);
            txtTenSP.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Hãy chọn một nguyên liệu để xóa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa nguyên liệu này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int ma = int.Parse(txtMaSP.Text);
                    bool ok = _bll.Xoa(ma);
                    if (ok)
                    {
                        MessageBox.Show("Đã xóa nguyên liệu.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (!ValidateForm(_isEditing)) return;

            NguyenLieuDTO nl = CollectForm();

            try
            {
                bool ok = _isEditing ? _bll.Sua(nl) : _bll.Them(nl);
                if (ok)
                {
                    MessageBox.Show("Đã lưu nguyên liệu.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BindGrid();
                    SetFormState(true);
                    if (!_isEditing) ClearForm();
                }
                else
                {
                    MessageBox.Show("Lưu không thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // sự kiện Grid

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgv.CurrentRow == null) return;

            DataGridViewRow row = dgv.Rows[e.RowIndex];

            txtMaSP.Text = row.Cells["MaSP"] != null ? Convert.ToString(row.Cells["MaSP"].Value) : "";
            txtTenSP.Text = row.Cells["TenSP"] != null ? Convert.ToString(row.Cells["TenSP"].Value) : "";
            txtDonGia.Text = row.Cells["DonGia"] != null ? Convert.ToString(row.Cells["DonGia"].Value) : "";
            txtDonViTinh.Text = row.Cells["DonViTinh"] != null ? Convert.ToString(row.Cells["DonViTinh"].Value) : "";
            txtSoLuong.Text = row.Cells["SoLuong"] != null ? Convert.ToString(row.Cells["SoLuong"].Value) : "";
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "DonGia" &&
                e.Value != null && e.Value != DBNull.Value)
            {
                decimal val;
                if (decimal.TryParse(e.Value.ToString(), out val))
                {
                    e.Value = val.ToString("#,0.##");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
