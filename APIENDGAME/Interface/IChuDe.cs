using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;

namespace APIENDGAME.Interface
{
    interface IChuDe
    {
        public IQueryable<ChuDe> GetChuDe();
        public ChuDe ThemChuDe(ChuDe cd);
        public ChuDe SuaChuDe(ChuDe cd);
        public void XoaChuDe(int key);
    }
}
