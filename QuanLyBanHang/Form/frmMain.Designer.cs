namespace QuanLyBanHang.Forms;

partial class frmMain
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.menuStrip = new System.Windows.Forms.MenuStrip();
        this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuLoaiSanPham = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuHangSanXuat = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuBaoCaoThongKe = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuThongKeSanPham = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuThongKeDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuHuongDanSuDung = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuThongTinPhanMem = new System.Windows.Forms.ToolStripMenuItem();
        this.statusStrip = new System.Windows.Forms.StatusStrip();
        this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
        this.lblSpring = new System.Windows.Forms.ToolStripStatusLabel();
        this.lblLienKet = new System.Windows.Forms.ToolStripStatusLabel();
        this.menuStrip.SuspendLayout();
        this.statusStrip.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStrip
        // 
        this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQuanLy,
            this.mnuBaoCaoThongKe,
            this.mnuTroGiup});
        this.menuStrip.Location = new System.Drawing.Point(0, 0);
        this.menuStrip.Name = "menuStrip";
        this.menuStrip.Size = new System.Drawing.Size(1200, 28);
        this.menuStrip.TabIndex = 0;
        this.menuStrip.Text = "menuStrip";
        // 
        // mnuHeThong
        // 
        this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDangXuat,
            this.mnuDoiMatKhau,
            this.toolStripSeparator1,
            this.mnuThoat});
        this.mnuHeThong.Name = "mnuHeThong";
        this.mnuHeThong.Size = new System.Drawing.Size(70, 24);
        this.mnuHeThong.Text = "&Hệ thống";
        // 
        // mnuDangNhap
        // 
        this.mnuDangNhap.Name = "mnuDangNhap";
        this.mnuDangNhap.Size = new System.Drawing.Size(200, 26);
        this.mnuDangNhap.Text = "Đăng &nhập...";
        this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
        // 
        // mnuDangXuat
        // 
        this.mnuDangXuat.Name = "mnuDangXuat";
        this.mnuDangXuat.Size = new System.Drawing.Size(200, 26);
        this.mnuDangXuat.Text = "Đăng &xuất";
        this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
        // 
        // mnuDoiMatKhau
        // 
        this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
        this.mnuDoiMatKhau.Size = new System.Drawing.Size(200, 26);
        this.mnuDoiMatKhau.Text = "Đổi &mật khẩu...";
        this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
        // 
        // toolStripSeparator1
        // 
        this.toolStripSeparator1.Name = "toolStripSeparator1";
        this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
        // 
        // mnuThoat
        // 
        this.mnuThoat.Name = "mnuThoat";
        this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
        this.mnuThoat.Size = new System.Drawing.Size(200, 26);
        this.mnuThoat.Text = "&Thoát";
        this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
        // 
        // mnuQuanLy
        // 
        this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoaiSanPham,
            this.mnuHangSanXuat,
            this.mnuSanPham,
            this.mnuKhachHang,
            this.mnuNhanVien,
            this.mnuHoaDon});
        this.mnuQuanLy.Name = "mnuQuanLy";
        this.mnuQuanLy.Size = new System.Drawing.Size(60, 24);
        this.mnuQuanLy.Text = "&Quản lý";
        // 
        // mnuLoaiSanPham
        // 
        this.mnuLoaiSanPham.Name = "mnuLoaiSanPham";
        this.mnuLoaiSanPham.Size = new System.Drawing.Size(210, 26);
        this.mnuLoaiSanPham.Text = "&Loại sản phẩm...";
        this.mnuLoaiSanPham.Click += new System.EventHandler(this.mnuLoaiSanPham_Click);
        // 
        // mnuHangSanXuat
        // 
        this.mnuHangSanXuat.Name = "mnuHangSanXuat";
        this.mnuHangSanXuat.Size = new System.Drawing.Size(210, 26);
        this.mnuHangSanXuat.Text = "&Hãng sản xuất...";
        this.mnuHangSanXuat.Click += new System.EventHandler(this.mnuHangSanXuat_Click);
        // 
        // mnuSanPham
        // 
        this.mnuSanPham.Name = "mnuSanPham";
        this.mnuSanPham.Size = new System.Drawing.Size(210, 26);
        this.mnuSanPham.Text = "&Sản phẩm...";
        this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);
        // 
        // mnuKhachHang
        // 
        this.mnuKhachHang.Name = "mnuKhachHang";
        this.mnuKhachHang.Size = new System.Drawing.Size(210, 26);
        this.mnuKhachHang.Text = "&Khách hàng...";
        this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
        // 
        // mnuNhanVien
        // 
        this.mnuNhanVien.Name = "mnuNhanVien";
        this.mnuNhanVien.Size = new System.Drawing.Size(210, 26);
        this.mnuNhanVien.Text = "&Nhân viên...";
        this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
        // 
        // mnuHoaDon
        // 
        this.mnuHoaDon.Name = "mnuHoaDon";
        this.mnuHoaDon.Size = new System.Drawing.Size(210, 26);
        this.mnuHoaDon.Text = "Hó&a đơn bán hàng...";
        this.mnuHoaDon.Click += new System.EventHandler(this.mnuHoaDon_Click);
        // 
        // mnuBaoCaoThongKe
        // 
        this.mnuBaoCaoThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongKeSanPham,
            this.mnuThongKeDoanhThu});
        this.mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
        this.mnuBaoCaoThongKe.Size = new System.Drawing.Size(130, 24);
        this.mnuBaoCaoThongKe.Text = "&Báo cáo – Thống kê";
        // 
        // mnuThongKeSanPham
        // 
        this.mnuThongKeSanPham.Name = "mnuThongKeSanPham";
        this.mnuThongKeSanPham.Size = new System.Drawing.Size(220, 26);
        this.mnuThongKeSanPham.Text = "Thống kê &sản phẩm...";
        this.mnuThongKeSanPham.Click += new System.EventHandler(this.mnuThongKeSanPham_Click);
        // 
        // mnuThongKeDoanhThu
        // 
        this.mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
        this.mnuThongKeDoanhThu.Size = new System.Drawing.Size(220, 26);
        this.mnuThongKeDoanhThu.Text = "Thống kê &doanh thu...";
        this.mnuThongKeDoanhThu.Click += new System.EventHandler(this.mnuThongKeDoanhThu_Click);
        // 
        // mnuTroGiup
        // 
        this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDanSuDung,
            this.mnuThongTinPhanMem});
        this.mnuTroGiup.Name = "mnuTroGiup";
        this.mnuTroGiup.Size = new System.Drawing.Size(65, 24);
        this.mnuTroGiup.Text = "&Trợ giúp";
        // 
        // mnuHuongDanSuDung
        // 
        this.mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
        this.mnuHuongDanSuDung.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
        this.mnuHuongDanSuDung.Size = new System.Drawing.Size(260, 26);
        this.mnuHuongDanSuDung.Text = "&Hướng dẫn sử dụng";
        this.mnuHuongDanSuDung.Click += new System.EventHandler(this.mnuHuongDanSuDung_Click);
        // 
        // mnuThongTinPhanMem
        // 
        this.mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
        this.mnuThongTinPhanMem.Size = new System.Drawing.Size(260, 26);
        this.mnuThongTinPhanMem.Text = "&Thông tin phần mềm...";
        this.mnuThongTinPhanMem.Click += new System.EventHandler(this.mnuThongTinPhanMem_Click);
        // 
        // statusStrip
        // 
        this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThai,
            this.lblSpring,
            this.lblLienKet});
        this.statusStrip.Location = new System.Drawing.Point(0, 749);
        this.statusStrip.Name = "statusStrip";
        this.statusStrip.Size = new System.Drawing.Size(1200, 26);
        this.statusStrip.TabIndex = 1;
        this.statusStrip.Text = "statusStrip";
        // 
        // lblTrangThai
        // 
        this.lblTrangThai.Name = "lblTrangThai";
        this.lblTrangThai.Size = new System.Drawing.Size(100, 20);
        this.lblTrangThai.Text = "Chưa đăng nhập.";
        // 
        // lblSpring
        // 
        this.lblSpring.Name = "lblSpring";
        this.lblSpring.Size = new System.Drawing.Size(980, 20);
        this.lblSpring.Spring = true;
        this.lblSpring.Text = "";
        // 
        // lblLienKet
        // 
        this.lblLienKet.IsLink = true;
        this.lblLienKet.Name = "lblLienKet";
        this.lblLienKet.Size = new System.Drawing.Size(80, 20);
        this.lblLienKet.Text = "© 2024 FIT";
        this.lblLienKet.Click += new System.EventHandler(this.lblLienKet_Click);
        // 
        // frmMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1200, 775);
        this.Controls.Add(this.statusStrip);
        this.Controls.Add(this.menuStrip);
        this.IsMdiContainer = true;
        this.MainMenuStrip = this.menuStrip;
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Quản lý bán hàng";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.frmMain_Load);
        this.menuStrip.ResumeLayout(false);
        this.menuStrip.PerformLayout();
        this.statusStrip.ResumeLayout(false);
        this.statusStrip.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
    private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
    private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
    private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
    private System.Windows.Forms.ToolStripMenuItem mnuLoaiSanPham;
    private System.Windows.Forms.ToolStripMenuItem mnuHangSanXuat;
    private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
    private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
    private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
    private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
    private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoThongKe;
    private System.Windows.Forms.ToolStripMenuItem mnuThongKeSanPham;
    private System.Windows.Forms.ToolStripMenuItem mnuThongKeDoanhThu;
    private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
    private System.Windows.Forms.ToolStripMenuItem mnuHuongDanSuDung;
    private System.Windows.Forms.ToolStripMenuItem mnuThongTinPhanMem;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
    private System.Windows.Forms.ToolStripStatusLabel lblSpring;
    private System.Windows.Forms.ToolStripStatusLabel lblLienKet;
}
