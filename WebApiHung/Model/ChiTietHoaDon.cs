using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHung.Model
{
    public class ChiTietHoaDon
    {
        [Key]
        public int chietiethoadonid { get; set; }
        public int HoaDonid { get; set; }
        public int SanPhamid { get; set; }
        public int SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public float? ThanhTien { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham { get; set; }    

    }
}
