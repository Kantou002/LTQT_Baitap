using QuanLyBanHang.Data;
using System.Diagnostics;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyBanHang.Forms;

public partial class frmMain : Form
{
    // Biến ngữ cảnh CSDL
    QLBHDbContext context = new QLBHDbContext();

    // Biến toàn cục lưu trạng thái các form con (MDI)
    frmLoaiSanPham? loaiSanPham = null;
    frmHangSanXuat? hangSanXuat = null;
    frmSanPham? sanPham = null;
    frmKhachHang? khachHang = null;
    frmNhanVien? nhanVien = null;
    frmHoaDon? hoaDon = null;
    frmDangNhap? dangNhap = null;

    string hoVaTenNhanVien = ""; // Tên người dùng hiển thị trên thanh Status

    public frmMain()
    {
        InitializeComponent();
    }

    // ==================== XỬ LÝ KHI TẢI FORM ====================
    private void frmMain_Load(object sender, EventArgs e)
    {
        ChuaDangNhap();
        DangNhap();
    }

    // ==================== HÀM ĐĂNG NHẬP ====================
    private void DangNhap()
    {
    LamLai:
        if (dangNhap == null || dangNhap.IsDisposed)
            dangNhap = new frmDangNhap();

        if (dangNhap.ShowDialog() == DialogResult.OK)
        {
            string tenDangNhap = dangNhap.txtTenDangNhap.Text;
            string matKhau = dangNhap.txtMatKhau.Text;

            if (tenDangNhap.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dangNhap.txtTenDangNhap.Focus();
                goto LamLai;
            }
            else if (matKhau.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dangNhap.txtMatKhau.Focus();
                goto LamLai;
            }
            else
            {
                var nv = context.NhanVien
                    .Where(r => r.TenDangNhap == tenDangNhap)
                    .SingleOrDefault();

                if (nv == null)
                {
                    MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else
                {
                    bool matKhauDung = false;
                    try
                    {
                        matKhauDung = BC.Verify(matKhau, nv.MatKhau);
                    }
                    catch
                    {
                        // Nếu mật khẩu chưa được hash (dữ liệu test) thì so sánh trực tiếp
                        matKhauDung = (matKhau == nv.MatKhau);
                    }

                    if (matKhauDung)
                    {
                        hoVaTenNhanVien = nv.HoVaTen;
                        if (nv.QuyenHan == true)
                            QuyenQuanLy();
                        else if (nv.QuyenHan == false)
                            QuyenNhanVien();
                        else
                            ChuaDangNhap();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtMatKhau.Focus();
                        goto LamLai;
                    }
                }
            }
        }
    }

    // ==================== PHÂN QUYỀN ====================
    public void ChuaDangNhap()
    {
        mnuDangNhap.Enabled = true;
        mnuDangXuat.Enabled = false;
        mnuDoiMatKhau.Enabled = false;
        mnuLoaiSanPham.Enabled = false;
        mnuHangSanXuat.Enabled = false;
        mnuSanPham.Enabled = false;
        mnuKhachHang.Enabled = false;
        mnuNhanVien.Enabled = false;
        mnuHoaDon.Enabled = false;
        mnuThongKeSanPham.Enabled = false;
        mnuThongKeDoanhThu.Enabled = false;
        lblTrangThai.Text = "Chưa đăng nhập.";
    }

    public void QuyenQuanLy()
    {
        mnuDangNhap.Enabled = false;
        mnuDangXuat.Enabled = true;
        mnuDoiMatKhau.Enabled = true;
        mnuLoaiSanPham.Enabled = true;
        mnuHangSanXuat.Enabled = true;
        mnuSanPham.Enabled = true;
        mnuKhachHang.Enabled = true;
        mnuNhanVien.Enabled = true;
        mnuHoaDon.Enabled = true;
        mnuThongKeSanPham.Enabled = true;
        mnuThongKeDoanhThu.Enabled = true;
        lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
    }

    public void QuyenNhanVien()
    {
        mnuDangNhap.Enabled = false;
        mnuDangXuat.Enabled = true;
        mnuDoiMatKhau.Enabled = true;
        mnuLoaiSanPham.Enabled = false;
        mnuHangSanXuat.Enabled = false;
        mnuSanPham.Enabled = false;
        mnuNhanVien.Enabled = false;
        mnuKhachHang.Enabled = true;
        mnuHoaDon.Enabled = true;
        mnuThongKeSanPham.Enabled = true;
        mnuThongKeDoanhThu.Enabled = true;
        lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
    }

    // ==================== XỬ LÝ MENU HỆ THỐNG ====================
    private void mnuDangNhap_Click(object sender, EventArgs e)
    {
        DangNhap();
    }

    private void mnuDangXuat_Click(object sender, EventArgs e)
    {
        foreach (Form child in MdiChildren)
        {
            child.Close();
        }
        ChuaDangNhap();
    }

    private void mnuDoiMatKhau_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Chức năng đổi mật khẩu đang được phát triển.", "Thông báo",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void mnuThoat_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    // ==================== XỬ LÝ MENU QUẢN LÝ ====================
    private void mnuLoaiSanPham_Click(object sender, EventArgs e)
    {
        if (loaiSanPham == null || loaiSanPham.IsDisposed)
        {
            loaiSanPham = new frmLoaiSanPham();
            loaiSanPham.MdiParent = this;
            loaiSanPham.Show();
        }
        else
            loaiSanPham.Activate();
    }

    private void mnuHangSanXuat_Click(object sender, EventArgs e)
    {
        if (hangSanXuat == null || hangSanXuat.IsDisposed)
        {
            hangSanXuat = new frmHangSanXuat();
            hangSanXuat.MdiParent = this;
            hangSanXuat.Show();
        }
        else
            hangSanXuat.Activate();
    }

    private void mnuSanPham_Click(object sender, EventArgs e)
    {
        if (sanPham == null || sanPham.IsDisposed)
        {
            sanPham = new frmSanPham();
            sanPham.MdiParent = this;
            sanPham.Show();
        }
        else
            sanPham.Activate();
    }

    private void mnuKhachHang_Click(object sender, EventArgs e)
    {
        if (khachHang == null || khachHang.IsDisposed)
        {
            khachHang = new frmKhachHang();
            khachHang.MdiParent = this;
            khachHang.Show();
        }
        else
            khachHang.Activate();
    }

    private void mnuNhanVien_Click(object sender, EventArgs e)
    {
        if (nhanVien == null || nhanVien.IsDisposed)
        {
            nhanVien = new frmNhanVien();
            nhanVien.MdiParent = this;
            nhanVien.Show();
        }
        else
            nhanVien.Activate();
    }

    private void mnuHoaDon_Click(object sender, EventArgs e)
    {
        if (hoaDon == null || hoaDon.IsDisposed)
        {
            hoaDon = new frmHoaDon();
            hoaDon.MdiParent = this;
            hoaDon.Show();
        }
        else
            hoaDon.Activate();
    }

    // ==================== XỬ LÝ MENU BÁO CÁO ====================
    private void mnuThongKeSanPham_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Chức năng thống kê sản phẩm đang được phát triển.", "Thông báo",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Chức năng thống kê doanh thu đang được phát triển.", "Thông báo",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // ==================== XỬ LÝ MENU TRỢ GIÚP ====================
    private void mnuHuongDanSuDung_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hướng dẫn sử dụng phần mềm Quản lý bán hàng.\nPhiên bản 1.0", "Hướng dẫn",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void mnuThongTinPhanMem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Phần mềm Quản lý bán hàng\nPhiên bản: 1.0\n© 2024 FIT", "Thông tin phần mềm",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // ==================== XỬ LÝ STATUS STRIP ====================
    private void lblLienKet_Click(object sender, EventArgs e)
    {
        ProcessStartInfo info = new ProcessStartInfo();
        info.FileName = "explorer.exe";
        info.Arguments = "https://fit.agu.edu.vn";
        Process.Start(info);
    }
}
