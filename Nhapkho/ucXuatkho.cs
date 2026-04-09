using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Sunny.UI;
using BLL;
using DTO;

namespace QL_CaPhe
{
    public partial class ucXuatKho : UIUserControl
    {
        private readonly XuatKhoBLL _bll = new XuatKhoBLL();
        private readonly BindingList<CTPXuatDTO> _ct = new BindingList<CTPXuatDTO>();
        private readonly string[] _editableCols = { nameof(CTPXuatDTO.SoLuong), nameof(CTPXuatDTO.DonGia) };

        public ucXuatKho()
        {
            InitializeComponent();

            // Events
            this.Load += ucXuatKho_Load;
            btnTim.Click += btnTim_Click;
            btnThem.Click += btnThem_Click;
            btnLuu.Click += btnLuu_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            bntLamMoi.Click += bntLamMoi_Click;

            // Chi tiết
            dgvChiTiet.ReadOnly = false;
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvChiTiet.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvChiTiet.MultiSelect = false;

            dgvChiTiet.CellParsing += dgvChiTiet_CellParsing;
            dgvChiTiet.CellValidating += dgvChiTiet_CellValidating;
            dgvChiTiet.CellEndEdit += dgvChiTiet_CellEndEdit;
            dgvChiTiet.CellValueChanged += dgvChiTiet_CellValueChanged;
            dgvChiTiet.CellClick += dgvChiTiet_CellClick;
            dgvChiTiet.EditingControlShowing += dgvChiTiet_EditingControlShowing;
            dgvChiTiet.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { e.Handled = true; e.SuppressKeyPress = true; dgvChiTiet.EndEdit(); SendKeys.Send("{TAB}"); }
            };
            txtDon.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
                if (e.KeyChar == (char)Keys.Enter) { e.Handled = true; btnThem.PerformClick(); }
            };
        }

        //Load
        private void ucXuatKho_Load(object sender, EventArgs e)
        {
            try
            {
                var nv = _bll.GetNhanVien();
                cboNhan.DataSource = nv;
                cboNhan.DisplayMember = "HoTen";
                cboNhan.ValueMember = "MaNV";
                dtpNgay.Value = DateTime.Today;

                dgvSanPham.DataSource = _bll.GetSanPham();
                AutoHeaderSanPham();

                dgvChiTiet.DataSource = _ct;
                BuildChiTietColumns();
            }
            catch (Exception ex)
            {
                MsgBox.Error("Không thể tải dữ liệu.\n" + ex.Message);
            }
        }

        //Tìm SP
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string kw = txtSearch.Text.Trim();
                dgvSanPham.DataSource = string.IsNullOrWhiteSpace(kw) ? _bll.GetSanPham() : _bll.SearchSanPham(kw);
                AutoHeaderSanPham();
            }
            catch (Exception ex)
            {
                MsgBox.Error("Lỗi tìm kiếm.\n" + ex.Message);
            }
        }

        //Thêm chi tiết
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) { MsgBox.Warning("Hãy chọn 1 sản phẩm ở bảng bên trái."); return; }

            var row = (dgvSanPham.CurrentRow.DataBoundItem as DataRowView)?.Row;
            if (row == null) return;
            int maSP = Convert.ToInt32(row["MaSP"]);
            string ten = Convert.ToString(row["TenSP"]);
            decimal donGia = ParseLooseOrFallback(txtDon.Text, row["DonGia"]);
            int so = (int)nudSo.Value;
            var exist = _ct.FirstOrDefault(x => x.MaSP == maSP);
            if (exist != null)
            {
                exist.SoLuong += so;
                if (TryParseDecimalLoose(txtDon.Text, out var dgNew)) exist.DonGia = dgNew;
                int r = _ct.IndexOf(exist);
                FocusEditableCell(r, nameof(CTPXuatDTO.SoLuong));
            }
            else
            {
                var item = new CTPXuatDTO { MaSP = maSP, TenSP = ten, SoLuong = so, DonGia = donGia };
                _ct.Add(item);
                int r = _ct.IndexOf(item);
                FocusEditableCell(r, nameof(CTPXuatDTO.SoLuong));
            }
        }

        //Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null) { MsgBox.Warning("Chọn 1 dòng để sửa."); return; }
            var item = dgvChiTiet.CurrentRow.DataBoundItem as CTPXuatDTO;
            if (item == null) return;
            int so = (int)nudSo.Value;
            if (so > 0) item.SoLuong = so;
            if (TryParseDecimalLoose(txtDon.Text, out var dg)) item.DonGia = dg;
            dgvChiTiet.Refresh();
            FocusEditableCell(dgvChiTiet.CurrentRow.Index, nameof(CTPXuatDTO.DonGia));
        }

        //Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null) { MsgBox.Warning("Chọn 1 dòng để xóa."); return; }
            if (MsgBox.Ask("Xóa dòng chi tiết này?"))
            {
                var item = dgvChiTiet.CurrentRow.DataBoundItem as CTPXuatDTO;
                if (item != null) _ct.Remove(item);
            }
        }

        // Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_ct.Count == 0) { MsgBox.Warning("Chưa có chi tiết để lưu."); return; }
            if (cboNhan.SelectedValue == null) { MsgBox.Warning("Chưa chọn nhân viên."); return; }

            try
            {
                var px = new PhieuXuatDTO
                {
                    MaNV = Convert.ToInt32(cboNhan.SelectedValue),
                    NgayLap = dtpNgay.Value,
                    GhiChu = txtGhi.Text.Trim()
                };

                var chitiet = _ct.Select(x => new CTPXuatDTO { MaSP = x.MaSP, SoLuong = x.SoLuong, DonGia = x.DonGia }).ToList();
                int id = _bll.ThemPhieuXuat(px, chitiet);
                MsgBox.Success("Đã lưu phiếu xuất. Mã phiếu: " + id);

                _ct.Clear(); txtDon.Clear(); txtGhi.Clear(); nudSo.Value = 1;
            }
            catch (Exception ex)
            {
                MsgBox.Error("Lỗi lưu phiếu.\n" + ex.Message);
            }
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var name = dgvChiTiet.Columns[e.ColumnIndex].DataPropertyName;
            if (_editableCols.Contains(name)) dgvChiTiet.BeginEdit(true);
        }
        private void dgvChiTiet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvChiTiet.CurrentCell == null) return;
            var name = dgvChiTiet.Columns[dgvChiTiet.CurrentCell.ColumnIndex].DataPropertyName;
            if (_editableCols.Contains(name) && e.Control is TextBox tb)
            {
                tb.KeyPress -= OnlyDigit_KeyPress;
                tb.KeyPress += OnlyDigit_KeyPress;
            }
        }
        private void OnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private static bool TryParseDecimalLoose(object input, out decimal value)
        {
            value = 0m;
            if (input == null) return false;
            var s = input.ToString().Trim();
            s = s.Replace(" ", "").Replace(".", "").Replace(",", "");
            return decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out value);
        }
        private static decimal ParseLooseOrFallback(string text, object fb)
        {
            if (TryParseDecimalLoose(text, out var v)) return v;
            try { return Convert.ToDecimal(fb); } catch { return 0m; }
        }

        private void dgvChiTiet_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            var name = dgvChiTiet.Columns[e.ColumnIndex].DataPropertyName;

            if (name == nameof(CTPXuatDTO.SoLuong))
            {
                if (TryParseDecimalLoose(e.Value, out var v))
                { e.Value = (int)Math.Max(1, Math.Round(v, 0)); e.ParsingApplied = true; }
            }
            else if (name == nameof(CTPXuatDTO.DonGia))
            {
                if (TryParseDecimalLoose(e.Value, out var v))
                { e.Value = Math.Max(0m, v); e.ParsingApplied = true; }
            }
        }

        private void dgvChiTiet_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var name = dgvChiTiet.Columns[e.ColumnIndex].DataPropertyName;

            if (name == nameof(CTPXuatDTO.SoLuong))
            {
                if (!TryParseDecimalLoose(e.FormattedValue, out var v) || v < 1)
                { e.Cancel = true; MsgBox.Warning("Số lượng phải ≥ 1."); }
            }
            else if (name == nameof(CTPXuatDTO.DonGia))
            {
                if (!TryParseDecimalLoose(e.FormattedValue, out var v) || v < 0)
                { e.Cancel = true; MsgBox.Warning("Đơn giá phải ≥ 0."); }
            }
        }

        private void dgvChiTiet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) dgvChiTiet.InvalidateRow(e.RowIndex);
        }
        private void dgvChiTiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) dgvChiTiet.InvalidateRow(e.RowIndex);
        }

        private int GetColIndex(string dataPropOrName)
        {
            var col = dgvChiTiet.Columns.Cast<DataGridViewColumn>()
                .FirstOrDefault(c => c.DataPropertyName == dataPropOrName || c.Name == dataPropOrName);
            return col?.Index ?? -1;
        }
        private void FocusEditableCell(int rowIndex, string dataProp)
        {
            int colIndex = GetColIndex(dataProp);
            if (rowIndex >= 0 && colIndex >= 0 && rowIndex < dgvChiTiet.Rows.Count)
            {
                dgvChiTiet.CurrentCell = dgvChiTiet.Rows[rowIndex].Cells[colIndex];
                dgvChiTiet.BeginEdit(true);
            }
        }

        private void BuildChiTietColumns()
        {
            dgvChiTiet.Columns.Clear();
            var noSep = CultureInfo.InvariantCulture;  

            // Mã SP
            dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = nameof(CTPXuatDTO.MaSP),
                DataPropertyName = nameof(CTPXuatDTO.MaSP),
                HeaderText = "Mã SP",
                ReadOnly = true,
                Width = 70
            });

            // Tên SP
            dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = nameof(CTPXuatDTO.TenSP),
                DataPropertyName = nameof(CTPXuatDTO.TenSP),
                HeaderText = "Tên SP",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // SL
            var colSL = new DataGridViewTextBoxColumn
            {
                Name = nameof(CTPXuatDTO.SoLuong),
                DataPropertyName = nameof(CTPXuatDTO.SoLuong),
                HeaderText = "SL",
                ValueType = typeof(int),
                ReadOnly = false,
                Width = 80
            };
            colSL.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colSL.DefaultCellStyle.FormatProvider = noSep;
            colSL.DefaultCellStyle.Format = "0";          
            dgvChiTiet.Columns.Add(colSL);

            // Đơn giá
            var colDG = new DataGridViewTextBoxColumn
            {
                Name = nameof(CTPXuatDTO.DonGia),
                DataPropertyName = nameof(CTPXuatDTO.DonGia),
                HeaderText = "Đơn giá",
                ValueType = typeof(decimal),
                ReadOnly = false,
                Width = 120
            };
            colDG.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colDG.DefaultCellStyle.FormatProvider = noSep;
            colDG.DefaultCellStyle.Format = "0";          
            dgvChiTiet.Columns.Add(colDG);

            // Thành tiền
            var colTT = new DataGridViewTextBoxColumn
            {
                Name = nameof(CTPXuatDTO.ThanhTien),
                DataPropertyName = nameof(CTPXuatDTO.ThanhTien),
                HeaderText = "Thành tiền",
                ReadOnly = true,
                Width = 140
            };
            colTT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTT.DefaultCellStyle.FormatProvider = noSep;
            colTT.DefaultCellStyle.Format = "0";          
            dgvChiTiet.Columns.Add(colTT);

            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.Columns[nameof(CTPXuatDTO.SoLuong)].ReadOnly = false;
            dgvChiTiet.Columns[nameof(CTPXuatDTO.DonGia)].ReadOnly = false;
        }

        //Header SP trái 
        private void AutoHeaderSanPham()
        {
            if (dgvSanPham.Columns.Count == 0) return;
            SetHeader(dgvSanPham, "MaSP", "Mã SP");
            SetHeader(dgvSanPham, "TenSP", "Tên sản phẩm");
            SetHeader(dgvSanPham, "DonGia", "Đơn giá");
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ReadOnly = true;
        }
        private static void SetHeader(DataGridView grid, string prop, string header)
        {
            var col = grid.Columns.Cast<DataGridViewColumn>()
                .FirstOrDefault(c => c.DataPropertyName == prop || c.Name == prop);
            if (col != null) col.HeaderText = header;
        }

        private void bntLamMoi_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dgvSanPham.DataSource = _bll.GetSanPham();
            AutoHeaderSanPham();
            _ct.Clear();
            dgvChiTiet.Refresh();
            nudSo.Value = 1;
            txtDon.Clear();
            txtGhi.Clear();
            dtpNgay.Value = DateTime.Today;
            if (cboNhan.Items.Count > 0)
                cboNhan.SelectedIndex = 0;
        }
    }
}
