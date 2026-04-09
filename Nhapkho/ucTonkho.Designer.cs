using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace QL_CaPhe
{
    partial class ucTonKho
    {
        private System.ComponentModel.IContainer components = null;

        private UIPanel pnlBody;
        private UITextBox txtSearch;
        private UIButton btnSearch;
        private UIButton btnRefresh;
        private UIButton btnAdd;
        private UIButton btnEdit;
        private UIButton btnDelete;
        private UICheckBox chkLowOnly;
        private UIIntegerUpDown numThreshold;
        private UILabel lblSummary;
        private UIDataGridView dgv;
        private UILabel lblMa;
        private UILabel lblTen;
        private UILabel lblSL;
        private UITextBox txtMa;
        private UITextBox txtTen;
        private UIIntegerUpDown numSL;
        private UIButton btnSaveAdjust;
        private UIButton btnClear;

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
            this.pnlBody = new Sunny.UI.UIPanel();
            this.txtSearch = new Sunny.UI.UITextBox();
            this.btnSearch = new Sunny.UI.UIButton();
            this.btnRefresh = new Sunny.UI.UIButton();
            this.chkLowOnly = new Sunny.UI.UICheckBox();
            this.numThreshold = new Sunny.UI.UIIntegerUpDown();
            this.lblSummary = new Sunny.UI.UILabel();
            this.dgv = new Sunny.UI.UIDataGridView();
            this.lblMa = new Sunny.UI.UILabel();
            this.txtMa = new Sunny.UI.UITextBox();
            this.lblTen = new Sunny.UI.UILabel();
            this.txtTen = new Sunny.UI.UITextBox();
            this.lblSL = new Sunny.UI.UILabel();
            this.numSL = new Sunny.UI.UIIntegerUpDown();
            this.btnAdd = new Sunny.UI.UIButton();
            this.btnEdit = new Sunny.UI.UIButton();
            this.btnDelete = new Sunny.UI.UIButton();
            this.btnSaveAdjust = new Sunny.UI.UIButton();
            this.btnClear = new Sunny.UI.UIButton();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.txtSearch);
            this.pnlBody.Controls.Add(this.btnSearch);
            this.pnlBody.Controls.Add(this.btnRefresh);
            this.pnlBody.Controls.Add(this.chkLowOnly);
            this.pnlBody.Controls.Add(this.numThreshold);
            this.pnlBody.Controls.Add(this.lblSummary);
            this.pnlBody.Controls.Add(this.dgv);
            this.pnlBody.Controls.Add(this.lblMa);
            this.pnlBody.Controls.Add(this.txtMa);
            this.pnlBody.Controls.Add(this.lblTen);
            this.pnlBody.Controls.Add(this.txtTen);
            this.pnlBody.Controls.Add(this.lblSL);
            this.pnlBody.Controls.Add(this.numSL);
            this.pnlBody.Controls.Add(this.btnAdd);
            this.pnlBody.Controls.Add(this.btnEdit);
            this.pnlBody.Controls.Add(this.btnDelete);
            this.pnlBody.Controls.Add(this.btnSaveAdjust);
            this.pnlBody.Controls.Add(this.btnClear);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.pnlBody.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBody.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(12);
            this.pnlBody.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.pnlBody.Size = new System.Drawing.Size(1145, 522);
            this.pnlBody.TabIndex = 0;
            this.pnlBody.Text = null;
            this.pnlBody.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearch.ShowText = false;
            this.txtSearch.Size = new System.Drawing.Size(260, 32);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearch.Watermark = "Nhập tên hoặc mã sản phẩm...";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(290, 20);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(380, 20);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chkLowOnly
            // 
            this.chkLowOnly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkLowOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkLowOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkLowOnly.Location = new System.Drawing.Point(531, 20);
            this.chkLowOnly.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkLowOnly.Name = "chkLowOnly";
            this.chkLowOnly.Size = new System.Drawing.Size(224, 29);
            this.chkLowOnly.TabIndex = 3;
            this.chkLowOnly.Text = "Chỉ SP dưới ngưỡng";
            this.chkLowOnly.CheckedChanged += new System.EventHandler(this.chkLowOnly_CheckedChanged);
            // 
            // numThreshold
            // 
            this.numThreshold.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numThreshold.Location = new System.Drawing.Point(770, 20);
            this.numThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numThreshold.Maximum = 100000D;
            this.numThreshold.MinimumSize = new System.Drawing.Size(1, 16);
            this.numThreshold.Name = "numThreshold";
            this.numThreshold.Padding = new System.Windows.Forms.Padding(5);
            this.numThreshold.ShowText = false;
            this.numThreshold.Size = new System.Drawing.Size(80, 32);
            this.numThreshold.TabIndex = 5;
            this.numThreshold.Text = "5";
            this.numThreshold.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.numThreshold.Value = 5;
            // 
            // lblSummary
            // 
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSummary.Location = new System.Drawing.Point(20, 460);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(600, 28);
            this.lblSummary.TabIndex = 6;
            this.lblSummary.Text = "Tổng kết tồn kho";
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 32;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(20, 70);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.SelectedIndex = -1;
            this.dgv.Size = new System.Drawing.Size(830, 380);
            this.dgv.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv.TabIndex = 7;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // lblMa
            // 
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblMa.Location = new System.Drawing.Point(856, 70);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(90, 23);
            this.lblMa.TabIndex = 8;
            this.lblMa.Text = "Mã SP:";
            // 
            // txtMa
            // 
            this.txtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMa.Location = new System.Drawing.Point(964, 70);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMa.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMa.Name = "txtMa";
            this.txtMa.Padding = new System.Windows.Forms.Padding(5);
            this.txtMa.ShowText = false;
            this.txtMa.Size = new System.Drawing.Size(120, 30);
            this.txtMa.TabIndex = 9;
            this.txtMa.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMa.Watermark = "";
            // 
            // lblTen
            // 
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTen.Location = new System.Drawing.Point(856, 110);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(90, 23);
            this.lblTen.TabIndex = 10;
            this.lblTen.Text = "Tên SP:";
            // 
            // txtTen
            // 
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTen.Location = new System.Drawing.Point(964, 110);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTen.Name = "txtTen";
            this.txtTen.Padding = new System.Windows.Forms.Padding(5);
            this.txtTen.ShowText = false;
            this.txtTen.Size = new System.Drawing.Size(120, 30);
            this.txtTen.TabIndex = 11;
            this.txtTen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTen.Watermark = "";
            // 
            // lblSL
            // 
            this.lblSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSL.Location = new System.Drawing.Point(856, 152);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(100, 23);
            this.lblSL.TabIndex = 12;
            this.lblSL.Text = "Số lượng:";
            // 
            // numSL
            // 
            this.numSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numSL.Location = new System.Drawing.Point(964, 150);
            this.numSL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSL.Maximum = 99999D;
            this.numSL.Minimum = -99999D;
            this.numSL.MinimumSize = new System.Drawing.Size(1, 16);
            this.numSL.Name = "numSL";
            this.numSL.Padding = new System.Windows.Forms.Padding(5);
            this.numSL.ShowText = false;
            this.numSL.Size = new System.Drawing.Size(120, 30);
            this.numSL.TabIndex = 13;
            this.numSL.Text = "0";
            this.numSL.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(140)))), ((int)(((byte)(88)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(879, 210);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnAdd.Size = new System.Drawing.Size(90, 34);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(140)))), ((int)(((byte)(88)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEdit.Location = new System.Drawing.Point(994, 210);
            this.btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnEdit.Size = new System.Drawing.Size(90, 34);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.Location = new System.Drawing.Point(879, 260);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDelete.Size = new System.Drawing.Size(90, 34);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveAdjust
            // 
            this.btnSaveAdjust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAdjust.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnSaveAdjust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaveAdjust.Location = new System.Drawing.Point(995, 260);
            this.btnSaveAdjust.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSaveAdjust.Name = "btnSaveAdjust";
            this.btnSaveAdjust.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnSaveAdjust.Size = new System.Drawing.Size(90, 34);
            this.btnSaveAdjust.TabIndex = 17;
            this.btnSaveAdjust.Text = "Lưu";
            this.btnSaveAdjust.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSaveAdjust.Click += new System.EventHandler(this.btnSaveAdjust_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(140)))), ((int)(((byte)(88)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.Location = new System.Drawing.Point(933, 310);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnClear.Size = new System.Drawing.Size(104, 34);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Làm mới ô";
            this.btnClear.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ucTonKho
            // 
            this.Controls.Add(this.pnlBody);
            this.Name = "ucTonKho";
            this.Size = new System.Drawing.Size(1145, 522);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
