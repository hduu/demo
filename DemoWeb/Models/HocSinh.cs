using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWeb.Models
{
    public class HocSinh
    {
        public int Id { get; set; }
        public string Hoten { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? LopId { get; set; }
        public Lop Lop { get; set; }

    }
}
