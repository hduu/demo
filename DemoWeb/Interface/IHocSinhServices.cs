using DemoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWeb.Interface
{
    interface IHocSinhServices
    {
        public HocSinh ThemHocSinh(HocSinh hs);

        public IList<HocSinh> GetHocSinh();
        public HocSinh GetHocSinh(int id);
        public HocSinh CapNhapHS(int id, HocSinh hs);
        public void DeleteHocSinh(int id);
    }
}
