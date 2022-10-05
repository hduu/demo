using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIENDGAME.Entities
{
    public class QuyenHan
    {
        [Key]
        public int QuyenHanID { get; set; }
        [MaxLength(50)]
        public string TenQuyenHan { get; set; }
        public IList<TaiKhoan> TaiKhoans { get; set; }
    }
}
