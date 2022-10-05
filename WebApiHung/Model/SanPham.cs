using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHung.Model
{
    public class SanPham
    {
        [Key]
        public int Sanphamid { get; set; }
        public int Loaisanphamid { get; set; }
        public string TenSanPham { get; set; }
        public float GiaThanh { get; set; }
        public string MoTa { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public bool DaHetHan { get; set; }
        public int? SoLuongTonKho { get; set; }
        public string KyHieuSanPham { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }     
    }
}
