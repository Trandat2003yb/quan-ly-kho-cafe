using System.Windows.Forms;

namespace QL_CaPhe
{
    partial class ucNhapKho
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Sunny.UI.UIPanel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.pnlInfo = new Sunny.UI.UIPanel();
            this.lblNCC = new Sunny.UI.UILabel();
            this.cboNCC = new Sunny.UI.UIComboBox();
            this.lblNV = new Sunny.UI.UILabel();
            this.cboNV = new Sunny.UI.UIComboBox();
            this.lblNgay = new Sunny.UI.UILabel();
            this.dtpNgayLap = new Sunny.UI.UIDatePicker();
            this.lblGhiChu = new Sunny.UI.UILabel();
            this.txtGhiChu = new Sunny.UI.UITextBox();
            this.pnlBody = new Sunny.UI.UIPanel();
            this.lblSanPham = new Sunny.UI.UILabel();
            this.txtTim = new Sunny.UI.UITextBox();
            this.btnTim = new Sunny.UI.UIButton();
            this.dgvSanPham = new Sunny.UI.UIDataGridView();
            this.lblSoLuong = new Sunny.UI.UILabel();
            this.nbSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblDonGia = new Sunny.UI.UILabel();
            this.txtDonGia = new Sunny.UI.UITextBox();
            this.btnThem = new Sunny.UI.UIButton();
            this.lblChiTiet = new Sunny.UI.UILabel();
            this.dgvChiTiet = new Sunny.UI.UIDataGridView();
            this.btnSua = new Sunny.UI.UIButton();
            this.btnXoaDong = new Sunny.UI.UIButton();
            this.btnLamMoi = new Sunny.UI.UIButton();
            this.btnLuu = new Sunny.UI.UIButton();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.pnlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.RectColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Size = new System.Drawing.Size(1251, 50);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Text = null;
            this.pnlHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "NHẬP KHO";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.lblNCC);
            this.pnlInfo.Controls.Add(this.cboNCC);
            this.pnlInfo.Controls.Add(this.lblNV);
            this.pnlInfo.Controls.Add(this.cboNV);
            this.pnlInfo.Controls.Add(this.lblNgay);
            this.pnlInfo.Controls.Add(this.dtpNgayLap);
            this.pnlInfo.Controls.Add(this.lblGhiChu);
            this.pnlInfo.Controls.Add(this.txtGhiChu);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlInfo.Location = new System.Drawing.Point(0, 50);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.RectColor = System.Drawing.Color.Gainsboro;
            this.pnlInfo.Size = new System.Drawing.Size(1251, 120);
            this.pnlInfo.TabIndex = 1;
            this.pnlInfo.Text = null;
            this.pnlInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNCC
            // 
            this.lblNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblNCC.Location = new System.Drawing.Point(20, 18);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(80, 26);
            this.lblNCC.TabIndex = 0;
            this.lblNCC.Text = "Nhà CC:";
            // 
            // cboNCC
            // 
            this.cboNCC.DataSource = null;
            this.cboNCC.FillColor = System.Drawing.Color.White;
            this.cboNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNCC.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboNCC.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboNCC.Location = new System.Drawing.Point(100, 18);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNCC.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboNCC.Size = new System.Drawing.Size(250, 26);
            this.cboNCC.SymbolSize = 24;
            this.cboNCC.TabIndex = 1;
            this.cboNCC.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboNCC.Watermark = "";
            // 
            // lblNV
            // 
            this.lblNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblNV.Location = new System.Drawing.Point(380, 18);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(100, 26);
            this.lblNV.TabIndex = 2;
            this.lblNV.Text = "Nhân viên:";
            // 
            // cboNV
            // 
            this.cboNV.DataSource = null;
            this.cboNV.FillColor = System.Drawing.Color.White;
            this.cboNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNV.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboNV.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboNV.Location = new System.Drawing.Point(499, 18);
            this.cboNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNV.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboNV.Name = "cboNV";
            this.cboNV.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboNV.Size = new System.Drawing.Size(186, 26);
            this.cboNV.SymbolSize = 24;
            this.cboNV.TabIndex = 3;
            this.cboNV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboNV.Watermark = "";
            // 
            // lblNgay
            // 
            this.lblNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblNgay.Location = new System.Drawing.Point(710, 18);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(60, 26);
            this.lblNgay.TabIndex = 4;
            this.lblNgay.Text = "Ngày:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.FillColor = System.Drawing.Color.White;
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayLap.Location = new System.Drawing.Point(770, 18);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayLap.MaxLength = 10;
            this.dtpNgayLap.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpNgayLap.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayLap.SymbolDropDown = 61555;
            this.dtpNgayLap.SymbolNormal = 61555;
            this.dtpNgayLap.SymbolSize = 24;
            this.dtpNgayLap.TabIndex = 5;
            this.dtpNgayLap.Text = "2025-10-15";
            this.dtpNgayLap.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpNgayLap.Value = new System.DateTime(2025, 10, 15, 4, 8, 22, 607);
            this.dtpNgayLap.Watermark = "";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblGhiChu.Location = new System.Drawing.Point(20, 64);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(86, 26);
            this.lblGhiChu.TabIndex = 6;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.Location = new System.Drawing.Point(122, 64);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Padding = new System.Windows.Forms.Padding(5);
            this.txtGhiChu.ShowText = false;
            this.txtGhiChu.Size = new System.Drawing.Size(848, 26);
            this.txtGhiChu.TabIndex = 7;
            this.txtGhiChu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtGhiChu.Watermark = "";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.lblSanPham);
            this.pnlBody.Controls.Add(this.txtTim);
            this.pnlBody.Controls.Add(this.btnTim);
            this.pnlBody.Controls.Add(this.dgvSanPham);
            this.pnlBody.Controls.Add(this.lblSoLuong);
            this.pnlBody.Controls.Add(this.nbSoLuong);
            this.pnlBody.Controls.Add(this.lblDonGia);
            this.pnlBody.Controls.Add(this.txtDonGia);
            this.pnlBody.Controls.Add(this.btnThem);
            this.pnlBody.Controls.Add(this.lblChiTiet);
            this.pnlBody.Controls.Add(this.dgvChiTiet);
            this.pnlBody.Controls.Add(this.btnSua);
            this.pnlBody.Controls.Add(this.btnXoaDong);
            this.pnlBody.Controls.Add(this.btnLamMoi);
            this.pnlBody.Controls.Add(this.btnLuu);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.FillColor = System.Drawing.Color.White;
            this.pnlBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlBody.Location = new System.Drawing.Point(0, 170);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBody.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.RectColor = System.Drawing.Color.Transparent;
            this.pnlBody.Size = new System.Drawing.Size(1251, 470);
            this.pnlBody.TabIndex = 2;
            this.pnlBody.Text = null;
            this.pnlBody.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSanPham
            // 
            this.lblSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSanPham.Location = new System.Drawing.Point(20, 8);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(150, 24);
            this.lblSanPham.TabIndex = 0;
            this.lblSanPham.Text = "Danh mục sản phẩm";
            // 
            // txtTim
            // 
            this.txtTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTim.Location = new System.Drawing.Point(20, 36);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTim.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTim.Name = "txtTim";
            this.txtTim.Padding = new System.Windows.Forms.Padding(5);
            this.txtTim.ShowText = false;
            this.txtTim.Size = new System.Drawing.Size(380, 26);
            this.txtTim.TabIndex = 1;
            this.txtTim.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTim.Watermark = "Nhập tên/mã sản phẩm...";
            // 
            // btnTim
            // 
            this.btnTim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTim.Location = new System.Drawing.Point(410, 36);
            this.btnTim.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(70, 26);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvSanPham.Location = new System.Drawing.Point(20, 99);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvSanPham.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSanPham.SelectedIndex = -1;
            this.dgvSanPham.Size = new System.Drawing.Size(460, 187);
            this.dgvSanPham.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvSanPham.TabIndex = 3;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSoLuong.Location = new System.Drawing.Point(510, 36);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(70, 26);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // nbSoLuong
            // 
            this.nbSoLuong.Location = new System.Drawing.Point(580, 36);
            this.nbSoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nbSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbSoLuong.Name = "nbSoLuong";
            this.nbSoLuong.Size = new System.Drawing.Size(80, 30);
            this.nbSoLuong.TabIndex = 5;
            this.nbSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDonGia
            // 
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblDonGia.Location = new System.Drawing.Point(680, 36);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(65, 26);
            this.lblDonGia.TabIndex = 6;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDonGia.Location = new System.Drawing.Point(745, 36);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonGia.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Padding = new System.Windows.Forms.Padding(5);
            this.txtDonGia.ShowText = false;
            this.txtDonGia.Size = new System.Drawing.Size(120, 26);
            this.txtDonGia.TabIndex = 7;
            this.txtDonGia.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDonGia.Watermark = "";
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FillColor = System.Drawing.Color.SeaGreen;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(875, 36);
            this.btnThem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 26);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm >>";
            this.btnThem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblChiTiet.Location = new System.Drawing.Point(510, 72);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(150, 24);
            this.lblChiTiet.TabIndex = 9;
            this.lblChiTiet.Text = "Chi tiết phiếu nhập";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvChiTiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvChiTiet.ColumnHeadersHeight = 32;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvChiTiet.EnableHeadersVisualStyles = false;
            this.dgvChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvChiTiet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvChiTiet.Location = new System.Drawing.Point(514, 99);
            this.dgvChiTiet.Name = "dgvChiTiet";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTiet.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvChiTiet.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvChiTiet.SelectedIndex = -1;
            this.dgvChiTiet.Size = new System.Drawing.Size(600, 187);
            this.dgvChiTiet.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvChiTiet.TabIndex = 10;
            this.dgvChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSua.Location = new System.Drawing.Point(514, 311);
            this.btnSua.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 32);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa dòng";
            this.btnSua.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoaDong
            // 
            this.btnXoaDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoaDong.Location = new System.Drawing.Point(610, 311);
            this.btnXoaDong.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoaDong.Name = "btnXoaDong";
            this.btnXoaDong.Size = new System.Drawing.Size(90, 32);
            this.btnXoaDong.TabIndex = 12;
            this.btnXoaDong.Text = "Xóa dòng";
            this.btnXoaDong.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoaDong.Click += new System.EventHandler(this.btnXoaDong_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLamMoi.Location = new System.Drawing.Point(706, 311);
            this.btnLamMoi.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 32);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLuu.Location = new System.Drawing.Point(802, 311);
            this.btnLuu.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 32);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu phiếu";
            this.btnLuu.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 5000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // ucNhapKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ucNhapKho";
            this.Size = new System.Drawing.Size(1251, 640);
            this.Load += new System.EventHandler(this.ucNhapKho_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pnlHeader;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UIPanel pnlInfo;
        private Sunny.UI.UILabel lblNCC;
        private Sunny.UI.UIComboBox cboNCC;
        private Sunny.UI.UILabel lblNV;
        private Sunny.UI.UIComboBox cboNV;
        private Sunny.UI.UILabel lblNgay;
        private Sunny.UI.UIDatePicker dtpNgayLap;
        private Sunny.UI.UILabel lblGhiChu;
        private Sunny.UI.UITextBox txtGhiChu;

        private Sunny.UI.UIPanel pnlBody;
        private Sunny.UI.UILabel lblSanPham;
        private Sunny.UI.UITextBox txtTim;
        private Sunny.UI.UIButton btnTim;
        private Sunny.UI.UIDataGridView dgvSanPham;

        private Sunny.UI.UILabel lblSoLuong;
        private System.Windows.Forms.NumericUpDown nbSoLuong;
        private Sunny.UI.UILabel lblDonGia;
        private Sunny.UI.UITextBox txtDonGia;
        private Sunny.UI.UIButton btnThem;

        private Sunny.UI.UILabel lblChiTiet;
        private Sunny.UI.UIDataGridView dgvChiTiet;

        private Sunny.UI.UIButton btnSua;
        private Sunny.UI.UIButton btnXoaDong;
        private Sunny.UI.UIButton btnLamMoi;
        private Sunny.UI.UIButton btnLuu;

        private System.Windows.Forms.Timer tmrRefresh;
    }
}
