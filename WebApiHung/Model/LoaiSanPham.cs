using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHung.Model
{
    public class LoaiSanPham
    {
        [Key]
        public int Loaisanphamid { get; set; }
        public string TenLoaiSanPham { get; set; }

    }
}
