using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;

namespace APIENDGAME.Interface
{
    interface IHocVien
    {
        public IQueryable<HocVien> GetHocVien(string? ten=null, string? emai= null);
        public HocVien ThemHocVien(HocVien hv);
        public HocVien SuaHocVien(HocVien hv);
        public string ChuanHoa(string str);
        public bool XoaHocVien(int idhocvien);
    }
}
