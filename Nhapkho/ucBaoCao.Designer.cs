using System;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace PresentationLayer
{
    partial class ucBaoCao : UserControl
    {
        private System.ComponentModel.IContainer components = null;

        private UIPanel pnlHeader;
        private UILabel lblTitle;

        private UIPanel pnlFilter;
        private UILabel lblLoai;
        private UIComboBox cboLoai;
        private UILabel lblFrom;
        private UIDatePicker dpFrom;
        private UILabel lblTo;
        private UIDatePicker dpTo;
        private UIButton btnView;
        private UIButton btnExport;
        private UIButton btnPrint;
        private UIButton btnRefresh;

        private UIPanel pnlSummary;
        private UILabel lblSum1;
        private UILabel lblSum2;
        private UILabel lblSum3;

        private UIDataGridView dgv;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region InitializeComponent
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Sunny.UI.UIPanel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.pnlFilter = new Sunny.UI.UIPanel();
            this.lblLoai = new Sunny.UI.UILabel();
            this.cboLoai = new Sunny.UI.UIComboBox();
            this.lblFrom = new Sunny.UI.UILabel();
            this.dpFrom = new Sunny.UI.UIDatePicker();
            this.lblTo = new Sunny.UI.UILabel();
            this.dpTo = new Sunny.UI.UIDatePicker();
            this.btnView = new Sunny.UI.UIButton();
            this.btnExport = new Sunny.UI.UIButton();
            this.btnPrint = new Sunny.UI.UIButton();
            this.btnRefresh = new Sunny.UI.UIButton();
            this.pnlSummary = new Sunny.UI.UIPanel();
            this.lblSum1 = new Sunny.UI.UILabel();
            this.lblSum2 = new Sunny.UI.UILabel();
            this.lblSum3 = new Sunny.UI.UILabel();
            this.dgv = new Sunny.UI.UIDataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlSummary.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1138, 56);
            this.pnlHeader.TabIndex = 3;
            this.pnlHeader.Text = null;
            this.pnlHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Báo cáo - Thống kê";
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lblLoai);
            this.pnlFilter.Controls.Add(this.cboLoai);
            this.pnlFilter.Controls.Add(this.lblFrom);
            this.pnlFilter.Controls.Add(this.dpFrom);
            this.pnlFilter.Controls.Add(this.lblTo);
            this.pnlFilter.Controls.Add(this.dpTo);
            this.pnlFilter.Controls.Add(this.btnView);
            this.pnlFilter.Controls.Add(this.btnExport);
            this.pnlFilter.Controls.Add(this.btnPrint);
            this.pnlFilter.Controls.Add(this.btnRefresh);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.pnlFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlFilter.Location = new System.Drawing.Point(0, 56);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFilter.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlFilter.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.pnlFilter.Size = new System.Drawing.Size(1138, 72);
            this.pnlFilter.TabIndex = 2;
            this.pnlFilter.Text = null;
            this.pnlFilter.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblLoai.Location = new System.Drawing.Point(20, 20);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(48, 23);
            this.lblLoai.TabIndex = 0;
            this.lblLoai.Text = "Loại:";
            // 
            // cboLoai
            // 
            this.cboLoai.DataSource = null;
            this.cboLoai.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboLoai.FillColor = System.Drawing.Color.White;
            this.cboLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboLoai.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboLoai.Items.AddRange(new object[] {
            "Nhập kho",
            "Xuất kho",
            "Tồn kho",
            "Sản phẩm"});
            this.cboLoai.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboLoai.Location = new System.Drawing.Point(70, 16);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLoai.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboLoai.Size = new System.Drawing.Size(160, 32);
            this.cboLoai.SymbolSize = 24;
            this.cboLoai.TabIndex = 1;
            this.cboLoai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboLoai.Watermark = "";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblFrom.Location = new System.Drawing.Point(250, 20);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 23);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Từ:";
            // 
            // dpFrom
            // 
            this.dpFrom.FillColor = System.Drawing.Color.White;
            this.dpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dpFrom.Location = new System.Drawing.Point(285, 16);
            this.dpFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpFrom.MaxLength = 10;
            this.dpFrom.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpFrom.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.dpFrom.Size = new System.Drawing.Size(160, 32);
            this.dpFrom.SymbolDropDown = 61555;
            this.dpFrom.SymbolNormal = 61555;
            this.dpFrom.SymbolSize = 24;
            this.dpFrom.TabIndex = 3;
            this.dpFrom.Text = "2025-10-10";
            this.dpFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpFrom.Value = new System.DateTime(2025, 10, 10, 0, 0, 0, 0);
            this.dpFrom.Watermark = "";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblTo.Location = new System.Drawing.Point(460, 20);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(47, 23);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "Đến:";
            // 
            // dpTo
            // 
            this.dpTo.FillColor = System.Drawing.Color.White;
            this.dpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dpTo.Location = new System.Drawing.Point(510, 16);
            this.dpTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpTo.MaxLength = 10;
            this.dpTo.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpTo.Name = "dpTo";
            this.dpTo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpTo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.dpTo.Size = new System.Drawing.Size(160, 32);
            this.dpTo.SymbolDropDown = 61555;
            this.dpTo.SymbolNormal = 61555;
            this.dpTo.SymbolSize = 24;
            this.dpTo.TabIndex = 5;
            this.dpTo.Text = "2025-10-17";
            this.dpTo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpTo.Value = new System.DateTime(2025, 10, 17, 0, 0, 0, 0);
            this.dpTo.Watermark = "";
            // 
            // btnView
            // 
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnView.Location = new System.Drawing.Point(690, 16);
            this.btnView.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnView.Name = "btnView";
            this.btnView.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.btnView.Size = new System.Drawing.Size(90, 32);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "Xem";
            this.btnView.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExport.Location = new System.Drawing.Point(790, 16);
            this.btnExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.btnExport.Size = new System.Drawing.Size(110, 32);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Xuất CSV";
            this.btnExport.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(910, 16);
            this.btnPrint.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.btnPrint.Size = new System.Drawing.Size(90, 32);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "In";
            this.btnPrint.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(1010, 16);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.btnRefresh.Size = new System.Drawing.Size(110, 32);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // pnlSummary
            // 
            this.pnlSummary.Controls.Add(this.lblSum1);
            this.pnlSummary.Controls.Add(this.lblSum2);
            this.pnlSummary.Controls.Add(this.lblSum3);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummary.FillColor = System.Drawing.Color.White;
            this.pnlSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlSummary.Location = new System.Drawing.Point(0, 128);
            this.pnlSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSummary.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Padding = new System.Windows.Forms.Padding(16);
            this.pnlSummary.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.pnlSummary.Size = new System.Drawing.Size(1138, 80);
            this.pnlSummary.TabIndex = 1;
            this.pnlSummary.Text = null;
            this.pnlSummary.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSum1
            // 
            this.lblSum1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblSum1.Location = new System.Drawing.Point(20, 20);
            this.lblSum1.Name = "lblSum1";
            this.lblSum1.Size = new System.Drawing.Size(350, 40);
            this.lblSum1.TabIndex = 0;
            this.lblSum1.Text = "Tổng phiếu: 0";
            // 
            // lblSum2
            // 
            this.lblSum2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblSum2.Location = new System.Drawing.Point(380, 20);
            this.lblSum2.Name = "lblSum2";
            this.lblSum2.Size = new System.Drawing.Size(350, 40);
            this.lblSum2.TabIndex = 1;
            this.lblSum2.Text = "Tổng SL: 0";
            // 
            // lblSum3
            // 
            this.lblSum3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSum3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.lblSum3.Location = new System.Drawing.Point(740, 20);
            this.lblSum3.Name = "lblSum3";
            this.lblSum3.Size = new System.Drawing.Size(379, 40);
            this.lblSum3.TabIndex = 2;
            this.lblSum3.Text = "Tổng tiền: 0";
            // 
            // dgv
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.ColumnHeadersHeight = 38;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.dgv.Location = new System.Drawing.Point(0, 208);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.SelectedIndex = -1;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1138, 382);
            this.dgv.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.dgv.TabIndex = 0;
            // 
            // ucBaoCao
            // 
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ucBaoCao";
            this.Size = new System.Drawing.Size(1138, 590);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
