using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIENDGAME.Entities
{
    public class LoaiBaiViet
    {
        [Key]
        public int LoaiBaiVietID { get; set; }
        [MaxLength(50)]
        public string TenLoai { get; set; }
        public IList<ChuDe> ChuDes { get; set; }
    }
}
