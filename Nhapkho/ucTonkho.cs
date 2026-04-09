using System;
using System.Data;
using System.Windows.Forms;
using Sunny.UI;
using BLL;
using DTO;

namespace QL_CaPhe
{
    public partial class ucTonKho : UIUserControl
    {
        private readonly TonKhoBLL _bll = new TonKhoBLL();
        private DataTable _data;

        public ucTonKho()
        {
            InitializeComponent();
            this.Load += ucTonKho_Load;
        }

        private void ucTonKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(string keyword = null)
        {
            try
            {
                _data = _bll.List(keyword);
                dgv.DataSource = _data;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgv.Columns["MaSP"] != null) dgv.Columns["MaSP"].HeaderText = "Mã SP";
                if (dgv.Columns["TenSP"] != null) dgv.Columns["TenSP"].HeaderText = "Tên sản phẩm";
                if (dgv.Columns["SoLuong"] != null) dgv.Columns["SoLuong"].HeaderText = "Tồn kho";

                UpdateSummary();
            }
            catch (Exception ex)
            {
                MsgBox.Error("Không thể tải dữ liệu tồn kho\n" + ex.Message);
            }
        }

        private void UpdateSummary()
        {
            if (_data == null) return;

            int total = 0;
            foreach (DataRow r in _data.Rows)
            {
                int x;
                if (int.TryParse(r["SoLuong"]?.ToString() ?? "0", out x))
                    total += x;
            }
            lblSummary.Text = "Tổng sản phẩm: " + _data.Rows.Count + " | Tổng tồn: " + total;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            chkLowOnly.Checked = false;
            LoadData();
        }

        private void chkLowOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (_data == null) return;

            if (chkLowOnly.Checked)
            {
                var view = new DataView(_data);
                view.RowFilter = "SoLuong < " + (int)numThreshold.Value;
                dgv.DataSource = view;
            }
            else
            {
                dgv.DataSource = _data;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var r = dgv.Rows[e.RowIndex];
            txtMa.Text = r.Cells["MaSP"]?.Value?.ToString() ?? "";
            txtTen.Text = r.Cells["TenSP"]?.Value?.ToString() ?? "";

            int sl = 0;
            int.TryParse(r.Cells["SoLuong"]?.Value?.ToString() ?? "0", out sl);
            numSL.Value = sl;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new TonKhoDTO
                {
                    MaSP = txtMa.Text.Trim(),
                    TenSP = txtTen.Text.Trim(),
                    SoLuong = (int)numSL.Value
                };
                _bll.Upsert(dto);
            }
            catch (NotSupportedException ex)
            {
                MsgBox.Error(ex.Message);
            }
            catch (Exception ex)
            {
                MsgBox.Error("Lỗi không xác định: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new TonKhoDTO
                {
                    MaSP = txtMa.Text.Trim(),
                    TenSP = txtTen.Text.Trim(),
                    SoLuong = (int)numSL.Value
                };
                _bll.Upsert(dto);
            }
            catch (NotSupportedException ex)
            {
                MsgBox.Error(ex.Message);
            }
            catch (Exception ex)
            {
                MsgBox.Error("Lỗi không xác định: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMa.Text))
                {
                    MsgBox.Error("Vui lòng chọn sản phẩm cần xóa.");
                    return;
                }

                if (MsgBox.Ask("Bạn có chắc muốn xóa sản phẩm này không?"))
                {
                    _bll.Delete(txtMa.Text.Trim());
                }
            }
            catch (NotSupportedException ex)
            {
                MsgBox.Error(ex.Message);
            }
            catch (Exception ex)
            {
                MsgBox.Error("Lỗi không xác định: " + ex.Message);
            }
        }

        private void btnSaveAdjust_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new TonKhoDTO
                {
                    MaSP = txtMa.Text.Trim(),
                    TenSP = txtTen.Text.Trim(),
                    SoLuong = (int)numSL.Value
                };
                _bll.Upsert(dto);
            }
            catch (NotSupportedException ex)
            {
                MsgBox.Error(ex.Message);
            }
            catch (Exception ex)
            {
                MsgBox.Error("Lỗi không xác định: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            numSL.Value = 0;
            dgv.ClearSelection();
        }
    }
}
