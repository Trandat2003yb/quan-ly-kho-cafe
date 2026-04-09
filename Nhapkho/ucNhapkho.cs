using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Sunny.UI;
using BLL;
using DTO;
using System.ComponentModel;

namespace QL_CaPhe
{
    public partial class ucNhapKho : UserControl
    {
        private readonly NhapKhoBLL _bll = new NhapKhoBLL();
        private DataTable _dtSP;
        private DataTable _dtCT;
        private int _maSpChon = 0;
        private decimal _donGiaChon = 0;

        public ucNhapKho()
        {
            if (IsDesignerHosted())
            {
                Controls.Clear();
                BackColor = System.Drawing.Color.White;
                Size = new System.Drawing.Size(1132, 640);
                Controls.Add(new Label
                {
                    Text = "[Preview - ucNhapKho]\r\nChạy F5 để thấy UI SunnyUI đầy đủ.",
                    AutoSize = true,
                    Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.Gray,
                    Location = new System.Drawing.Point(18, 18)
                });
                return;
            }
            InitializeComponent();
        }

        private static bool IsDesignerHosted()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime
                || string.Equals(System.Diagnostics.Process.GetCurrentProcess().ProcessName, "devenv",
                                 StringComparison.OrdinalIgnoreCase);
        }

        private void BuildTableChiTiet()
        {
            _dtCT = new DataTable();
            _dtCT.Columns.Add("MaSP", typeof(int));
            _dtCT.Columns.Add("TenSP", typeof(string));
            _dtCT.Columns.Add("SoLuong", typeof(int));
            _dtCT.Columns.Add("DonGia", typeof(decimal));
            _dtCT.Columns.Add("ThanhTien", typeof(decimal), "SoLuong * DonGia");
        }

        private void BindGridCTHeaders()
        {
            if (dgvChiTiet.Columns.Count == 0) return;
            dgvChiTiet.Columns["MaSP"].HeaderText = "Mã SP";
            dgvChiTiet.Columns["TenSP"].HeaderText = "Tên SP";
            dgvChiTiet.Columns["SoLuong"].HeaderText = "SL";
            dgvChiTiet.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvChiTiet.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dgvChiTiet.ColumnHeadersHeight = 34;
        }

        private void ReloadProducts(bool preserveSelection = false)
        {
            int? keep = preserveSelection && _maSpChon != 0 ? _maSpChon : (int?)null;

            _dtSP = _bll.GetSanPham();                 
            dgvSanPham.DataSource = _dtSP;

            if (dgvSanPham.Columns.Contains("MaSP")) dgvSanPham.Columns["MaSP"].HeaderText = "Mã SP";
            if (dgvSanPham.Columns.Contains("TenSP")) dgvSanPham.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            if (dgvSanPham.Columns.Contains("DonGia")) dgvSanPham.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvSanPham.ColumnHeadersHeight = 34;

            if (keep.HasValue)
            {
                foreach (DataGridViewRow r in dgvSanPham.Rows)
                {
                    var drv = r.DataBoundItem as DataRowView;
                    if (drv != null && Convert.ToInt32(drv.Row["MaSP"]) == keep.Value)
                    {
                        r.Selected = true;
                        dgvSanPham.CurrentCell = r.Cells[0];
                        break;
                    }
                }
            }
        }

        private void InitData()
        {
            var dtNcc = _bll.GetNhaCungCap();
            cboNCC.DataSource = dtNcc;
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";

            var dtNv = _bll.GetNhanVien();
            cboNV.DataSource = dtNv;
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";

            ReloadProducts();
            BuildTableChiTiet();
            dgvChiTiet.DataSource = _dtCT;
            BindGridCTHeaders();

            nbSoLuong.Value = 1;
            txtDonGia.Text = "";
            txtTim.Text = "";
        }

        private void ucNhapKho_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var drv = dgvSanPham.Rows[e.RowIndex].DataBoundItem as DataRowView; if (drv == null) return;

            _maSpChon = Convert.ToInt32(drv.Row["MaSP"]);
            _donGiaChon = drv.Row.Table.Columns.Contains("DonGia") ? Convert.ToDecimal(drv.Row["DonGia"]) : 0;
            txtDonGia.Text = _donGiaChon.ToString("0.##");
            nbSoLuong.Value = 1;
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var drv = dgvChiTiet.Rows[e.RowIndex].DataBoundItem as DataRowView; if (drv == null) return;

