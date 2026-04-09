using System;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace PresentationLayer
{
    partial class ucDashboard : UserControl
    {
        private System.ComponentModel.IContainer components = null;

        private UIPanel pnlHeader;
        private UILabel lblTitle;

        private UIPanel pnlFilters;
        private UILabel lblMonth;
        private UIComboBox cboMonth;
        private UILabel lblYear;
        private UIComboBox cboYear;
        private UIButton btnRefresh;

        private UIPanel pnlKPI;
        private UIPanel cardSP;
        private UIPanel cardNCC;
        private UIPanel cardNhap;
        private UIPanel cardXuat;
        private UILabel lblSP;
        private UILabel lblNCC;
        private UILabel lblNhap;
        private UILabel lblXuat;

        private UIPanel pnlBottom;
        private UILabel lblLowStock;
        private UIDataGridView dgvLowStock;
        private UILabel lblRecent;
        private UIDataGridView dgvRecent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region InitializeComponent
        private void InitializeComponent()
        {
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
            this.pnlFilters = new Sunny.UI.UIPanel();
            this.lblMonth = new Sunny.UI.UILabel();
            this.cboMonth = new Sunny.UI.UIComboBox();
            this.lblYear = new Sunny.UI.UILabel();
            this.cboYear = new Sunny.UI.UIComboBox();
            this.btnRefresh = new Sunny.UI.UIButton();
            this.pnlKPI = new Sunny.UI.UIPanel();
            this.cardSP = new Sunny.UI.UIPanel();
            this.t1 = new System.Windows.Forms.Label();
            this.lblSP = new Sunny.UI.UILabel();
            this.cardNCC = new Sunny.UI.UIPanel();
            this.t2 = new System.Windows.Forms.Label();
            this.lblNCC = new Sunny.UI.UILabel();
            this.cardNhap = new Sunny.UI.UIPanel();
            this.t3 = new System.Windows.Forms.Label();
            this.lblNhap = new Sunny.UI.UILabel();
            this.cardXuat = new Sunny.UI.UIPanel();
            this.t4 = new System.Windows.Forms.Label();
            this.lblXuat = new Sunny.UI.UILabel();
            this.pnlBottom = new Sunny.UI.UIPanel();
            this.lblLowStock = new Sunny.UI.UILabel();
            this.dgvLowStock = new Sunny.UI.UIDataGridView();
            this.lblRecent = new Sunny.UI.UILabel();
            this.dgvRecent = new Sunny.UI.UIDataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlKPI.SuspendLayout();
            this.cardSP.SuspendLayout();
            this.cardNCC.SuspendLayout();
            this.cardNhap.SuspendLayout();
            this.cardXuat.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.pnlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlHeader.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.pnlHeader.Size = new System.Drawing.Size(1213, 56);
            this.pnlHeader.TabIndex = 3;
            this.pnlHeader.Text = null;
            this.pnlHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(16, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tổng quan hệ thống";
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.lblMonth);
            this.pnlFilters.Controls.Add(this.cboMonth);
            this.pnlFilters.Controls.Add(this.lblYear);
            this.pnlFilters.Controls.Add(this.cboYear);
            this.pnlFilters.Controls.Add(this.btnRefresh);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.pnlFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlFilters.Location = new System.Drawing.Point(0, 56);
            this.pnlFilters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFilters.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlFilters.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.pnlFilters.Size = new System.Drawing.Size(1213, 64);
            this.pnlFilters.TabIndex = 2;
            this.pnlFilters.Text = null;
            this.pnlFilters.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblMonth.Location = new System.Drawing.Point(20, 18);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(65, 23);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Tháng:";
            // 
            // cboMonth
            // 
            this.cboMonth.DataSource = null;
            this.cboMonth.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboMonth.FillColor = System.Drawing.Color.White;
            this.cboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboMonth.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboMonth.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboMonth.Location = new System.Drawing.Point(92, 15);
            this.cboMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMonth.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboMonth.Size = new System.Drawing.Size(100, 32);
            this.cboMonth.SymbolSize = 24;
            this.cboMonth.TabIndex = 1;
            this.cboMonth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboMonth.Watermark = "";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblYear.Location = new System.Drawing.Point(200, 18);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(53, 23);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Năm:";
            // 
            // cboYear
            // 
            this.cboYear.DataSource = null;
            this.cboYear.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboYear.FillColor = System.Drawing.Color.White;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboYear.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboYear.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboYear.Location = new System.Drawing.Point(259, 15);
            this.cboYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboYear.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboYear.Name = "cboYear";
            this.cboYear.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboYear.Size = new System.Drawing.Size(120, 32);
            this.cboYear.SymbolSize = 24;
            this.cboYear.TabIndex = 3;
            this.cboYear.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboYear.Watermark = "";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(409, 15);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.btnRefresh.Size = new System.Drawing.Size(110, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // pnlKPI
            // 
            this.pnlKPI.Controls.Add(this.cardSP);
            this.pnlKPI.Controls.Add(this.cardNCC);
            this.pnlKPI.Controls.Add(this.cardXuat);
            this.pnlKPI.Controls.Add(this.cardNhap);
            this.pnlKPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKPI.FillColor = System.Drawing.Color.White;
            this.pnlKPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlKPI.Location = new System.Drawing.Point(0, 120);
            this.pnlKPI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlKPI.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlKPI.Name = "pnlKPI";
            this.pnlKPI.Padding = new System.Windows.Forms.Padding(16);
            this.pnlKPI.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.pnlKPI.Size = new System.Drawing.Size(1213, 130);
            this.pnlKPI.TabIndex = 1;
            this.pnlKPI.Text = null;
            this.pnlKPI.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardSP
            // 
            this.cardSP.Controls.Add(this.t1);
            this.cardSP.Controls.Add(this.lblSP);
            this.cardSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.cardSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cardSP.Location = new System.Drawing.Point(20, 24);
            this.cardSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardSP.MinimumSize = new System.Drawing.Size(1, 1);
            this.cardSP.Name = "cardSP";
            this.cardSP.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.cardSP.Size = new System.Drawing.Size(292, 90);
            this.cardSP.TabIndex = 0;
            this.cardSP.Text = null;
            this.cardSP.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.t1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.t1.Location = new System.Drawing.Point(16, 10);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(90, 23);
            this.t1.TabIndex = 0;
            this.t1.Text = "Sản phẩm";
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblSP.Location = new System.Drawing.Point(12, 40);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(40, 46);
            this.lblSP.TabIndex = 1;
            this.lblSP.Text = "0";
            // 
            // cardNCC
            // 
            this.cardNCC.Controls.Add(this.t2);
            this.cardNCC.Controls.Add(this.lblNCC);
            this.cardNCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.cardNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cardNCC.Location = new System.Drawing.Point(350, 24);
            this.cardNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardNCC.MinimumSize = new System.Drawing.Size(1, 1);
            this.cardNCC.Name = "cardNCC";
            this.cardNCC.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.cardNCC.Size = new System.Drawing.Size(290, 90);
            this.cardNCC.TabIndex = 1;
            this.cardNCC.Text = null;
            this.cardNCC.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.t2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.t2.Location = new System.Drawing.Point(16, 10);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(119, 23);
            this.t2.TabIndex = 0;
            this.t2.Text = "Nhà cung cấp";
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblNCC.Location = new System.Drawing.Point(12, 40);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(40, 46);
            this.lblNCC.TabIndex = 1;
            this.lblNCC.Text = "0";
            // 
            // cardNhap
            // 
            this.cardNhap.Controls.Add(this.t3);
            this.cardNhap.Controls.Add(this.lblNhap);
            this.cardNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.cardNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cardNhap.Location = new System.Drawing.Point(665, 24);
            this.cardNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardNhap.MinimumSize = new System.Drawing.Size(1, 1);
            this.cardNhap.Name = "cardNhap";
            this.cardNhap.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.cardNhap.Size = new System.Drawing.Size(277, 90);
            this.cardNhap.TabIndex = 2;
            this.cardNhap.Text = null;
            this.cardNhap.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t3
            // 
            this.t3.AutoSize = true;
            this.t3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.t3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.t3.Location = new System.Drawing.Point(16, 10);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(117, 23);
            this.t3.TabIndex = 0;
            this.t3.Text = "Nhập (tháng)";
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblNhap.Location = new System.Drawing.Point(12, 40);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(40, 46);
            this.lblNhap.TabIndex = 1;
            this.lblNhap.Text = "0";
            // 
            // cardXuat
            // 
            this.cardXuat.Controls.Add(this.t4);
            this.cardXuat.Controls.Add(this.lblXuat);
            this.cardXuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.cardXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cardXuat.Location = new System.Drawing.Point(964, 24);
            this.cardXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardXuat.MinimumSize = new System.Drawing.Size(1, 1);
            this.cardXuat.Name = "cardXuat";
            this.cardXuat.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.cardXuat.Size = new System.Drawing.Size(245, 90);
            this.cardXuat.TabIndex = 3;
            this.cardXuat.Text = null;
            this.cardXuat.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t4
            // 
            this.t4.AutoSize = true;
            this.t4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.t4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.t4.Location = new System.Drawing.Point(16, 10);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(111, 23);
            this.t4.TabIndex = 0;
            this.t4.Text = "Xuất (tháng)";
            // 
            // lblXuat
            // 
            this.lblXuat.AutoSize = true;
            this.lblXuat.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblXuat.Location = new System.Drawing.Point(12, 40);
            this.lblXuat.Name = "lblXuat";
            this.lblXuat.Size = new System.Drawing.Size(40, 46);
            this.lblXuat.TabIndex = 1;
            this.lblXuat.Text = "0";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblLowStock);
            this.pnlBottom.Controls.Add(this.dgvLowStock);
            this.pnlBottom.Controls.Add(this.lblRecent);
            this.pnlBottom.Controls.Add(this.dgvRecent);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.FillColor = System.Drawing.Color.White;
            this.pnlBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlBottom.Location = new System.Drawing.Point(0, 250);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBottom.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(16);
            this.pnlBottom.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.pnlBottom.Size = new System.Drawing.Size(1213, 340);
            this.pnlBottom.TabIndex = 0;
            this.pnlBottom.Text = null;
            this.pnlBottom.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLowStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblLowStock.Location = new System.Drawing.Point(20, 16);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(142, 25);
            this.lblLowStock.TabIndex = 0;
            this.lblLowStock.Text = "Hàng tồn thấp";
            // 
            // dgvLowStock
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.dgvLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLowStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvLowStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLowStock.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLowStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLowStock.EnableHeadersVisualStyles = false;
            this.dgvLowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvLowStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.dgvLowStock.Location = new System.Drawing.Point(20, 44);
            this.dgvLowStock.Name = "dgvLowStock";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLowStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLowStock.RowHeadersVisible = false;
            this.dgvLowStock.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvLowStock.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLowStock.SelectedIndex = -1;
            this.dgvLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStock.Size = new System.Drawing.Size(620, 320);
            this.dgvLowStock.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.dgvLowStock.TabIndex = 1;
            // 
            // lblRecent
            // 
            this.lblRecent.AutoSize = true;
            this.lblRecent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblRecent.Location = new System.Drawing.Point(660, 16);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.Size = new System.Drawing.Size(171, 25);
            this.lblRecent.TabIndex = 2;
            this.lblRecent.Text = "Giao dịch gần đây";
            // 
            // dgvRecent
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.dgvRecent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.dgvRecent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRecent.ColumnHeadersHeight = 38;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecent.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRecent.EnableHeadersVisualStyles = false;
            this.dgvRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvRecent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.dgvRecent.Location = new System.Drawing.Point(660, 44);
            this.dgvRecent.Name = "dgvRecent";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecent.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvRecent.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRecent.SelectedIndex = -1;
            this.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecent.Size = new System.Drawing.Size(620, 320);
            this.dgvRecent.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.dgvRecent.TabIndex = 3;
            // 
            // ucDashboard
            // 
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlKPI);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1213, 590);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlKPI.ResumeLayout(false);
            this.cardSP.ResumeLayout(false);
            this.cardSP.PerformLayout();
            this.cardNCC.ResumeLayout(false);
            this.cardNCC.PerformLayout();
            this.cardNhap.ResumeLayout(false);
            this.cardNhap.PerformLayout();
            this.cardXuat.ResumeLayout(false);
            this.cardXuat.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Label t1;
        private Label t2;
        private Label t3;
        private Label t4;
    }
}
