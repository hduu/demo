using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIENDGAME.Entities
{
    public class DangKyHoc
    {
        [Key]
        public int DangKyHocID { get; set; }
        [Column(TypeName ="date")]
        public DateTime NgayDangKy { get; set; }
        [Column(TypeName = "date")]
        public DateTime NgayBatDau { get; set; }
        [Column(TypeName = "date")]
        public DateTime NgayKetThuc { get; set; }
        public int TinhTrangHocID { get; set; }
        public TinhTrangHoc TinhTrangHoc { get; set; }
        public int HocVienID { get; set; }
        public HocVien HocVien { get; set; }
        public int KhoaHocID { get; set; }
        public KhoaHoc KhoaHoc { get; set; }
        public int TaiKhoaID { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
    }
}
