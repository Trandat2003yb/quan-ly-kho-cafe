using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace QL_CaPhe
{
    partial class FrmMain
    {
        private IContainer components = null;
        private UIStyleManager styleManager;
        private UIPanel panelTop;
        private TableLayoutPanel layoutTop;
        private UILabel lblLogo;
        private UILabel lblTitle;
        private UILabel lblUserInfo;
        private UITabControlMenu menuSidebar;
        private ImageList imageListMenu;

        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.styleManager = new Sunny.UI.UIStyleManager(this.components);
            this.panelTop = new Sunny.UI.UIPanel();
            this.layoutTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblLogo = new Sunny.UI.UILabel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.lblUserInfo = new Sunny.UI.UILabel();
            this.menuSidebar = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.panelTop.SuspendLayout();
            this.layoutTop.SuspendLayout();
            this.menuSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.Style = Sunny.UI.UIStyle.Custom;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.layoutTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.panelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Radius = 0;
            this.panelTop.RectColor = System.Drawing.Color.Transparent;
            this.panelTop.Size = new System.Drawing.Size(1280, 60);
            this.panelTop.TabIndex = 1;
            this.panelTop.Text = null;
            this.panelTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutTop
            // 
            this.layoutTop.BackColor = System.Drawing.Color.Transparent;
            this.layoutTop.ColumnCount = 3;
            this.layoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutTop.Controls.Add(this.lblLogo, 0, 0);
            this.layoutTop.Controls.Add(this.lblTitle, 1, 0);
            this.layoutTop.Controls.Add(this.lblUserInfo, 2, 0);
            this.layoutTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTop.Location = new System.Drawing.Point(0, 0);
            this.layoutTop.Name = "layoutTop";
            this.layoutTop.RowCount = 1;
            this.layoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTop.Size = new System.Drawing.Size(1280, 60);
            this.layoutTop.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(3, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(314, 60);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(323, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(634, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "☕ Quản lý kho quán cà phê";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblUserInfo.Location = new System.Drawing.Point(963, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.lblUserInfo.Size = new System.Drawing.Size(314, 60);
            this.lblUserInfo.TabIndex = 2;
            this.lblUserInfo.Text = "Phầm mềm được phát triển bởi Trần Tuấn Đạt \r\n GVHD : An Hồng Sơn";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuSidebar
            // 
            this.menuSidebar.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.menuSidebar.Controls.Add(this.tabPage1);
            this.menuSidebar.Controls.Add(this.tabPage2);
            this.menuSidebar.Controls.Add(this.tabPage3);
            this.menuSidebar.Controls.Add(this.tabPage4);
            this.menuSidebar.Controls.Add(this.tabPage5);
            this.menuSidebar.Controls.Add(this.tabPage6);
            this.menuSidebar.Controls.Add(this.tabPage7);
            this.menuSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuSidebar.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.menuSidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.menuSidebar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuSidebar.ForeColor = System.Drawing.Color.White;
            this.menuSidebar.ImageList = this.imageListMenu;
            this.menuSidebar.ItemSize = new System.Drawing.Size(220, 46);
            this.menuSidebar.Location = new System.Drawing.Point(0, 60);
            this.menuSidebar.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.menuSidebar.Multiline = true;
            this.menuSidebar.Name = "menuSidebar";
            this.menuSidebar.SelectedIndex = 0;
            this.menuSidebar.Size = new System.Drawing.Size(1280, 740);
            this.menuSidebar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.menuSidebar.Style = Sunny.UI.UIStyle.Custom;
            this.menuSidebar.TabIndex = 0;
            this.menuSidebar.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.menuSidebar.TabSelectedForeColor = System.Drawing.Color.White;
            this.menuSidebar.TabUnSelectedForeColor = System.Drawing.Color.Gainsboro;
            this.menuSidebar.SelectedIndexChanged += new System.EventHandler(this.menuSidebar_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.tabPage1.Location = new System.Drawing.Point(221, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1059, 740);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.tabPage2.Location = new System.Drawing.Point(221, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1059, 740);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhập kho";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.tabPage3.Location = new System.Drawing.Point(221, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1059, 740);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xuất kho";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.tabPage4.Location = new System.Drawing.Point(221, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1059, 740);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tồn kho";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.tabPage5.Location = new System.Drawing.Point(221, 0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1059, 740);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Sản phẩm";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.tabPage6.Location = new System.Drawing.Point(221, 0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1059, 740);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Nhà cung cấp";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.tabPage7.Location = new System.Drawing.Point(221, 0);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1059, 740);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Báo cáo";
            // 
            // imageListMenu
            // 
            this.imageListMenu.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListMenu.ImageSize = new System.Drawing.Size(24, 24);
            this.imageListMenu.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMain
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.menuSidebar);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowRect = false;
            this.ShowTitle = false;
            this.Text = "UI";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1280, 800);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelTop.ResumeLayout(false);
            this.layoutTop.ResumeLayout(false);
            this.menuSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}
