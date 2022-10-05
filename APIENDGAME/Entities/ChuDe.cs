using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIENDGAME.Entities
{
    public class ChuDe
    {
        [Key]
        public int ChuDeID { get; set; }
        [MaxLength(50)]
        public string TenChuDe { get; set; }
        public string NoiDung { get; set; }
        public int LoaiBaiVietID { get; set; }
        public LoaiBaiViet LoaiBaiViet { get; set; }
        public IList<BaiViet> BaiViets { get; set; }
    }
}
