// ucNhaCungCap.Designer.cs
using System;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace PresentationLayer
{
    partial class ucNhaCungCap : UserControl
    {
        private System.ComponentModel.IContainer components = null;

        private UIPanel pnlHeader;
        private UILabel lblTitle;

        private UIPanel pnlSearch;
        private FlowLayoutPanel flpSearch;
        private UILabel lblSearch;
        private UITextBox txtSearch;
        private UIButton btnSearch;
        private UIButton btnRefresh;

        private UIPanel pnlForm;
        private TableLayoutPanel tblForm;
        private UILabel lblMa;
        private UILabel lblTen;
        private UILabel lblLienHe;
        private UILabel lblDT;
        private UILabel lblEmail;
        private UILabel lblDC;
        private UITextBox txtMa;
        private UITextBox txtTen;
        private UITextBox txtLienHe;
        private UITextBox txtDT;
        private UITextBox txtEmail;
        private UITextBox txtDC;

        private UIPanel pnlButtons;
        private FlowLayoutPanel flpButtons;
        private UIButton btnAdd;
        private UIButton btnEdit;
        private UIButton btnDelete;
        private UIButton btnSave;

        private UIDataGridView dgv;

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
            this.pnlHeader = new Sunny.UI.UIPanel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.pnlSearch = new Sunny.UI.UIPanel();
            this.flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearch = new Sunny.UI.UILabel();
            this.txtSearch = new Sunny.UI.UITextBox();
            this.btnSearch = new Sunny.UI.UIButton();
            this.btnRefresh = new Sunny.UI.UIButton();
            this.pnlForm = new Sunny.UI.UIPanel();
            this.tblForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblMa = new Sunny.UI.UILabel();
            this.txtMa = new Sunny.UI.UITextBox();
            this.lblTen = new Sunny.UI.UILabel();
            this.txtTen = new Sunny.UI.UITextBox();
            this.lblLienHe = new Sunny.UI.UILabel();
            this.txtLienHe = new Sunny.UI.UITextBox();
            this.lblDT = new Sunny.UI.UILabel();
            this.txtDT = new Sunny.UI.UITextBox();
            this.lblEmail = new Sunny.UI.UILabel();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.lblDC = new Sunny.UI.UILabel();
            this.txtDC = new Sunny.UI.UITextBox();
            this.pnlButtons = new Sunny.UI.UIPanel();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new Sunny.UI.UIButton();
            this.btnEdit = new Sunny.UI.UIButton();
            this.btnDelete = new Sunny.UI.UIButton();
            this.btnSave = new Sunny.UI.UIButton();
            this.dgv = new Sunny.UI.UIDataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.flpSearch.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.tblForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.flpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1222, 56);
            this.pnlHeader.TabIndex = 4;
            this.pnlHeader.Text = null;
            this.pnlHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý Nhà Cung Cấp";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.flpSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.pnlSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlSearch.Location = new System.Drawing.Point(0, 56);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.pnlSearch.Size = new System.Drawing.Size(1222, 64);
            this.pnlSearch.TabIndex = 3;
            this.pnlSearch.Text = null;
            this.pnlSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpSearch
            // 
            this.flpSearch.Controls.Add(this.lblSearch);
            this.flpSearch.Controls.Add(this.txtSearch);
            this.flpSearch.Controls.Add(this.btnSearch);
            this.flpSearch.Controls.Add(this.btnRefresh);
            this.flpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSearch.Location = new System.Drawing.Point(16, 12);
            this.flpSearch.Name = "flpSearch";
            this.flpSearch.Size = new System.Drawing.Size(1190, 40);
            this.flpSearch.TabIndex = 0;
            this.flpSearch.WrapContents = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblSearch.Location = new System.Drawing.Point(4, 6);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 6, 8, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(83, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(95, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.txtSearch.ShowText = false;
            this.txtSearch.Size = new System.Drawing.Size(280, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearch.Watermark = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(385, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(488, 3);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.btnRefresh.Size = new System.Drawing.Size(110, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.tblForm);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.FillColor = System.Drawing.Color.White;
            this.pnlForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlForm.Location = new System.Drawing.Point(0, 120);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlForm.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(16);
            this.pnlForm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.pnlForm.Size = new System.Drawing.Size(1222, 180);
            this.pnlForm.TabIndex = 2;
            this.pnlForm.Text = null;
            this.pnlForm.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblForm
            // 
            this.tblForm.ColumnCount = 4;
            this.tblForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblForm.Controls.Add(this.lblMa, 0, 0);
            this.tblForm.Controls.Add(this.txtMa, 1, 0);
            this.tblForm.Controls.Add(this.lblTen, 2, 0);
            this.tblForm.Controls.Add(this.txtTen, 3, 0);
            this.tblForm.Controls.Add(this.lblLienHe, 0, 1);
            this.tblForm.Controls.Add(this.txtLienHe, 1, 1);
            this.tblForm.Controls.Add(this.lblDT, 2, 1);
            this.tblForm.Controls.Add(this.txtDT, 3, 1);
            this.tblForm.Controls.Add(this.lblEmail, 0, 2);
            this.tblForm.Controls.Add(this.txtEmail, 1, 2);
            this.tblForm.Controls.Add(this.lblDC, 2, 2);
            this.tblForm.Controls.Add(this.txtDC, 3, 2);
            this.tblForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblForm.Location = new System.Drawing.Point(16, 16);
            this.tblForm.Name = "tblForm";
            this.tblForm.RowCount = 3;
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblForm.Size = new System.Drawing.Size(1190, 148);
            this.tblForm.TabIndex = 0;
            // 
            // lblMa
            // 
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblMa.Location = new System.Drawing.Point(3, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(84, 23);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã NCC:";
            // 
            // txtMa
            // 
            this.txtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMa.Location = new System.Drawing.Point(94, 5);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMa.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMa.Name = "txtMa";
            this.txtMa.Padding = new System.Windows.Forms.Padding(5);
            this.txtMa.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.txtMa.ShowText = false;
            this.txtMa.Size = new System.Drawing.Size(220, 29);
            this.txtMa.TabIndex = 1;
            this.txtMa.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMa.Watermark = "";
            // 
            // lblTen
            // 
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTen.Location = new System.Drawing.Point(598, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(84, 23);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên NCC:";
            // 
            // txtTen
            // 
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTen.Location = new System.Drawing.Point(689, 5);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTen.Name = "txtTen";
            this.txtTen.Padding = new System.Windows.Forms.Padding(5);
            this.txtTen.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.txtTen.ShowText = false;
            this.txtTen.Size = new System.Drawing.Size(400, 29);
            this.txtTen.TabIndex = 3;
            this.txtTen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTen.Watermark = "";
            // 
            // lblLienHe
            // 
            this.lblLienHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLienHe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblLienHe.Location = new System.Drawing.Point(3, 40);
            this.lblLienHe.Name = "lblLienHe";
            this.lblLienHe.Size = new System.Drawing.Size(84, 23);
            this.lblLienHe.TabIndex = 4;
            this.lblLienHe.Text = "Liên hệ:";
            // 
            // txtLienHe
            // 
            this.txtLienHe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLienHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLienHe.Location = new System.Drawing.Point(94, 45);
            this.txtLienHe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLienHe.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtLienHe.Name = "txtLienHe";
            this.txtLienHe.Padding = new System.Windows.Forms.Padding(5);
            this.txtLienHe.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.txtLienHe.ShowText = false;
            this.txtLienHe.Size = new System.Drawing.Size(220, 29);
            this.txtLienHe.TabIndex = 5;
            this.txtLienHe.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtLienHe.Watermark = "";
            // 
            // lblDT
            // 
            this.lblDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblDT.Location = new System.Drawing.Point(598, 40);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(84, 23);
            this.lblDT.TabIndex = 6;
            this.lblDT.Text = "Điện thoại:";
            // 
            // txtDT
            // 
            this.txtDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDT.Location = new System.Drawing.Point(689, 45);
            this.txtDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDT.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDT.Name = "txtDT";
            this.txtDT.Padding = new System.Windows.Forms.Padding(5);
            this.txtDT.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.txtDT.ShowText = false;
            this.txtDT.Size = new System.Drawing.Size(250, 29);
            this.txtDT.TabIndex = 7;
            this.txtDT.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDT.Watermark = "";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblEmail.Location = new System.Drawing.Point(3, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 23);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(94, 85);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.txtEmail.ShowText = false;
            this.txtEmail.Size = new System.Drawing.Size(220, 29);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Watermark = "";
            // 
            // lblDC
            // 
            this.lblDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblDC.Location = new System.Drawing.Point(598, 80);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(84, 23);
            this.lblDC.TabIndex = 10;
            this.lblDC.Text = "Địa chỉ:";
            // 
            // txtDC
            // 
            this.txtDC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDC.Location = new System.Drawing.Point(689, 85);
            this.txtDC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDC.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDC.Name = "txtDC";
            this.txtDC.Padding = new System.Windows.Forms.Padding(5);
            this.txtDC.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.txtDC.ShowText = false;
            this.txtDC.Size = new System.Drawing.Size(400, 29);
            this.txtDC.TabIndex = 11;
            this.txtDC.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDC.Watermark = "";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.flpButtons);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.pnlButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlButtons.Location = new System.Drawing.Point(0, 300);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlButtons.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlButtons.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.pnlButtons.Size = new System.Drawing.Size(1222, 64);
            this.pnlButtons.TabIndex = 1;
            this.pnlButtons.Text = null;
            this.pnlButtons.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnAdd);
            this.flpButtons.Controls.Add(this.btnEdit);
            this.flpButtons.Controls.Add(this.btnDelete);
            this.flpButtons.Controls.Add(this.btnSave);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.Location = new System.Drawing.Point(16, 10);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(1190, 44);
            this.flpButtons.TabIndex = 0;
            this.flpButtons.WrapContents = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(110, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(220, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(330, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.dgv.Location = new System.Drawing.Point(0, 364);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.SelectedIndex = -1;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1222, 226);
            this.dgv.StripeEvenColor = System.Drawing.Color.Empty;
            this.dgv.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.dgv.TabIndex = 0;
            // 
            // ucNhaCungCap
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ucNhaCungCap";
            this.Size = new System.Drawing.Size(1222, 590);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.flpSearch.ResumeLayout(false);
            this.flpSearch.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.tblForm.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.flpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
