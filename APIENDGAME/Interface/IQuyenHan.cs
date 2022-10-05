using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIENDGAME.Entities;

namespace APIENDGAME.Interface
{
    interface IQuyenHan
    {
        public IQueryable<QuyenHan> GetQuyenHan();
        public QuyenHan ThemQuyenHan(QuyenHan qh);
        public QuyenHan SuaQuyenHan(QuyenHan qh);
        public void XoaQuyenHan(int key);
    }
}
