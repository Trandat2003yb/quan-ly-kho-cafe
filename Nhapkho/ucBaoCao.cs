using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace PresentationLayer
{
    public partial class ucBaoCao : UserControl
    {
        private readonly BaoCaoBLL _bll = new BaoCaoBLL();

        public ucBaoCao()
        {
            InitializeComponent();
            cboLoai.SelectedIndex = 0;
            WireEvents();
            SetupGridAppearance();
            dpFrom.Value = DateTime.Today.AddDays(-7);
            dpTo.Value = DateTime.Today;
            BtnView_Click(null, EventArgs.Empty);
        }
        private void SetupGridAppearance()
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersVisible = false;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 245, 239); 

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(90, 60, 40);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 38;
            dgv.GridColor = Color.FromArgb(190, 170, 150);

            dgv.RowTemplate.Height = 26;
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);  
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void WireEvents()
        {
            btnView.Click += BtnView_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnExport.Click += BtnExport_Click;
            btnPrint.Click += BtnPrint_Click;
            cboLoai.SelectedIndexChanged += CboLoai_SelectedIndexChanged;
        }

        private void CboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool needRange = cboLoai.SelectedIndex == 0 || cboLoai.SelectedIndex == 1; // Nhập / Xuất
            lblFrom.Enabled = dpFrom.Enabled = needRange;
            lblTo.Enabled = dpTo.Enabled = needRange;

            BtnView_Click(null, EventArgs.Empty);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dpFrom.Value = new DateTime(DateTime.Today.Year, 1, 1); 
            dpTo.Value = DateTime.Today;                            
            BtnView_Click(null, EventArgs.Empty);
        }


        private void BtnView_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = null;
                int idx = cboLoai.SelectedIndex;

               
                DateTime from = dpFrom.Value.Date;
                DateTime to = dpTo.Value.Date.AddDays(1).AddTicks(-1);
              
                if (idx == 0)          // Nhập
                    dt = _bll.LayBaoCaoNhap(from, to);
                else if (idx == 1)     // Xuất
                    dt = _bll.LayBaoCaoXuat(from, to);
                else if (idx == 2)     // Tồn
                    dt = _bll.LayBaoCaoTonKho(to);
                else                   // Sản phẩm
                    dt = _bll.LayDanhSachSanPham();

                dgv.DataSource = dt;
                UpdateSummary(dt, idx);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo: " + ex.Message,
                    "Báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSummary(DataTable dt, int idx)
        {
            if (dt == null)
            {
                lblSum1.Text = "Tổng phiếu: 0";
                lblSum2.Text = "Tổng SL: 0";
                lblSum3.Text = "Tổng tiền: 0";
                return;
            }

            if (idx == 0 || idx == 1)   // Nhập / Xuất
            {
                int tongPhieu = dt.Rows.Count;
                decimal tongSL = 0m, tongTien = 0m;

                if (dt.Columns.Contains("TongSL"))
                {
                    foreach (DataRow r in dt.Rows)
                        if (r["TongSL"] != DBNull.Value)
                            tongSL += Convert.ToDecimal(r["TongSL"]);
                }

                if (dt.Columns.Contains("TongTien"))
                {
                    foreach (DataRow r in dt.Rows)
                        if (r["TongTien"] != DBNull.Value)
                            tongTien += Convert.ToDecimal(r["TongTien"]);
                }

                lblSum1.Text = "Tổng phiếu: " + tongPhieu;
                lblSum2.Text = "Tổng SL: " + tongSL;
                lblSum3.Text = "Tổng tiền: " + tongTien.ToString("#,0");
            }
            else if (idx == 2)          // Tồn kho
            {
                int matHang = dt.Rows.Count;
                decimal tongTon = 0m;

                if (dt.Columns.Contains("Ton"))
                {
                    foreach (DataRow r in dt.Rows)
                        if (r["Ton"] != DBNull.Value)
                            tongTon += Convert.ToDecimal(r["Ton"]);
                }

                lblSum1.Text = "Mặt hàng: " + matHang;
                lblSum2.Text = "Tổng tồn: " + tongTon;
                lblSum3.Text = "Tổng tiền: —";
            }
            else                        // Sản phẩm
            {
                lblSum1.Text = "Sản phẩm: " + dt.Rows.Count;
                lblSum2.Text = "—";
                lblSum3.Text = "—";
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dgv.DataSource as DataTable;
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.",
                        "Xuất CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV file (*.csv)|*.csv";
                    sfd.FileName = "baocao.csv";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ExportDataTableToCsv(dt, sfd.FileName);
                        MessageBox.Show("Đã xuất: " + sfd.FileName,
                            "Xuất CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất CSV: " + ex.Message);
            }
        }

        private void ExportDataTableToCsv(DataTable dt, string path)
        {
            StringBuilder sb = new StringBuilder();

            // header
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (i > 0) sb.Append(",");
                sb.Append(dt.Columns[i].ColumnName);
            }
            sb.AppendLine();

            // rows
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (i > 0) sb.Append(",");
                    string v = row[i] == DBNull.Value ? "" : row[i].ToString();
                    v = v.Replace("\"", "\"\"");
                    if (v.Contains(",")) v = "\"" + v + "\"";
                    sb.Append(v);
                }
                sb.AppendLine();
            }

            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog pd = new PrintDialog();
                System.Drawing.Printing.PrintDocument doc =
                    new System.Drawing.Printing.PrintDocument();

                pd.Document = doc;
                int rowIndex = 0;

                doc.PrintPage += (s, ev) =>
                {
                    float y = 20;
                    float x = 20;
                    float lineHeight = 20;
                    Font f = new Font("Segoe UI", 9F);
                    for (int c = 0; c < dgv.Columns.Count; c++)
                    {
                        ev.Graphics.DrawString(dgv.Columns[c].HeaderText, f, Brushes.Black, x, y);
                        x += 150;
                    }
                    y += lineHeight;
                    x = 20;
                    while (rowIndex < dgv.Rows.Count)
                    {
                        DataGridViewRow r = dgv.Rows[rowIndex];
                        if (r.IsNewRow) { rowIndex++; continue; }

                        for (int c = 0; c < dgv.Columns.Count; c++)
                        {
                            string sVal = r.Cells[c].Value == null
                                ? ""
                                : r.Cells[c].Value.ToString();
                            ev.Graphics.DrawString(sVal, f, Brushes.Black, x, y);
                            x += 150;
                        }

                        x = 20;
                        y += lineHeight;

                        if (y > ev.MarginBounds.Bottom - 40)
                        {
                            ev.HasMorePages = true;
                            rowIndex++;
                            return;
                        }
                        rowIndex++;
                    }

                    ev.HasMorePages = false;
                    rowIndex = 0;
                };

                if (pd.ShowDialog() == DialogResult.OK)
                    doc.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in: " + ex.Message);
            }
        }
    }
}
