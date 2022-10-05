using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIENDGAME.Entities
{
    public class LoaiKhoaHoc
    {
        [Key]
        public int LoaiKhoaHocID { get; set; }
        [MaxLength(30)]
        public string TenLoai { get; set; }
        public IList<KhoaHoc> KhoaHocs { get; set; }
    }
}
