using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIENDGAME.Entities
{
    public class KhoaHoc
    {
        [Key]
        public int KhoaHocID { get; set; }
        [MaxLength(50)]
        public string TenKhoaHoc { get; set; }
        public int ThoiGianHoc { get; set; }
        public string GioiThieu { get; set; }
        public string NoiDung { get; set; }
        public float  HocPhi { get; set; }
        public int SoHocVien { get; set; }
        public int SoLuongMon { get; set; }
        public string HinhAnh { get; set; }
        public int LoaiKhoaHocID { get; set; }
        public LoaiKhoaHoc LoaiKhoaHoc { get; set; }
        public IList<DangKyHoc> DangKyHocs { get; set; }

    }
}
