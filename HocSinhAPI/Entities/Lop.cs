using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HocSinhAPI.Entities
{
    public class Lop
    {
        public int LopId { get; set; }
        public string Tenlop { get; set; }
        public int Siso { get; set; }
        public IList<HocSinh> HocSinhs { get; set; }
    }
}
