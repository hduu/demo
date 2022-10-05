using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIENDGAME.Entities
{
    public class TaiKhoan
    {
        [Key]
        public int TaiKhoanID { get; set; }
        [MaxLength(50)]
        public string TenNguoiDung { get; set; }
        [MaxLength(50)]
        public string TenTaiKhoan { get; set; }
        [MaxLength(50)]
        public string MatKhau { get; set; }

        public int QuyenHanID  { get; set; }
        public QuyenHan QuyenHan  { get; set; }
        public IList<DangKyHoc> DangKyHocs { get; set; }
    }
}
