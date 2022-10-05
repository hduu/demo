using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;
namespace APIENDGAME.Interface
{
    interface ITinhTrangHoc
    {
        public IQueryable<TinhTrangHoc> GetDT();
        public TinhTrangHoc ThemDT(TinhTrangHoc tt);
        public TinhTrangHoc SuaDT(TinhTrangHoc tt);
        public int XoaDT(int x);
    }
}
