using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWeb.Models
{
    public class Lop
    {
        public int Id { get; set; }
        public string Tenlop { get; set; }
        public int Siso { get; set; }
        public IList<HocSinh> HocSinhs { get; set; }
    }
}
