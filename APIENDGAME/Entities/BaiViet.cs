using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIENDGAME.Entities
{
    public class BaiViet
    {
        [Key]
        public int BaiVietID { get; set; }
        [MaxLength(50)]
        public string TenBaiViet { get; set; }
        [Column(TypeName ="date")]
        public DateTime ThoiGianTao { get; set; }
        [MaxLength(50)]
        public string TacGia { get; set; }
        public string NoiDung { get; set; }
        [MaxLength(1000)]
        public string NoiDungNgan { get; set; }
        public string HinhAnh { get; set; }
        public int ChuDeID { get; set; }
        public ChuDe ChuDe { get; set; }
        public int TaiKhoanID { get; set; }
        public TaiKhoan TaiKhoan { get; set; }

    }
}
