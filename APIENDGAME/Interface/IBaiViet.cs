using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;

namespace APIENDGAME.Interface
{
    interface IBaiViet
    {
        public IQueryable<BaiViet> GetBaiViet();
        public BaiViet ThemBaiViet(BaiViet bv);
        public BaiViet SuaBaiViet(BaiViet bv);
        public void XoaBaiViet(int key);
    }
}
