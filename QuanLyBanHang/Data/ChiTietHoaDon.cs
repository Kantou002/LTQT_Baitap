using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Data;

public class ChiTietHoaDon
{
    [Key]
    public int MaChiTiet { get; set; }

    public int SoLuong { get; set; }

    [Column(TypeName = "decimal(18,0)")]
    public decimal DonGia { get; set; }

    [Column(TypeName = "decimal(18,0)")]
    public decimal ThanhTien { get; set; }

    public int? MaHoaDon { get; set; }
    public HoaDon? HoaDon { get; set; }

    public int? MaSanPham { get; set; }
    public SanPham? SanPham { get; set; }
}
