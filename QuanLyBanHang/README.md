# Quản Lý Bán Hàng - Buổi 06
## Hướng dẫn cài đặt và chạy project

---

## 📋 Yêu cầu hệ thống
- Windows 10/11
- Visual Studio 2022 (hoặc 2019)
- .NET 6.0 SDK
- SQL Server Express (hoặc SQL Server Developer)
- SQL Server Management Studio (SSMS)

---

## 🚀 Các bước cài đặt

### Bước 1: Mở Project
1. Giải nén file `QuanLyBanHang_Buoi06.zip`
2. Mở file `QuanLyBanHang.sln` bằng Visual Studio

### Bước 2: Cấu hình kết nối CSDL
Mở file `Data\QLBHDbContext.cs`, chỉnh chuỗi kết nối nếu cần:
```
"Server=.\\SQLEXPRESS;Database=QLBH;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True"
```
> Nếu SQL Server của bạn không phải SQLEXPRESS, đổi `.\SQLEXPRESS` thành tên instance của bạn (ví dụ: `.` hoặc `.\SQLSERVER2019`)

### Bước 3: Restore NuGet packages
Mở **Developer Command Prompt for VS 2022** với quyền Administrator, điều hướng đến thư mục project rồi chạy:
```
MSBuild /t:restore
```
Hoặc trong Visual Studio: **Tools → NuGet Package Manager → Restore NuGet Packages**

### Bước 4: Tạo CSDL bằng Migration
Mở **Package Manager Console** trong Visual Studio (Tools → NuGet Package Manager → Package Manager Console) rồi chạy:
```
Update-Database
```
Lệnh này sẽ tạo database `QLBH` với đầy đủ các bảng.

### Bước 5: Nhập dữ liệu mẫu
1. Mở SSMS, kết nối đến SQL Server
2. Mở file `QLBH.sql` (có trong thư mục project)
3. Chạy toàn bộ file SQL

### Bước 6: Chạy ứng dụng
Nhấn **F5** hoặc **Ctrl+F5** trong Visual Studio

---

## 🔐 Tài khoản đăng nhập mặc định

| Tên đăng nhập | Mật khẩu | Quyền hạn |
|---------------|----------|-----------|
| `nhtung`      | `123456` | Quản lý   |
| `tthoa`       | `123456` | Nhân viên |
| `lvkhoa`      | `123456` | Nhân viên |
| `pmtuan`      | `123456` | Nhân viên |

---

## 📁 Cấu trúc project

```
QuanLyBanHang/
├── Data/
│   ├── QLBHDbContext.cs       # Entity Framework DbContext
│   ├── NhanVien.cs            # Entity nhân viên
│   ├── LoaiSanPham.cs         # Entity loại sản phẩm
│   ├── HangSanXuat.cs         # Entity hãng sản xuất
│   ├── SanPham.cs             # Entity sản phẩm
│   ├── KhachHang.cs           # Entity khách hàng
│   ├── HoaDon.cs              # Entity hóa đơn
│   └── ChiTietHoaDon.cs       # Entity chi tiết hóa đơn
├── Forms/
│   ├── frmMain.cs             # Form chính (MDI Parent)
│   ├── frmDangNhap.cs         # Form đăng nhập
│   ├── frmLoaiSanPham.cs      # Quản lý loại sản phẩm
│   ├── frmHangSanXuat.cs      # Quản lý hãng sản xuất
│   ├── frmSanPham.cs          # Quản lý sản phẩm
│   ├── frmKhachHang.cs        # Quản lý khách hàng
│   ├── frmNhanVien.cs         # Quản lý nhân viên
│   ├── frmHoaDon.cs           # Quản lý hóa đơn
│   └── frmHoaDon_ChiTiet.cs   # Chi tiết hóa đơn
├── Migrations/                # EF Migration files
├── QLBH.sql                   # Dữ liệu mẫu
├── Program.cs
└── QuanLyBanHang.csproj
```

---

## ✅ Tính năng đã hoàn thành (Buổi 06)

- **frmMain**: MDI Parent, MenuStrip đầy đủ 4 menu chính, StatusStrip với link FIT
- **Phân quyền**: 3 cấp độ - Chưa đăng nhập / Quản lý / Nhân viên
- **Đăng nhập / Đăng xuất**: BCrypt password hashing
- **frmLoaiSanPham**: CRUD đầy đủ
- **frmHangSanXuat**: CRUD đầy đủ
- **frmSanPham**: CRUD + tìm kiếm theo tên, combobox loại/hãng
- **frmKhachHang**: CRUD đầy đủ
- **frmNhanVien**: CRUD + mã hóa mật khẩu BCrypt
- **frmHoaDon**: Tạo/sửa/xóa hóa đơn + chi tiết nhúng SplitContainer
- **frmHoaDon_ChiTiet**: Thêm/sửa/xóa chi tiết, tự tính thành tiền và tổng tiền

---

## 📦 NuGet Packages sử dụng

| Package | Phiên bản | Mục đích |
|---------|-----------|----------|
| Microsoft.EntityFrameworkCore | 6.0.0 | ORM |
| Microsoft.EntityFrameworkCore.SqlServer | 6.0.0 | SQL Server provider |
| Microsoft.EntityFrameworkCore.Tools | 6.0.0 | Migration tools |
| BCrypt.Net-Next | 4.0.3 | Mã hóa mật khẩu |

---

## ⚠️ Lưu ý

- Mật khẩu trong `QLBH.sql` đã được hash bằng BCrypt với `WorkFactor=11`
- Hash hiện tại trong SQL tương ứng với mật khẩu `123456`
- Khi thêm nhân viên mới qua form, mật khẩu sẽ tự động được hash
- Form chi tiết hóa đơn được nhúng trực tiếp vào frmHoaDon qua SplitContainer
