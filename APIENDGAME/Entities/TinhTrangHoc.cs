using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIENDGAME.Entities
{
    public class TinhTrangHoc
    {
        [Key]
        public int TinhTrangHocID { get; set; }
        [MaxLength(40)]
        public string TenTinhTrang { get; set; }
        public IList<DangKyHoc> DangKyHocs { get; set; }
    }
}