            nbSoLuong.Value = Math.Max(1, Convert.ToDecimal(drv.Row["SoLuong"]));
            txtDonGia.Text = Convert.ToDecimal(drv.Row["DonGia"]).ToString("0.##");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string kw = (txtTim.Text ?? "").Trim().ToLower();
            if (string.IsNullOrEmpty(kw)) { dgvSanPham.DataSource = _dtSP; return; }

            var query = _dtSP.AsEnumerable().Where(r =>
                (r.Field<string>("TenSP") ?? "").ToLower().Contains(kw) ||
                r.Field<int>("MaSP").ToString().Contains(kw));

            var result = _dtSP.Clone();
            foreach (var r in query) result.ImportRow(r);
            dgvSanPham.DataSource = result;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (_maSpChon == 0) { MsgBox.Warning("Hãy chọn sản phẩm."); return; }
            if (nbSoLuong.Value <= 0) { MsgBox.Warning("Số lượng phải > 0."); return; }

            int soLuong = (int)nbSoLuong.Value;
            decimal donGia = 0m; decimal.TryParse(txtDonGia.Text, out donGia);

            var existed = _dtCT.AsEnumerable().FirstOrDefault(r => r.Field<int>("MaSP") == _maSpChon);
            if (existed != null)
            {
                existed["SoLuong"] = existed.Field<int>("SoLuong") + soLuong;
                if (donGia > 0) existed["DonGia"] = donGia;
            }
            else
            {
                var spRow = _dtSP.AsEnumerable().First(r => r.Field<int>("MaSP") == _maSpChon);
                var newRow = _dtCT.NewRow();
                newRow["MaSP"] = _maSpChon;
                newRow["TenSP"] = spRow.Field<string>("TenSP");
                newRow["SoLuong"] = soLuong;
                newRow["DonGia"] = donGia;
                _dtCT.Rows.Add(newRow);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null) { MsgBox.Warning("Chọn 1 dòng để sửa."); return; }
            var drv = dgvChiTiet.CurrentRow.DataBoundItem as DataRowView; if (drv == null) return;

            var newSL = (int)Math.Max(1, nbSoLuong.Value);
            if (!decimal.TryParse(txtDonGia.Text, out decimal newDG) || newDG < 0)
            { MsgBox.Warning("Đơn giá không hợp lệ."); return; }

            drv.Row["SoLuong"] = newSL;
            drv.Row["DonGia"] = newDG;
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null) return;
            dgvChiTiet.Rows.RemoveAt(dgvChiTiet.CurrentRow.Index);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
            txtGhiChu.Text = "";
            BuildTableChiTiet();
            dgvChiTiet.DataSource = _dtCT;
            BindGridCTHeaders();
            nbSoLuong.Value = 1;
            _maSpChon = 0; _donGiaChon = 0; txtDonGia.Text = "";
            ReloadProducts();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_dtCT.Rows.Count == 0) { MsgBox.Warning("Chưa có dòng chi tiết nào."); return; }
            if (cboNCC.SelectedValue == null || cboNV.SelectedValue == null)
            { MsgBox.Warning("Vui lòng chọn Nhà cung cấp và Nhân viên."); return; }

            try
            {
                var phieu = new PhieuNhapDTO
                {
                    MaNCC = Convert.ToInt32(cboNCC.SelectedValue),
                    MaNV = Convert.ToInt32(cboNV.SelectedValue),
                    NgayLap = dtpNgayLap.Value,
                    GhiChu = txtGhiChu.Text?.Trim() ?? ""
                };

                var cts = new List<CTPNhapDTO>();
                foreach (DataRow r in _dtCT.Rows)
                    cts.Add(new CTPNhapDTO
                    {
                        MaSP = r.Field<int>("MaSP"),
                        SoLuong = r.Field<int>("SoLuong"),
                        DonGia = r.Field<decimal>("DonGia")
                    });

                int newMaPN = _bll.ThemPhieuNhap(phieu, cts);
                MsgBox.Success($"Đã lưu phiếu nhập #{newMaPN}!");
                btnLamMoi_Click(null, null);
            }
            catch (Exception ex)
            {
                MsgBox.Error("Lưu phiếu thất bại: " + ex.Message);
            }
        }
    }
}
