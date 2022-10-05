using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;

namespace APIENDGAME.Interface
{
    interface IKhoaHoc
    {
        public IQueryable<KhoaHoc> GetKhoaHoc();
        public IQueryable<KhoaHoc> GetKHSTRING(string tenkh);
        public KhoaHoc ThemKH(KhoaHoc khoc);
        public KhoaHoc SuaKH(KhoaHoc kh);
        public int XoaKH(int id);
    }
}
