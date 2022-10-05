using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HocSinhAPI.Entities
{
    public class HocSinh
    {
        public int HocsinhId { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public int? LopId { get; set; }
        public Lop Lop { get; set; }
    }
}
