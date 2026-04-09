using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using BLL;

namespace PresentationLayer
{
    public partial class ucDashboard : UserControl
    {
        private readonly DashboardBLL _bll = new DashboardBLL();
        private PictureBox _placeholder;

        public ucDashboard()
        {
            InitializeComponent();
            InitFilters();
            WireEvents();
            ConfigureGrids();
            InitPlaceholder();
            SafeLoadAll();
        }

        private void InitFilters()
        {
            // Tháng
            cboMonth.Items.Clear();
            for (int m = 1; m <= 12; m++) cboMonth.Items.Add(m);
            // Năm năm gần nhất
            int year = DateTime.Today.Year;
            cboYear.Items.Clear();
            for (int y = year - 4; y <= year; y++) cboYear.Items.Add(y);
            cboMonth.SelectedItem = DateTime.Today.Month;
            cboYear.SelectedItem = year;
        }

        private void WireEvents()
        {
            btnRefresh.Click += (_, __) => SafeLoadAll();
            cboMonth.SelectedIndexChanged += (_, __) => SafeLoadKPI();
            cboYear.SelectedIndexChanged += (_, __) => SafeLoadKPI();
        }

        private void ConfigureGrids()
        {
            dgvLowStock.ReadOnly = true;
            dgvLowStock.AllowUserToAddRows = false;
            dgvLowStock.AllowUserToDeleteRows = false;
            dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecent.ReadOnly = true;
            dgvRecent.AllowUserToAddRows = false;
            dgvRecent.AllowUserToDeleteRows = false;
            dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void InitPlaceholder()
        {
            string imgPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "dashboard.png");
            _placeholder = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                Visible = false
            };
            try
            {
                if (System.IO.File.Exists(imgPath))
                    _placeholder.Image = Image.FromFile(imgPath);
            }
            catch {}

            this.Controls.Add(_placeholder);
            _placeholder.BringToFront();
        }

        private void SafeLoadAll()
        {
            try
            {
                LoadKPI();
                LoadLowStock();
                LoadRecent();
                TogglePlaceholderByData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải Dashboard: " + ex.Message, "Dashboard",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SafeLoadKPI()
        {
            try
            {
                LoadKPI();
                TogglePlaceholderByData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải KPI: " + ex.Message, "Dashboard",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Load Data
        private void LoadKPI()
        {
            var counts = _bll.LayDemCoBan();
            lblSP.Text = counts.SanPham.ToString();
            lblNCC.Text = counts.NhaCungCap.ToString();
            // Tổng tháng
            if (cboMonth.SelectedItem == null || cboYear.SelectedItem == null)
                return;

            int month = Convert.ToInt32(cboMonth.SelectedItem);
            int year = Convert.ToInt32(cboYear.SelectedItem);

            var totals = _bll.LayTongThang(year, month);
            lblNhap.Text = FormatMoney(totals.TongNhap);
            lblXuat.Text = FormatMoney(totals.TongXuat);
        }

        private void LoadLowStock()
        {
            // Top 10, ngưỡng cảnh báo tồn <= 10
            DataTable dt = _bll.LayTonThap(10, 10);
            dgvLowStock.DataSource = dt;
            if (dt == null) return;
            SetHeader(dgvLowStock, "MaSP", "Mã SP");
            SetHeader(dgvLowStock, "TenSP", "Tên SP");
            SetHeader(dgvLowStock, "DonGia", "Đơn giá");
            SetHeader(dgvLowStock, "Ton", "Tồn");
            // Format đơn giá
            if (dgvLowStock.Columns.Contains("DonGia"))
                dgvLowStock.Columns["DonGia"].DefaultCellStyle.Format = "N0";
        }

        private void LoadRecent()
        {
            DataTable dt = _bll.LayHoatDongGanDay(8);
            dgvRecent.DataSource = dt;
            if (dt == null) return;
            SetHeader(dgvRecent, "MaPhieu", "Mã phiếu");
            SetHeader(dgvRecent, "NgayLap", "Ngày lập");
            SetHeader(dgvRecent, "NhanVien", "Nhân viên");
            SetHeader(dgvRecent, "TongTien", "Tổng tiền");
            SetHeader(dgvRecent, "Loai", "Loại");
            if (dgvRecent.Columns.Contains("NgayLap"))
                dgvRecent.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            if (dgvRecent.Columns.Contains("TongTien"))
                dgvRecent.Columns["TongTien"].DefaultCellStyle.Format = "N0";
        }

        private static void SetHeader(DataGridView grid, string colName, string header)
        {
            if (grid.Columns.Contains(colName))
                grid.Columns[colName].HeaderText = header;
        }

        private static string FormatMoney(decimal value)
        {
            return value.ToString("#,0", CultureInfo.InvariantCulture);
        }

        private void TogglePlaceholderByData()
        {
            bool kpiHasAny =
                lblSP.Text != "0" ||
                lblNCC.Text != "0" ||
                lblNhap.Text != "0" ||
                lblXuat.Text != "0";

            bool gridsHaveAny =
                (dgvLowStock.DataSource is DataTable dt1 && dt1.Rows.Count > 0) ||
                (dgvRecent.DataSource is DataTable dt2 && dt2.Rows.Count > 0);

            _placeholder.Visible = !(kpiHasAny || gridsHaveAny);
            if (_placeholder.Visible) _placeholder.BringToFront();
        }
    }
}
