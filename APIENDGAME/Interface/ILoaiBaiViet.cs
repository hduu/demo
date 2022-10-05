using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;

namespace APIENDGAME.Interface
{
    interface ILoaiBaiViet
    {
        public IQueryable<LoaiBaiViet> GetLoaiBaiViet();
        public LoaiBaiViet ThemLoaiBV(LoaiBaiViet lbv);
        public LoaiBaiViet SuaLoaiBV(LoaiBaiViet lbv);
        public void XoaLBV(int key);
    }
}
