using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHung.Model
{
    public class HoaDon
    {
        [Key]
        public int HoanDonid { get; set; }
        public int? KhachHangid { get; set; }
        public string TenHoaDon { get; set; }
        public string MaGiaoDich { get; set; }
        public string GhiChu { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime? ThoiGianCapNhap { get; set; }
        public float? TongTien { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public  virtual IList<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
