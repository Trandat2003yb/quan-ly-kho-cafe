using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PresentationLayer;
using Sunny.UI;

namespace QL_CaPhe
{
    public partial class FrmMain : UIForm
    {
        private readonly Dictionary<string, Control> _ucCache =
            new Dictionary<string, Control>(StringComparer.OrdinalIgnoreCase);
        private string _currentRole = "";
        private UIButton _btnLogout;
        private const string KEY_HOME = "Home";
        private const string KEY_DASHBOARD = "Dashboard";
        private const string KEY_NHAP = "Nhập kho";
        private const string KEY_XUAT = "Xuất kho";
        private const string KEY_TON = "Tồn kho";
        private const string KEY_SANPHAM = "Sản phẩm";
        private const string KEY_NCC = "Nhà cung cấp";
        private const string KEY_BAOCAO = "Báo cáo";

        public FrmMain()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.WindowState = FormWindowState.Maximized;
            this.CenterToScreen();
        }
        private int AddImg(Image img)
        {
            int idx = imageListMenu.Images.Count;
            imageListMenu.Images.Add(img);
            return idx;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            imageListMenu.Images.Clear();
            int idxHome = -1;
            int idxDash = AddImg(Properties.Resources.ic_dashboard_fluent_24);
            int idxImport = AddImg(Properties.Resources.ic_import_fluent_24);
            int idxExport = AddImg(Properties.Resources.ic_export_fluent_24);
            int idxStock = AddImg(Properties.Resources.ic_stock_fluent_24);
            int idxProd = AddImg(Properties.Resources.ic_product_fluent_24);
            int idxSupp = AddImg(Properties.Resources.ic_supplier_fluent_24);
            int idxReport = AddImg(Properties.Resources.ic_report_fluent_24);

            if (menuSidebar.TabPages.Count == 0 ||
                !string.Equals(menuSidebar.TabPages[0].Text, "Home", StringComparison.OrdinalIgnoreCase))
            {
                var tabHome = new TabPage("Home") { BackColor = Color.White };
                menuSidebar.TabPages.Insert(0, tabHome);
            }

            for (int i = 0; i < menuSidebar.TabPages.Count; i++)
            {
                var page = menuSidebar.TabPages[i];
                page.BackColor = Color.White;

                switch (page.Text.Trim())
                {
                    case "Home": page.ImageIndex = idxHome; break;
                    case "Dashboard": page.ImageIndex = idxDash; break;
                    case "Nhập kho": page.ImageIndex = idxImport; break;
                    case "Xuất kho": page.ImageIndex = idxExport; break;
                    case "Tồn kho": page.ImageIndex = idxStock; break;
                    case "Sản phẩm": page.ImageIndex = idxProd; break;
                    case "Nhà cung cấp": page.ImageIndex = idxSupp; break;
                    case "Báo cáo": page.ImageIndex = idxReport; break;
                    default: page.ImageIndex = -1; break;
                }

                if (page.Controls.Count == 0)
                {
                    var lbl = new UILabel
                    {
                        Dock = DockStyle.Fill,
                        Text = $"[{page.Text}]",
                        Font = new Font("Segoe UI", 16F),
                        ForeColor = Color.DimGray,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    page.Controls.Add(lbl);
                }
            }
            menuSidebar.SelectedIndex = 0;
            var home = GetOrCreateUC(KEY_HOME, () => new ucHome());
            ShowOnTab(0, home);

            if (Program.CurrentUser != null)
            {
                BindUser(Program.CurrentUser.HoTen, Program.CurrentUser.QuyenHan);
            }
            AddLogoutButtonToSidebar();
        }

        public void BindUser(string hoTen, string quyen)
        {
            _currentRole = (quyen ?? "").Trim();
            lblUserInfo.Text = $"Phầm mềm được phát triển bởi Trần Tuấn Đạt\r\n GVHD : An Hồng Sơn";
            ApplyPermission();
        }

        private void menuSidebar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = menuSidebar.SelectedIndex;
            if (idx < 0) return;

            string tabText = menuSidebar.TabPages[idx].Text.Trim();

            // Phân quyền
            bool isStaff = string.Equals(_currentRole, "Staff", StringComparison.OrdinalIgnoreCase);

            if (isStaff)
            {
                if (tabText == "Sản phẩm" || tabText == "Nhà cung cấp" || tabText == "Báo cáo"
                    || tabText == "Dashboard")
                {
                    MessageBox.Show("Bạn không có quyền truy cập chức năng này.",
                                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    foreach (TabPage page in menuSidebar.TabPages)
                    {
                        if (page.Text.Trim() == "Home")
                        {
                            menuSidebar.SelectedTab = page;
                            break;
                        }
                    }
                    return;
                }
            }

            Control uc;
            switch (tabText)
            {
                case "Home":
                    uc = GetOrCreateUC(KEY_HOME, () => new ucHome());
                    break;

                case "Dashboard":
                    uc = GetOrCreateUC(KEY_DASHBOARD, () => new ucDashboard());
                    break;

                case "Nhập kho":
                    uc = GetOrCreateUC(KEY_NHAP, () => new ucNhapKho());
                    break;

                case "Xuất kho":
                    uc = GetOrCreateUC(KEY_XUAT, () => new ucXuatKho());
                    break;

                case "Tồn kho":
                    uc = GetOrCreateUC(KEY_TON, () => new ucTonKho());
                    break;

                case "Sản phẩm":
                    uc = GetOrCreateUC(KEY_SANPHAM, () => new ucSanPham());
                    break;

                case "Nhà cung cấp":
                    uc = GetOrCreateUC(KEY_NCC, () => new ucNhaCungCap());
                    break;

                case "Báo cáo":
                    uc = GetOrCreateUC(KEY_BAOCAO, () => new ucBaoCao());
                    break;

                default:
                    uc = MakeInfoLabel("Chức năng đang phát triển…");
                    break;
            }

            ShowOnTab(idx, uc);
        }

        private Control GetOrCreateUC(string key, Func<Control> factory)
        {
            if (_ucCache.TryGetValue(key, out var ctl) && ctl != null && !ctl.IsDisposed)
                return ctl;

            ctl = factory();
            ctl.Dock = DockStyle.Fill;
            ctl.Margin = new Padding(0);
            _ucCache[key] = ctl;
            return ctl;
        }

        private void ShowOnTab(int pageIndex, Control ctl)
        {
            if (pageIndex < 0 || pageIndex >= menuSidebar.TabPages.Count || ctl == null) return;

            var page = menuSidebar.TabPages[pageIndex];
            page.SuspendLayout();
            page.Controls.Clear();
            page.Controls.Add(ctl);
            page.ResumeLayout();
        }

        private Control MakeInfoLabel(string text)
        {
            var holder = new UserControl { BackColor = Color.White, Dock = DockStyle.Fill };
            var lbl = new UILabel
            {
                Dock = DockStyle.Fill,
                Text = $"[{text}]",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.DimGray,
                TextAlign = ContentAlignment.MiddleCenter
            };
            holder.Controls.Add(lbl);
            return holder;
        }

        private void ApplyPermission()
        {
            bool isAdmin = _currentRole.Equals("Admin", StringComparison.OrdinalIgnoreCase);

            if (isAdmin)
            {
                return;
            }

            var allowed = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Home",
                "Nhập kho",
                "Xuất kho",
                "Tồn kho"
            };

            for (int i = menuSidebar.TabPages.Count - 1; i >= 0; i--)
            {
                var page = menuSidebar.TabPages[i];
                var text = page.Text.Trim();

                if (!allowed.Contains(text))
                {
                    menuSidebar.TabPages.RemoveAt(i);
                }
            }

            if (menuSidebar.TabPages.Count > 0)
                menuSidebar.SelectedIndex = 0;
        }
        private void AddLogoutButtonToSidebar()
        {
            var btn = new UIButton
            {
                Text = "Đăng xuất",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Height = 40,  
                Width = 120,  
                Radius = 5
            };
            btn.FillColor = Color.FromArgb(220, 53, 69);
            btn.FillHoverColor = Color.FromArgb(200, 35, 51);
            btn.FillPressColor = Color.FromArgb(180, 30, 45);
            btn.RectColor = Color.FromArgb(220, 53, 69);
            btn.ForeColor = Color.White;

            int leftPadding = menuSidebar.Left + 50;  
            int bottom = menuSidebar.Bottom - btn.Height - 15;

            btn.Location = new Point(leftPadding, bottom);

            btn.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;

            btn.Click += (s, e) =>
            {
                if (MessageBox.Show("Bạn có chắc muốn đăng xuất?",
                                    "Đăng xuất",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            };

            this.Controls.Add(btn);
            btn.BringToFront();
        }
    }
}
